// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/Wsdevlicensing.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.WinRT
{
    public static unsafe partial class WinRT
    {
        [DllImport("wsclient", ExactSpelling = true)]
        public static extern HRESULT CheckDeveloperLicense(FILETIME* pExpiration);

        [DllImport("wsclient", ExactSpelling = true)]
        public static extern HRESULT AcquireDeveloperLicense(HWND hwndParent, FILETIME* pExpiration);

        [DllImport("wsclient", ExactSpelling = true)]
        public static extern HRESULT RemoveDeveloperLicense(HWND hwndParent);
    }
}
