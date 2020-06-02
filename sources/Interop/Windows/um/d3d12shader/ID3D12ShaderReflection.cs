// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12shader.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5A58797D-A72C-478D-8BA2-EFC6B0EFE88E")]
    public unsafe partial struct ID3D12ShaderReflection
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDesc([NativeTypeName("D3D12_SHADER_DESC *")] D3D12_SHADER_DESC* pDesc)
        {
            return lpVtbl->GetDesc((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this), pDesc);
        }

        [return: NativeTypeName("ID3D12ShaderReflectionConstantBuffer *")]
        public ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByIndex([NativeTypeName("UINT")] uint Index)
        {
            return lpVtbl->GetConstantBufferByIndex((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this), Index);
        }

        [return: NativeTypeName("ID3D12ShaderReflectionConstantBuffer *")]
        public ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return lpVtbl->GetConstantBufferByName((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this), Name);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetResourceBindingDesc([NativeTypeName("UINT")] uint ResourceIndex, [NativeTypeName("D3D12_SHADER_INPUT_BIND_DESC *")] D3D12_SHADER_INPUT_BIND_DESC* pDesc)
        {
            return lpVtbl->GetResourceBindingDesc((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this), ResourceIndex, pDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetInputParameterDesc([NativeTypeName("UINT")] uint ParameterIndex, [NativeTypeName("D3D12_SIGNATURE_PARAMETER_DESC *")] D3D12_SIGNATURE_PARAMETER_DESC* pDesc)
        {
            return lpVtbl->GetInputParameterDesc((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this), ParameterIndex, pDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetOutputParameterDesc([NativeTypeName("UINT")] uint ParameterIndex, [NativeTypeName("D3D12_SIGNATURE_PARAMETER_DESC *")] D3D12_SIGNATURE_PARAMETER_DESC* pDesc)
        {
            return lpVtbl->GetOutputParameterDesc((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this), ParameterIndex, pDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPatchConstantParameterDesc([NativeTypeName("UINT")] uint ParameterIndex, [NativeTypeName("D3D12_SIGNATURE_PARAMETER_DESC *")] D3D12_SIGNATURE_PARAMETER_DESC* pDesc)
        {
            return lpVtbl->GetPatchConstantParameterDesc((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this), ParameterIndex, pDesc);
        }

        [return: NativeTypeName("ID3D12ShaderReflectionVariable *")]
        public ID3D12ShaderReflectionVariable* GetVariableByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return lpVtbl->GetVariableByName((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this), Name);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetResourceBindingDescByName([NativeTypeName("LPCSTR")] sbyte* Name, [NativeTypeName("D3D12_SHADER_INPUT_BIND_DESC *")] D3D12_SHADER_INPUT_BIND_DESC* pDesc)
        {
            return lpVtbl->GetResourceBindingDescByName((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this), Name, pDesc);
        }

        [return: NativeTypeName("UINT")]
        public uint GetMovInstructionCount()
        {
            return lpVtbl->GetMovInstructionCount((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT")]
        public uint GetMovcInstructionCount()
        {
            return lpVtbl->GetMovcInstructionCount((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT")]
        public uint GetConversionInstructionCount()
        {
            return lpVtbl->GetConversionInstructionCount((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT")]
        public uint GetBitwiseInstructionCount()
        {
            return lpVtbl->GetBitwiseInstructionCount((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        public D3D_PRIMITIVE GetGSInputPrimitive()
        {
            return lpVtbl->GetGSInputPrimitive((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("BOOL")]
        public int IsSampleFrequencyShader()
        {
            return lpVtbl->IsSampleFrequencyShader((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT")]
        public uint GetNumInterfaceSlots()
        {
            return lpVtbl->GetNumInterfaceSlots((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMinFeatureLevel([NativeTypeName("enum D3D_FEATURE_LEVEL *")] D3D_FEATURE_LEVEL* pLevel)
        {
            return lpVtbl->GetMinFeatureLevel((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this), pLevel);
        }

        [return: NativeTypeName("UINT")]
        public uint GetThreadGroupSize([NativeTypeName("UINT *")] uint* pSizeX, [NativeTypeName("UINT *")] uint* pSizeY, [NativeTypeName("UINT *")] uint* pSizeZ)
        {
            return lpVtbl->GetThreadGroupSize((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this), pSizeX, pSizeY, pSizeZ);
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetRequiresFlags()
        {
            return lpVtbl->GetRequiresFlags((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12ShaderReflection*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12ShaderReflection*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12ShaderReflection*, uint> Release;

            [NativeTypeName("HRESULT (D3D12_SHADER_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12ShaderReflection*, D3D12_SHADER_DESC*, int> GetDesc;

            [NativeTypeName("ID3D12ShaderReflectionConstantBuffer *(UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12ShaderReflection*, uint, ID3D12ShaderReflectionConstantBuffer*> GetConstantBufferByIndex;

            [NativeTypeName("ID3D12ShaderReflectionConstantBuffer *(LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12ShaderReflection*, sbyte*, ID3D12ShaderReflectionConstantBuffer*> GetConstantBufferByName;

            [NativeTypeName("HRESULT (UINT, D3D12_SHADER_INPUT_BIND_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12ShaderReflection*, uint, D3D12_SHADER_INPUT_BIND_DESC*, int> GetResourceBindingDesc;

            [NativeTypeName("HRESULT (UINT, D3D12_SIGNATURE_PARAMETER_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12ShaderReflection*, uint, D3D12_SIGNATURE_PARAMETER_DESC*, int> GetInputParameterDesc;

            [NativeTypeName("HRESULT (UINT, D3D12_SIGNATURE_PARAMETER_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12ShaderReflection*, uint, D3D12_SIGNATURE_PARAMETER_DESC*, int> GetOutputParameterDesc;

            [NativeTypeName("HRESULT (UINT, D3D12_SIGNATURE_PARAMETER_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12ShaderReflection*, uint, D3D12_SIGNATURE_PARAMETER_DESC*, int> GetPatchConstantParameterDesc;

            [NativeTypeName("ID3D12ShaderReflectionVariable *(LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12ShaderReflection*, sbyte*, ID3D12ShaderReflectionVariable*> GetVariableByName;

            [NativeTypeName("HRESULT (LPCSTR, D3D12_SHADER_INPUT_BIND_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12ShaderReflection*, sbyte*, D3D12_SHADER_INPUT_BIND_DESC*, int> GetResourceBindingDescByName;

            [NativeTypeName("UINT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12ShaderReflection*, uint> GetMovInstructionCount;

            [NativeTypeName("UINT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12ShaderReflection*, uint> GetMovcInstructionCount;

            [NativeTypeName("UINT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12ShaderReflection*, uint> GetConversionInstructionCount;

            [NativeTypeName("UINT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12ShaderReflection*, uint> GetBitwiseInstructionCount;

            [NativeTypeName("D3D_PRIMITIVE () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12ShaderReflection*, D3D_PRIMITIVE> GetGSInputPrimitive;

            [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12ShaderReflection*, int> IsSampleFrequencyShader;

            [NativeTypeName("UINT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12ShaderReflection*, uint> GetNumInterfaceSlots;

            [NativeTypeName("HRESULT (enum D3D_FEATURE_LEVEL *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12ShaderReflection*, D3D_FEATURE_LEVEL*, int> GetMinFeatureLevel;

            [NativeTypeName("UINT (UINT *, UINT *, UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12ShaderReflection*, uint*, uint*, uint*, uint> GetThreadGroupSize;

            [NativeTypeName("UINT64 () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12ShaderReflection*, ulong> GetRequiresFlags;
        }
    }
}
