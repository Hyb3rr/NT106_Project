using Google.Apis.Auth.OAuth2;
using Google.Apis.Download;
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
        private static readonly string[] Scopes = { DriveService.Scope.DriveReadonly };
        // Hoặc DriveService.Scope.Drive nếu cần quyền đầy đủ
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
        public async Task DownloadFileAsync(string fileId, string destinationPath, IProgress<double>? progress = null)
        {
            // try
            // {
            //     if (string.IsNullOrEmpty(fileId))
            //     {
            //         throw new ArgumentException("ID file Google Drive không được để trống");
            //     }

            //     var request = _driveService.Files.Get(fileId);

            //     // Sử dụng cách tải file đơn giản hơn và tương thích với API hiện tại
            //     using var stream = new MemoryStream();

            //     // Tải file và báo cáo tiến trình
            //     if (progress != null)
            //     {
            //         // Báo cáo tiến độ bắt đầu
            //         progress.Report(0.1); // Báo cáo 10% khi bắt đầu

            //         try
            //         {
            //             // Tạo và thiết lập MediaDownloader
            //             var downloader = new Google.Apis.Download.MediaDownloader(_driveService)
            //             {
            //                 ChunkSize = 256 * 1024 // 256KB mỗi chunk
            //             };

            //             // Theo dõi tiến độ tải
            //             downloader.ProgressChanged += (IDownloadProgress downloadProgress) =>
            //             {
            //                 switch (downloadProgress.Status)
            //                 {
            //                     case DownloadStatus.Downloading:
            //                         // Ước tính tiến độ dựa trên bytes đã tải
            //                         // Tăng dần từ 10% đến 90% tùy theo số bytes đã tải
            //                         long bytesDownloaded = downloadProgress.BytesDownloaded;
            //                         if (bytesDownloaded > 0)
            //                         {
            //                             // Giả lập tiến độ dựa trên bytes đã tải (tối đa 90%)
            //                             double estimatedProgress = 0.1 + (Math.Min(bytesDownloaded, 10000000) / 10000000.0) * 0.8;
            //                             progress.Report(Math.Min(0.9, estimatedProgress));
            //                         }
            //                         break;

            //                     case DownloadStatus.Completed:
            //                         // Hoàn thành 100%
            //                         progress.Report(1.0);
            //                         break;
            //                 }
            //             };

            //             // Tạo URI cho request tải xuống
            //             string downloadUrl = $"https://www.googleapis.com/drive/v3/files/{fileId}?alt=media";
            //             Uri uri = new Uri(downloadUrl);

            //             // Tải file
            //             var result = await downloader.DownloadAsync(downloadUrl, stream);

            //             // Kiểm tra kết quả
            //             if (result.Status != DownloadStatus.Completed)
            //             {
            //                 throw new Exception($"Download failed with status: {result.Status}");
            //             }

            //             // Báo cáo hoàn thành 100%
            //             progress.Report(1.0);
            //         }
            //         catch
            //         {
            //             // Báo cáo lỗi
            //             progress.Report(0);
            //             throw;
            //         }
            //     }
            //     else
            //     {
            //         // Nếu không cần báo cáo tiến trình, sử dụng phương thức đơn giản
            //         await request.DownloadAsync(stream);
            //     }

            //     // Ghi file ra đĩa
            //     stream.Position = 0; // Reset position to beginning
            //     using var fileStream = new FileStream(destinationPath, FileMode.Create, FileAccess.Write);
            //     await stream.CopyToAsync(fileStream);
            // }
            // catch (Exception ex)
            // {
            //     Console.WriteLine($"Error downloading file: {ex.Message}");
            //     throw;
            // }
            try
            {
                if (string.IsNullOrEmpty(fileId))
                {
                    throw new ArgumentException("ID file Google Drive không được để trống");
                }

                // Thử kiểm tra thông tin file trước
                try
                {
                    var fileRequest = _driveService.Files.Get(fileId);
                    fileRequest.Fields = "id,name,size,mimeType,permissions";
                    var fileInfo = await fileRequest.ExecuteAsync();

                    Console.WriteLine($"File info: Name={fileInfo.Name}, Size={fileInfo.Size}, MimeType={fileInfo.MimeType}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Cannot get file info: {ex.Message}");
                    throw new Exception($"File không tồn tại hoặc không có quyền truy cập: {fileId}");
                }

                // Báo cáo tiến độ bắt đầu
                progress?.Report(0.1);

                // Tạo thư mục nếu chưa có
                var directory = Path.GetDirectoryName(destinationPath);
                if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                // Tải file
                using var stream = new FileStream(destinationPath, FileMode.Create, FileAccess.Write);

                progress?.Report(0.5);

                var downloadRequest = _driveService.Files.Get(fileId);
                await downloadRequest.DownloadAsync(stream);

                await stream.FlushAsync();

                progress?.Report(1.0);

                // Kiểm tra file sau khi tải
                var downloadedFileInfo = new FileInfo(destinationPath);
                Console.WriteLine($"Downloaded file size: {downloadedFileInfo.Length} bytes");

                if (downloadedFileInfo.Length == 0)
                {
                    throw new Exception("File tải về có kích thước 0 byte");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error downloading file: {ex.Message}");
                progress?.Report(0);
                throw;
            }
        }

    }
}