// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0A97B3CF-8E7C-4A3D-8F8C-0C843DC247FB")]
    [NativeTypeName("struct IMFStreamSink : IMFMediaEventGenerator")]
    public unsafe partial struct IMFStreamSink
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFStreamSink*, Guid*, void**, int>)(lpVtbl[0]))((IMFStreamSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFStreamSink*, uint>)(lpVtbl[1]))((IMFStreamSink*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFStreamSink*, uint>)(lpVtbl[2]))((IMFStreamSink*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEvent([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("IMFMediaEvent **")] IMFMediaEvent** ppEvent)
        {
            return ((delegate* stdcall<IMFStreamSink*, uint, IMFMediaEvent**, int>)(lpVtbl[3]))((IMFStreamSink*)Unsafe.AsPointer(ref this), dwFlags, ppEvent);
        }

        [return: NativeTypeName("HRESULT")]
        public int BeginGetEvent([NativeTypeName("IMFAsyncCallback *")] IMFAsyncCallback* pCallback, [NativeTypeName("IUnknown *")] IUnknown* punkState)
        {
            return ((delegate* stdcall<IMFStreamSink*, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[4]))((IMFStreamSink*)Unsafe.AsPointer(ref this), pCallback, punkState);
        }

        [return: NativeTypeName("HRESULT")]
        public int EndGetEvent([NativeTypeName("IMFAsyncResult *")] IMFAsyncResult* pResult, [NativeTypeName("IMFMediaEvent **")] IMFMediaEvent** ppEvent)
        {
            return ((delegate* stdcall<IMFStreamSink*, IMFAsyncResult*, IMFMediaEvent**, int>)(lpVtbl[5]))((IMFStreamSink*)Unsafe.AsPointer(ref this), pResult, ppEvent);
        }

        [return: NativeTypeName("HRESULT")]
        public int QueueEvent([NativeTypeName("MediaEventType")] uint met, [NativeTypeName("const GUID &")] Guid* guidExtendedType, [NativeTypeName("HRESULT")] int hrStatus, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvValue)
        {
            return ((delegate* stdcall<IMFStreamSink*, uint, Guid*, int, PROPVARIANT*, int>)(lpVtbl[6]))((IMFStreamSink*)Unsafe.AsPointer(ref this), met, guidExtendedType, hrStatus, pvValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMediaSink([NativeTypeName("IMFMediaSink **")] IMFMediaSink** ppMediaSink)
        {
            return ((delegate* stdcall<IMFStreamSink*, IMFMediaSink**, int>)(lpVtbl[7]))((IMFStreamSink*)Unsafe.AsPointer(ref this), ppMediaSink);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIdentifier([NativeTypeName("DWORD *")] uint* pdwIdentifier)
        {
            return ((delegate* stdcall<IMFStreamSink*, uint*, int>)(lpVtbl[8]))((IMFStreamSink*)Unsafe.AsPointer(ref this), pdwIdentifier);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMediaTypeHandler([NativeTypeName("IMFMediaTypeHandler **")] IMFMediaTypeHandler** ppHandler)
        {
            return ((delegate* stdcall<IMFStreamSink*, IMFMediaTypeHandler**, int>)(lpVtbl[9]))((IMFStreamSink*)Unsafe.AsPointer(ref this), ppHandler);
        }

        [return: NativeTypeName("HRESULT")]
        public int ProcessSample([NativeTypeName("IMFSample *")] IMFSample* pSample)
        {
            return ((delegate* stdcall<IMFStreamSink*, IMFSample*, int>)(lpVtbl[10]))((IMFStreamSink*)Unsafe.AsPointer(ref this), pSample);
        }

        [return: NativeTypeName("HRESULT")]
        public int PlaceMarker(MFSTREAMSINK_MARKER_TYPE eMarkerType, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarMarkerValue, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarContextValue)
        {
            return ((delegate* stdcall<IMFStreamSink*, MFSTREAMSINK_MARKER_TYPE, PROPVARIANT*, PROPVARIANT*, int>)(lpVtbl[11]))((IMFStreamSink*)Unsafe.AsPointer(ref this), eMarkerType, pvarMarkerValue, pvarContextValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int Flush()
        {
            return ((delegate* stdcall<IMFStreamSink*, int>)(lpVtbl[12]))((IMFStreamSink*)Unsafe.AsPointer(ref this));
        }
    }
}
