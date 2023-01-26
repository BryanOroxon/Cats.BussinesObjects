namespace Cats.BussinesObjects.Interfaces;

public interface ICatsModel
{
    Task<IReadOnlyCollection<Cat>> GetCatsAsync();
}

