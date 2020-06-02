// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12shader.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8337A8A6-A216-444A-B2F4-314733A73AEA")]
    public unsafe partial struct ID3D12ShaderReflectionVariable
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int GetDesc([NativeTypeName("D3D12_SHADER_VARIABLE_DESC *")] D3D12_SHADER_VARIABLE_DESC* pDesc)
        {
            return lpVtbl->GetDesc((ID3D12ShaderReflectionVariable*)Unsafe.AsPointer(ref this), pDesc);
        }

        [return: NativeTypeName("ID3D12ShaderReflectionType *")]
        public new ID3D12ShaderReflectionType* GetType()
        {
            return lpVtbl->GetType((ID3D12ShaderReflectionVariable*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ID3D12ShaderReflectionConstantBuffer *")]
        public ID3D12ShaderReflectionConstantBuffer* GetBuffer()
        {
            return lpVtbl->GetBuffer((ID3D12ShaderReflectionVariable*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT")]
        public uint GetInterfaceSlot([NativeTypeName("UINT")] uint uArrayIndex)
        {
            return lpVtbl->GetInterfaceSlot((ID3D12ShaderReflectionVariable*)Unsafe.AsPointer(ref this), uArrayIndex);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (D3D12_SHADER_VARIABLE_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12ShaderReflectionVariable*, D3D12_SHADER_VARIABLE_DESC*, int> GetDesc;

            [NativeTypeName("ID3D12ShaderReflectionType *() __attribute__((nothrow)) __attribute__((stdcall))")]
            public new delegate* stdcall<ID3D12ShaderReflectionVariable*, ID3D12ShaderReflectionType*> GetType;

            [NativeTypeName("ID3D12ShaderReflectionConstantBuffer *() __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12ShaderReflectionVariable*, ID3D12ShaderReflectionConstantBuffer*> GetBuffer;

            [NativeTypeName("UINT (UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12ShaderReflectionVariable*, uint, uint> GetInterfaceSlot;
        }
    }
}
