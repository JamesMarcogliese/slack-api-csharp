// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Slack.Api.CSharp.WebApi.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// file object
    /// </summary>
    public partial class ObjsFile
    {
        /// <summary>
        /// Initializes a new instance of the ObjsFile class.
        /// </summary>
        public ObjsFile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ObjsFile class.
        /// </summary>
        public ObjsFile(IList<string> channels = default(IList<string>), int? commentsCount = default(int?), int? created = default(int?), bool? displayAsBot = default(bool?), bool? editable = default(bool?), string externalType = default(string), string filetype = default(string), IList<string> groups = default(IList<string>), string id = default(string), int? imageExifRotation = default(int?), IList<string> ims = default(IList<string>), bool? isExternal = default(bool?), bool? isPublic = default(bool?), string mimetype = default(string), string mode = default(string), string name = default(string), int? originalH = default(int?), int? originalW = default(int?), string permalink = default(string), string permalinkPublic = default(string), IDictionary<string, DefsPinnedInfoValue> pinnedInfo = default(IDictionary<string, DefsPinnedInfoValue>), IList<string> pinnedTo = default(IList<string>), string prettyType = default(string), bool? publicUrlShared = default(bool?), IList<ObjsReaction> reactions = default(IList<ObjsReaction>), int? size = default(int?), string thumb1024 = default(string), int? thumb1024H = default(int?), int? thumb1024W = default(int?), string thumb160 = default(string), string thumb360 = default(string), int? thumb360H = default(int?), int? thumb360W = default(int?), string thumb480 = default(string), int? thumb480H = default(int?), int? thumb480W = default(int?), string thumb64 = default(string), string thumb720 = default(string), int? thumb720H = default(int?), int? thumb720W = default(int?), string thumb80 = default(string), string thumb800 = default(string), int? thumb800H = default(int?), int? thumb800W = default(int?), string thumb960 = default(string), int? thumb960H = default(int?), int? thumb960W = default(int?), int? timestamp = default(int?), string title = default(string), string urlPrivate = default(string), string urlPrivateDownload = default(string), string user = default(string), string username = default(string))
        {
            Channels = channels;
            CommentsCount = commentsCount;
            Created = created;
            DisplayAsBot = displayAsBot;
            Editable = editable;
            ExternalType = externalType;
            Filetype = filetype;
            Groups = groups;
            Id = id;
            ImageExifRotation = imageExifRotation;
            Ims = ims;
            IsExternal = isExternal;
            IsPublic = isPublic;
            Mimetype = mimetype;
            Mode = mode;
            Name = name;
            OriginalH = originalH;
            OriginalW = originalW;
            Permalink = permalink;
            PermalinkPublic = permalinkPublic;
            PinnedInfo = pinnedInfo;
            PinnedTo = pinnedTo;
            PrettyType = prettyType;
            PublicUrlShared = publicUrlShared;
            Reactions = reactions;
            Size = size;
            Thumb1024 = thumb1024;
            Thumb1024H = thumb1024H;
            Thumb1024W = thumb1024W;
            Thumb160 = thumb160;
            Thumb360 = thumb360;
            Thumb360H = thumb360H;
            Thumb360W = thumb360W;
            Thumb480 = thumb480;
            Thumb480H = thumb480H;
            Thumb480W = thumb480W;
            Thumb64 = thumb64;
            Thumb720 = thumb720;
            Thumb720H = thumb720H;
            Thumb720W = thumb720W;
            Thumb80 = thumb80;
            Thumb800 = thumb800;
            Thumb800H = thumb800H;
            Thumb800W = thumb800W;
            Thumb960 = thumb960;
            Thumb960H = thumb960H;
            Thumb960W = thumb960W;
            Timestamp = timestamp;
            Title = title;
            UrlPrivate = urlPrivate;
            UrlPrivateDownload = urlPrivateDownload;
            User = user;
            Username = username;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "channels")]
        public IList<string> Channels { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "comments_count")]
        public int? CommentsCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "created")]
        public int? Created { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "display_as_bot")]
        public bool? DisplayAsBot { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "editable")]
        public bool? Editable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "external_type")]
        public string ExternalType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "filetype")]
        public string Filetype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "groups")]
        public IList<string> Groups { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "image_exif_rotation")]
        public int? ImageExifRotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ims")]
        public IList<string> Ims { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "is_external")]
        public bool? IsExternal { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "is_public")]
        public bool? IsPublic { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mimetype")]
        public string Mimetype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public string Mode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "original_h")]
        public int? OriginalH { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "original_w")]
        public int? OriginalW { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "permalink")]
        public string Permalink { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "permalink_public")]
        public string PermalinkPublic { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pinned_info")]
        public IDictionary<string, DefsPinnedInfoValue> PinnedInfo { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pinned_to")]
        public IList<string> PinnedTo { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pretty_type")]
        public string PrettyType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "public_url_shared")]
        public bool? PublicUrlShared { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "reactions")]
        public IList<ObjsReaction> Reactions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        public int? Size { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "thumb_1024")]
        public string Thumb1024 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "thumb_1024_h")]
        public int? Thumb1024H { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "thumb_1024_w")]
        public int? Thumb1024W { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "thumb_160")]
        public string Thumb160 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "thumb_360")]
        public string Thumb360 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "thumb_360_h")]
        public int? Thumb360H { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "thumb_360_w")]
        public int? Thumb360W { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "thumb_480")]
        public string Thumb480 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "thumb_480_h")]
        public int? Thumb480H { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "thumb_480_w")]
        public int? Thumb480W { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "thumb_64")]
        public string Thumb64 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "thumb_720")]
        public string Thumb720 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "thumb_720_h")]
        public int? Thumb720H { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "thumb_720_w")]
        public int? Thumb720W { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "thumb_80")]
        public string Thumb80 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "thumb_800")]
        public string Thumb800 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "thumb_800_h")]
        public int? Thumb800H { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "thumb_800_w")]
        public int? Thumb800W { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "thumb_960")]
        public string Thumb960 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "thumb_960_h")]
        public int? Thumb960H { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "thumb_960_w")]
        public int? Thumb960W { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public int? Timestamp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "url_private")]
        public string UrlPrivate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "url_private_download")]
        public string UrlPrivateDownload { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "user")]
        public string User { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Channels != null)
            {
                if (Channels.Count != System.Linq.Enumerable.Count(System.Linq.Enumerable.Distinct(Channels)))
                {
                    throw new ValidationException(ValidationRules.UniqueItems, "Channels");
                }
            }
            if (Groups != null)
            {
                if (Groups.Count != System.Linq.Enumerable.Count(System.Linq.Enumerable.Distinct(Groups)))
                {
                    throw new ValidationException(ValidationRules.UniqueItems, "Groups");
                }
            }
            if (Ims != null)
            {
                if (Ims.Count != System.Linq.Enumerable.Count(System.Linq.Enumerable.Distinct(Ims)))
                {
                    throw new ValidationException(ValidationRules.UniqueItems, "Ims");
                }
            }
            if (PinnedInfo != null)
            {
                foreach (var valueElement in PinnedInfo.Values)
                {
                    if (valueElement != null)
                    {
                        valueElement.Validate();
                    }
                }
            }
            if (Reactions != null)
            {
                foreach (var element in Reactions)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}