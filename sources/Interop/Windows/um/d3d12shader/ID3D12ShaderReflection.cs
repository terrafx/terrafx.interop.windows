// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12shader.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5A58797D-A72C-478D-8BA2-EFC6B0EFE88E")]
    [NativeTypeName("struct ID3D12ShaderReflection : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ID3D12ShaderReflection
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12ShaderReflection*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12ShaderReflection*, uint>)(lpVtbl[1]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D12ShaderReflection*, uint>)(lpVtbl[2]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetDesc(D3D12_SHADER_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D12ShaderReflection*, D3D12_SHADER_DESC*, int>)(lpVtbl[3]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this), pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByIndex([NativeTypeName("UINT")] uint Index)
        {
            return ((delegate* unmanaged<ID3D12ShaderReflection*, uint, ID3D12ShaderReflectionConstantBuffer*>)(lpVtbl[4]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this), Index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return ((delegate* unmanaged<ID3D12ShaderReflection*, sbyte*, ID3D12ShaderReflectionConstantBuffer*>)(lpVtbl[5]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this), Name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetResourceBindingDesc([NativeTypeName("UINT")] uint ResourceIndex, D3D12_SHADER_INPUT_BIND_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D12ShaderReflection*, uint, D3D12_SHADER_INPUT_BIND_DESC*, int>)(lpVtbl[6]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this), ResourceIndex, pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetInputParameterDesc([NativeTypeName("UINT")] uint ParameterIndex, D3D12_SIGNATURE_PARAMETER_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D12ShaderReflection*, uint, D3D12_SIGNATURE_PARAMETER_DESC*, int>)(lpVtbl[7]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this), ParameterIndex, pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetOutputParameterDesc([NativeTypeName("UINT")] uint ParameterIndex, D3D12_SIGNATURE_PARAMETER_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D12ShaderReflection*, uint, D3D12_SIGNATURE_PARAMETER_DESC*, int>)(lpVtbl[8]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this), ParameterIndex, pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int GetPatchConstantParameterDesc([NativeTypeName("UINT")] uint ParameterIndex, D3D12_SIGNATURE_PARAMETER_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D12ShaderReflection*, uint, D3D12_SIGNATURE_PARAMETER_DESC*, int>)(lpVtbl[9]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this), ParameterIndex, pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public ID3D12ShaderReflectionVariable* GetVariableByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return ((delegate* unmanaged<ID3D12ShaderReflection*, sbyte*, ID3D12ShaderReflectionVariable*>)(lpVtbl[10]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this), Name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int GetResourceBindingDescByName([NativeTypeName("LPCSTR")] sbyte* Name, D3D12_SHADER_INPUT_BIND_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D12ShaderReflection*, sbyte*, D3D12_SHADER_INPUT_BIND_DESC*, int>)(lpVtbl[11]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this), Name, pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("UINT")]
        public uint GetMovInstructionCount()
        {
            return ((delegate* unmanaged<ID3D12ShaderReflection*, uint>)(lpVtbl[12]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("UINT")]
        public uint GetMovcInstructionCount()
        {
            return ((delegate* unmanaged<ID3D12ShaderReflection*, uint>)(lpVtbl[13]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("UINT")]
        public uint GetConversionInstructionCount()
        {
            return ((delegate* unmanaged<ID3D12ShaderReflection*, uint>)(lpVtbl[14]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("UINT")]
        public uint GetBitwiseInstructionCount()
        {
            return ((delegate* unmanaged<ID3D12ShaderReflection*, uint>)(lpVtbl[15]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public D3D_PRIMITIVE GetGSInputPrimitive()
        {
            return ((delegate* unmanaged<ID3D12ShaderReflection*, D3D_PRIMITIVE>)(lpVtbl[16]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public BOOL IsSampleFrequencyShader()
        {
            return ((delegate* unmanaged<ID3D12ShaderReflection*, int>)(lpVtbl[17]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("UINT")]
        public uint GetNumInterfaceSlots()
        {
            return ((delegate* unmanaged<ID3D12ShaderReflection*, uint>)(lpVtbl[18]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int GetMinFeatureLevel([NativeTypeName("enum D3D_FEATURE_LEVEL *")] D3D_FEATURE_LEVEL* pLevel)
        {
            return ((delegate* unmanaged<ID3D12ShaderReflection*, D3D_FEATURE_LEVEL*, int>)(lpVtbl[19]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this), pLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("UINT")]
        public uint GetThreadGroupSize([NativeTypeName("UINT *")] uint* pSizeX, [NativeTypeName("UINT *")] uint* pSizeY, [NativeTypeName("UINT *")] uint* pSizeZ)
        {
            return ((delegate* unmanaged<ID3D12ShaderReflection*, uint*, uint*, uint*, uint>)(lpVtbl[20]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this), pSizeX, pSizeY, pSizeZ);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("UINT64")]
        public ulong GetRequiresFlags()
        {
            return ((delegate* unmanaged<ID3D12ShaderReflection*, ulong>)(lpVtbl[21]))((ID3D12ShaderReflection*)Unsafe.AsPointer(ref this));
        }
    }
}
