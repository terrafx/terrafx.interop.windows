// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shader.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("42757488-334F-47FE-982E-1A65D08CC462")]
    public unsafe partial struct ID3D11FunctionParameterReflection
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDesc(D3D11_PARAMETER_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D11FunctionParameterReflection*, D3D11_PARAMETER_DESC*, int>)(lpVtbl[0]))((ID3D11FunctionParameterReflection*)Unsafe.AsPointer(ref this), pDesc);
        }
    }
}
