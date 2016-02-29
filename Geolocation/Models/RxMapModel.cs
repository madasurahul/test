using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Geolocation.Models
{
    public class RxMapModel
    {
        public int storenumber { get; set; }
        public string storename { get; set; }
        public string addressline { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int zipcode { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public string timezone { get; set; }
        public string storehours { get; set; }
        public double Distance { get; set; }
        public bool IsFavourite { get; set; }
    }
    //public class LatLng
    //{
    //    public double Latitude { get; set; }
    //    public double Longitude { get; set; }

    //    public LatLng()
    //    {
    //    }

    //    public LatLng(double lat, double lng)
    //    {
    //        this.Latitude = lat;
    //        this.Longitude = lng;
    //    }
    //}

    //public class Stores
    //{
    //    private double toRadian(double val)
    //    {
    //        return (Math.PI / 180) * val;
    //    }
    //    public enum DistanceUnit { Miles, Kilometers };

    //    public IList<RxMapModel> GetAllStores()
    //    {
    //        List<RxMapModel> _ProgramAddress = new List<RxMapModel>();

    //        _ProgramAddress.Add(new RxMapModel { storenumber = 4, storename = "Mulbery Grove Plaza Shopping Center", addressline = "8780 S.E. 165th mulbery lane", city = "The villages", state = "FL", zipcode = 32162, latitude = 28.980031, longitude = -82.007235, timezone = "Eastern", storehours = "9:00 am- 9:00 pm, 9:00 am- 9:00 pm,9:00 am- 9:00 pm,9:00 am- 9:00 pm,9:00 am- 9:00 pm,9:00 am- 9:00 pm", Distance = 0 });
    //        _ProgramAddress.Add(new RxMapModel { storenumber = 6, storename = "Shoppers At New Tampa", addressline = "1920 C.R. 581", city = "Wesley Chapel", state = "FL", zipcode = 33543, latitude = 28.184634, longitude = -82.350746, timezone = "Eastern", storehours = "9:00 am- 9:00 pm, 9:00 am- 9:00 pm,9:00 am- 9:00 pm,9:00 am- 9:00 pm,9:00 am- 9:00 pm,9:00 am- 9:00 pm", Distance = 0 });
    //        _ProgramAddress.Add(new RxMapModel { storenumber = 10, storename = "Flagler Park Plaza", addressline = "8341 West Flagler Street", city = "Miami", state = "FL", zipcode = 33144, latitude = 25.771282, longitude = -80.331836, timezone = "Eastern", storehours = "9:00 am- 9:00 pm, 9:00 am- 9:00 pm,9:00 am- 9:00 pm,9:00 am- 9:00 pm,9:00 am- 9:00 pm,9:00 am- 9:00 pm", Distance = 0 });
    //        _ProgramAddress.Add(new RxMapModel { storenumber = 12, storename = "Pembroke Commons", addressline = "600-B North University Drive", city = "Pembroke Pines", state = "FL", zipcode = 33024, latitude = 26.013747, longitude = -80.25175, timezone = "Eastern", storehours = "9:00 am- 9:00 pm, 9:00 am- 9:00 pm,9:00 am- 9:00 pm,9:00 am- 9:00 pm,9:00 am- 9:00 pm,9:00 am- 9:00 pm", Distance = 0 });
    //        _ProgramAddress.Add(new RxMapModel { storenumber = 15, storename = "Citrus Tower Village", addressline = "250 Citrus Tower Boulevard", city = "Clermont", state = "FL", zipcode = 34711, latitude = 28.565843, longitude = -81.741399, timezone = "Eastern", storehours = "9:00 am- 9:00 pm, 9:00 am- 9:00 pm,9:00 am- 9:00 pm,9:00 am- 9:00 pm,9:00 am- 9:00 pm,9:00 am- 9:00 pm", Distance = 0 });
    //        _ProgramAddress.Add(new RxMapModel { storenumber = 17, storename = "Kennerly Crossing", addressline = "7320 Broad River Road", city = "Irmo", state = "SC", zipcode = 29063, latitude = 34.096975, longitude = -81.15759, timezone = "Eastern", storehours = "9:00 am- 9:00 pm, 9:00 am- 9:00 pm,9:00 am- 9:00 pm,9:00 am- 9:00 pm,9:00 am- 9:00 pm,9:00 am- 9:00 pm", Distance = 0 });
    //        _ProgramAddress.Add(new RxMapModel { storenumber = 21, storename = "Publix @ Glade Crossing", addressline = "2465 Glades Circle", city = "Weston", state = "FL", zipcode = 33327, latitude = 26.139109, longitude = -80.420603, timezone = "Eastern", storehours = "9:00 am- 9:00 pm, 9:00 am- 9:00 pm,9:00 am- 9:00 pm,9:00 am- 9:00 pm,9:00 am- 9:00 pm,9:00 am- 9:00 pm", Distance = 0 });
    //        _ProgramAddress.Add(new RxMapModel { storenumber = 22, storename = "Publix At Northridge", addressline = "5100 Clark Road", city = "Sarasota", state = "FL", zipcode = 34233, latitude = 27.265808, longitude = -82.467904, timezone = "Eastern", storehours = "9:00 am- 9:00 pm, 9:00 am- 9:00 pm,9:00 am- 9:00 pm,9:00 am- 9:00 pm,9:00 am- 9:00 pm,9:00 am- 9:00 pm", Distance = 0 });
    //        _ProgramAddress.Add(new RxMapModel { storenumber = 23, storename = "Riverbridge Center", addressline = "6790 Forest Hills Blvd", city = "Greenacres", state = "FL", zipcode = 33413, latitude = 26.649018, longitude = -80.1478045, timezone = "Eastern", storehours = "9:00 am- 9:00 pm, 9:00 am- 9:00 pm,9:00 am- 9:00 pm,9:00 am- 9:00 pm,9:00 am- 9:00 pm,9:00 am- 9:00 pm", Distance = 0 });

    //        _ProgramAddress = _ProgramAddress.ToList();
    //        return _ProgramAddress;
    //    }

    //    public double HaversineDistance(LatLng pos1, LatLng pos2, DistanceUnit unit)
    //    {
    //        double R = (unit == DistanceUnit.Miles) ? 3960 : 6371;
    //        var lat = this.toRadian(pos2.Latitude - pos1.Latitude);
    //        var lng = this.toRadian(pos2.Longitude - pos1.Longitude);
    //        var h1 = Math.Sin(lat / 2) * Math.Sin(lat / 2) +
    //                      Math.Cos(this.toRadian(pos1.Latitude)) * Math.Cos(this.toRadian(pos2.Latitude)) *
    //                      Math.Sin(lng / 2) * Math.Sin(lng / 2);
    //        var h2 = 2 * Math.Asin(Math.Min(1, Math.Sqrt(h1)));
    //        return R * h2;
    //    }

    //    public IEnumerable<RxMapModel> GetClosetStores(double lat, double longt)
    //    {
    //        IEnumerable<RxMapModel> closestOffice = new List<RxMapModel>();
    //        LatLng coord = new LatLng(lat, longt);

    //        var Offices = GetAllStores();
    //        Offices.ToList().ForEach(c => c.Distance=HaversineDistance(
    //                 coord,
    //                 new LatLng(c.latitude, c.longitude),
    //                 DistanceUnit.Miles));
    //        //for (int i = 0; i < Offices.Count; i++)
    //        //{
    //        //    Offices[i].Distance = HaversineDistance(
    //        //         coord,
    //        //         new LatLng(Offices[i].latitude, Offices[i].longitude),
    //        //         DistanceUnit.Miles);
    //        //}

    //       // Offices = Offices.Where(x => x.Distance <= 150).ToList();
    //        closestOffice = Offices.Where(i=>i.Distance<=150).ToList().OrderBy(x => x.Distance);
    //        return closestOffice;
    //    }

    //    public IEnumerable<RxMapModel> GetClosetStores(int storeCode)
    //    {
    //        IEnumerable<RxMapModel> closestOffice = new List<RxMapModel>();
    //        var Offices = GetAllStores();
    //        var store = Offices.Where(x => x.storenumber == Convert.ToInt32(storeCode)).ToList();
    //        LatLng coord = new LatLng(store[0].latitude, store[0].longitude);
    //        for (int i = 0; i < Offices.Count; i++)
    //        {
    //            Offices[i].Distance = HaversineDistance(
    //                 coord,
    //                 new LatLng(Offices[i].latitude, Offices[i].longitude),
    //                 DistanceUnit.Miles);
    //        }

    //        Offices = Offices.Where(x => x.Distance <= 150).ToList();
    //        closestOffice = Offices.OrderBy(x => x.Distance);
    //        return closestOffice;
    //    }
    //}
}