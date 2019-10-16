// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11on12.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("HRESULT")]
    public unsafe delegate int PFN_D3D11ON12_CREATE_DEVICE([NativeTypeName("IUnknown *")] IUnknown* param0, [NativeTypeName("UINT")] uint param1, [NativeTypeName("const D3D_FEATURE_LEVEL *")] D3D_FEATURE_LEVEL* param2, [NativeTypeName("UINT")] uint FeatureLevels, [NativeTypeName("IUnknown *const *")] IUnknown** param4, [NativeTypeName("UINT")] uint NumQueues, [NativeTypeName("UINT")] uint param6, [NativeTypeName("ID3D11Device **")] ID3D11Device** param7, [NativeTypeName("ID3D11DeviceContext **")] ID3D11DeviceContext** param8, [NativeTypeName("D3D_FEATURE_LEVEL *")] D3D_FEATURE_LEVEL* param9);
}
