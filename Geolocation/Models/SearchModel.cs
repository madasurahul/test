﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace Geolocation.Models
{
    public class SearchModel
    {
        [Required]
        public string SearchInput { get; set; }
    }
}