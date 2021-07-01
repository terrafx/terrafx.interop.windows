// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FBE5A32D-A497-4B61-BB85-97B1A848A6E3")]
    [NativeTypeName("struct IMFSourceResolver : IUnknown")]
    public unsafe partial struct IMFSourceResolver
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFSourceResolver*, Guid*, void**, int>)(lpVtbl[0]))((IMFSourceResolver*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFSourceResolver*, uint>)(lpVtbl[1]))((IMFSourceResolver*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFSourceResolver*, uint>)(lpVtbl[2]))((IMFSourceResolver*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateObjectFromURL([NativeTypeName("LPCWSTR")] ushort* pwszURL, [NativeTypeName("DWORD")] uint dwFlags, IPropertyStore* pProps, MF_OBJECT_TYPE* pObjectType, IUnknown** ppObject)
        {
            return ((delegate* unmanaged<IMFSourceResolver*, ushort*, uint, IPropertyStore*, MF_OBJECT_TYPE*, IUnknown**, int>)(lpVtbl[3]))((IMFSourceResolver*)Unsafe.AsPointer(ref this), pwszURL, dwFlags, pProps, pObjectType, ppObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateObjectFromByteStream(IMFByteStream* pByteStream, [NativeTypeName("LPCWSTR")] ushort* pwszURL, [NativeTypeName("DWORD")] uint dwFlags, IPropertyStore* pProps, MF_OBJECT_TYPE* pObjectType, IUnknown** ppObject)
        {
            return ((delegate* unmanaged<IMFSourceResolver*, IMFByteStream*, ushort*, uint, IPropertyStore*, MF_OBJECT_TYPE*, IUnknown**, int>)(lpVtbl[4]))((IMFSourceResolver*)Unsafe.AsPointer(ref this), pByteStream, pwszURL, dwFlags, pProps, pObjectType, ppObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BeginCreateObjectFromURL([NativeTypeName("LPCWSTR")] ushort* pwszURL, [NativeTypeName("DWORD")] uint dwFlags, IPropertyStore* pProps, IUnknown** ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, IUnknown* punkState)
        {
            return ((delegate* unmanaged<IMFSourceResolver*, ushort*, uint, IPropertyStore*, IUnknown**, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[5]))((IMFSourceResolver*)Unsafe.AsPointer(ref this), pwszURL, dwFlags, pProps, ppIUnknownCancelCookie, pCallback, punkState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EndCreateObjectFromURL(IMFAsyncResult* pResult, MF_OBJECT_TYPE* pObjectType, IUnknown** ppObject)
        {
            return ((delegate* unmanaged<IMFSourceResolver*, IMFAsyncResult*, MF_OBJECT_TYPE*, IUnknown**, int>)(lpVtbl[6]))((IMFSourceResolver*)Unsafe.AsPointer(ref this), pResult, pObjectType, ppObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BeginCreateObjectFromByteStream(IMFByteStream* pByteStream, [NativeTypeName("LPCWSTR")] ushort* pwszURL, [NativeTypeName("DWORD")] uint dwFlags, IPropertyStore* pProps, IUnknown** ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, IUnknown* punkState)
        {
            return ((delegate* unmanaged<IMFSourceResolver*, IMFByteStream*, ushort*, uint, IPropertyStore*, IUnknown**, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[7]))((IMFSourceResolver*)Unsafe.AsPointer(ref this), pByteStream, pwszURL, dwFlags, pProps, ppIUnknownCancelCookie, pCallback, punkState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EndCreateObjectFromByteStream(IMFAsyncResult* pResult, MF_OBJECT_TYPE* pObjectType, IUnknown** ppObject)
        {
            return ((delegate* unmanaged<IMFSourceResolver*, IMFAsyncResult*, MF_OBJECT_TYPE*, IUnknown**, int>)(lpVtbl[8]))((IMFSourceResolver*)Unsafe.AsPointer(ref this), pResult, pObjectType, ppObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CancelObjectCreation(IUnknown* pIUnknownCancelCookie)
        {
            return ((delegate* unmanaged<IMFSourceResolver*, IUnknown*, int>)(lpVtbl[9]))((IMFSourceResolver*)Unsafe.AsPointer(ref this), pIUnknownCancelCookie);
        }
    }
}
