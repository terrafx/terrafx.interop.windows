// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("HRESULT")]
    public unsafe delegate int PFN_D3D12_CREATE_DEVICE([NativeTypeName("IUnknown *")] IUnknown* param0, D3D_FEATURE_LEVEL param1, [NativeTypeName("const IID &")] Guid* param2, [NativeTypeName("void **")] void** param3);
}
