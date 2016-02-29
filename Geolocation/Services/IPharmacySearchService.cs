using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Geolocation.Models;

namespace Geolocation.Services
{
    public interface IPharmacySearchService
    {
        IEnumerable<RxMapModel> GetPharmacyStores(string searchText);
        RxMapModel GetPharmacyDetail(Int32 storeNumber);
            bool ValidateStoreNumber(Int32 storeNumber);
    }
}