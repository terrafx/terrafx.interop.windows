// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10shader.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1BF63C95-2650-405D-99C1-3636BD1DA0A1")]
    public unsafe partial struct ID3D10ShaderReflectionVariable
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDesc([NativeTypeName("D3D10_SHADER_VARIABLE_DESC *")] D3D10_SHADER_VARIABLE_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D10ShaderReflectionVariable*, D3D10_SHADER_VARIABLE_DESC*, int>)(lpVtbl[0]))((ID3D10ShaderReflectionVariable*)Unsafe.AsPointer(ref this), pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ID3D10ShaderReflectionType *")]
        public new ID3D10ShaderReflectionType* GetType()
        {
            return ((delegate* unmanaged<ID3D10ShaderReflectionVariable*, ID3D10ShaderReflectionType*>)(lpVtbl[1]))((ID3D10ShaderReflectionVariable*)Unsafe.AsPointer(ref this));
        }
    }
}
