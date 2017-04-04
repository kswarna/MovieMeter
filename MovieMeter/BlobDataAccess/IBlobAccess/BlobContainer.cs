using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlobDataAccess.IBlobAccess
{
    public abstract class BlobContainer
    {
        private string containerName;

        public BlobContainer(string storageConnectionString)
        {
            StorageConnectionString = storageConnectionString;
        }

        public string StorageConnectionString { get; set; }
        public abstract void GetOrCreateContainer(string ContainerName);

        public abstract void DeleteContainer(string ContainerName);

        public abstract List<Uri> GetListFiles(string ContainerName);

        public abstract string StoreFile(string fileName, Stream fileStream);

        public abstract void DeleteFile(string fileName);

    }

}
