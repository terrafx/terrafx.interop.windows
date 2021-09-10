// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3C9B2EB9-86D5-4514-A394-F56664F9F0D8")]
    [NativeTypeName("struct IMFMediaSourceEx : IMFMediaSource")]
    [NativeInheritance("IMFMediaSource")]
    public unsafe partial struct IMFMediaSourceEx
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFMediaSourceEx*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaSourceEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFMediaSourceEx*, uint>)(lpVtbl[1]))((IMFMediaSourceEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFMediaSourceEx*, uint>)(lpVtbl[2]))((IMFMediaSourceEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetEvent([NativeTypeName("DWORD")] uint dwFlags, IMFMediaEvent** ppEvent)
        {
            return ((delegate* unmanaged<IMFMediaSourceEx*, uint, IMFMediaEvent**, int>)(lpVtbl[3]))((IMFMediaSourceEx*)Unsafe.AsPointer(ref this), dwFlags, ppEvent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int BeginGetEvent(IMFAsyncCallback* pCallback, IUnknown* punkState)
        {
            return ((delegate* unmanaged<IMFMediaSourceEx*, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[4]))((IMFMediaSourceEx*)Unsafe.AsPointer(ref this), pCallback, punkState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int EndGetEvent(IMFAsyncResult* pResult, IMFMediaEvent** ppEvent)
        {
            return ((delegate* unmanaged<IMFMediaSourceEx*, IMFAsyncResult*, IMFMediaEvent**, int>)(lpVtbl[5]))((IMFMediaSourceEx*)Unsafe.AsPointer(ref this), pResult, ppEvent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int QueueEvent([NativeTypeName("MediaEventType")] uint met, [NativeTypeName("const GUID &")] Guid* guidExtendedType, [NativeTypeName("HRESULT")] int hrStatus, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvValue)
        {
            return ((delegate* unmanaged<IMFMediaSourceEx*, uint, Guid*, int, PROPVARIANT*, int>)(lpVtbl[6]))((IMFMediaSourceEx*)Unsafe.AsPointer(ref this), met, guidExtendedType, hrStatus, pvValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetCharacteristics([NativeTypeName("DWORD *")] uint* pdwCharacteristics)
        {
            return ((delegate* unmanaged<IMFMediaSourceEx*, uint*, int>)(lpVtbl[7]))((IMFMediaSourceEx*)Unsafe.AsPointer(ref this), pdwCharacteristics);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int CreatePresentationDescriptor(IMFPresentationDescriptor** ppPresentationDescriptor)
        {
            return ((delegate* unmanaged<IMFMediaSourceEx*, IMFPresentationDescriptor**, int>)(lpVtbl[8]))((IMFMediaSourceEx*)Unsafe.AsPointer(ref this), ppPresentationDescriptor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int Start(IMFPresentationDescriptor* pPresentationDescriptor, [NativeTypeName("const GUID *")] Guid* pguidTimeFormat, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarStartPosition)
        {
            return ((delegate* unmanaged<IMFMediaSourceEx*, IMFPresentationDescriptor*, Guid*, PROPVARIANT*, int>)(lpVtbl[9]))((IMFMediaSourceEx*)Unsafe.AsPointer(ref this), pPresentationDescriptor, pguidTimeFormat, pvarStartPosition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int Stop()
        {
            return ((delegate* unmanaged<IMFMediaSourceEx*, int>)(lpVtbl[10]))((IMFMediaSourceEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int Pause()
        {
            return ((delegate* unmanaged<IMFMediaSourceEx*, int>)(lpVtbl[11]))((IMFMediaSourceEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int Shutdown()
        {
            return ((delegate* unmanaged<IMFMediaSourceEx*, int>)(lpVtbl[12]))((IMFMediaSourceEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int GetSourceAttributes(IMFAttributes** ppAttributes)
        {
            return ((delegate* unmanaged<IMFMediaSourceEx*, IMFAttributes**, int>)(lpVtbl[13]))((IMFMediaSourceEx*)Unsafe.AsPointer(ref this), ppAttributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int GetStreamAttributes([NativeTypeName("DWORD")] uint dwStreamIdentifier, IMFAttributes** ppAttributes)
        {
            return ((delegate* unmanaged<IMFMediaSourceEx*, uint, IMFAttributes**, int>)(lpVtbl[14]))((IMFMediaSourceEx*)Unsafe.AsPointer(ref this), dwStreamIdentifier, ppAttributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int SetD3DManager(IUnknown* pManager)
        {
            return ((delegate* unmanaged<IMFMediaSourceEx*, IUnknown*, int>)(lpVtbl[15]))((IMFMediaSourceEx*)Unsafe.AsPointer(ref this), pManager);
        }
    }
}
