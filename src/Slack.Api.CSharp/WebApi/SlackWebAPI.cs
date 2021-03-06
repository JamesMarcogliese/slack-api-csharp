// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Slack.Api.CSharp.WebApi
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;

    /// <summary>
    /// One way to interact with the Slack platform is its HTTP RPC-based Web
    /// API, a collection of methods requiring OAuth 2.0-based user, bot, or
    /// workspace tokens blessed with related OAuth scopes.
    /// </summary>
    public partial class SlackWebAPI : ServiceClient<SlackWebAPI>, ISlackWebAPI
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        public System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        public JsonSerializerSettings SerializationSettings { get; private set; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        public JsonSerializerSettings DeserializationSettings { get; private set; }

        /// <summary>
        /// Gets the IApi.
        /// </summary>
        public virtual IApi Api { get; private set; }

        /// <summary>
        /// Gets the IApps.
        /// </summary>
        public virtual IApps Apps { get; private set; }

        /// <summary>
        /// Gets the IAuth.
        /// </summary>
        public virtual IAuth Auth { get; private set; }

        /// <summary>
        /// Gets the IBots.
        /// </summary>
        public virtual IBots Bots { get; private set; }

        /// <summary>
        /// Gets the IChannels.
        /// </summary>
        public virtual IChannels Channels { get; private set; }

        /// <summary>
        /// Gets the IChat.
        /// </summary>
        public virtual IChat Chat { get; private set; }

        /// <summary>
        /// Gets the IConversations.
        /// </summary>
        public virtual IConversations Conversations { get; private set; }

        /// <summary>
        /// Gets the IDialog.
        /// </summary>
        public virtual IDialog Dialog { get; private set; }

        /// <summary>
        /// Gets the IDnd.
        /// </summary>
        public virtual IDnd Dnd { get; private set; }

        /// <summary>
        /// Gets the IEmoji.
        /// </summary>
        public virtual IEmoji Emoji { get; private set; }

        /// <summary>
        /// Gets the IFiles.
        /// </summary>
        public virtual IFiles Files { get; private set; }

        /// <summary>
        /// Gets the IGroups.
        /// </summary>
        public virtual IGroups Groups { get; private set; }

        /// <summary>
        /// Gets the IIm.
        /// </summary>
        public virtual IIm Im { get; private set; }

        /// <summary>
        /// Gets the IMigration.
        /// </summary>
        public virtual IMigration Migration { get; private set; }

        /// <summary>
        /// Gets the IMpim.
        /// </summary>
        public virtual IMpim Mpim { get; private set; }

        /// <summary>
        /// Gets the IOauth.
        /// </summary>
        public virtual IOauth Oauth { get; private set; }

        /// <summary>
        /// Gets the IPins.
        /// </summary>
        public virtual IPins Pins { get; private set; }

        /// <summary>
        /// Gets the IReactions.
        /// </summary>
        public virtual IReactions Reactions { get; private set; }

        /// <summary>
        /// Gets the IReminders.
        /// </summary>
        public virtual IReminders Reminders { get; private set; }

        /// <summary>
        /// Gets the IRtm.
        /// </summary>
        public virtual IRtm Rtm { get; private set; }

        /// <summary>
        /// Gets the ISearch.
        /// </summary>
        public virtual ISearch Search { get; private set; }

        /// <summary>
        /// Gets the IStars.
        /// </summary>
        public virtual IStars Stars { get; private set; }

        /// <summary>
        /// Gets the ITeam.
        /// </summary>
        public virtual ITeam Team { get; private set; }

        /// <summary>
        /// Gets the IUsergroups.
        /// </summary>
        public virtual IUsergroups Usergroups { get; private set; }

        /// <summary>
        /// Gets the IUsers.
        /// </summary>
        public virtual IUsers Users { get; private set; }

        /// <summary>
        /// Initializes a new instance of the SlackWebAPI class.
        /// </summary>
        /// <param name='httpClient'>
        /// HttpClient to be used
        /// </param>
        /// <param name='disposeHttpClient'>
        /// True: will dispose the provided httpClient on calling SlackWebAPI.Dispose(). False: will not dispose provided httpClient</param>
        public SlackWebAPI(HttpClient httpClient, bool disposeHttpClient) : base(httpClient, disposeHttpClient)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the SlackWebAPI class.
        /// </summary>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        public SlackWebAPI(params DelegatingHandler[] handlers) : base(handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the SlackWebAPI class.
        /// </summary>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        public SlackWebAPI(HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : base(rootHandler, handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the SlackWebAPI class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public SlackWebAPI(System.Uri baseUri, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the SlackWebAPI class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public SlackWebAPI(System.Uri baseUri, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// An optional partial-method to perform custom initialization.
        ///</summary>
        partial void CustomInitialize();
        /// <summary>
        /// Initializes client properties.
        /// </summary>
        private void Initialize()
        {
            Api = new Api(this);
            Apps = new Apps(this);
            Auth = new Auth(this);
            Bots = new Bots(this);
            Channels = new Channels(this);
            Chat = new Chat(this);
            Conversations = new Conversations(this);
            Dialog = new Dialog(this);
            Dnd = new Dnd(this);
            Emoji = new Emoji(this);
            Files = new Files(this);
            Groups = new Groups(this);
            Im = new Im(this);
            Migration = new Migration(this);
            Mpim = new Mpim(this);
            Oauth = new Oauth(this);
            Pins = new Pins(this);
            Reactions = new Reactions(this);
            Reminders = new Reminders(this);
            Rtm = new Rtm(this);
            Search = new Search(this);
            Stars = new Stars(this);
            Team = new Team(this);
            Usergroups = new Usergroups(this);
            Users = new Users(this);
            BaseUri = new System.Uri("https://slack.com/api");
            SerializationSettings = new JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new  List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            DeserializationSettings = new JsonSerializerSettings
            {
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            CustomInitialize();
        }
    }
}
