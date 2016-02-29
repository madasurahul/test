//using Geolocation.Models;
//using Geolocation.Repositories.Repository;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//namespace Geolocation.Services
//{
//    public class SearchService : SearchInterface
//    {

//        //public IEnumerable<RxMapModel> GetStoreListBasedonZeoCode(double latitude, double langitude)
//        //{ 
        
//        //}
//        public IEnumerable<RxMapModel> GeStoreListBasedOnLatnLng(double latitude, double langitude)
//        {
//            SearchRepository objStore = new SearchRepository();
//            return objStore.GeStoreListBasedOnLatnLng(latitude, langitude);
           
//        }
//        public IEnumerable<RxMapModel> GeStoreDetailsBasedOnStoreNumber(int storeNumber)
//        {
//            SearchRepository objStore = new SearchRepository();
//            return objStore.GeStoreDetailsBasedOnStoreNumber(storeNumber);

//        }
//    }
//}