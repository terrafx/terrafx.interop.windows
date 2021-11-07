// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    [SupportedOSPlatform("windows10.0")]
    [Guid("6CD696F4-F289-40CC-8091-5A6C0A099C3D")]
    [NativeTypeName("struct ID3D12ProtectedResourceSession : ID3D12ProtectedSession")]
    [NativeInheritance("ID3D12ProtectedSession")]
    public unsafe partial struct ID3D12ProtectedResourceSession : ID3D12ProtectedResourceSession.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12ProtectedResourceSession*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12ProtectedResourceSession*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12ProtectedResourceSession*, uint>)(lpVtbl[1]))((ID3D12ProtectedResourceSession*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D12ProtectedResourceSession*, uint>)(lpVtbl[2]))((ID3D12ProtectedResourceSession*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<ID3D12ProtectedResourceSession*, Guid*, uint*, void*, int>)(lpVtbl[3]))((ID3D12ProtectedResourceSession*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D12ProtectedResourceSession*, Guid*, uint, void*, int>)(lpVtbl[4]))((ID3D12ProtectedResourceSession*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* unmanaged<ID3D12ProtectedResourceSession*, Guid*, IUnknown*, int>)(lpVtbl[5]))((ID3D12ProtectedResourceSession*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetName([NativeTypeName("LPCWSTR")] ushort* Name)
        {
            return ((delegate* unmanaged<ID3D12ProtectedResourceSession*, ushort*, int>)(lpVtbl[6]))((ID3D12ProtectedResourceSession*)Unsafe.AsPointer(ref this), Name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppvDevice)
        {
            return ((delegate* unmanaged<ID3D12ProtectedResourceSession*, Guid*, void**, int>)(lpVtbl[7]))((ID3D12ProtectedResourceSession*)Unsafe.AsPointer(ref this), riid, ppvDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetStatusFence([NativeTypeName("const IID &")] Guid* riid, void** ppFence)
        {
            return ((delegate* unmanaged<ID3D12ProtectedResourceSession*, Guid*, void**, int>)(lpVtbl[8]))((ID3D12ProtectedResourceSession*)Unsafe.AsPointer(ref this), riid, ppFence);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public D3D12_PROTECTED_SESSION_STATUS GetSessionStatus()
        {
            return ((delegate* unmanaged<ID3D12ProtectedResourceSession*, D3D12_PROTECTED_SESSION_STATUS>)(lpVtbl[9]))((ID3D12ProtectedResourceSession*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public D3D12_PROTECTED_RESOURCE_SESSION_DESC GetDesc()
        {
            D3D12_PROTECTED_RESOURCE_SESSION_DESC result;
            return *((delegate* unmanaged<ID3D12ProtectedResourceSession*, D3D12_PROTECTED_RESOURCE_SESSION_DESC*, D3D12_PROTECTED_RESOURCE_SESSION_DESC*>)(lpVtbl[10]))((ID3D12ProtectedResourceSession*)Unsafe.AsPointer(ref this), &result);
        }

        public interface Interface : ID3D12ProtectedSession.Interface
        {
            [VtblIndex(10)]
            D3D12_PROTECTED_RESOURCE_SESSION_DESC GetDesc();
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D12ProtectedResourceSession*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D12ProtectedResourceSession*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D12ProtectedResourceSession*, uint> Release;

            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D12ProtectedResourceSession*, Guid*, uint*, void*, int> GetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D12ProtectedResourceSession*, Guid*, uint, void*, int> SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D12ProtectedResourceSession*, Guid*, IUnknown*, int> SetPrivateDataInterface;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D12ProtectedResourceSession*, ushort*, int> SetName;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D12ProtectedResourceSession*, Guid*, void**, int> GetDevice;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D12ProtectedResourceSession*, Guid*, void**, int> GetStatusFence;

            [NativeTypeName("D3D12_PROTECTED_SESSION_STATUS () __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D12ProtectedResourceSession*, D3D12_PROTECTED_SESSION_STATUS> GetSessionStatus;

            [NativeTypeName("D3D12_PROTECTED_RESOURCE_SESSION_DESC () __attribute__((stdcall))")]
            public delegate* unmanaged<ID3D12ProtectedResourceSession*, D3D12_PROTECTED_RESOURCE_SESSION_DESC*, D3D12_PROTECTED_RESOURCE_SESSION_DESC*> GetDesc;
        }
    }
}
