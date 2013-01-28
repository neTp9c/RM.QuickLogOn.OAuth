using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orchard;
using Orchard.Environment.Extensions;
using RM.QuickLogOn.Providers;

namespace RM.QuickLogOn.OAuth.Providers
{
    [OrchardFeature("RM.QuickLogOn.OAuth.Twitter")]
    public class TwitterOAuthProvider : IQuickLogOnProvider
    {
        public string Name
        {
            get { return "Twitter"; }
        }

        public string Description
        {
            get { return "LogOn with Your Twitter account"; }
        }

        public string GetLogOnUrl(WorkContext context)
        {
            return "http://www.twitter.com";
        }
    }
}
