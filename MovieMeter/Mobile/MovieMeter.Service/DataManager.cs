using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieMeter.Service
{
    public class DataManager<T>
    {
        RestService<T> RestService;

        public DataManager()
        {
            RestService = new RestService<T>();
        }

        public Task<List<T>> GetItems()
        {
            return RestService.GetItems();
           
        }

        public Task<T> GetItemData(int ItemID)
        {
            return RestService.GetItemData(ItemID);

        }
    }
}
