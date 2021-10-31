// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C5BC37D6-75C7-46A1-A132-81B5F723C20F")]
    [NativeTypeName("struct IMFMediaStream2 : IMFMediaStream")]
    [NativeInheritance("IMFMediaStream")]
    public unsafe partial struct IMFMediaStream2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFMediaStream2*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaStream2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFMediaStream2*, uint>)(lpVtbl[1]))((IMFMediaStream2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFMediaStream2*, uint>)(lpVtbl[2]))((IMFMediaStream2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetEvent([NativeTypeName("DWORD")] uint dwFlags, IMFMediaEvent** ppEvent)
        {
            return ((delegate* unmanaged<IMFMediaStream2*, uint, IMFMediaEvent**, int>)(lpVtbl[3]))((IMFMediaStream2*)Unsafe.AsPointer(ref this), dwFlags, ppEvent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT BeginGetEvent(IMFAsyncCallback* pCallback, IUnknown* punkState)
        {
            return ((delegate* unmanaged<IMFMediaStream2*, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[4]))((IMFMediaStream2*)Unsafe.AsPointer(ref this), pCallback, punkState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT EndGetEvent(IMFAsyncResult* pResult, IMFMediaEvent** ppEvent)
        {
            return ((delegate* unmanaged<IMFMediaStream2*, IMFAsyncResult*, IMFMediaEvent**, int>)(lpVtbl[5]))((IMFMediaStream2*)Unsafe.AsPointer(ref this), pResult, ppEvent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT QueueEvent([NativeTypeName("MediaEventType")] uint met, [NativeTypeName("const GUID &")] Guid* guidExtendedType, HRESULT hrStatus, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvValue)
        {
            return ((delegate* unmanaged<IMFMediaStream2*, uint, Guid*, HRESULT, PROPVARIANT*, int>)(lpVtbl[6]))((IMFMediaStream2*)Unsafe.AsPointer(ref this), met, guidExtendedType, hrStatus, pvValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetMediaSource(IMFMediaSource** ppMediaSource)
        {
            return ((delegate* unmanaged<IMFMediaStream2*, IMFMediaSource**, int>)(lpVtbl[7]))((IMFMediaStream2*)Unsafe.AsPointer(ref this), ppMediaSource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetStreamDescriptor(IMFStreamDescriptor** ppStreamDescriptor)
        {
            return ((delegate* unmanaged<IMFMediaStream2*, IMFStreamDescriptor**, int>)(lpVtbl[8]))((IMFMediaStream2*)Unsafe.AsPointer(ref this), ppStreamDescriptor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT RequestSample(IUnknown* pToken)
        {
            return ((delegate* unmanaged<IMFMediaStream2*, IUnknown*, int>)(lpVtbl[9]))((IMFMediaStream2*)Unsafe.AsPointer(ref this), pToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT SetStreamState(MF_STREAM_STATE value)
        {
            return ((delegate* unmanaged<IMFMediaStream2*, MF_STREAM_STATE, int>)(lpVtbl[10]))((IMFMediaStream2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetStreamState(MF_STREAM_STATE* value)
        {
            return ((delegate* unmanaged<IMFMediaStream2*, MF_STREAM_STATE*, int>)(lpVtbl[11]))((IMFMediaStream2*)Unsafe.AsPointer(ref this), value);
        }
    }
}
