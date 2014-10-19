﻿﻿using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomeType = CollisionA.SomeType;
using CollisionB;
using System.Net;
using System.Reactive.Linq;
using NUnit.Framework;
using Newtonsoft.Json;

/* ******** Hey You! *********
 *
 * This is a generated file, and gets rewritten every time you build the
 * project. If you want to edit it, you need to edit the mustache template
 * in the Refit package */

namespace RefitInternalGenerated
{
    [AttributeUsage (AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate)]
    sealed class PreserveAttribute : Attribute
    {
        //
        // Fields
        //
        public bool AllMembers;

        public bool Conditional;
    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    [Preserve]
    public partial class AutoGeneratedIGitHubApi : IGitHubApi
    {
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls;

        public AutoGeneratedIGitHubApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            methodImpls = requestBuilder.InterfaceHttpMethods.ToDictionary(k => k, v => requestBuilder.BuildRestResultFuncForMethod(v));
            Client = client;
        }

        public virtual Task<User> GetUser(string userName)
        {
            var arguments = new object[] { userName };
            return (Task<User>) methodImpls["GetUser"](Client, arguments);
        }

        public virtual IObservable<User> GetUserObservable(string userName)
        {
            var arguments = new object[] { userName };
            return (IObservable<User>) methodImpls["GetUserObservable"](Client, arguments);
        }

        public virtual Task<List<User>> GetOrgMembers(string orgName)
        {
            var arguments = new object[] { orgName };
            return (Task<List<User>>) methodImpls["GetOrgMembers"](Client, arguments);
        }

        public virtual Task<UserSearchResult> FindUsers(string q)
        {
            var arguments = new object[] { q };
            return (Task<UserSearchResult>) methodImpls["FindUsers"](Client, arguments);
        }

        public virtual Task<HttpResponseMessage> GetIndex()
        {
            var arguments = new object[] {  };
            return (Task<HttpResponseMessage>) methodImpls["GetIndex"](Client, arguments);
        }

        public virtual IObservable<string> GetIndexObservable()
        {
            var arguments = new object[] {  };
            return (IObservable<string>) methodImpls["GetIndexObservable"](Client, arguments);
        }

        public virtual Task NothingToSeeHere()
        {
            var arguments = new object[] {  };
            return (Task) methodImpls["NothingToSeeHere"](Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    [Preserve]
    public partial class AutoGeneratedINamespaceCollisionApi : INamespaceCollisionApi
    {
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls;

        public AutoGeneratedINamespaceCollisionApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            methodImpls = requestBuilder.InterfaceHttpMethods.ToDictionary(k => k, v => requestBuilder.BuildRestResultFuncForMethod(v));
            Client = client;
        }

        public virtual Task<SomeType> SomeRequest()
        {
            var arguments = new object[] {  };
            return (Task<SomeType>) methodImpls["SomeRequest"](Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    [Preserve]
    public partial class AutoGeneratedINpmJs : INpmJs
    {
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls;

        public AutoGeneratedINpmJs(HttpClient client, IRequestBuilder requestBuilder)
        {
            methodImpls = requestBuilder.InterfaceHttpMethods.ToDictionary(k => k, v => requestBuilder.BuildRestResultFuncForMethod(v));
            Client = client;
        }

        public virtual Task<RootObject> GetCongruence()
        {
            var arguments = new object[] {  };
            return (Task<RootObject>) methodImpls["GetCongruence"](Client, arguments);
        }

    }
}

namespace Refit.Tests
{
    using RefitInternalGenerated;

    [Preserve]
    public partial class AutoGeneratedIRequestBin : IRequestBin
    {
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls;

        public AutoGeneratedIRequestBin(HttpClient client, IRequestBuilder requestBuilder)
        {
            methodImpls = requestBuilder.InterfaceHttpMethods.ToDictionary(k => k, v => requestBuilder.BuildRestResultFuncForMethod(v));
            Client = client;
        }

        public virtual Task Post()
        {
            var arguments = new object[] {  };
            return (Task) methodImpls["Post"](Client, arguments);
        }

    }
}


