using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Taskrouter.V1 
{

    /// <summary>
    /// WorkspaceResource
    /// </summary>
    public class WorkspaceResource : Resource 
    {
        public sealed class QueueOrderEnum : StringEnum 
        {
            private QueueOrderEnum(string value) : base(value) {}
            public QueueOrderEnum() {}
        
            public static readonly QueueOrderEnum Fifo = new QueueOrderEnum("FIFO");
            public static readonly QueueOrderEnum Lifo = new QueueOrderEnum("LIFO");
        }
    
        private static Request BuildFetchRequest(FetchWorkspaceOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Taskrouter,
                "/v1/Workspaces/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="options"> Fetch Workspace parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Workspace </returns> 
        public static WorkspaceResource Fetch(FetchWorkspaceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
    
        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="options"> Fetch Workspace parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Workspace </returns> 
        public static async System.Threading.Tasks.Task<WorkspaceResource> FetchAsync(FetchWorkspaceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Workspace </returns> 
        public static WorkspaceResource Fetch(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchWorkspaceOptions(pathSid);
            return Fetch(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Workspace </returns> 
        public static async System.Threading.Tasks.Task<WorkspaceResource> FetchAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchWorkspaceOptions(pathSid);
            return await FetchAsync(options, client);
        }
        #endif
    
        private static Request BuildUpdateRequest(UpdateWorkspaceOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Taskrouter,
                "/v1/Workspaces/" + options.PathSid + "",
                client.Region,
                postParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="options"> Update Workspace parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Workspace </returns> 
        public static WorkspaceResource Update(UpdateWorkspaceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
    
        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="options"> Update Workspace parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Workspace </returns> 
        public static async System.Threading.Tasks.Task<WorkspaceResource> UpdateAsync(UpdateWorkspaceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        /// <param name="defaultActivitySid"> The default_activity_sid </param>
        /// <param name="eventCallbackUrl"> The event_callback_url </param>
        /// <param name="eventsFilter"> The events_filter </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="multiTaskEnabled"> The multi_task_enabled </param>
        /// <param name="timeoutActivitySid"> The timeout_activity_sid </param>
        /// <param name="prioritizeQueueOrder"> The prioritize_queue_order </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Workspace </returns> 
        public static WorkspaceResource Update(string pathSid, string defaultActivitySid = null, Uri eventCallbackUrl = null, string eventsFilter = null, string friendlyName = null, bool? multiTaskEnabled = null, string timeoutActivitySid = null, WorkspaceResource.QueueOrderEnum prioritizeQueueOrder = null, ITwilioRestClient client = null)
        {
            var options = new UpdateWorkspaceOptions(pathSid){DefaultActivitySid = defaultActivitySid, EventCallbackUrl = eventCallbackUrl, EventsFilter = eventsFilter, FriendlyName = friendlyName, MultiTaskEnabled = multiTaskEnabled, TimeoutActivitySid = timeoutActivitySid, PrioritizeQueueOrder = prioritizeQueueOrder};
            return Update(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        /// <param name="defaultActivitySid"> The default_activity_sid </param>
        /// <param name="eventCallbackUrl"> The event_callback_url </param>
        /// <param name="eventsFilter"> The events_filter </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="multiTaskEnabled"> The multi_task_enabled </param>
        /// <param name="timeoutActivitySid"> The timeout_activity_sid </param>
        /// <param name="prioritizeQueueOrder"> The prioritize_queue_order </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Workspace </returns> 
        public static async System.Threading.Tasks.Task<WorkspaceResource> UpdateAsync(string pathSid, string defaultActivitySid = null, Uri eventCallbackUrl = null, string eventsFilter = null, string friendlyName = null, bool? multiTaskEnabled = null, string timeoutActivitySid = null, WorkspaceResource.QueueOrderEnum prioritizeQueueOrder = null, ITwilioRestClient client = null)
        {
            var options = new UpdateWorkspaceOptions(pathSid){DefaultActivitySid = defaultActivitySid, EventCallbackUrl = eventCallbackUrl, EventsFilter = eventsFilter, FriendlyName = friendlyName, MultiTaskEnabled = multiTaskEnabled, TimeoutActivitySid = timeoutActivitySid, PrioritizeQueueOrder = prioritizeQueueOrder};
            return await UpdateAsync(options, client);
        }
        #endif
    
        private static Request BuildReadRequest(ReadWorkspaceOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Taskrouter,
                "/v1/Workspaces",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="options"> Read Workspace parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Workspace </returns> 
        public static ResourceSet<WorkspaceResource> Read(ReadWorkspaceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            
            var page = Page<WorkspaceResource>.FromJson("workspaces", response.Content);
            return new ResourceSet<WorkspaceResource>(page, options, client);
        }
    
        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="options"> Read Workspace parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Workspace </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<WorkspaceResource>> ReadAsync(ReadWorkspaceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));
            
            var page = Page<WorkspaceResource>.FromJson("workspaces", response.Content);
            return new ResourceSet<WorkspaceResource>(page, options, client);
        }
        #endif
    
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Workspace </returns> 
        public static ResourceSet<WorkspaceResource> Read(string friendlyName = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadWorkspaceOptions{FriendlyName = friendlyName, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Workspace </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<WorkspaceResource>> ReadAsync(string friendlyName = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadWorkspaceOptions{FriendlyName = friendlyName, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        ///
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns> 
        public static Page<WorkspaceResource> NextPage(Page<WorkspaceResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Taskrouter,
                    client.Region
                )
            );
            
            var response = client.Request(request);
            return Page<WorkspaceResource>.FromJson("workspaces", response.Content);
        }
    
        private static Request BuildCreateRequest(CreateWorkspaceOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Taskrouter,
                "/v1/Workspaces",
                client.Region,
                postParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="options"> Create Workspace parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Workspace </returns> 
        public static WorkspaceResource Create(CreateWorkspaceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
    
        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="options"> Create Workspace parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Workspace </returns> 
        public static async System.Threading.Tasks.Task<WorkspaceResource> CreateAsync(CreateWorkspaceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="eventCallbackUrl"> The event_callback_url </param>
        /// <param name="eventsFilter"> The events_filter </param>
        /// <param name="multiTaskEnabled"> The multi_task_enabled </param>
        /// <param name="template"> The template </param>
        /// <param name="prioritizeQueueOrder"> The prioritize_queue_order </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Workspace </returns> 
        public static WorkspaceResource Create(string friendlyName, Uri eventCallbackUrl = null, string eventsFilter = null, bool? multiTaskEnabled = null, string template = null, WorkspaceResource.QueueOrderEnum prioritizeQueueOrder = null, ITwilioRestClient client = null)
        {
            var options = new CreateWorkspaceOptions(friendlyName){EventCallbackUrl = eventCallbackUrl, EventsFilter = eventsFilter, MultiTaskEnabled = multiTaskEnabled, Template = template, PrioritizeQueueOrder = prioritizeQueueOrder};
            return Create(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="eventCallbackUrl"> The event_callback_url </param>
        /// <param name="eventsFilter"> The events_filter </param>
        /// <param name="multiTaskEnabled"> The multi_task_enabled </param>
        /// <param name="template"> The template </param>
        /// <param name="prioritizeQueueOrder"> The prioritize_queue_order </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Workspace </returns> 
        public static async System.Threading.Tasks.Task<WorkspaceResource> CreateAsync(string friendlyName, Uri eventCallbackUrl = null, string eventsFilter = null, bool? multiTaskEnabled = null, string template = null, WorkspaceResource.QueueOrderEnum prioritizeQueueOrder = null, ITwilioRestClient client = null)
        {
            var options = new CreateWorkspaceOptions(friendlyName){EventCallbackUrl = eventCallbackUrl, EventsFilter = eventsFilter, MultiTaskEnabled = multiTaskEnabled, Template = template, PrioritizeQueueOrder = prioritizeQueueOrder};
            return await CreateAsync(options, client);
        }
        #endif
    
        private static Request BuildDeleteRequest(DeleteWorkspaceOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Taskrouter,
                "/v1/Workspaces/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="options"> Delete Workspace parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Workspace </returns> 
        public static bool Delete(DeleteWorkspaceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
    
        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="options"> Delete Workspace parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Workspace </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteWorkspaceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif
    
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Workspace </returns> 
        public static bool Delete(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteWorkspaceOptions(pathSid);
            return Delete(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Workspace </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteWorkspaceOptions(pathSid);
            return await DeleteAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a WorkspaceResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> WorkspaceResource object represented by the provided JSON </returns> 
        public static WorkspaceResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<WorkspaceResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }
    
        /// <summary>
        /// The account_sid
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The date_created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date_updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The default_activity_name
        /// </summary>
        [JsonProperty("default_activity_name")]
        public string DefaultActivityName { get; private set; }
        /// <summary>
        /// The default_activity_sid
        /// </summary>
        [JsonProperty("default_activity_sid")]
        public string DefaultActivitySid { get; private set; }
        /// <summary>
        /// The event_callback_url
        /// </summary>
        [JsonProperty("event_callback_url")]
        public Uri EventCallbackUrl { get; private set; }
        /// <summary>
        /// The events_filter
        /// </summary>
        [JsonProperty("events_filter")]
        public string EventsFilter { get; private set; }
        /// <summary>
        /// The friendly_name
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// The multi_task_enabled
        /// </summary>
        [JsonProperty("multi_task_enabled")]
        public bool? MultiTaskEnabled { get; private set; }
        /// <summary>
        /// The sid
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The timeout_activity_name
        /// </summary>
        [JsonProperty("timeout_activity_name")]
        public string TimeoutActivityName { get; private set; }
        /// <summary>
        /// The timeout_activity_sid
        /// </summary>
        [JsonProperty("timeout_activity_sid")]
        public string TimeoutActivitySid { get; private set; }
        /// <summary>
        /// The prioritize_queue_order
        /// </summary>
        [JsonProperty("prioritize_queue_order")]
        [JsonConverter(typeof(StringEnumConverter))]
        public WorkspaceResource.QueueOrderEnum PrioritizeQueueOrder { get; private set; }
        /// <summary>
        /// The url
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// The links
        /// </summary>
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }
    
        private WorkspaceResource()
        {
        
        }
    }

}