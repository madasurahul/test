using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Geolocation.Models;
using System.Net;
using System.Xml.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Geolocation.Repositories.Repository
{
    public class PharmacyRepository
    {
        public IList<RxMapModel> GetAllStores()
        {
             List<RxMapModel> _ProgramAddress = new List<RxMapModel>();

            _ProgramAddress.Add(new RxMapModel { storenumber = 4, storename = "Mulbery Grove Plaza Shopping Center", addressline = "8780 S.E. 165th mulbery lane", city = "The villages", state = "FL", zipcode = 32162, latitude = 28.980031, longitude = -82.007235, timezone = "Eastern", storehours = "9:00 am- 9:00 pm, 9:00 am- 9:00 pm,9:00 am- 9:00 pm,9:00 am- 9:00 pm,9:00 am- 9:00 pm,9:00 am- 9:00 pm", Distance = 0 });
            _ProgramAddress.Add(new RxMapModel { storenumber = 6, storename = "Shoppers At New Tampa", addressline = "1920 C.R. 581", city = "Wesley Chapel", state = "FL", zipcode = 33543, latitude = 28.184634, longitude = -82.350746, timezone = "Eastern", storehours = "9:00 am- 9:00 pm, 9:00 am- 9:00 pm,9:00 am- 9:00 pm,9:00 am- 9:00 pm,9:00 am- 9:00 pm,9:00 am- 9:00 pm", Distance = 0 });
            _ProgramAddress.Add(new RxMapModel { storenumber = 10, storename = "Flagler Park Plaza", addressline = "8341 West Flagler Street", city = "Miami", state = "FL", zipcode = 33144, latitude = 25.771282, longitude = -80.331836, timezone = "Eastern", storehours = "9:00 am- 9:00 pm, 9:00 am- 9:00 pm,9:00 am- 9:00 pm,9:00 am- 9:00 pm,9:00 am- 9:00 pm,9:00 am- 9:00 pm", Distance = 0 });
            _ProgramAddress.Add(new RxMapModel { storenumber = 12, storename = "Pembroke Commons", addressline = "600-B North University Drive", city = "Pembroke Pines", state = "FL", zipcode = 33024, latitude = 26.013747, longitude = -80.25175, timezone = "Eastern", storehours = "9:00 am- 9:00 pm, 9:00 am- 9:00 pm,9:00 am- 9:00 pm,9:00 am- 9:00 pm,9:00 am- 9:00 pm,9:00 am- 9:00 pm", Distance = 0 });
            _ProgramAddress.Add(new RxMapModel { storenumber = 15, storename = "Citrus Tower Village", addressline = "250 Citrus Tower Boulevard", city = "Clermont", state = "FL", zipcode = 34711, latitude = 28.565843, longitude = -81.741399, timezone = "Eastern", storehours = "9:00 am- 9:00 pm, 9:00 am- 9:00 pm,9:00 am- 9:00 pm,9:00 am- 9:00 pm,9:00 am- 9:00 pm,9:00 am- 9:00 pm", Distance = 0 });
            _ProgramAddress.Add(new RxMapModel { storenumber = 17, storename = "Kennerly Crossing", addressline = "7320 Broad River Road", city = "Irmo", state = "SC", zipcode = 29063, latitude = 34.096975, longitude = -81.15759, timezone = "Eastern", storehours = "9:00 am- 9:00 pm, 9:00 am- 9:00 pm,9:00 am- 9:00 pm,9:00 am- 9:00 pm,9:00 am- 9:00 pm,9:00 am- 9:00 pm", Distance = 0 });
            _ProgramAddress.Add(new RxMapModel { storenumber = 21, storename = "Publix @ Glade Crossing", addressline = "2465 Glades Circle", city = "Weston", state = "FL", zipcode = 33327, latitude = 26.139109, longitude = -80.420603, timezone = "Eastern", storehours = "9:00 am- 9:00 pm, 9:00 am- 9:00 pm,9:00 am- 9:00 pm,9:00 am- 9:00 pm,9:00 am- 9:00 pm,9:00 am- 9:00 pm", Distance = 0 });
            _ProgramAddress.Add(new RxMapModel { storenumber = 22, storename = "Publix At Northridge", addressline = "5100 Clark Road", city = "Sarasota", state = "FL", zipcode = 34233, latitude = 27.265808, longitude = -82.467904, timezone = "Eastern", storehours = "9:00 am- 9:00 pm, 9:00 am- 9:00 pm,9:00 am- 9:00 pm,9:00 am- 9:00 pm,9:00 am- 9:00 pm,9:00 am- 9:00 pm", Distance = 0 });
            _ProgramAddress.Add(new RxMapModel { storenumber = 23, storename = "Riverbridge Center", addressline = "6790 Forest Hills Blvd", city = "Greenacres", state = "FL", zipcode = 33413, latitude = 26.649018, longitude = -80.1478045, timezone = "Eastern", storehours = "9:00 am- 9:00 pm, 9:00 am- 9:00 pm,9:00 am- 9:00 pm,9:00 am- 9:00 pm,9:00 am- 9:00 pm,9:00 am- 9:00 pm", Distance = 0 });

            _ProgramAddress = _ProgramAddress.ToList();
            return _ProgramAddress;
        

        }
        public bool ValidateStoreNumber(int storeNumber)
        {
            IList<RxMapModel> storesfromDb = GetAllStores();
            bool isValidStore = false;
            if (storesfromDb.Where(x=>x.storenumber == storeNumber).ToList().Count >0)
            {
                isValidStore = true;
            }
            return isValidStore;
        }

        public RxMapModel GetPharmacyDetail(Int32 storeNumber)
        {
            IList<RxMapModel> storesfromDb = GetAllStores();
            RxMapModel rxMapModel = storesfromDb.Where(x => x.storenumber == storeNumber).FirstOrDefault();
            return rxMapModel;
        }

        public IEnumerable<RxMapModel> GetPharmacyStores(string searchText)
        {
            IEnumerable<RxMapModel> rxMapModellist = null;

            IList<RxMapModel> storesfromDb = GetAllStores();

            GoogleLatLang googleLatLang = new GoogleLatLang();
            //googleLatLang = Google.GetCorodinates(searchText);

            //rxMapModellist = GetClosetStores(googleLatLang, storesfromDb);
            rxMapModellist = storesfromDb;
            return rxMapModellist;
        }

        public double HaversineDistance(GoogleLatLang googleLatLangSource, GoogleLatLang GoogleLatLangStore, DistanceUnit unit)
        {
            double R = (unit == DistanceUnit.Miles) ? 3960 : 6371;
            var lat = this.toRadian(GoogleLatLangStore.latitude - googleLatLangSource.latitude);
            var lng = this.toRadian(GoogleLatLangStore.longitude - googleLatLangSource.longitude);
            var h1 = Math.Sin(lat / 2) * Math.Sin(lat / 2) +
                          Math.Cos(this.toRadian(googleLatLangSource.latitude)) * Math.Cos(this.toRadian(GoogleLatLangStore.latitude)) *
                          Math.Sin(lng / 2) * Math.Sin(lng / 2);
            var h2 = 2 * Math.Asin(Math.Min(1, Math.Sqrt(h1)));
            return R * h2;
        }

        private IEnumerable<RxMapModel> GetClosetStores(GoogleLatLang googleLatLang, IList<RxMapModel> storesfromDb)
        {
            IEnumerable<RxMapModel> closestOffice = new List<RxMapModel>();

            foreach(var store in storesfromDb)
            {
                GoogleLatLang googleLatLangStore = new GoogleLatLang();
                googleLatLangStore.latitude = store.latitude;
                googleLatLangStore.longitude = store.longitude;
                store.Distance = HaversineDistance(googleLatLang, googleLatLangStore, DistanceUnit.Miles);
            }

            storesfromDb = storesfromDb.Where(x => x.Distance <= 150).ToList();
            closestOffice = storesfromDb.OrderBy(x => x.Distance);
            return closestOffice;
        }

        private double toRadian(double val)
        {
            return (Math.PI / 180) * val;
        }

        public enum DistanceUnit { Miles, Kilometres };
        public class GoogleLatLang
        {
            public double latitude { get; set; }
            public double longitude { get; set; }
        }
        public bool ToggleFavourite(int storeCode)
        {
            IEnumerable<RxMapModel> closestOffice = new List<RxMapModel>();
            var Offices = GetAllStores();
            var store = Offices.Where(x => x.storenumber == Convert.ToInt32(storeCode)).First();
            if (store != null)
            {
                store.IsFavourite = !store.IsFavourite;
                return store.IsFavourite;
            }
            else
            {
                return false;
            }
        }

        public static class Google
        {
            public static GoogleLatLang GetCorodinates(string searchText)
            {
                GoogleLatLang googleLatLang = new GoogleLatLang();
                try{
                var requestUri = string.Format("http://maps.googleapis.com/maps/api/geocode/xml?address={0}&sensor=flase", Uri.EscapeDataString(searchText));
                var request = WebRequest.Create(requestUri);
                var response = request.GetResponse();
                var xdoc = XDocument.Load(response.GetResponseStream());
                var result = xdoc.Element("GeocodeResponse").Element("result");
                var locationElement = result.Element("geoemtry").Element("location");
                googleLatLang.latitude = Convert.ToDouble(locationElement.Element("lat"));
                googleLatLang.longitude = Convert.ToDouble(locationElement.Element("lng"));
            }
            catch (Exception ex)
                {
                    throw ex;
                }
                return googleLatLang;
            }
        }

    }
}