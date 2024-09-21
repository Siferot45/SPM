namespace SPM.Storage.Storages;

public interface IGuidFactory
{
    Guid Create();
}

internal class GuidFactory : IGuidFactory
{
    public Guid Create() => Guid.NewGuid();

}
