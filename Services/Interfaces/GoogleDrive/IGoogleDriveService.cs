using Domain.ModelViews;

namespace Services.Interfaces.GoogleDrive
{
    public interface IGoogleDriveService
    {
        Task<string> UploadFilesToGoogleDrive(UploadVM pRequest);
    }
}
