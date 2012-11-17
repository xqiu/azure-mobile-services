﻿// ----------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// ----------------------------------------------------------------------------

using System;
using Microsoft.Azure.Zumo.WindowsPhone7.Test;
using Microsoft.WindowsAzure.MobileServices;

namespace Microsoft.Azure.Zumo.WindowsPhone7.CSharp.Test
{
    public class ZumoUserTests : TestBase
    {
        [TestMethod]
        public void CreateUser()
        {
            string id = "qwrdsjjjd8";
            MobileServiceUser user = new MobileServiceUser(id);
            Assert.AreEqual(id, user.UserId);

            new MobileServiceUser(null);
            new MobileServiceUser("");
        }
    }
}
