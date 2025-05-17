using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Upload;
using Google.Apis.Util.Store;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace BookReaderApp.Services
{
    public class DriveServiceHelper
    {
        private const string ApplicationName = "BookReaderApp";
        private static readonly string[] Scopes = { DriveService.Scope.DriveFile };
        private readonly DriveService _driveService;

        public DriveServiceHelper()
        {
            _driveService = InitializeDriveService();
        }

        /// <summary>
        /// Initializes the Google Drive service.
        /// </summary>
        /// <returns>A DriveService instance.</returns>
        private static DriveService InitializeDriveService()
        {
            try
            {
                UserCredential credential;

                // Load credentials.json from a secure location
                using (var stream = new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
                {
                    string credPath = "token.json";
                    credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                        GoogleClientSecrets.FromStream(stream).Secrets,
                        Scopes,
                        "user",
                        CancellationToken.None,
                        new FileDataStore(credPath, true)).Result;
                }

                // Create Drive API service
                return new DriveService(new BaseClientService.Initializer
                {
                    HttpClientInitializer = credential,
                    ApplicationName = ApplicationName,
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error initializing Google Drive service: {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// Uploads a file to Google Drive.
        /// </summary>
        /// <param name="localFilePath">The path to the local file.</param>
        /// <param name="progress">Optional progress reporter.</param>
        /// <returns>The ID of the uploaded file.</returns>
        public async Task<string> UploadFileAsync(string localFilePath, IProgress<double>? progress = null)
        {
            try
            {
                var fileMetadata = new Google.Apis.Drive.v3.Data.File
                {
                    Name = Path.GetFileName(localFilePath)
                };

                using var fileStream = new FileStream(localFilePath, FileMode.Open, FileAccess.Read);
                var request = _driveService.Files.Create(fileMetadata, fileStream, "application/octet-stream");
                request.Fields = "id";

                if (progress != null)
                {
                    request.ProgressChanged += (IUploadProgress uploadProgress) =>
                    {
                        if (uploadProgress.Status == UploadStatus.Uploading)
                        {
                            progress.Report((double)uploadProgress.BytesSent / fileStream.Length);
                        }
                    };
                }

                var result = await request.UploadAsync();
                if (result.Status != UploadStatus.Completed)
                {
                    throw new Exception($"Upload failed: {result.Exception?.Message}");
                }

                return request.ResponseBody?.Id ?? throw new Exception("Upload failed: No file ID returned.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error uploading file: {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// Downloads a file from Google Drive.
        /// </summary>
        /// <param name="fileId">The ID of the file to download.</param>
        /// <param name="destinationPath">The local path to save the file.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public async Task DownloadFileAsync(string fileId, string destinationPath)
        {
            try
            {
                var request = _driveService.Files.Get(fileId);
                using var stream = new MemoryStream();

                // Download the file
                await request.DownloadAsync(stream);

                // Save to the destination path
                using var fileStream = new FileStream(destinationPath, FileMode.Create, FileAccess.Write);
                stream.WriteTo(fileStream);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error downloading file: {ex.Message}");
                throw;
            }
        }
    }
}