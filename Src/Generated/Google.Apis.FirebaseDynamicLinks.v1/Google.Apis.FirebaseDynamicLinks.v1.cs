// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by google-apis-code-generator 1.5.1
//     C# generator version: 1.25.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

/**
 * \brief
 *   Firebase Dynamic Links API Version v1
 *
 * \section ApiInfo API Version Information
 *    <table>
 *      <tr><th>API
 *          <td><a href='https://firebase.google.com/docs/dynamic-links/'>Firebase Dynamic Links API</a>
 *      <tr><th>API Version<td>v1
 *      <tr><th>API Rev<td>20170515 (865)
 *      <tr><th>API Docs
 *          <td><a href='https://firebase.google.com/docs/dynamic-links/'>
 *              https://firebase.google.com/docs/dynamic-links/</a>
 *      <tr><th>Discovery Name<td>firebasedynamiclinks
 *    </table>
 *
 * \section ForMoreInfo For More Information
 *
 * The complete API documentation for using Firebase Dynamic Links API can be found at
 * <a href='https://firebase.google.com/docs/dynamic-links/'>https://firebase.google.com/docs/dynamic-links/</a>.
 *
 * For more information about the Google APIs Client Library for .NET, see
 * <a href='https://developers.google.com/api-client-library/dotnet/get_started'>
 * https://developers.google.com/api-client-library/dotnet/get_started</a>
 */

namespace Google.Apis.FirebaseDynamicLinks.v1
{
    /// <summary>The FirebaseDynamicLinks Service.</summary>
    public class FirebaseDynamicLinksService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed =
            Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public FirebaseDynamicLinksService() :
            this(new Google.Apis.Services.BaseClientService.Initializer()) {}

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public FirebaseDynamicLinksService(Google.Apis.Services.BaseClientService.Initializer initializer)
            : base(initializer)
        {
            shortLinks = new ShortLinksResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features
        {
            get { return new string[0]; }
        }

        /// <summary>Gets the service name.</summary>
        public override string Name
        {
            get { return "firebasedynamiclinks"; }
        }

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri
        {
            get { return "https://firebasedynamiclinks.googleapis.com/"; }
        }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath
        {
            get { return ""; }
        }

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri
        {
            get { return "https://firebasedynamiclinks.googleapis.com/batch"; }
        }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath
        {
            get { return "batch"; }
        }
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Firebase Dynamic Links API.</summary>
        public class Scope
        {
            /// <summary>View and administer all your Firebase data and settings</summary>
            public static string Firebase = "https://www.googleapis.com/auth/firebase";

        }



        private readonly ShortLinksResource shortLinks;

        /// <summary>Gets the ShortLinks resource.</summary>
        public virtual ShortLinksResource ShortLinks
        {
            get { return shortLinks; }
        }
    }

    ///<summary>A base abstract class for FirebaseDynamicLinks requests.</summary>
    public abstract class FirebaseDynamicLinksBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        ///<summary>Constructs a new FirebaseDynamicLinksBaseServiceRequest instance.</summary>
        protected FirebaseDynamicLinksBaseServiceRequest(Google.Apis.Services.IClientService service)
            : base(service)
        {
        }

        /// <summary>V1 error format.</summary>
        [Google.Apis.Util.RequestParameterAttribute("$.xgafv", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<XgafvEnum> Xgafv { get; set; }

        /// <summary>V1 error format.</summary>
        public enum XgafvEnum
        {
            /// <summary>v1 error format</summary>
            [Google.Apis.Util.StringValueAttribute("1")]
            Value1,
            /// <summary>v2 error format</summary>
            [Google.Apis.Util.StringValueAttribute("2")]
            Value2,
        }

        /// <summary>OAuth access token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("access_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string AccessToken { get; set; }

        /// <summary>Data format for response.</summary>
        /// [default: json]
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json,
            /// <summary>Media download with context-dependent Content-Type</summary>
            [Google.Apis.Util.StringValueAttribute("media")]
            Media,
            /// <summary>Responses with Content-Type of application/x-protobuf</summary>
            [Google.Apis.Util.StringValueAttribute("proto")]
            Proto,
        }

        /// <summary>OAuth bearer token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("bearer_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string BearerToken { get; set; }

        /// <summary>JSONP</summary>
        [Google.Apis.Util.RequestParameterAttribute("callback", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Callback { get; set; }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>API key. Your API key identifies your project and provides you with API access, quota, and reports.
        /// Required unless you provide an OAuth 2.0 token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Pretty-print response.</summary>
        /// [default: true]
        [Google.Apis.Util.RequestParameterAttribute("pp", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> Pp { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        /// [default: true]
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string
        /// assigned to a user, but should not exceed 40 characters.</summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadType { get; set; }

        /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadProtocol { get; set; }

        /// <summary>Initializes FirebaseDynamicLinks parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();

            RequestParameters.Add(
                "$.xgafv", new Google.Apis.Discovery.Parameter
                {
                    Name = "$.xgafv",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "access_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "access_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "alt", new Google.Apis.Discovery.Parameter
                {
                    Name = "alt",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "json",
                    Pattern = null,
                });
            RequestParameters.Add(
                "bearer_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "bearer_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "callback", new Google.Apis.Discovery.Parameter
                {
                    Name = "callback",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "fields", new Google.Apis.Discovery.Parameter
                {
                    Name = "fields",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "key", new Google.Apis.Discovery.Parameter
                {
                    Name = "key",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "oauth_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "oauth_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "pp", new Google.Apis.Discovery.Parameter
                {
                    Name = "pp",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
            RequestParameters.Add(
                "prettyPrint", new Google.Apis.Discovery.Parameter
                {
                    Name = "prettyPrint",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
            RequestParameters.Add(
                "quotaUser", new Google.Apis.Discovery.Parameter
                {
                    Name = "quotaUser",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "uploadType", new Google.Apis.Discovery.Parameter
                {
                    Name = "uploadType",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "upload_protocol", new Google.Apis.Discovery.Parameter
                {
                    Name = "upload_protocol",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
        }
    }

    /// <summary>The "shortLinks" collection of methods.</summary>
    public class ShortLinksResource
    {
        private const string Resource = "shortLinks";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ShortLinksResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Creates a short Dynamic Link given either a valid long Dynamic Link or details such as Dynamic Link
        /// domain, Android and iOS app information. The created short Dynamic Link will not expire.
        ///
        /// Repeated calls with the same long Dynamic Link or Dynamic Link information will produce the same short
        /// Dynamic Link.
        ///
        /// The Dynamic Link domain in the request must be owned by requester's Firebase project.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.FirebaseDynamicLinks.v1.Data.CreateShortDynamicLinkRequest body)
        {
            return new CreateRequest(service, body);
        }

        /// <summary>Creates a short Dynamic Link given either a valid long Dynamic Link or details such as Dynamic Link
        /// domain, Android and iOS app information. The created short Dynamic Link will not expire.
        ///
        /// Repeated calls with the same long Dynamic Link or Dynamic Link information will produce the same short
        /// Dynamic Link.
        ///
        /// The Dynamic Link domain in the request must be owned by requester's Firebase project.</summary>
        public class CreateRequest : FirebaseDynamicLinksBaseServiceRequest<Google.Apis.FirebaseDynamicLinks.v1.Data.CreateShortDynamicLinkResponse>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseDynamicLinks.v1.Data.CreateShortDynamicLinkRequest body)
                : base(service)
            {
                Body = body;
                InitParameters();
            }



            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.FirebaseDynamicLinks.v1.Data.CreateShortDynamicLinkRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() { return Body; }

            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "create"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "POST"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "v1/shortLinks"; }
            }

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }
    }
}

namespace Google.Apis.FirebaseDynamicLinks.v1.Data
{    

    /// <summary>Tracking parameters supported by Dynamic Link.</summary>
    public class AnalyticsInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Google Play Campaign Measurements.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googlePlayAnalytics")]
        public virtual GooglePlayAnalytics GooglePlayAnalytics { get; set; } 

        /// <summary>iTunes Connect App Analytics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itunesConnectAnalytics")]
        public virtual ITunesConnectAnalytics ItunesConnectAnalytics { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Android related attributes to the Dynamic Link.</summary>
    public class AndroidInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Link to open on Android if the app is not installed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidFallbackLink")]
        public virtual string AndroidFallbackLink { get; set; } 

        /// <summary>If specified, this overrides the ‘link’ parameter on Android.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidLink")]
        public virtual string AndroidLink { get; set; } 

        /// <summary>Minimum version code for the Android app. If the installed app’s version code is lower, then the
        /// user is taken to the Play Store.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidMinPackageVersionCode")]
        public virtual string AndroidMinPackageVersionCode { get; set; } 

        /// <summary>Android package name of the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidPackageName")]
        public virtual string AndroidPackageName { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Request to create a short Dynamic Link.</summary>
    public class CreateShortDynamicLinkRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Information about the Dynamic Link to be shortened. [Learn more](https://firebase.google.com/docs
        /// /dynamic-links/android#create-a-dynamic-link-programmatically).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dynamicLinkInfo")]
        public virtual DynamicLinkInfo DynamicLinkInfo { get; set; } 

        /// <summary>Full long Dynamic Link URL with desired query parameters specified. For example,
        /// "https://sample.app.goo.gl/?link=http://www.google.com=com.sample", [Learn
        /// more](https://firebase.google.com/docs/dynamic-links/android#create-a-dynamic-link-
        /// programmatically).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longDynamicLink")]
        public virtual string LongDynamicLink { get; set; } 

        /// <summary>Short Dynamic Link suffix. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suffix")]
        public virtual Suffix Suffix { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response to create a short Dynamic Link.</summary>
    public class CreateShortDynamicLinkResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Preivew link to show the link flow chart.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("previewLink")]
        public virtual string PreviewLink { get; set; } 

        /// <summary>Short Dynamic Link value. e.g. https://abcd.app.goo.gl/wxyz</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shortLink")]
        public virtual string ShortLink { get; set; } 

        /// <summary>Information about potential warnings on link creation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warning")]
        public virtual System.Collections.Generic.IList<DynamicLinkWarning> Warning { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Information about a Dynamic Link.</summary>
    public class DynamicLinkInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Parameters used for tracking. See all tracking parameters in the
        /// [documentation](https://firebase.google.com/docs/dynamic-links/create-manually).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analyticsInfo")]
        public virtual AnalyticsInfo AnalyticsInfo { get; set; } 

        /// <summary>Android related information. See Android related parameters in the
        /// [documentation](https://firebase.google.com/docs/dynamic-links/create-manually).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidInfo")]
        public virtual AndroidInfo AndroidInfo { get; set; } 

        /// <summary>Dynamic Links domain that the project owns, e.g. abcd.app.goo.gl [Learn
        /// more](https://firebase.google.com/docs/dynamic-links/android/receive) on how to set up Dynamic Link domain
        /// associated with your Firebase project.
        ///
        /// Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dynamicLinkDomain")]
        public virtual string DynamicLinkDomain { get; set; } 

        /// <summary>iOS related information. See iOS related parameters in the
        /// [documentation](https://firebase.google.com/docs/dynamic-links/create-manually).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iosInfo")]
        public virtual IosInfo IosInfo { get; set; } 

        /// <summary>The link your app will open, You can specify any URL your app can handle. This link must be a well-
        /// formatted URL, be properly URL-encoded, and use the HTTP or HTTPS scheme. See 'link' parameters in the
        /// [documentation](https://firebase.google.com/docs/dynamic-links/create-manually).
        ///
        /// Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("link")]
        public virtual string Link { get; set; } 

        /// <summary>Information of navigation behavior of a Firebase Dynamic Links.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("navigationInfo")]
        public virtual NavigationInfo NavigationInfo { get; set; } 

        /// <summary>Parameters for social meta tag params. Used to set meta tag data for link previews on social
        /// sites.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("socialMetaTagInfo")]
        public virtual SocialMetaTagInfo SocialMetaTagInfo { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Dynamic Links warning messages.</summary>
    public class DynamicLinkWarning : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The warning code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warningCode")]
        public virtual string WarningCode { get; set; } 

        /// <summary>The warning message to help developers improve their requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warningMessage")]
        public virtual string WarningMessage { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Parameters for Google Play Campaign Measurements. [Learn
    /// more](https://developers.google.com/analytics/devguides/collection/android/v4/campaigns#campaign-
    /// params)</summary>
    public class GooglePlayAnalytics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>[AdWords autotagging parameter](https://support.google.com/analytics/answer/1033981?hl=en); used to
        /// measure Google AdWords ads. This value is generated dynamically and should never be modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gclid")]
        public virtual string Gclid { get; set; } 

        /// <summary>Campaign name; used for keyword analysis to identify a specific product promotion or strategic
        /// campaign.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("utmCampaign")]
        public virtual string UtmCampaign { get; set; } 

        /// <summary>Campaign content; used for A/B testing and content-targeted ads to differentiate ads or links that
        /// point to the same URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("utmContent")]
        public virtual string UtmContent { get; set; } 

        /// <summary>Campaign medium; used to identify a medium such as email or cost-per-click.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("utmMedium")]
        public virtual string UtmMedium { get; set; } 

        /// <summary>Campaign source; used to identify a search engine, newsletter, or other source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("utmSource")]
        public virtual string UtmSource { get; set; } 

        /// <summary>Campaign term; used with paid search to supply the keywords for ads.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("utmTerm")]
        public virtual string UtmTerm { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Parameters for iTunes Connect App Analytics.</summary>
    public class ITunesConnectAnalytics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Affiliate token used to create affiliate-coded links.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("at")]
        public virtual string At { get; set; } 

        /// <summary>Campaign text that developers can optionally add to any link in order to track sales from a
        /// specific marketing campaign.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ct")]
        public virtual string Ct { get; set; } 

        /// <summary>iTune media types, including music, podcasts, audiobooks and so on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mt")]
        public virtual string Mt { get; set; } 

        /// <summary>Provider token that enables analytics for Dynamic Links from within iTunes Connect.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pt")]
        public virtual string Pt { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>iOS related attributes to the Dynamic Link..</summary>
    public class IosInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>iOS App Store ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iosAppStoreId")]
        public virtual string IosAppStoreId { get; set; } 

        /// <summary>iOS bundle ID of the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iosBundleId")]
        public virtual string IosBundleId { get; set; } 

        /// <summary>Custom (destination) scheme to use for iOS. By default, we’ll use the bundle ID as the custom
        /// scheme. Developer can override this behavior using this param.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iosCustomScheme")]
        public virtual string IosCustomScheme { get; set; } 

        /// <summary>Link to open on iOS if the app is not installed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iosFallbackLink")]
        public virtual string IosFallbackLink { get; set; } 

        /// <summary>iPad bundle ID of the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iosIpadBundleId")]
        public virtual string IosIpadBundleId { get; set; } 

        /// <summary>If specified, this overrides the ios_fallback_link value on iPads.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iosIpadFallbackLink")]
        public virtual string IosIpadFallbackLink { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Information of navigation behavior.</summary>
    public class NavigationInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If this option is on, FDL click will be forced to redirect rather than show an interstitial
        /// page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableForcedRedirect")]
        public virtual System.Nullable<bool> EnableForcedRedirect { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Parameters for social meta tag params. Used to set meta tag data for link previews on social
    /// sites.</summary>
    public class SocialMetaTagInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A short description of the link. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("socialDescription")]
        public virtual string SocialDescription { get; set; } 

        /// <summary>An image url string. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("socialImageLink")]
        public virtual string SocialImageLink { get; set; } 

        /// <summary>Title to be displayed. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("socialTitle")]
        public virtual string SocialTitle { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Short Dynamic Link suffix.</summary>
    public class Suffix : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Suffix option.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("option")]
        public virtual string Option { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
