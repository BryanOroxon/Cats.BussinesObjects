namespace Cats.BussinesObjects.Interfaces;

public interface ICatsViewModels
{
    IReadOnlyCollection<Cat> Cats{get;  }

    Task GetCatsAsync();

}

