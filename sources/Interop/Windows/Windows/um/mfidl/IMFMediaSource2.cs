// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("FBB03414-D13B-4786-8319-5AC51FC0A136")]
[NativeTypeName("struct IMFMediaSource2 : IMFMediaSourceEx")]
[NativeInheritance("IMFMediaSourceEx")]
public unsafe partial struct IMFMediaSource2 : IMFMediaSource2.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMediaSource2*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaSource2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFMediaSource2*, uint>)(lpVtbl[1]))((IMFMediaSource2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaSource2*, uint>)(lpVtbl[2]))((IMFMediaSource2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetEvent([NativeTypeName("DWORD")] uint dwFlags, IMFMediaEvent** ppEvent)
    {
        return ((delegate* unmanaged<IMFMediaSource2*, uint, IMFMediaEvent**, int>)(lpVtbl[3]))((IMFMediaSource2*)Unsafe.AsPointer(ref this), dwFlags, ppEvent);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT BeginGetEvent(IMFAsyncCallback* pCallback, IUnknown* punkState)
    {
        return ((delegate* unmanaged<IMFMediaSource2*, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[4]))((IMFMediaSource2*)Unsafe.AsPointer(ref this), pCallback, punkState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT EndGetEvent(IMFAsyncResult* pResult, IMFMediaEvent** ppEvent)
    {
        return ((delegate* unmanaged<IMFMediaSource2*, IMFAsyncResult*, IMFMediaEvent**, int>)(lpVtbl[5]))((IMFMediaSource2*)Unsafe.AsPointer(ref this), pResult, ppEvent);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT QueueEvent([NativeTypeName("MediaEventType")] uint met, [NativeTypeName("const GUID &")] Guid* guidExtendedType, HRESULT hrStatus, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvValue)
    {
        return ((delegate* unmanaged<IMFMediaSource2*, uint, Guid*, HRESULT, PROPVARIANT*, int>)(lpVtbl[6]))((IMFMediaSource2*)Unsafe.AsPointer(ref this), met, guidExtendedType, hrStatus, pvValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetCharacteristics([NativeTypeName("DWORD *")] uint* pdwCharacteristics)
    {
        return ((delegate* unmanaged<IMFMediaSource2*, uint*, int>)(lpVtbl[7]))((IMFMediaSource2*)Unsafe.AsPointer(ref this), pdwCharacteristics);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreatePresentationDescriptor(IMFPresentationDescriptor** ppPresentationDescriptor)
    {
        return ((delegate* unmanaged<IMFMediaSource2*, IMFPresentationDescriptor**, int>)(lpVtbl[8]))((IMFMediaSource2*)Unsafe.AsPointer(ref this), ppPresentationDescriptor);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Start(IMFPresentationDescriptor* pPresentationDescriptor, [NativeTypeName("const GUID *")] Guid* pguidTimeFormat, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarStartPosition)
    {
        return ((delegate* unmanaged<IMFMediaSource2*, IMFPresentationDescriptor*, Guid*, PROPVARIANT*, int>)(lpVtbl[9]))((IMFMediaSource2*)Unsafe.AsPointer(ref this), pPresentationDescriptor, pguidTimeFormat, pvarStartPosition);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged<IMFMediaSource2*, int>)(lpVtbl[10]))((IMFMediaSource2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Pause()
    {
        return ((delegate* unmanaged<IMFMediaSource2*, int>)(lpVtbl[11]))((IMFMediaSource2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Shutdown()
    {
        return ((delegate* unmanaged<IMFMediaSource2*, int>)(lpVtbl[12]))((IMFMediaSource2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetSourceAttributes(IMFAttributes** ppAttributes)
    {
        return ((delegate* unmanaged<IMFMediaSource2*, IMFAttributes**, int>)(lpVtbl[13]))((IMFMediaSource2*)Unsafe.AsPointer(ref this), ppAttributes);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetStreamAttributes([NativeTypeName("DWORD")] uint dwStreamIdentifier, IMFAttributes** ppAttributes)
    {
        return ((delegate* unmanaged<IMFMediaSource2*, uint, IMFAttributes**, int>)(lpVtbl[14]))((IMFMediaSource2*)Unsafe.AsPointer(ref this), dwStreamIdentifier, ppAttributes);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetD3DManager(IUnknown* pManager)
    {
        return ((delegate* unmanaged<IMFMediaSource2*, IUnknown*, int>)(lpVtbl[15]))((IMFMediaSource2*)Unsafe.AsPointer(ref this), pManager);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SetMediaType([NativeTypeName("DWORD")] uint dwStreamID, IMFMediaType* pMediaType)
    {
        return ((delegate* unmanaged<IMFMediaSource2*, uint, IMFMediaType*, int>)(lpVtbl[16]))((IMFMediaSource2*)Unsafe.AsPointer(ref this), dwStreamID, pMediaType);
    }

    public interface Interface : IMFMediaSourceEx.Interface
    {
        [VtblIndex(16)]
        HRESULT SetMediaType([NativeTypeName("DWORD")] uint dwStreamID, IMFMediaType* pMediaType);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaSource2*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaSource2*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaSource2*, uint> Release;

        [NativeTypeName("HRESULT (DWORD, IMFMediaEvent **) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaSource2*, uint, IMFMediaEvent**, int> GetEvent;

        [NativeTypeName("HRESULT (IMFAsyncCallback *, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaSource2*, IMFAsyncCallback*, IUnknown*, int> BeginGetEvent;

        [NativeTypeName("HRESULT (IMFAsyncResult *, IMFMediaEvent **) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaSource2*, IMFAsyncResult*, IMFMediaEvent**, int> EndGetEvent;

        [NativeTypeName("HRESULT (MediaEventType, const GUID &, HRESULT, const PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaSource2*, uint, Guid*, HRESULT, PROPVARIANT*, int> QueueEvent;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaSource2*, uint*, int> GetCharacteristics;

        [NativeTypeName("HRESULT (IMFPresentationDescriptor **) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaSource2*, IMFPresentationDescriptor**, int> CreatePresentationDescriptor;

        [NativeTypeName("HRESULT (IMFPresentationDescriptor *, const GUID *, const PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaSource2*, IMFPresentationDescriptor*, Guid*, PROPVARIANT*, int> Start;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaSource2*, int> Stop;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaSource2*, int> Pause;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaSource2*, int> Shutdown;

        [NativeTypeName("HRESULT (IMFAttributes **) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaSource2*, IMFAttributes**, int> GetSourceAttributes;

        [NativeTypeName("HRESULT (DWORD, IMFAttributes **) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaSource2*, uint, IMFAttributes**, int> GetStreamAttributes;

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaSource2*, IUnknown*, int> SetD3DManager;

        [NativeTypeName("HRESULT (DWORD, IMFMediaType *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaSource2*, uint, IMFMediaType*, int> SetMediaType;
    }
}
