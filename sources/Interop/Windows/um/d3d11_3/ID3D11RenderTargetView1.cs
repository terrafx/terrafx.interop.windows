// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FFBE2E23-F011-418A-AC56-5CEED7C5B94B")]
    [NativeTypeName("struct ID3D11RenderTargetView1 : ID3D11RenderTargetView")]
    public unsafe partial struct ID3D11RenderTargetView1
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID3D11RenderTargetView1*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11RenderTargetView1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID3D11RenderTargetView1*, uint>)(lpVtbl[1]))((ID3D11RenderTargetView1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID3D11RenderTargetView1*, uint>)(lpVtbl[2]))((ID3D11RenderTargetView1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetDevice([NativeTypeName("ID3D11Device **")] ID3D11Device** ppDevice)
        {
            ((delegate* stdcall<ID3D11RenderTargetView1*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11RenderTargetView1*)Unsafe.AsPointer(ref this), ppDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return ((delegate* stdcall<ID3D11RenderTargetView1*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11RenderTargetView1*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* stdcall<ID3D11RenderTargetView1*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11RenderTargetView1*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* stdcall<ID3D11RenderTargetView1*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11RenderTargetView1*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetResource([NativeTypeName("ID3D11Resource **")] ID3D11Resource** ppResource)
        {
            ((delegate* stdcall<ID3D11RenderTargetView1*, ID3D11Resource**, void>)(lpVtbl[7]))((ID3D11RenderTargetView1*)Unsafe.AsPointer(ref this), ppResource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetDesc([NativeTypeName("D3D11_RENDER_TARGET_VIEW_DESC *")] D3D11_RENDER_TARGET_VIEW_DESC* pDesc)
        {
            ((delegate* stdcall<ID3D11RenderTargetView1*, D3D11_RENDER_TARGET_VIEW_DESC*, void>)(lpVtbl[8]))((ID3D11RenderTargetView1*)Unsafe.AsPointer(ref this), pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetDesc1([NativeTypeName("D3D11_RENDER_TARGET_VIEW_DESC1 *")] D3D11_RENDER_TARGET_VIEW_DESC1* pDesc1)
        {
            ((delegate* stdcall<ID3D11RenderTargetView1*, D3D11_RENDER_TARGET_VIEW_DESC1*, void>)(lpVtbl[9]))((ID3D11RenderTargetView1*)Unsafe.AsPointer(ref this), pDesc1);
        }
    }
}
