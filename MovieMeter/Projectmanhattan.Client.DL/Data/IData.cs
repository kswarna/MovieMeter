using MovieMeter.Service;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Projectmanhattan.Client.DL.Data
{
    public abstract class Data<T>
    {
          protected int ItemId { get; private set; }
        public async Task<List<T>> GetData()
        {
            return await RestService<T>.GetItems(GetUrl());
        }

        protected string GetUrl()
        {
            return UrlResourceFile.BasePath + GetRelativeUrl();
        }

        public abstract string GetRelativeUrl();

        public async Task<T> GetData(int itemID)
        {
            ItemId = itemID;
            return await RestService<T>.GetItemData(GetUrl(),itemID);
        }

        public async Task<List<T>> GetItemData(int itemID)
        {
            ItemId = itemID;
            return await RestService<T>.GetItems(GetUrl(), itemID);
        }
    }
}