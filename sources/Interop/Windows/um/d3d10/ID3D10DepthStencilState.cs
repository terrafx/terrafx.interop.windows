// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2B4B1CC8-A4AD-41F8-8322-CA86FC3EC675")]
    [NativeTypeName("struct ID3D10DepthStencilState : ID3D10DeviceChild")]
    public unsafe partial struct ID3D10DepthStencilState
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D10DepthStencilState*, Guid*, void**, int>)(lpVtbl[0]))((ID3D10DepthStencilState*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D10DepthStencilState*, uint>)(lpVtbl[1]))((ID3D10DepthStencilState*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D10DepthStencilState*, uint>)(lpVtbl[2]))((ID3D10DepthStencilState*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetDevice(ID3D10Device** ppDevice)
        {
            ((delegate* unmanaged<ID3D10DepthStencilState*, ID3D10Device**, void>)(lpVtbl[3]))((ID3D10DepthStencilState*)Unsafe.AsPointer(ref this), ppDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<ID3D10DepthStencilState*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D10DepthStencilState*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D10DepthStencilState*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D10DepthStencilState*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* unmanaged<ID3D10DepthStencilState*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D10DepthStencilState*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetDesc(D3D10_DEPTH_STENCIL_DESC* pDesc)
        {
            ((delegate* unmanaged<ID3D10DepthStencilState*, D3D10_DEPTH_STENCIL_DESC*, void>)(lpVtbl[7]))((ID3D10DepthStencilState*)Unsafe.AsPointer(ref this), pDesc);
        }
    }
}
