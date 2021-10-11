// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/Wsdevlicensing.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("wsclient", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CheckDeveloperLicense(FILETIME* pExpiration);

        [DllImport("wsclient", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int AcquireDeveloperLicense([NativeTypeName("HWND")] IntPtr hwndParent, FILETIME* pExpiration);

        [DllImport("wsclient", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int RemoveDeveloperLicense([NativeTypeName("HWND")] IntPtr hwndParent);
    }
}
