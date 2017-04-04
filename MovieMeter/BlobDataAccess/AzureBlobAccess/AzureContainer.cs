using BlobDataAccess.IBlobAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure; // Namespace for CloudConfigurationManager
using Microsoft.WindowsAzure.Storage; // Namespace for CloudStorageAccount
using Microsoft.WindowsAzure.Storage.Blob; // Namespace for Blob storage types
using System.IO;

namespace BlobDataAccess.AzureBlobAccess
{
    public class AzureContainer : BlobContainer
    {
        public AzureContainer(string storageConnectionString) : base(storageConnectionString)
        {
            // Retrieve storage account from connection string.
            var storageAccount = CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting(storageConnectionString));
            // Create the blob client.
            blobClient = storageAccount.CreateCloudBlobClient();

        }

        CloudBlobClient blobClient;
        CloudBlobContainer Container;
        public override void GetOrCreateContainer(string ContainerName)
        {
            // Retrieve a reference to a container.
            Container = blobClient.GetContainerReference(ContainerName);

            // Create the container if it doesn't already exist.
            Container.CreateIfNotExists();

            Container.SetPermissions(
    new BlobContainerPermissions { PublicAccess = BlobContainerPublicAccessType.Blob });
        }

        public override void DeleteContainer(string ContainerName)
        {
            throw new NotImplementedException();
        }

        public override List<Uri> GetListFiles(string ContainerName)
        {
            Container = blobClient.GetContainerReference(ContainerName);
            
            var uris = new List<Uri>();
            foreach (IListBlobItem item in Container.ListBlobs(null, false))
            {
                uris.Add(item.Uri);
            }
            return uris;
        }

        public void SetContainer(string containerName)
        {
            Container = blobClient.GetContainerReference(containerName);
        }

        public override string StoreFile(string fileName, Stream fileStream)
        {
            // Retrieve reference to a blob named "myblob".
            CloudBlockBlob blockBlob = Container.GetBlockBlobReference(fileName);
            
            // Create or overwrite the "myblob" blob with contents from a local file.
            blockBlob.UploadFromStream(fileStream);

            return Container.Uri.OriginalString + "/" + fileName;
        }

        public override void DeleteFile(string fileName)
        {
            var completePath = Path.Combine(Container.Uri.OriginalString, fileName);
            // Retrieve reference to a blob named "myblob".
            CloudBlockBlob blockBlob = Container.GetBlockBlobReference(fileName);

            // Delete the blob.
            blockBlob.Delete();
        }
    }
}
