// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3dcommon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public unsafe partial struct ID3DInclude
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int Open(D3D_INCLUDE_TYPE IncludeType, [NativeTypeName("LPCSTR")] sbyte* pFileName, [NativeTypeName("LPCVOID")] void* pParentData, [NativeTypeName("LPCVOID *")] void** ppData, [NativeTypeName("UINT *")] uint* pBytes)
        {
            return ((delegate* stdcall<ID3DInclude*, D3D_INCLUDE_TYPE, sbyte*, void*, void**, uint*, int>)(lpVtbl[0]))((ID3DInclude*)Unsafe.AsPointer(ref this), IncludeType, pFileName, pParentData, ppData, pBytes);
        }

        [return: NativeTypeName("HRESULT")]
        public int Close([NativeTypeName("LPCVOID")] void* pData)
        {
            return ((delegate* stdcall<ID3DInclude*, void*, int>)(lpVtbl[1]))((ID3DInclude*)Unsafe.AsPointer(ref this), pData);
        }
    }
}
