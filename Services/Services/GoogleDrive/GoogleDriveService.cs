using Domain.ModelViews;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Services.Interfaces.GoogleDrive;
using System.Net;

namespace Services.Services.GoogleDrive
{
    public class GoogleDriveService : IGoogleDriveService
    {
        private const string _credentialsPath = "./../../../../Services/Services/GoogleDrive/client_secret.json";
        private const string _folderId = "1Htiya3sYzh2zLNzXsg8g3OAnMOtz3leq";
        private const string _path = "https://drive.google.com/uc?id=";

        public async Task<string> UploadFilesToGoogleDrive(UploadVM pRequest)
        {
            try
            {
                GoogleCredential credential;

                using (var stream1 = new FileStream(_credentialsPath, FileMode.Open, FileAccess.Read))
                {
                    credential = GoogleCredential.FromStream(stream1)
                         .CreateScoped(DriveService.ScopeConstants.DriveFile);

                    var service = new DriveService(new BaseClientService.Initializer()
                    {
                        HttpClientInitializer = credential,
                        ApplicationName = "Google Drive Upload SmartPhone"
                    });

                    // Tạo thư mục trước khi lưu tệp tin
                    var folderId = _folderId;

                    string[] folders = pRequest.FileName.Split("/");
                    for (int i = 0; i < folders.Length - 1; i++)
                    {
                        var existingFolderQuery = service.Files.List();
                        existingFolderQuery.Q = $"name='{folders[i]}' and '{folderId}' in parents";
                        existingFolderQuery.Fields = "files(id, name)";
                        var existingFolders = existingFolderQuery.Execute().Files;

                        if (existingFolders != null && existingFolders.Count > 0)
                        {
                            folderId = existingFolders.First().Id;
                        }
                        else
                        {
                            var folderMetadata = new Google.Apis.Drive.v3.Data.File()
                            {
                                Name = folders[i],
                                MimeType = "application/vnd.google-apps.folder",
                                Parents = new List<string> { folderId },
                            };

                            var folderRequest = service.Files.Create(folderMetadata);
                            folderRequest.Fields = "id";
                            var folder = folderRequest.Execute();
                            folderId = folder.Id;
                        }
                    }

                    // Kiểm tra xem tệp tin đã tồn tại chưa
                    string fileExtension = Path.GetExtension(new Uri(pRequest.FilePath).AbsolutePath);
                    var existingFileQuery = service.Files.List();
                    existingFileQuery.Q = $"name='{pRequest.FileName + fileExtension}' and '{folderId}' in parents";
                    existingFileQuery.Fields = "files(id, name)";
                    var existingFiles = existingFileQuery.Execute().Files;

                    if (existingFiles != null && existingFiles.Count > 0)
                    {
                        return $"File có tên '{pRequest.FileName + fileExtension}' đã tồn tại!";
                    }
                    else
                    {
                        var fileMetaData = new Google.Apis.Drive.v3.Data.File()
                        {
                            Name = folders[folders.Length - 1] + fileExtension,
                            Parents = new List<string> { folderId },
                        };

                        using (var stream2 = new MemoryStream(new WebClient().DownloadData(pRequest.FilePath)))
                        {
                            FilesResource.CreateMediaUpload request = service.Files.Create(fileMetaData, stream2, "");
                            request.Fields = "id";
                            request.Upload();
                            var uploadFile = request.ResponseBody;

                            // Xây dựng đường dẫn đầy đủ
                            string fileId = uploadFile.Id;
                            string downloadUrl = $"{_path}{fileId}";

                            return downloadUrl;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
