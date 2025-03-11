using Azure.Storage.Blobs;
using System;
using System.IO;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        // Replace the placeholder with your Azure Storage account's connection string.
        // You can get this from the Azure Portal under 'Access Keys' for your storage account.
        string connectionString = "<your-storage-account-connection-string>"; 
        
        // Replace with the name of the blob container in your Azure Blob Storage
        string containerName = "<your-container-name>"; 
        
        // Replace with the name of the blob you want to download (the file in the container)
        string blobName = "<your-blob-name>"; // Example: "example-file.json"

        // Define the local folder where the file will be downloaded
        // Make sure the folder exists or the program will fail to write the file.
        string downloadFolderPath = @"<your-local-download-folder-path>";  // Example: @"C:\Users\YourName\Downloads"

        // Combine the folder path and the blob name to create the full path for the downloaded file
        string downloadFilePath = Path.Combine(downloadFolderPath, blobName);

        try
        {
            // Create a BlobServiceClient to interact with the Blob service
            BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);
            
            // Get the reference to the container (ensure the container exists in your Azure Blob Storage)
            BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(containerName);
            
            // Get a reference to the blob (the file you want to download)
            BlobClient blobClient = containerClient.GetBlobClient(blobName);

            // Download the file asynchronously
            Console.WriteLine($"Downloading file {blobName}...");
            await blobClient.DownloadToAsync(downloadFilePath);

            // Confirm the download completion
            Console.WriteLine($"Download completed!\nThe file is saved as {downloadFilePath}");
        }
        catch (Exception ex)
        {
            // Handle any errors (like if the blob doesn't exist or authentication fails)
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}





