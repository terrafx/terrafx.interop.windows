// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2F69D622-20B5-41E9-AFDF-89CED1DDA04E")]
    [NativeTypeName("struct IMFMediaEngineExtension : IUnknown")]
    public unsafe partial struct IMFMediaEngineExtension
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFMediaEngineExtension*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaEngineExtension*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFMediaEngineExtension*, uint>)(lpVtbl[1]))((IMFMediaEngineExtension*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFMediaEngineExtension*, uint>)(lpVtbl[2]))((IMFMediaEngineExtension*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CanPlayType([NativeTypeName("BOOL")] int AudioOnly, [NativeTypeName("BSTR")] ushort* MimeType, MF_MEDIA_ENGINE_CANPLAY* pAnswer)
        {
            return ((delegate* unmanaged<IMFMediaEngineExtension*, int, ushort*, MF_MEDIA_ENGINE_CANPLAY*, int>)(lpVtbl[3]))((IMFMediaEngineExtension*)Unsafe.AsPointer(ref this), AudioOnly, MimeType, pAnswer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BeginCreateObject([NativeTypeName("BSTR")] ushort* bstrURL, IMFByteStream* pByteStream, MF_OBJECT_TYPE type, IUnknown** ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, IUnknown* punkState)
        {
            return ((delegate* unmanaged<IMFMediaEngineExtension*, ushort*, IMFByteStream*, MF_OBJECT_TYPE, IUnknown**, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[4]))((IMFMediaEngineExtension*)Unsafe.AsPointer(ref this), bstrURL, pByteStream, type, ppIUnknownCancelCookie, pCallback, punkState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CancelObjectCreation(IUnknown* pIUnknownCancelCookie)
        {
            return ((delegate* unmanaged<IMFMediaEngineExtension*, IUnknown*, int>)(lpVtbl[5]))((IMFMediaEngineExtension*)Unsafe.AsPointer(ref this), pIUnknownCancelCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EndCreateObject(IMFAsyncResult* pResult, IUnknown** ppObject)
        {
            return ((delegate* unmanaged<IMFMediaEngineExtension*, IMFAsyncResult*, IUnknown**, int>)(lpVtbl[6]))((IMFMediaEngineExtension*)Unsafe.AsPointer(ref this), pResult, ppObject);
        }
    }
}
