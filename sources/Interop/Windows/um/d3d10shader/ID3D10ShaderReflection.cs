// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10shader.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D40E20B6-F8F7-42AD-AB20-4BAF8F15DFAA")]
    [NativeTypeName("struct ID3D10ShaderReflection : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ID3D10ShaderReflection
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D10ShaderReflection*, Guid*, void**, int>)(lpVtbl[0]))((ID3D10ShaderReflection*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D10ShaderReflection*, uint>)(lpVtbl[1]))((ID3D10ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D10ShaderReflection*, uint>)(lpVtbl[2]))((ID3D10ShaderReflection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetDesc(D3D10_SHADER_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D10ShaderReflection*, D3D10_SHADER_DESC*, int>)(lpVtbl[3]))((ID3D10ShaderReflection*)Unsafe.AsPointer(ref this), pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public ID3D10ShaderReflectionConstantBuffer* GetConstantBufferByIndex([NativeTypeName("UINT")] uint Index)
        {
            return ((delegate* unmanaged<ID3D10ShaderReflection*, uint, ID3D10ShaderReflectionConstantBuffer*>)(lpVtbl[4]))((ID3D10ShaderReflection*)Unsafe.AsPointer(ref this), Index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public ID3D10ShaderReflectionConstantBuffer* GetConstantBufferByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return ((delegate* unmanaged<ID3D10ShaderReflection*, sbyte*, ID3D10ShaderReflectionConstantBuffer*>)(lpVtbl[5]))((ID3D10ShaderReflection*)Unsafe.AsPointer(ref this), Name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetResourceBindingDesc([NativeTypeName("UINT")] uint ResourceIndex, D3D10_SHADER_INPUT_BIND_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D10ShaderReflection*, uint, D3D10_SHADER_INPUT_BIND_DESC*, int>)(lpVtbl[6]))((ID3D10ShaderReflection*)Unsafe.AsPointer(ref this), ResourceIndex, pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetInputParameterDesc([NativeTypeName("UINT")] uint ParameterIndex, D3D10_SIGNATURE_PARAMETER_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D10ShaderReflection*, uint, D3D10_SIGNATURE_PARAMETER_DESC*, int>)(lpVtbl[7]))((ID3D10ShaderReflection*)Unsafe.AsPointer(ref this), ParameterIndex, pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetOutputParameterDesc([NativeTypeName("UINT")] uint ParameterIndex, D3D10_SIGNATURE_PARAMETER_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D10ShaderReflection*, uint, D3D10_SIGNATURE_PARAMETER_DESC*, int>)(lpVtbl[8]))((ID3D10ShaderReflection*)Unsafe.AsPointer(ref this), ParameterIndex, pDesc);
        }
    }
}
