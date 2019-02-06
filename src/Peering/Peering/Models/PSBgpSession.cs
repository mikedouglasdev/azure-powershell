// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.PowerShell.Cmdlets.Peering.Common.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The peering session configuration class.
    /// </summary>
    public partial class PSBgpSession
    {
        /// <summary>
        /// Initializes a new instance of the PSBgpSession class.
        /// </summary>
        public PSBgpSession()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PSBgpSession class.
        /// </summary>
        /// <param name="sessionPrefixV4">Gets or sets the IP v4 session
        /// prefix.</param>
        /// <param name="sessionPrefixV6">Gets or sets the IP v6 session
        /// prefix.</param>
        /// <param name="microsoftSessionIPv4Address">Gets or sets the IP v4
        /// session prefix.</param>
        /// <param name="microsoftSessionIPv6Address">Gets or sets the IP v6
        /// session prefix.</param>
        /// <param name="peerSessionIPv4Address">Gets or sets the peer session
        /// IP v4 address.</param>
        /// <param name="peerSessionIPv6Address">Gets or sets the peer session
        /// IP v6 address.</param>
        /// <param name="sessionStateV4">Gets or sets the IP v4 BGP Session
        /// state. Possible values include: 'None', 'Idle', 'Connect',
        /// 'Active', 'OpenSent', 'OpenConfirm', 'Established'</param>
        /// <param name="sessionStateV6">Gets or sets the IP v6 BGP Session
        /// state. Possible values include: 'None', 'Idle', 'Connect',
        /// 'Active', 'OpenSent', 'OpenConfirm', 'Established'</param>
        /// <param name="maxPrefixesAdvertisedV4">Gets or sets the Max Prefix
        /// Advertised v4.</param>
        /// <param name="maxPrefixesAdvertisedV6">Gets or sets the Max Prefix
        /// Advertised v6.</param>
        /// <param name="md5AuthenticationKey">Gets or sets the MD5
        /// authentication key.</param>
        public PSBgpSession(string sessionPrefixV4 = default(string), string sessionPrefixV6 = default(string), string microsoftSessionIPv4Address = default(string), string microsoftSessionIPv6Address = default(string), string peerSessionIPv4Address = default(string), string peerSessionIPv6Address = default(string), string sessionStateV4 = default(string), string sessionStateV6 = default(string), int? maxPrefixesAdvertisedV4 = default(int?), int? maxPrefixesAdvertisedV6 = default(int?), string md5AuthenticationKey = default(string))
        {
            SessionPrefixV4 = sessionPrefixV4;
            SessionPrefixV6 = sessionPrefixV6;
            MicrosoftSessionIPv4Address = microsoftSessionIPv4Address;
            MicrosoftSessionIPv6Address = microsoftSessionIPv6Address;
            PeerSessionIPv4Address = peerSessionIPv4Address;
            PeerSessionIPv6Address = peerSessionIPv6Address;
            SessionStateV4 = sessionStateV4;
            SessionStateV6 = sessionStateV6;
            MaxPrefixesAdvertisedV4 = maxPrefixesAdvertisedV4;
            MaxPrefixesAdvertisedV6 = maxPrefixesAdvertisedV6;
            Md5AuthenticationKey = md5AuthenticationKey;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the IP v4 session prefix.
        /// </summary>
        [JsonProperty(PropertyName = "sessionPrefixV4")]
        public string SessionPrefixV4 { get; set; }

        /// <summary>
        /// Gets or sets the IP v6 session prefix.
        /// </summary>
        [JsonProperty(PropertyName = "sessionPrefixV6")]
        public string SessionPrefixV6 { get; set; }

        /// <summary>
        /// Gets or sets the IP v4 session prefix.
        /// </summary>
        [JsonProperty(PropertyName = "microsoftSessionIPv4Address")]
        public string MicrosoftSessionIPv4Address { get; set; }

        /// <summary>
        /// Gets or sets the IP v6 session prefix.
        /// </summary>
        [JsonProperty(PropertyName = "microsoftSessionIPv6Address")]
        public string MicrosoftSessionIPv6Address { get; set; }

        /// <summary>
        /// Gets or sets the peer session IP v4 address.
        /// </summary>
        [JsonProperty(PropertyName = "peerSessionIPv4Address")]
        public string PeerSessionIPv4Address { get; set; }

        /// <summary>
        /// Gets or sets the peer session IP v6 address.
        /// </summary>
        [JsonProperty(PropertyName = "peerSessionIPv6Address")]
        public string PeerSessionIPv6Address { get; set; }

        /// <summary>
        /// Gets or sets the IP v4 BGP Session state. Possible values include:
        /// 'None', 'Idle', 'Connect', 'Active', 'OpenSent', 'OpenConfirm',
        /// 'Established'
        /// </summary>
        [JsonProperty(PropertyName = "sessionStateV4")]
        public string SessionStateV4 { get; set; }

        /// <summary>
        /// Gets or sets the IP v6 BGP Session state. Possible values include:
        /// 'None', 'Idle', 'Connect', 'Active', 'OpenSent', 'OpenConfirm',
        /// 'Established'
        /// </summary>
        [JsonProperty(PropertyName = "sessionStateV6")]
        public string SessionStateV6 { get; set; }

        /// <summary>
        /// Gets or sets the Max Prefix Advertised v4.
        /// </summary>
        [JsonProperty(PropertyName = "maxPrefixesAdvertisedV4")]
        public int? MaxPrefixesAdvertisedV4 { get; set; }

        /// <summary>
        /// Gets or sets the Max Prefix Advertised v6.
        /// </summary>
        [JsonProperty(PropertyName = "maxPrefixesAdvertisedV6")]
        public int? MaxPrefixesAdvertisedV6 { get; set; }

        /// <summary>
        /// Gets or sets the MD5 authentication key.
        /// </summary>
        [JsonProperty(PropertyName = "md5AuthenticationKey")]
        public string Md5AuthenticationKey { get; set; }

    }
}
