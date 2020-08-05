// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BB420AA4-765B-4A1F-91FE-D6A8A143924C")]
    [NativeTypeName("struct IMFByteStreamHandler : IUnknown")]
    public unsafe partial struct IMFByteStreamHandler
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFByteStreamHandler*, Guid*, void**, int>)(lpVtbl[0]))((IMFByteStreamHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFByteStreamHandler*, uint>)(lpVtbl[1]))((IMFByteStreamHandler*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFByteStreamHandler*, uint>)(lpVtbl[2]))((IMFByteStreamHandler*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int BeginCreateObject([NativeTypeName("IMFByteStream *")] IMFByteStream* pByteStream, [NativeTypeName("LPCWSTR")] ushort* pwszURL, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("IPropertyStore *")] IPropertyStore* pProps, [NativeTypeName("IUnknown **")] IUnknown** ppIUnknownCancelCookie, [NativeTypeName("IMFAsyncCallback *")] IMFAsyncCallback* pCallback, [NativeTypeName("IUnknown *")] IUnknown* punkState)
        {
            return ((delegate* stdcall<IMFByteStreamHandler*, IMFByteStream*, ushort*, uint, IPropertyStore*, IUnknown**, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[3]))((IMFByteStreamHandler*)Unsafe.AsPointer(ref this), pByteStream, pwszURL, dwFlags, pProps, ppIUnknownCancelCookie, pCallback, punkState);
        }

        [return: NativeTypeName("HRESULT")]
        public int EndCreateObject([NativeTypeName("IMFAsyncResult *")] IMFAsyncResult* pResult, [NativeTypeName("MF_OBJECT_TYPE *")] MF_OBJECT_TYPE* pObjectType, [NativeTypeName("IUnknown **")] IUnknown** ppObject)
        {
            return ((delegate* stdcall<IMFByteStreamHandler*, IMFAsyncResult*, MF_OBJECT_TYPE*, IUnknown**, int>)(lpVtbl[4]))((IMFByteStreamHandler*)Unsafe.AsPointer(ref this), pResult, pObjectType, ppObject);
        }

        [return: NativeTypeName("HRESULT")]
        public int CancelObjectCreation([NativeTypeName("IUnknown *")] IUnknown* pIUnknownCancelCookie)
        {
            return ((delegate* stdcall<IMFByteStreamHandler*, IUnknown*, int>)(lpVtbl[5]))((IMFByteStreamHandler*)Unsafe.AsPointer(ref this), pIUnknownCancelCookie);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMaxNumberOfBytesRequiredForResolution([NativeTypeName("QWORD *")] ulong* pqwBytes)
        {
            return ((delegate* stdcall<IMFByteStreamHandler*, ulong*, int>)(lpVtbl[6]))((IMFByteStreamHandler*)Unsafe.AsPointer(ref this), pqwBytes);
        }
    }
}
