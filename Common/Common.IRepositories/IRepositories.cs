namespace Common.Common.Responstories;

public interface IRepositories<T> where T : class
{
  //restful api
  public IEnumerable<T> GetAllAsync(string tokenJwt);
  public T? GetByIdAsync(Guid id, string tokenJwt);
  public bool AddAsync(T entity, string tokenJwt);
  public bool UpdateAsync(T entity, string tokenJwt);
  public bool DeleteAsync(Guid id, string tokenJwt);
}
