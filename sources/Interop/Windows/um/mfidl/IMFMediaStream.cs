// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D182108F-4EC6-443F-AA42-A71106EC825F")]
    [NativeTypeName("struct IMFMediaStream : IMFMediaEventGenerator")]
    public unsafe partial struct IMFMediaStream
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFMediaStream*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFMediaStream*, uint>)(lpVtbl[1]))((IMFMediaStream*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFMediaStream*, uint>)(lpVtbl[2]))((IMFMediaStream*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetEvent([NativeTypeName("DWORD")] uint dwFlags, IMFMediaEvent** ppEvent)
        {
            return ((delegate* unmanaged<IMFMediaStream*, uint, IMFMediaEvent**, int>)(lpVtbl[3]))((IMFMediaStream*)Unsafe.AsPointer(ref this), dwFlags, ppEvent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BeginGetEvent(IMFAsyncCallback* pCallback, IUnknown* punkState)
        {
            return ((delegate* unmanaged<IMFMediaStream*, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[4]))((IMFMediaStream*)Unsafe.AsPointer(ref this), pCallback, punkState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EndGetEvent(IMFAsyncResult* pResult, IMFMediaEvent** ppEvent)
        {
            return ((delegate* unmanaged<IMFMediaStream*, IMFAsyncResult*, IMFMediaEvent**, int>)(lpVtbl[5]))((IMFMediaStream*)Unsafe.AsPointer(ref this), pResult, ppEvent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueueEvent([NativeTypeName("MediaEventType")] uint met, [NativeTypeName("const GUID &")] Guid* guidExtendedType, [NativeTypeName("HRESULT")] int hrStatus, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvValue)
        {
            return ((delegate* unmanaged<IMFMediaStream*, uint, Guid*, int, PROPVARIANT*, int>)(lpVtbl[6]))((IMFMediaStream*)Unsafe.AsPointer(ref this), met, guidExtendedType, hrStatus, pvValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMediaSource(IMFMediaSource** ppMediaSource)
        {
            return ((delegate* unmanaged<IMFMediaStream*, IMFMediaSource**, int>)(lpVtbl[7]))((IMFMediaStream*)Unsafe.AsPointer(ref this), ppMediaSource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStreamDescriptor(IMFStreamDescriptor** ppStreamDescriptor)
        {
            return ((delegate* unmanaged<IMFMediaStream*, IMFStreamDescriptor**, int>)(lpVtbl[8]))((IMFMediaStream*)Unsafe.AsPointer(ref this), ppStreamDescriptor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RequestSample(IUnknown* pToken)
        {
            return ((delegate* unmanaged<IMFMediaStream*, IUnknown*, int>)(lpVtbl[9]))((IMFMediaStream*)Unsafe.AsPointer(ref this), pToken);
        }
    }
}
