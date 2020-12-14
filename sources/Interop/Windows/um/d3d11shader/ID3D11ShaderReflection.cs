// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shader.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8D536CA1-0CCA-4956-A837-786963755584")]
    [NativeTypeName("struct ID3D11ShaderReflection : IUnknown")]
    public unsafe partial struct ID3D11ShaderReflection
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D11ShaderReflection*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D11ShaderReflection*, uint>)(lpVtbl[1]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D11ShaderReflection*, uint>)(lpVtbl[2]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDesc([NativeTypeName("D3D11_SHADER_DESC *")] D3D11_SHADER_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D11ShaderReflection*, D3D11_SHADER_DESC*, int>)(lpVtbl[3]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ID3D11ShaderReflectionConstantBuffer *")]
        public ID3D11ShaderReflectionConstantBuffer* GetConstantBufferByIndex([NativeTypeName("UINT")] uint Index)
        {
            return ((delegate* unmanaged<ID3D11ShaderReflection*, uint, ID3D11ShaderReflectionConstantBuffer*>)(lpVtbl[4]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), Index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ID3D11ShaderReflectionConstantBuffer *")]
        public ID3D11ShaderReflectionConstantBuffer* GetConstantBufferByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return ((delegate* unmanaged<ID3D11ShaderReflection*, sbyte*, ID3D11ShaderReflectionConstantBuffer*>)(lpVtbl[5]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), Name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetResourceBindingDesc([NativeTypeName("UINT")] uint ResourceIndex, [NativeTypeName("D3D11_SHADER_INPUT_BIND_DESC *")] D3D11_SHADER_INPUT_BIND_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D11ShaderReflection*, uint, D3D11_SHADER_INPUT_BIND_DESC*, int>)(lpVtbl[6]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), ResourceIndex, pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetInputParameterDesc([NativeTypeName("UINT")] uint ParameterIndex, [NativeTypeName("D3D11_SIGNATURE_PARAMETER_DESC *")] D3D11_SIGNATURE_PARAMETER_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D11ShaderReflection*, uint, D3D11_SIGNATURE_PARAMETER_DESC*, int>)(lpVtbl[7]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), ParameterIndex, pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetOutputParameterDesc([NativeTypeName("UINT")] uint ParameterIndex, [NativeTypeName("D3D11_SIGNATURE_PARAMETER_DESC *")] D3D11_SIGNATURE_PARAMETER_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D11ShaderReflection*, uint, D3D11_SIGNATURE_PARAMETER_DESC*, int>)(lpVtbl[8]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), ParameterIndex, pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPatchConstantParameterDesc([NativeTypeName("UINT")] uint ParameterIndex, [NativeTypeName("D3D11_SIGNATURE_PARAMETER_DESC *")] D3D11_SIGNATURE_PARAMETER_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D11ShaderReflection*, uint, D3D11_SIGNATURE_PARAMETER_DESC*, int>)(lpVtbl[9]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), ParameterIndex, pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ID3D11ShaderReflectionVariable *")]
        public ID3D11ShaderReflectionVariable* GetVariableByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return ((delegate* unmanaged<ID3D11ShaderReflection*, sbyte*, ID3D11ShaderReflectionVariable*>)(lpVtbl[10]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), Name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetResourceBindingDescByName([NativeTypeName("LPCSTR")] sbyte* Name, [NativeTypeName("D3D11_SHADER_INPUT_BIND_DESC *")] D3D11_SHADER_INPUT_BIND_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D11ShaderReflection*, sbyte*, D3D11_SHADER_INPUT_BIND_DESC*, int>)(lpVtbl[11]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), Name, pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT")]
        public uint GetMovInstructionCount()
        {
            return ((delegate* unmanaged<ID3D11ShaderReflection*, uint>)(lpVtbl[12]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT")]
        public uint GetMovcInstructionCount()
        {
            return ((delegate* unmanaged<ID3D11ShaderReflection*, uint>)(lpVtbl[13]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT")]
        public uint GetConversionInstructionCount()
        {
            return ((delegate* unmanaged<ID3D11ShaderReflection*, uint>)(lpVtbl[14]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT")]
        public uint GetBitwiseInstructionCount()
        {
            return ((delegate* unmanaged<ID3D11ShaderReflection*, uint>)(lpVtbl[15]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public D3D_PRIMITIVE GetGSInputPrimitive()
        {
            return ((delegate* unmanaged<ID3D11ShaderReflection*, D3D_PRIMITIVE>)(lpVtbl[16]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int IsSampleFrequencyShader()
        {
            return ((delegate* unmanaged<ID3D11ShaderReflection*, int>)(lpVtbl[17]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT")]
        public uint GetNumInterfaceSlots()
        {
            return ((delegate* unmanaged<ID3D11ShaderReflection*, uint>)(lpVtbl[18]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMinFeatureLevel([NativeTypeName("enum D3D_FEATURE_LEVEL *")] D3D_FEATURE_LEVEL* pLevel)
        {
            return ((delegate* unmanaged<ID3D11ShaderReflection*, D3D_FEATURE_LEVEL*, int>)(lpVtbl[19]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), pLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT")]
        public uint GetThreadGroupSize([NativeTypeName("UINT *")] uint* pSizeX, [NativeTypeName("UINT *")] uint* pSizeY, [NativeTypeName("UINT *")] uint* pSizeZ)
        {
            return ((delegate* unmanaged<ID3D11ShaderReflection*, uint*, uint*, uint*, uint>)(lpVtbl[20]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this), pSizeX, pSizeY, pSizeZ);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT64")]
        public ulong GetRequiresFlags()
        {
            return ((delegate* unmanaged<ID3D11ShaderReflection*, ulong>)(lpVtbl[21]))((ID3D11ShaderReflection*)Unsafe.AsPointer(ref this));
        }
    }
}
