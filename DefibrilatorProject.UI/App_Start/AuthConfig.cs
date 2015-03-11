using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DefibrilatorProject.BusinessLogic.Accounts;
using Microsoft.Web.WebPages.OAuth;
using DefibrilatorProject.Models.Models;

namespace DefibrilatorProject.UI
{
    public static class AuthConfig
    {
        private static readonly AccountManager _accountManager = new AccountManager();
        public static void RegisterAuth()
        {
            _accountManager.InitializeSimpleMembership();
            // To let users of this site log in using their accounts from other sites such as Microsoft, Facebook, and Twitter,
            // you must update this site. For more information visit http://go.microsoft.com/fwlink/?LinkID=252166

            //OAuthWebSecurity.RegisterMicrosoftClient(
            //    clientId: "",
            //    clientSecret: "");

            //OAuthWebSecurity.RegisterTwitterClient(
            //    consumerKey: "",
            //    consumerSecret: "");

            //OAuthWebSecurity.RegisterFacebookClient(
            //    appId: "",
            //    appSecret: "");

            //OAuthWebSecurity.RegisterGoogleClient();
        }
    }
}
