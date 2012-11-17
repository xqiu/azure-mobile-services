﻿// ----------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// ----------------------------------------------------------------------------

using System;

namespace Microsoft.Azure.Zumo.WindowsPhone7.CSharp
{
    /// <summary>
    /// Declare an async test.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class AsyncTestMethodAttribute : Attribute
    {
    }
}
