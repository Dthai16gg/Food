using Common.Common.Context;
using Microsoft.EntityFrameworkCore;

namespace Common.Common.Responstories;
public class Repositories<T> : IRepositories<T> where T : class
{
  private readonly CommonContext _context;
  private readonly DbSet<T>? _dbSet;
  public Repositories() => _context = new CommonContext(); // expression methods body
  public bool AddAsync(T entity, string tokenJwt)
  {
    //check token jwt
    if (string.IsNullOrEmpty(tokenJwt)) return false;
    if (_dbSet == null) return false;
    if (entity == null) return false;
    _dbSet?.Add(entity);
    return _context.SaveChanges() > 0;
  }

  public bool DeleteAsync(Guid id, string tokenJwt)
  {
    if (string.IsNullOrEmpty(tokenJwt)) return false;
    if (_dbSet == null) return false;
    if (id == null || id == Guid.Empty) return false;
    _dbSet?.Remove(_dbSet?.Find(id) ?? throw new InvalidOperationException());
    return _context.SaveChanges() > 0;
  }
  //Get All Entity
  //?? : null coalescing operator
  public IEnumerable<T> GetAllAsync(string tokenJwt) =>
    string.IsNullOrEmpty(tokenJwt) ? Enumerable.Empty<T>() : _dbSet?.AsEnumerable() ?? Enumerable.Empty<T>();
  public T? GetByIdAsync(Guid id, string tokenJwt) => string.IsNullOrEmpty(tokenJwt) ? null : _dbSet?.Find(id) ?? throw new InvalidOperationException();

  public bool UpdateAsync(T entity, string tokenJwt)
  {
    if (string.IsNullOrEmpty(tokenJwt)) return false;
    if (_dbSet == null) return false;
    if (entity == null) return false;
    _dbSet?.Update(entity);
    return _context.SaveChanges() > 0;
  }
}
