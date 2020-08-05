// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12shader.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5A58797D-A72C-478D-8BA2-EFC6B0EFE88E")]
    [NativeTypeName("struct ID3D12ShaderReflection : IUnknown")]
    public unsafe partial struct ID3D12ShaderReflection
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID3D12ShaderReflection*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID3D12ShaderReflection*, uint>)(lpVtbl[1]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID3D12ShaderReflection*, uint>)(lpVtbl[2]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDesc([NativeTypeName("D3D12_SHADER_DESC *")] D3D12_SHADER_DESC* pDesc)
        {
            return ((delegate* stdcall<ID3D12ShaderReflection*, D3D12_SHADER_DESC*, int>)(lpVtbl[3]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this), pDesc);
        }

        [return: NativeTypeName("ID3D12ShaderReflectionConstantBuffer *")]
        public ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByIndex([NativeTypeName("UINT")] uint Index)
        {
            return ((delegate* stdcall<ID3D12ShaderReflection*, uint, ID3D12ShaderReflectionConstantBuffer*>)(lpVtbl[4]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this), Index);
        }

        [return: NativeTypeName("ID3D12ShaderReflectionConstantBuffer *")]
        public ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return ((delegate* stdcall<ID3D12ShaderReflection*, sbyte*, ID3D12ShaderReflectionConstantBuffer*>)(lpVtbl[5]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this), Name);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetResourceBindingDesc([NativeTypeName("UINT")] uint ResourceIndex, [NativeTypeName("D3D12_SHADER_INPUT_BIND_DESC *")] D3D12_SHADER_INPUT_BIND_DESC* pDesc)
        {
            return ((delegate* stdcall<ID3D12ShaderReflection*, uint, D3D12_SHADER_INPUT_BIND_DESC*, int>)(lpVtbl[6]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this), ResourceIndex, pDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetInputParameterDesc([NativeTypeName("UINT")] uint ParameterIndex, [NativeTypeName("D3D12_SIGNATURE_PARAMETER_DESC *")] D3D12_SIGNATURE_PARAMETER_DESC* pDesc)
        {
            return ((delegate* stdcall<ID3D12ShaderReflection*, uint, D3D12_SIGNATURE_PARAMETER_DESC*, int>)(lpVtbl[7]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this), ParameterIndex, pDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetOutputParameterDesc([NativeTypeName("UINT")] uint ParameterIndex, [NativeTypeName("D3D12_SIGNATURE_PARAMETER_DESC *")] D3D12_SIGNATURE_PARAMETER_DESC* pDesc)
        {
            return ((delegate* stdcall<ID3D12ShaderReflection*, uint, D3D12_SIGNATURE_PARAMETER_DESC*, int>)(lpVtbl[8]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this), ParameterIndex, pDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPatchConstantParameterDesc([NativeTypeName("UINT")] uint ParameterIndex, [NativeTypeName("D3D12_SIGNATURE_PARAMETER_DESC *")] D3D12_SIGNATURE_PARAMETER_DESC* pDesc)
        {
            return ((delegate* stdcall<ID3D12ShaderReflection*, uint, D3D12_SIGNATURE_PARAMETER_DESC*, int>)(lpVtbl[9]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this), ParameterIndex, pDesc);
        }

        [return: NativeTypeName("ID3D12ShaderReflectionVariable *")]
        public ID3D12ShaderReflectionVariable* GetVariableByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return ((delegate* stdcall<ID3D12ShaderReflection*, sbyte*, ID3D12ShaderReflectionVariable*>)(lpVtbl[10]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this), Name);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetResourceBindingDescByName([NativeTypeName("LPCSTR")] sbyte* Name, [NativeTypeName("D3D12_SHADER_INPUT_BIND_DESC *")] D3D12_SHADER_INPUT_BIND_DESC* pDesc)
        {
            return ((delegate* stdcall<ID3D12ShaderReflection*, sbyte*, D3D12_SHADER_INPUT_BIND_DESC*, int>)(lpVtbl[11]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this), Name, pDesc);
        }

        [return: NativeTypeName("UINT")]
        public uint GetMovInstructionCount()
        {
            return ((delegate* stdcall<ID3D12ShaderReflection*, uint>)(lpVtbl[12]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT")]
        public uint GetMovcInstructionCount()
        {
            return ((delegate* stdcall<ID3D12ShaderReflection*, uint>)(lpVtbl[13]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT")]
        public uint GetConversionInstructionCount()
        {
            return ((delegate* stdcall<ID3D12ShaderReflection*, uint>)(lpVtbl[14]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT")]
        public uint GetBitwiseInstructionCount()
        {
            return ((delegate* stdcall<ID3D12ShaderReflection*, uint>)(lpVtbl[15]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        public D3D_PRIMITIVE GetGSInputPrimitive()
        {
            return ((delegate* stdcall<ID3D12ShaderReflection*, D3D_PRIMITIVE>)(lpVtbl[16]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("BOOL")]
        public int IsSampleFrequencyShader()
        {
            return ((delegate* stdcall<ID3D12ShaderReflection*, int>)(lpVtbl[17]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT")]
        public uint GetNumInterfaceSlots()
        {
            return ((delegate* stdcall<ID3D12ShaderReflection*, uint>)(lpVtbl[18]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMinFeatureLevel([NativeTypeName("enum D3D_FEATURE_LEVEL *")] D3D_FEATURE_LEVEL* pLevel)
        {
            return ((delegate* stdcall<ID3D12ShaderReflection*, D3D_FEATURE_LEVEL*, int>)(lpVtbl[19]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this), pLevel);
        }

        [return: NativeTypeName("UINT")]
        public uint GetThreadGroupSize([NativeTypeName("UINT *")] uint* pSizeX, [NativeTypeName("UINT *")] uint* pSizeY, [NativeTypeName("UINT *")] uint* pSizeZ)
        {
            return ((delegate* stdcall<ID3D12ShaderReflection*, uint*, uint*, uint*, uint>)(lpVtbl[20]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this), pSizeX, pSizeY, pSizeZ);
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetRequiresFlags()
        {
            return ((delegate* stdcall<ID3D12ShaderReflection*, ulong>)(lpVtbl[21]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this));
        }
    }
}
