﻿// ----------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// ----------------------------------------------------------------------------

using System;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;

namespace Microsoft.Azure.Zumo.WindowsPhone7.CSharp.Test
{
    /// <summary>
    /// Base class for functional tests.
    /// </summary>
    [FunctionalTest]
    public class FunctionalTestBase : TestBase
    {
        /// <summary>
        /// Get a client pointed at the test server without request logging.
        /// </summary>
        /// <returns>The test client.</returns>
        public MobileServiceClient GetClientNoLogging()
        {
            string runtimeUrl = App.Harness.Settings.Custom["MobileServiceRuntimeUrl"];
            return new MobileServiceClient(runtimeUrl);
        }

        /// <summary>
        /// Get a client pointed at the test server.
        /// </summary>
        /// <returns>The test client.</returns>
        public MobileServiceClient GetClient()
        {
            return GetClientNoLogging().WithFilter(new LoggingFilter(this));
        }
    }

    public class LoggingFilter : IServiceFilter
    {
        public TestBase Test { get; private set; }

        public LoggingFilter(TestBase test)
        {
            Test = test;
        }

        public async Task<IServiceFilterResponse> Handle(IServiceFilterRequest request, IServiceFilterContinuation continuation)
        {
            return await Log(request, continuation);
        }

        private async Task<IServiceFilterResponse> Log(IServiceFilterRequest request, IServiceFilterContinuation next)
        {
            Test.Log("    >>> {0} {1} {2}", request.Method, request.Uri, request.Content);
            IServiceFilterResponse response = await next.Handle(request);
            Test.Log("    <<< {0} {1} {2}", response.StatusCode, response.StatusDescription, response.Content);
            return response;
        }
    }
}
