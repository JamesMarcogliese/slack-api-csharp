// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Slack.Api.CSharp.WebApi.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ObjsUser
    {
        /// <summary>
        /// Initializes a new instance of the ObjsUser class.
        /// </summary>
        public ObjsUser()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ObjsUser class.
        /// </summary>
        public ObjsUser(string color, bool deleted, string id, bool isAdmin, bool isAppUser, bool isBot, bool isOwner, bool isPrimaryOwner, bool isRestricted, bool isUltraRestricted, string name, ObjsUserProfile profile, string realName, string teamId, string tz, string tzLabel, int tzOffset, int updated, bool? has2fa = default(bool?), string locale = default(string), string presence = default(string))
        {
            Color = color;
            Deleted = deleted;
            Has2fa = has2fa;
            Id = id;
            IsAdmin = isAdmin;
            IsAppUser = isAppUser;
            IsBot = isBot;
            IsOwner = isOwner;
            IsPrimaryOwner = isPrimaryOwner;
            IsRestricted = isRestricted;
            IsUltraRestricted = isUltraRestricted;
            Locale = locale;
            Name = name;
            Presence = presence;
            Profile = profile;
            RealName = realName;
            TeamId = teamId;
            Tz = tz;
            TzLabel = tzLabel;
            TzOffset = tzOffset;
            Updated = updated;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "color")]
        public string Color { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "deleted")]
        public bool Deleted { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "has_2fa")]
        public bool? Has2fa { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "is_admin")]
        public bool IsAdmin { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "is_app_user")]
        public bool IsAppUser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "is_bot")]
        public bool IsBot { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "is_owner")]
        public bool IsOwner { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "is_primary_owner")]
        public bool IsPrimaryOwner { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "is_restricted")]
        public bool IsRestricted { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "is_ultra_restricted")]
        public bool IsUltraRestricted { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "locale")]
        public string Locale { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "presence")]
        public string Presence { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "profile")]
        public ObjsUserProfile Profile { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "real_name")]
        public string RealName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "team_id")]
        public string TeamId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tz")]
        public string Tz { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tz_label")]
        public string TzLabel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tz_offset")]
        public int TzOffset { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "updated")]
        public int Updated { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Color == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Color");
            }
            if (Id == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Id");
            }
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Profile == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Profile");
            }
            if (RealName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RealName");
            }
            if (TeamId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TeamId");
            }
            if (Tz == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Tz");
            }
            if (TzLabel == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TzLabel");
            }
            if (Color != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(Color, "^[a-fA-F0-9]{6}$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "Color", "^[a-fA-F0-9]{6}$");
                }
            }
            if (Profile != null)
            {
                Profile.Validate();
            }
        }
    }
}
