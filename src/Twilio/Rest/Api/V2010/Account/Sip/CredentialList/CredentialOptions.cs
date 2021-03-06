using System;
using System.Collections.Generic;
using Twilio.Base;

namespace Twilio.Rest.Api.V2010.Account.Sip.CredentialList 
{

    /// <summary>
    /// ReadCredentialOptions
    /// </summary>
    public class ReadCredentialOptions : ReadOptions<CredentialResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The credential_list_sid
        /// </summary>
        public string PathCredentialListSid { get; }
    
        /// <summary>
        /// Construct a new ReadCredentialOptions
        /// </summary>
        ///
        /// <param name="pathCredentialListSid"> The credential_list_sid </param>
        public ReadCredentialOptions(string pathCredentialListSid)
        {
            PathCredentialListSid = pathCredentialListSid;
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            
            return p;
        }
    }

    /// <summary>
    /// CreateCredentialOptions
    /// </summary>
    public class CreateCredentialOptions : IOptions<CredentialResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The credential_list_sid
        /// </summary>
        public string PathCredentialListSid { get; }
        /// <summary>
        /// The username
        /// </summary>
        public string Username { get; }
        /// <summary>
        /// The password
        /// </summary>
        public string Password { get; }
    
        /// <summary>
        /// Construct a new CreateCredentialOptions
        /// </summary>
        ///
        /// <param name="pathCredentialListSid"> The credential_list_sid </param>
        /// <param name="username"> The username </param>
        /// <param name="password"> The password </param>
        public CreateCredentialOptions(string pathCredentialListSid, string username, string password)
        {
            PathCredentialListSid = pathCredentialListSid;
            Username = username;
            Password = password;
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Username != null)
            {
                p.Add(new KeyValuePair<string, string>("Username", Username));
            }
            
            if (Password != null)
            {
                p.Add(new KeyValuePair<string, string>("Password", Password));
            }
            
            return p;
        }
    }

    /// <summary>
    /// FetchCredentialOptions
    /// </summary>
    public class FetchCredentialOptions : IOptions<CredentialResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The credential_list_sid
        /// </summary>
        public string PathCredentialListSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }
    
        /// <summary>
        /// Construct a new FetchCredentialOptions
        /// </summary>
        ///
        /// <param name="pathCredentialListSid"> The credential_list_sid </param>
        /// <param name="pathSid"> The sid </param>
        public FetchCredentialOptions(string pathCredentialListSid, string pathSid)
        {
            PathCredentialListSid = pathCredentialListSid;
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
    /// UpdateCredentialOptions
    /// </summary>
    public class UpdateCredentialOptions : IOptions<CredentialResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The credential_list_sid
        /// </summary>
        public string PathCredentialListSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// The password
        /// </summary>
        public string Password { get; set; }
    
        /// <summary>
        /// Construct a new UpdateCredentialOptions
        /// </summary>
        ///
        /// <param name="pathCredentialListSid"> The credential_list_sid </param>
        /// <param name="pathSid"> The sid </param>
        public UpdateCredentialOptions(string pathCredentialListSid, string pathSid)
        {
            PathCredentialListSid = pathCredentialListSid;
            PathSid = pathSid;
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Password != null)
            {
                p.Add(new KeyValuePair<string, string>("Password", Password));
            }
            
            return p;
        }
    }

    /// <summary>
    /// DeleteCredentialOptions
    /// </summary>
    public class DeleteCredentialOptions : IOptions<CredentialResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The credential_list_sid
        /// </summary>
        public string PathCredentialListSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }
    
        /// <summary>
        /// Construct a new DeleteCredentialOptions
        /// </summary>
        ///
        /// <param name="pathCredentialListSid"> The credential_list_sid </param>
        /// <param name="pathSid"> The sid </param>
        public DeleteCredentialOptions(string pathCredentialListSid, string pathSid)
        {
            PathCredentialListSid = pathCredentialListSid;
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