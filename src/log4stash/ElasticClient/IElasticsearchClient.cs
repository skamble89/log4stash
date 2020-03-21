using System;
using System.Collections.Generic;
using log4stash.Authentication;
using log4stash.Configuration;
using RestSharp.Authenticators;

namespace log4stash
{
    public interface IElasticsearchClient : IDisposable
    {
        IServerDataCollection Servers { get; }
        bool Ssl { get; }
        bool AllowSelfSignedServerCert { get; }
        IAuthenticator AuthenticationMethod { get; set; }
        void PutTemplateRaw(string templateName, string rawBody);
        void IndexBulk(IEnumerable<InnerBulkOperation> bulk);
        void IndexBulkAsync(IEnumerable<InnerBulkOperation> bulk);
    }
}