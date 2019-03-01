// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Bot.Connector
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Conversation account represents the identity of the conversation within
    /// a channel
    /// </summary>
    public partial class ConversationAccount
    {
        /// <summary>
        /// Initializes a new instance of the ConversationAccount class.
        /// </summary>
        public ConversationAccount()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConversationAccount class.
        /// </summary>
        /// <param name="isGroup">Indicates whether the conversation contains
        /// more than two participants at the time the activity was
        /// generated</param>
        /// <param name="conversationType">Indicates the type of the
        /// conversation in channels that distinguish between conversation
        /// types</param>
        /// <param name="id">Channel id for the user or bot on this channel
        /// (Example: joe@smith.com, or @joesmith or 123456)</param>
        /// <param name="name">Display friendly name</param>
        /// <param name="aadObjectId">This account's object ID within Azure
        /// Active Directory (AAD)</param>
        /// <param name="role">Role of the entity behind the account (Example:
        /// User, Bot, etc.). Possible values include: 'user', 'bot'</param>
        /// <param name="tenantId">This conversation's tenant ID</param>
        public ConversationAccount(bool? isGroup = default(bool?), string id = default(string), string name = default(string), string conversationType = default(string), string role = default(string), string aadObjectId = default(string), string tenantId = default(string))
        {
            IsGroup = isGroup;
            ConversationType = conversationType;
            TenantId = tenantId;
            Id = id;
            Name = name;
            AadObjectId = aadObjectId;
            Role = role;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets indicates whether the conversation contains more than
        /// two participants at the time the activity was generated
        /// </summary>
        [JsonProperty(PropertyName = "isGroup")]
        public bool? IsGroup { get; set; }

        /// <summary>
        /// Gets or sets indicates the type of the conversation in channels
        /// that distinguish between conversation types
        /// </summary>
        [JsonProperty(PropertyName = "conversationType")]
        public string ConversationType { get; set; }

        /// <summary>
        /// Gets or sets this conversation's tenant ID
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or sets channel id for the user or bot on this channel
        /// (Example: joe@smith.com, or @joesmith or 123456)
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets display friendly name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets this account's object ID within Azure Active Directory
        /// (AAD)
        /// </summary>
        [JsonProperty(PropertyName = "aadObjectId")]
        public string AadObjectId { get; set; }

        /// <summary>
        /// Gets or sets role of the entity behind the account (Example: User,
        /// Bot, etc.). Possible values include: 'user', 'bot'
        /// </summary>
        [JsonProperty(PropertyName = "role")]
        public string Role { get; set; }

    }
}
