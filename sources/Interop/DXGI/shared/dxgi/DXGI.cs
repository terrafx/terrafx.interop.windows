// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class DXGI
    {
        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "CreateDXGIFactory", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreateDXGIFactory([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppFactory);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "CreateDXGIFactory1", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreateDXGIFactory1([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppFactory);
    }
}
