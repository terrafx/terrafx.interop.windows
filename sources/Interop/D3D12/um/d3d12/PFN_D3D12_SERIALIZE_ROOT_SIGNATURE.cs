// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("HRESULT")]
    public unsafe delegate int PFN_D3D12_SERIALIZE_ROOT_SIGNATURE([NativeTypeName("const D3D12_ROOT_SIGNATURE_DESC *")] D3D12_ROOT_SIGNATURE_DESC* pRootSignature, D3D_ROOT_SIGNATURE_VERSION Version, [NativeTypeName("ID3DBlob **")] ID3DBlob** ppBlob, [NativeTypeName("ID3DBlob **")] ID3DBlob** ppErrorBlob);
}
