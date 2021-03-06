﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace RM.QuickLogOn.OAuth.ViewModels
{
    [DataContract]
    public class FacebookUserInfoJsonViewModel
    {

        [DataMember]
        public string name { get; set; }

        [DataMember]
        public string email { get; set; }

        [DataMember]
        public bool verified { get; set; }
    }
}
