namespace Services.Interfaces
{
    public interface IPermissionService
    {
        List<string> GetRequiredPermissions();

        Task<List<string>> Create(List<string> pPermissions);
    }
}
