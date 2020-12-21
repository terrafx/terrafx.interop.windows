// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12shader.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8337A8A6-A216-444A-B2F4-314733A73AEA")]
    public unsafe partial struct ID3D12ShaderReflectionVariable
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDesc([NativeTypeName("D3D12_SHADER_VARIABLE_DESC *")] D3D12_SHADER_VARIABLE_DESC* pDesc)
        {
            return ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionVariable*, D3D12_SHADER_VARIABLE_DESC*, int>)(lpVtbl[0]))((ID3D12ShaderReflectionVariable*)Unsafe.AsPointer(ref this), pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ID3D12ShaderReflectionType *")]
        public new ID3D12ShaderReflectionType* GetType()
        {
            return ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionVariable*, ID3D12ShaderReflectionType*>)(lpVtbl[1]))((ID3D12ShaderReflectionVariable*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ID3D12ShaderReflectionConstantBuffer *")]
        public ID3D12ShaderReflectionConstantBuffer* GetBuffer()
        {
            return ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionVariable*, ID3D12ShaderReflectionConstantBuffer*>)(lpVtbl[2]))((ID3D12ShaderReflectionVariable*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT")]
        public uint GetInterfaceSlot([NativeTypeName("UINT")] uint uArrayIndex)
        {
            return ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionVariable*, uint, uint>)(lpVtbl[3]))((ID3D12ShaderReflectionVariable*)Unsafe.AsPointer(ref this), uArrayIndex);
        }
    }
}
