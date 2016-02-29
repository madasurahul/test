using Geolocation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geolocation.Services
{
    interface SearchInterface
    {
        //IEnumerable<RxMapModel> GetStoreListBasedonZeoCode(double latitude, double langitude);
        IEnumerable<RxMapModel> GeStoreListBasedOnLatnLng(double latitude, double langitude);
        IEnumerable<RxMapModel> GeStoreDetailsBasedOnStoreNumber(int storeNumber);
    }
}
