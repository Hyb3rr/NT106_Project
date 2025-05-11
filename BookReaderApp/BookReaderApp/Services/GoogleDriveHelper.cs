using Google.Apis.Drive.v3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
namespace BookReaderApp.Services
{
    public class GoogleDriveHelper
    {
        private readonly DriveService _driveService;

        public GoogleDriveHelper(string credentialsPath, string applicationName)
        {
            var credential = GoogleCredential.FromFile(credentialsPath)
                .CreateScoped(DriveService.Scope.DriveReadonly);

            _driveService = new DriveService(new BaseClientService.Initializer
            {
                HttpClientInitializer = credential,
                ApplicationName = applicationName
            });
        }

        public void DownloadFile(string fileId, string savePath)
        {
            var request = _driveService.Files.Get(fileId);
            using (var stream = new FileStream(savePath, FileMode.Create, FileAccess.Write))
            {
                request.Download(stream);
            }
        }
    }
}
