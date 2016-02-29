using Geolocation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net;
using Geolocation.Services;


namespace Geolocation.Controllers
{
    public class SearchController : Controller
    {

        public SearchController()
        {

        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetLocations(SearchModel model)
        {
            if (ModelState.IsValid)
            {
                var search = model.SearchInput;

                Int32 storenumber;
                if (search.Length < 5 && int.TryParse(search, out storenumber))
                {
                    bool isValidStore = (new PharmacySearchService()).ValidateStoreNumber(storenumber);
                    if (isValidStore)
                    {
                        return RedirectToAction("StoreDetails", "Search", new { storenumber = storenumber });
                    }
                    
                }
                else
                {
                    List<RxMapModel> rxMapModellist = new List<RxMapModel>();
                    rxMapModellist = (new PharmacySearchService()).GetPharmacyStores(search).ToList();//TBD Call List<RxModel>}
                    return View("GetLocations", rxMapModellist);
                }
            }
                return View("Index");
            }
        public JsonResult ToggleFavourite()
        {
            var scode = Request.QueryString["storecode"];
            return Json(new PharmacySearchService().ToggleFavourite(scode), JsonRequestBehavior.AllowGet);
        }
            
        [HttpGet]
        public ActionResult StoreDetails(int storenumber)
        {
            RxMapModel rxMapModel = new RxMapModel();
            rxMapModel =(new PharmacySearchService()).GetPharmacyDetail(storenumber);
            return View(rxMapModel);
        }
        public ActionResult Directions()
        {
            return View();
        }
        //string _Latitude;
        //string _Longitude;
        //string _storeCode;
        ////
        //// GET: /Search/
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //public ViewResult Result()
        
        
        //{
        //    _storeCode = Request.QueryString["storecode"];

        //    _Latitude = Request.QueryString["Latitude"];
        //    _Longitude = Request.QueryString["Longitude"];
        //   IEnumerable<RxMapModel> store;
        //     SearchService objSearch = new SearchService();
        //    if (string.IsNullOrEmpty(_storeCode))
        //    {
               
        //        store = objSearch.GeStoreListBasedOnLatnLng(double.Parse(_Latitude), double.Parse(_Longitude));
        //       return View(store);
        //    }
        //    else
        //    {
        //        store = objSearch.GeStoreDetailsBasedOnStoreNumber(Convert.ToInt32(_storeCode));
        //        return View(store);
        //    }
        //}

        //public ViewResult Directions()
        //{
        //    return View();
        //}
        //public ViewResult StoreDetails()
        //{
        //    return View();
        //}
        //public JsonResult GetLocations()
        //{
        //    _storeCode = Request.QueryString["storecode"];
        //    _Latitude = Request.QueryString["Latitude"];
        //    _Longitude = Request.QueryString["Longitude"];

        //    IEnumerable<RxMapModel> store;
        //    SearchService objSearch = new SearchService();
        //    if (string.IsNullOrEmpty(_storeCode))
        //    {

        //        store = objSearch.GeStoreListBasedOnLatnLng(double.Parse(_Latitude), double.Parse(_Longitude));
                
        //    }
        //    else
        //    {
        //        store = objSearch.GeStoreDetailsBasedOnStoreNumber(Convert.ToInt32(_storeCode));
                
        //    }

        //    return Json(store, JsonRequestBehavior.AllowGet);
        //}

        //[HttpPost]
        //public ActionResult Index(string Zipcode)
        //{
        //    return View();
        //}
    }
}