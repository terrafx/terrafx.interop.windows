// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("279A808D-AEC7-40C8-9C6B-A6B492C78A66")]
    [NativeTypeName("struct IMFMediaSource : IMFMediaEventGenerator")]
    public unsafe partial struct IMFMediaSource
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFMediaSource*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFMediaSource*, uint>)(lpVtbl[1]))((IMFMediaSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFMediaSource*, uint>)(lpVtbl[2]))((IMFMediaSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetEvent([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("IMFMediaEvent **")] IMFMediaEvent** ppEvent)
        {
            return ((delegate* stdcall<IMFMediaSource*, uint, IMFMediaEvent**, int>)(lpVtbl[3]))((IMFMediaSource*)Unsafe.AsPointer(ref this), dwFlags, ppEvent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BeginGetEvent([NativeTypeName("IMFAsyncCallback *")] IMFAsyncCallback* pCallback, [NativeTypeName("IUnknown *")] IUnknown* punkState)
        {
            return ((delegate* stdcall<IMFMediaSource*, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[4]))((IMFMediaSource*)Unsafe.AsPointer(ref this), pCallback, punkState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EndGetEvent([NativeTypeName("IMFAsyncResult *")] IMFAsyncResult* pResult, [NativeTypeName("IMFMediaEvent **")] IMFMediaEvent** ppEvent)
        {
            return ((delegate* stdcall<IMFMediaSource*, IMFAsyncResult*, IMFMediaEvent**, int>)(lpVtbl[5]))((IMFMediaSource*)Unsafe.AsPointer(ref this), pResult, ppEvent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueueEvent([NativeTypeName("MediaEventType")] uint met, [NativeTypeName("const GUID &")] Guid* guidExtendedType, [NativeTypeName("HRESULT")] int hrStatus, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvValue)
        {
            return ((delegate* stdcall<IMFMediaSource*, uint, Guid*, int, PROPVARIANT*, int>)(lpVtbl[6]))((IMFMediaSource*)Unsafe.AsPointer(ref this), met, guidExtendedType, hrStatus, pvValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCharacteristics([NativeTypeName("DWORD *")] uint* pdwCharacteristics)
        {
            return ((delegate* stdcall<IMFMediaSource*, uint*, int>)(lpVtbl[7]))((IMFMediaSource*)Unsafe.AsPointer(ref this), pdwCharacteristics);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreatePresentationDescriptor([NativeTypeName("IMFPresentationDescriptor **")] IMFPresentationDescriptor** ppPresentationDescriptor)
        {
            return ((delegate* stdcall<IMFMediaSource*, IMFPresentationDescriptor**, int>)(lpVtbl[8]))((IMFMediaSource*)Unsafe.AsPointer(ref this), ppPresentationDescriptor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Start([NativeTypeName("IMFPresentationDescriptor *")] IMFPresentationDescriptor* pPresentationDescriptor, [NativeTypeName("const GUID *")] Guid* pguidTimeFormat, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarStartPosition)
        {
            return ((delegate* stdcall<IMFMediaSource*, IMFPresentationDescriptor*, Guid*, PROPVARIANT*, int>)(lpVtbl[9]))((IMFMediaSource*)Unsafe.AsPointer(ref this), pPresentationDescriptor, pguidTimeFormat, pvarStartPosition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Stop()
        {
            return ((delegate* stdcall<IMFMediaSource*, int>)(lpVtbl[10]))((IMFMediaSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Pause()
        {
            return ((delegate* stdcall<IMFMediaSource*, int>)(lpVtbl[11]))((IMFMediaSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Shutdown()
        {
            return ((delegate* stdcall<IMFMediaSource*, int>)(lpVtbl[12]))((IMFMediaSource*)Unsafe.AsPointer(ref this));
        }
    }
}
