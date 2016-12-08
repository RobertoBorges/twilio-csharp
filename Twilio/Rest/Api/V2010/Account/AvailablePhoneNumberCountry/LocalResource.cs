using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Api.V2010.Account.AvailablePhoneNumberCountry 
{

    public class LocalResource : Resource 
    {
        private static Request BuildReadRequest(ReadLocalOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.AccountSid ?? client.AccountSid) + "/AvailablePhoneNumbers/" + options.CountryCode + "/Local.json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// read
        /// </summary>
        public static ResourceSet<LocalResource> Read(ReadLocalOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            
            var page = Page<LocalResource>.FromJson("available_phone_numbers", response.Content);
            return new ResourceSet<LocalResource>(page, options, client);
        }
    
        #if NET40
        public static async System.Threading.Tasks.Task<ResourceSet<LocalResource>> ReadAsync(ReadLocalOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));
            
            var page = Page<LocalResource>.FromJson("available_phone_numbers", response.Content);
            return new ResourceSet<LocalResource>(page, options, client);
        }
        #endif
    
        /// <summary>
        /// read
        /// </summary>
        public static ResourceSet<LocalResource> Read(string countryCode, string accountSid = null, int? areaCode = null, string contains = null, bool? smsEnabled = null, bool? mmsEnabled = null, bool? voiceEnabled = null, bool? excludeAllAddressRequired = null, bool? excludeLocalAddressRequired = null, bool? excludeForeignAddressRequired = null, bool? beta = null, Types.PhoneNumber nearNumber = null, string nearLatLong = null, int? distance = null, string inPostalCode = null, string inRegion = null, string inRateCenter = null, string inLata = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadLocalOptions(countryCode){AccountSid = accountSid, AreaCode = areaCode, Contains = contains, SmsEnabled = smsEnabled, MmsEnabled = mmsEnabled, VoiceEnabled = voiceEnabled, ExcludeAllAddressRequired = excludeAllAddressRequired, ExcludeLocalAddressRequired = excludeLocalAddressRequired, ExcludeForeignAddressRequired = excludeForeignAddressRequired, Beta = beta, NearNumber = nearNumber, NearLatLong = nearLatLong, Distance = distance, InPostalCode = inPostalCode, InRegion = inRegion, InRateCenter = inRateCenter, InLata = inLata, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }
    
        #if NET40
        public static async System.Threading.Tasks.Task<ResourceSet<LocalResource>> ReadAsync(string countryCode, string accountSid = null, int? areaCode = null, string contains = null, bool? smsEnabled = null, bool? mmsEnabled = null, bool? voiceEnabled = null, bool? excludeAllAddressRequired = null, bool? excludeLocalAddressRequired = null, bool? excludeForeignAddressRequired = null, bool? beta = null, Types.PhoneNumber nearNumber = null, string nearLatLong = null, int? distance = null, string inPostalCode = null, string inRegion = null, string inRateCenter = null, string inLata = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadLocalOptions(countryCode){AccountSid = accountSid, AreaCode = areaCode, Contains = contains, SmsEnabled = smsEnabled, MmsEnabled = mmsEnabled, VoiceEnabled = voiceEnabled, ExcludeAllAddressRequired = excludeAllAddressRequired, ExcludeLocalAddressRequired = excludeLocalAddressRequired, ExcludeForeignAddressRequired = excludeForeignAddressRequired, Beta = beta, NearNumber = nearNumber, NearLatLong = nearLatLong, Distance = distance, InPostalCode = inPostalCode, InRegion = inRegion, InRateCenter = inRateCenter, InLata = inLata, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif
    
        public static Page<LocalResource> NextPage(Page<LocalResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Api,
                    client.Region
                )
            );
            
            var response = client.Request(request);
            return Page<LocalResource>.FromJson("available_phone_numbers", response.Content);
        }
    
        /// <summary>
        /// Converts a JSON string into a LocalResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> LocalResource object represented by the provided JSON </returns> 
        public static LocalResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<LocalResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }
    
        [JsonProperty("friendly_name")]
        [JsonConverter(typeof(PhoneNumberConverter))]
        public Types.PhoneNumber FriendlyName { get; private set; }
        [JsonProperty("phone_number")]
        [JsonConverter(typeof(PhoneNumberConverter))]
        public Types.PhoneNumber PhoneNumber { get; private set; }
        [JsonProperty("lata")]
        public string Lata { get; private set; }
        [JsonProperty("rate_center")]
        public string RateCenter { get; private set; }
        [JsonProperty("latitude")]
        public decimal? Latitude { get; private set; }
        [JsonProperty("longitude")]
        public decimal? Longitude { get; private set; }
        [JsonProperty("region")]
        public string Region { get; private set; }
        [JsonProperty("postal_code")]
        public string PostalCode { get; private set; }
        [JsonProperty("iso_country")]
        public string IsoCountry { get; private set; }
        [JsonProperty("address_requirements")]
        public string AddressRequirements { get; private set; }
        [JsonProperty("beta")]
        public bool? Beta { get; private set; }
        [JsonProperty("capabilities")]
        public PhoneNumberCapabilities Capabilities { get; private set; }
    
        private LocalResource()
        {
        
        }
    }

}