// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FBB03414-D13B-4786-8319-5AC51FC0A136")]
    [NativeTypeName("struct IMFMediaSource2 : IMFMediaSourceEx")]
    public unsafe partial struct IMFMediaSource2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFMediaSource2*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaSource2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFMediaSource2*, uint>)(lpVtbl[1]))((IMFMediaSource2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFMediaSource2*, uint>)(lpVtbl[2]))((IMFMediaSource2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetEvent([NativeTypeName("DWORD")] uint dwFlags, IMFMediaEvent** ppEvent)
        {
            return ((delegate* unmanaged<IMFMediaSource2*, uint, IMFMediaEvent**, int>)(lpVtbl[3]))((IMFMediaSource2*)Unsafe.AsPointer(ref this), dwFlags, ppEvent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BeginGetEvent(IMFAsyncCallback* pCallback, IUnknown* punkState)
        {
            return ((delegate* unmanaged<IMFMediaSource2*, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[4]))((IMFMediaSource2*)Unsafe.AsPointer(ref this), pCallback, punkState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EndGetEvent(IMFAsyncResult* pResult, IMFMediaEvent** ppEvent)
        {
            return ((delegate* unmanaged<IMFMediaSource2*, IMFAsyncResult*, IMFMediaEvent**, int>)(lpVtbl[5]))((IMFMediaSource2*)Unsafe.AsPointer(ref this), pResult, ppEvent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueueEvent([NativeTypeName("MediaEventType")] uint met, [NativeTypeName("const GUID &")] Guid* guidExtendedType, [NativeTypeName("HRESULT")] int hrStatus, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvValue)
        {
            return ((delegate* unmanaged<IMFMediaSource2*, uint, Guid*, int, PROPVARIANT*, int>)(lpVtbl[6]))((IMFMediaSource2*)Unsafe.AsPointer(ref this), met, guidExtendedType, hrStatus, pvValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCharacteristics([NativeTypeName("DWORD *")] uint* pdwCharacteristics)
        {
            return ((delegate* unmanaged<IMFMediaSource2*, uint*, int>)(lpVtbl[7]))((IMFMediaSource2*)Unsafe.AsPointer(ref this), pdwCharacteristics);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreatePresentationDescriptor(IMFPresentationDescriptor** ppPresentationDescriptor)
        {
            return ((delegate* unmanaged<IMFMediaSource2*, IMFPresentationDescriptor**, int>)(lpVtbl[8]))((IMFMediaSource2*)Unsafe.AsPointer(ref this), ppPresentationDescriptor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Start(IMFPresentationDescriptor* pPresentationDescriptor, [NativeTypeName("const GUID *")] Guid* pguidTimeFormat, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarStartPosition)
        {
            return ((delegate* unmanaged<IMFMediaSource2*, IMFPresentationDescriptor*, Guid*, PROPVARIANT*, int>)(lpVtbl[9]))((IMFMediaSource2*)Unsafe.AsPointer(ref this), pPresentationDescriptor, pguidTimeFormat, pvarStartPosition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Stop()
        {
            return ((delegate* unmanaged<IMFMediaSource2*, int>)(lpVtbl[10]))((IMFMediaSource2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Pause()
        {
            return ((delegate* unmanaged<IMFMediaSource2*, int>)(lpVtbl[11]))((IMFMediaSource2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Shutdown()
        {
            return ((delegate* unmanaged<IMFMediaSource2*, int>)(lpVtbl[12]))((IMFMediaSource2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSourceAttributes(IMFAttributes** ppAttributes)
        {
            return ((delegate* unmanaged<IMFMediaSource2*, IMFAttributes**, int>)(lpVtbl[13]))((IMFMediaSource2*)Unsafe.AsPointer(ref this), ppAttributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStreamAttributes([NativeTypeName("DWORD")] uint dwStreamIdentifier, IMFAttributes** ppAttributes)
        {
            return ((delegate* unmanaged<IMFMediaSource2*, uint, IMFAttributes**, int>)(lpVtbl[14]))((IMFMediaSource2*)Unsafe.AsPointer(ref this), dwStreamIdentifier, ppAttributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetD3DManager(IUnknown* pManager)
        {
            return ((delegate* unmanaged<IMFMediaSource2*, IUnknown*, int>)(lpVtbl[15]))((IMFMediaSource2*)Unsafe.AsPointer(ref this), pManager);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetMediaType([NativeTypeName("DWORD")] uint dwStreamID, IMFMediaType* pMediaType)
        {
            return ((delegate* unmanaged<IMFMediaSource2*, uint, IMFMediaType*, int>)(lpVtbl[16]))((IMFMediaSource2*)Unsafe.AsPointer(ref this), dwStreamID, pMediaType);
        }
    }
}
