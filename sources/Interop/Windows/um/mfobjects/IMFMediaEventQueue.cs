// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("36F846FC-2256-48B6-B58E-E2B638316581")]
    [NativeTypeName("struct IMFMediaEventQueue : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFMediaEventQueue
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFMediaEventQueue*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaEventQueue*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFMediaEventQueue*, uint>)(lpVtbl[1]))((IMFMediaEventQueue*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFMediaEventQueue*, uint>)(lpVtbl[2]))((IMFMediaEventQueue*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetEvent([NativeTypeName("DWORD")] uint dwFlags, IMFMediaEvent** ppEvent)
        {
            return ((delegate* unmanaged<IMFMediaEventQueue*, uint, IMFMediaEvent**, int>)(lpVtbl[3]))((IMFMediaEventQueue*)Unsafe.AsPointer(ref this), dwFlags, ppEvent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int BeginGetEvent(IMFAsyncCallback* pCallback, IUnknown* punkState)
        {
            return ((delegate* unmanaged<IMFMediaEventQueue*, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[4]))((IMFMediaEventQueue*)Unsafe.AsPointer(ref this), pCallback, punkState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int EndGetEvent(IMFAsyncResult* pResult, IMFMediaEvent** ppEvent)
        {
            return ((delegate* unmanaged<IMFMediaEventQueue*, IMFAsyncResult*, IMFMediaEvent**, int>)(lpVtbl[5]))((IMFMediaEventQueue*)Unsafe.AsPointer(ref this), pResult, ppEvent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int QueueEvent(IMFMediaEvent* pEvent)
        {
            return ((delegate* unmanaged<IMFMediaEventQueue*, IMFMediaEvent*, int>)(lpVtbl[6]))((IMFMediaEventQueue*)Unsafe.AsPointer(ref this), pEvent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int QueueEventParamVar([NativeTypeName("MediaEventType")] uint met, [NativeTypeName("const GUID &")] Guid* guidExtendedType, [NativeTypeName("HRESULT")] int hrStatus, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvValue)
        {
            return ((delegate* unmanaged<IMFMediaEventQueue*, uint, Guid*, int, PROPVARIANT*, int>)(lpVtbl[7]))((IMFMediaEventQueue*)Unsafe.AsPointer(ref this), met, guidExtendedType, hrStatus, pvValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int QueueEventParamUnk([NativeTypeName("MediaEventType")] uint met, [NativeTypeName("const GUID &")] Guid* guidExtendedType, [NativeTypeName("HRESULT")] int hrStatus, IUnknown* pUnk)
        {
            return ((delegate* unmanaged<IMFMediaEventQueue*, uint, Guid*, int, IUnknown*, int>)(lpVtbl[8]))((IMFMediaEventQueue*)Unsafe.AsPointer(ref this), met, guidExtendedType, hrStatus, pUnk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int Shutdown()
        {
            return ((delegate* unmanaged<IMFMediaEventQueue*, int>)(lpVtbl[9]))((IMFMediaEventQueue*)Unsafe.AsPointer(ref this));
        }
    }
}
