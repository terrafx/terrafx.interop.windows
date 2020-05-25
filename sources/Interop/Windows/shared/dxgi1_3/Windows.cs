// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("dxgi", EntryPoint = "CreateDXGIFactory2", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreateDXGIFactory2([NativeTypeName("UINT")] uint Flags, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppFactory);

        [DllImport("dxgi", EntryPoint = "DXGIGetDebugInterface1", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int DXGIGetDebugInterface1([NativeTypeName("UINT")] uint Flags, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** pDebug);
    }
}
