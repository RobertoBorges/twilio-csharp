using System;
using System.Collections.Generic;
using Twilio.Base;

namespace Twilio.Rest.Taskrouter.V1.Workspace 
{

    /// <summary>
    /// FetchTaskQueueOptions
    /// </summary>
    public class FetchTaskQueueOptions : IOptions<TaskQueueResource> 
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
        /// Construct a new FetchTaskQueueOptions
        /// </summary>
        ///
        /// <param name="pathWorkspaceSid"> The workspace_sid </param>
        /// <param name="pathSid"> The sid </param>
        public FetchTaskQueueOptions(string pathWorkspaceSid, string pathSid)
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
    /// UpdateTaskQueueOptions
    /// </summary>
    public class UpdateTaskQueueOptions : IOptions<TaskQueueResource> 
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
        /// The target_workers
        /// </summary>
        public string TargetWorkers { get; set; }
        /// <summary>
        /// The reservation_activity_sid
        /// </summary>
        public string ReservationActivitySid { get; set; }
        /// <summary>
        /// The assignment_activity_sid
        /// </summary>
        public string AssignmentActivitySid { get; set; }
        /// <summary>
        /// The max_reserved_workers
        /// </summary>
        public int? MaxReservedWorkers { get; set; }
        /// <summary>
        /// The task_order
        /// </summary>
        public TaskQueueResource.TaskOrderEnum TaskOrder { get; set; }
    
        /// <summary>
        /// Construct a new UpdateTaskQueueOptions
        /// </summary>
        ///
        /// <param name="pathWorkspaceSid"> The workspace_sid </param>
        /// <param name="pathSid"> The sid </param>
        public UpdateTaskQueueOptions(string pathWorkspaceSid, string pathSid)
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
            
            if (TargetWorkers != null)
            {
                p.Add(new KeyValuePair<string, string>("TargetWorkers", TargetWorkers));
            }
            
            if (ReservationActivitySid != null)
            {
                p.Add(new KeyValuePair<string, string>("ReservationActivitySid", ReservationActivitySid.ToString()));
            }
            
            if (AssignmentActivitySid != null)
            {
                p.Add(new KeyValuePair<string, string>("AssignmentActivitySid", AssignmentActivitySid.ToString()));
            }
            
            if (MaxReservedWorkers != null)
            {
                p.Add(new KeyValuePair<string, string>("MaxReservedWorkers", MaxReservedWorkers.Value.ToString()));
            }
            
            if (TaskOrder != null)
            {
                p.Add(new KeyValuePair<string, string>("TaskOrder", TaskOrder.ToString()));
            }
            
            return p;
        }
    }

    /// <summary>
    /// ReadTaskQueueOptions
    /// </summary>
    public class ReadTaskQueueOptions : ReadOptions<TaskQueueResource> 
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
        /// The evaluate_worker_attributes
        /// </summary>
        public string EvaluateWorkerAttributes { get; set; }
        /// <summary>
        /// The worker_sid
        /// </summary>
        public string WorkerSid { get; set; }
    
        /// <summary>
        /// Construct a new ReadTaskQueueOptions
        /// </summary>
        ///
        /// <param name="pathWorkspaceSid"> The workspace_sid </param>
        public ReadTaskQueueOptions(string pathWorkspaceSid)
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
            
            if (EvaluateWorkerAttributes != null)
            {
                p.Add(new KeyValuePair<string, string>("EvaluateWorkerAttributes", EvaluateWorkerAttributes));
            }
            
            if (WorkerSid != null)
            {
                p.Add(new KeyValuePair<string, string>("WorkerSid", WorkerSid.ToString()));
            }
            
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            
            return p;
        }
    }

    /// <summary>
    /// CreateTaskQueueOptions
    /// </summary>
    public class CreateTaskQueueOptions : IOptions<TaskQueueResource> 
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
        /// The reservation_activity_sid
        /// </summary>
        public string ReservationActivitySid { get; }
        /// <summary>
        /// The assignment_activity_sid
        /// </summary>
        public string AssignmentActivitySid { get; }
        /// <summary>
        /// The target_workers
        /// </summary>
        public string TargetWorkers { get; set; }
        /// <summary>
        /// The max_reserved_workers
        /// </summary>
        public int? MaxReservedWorkers { get; set; }
        /// <summary>
        /// The task_order
        /// </summary>
        public TaskQueueResource.TaskOrderEnum TaskOrder { get; set; }
    
        /// <summary>
        /// Construct a new CreateTaskQueueOptions
        /// </summary>
        ///
        /// <param name="pathWorkspaceSid"> The workspace_sid </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="reservationActivitySid"> The reservation_activity_sid </param>
        /// <param name="assignmentActivitySid"> The assignment_activity_sid </param>
        public CreateTaskQueueOptions(string pathWorkspaceSid, string friendlyName, string reservationActivitySid, string assignmentActivitySid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
            FriendlyName = friendlyName;
            ReservationActivitySid = reservationActivitySid;
            AssignmentActivitySid = assignmentActivitySid;
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
            
            if (ReservationActivitySid != null)
            {
                p.Add(new KeyValuePair<string, string>("ReservationActivitySid", ReservationActivitySid.ToString()));
            }
            
            if (AssignmentActivitySid != null)
            {
                p.Add(new KeyValuePair<string, string>("AssignmentActivitySid", AssignmentActivitySid.ToString()));
            }
            
            if (TargetWorkers != null)
            {
                p.Add(new KeyValuePair<string, string>("TargetWorkers", TargetWorkers));
            }
            
            if (MaxReservedWorkers != null)
            {
                p.Add(new KeyValuePair<string, string>("MaxReservedWorkers", MaxReservedWorkers.Value.ToString()));
            }
            
            if (TaskOrder != null)
            {
                p.Add(new KeyValuePair<string, string>("TaskOrder", TaskOrder.ToString()));
            }
            
            return p;
        }
    }

    /// <summary>
    /// DeleteTaskQueueOptions
    /// </summary>
    public class DeleteTaskQueueOptions : IOptions<TaskQueueResource> 
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
        /// Construct a new DeleteTaskQueueOptions
        /// </summary>
        ///
        /// <param name="pathWorkspaceSid"> The workspace_sid </param>
        /// <param name="pathSid"> The sid </param>
        public DeleteTaskQueueOptions(string pathWorkspaceSid, string pathSid)
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

}