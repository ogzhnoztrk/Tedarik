using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Tedarik.Business.Abstract.Auth;
using Tedarik.Core.Helpers.Security.Hashing;
using Tedarik.Core.Models;
using Tedarik.DataAccess.Repositories.Persistence;
using Tedarik.Entities.Concrete.Auth;
using Tedarik.Models.DTOs.Kullanici;

namespace Tedarik.Business.Concrete.Auth
{
    public class AuthManager : IAuthService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly JwtModel jwtModel;
        //private readonly ILogger<AuthService> _logger;
        public AuthManager(IUnitOfWork unitOfWork, IOptions<JwtModel> options/*, ILogger<AuthService> logger*/)
        {
            _unitOfWork = unitOfWork;
            jwtModel = options.Value;
            //  _logger = logger;
        }

        public Result<Kullanici> Register(KullaniciKayitDto userRegisterDto)
        {
            var isExist = IsUserExist(userRegisterDto.Eposta);
            if (!isExist) //kullanıcı mevcut ise
            {
                //_logger.LogError("Bu kullanıcı adı alınmış");
                return new Result<Kullanici>(((int)HttpStatusCode.Conflict), "Bu kullanıcı adı alınmış", null);
            }
            else
            {
                byte[] passwordHash, passwordSalt;
                //şifreyi hashleme
                HashingHelper.CreatePasswordHash(userRegisterDto.Sifre, out passwordHash, out passwordSalt);
                Kullanici kullanici = new Kullanici
                {
                    Id = Guid.NewGuid(),
                    KullaniciAdi = userRegisterDto.Adi,
                    KullaniciSoyadi = userRegisterDto.Soyadi,    
                    KullaniciPosta = userRegisterDto.Eposta,
                    SifreHash = passwordHash,
                    SifreSalt = passwordSalt,
                    
                };

                //_logger.LogInformation("Kullanıcı Eklendi");
                return _unitOfWork.Kullanici.Add(kullanici);
            }
        }

        public Result<Kullanici> Login(KullaniciGirisDto kullaniciGirisDto)
        {
            var kullanici = _unitOfWork.Kullanici.GetFirstOrDefault(x => x.KullaniciPosta == kullaniciGirisDto.Eposta).Data;
            if (kullanici == null)//kullanıcı Mevcur değilse
            {
                //_logger.LogError("Kullanıcı Bulunamadı");
                return new Result<Kullanici>((int)HttpStatusCode.BadRequest, "Kullanici bulunamadı", null);
            }
            if (!HashingHelper.VerifyPasswordHash(kullaniciGirisDto.Sifre, kullanici.SifreHash, kullanici.SifreSalt))
            {
                //_logger.LogError("Şifre Veya Kullanıcı Adı Yanlış");
                return new Result<Kullanici>((int)HttpStatusCode.BadRequest, "Şifre veya kullanıcı adi yanlış", null);
            }
            else
            {
                //_logger.LogInformation("Giriş Yapıldı");
                return new Result<Kullanici>((int)HttpStatusCode.OK, "Giriş Yapıldi", kullanici);

            }

        }

        public Result<string> GenerateToken(Kullanici kullanici)
        {
            var yetkiler = _unitOfWork.Yetki.GetAll(x => x.KullaniciId == kullanici.Id, "Modul").Data;
            var moduller = Moduller(yetkiler);
            var generateToken = GenerateAccessToken(kullanici.Id.ToString(), kullanici.KullaniciAdi, kullanici.KullaniciSoyadi, kullanici.AktifMi, moduller);
            var token = new JwtSecurityTokenHandler().WriteToken(generateToken);
            return new Result<string>((int)HttpStatusCode.OK, "Giris Başarılı", token);
        }



        #region
        // Generating token based on user information
        private JwtSecurityToken GenerateAccessToken(string kullaniciId ,string kulaniciAdi, string kullaniciSoyadi, bool aktifMi, string moduller)
        {
            // Create user claims
            var claims = new List<Claim>
            {
               // new Claim(ClaimTypes.Name, kullaniciAdi),
                new Claim("kullanici_id", kullaniciId),
                new Claim("kullanici_adi", kulaniciAdi),
                new Claim("kullanici_soyadi", kullaniciSoyadi),      
                new Claim("aktif_mi", aktifMi.ToString()),
                new Claim(ClaimTypes.Role, moduller)
            };

            // JWT'nin oluşturulması
            var issuer = jwtModel.Issuer;
            var audience = jwtModel.Audience;
            var key = Encoding.ASCII.GetBytes(jwtModel.Key);


            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddHours(6),
                Issuer = issuer,
                Audience = audience,
                SigningCredentials = new SigningCredentials
                (new SymmetricSecurityKey(key),
                SecurityAlgorithms.HmacSha512Signature)
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);

            var stringToken = tokenHandler.WriteToken(token);



            return token as JwtSecurityToken;
        }




        /// <summary>
        /// kkullanıcı yoksa false varsa true döner
        /// </summary>
        /// <param name="kullaniciAdi"></param>
        /// <returns></returns>
        private bool IsUserExist(string eposta)
        {
            var kullanici = _unitOfWork.Kullanici.GetFirstOrDefault(x => x.KullaniciPosta == eposta).Data;
            if (kullanici != null)
            {
                return false;

            }
            return true;

        }



        private string Moduller(ICollection<Yetki> yetkiler)
        {
            List<string> moduller = new List<string>();
            foreach (var yetki in yetkiler)
            {
                moduller.Add(yetki.Modul!.ModulNo.ToString()!);
            }
            var result = String.Join(",", moduller);
            return result;
        }



        #endregion


    }
}
