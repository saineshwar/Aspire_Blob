# ☁️ Integrating Azure Blob Storage with .NET Aspire

This repository demonstrates how to integrate **Azure Blob Storage** with **.NET Aspire**, a modern framework by Microsoft for building scalable, cloud-native applications.

## 🌟 What is .NET Aspire?

[.NET Aspire](https://devblogs.microsoft.com/dotnet/introducing-dotnet-aspire/) is a cloud-native development stack tailored for .NET developers. It simplifies building distributed applications by integrating service discovery, telemetry, and cloud service bindings.

## 📦 Why Azure Blob Storage?

[Azure Blob Storage](https://azure.microsoft.com/en-us/products/storage/blobs) is a massively scalable object storage solution for unstructured data. It’s commonly used for:
- Storing images, videos, documents, backups
- Cloud-native file sharing
- Data archiving

## 📘 Learn More

Follow the full integration tutorial here:  
🔗 [How to Integrate .NET Aspire with Azure Blob Storage](https://tutexchange.com/how-to-integrate-net-aspire-with-azure-blob-storage/)

In the tutorial, you'll learn:
- How to use Azurite to emulate Blob Storage locally
- Configure Blob storage service inside Aspire
- Register Azure Blob clients with the Aspire builder
- Implement APIs to upload and retrieve blobs

## 🧰 Tech Stack

- .NET Aspire
- ASP.NET Core
- Azure.Storage.Blobs SDK
- Docker (for Azurite Blob Emulator)

## 🚀 Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- [Docker](https://www.docker.com/)
- [Azurite Emulator](https://learn.microsoft.com/en-us/azure/storage/common/storage-use-azurite)

### Run the Project

```bash
git clone https://github.com/saineshwar/Aspire_Blob.git
cd aspire-azure-blob-storage
dotnet run --project AspireApp
