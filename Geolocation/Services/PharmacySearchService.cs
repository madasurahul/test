using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Geolocation.Models;
using Geolocation.Repositories;
using Geolocation.Repositories.Repository;

namespace Geolocation.Services
{
    public class PharmacySearchService : IPharmacySearchService
    {
        public RxMapModel GetPharmacyDetail(Int32 storeNumber)
        {
            RxMapModel rxMapModel = new RxMapModel();
            rxMapModel = (new PharmacyRepository()).GetPharmacyDetail(storeNumber);

            return rxMapModel;
        }

        public IEnumerable<RxMapModel> GetPharmacyStores(string searchText)
        {
            IEnumerable<RxMapModel> rxModelList;

            rxModelList = (new PharmacyRepository()).GetPharmacyStores(searchText);
            return rxModelList;
        }
        public bool ValidateStoreNumber(Int32 storeNumber)
        {
            return (new PharmacyRepository()).ValidateStoreNumber(storeNumber);
            
        }
        public bool ToggleFavourite(string scode)
        {
            return new PharmacyRepository().ToggleFavourite(int.Parse(scode));
        }
    }
}