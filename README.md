# Project-2-Azure-Storage-for-file-management-Code-to-Retrieve-Files-

This repository contains the C# console application code that demonstrates how to retrieve (download) files from Azure Blob Storage. The application uses **Azure.Storage.Blobs** to interact with Azure Blob Storage and download files from a specified container.

## Prerequisites

Before you run the application, ensure you have the following:
- **.NET SDK** installed (version 5.0 or later) - You can download it from [here](https://dotnet.microsoft.com/download).
- **Azure.Storage.Blobs NuGet package** - This is used to interact with Azure Blob Storage.
- An **Azure Storage Account** with an existing **Blob Container** where the files you want to retrieve are stored.

## Getting Started

### 1. Set up your Azure Storage Account
- Create a **Storage Account** in the Azure portal.
- Create a **Blob Container** where your files are stored.
- Obtain the **Connection String** for your Storage Account. You can find this under **Access keys** in the **Settings** of your Storage Account.

### 2. Clone the Repository

```bash
git clone https://github.com/1suleyman/Project-2-Azure-Storage-for-file-management-Code-to-Retrieve-Files.git
cd Project-2-Azure-Storage-for-file-management-Code-to-Retrieve-Files
```

### 3. Install Dependencies

In the project folder, run the following command to install the **Azure.Storage.Blobs** NuGet package:

```bash
dotnet add package Azure.Storage.Blobs
```

### 4. Configure the Application

- Open the `Program.cs` file.
- Replace the placeholder for **connectionString** with the actual connection string from your Azure Storage Account.
- Specify the **containerName** and **blobName** (the file you want to download) and the **downloadFolderPath** (local path where the file will be saved).

```csharp
string connectionString = "<your-storage-account-connection-string>";
string containerName = "my-container";
string blobName = "file.txt"; // The name of the file to download
string downloadFolderPath = @"C:\path\to\download";

string downloadFilePath = Path.Combine(downloadFolderPath, blobName);
```

### 5. Run the Application

To download the file from Azure Blob Storage, run the following command:

```bash
dotnet run
```

The file will be downloaded from the specified blob container in Azure to your local machine.

## Conclusion

This project demonstrates how to retrieve files from Azure Blob Storage using C# and the **Azure.Storage.Blobs** package. You can use this code to manage your files stored in Azure Blob Storage and integrate the download functionality into your applications.

For more details on interacting with Azure Blob Storage, refer to the official Azure documentation: [Azure Blob Storage Documentation](https://docs.microsoft.com/en-us/azure/storage/blobs/).
