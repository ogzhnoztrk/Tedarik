using Tedarik.Core.Models;

namespace Tedarik.Web.Helpers
{
    /// <summary>
    /// <typeparamref name="T"/> bir return type, <typeparamref name="Y"/> ise bir postModel
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="Y"></typeparam>
    public interface IHttpService<T, Y> /*where T : class where Y: class*/
    {
        /// <summary>
        /// <typeparamref name="T"/> bir return type, <typeparamref name="Y"/> ise bir postModel
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="Y"></typeparam>
        Task<Result<T>> PostAsync(string endpoint, Y postModel);
        /// <summary>
        /// <typeparamref name="T"/> bir return type, <typeparamref name="Y"/> ise bir postModel
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="Y"></typeparam>
        Task<Result<T>> GetAsync(string endpoint);
        /// <summary>
        /// <typeparamref name="T"/> bir return type, <typeparamref name="Y"/> ise bir postModel
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="Y"></typeparam>
        Task<Result<T>> DeleteAsync(string endpoint);
        /// <summary>
        /// <typeparamref name="T"/> bir return type, <typeparamref name="Y"/> ise bir postModel
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="Y"></typeparam>
        Task<Result<T>> PutAsync(string endpoint, T putModel);

    }
}
