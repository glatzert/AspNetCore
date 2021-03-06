// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Runtime.Versioning;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.JSInterop;

namespace Microsoft.AspNetCore.Components.ProtectedBrowserStorage
{
    /// <summary>
    /// Provides mechanisms for storing and retrieving data in the browser's
    /// 'sessionStorage' collection.
    ///
    /// This data will be scoped to the current browser tab. The data will be
    /// discarded if the user closes the browser tab or closes the browser itself.
    ///
    /// See: https://developer.mozilla.org/en-US/docs/Web/API/Window/sessionStorage
    /// </summary>
    [UnsupportedOSPlatform("browser")]
    public class ProtectedSessionStorage : ProtectedBrowserStorage
    {
        /// <summary>
        /// Constructs an instance of <see cref="ProtectedSessionStorage"/>.
        /// </summary>
        /// <param name="jsRuntime">The <see cref="IJSRuntime"/>.</param>
        /// <param name="dataProtectionProvider">The <see cref="IDataProtectionProvider"/>.</param>
        public ProtectedSessionStorage(IJSRuntime jsRuntime, IDataProtectionProvider dataProtectionProvider)
            : base("sessionStorage", jsRuntime, dataProtectionProvider)
        {
        }
    }
}
