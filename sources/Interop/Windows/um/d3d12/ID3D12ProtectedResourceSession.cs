// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6CD696F4-F289-40CC-8091-5A6C0A099C3D")]
    [NativeTypeName("struct ID3D12ProtectedResourceSession : ID3D12ProtectedSession")]
    public unsafe partial struct ID3D12ProtectedResourceSession
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID3D12ProtectedResourceSession*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12ProtectedResourceSession*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID3D12ProtectedResourceSession*, uint>)(lpVtbl[1]))((ID3D12ProtectedResourceSession*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID3D12ProtectedResourceSession*, uint>)(lpVtbl[2]))((ID3D12ProtectedResourceSession*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return ((delegate* stdcall<ID3D12ProtectedResourceSession*, Guid*, uint*, void*, int>)(lpVtbl[3]))((ID3D12ProtectedResourceSession*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* stdcall<ID3D12ProtectedResourceSession*, Guid*, uint, void*, int>)(lpVtbl[4]))((ID3D12ProtectedResourceSession*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* stdcall<ID3D12ProtectedResourceSession*, Guid*, IUnknown*, int>)(lpVtbl[5]))((ID3D12ProtectedResourceSession*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetName([NativeTypeName("LPCWSTR")] ushort* Name)
        {
            return ((delegate* stdcall<ID3D12ProtectedResourceSession*, ushort*, int>)(lpVtbl[6]))((ID3D12ProtectedResourceSession*)Unsafe.AsPointer(ref this), Name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvDevice)
        {
            return ((delegate* stdcall<ID3D12ProtectedResourceSession*, Guid*, void**, int>)(lpVtbl[7]))((ID3D12ProtectedResourceSession*)Unsafe.AsPointer(ref this), riid, ppvDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStatusFence([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppFence)
        {
            return ((delegate* stdcall<ID3D12ProtectedResourceSession*, Guid*, void**, int>)(lpVtbl[8]))((ID3D12ProtectedResourceSession*)Unsafe.AsPointer(ref this), riid, ppFence);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public D3D12_PROTECTED_SESSION_STATUS GetSessionStatus()
        {
            return ((delegate* stdcall<ID3D12ProtectedResourceSession*, D3D12_PROTECTED_SESSION_STATUS>)(lpVtbl[9]))((ID3D12ProtectedResourceSession*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public D3D12_PROTECTED_RESOURCE_SESSION_DESC GetDesc()
        {
            D3D12_PROTECTED_RESOURCE_SESSION_DESC result;
            return *((delegate* stdcall<ID3D12ProtectedResourceSession*, D3D12_PROTECTED_RESOURCE_SESSION_DESC*, D3D12_PROTECTED_RESOURCE_SESSION_DESC*>)(lpVtbl[10]))((ID3D12ProtectedResourceSession*)Unsafe.AsPointer(ref this), &result);
        }
    }
}
