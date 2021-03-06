using System;
using System.Collections.Generic;
using Twilio.Base;

namespace Twilio.Rest.Taskrouter.V1.Workspace 
{

    /// <summary>
    /// FetchWorkflowOptions
    /// </summary>
    public class FetchWorkflowOptions : IOptions<WorkflowResource> 
    {
        /// <summary>
        /// The workspace_sid
        /// </summary>
        public string PathWorkspaceSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }
    
        /// <summary>
        /// Construct a new FetchWorkflowOptions
        /// </summary>
        ///
        /// <param name="pathWorkspaceSid"> The workspace_sid </param>
        /// <param name="pathSid"> The sid </param>
        public FetchWorkflowOptions(string pathWorkspaceSid, string pathSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
            PathSid = pathSid;
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// UpdateWorkflowOptions
    /// </summary>
    public class UpdateWorkflowOptions : IOptions<WorkflowResource> 
    {
        /// <summary>
        /// The workspace_sid
        /// </summary>
        public string PathWorkspaceSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// The friendly_name
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// The assignment_callback_url
        /// </summary>
        public Uri AssignmentCallbackUrl { get; set; }
        /// <summary>
        /// The fallback_assignment_callback_url
        /// </summary>
        public Uri FallbackAssignmentCallbackUrl { get; set; }
        /// <summary>
        /// The configuration
        /// </summary>
        public string Configuration { get; set; }
        /// <summary>
        /// The task_reservation_timeout
        /// </summary>
        public int? TaskReservationTimeout { get; set; }
    
        /// <summary>
        /// Construct a new UpdateWorkflowOptions
        /// </summary>
        ///
        /// <param name="pathWorkspaceSid"> The workspace_sid </param>
        /// <param name="pathSid"> The sid </param>
        public UpdateWorkflowOptions(string pathWorkspaceSid, string pathSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
            PathSid = pathSid;
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            
            if (AssignmentCallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("AssignmentCallbackUrl", AssignmentCallbackUrl.ToString()));
            }
            
            if (FallbackAssignmentCallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("FallbackAssignmentCallbackUrl", FallbackAssignmentCallbackUrl.ToString()));
            }
            
            if (Configuration != null)
            {
                p.Add(new KeyValuePair<string, string>("Configuration", Configuration));
            }
            
            if (TaskReservationTimeout != null)
            {
                p.Add(new KeyValuePair<string, string>("TaskReservationTimeout", TaskReservationTimeout.Value.ToString()));
            }
            
            return p;
        }
    }

    /// <summary>
    /// DeleteWorkflowOptions
    /// </summary>
    public class DeleteWorkflowOptions : IOptions<WorkflowResource> 
    {
        /// <summary>
        /// The workspace_sid
        /// </summary>
        public string PathWorkspaceSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }
    
        /// <summary>
        /// Construct a new DeleteWorkflowOptions
        /// </summary>
        ///
        /// <param name="pathWorkspaceSid"> The workspace_sid </param>
        /// <param name="pathSid"> The sid </param>
        public DeleteWorkflowOptions(string pathWorkspaceSid, string pathSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
            PathSid = pathSid;
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// ReadWorkflowOptions
    /// </summary>
    public class ReadWorkflowOptions : ReadOptions<WorkflowResource> 
    {
        /// <summary>
        /// The workspace_sid
        /// </summary>
        public string PathWorkspaceSid { get; }
        /// <summary>
        /// The friendly_name
        /// </summary>
        public string FriendlyName { get; set; }
    
        /// <summary>
        /// Construct a new ReadWorkflowOptions
        /// </summary>
        ///
        /// <param name="pathWorkspaceSid"> The workspace_sid </param>
        public ReadWorkflowOptions(string pathWorkspaceSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            
            return p;
        }
    }

    /// <summary>
    /// CreateWorkflowOptions
    /// </summary>
    public class CreateWorkflowOptions : IOptions<WorkflowResource> 
    {
        /// <summary>
        /// The workspace_sid
        /// </summary>
        public string PathWorkspaceSid { get; }
        /// <summary>
        /// The friendly_name
        /// </summary>
        public string FriendlyName { get; }
        /// <summary>
        /// The configuration
        /// </summary>
        public string Configuration { get; }
        /// <summary>
        /// The assignment_callback_url
        /// </summary>
        public Uri AssignmentCallbackUrl { get; set; }
        /// <summary>
        /// The fallback_assignment_callback_url
        /// </summary>
        public Uri FallbackAssignmentCallbackUrl { get; set; }
        /// <summary>
        /// The task_reservation_timeout
        /// </summary>
        public int? TaskReservationTimeout { get; set; }
    
        /// <summary>
        /// Construct a new CreateWorkflowOptions
        /// </summary>
        ///
        /// <param name="pathWorkspaceSid"> The workspace_sid </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="configuration"> The configuration </param>
        public CreateWorkflowOptions(string pathWorkspaceSid, string friendlyName, string configuration)
        {
            PathWorkspaceSid = pathWorkspaceSid;
            FriendlyName = friendlyName;
            Configuration = configuration;
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            
            if (Configuration != null)
            {
                p.Add(new KeyValuePair<string, string>("Configuration", Configuration));
            }
            
            if (AssignmentCallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("AssignmentCallbackUrl", AssignmentCallbackUrl.ToString()));
            }
            
            if (FallbackAssignmentCallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("FallbackAssignmentCallbackUrl", FallbackAssignmentCallbackUrl.ToString()));
            }
            
            if (TaskReservationTimeout != null)
            {
                p.Add(new KeyValuePair<string, string>("TaskReservationTimeout", TaskReservationTimeout.Value.ToString()));
            }
            
            return p;
        }
    }

}