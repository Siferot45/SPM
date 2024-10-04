namespace SPM.Storage.Storages;

public class GuidFactory : IGuidFactory
{
    public Guid Create() => Guid.NewGuid();

}
