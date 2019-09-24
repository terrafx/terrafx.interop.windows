// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dxgidebug.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe class DXGIDebug
    {
        private const string DllName = nameof(DXGIDebug);

        public static readonly Guid DXGI_DEBUG_ALL = new Guid(0xE48AE283, 0xDA80, 0x490B, 0x87, 0xE6, 0x43, 0xE9, 0xA9, 0xCF, 0xDA, 0x08);

        public static readonly Guid DXGI_DEBUG_DX = new Guid(0x35CDD7FC, 0x13B2, 0x421D, 0xA5, 0xD7, 0x7E, 0x44, 0x51, 0x28, 0x7D, 0x64);

        public static readonly Guid DXGI_DEBUG_DXGI = new Guid(0x25CDDAA4, 0xB1C6, 0x47E1, 0xAC, 0x3E, 0x98, 0x87, 0x5B, 0x5A, 0x2E, 0x2A);

        public static readonly Guid DXGI_DEBUG_APP = new Guid(0x06CD6E01, 0x4219, 0x4EBD, 0x87, 0x09, 0x27, 0xED, 0x23, 0x36, 0x0C, 0x62);

        public const int DXGI_INFO_QUEUE_MESSAGE_ID_STRING_FROM_APPLICATION = 0;

        public const int DXGI_INFO_QUEUE_DEFAULT_MESSAGE_COUNT_LIMIT = 1024;

        public static readonly Guid IID_IDXGIInfoQueue = new Guid(0xD67441C7, 0x672A, 0x476F, 0x9E, 0x82, 0xCD, 0x55, 0xB4, 0x49, 0x49, 0xCE);

        public static readonly Guid IID_IDXGIDebug = new Guid(0x119E7452, 0xDE9E, 0x40FE, 0x88, 0x06, 0x88, 0xF9, 0x0C, 0x12, 0xB4, 0x41);

        public static readonly Guid IID_IDXGIDebug1 = new Guid(0xC5A05F0C, 0x16F2, 0x4ADF, 0x9F, 0x4D, 0xA8, 0xC4, 0xD5, 0x8A, 0xC5, 0x50);

        [DllImport(DllName, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "DXGIGetDebugInterface", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public static extern int DXGIGetDebugInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** pDebug
        );
    }
}
