// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/CoreWindow.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("Windows.UI.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreateControlInput([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        [DllImport("Windows.UI.dll", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreateControlInputEx([NativeTypeName("IUnknown *")] IUnknown* pCoreWindow, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        public static readonly Guid IID_ICoreWindowInterop = new Guid(0x45D64A29, 0xA63E, 0x4CB6, 0xB4, 0x98, 0x57, 0x81, 0xD2, 0x98, 0xCB, 0x4F);

        public static readonly Guid IID_ICoreInputInterop = new Guid(0x40BFE3E3, 0xB75A, 0x4479, 0xAC, 0x96, 0x47, 0x53, 0x65, 0x74, 0x9B, 0xB8);

        public static readonly Guid IID_ICoreWindowComponentInterop = new Guid(0x0576AB31, 0xA310, 0x4C40, 0xBA, 0x31, 0xFD, 0x37, 0xE0, 0x29, 0x8D, 0xFA);

        public static readonly Guid IID_ICoreWindowAdapterInterop = new Guid(0x7A5B6FD1, 0xCD73, 0x4B6C, 0x9C, 0xF4, 0x2E, 0x86, 0x9E, 0xAF, 0x47, 0x0A);
    }
}
