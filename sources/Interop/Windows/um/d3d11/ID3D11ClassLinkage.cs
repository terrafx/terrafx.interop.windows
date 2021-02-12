// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DDF57CBA-9543-46E4-A12B-F207A0FE7FED")]
    [NativeTypeName("struct ID3D11ClassLinkage : ID3D11DeviceChild")]
    public unsafe partial struct ID3D11ClassLinkage
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D11ClassLinkage*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11ClassLinkage*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D11ClassLinkage*, uint>)(lpVtbl[1]))((ID3D11ClassLinkage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D11ClassLinkage*, uint>)(lpVtbl[2]))((ID3D11ClassLinkage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetDevice([NativeTypeName("ID3D11Device **")] ID3D11Device** ppDevice)
        {
            ((delegate* unmanaged<ID3D11ClassLinkage*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11ClassLinkage*)Unsafe.AsPointer(ref this), ppDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D11ClassLinkage*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11ClassLinkage*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D11ClassLinkage*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11ClassLinkage*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* unmanaged<ID3D11ClassLinkage*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11ClassLinkage*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetClassInstance([NativeTypeName("LPCSTR")] sbyte* pClassInstanceName, [NativeTypeName("UINT")] uint InstanceIndex, [NativeTypeName("ID3D11ClassInstance **")] ID3D11ClassInstance** ppInstance)
        {
            return ((delegate* unmanaged<ID3D11ClassLinkage*, sbyte*, uint, ID3D11ClassInstance**, int>)(lpVtbl[7]))((ID3D11ClassLinkage*)Unsafe.AsPointer(ref this), pClassInstanceName, InstanceIndex, ppInstance);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateClassInstance([NativeTypeName("LPCSTR")] sbyte* pClassTypeName, [NativeTypeName("UINT")] uint ConstantBufferOffset, [NativeTypeName("UINT")] uint ConstantVectorOffset, [NativeTypeName("UINT")] uint TextureOffset, [NativeTypeName("UINT")] uint SamplerOffset, [NativeTypeName("ID3D11ClassInstance **")] ID3D11ClassInstance** ppInstance)
        {
            return ((delegate* unmanaged<ID3D11ClassLinkage*, sbyte*, uint, uint, uint, uint, ID3D11ClassInstance**, int>)(lpVtbl[8]))((ID3D11ClassLinkage*)Unsafe.AsPointer(ref this), pClassTypeName, ConstantBufferOffset, ConstantVectorOffset, TextureOffset, SamplerOffset, ppInstance);
        }
    }
}
