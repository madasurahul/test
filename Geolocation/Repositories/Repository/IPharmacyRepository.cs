using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Geolocation.Models;


namespace Geolocation.Repositories.Repository
{
   
    public interface IPharmacyRepository
    {

        RxMapModel GetPharmacyDetail(Int32 storeNumber);

        bool ValidateStoreNumber(Int32 storeNumber);

        IEnumerable<RxMapModel> GetPharmacyStores(string searchText);
    }
}