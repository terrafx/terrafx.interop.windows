// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfcaptureengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3323B55A-F92A-4FE2-8EDC-E9BFC0634D77")]
    [NativeTypeName("struct IMFCaptureRecordSink : IMFCaptureSink")]
    public unsafe partial struct IMFCaptureRecordSink
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFCaptureRecordSink*, Guid*, void**, int>)(lpVtbl[0]))((IMFCaptureRecordSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFCaptureRecordSink*, uint>)(lpVtbl[1]))((IMFCaptureRecordSink*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFCaptureRecordSink*, uint>)(lpVtbl[2]))((IMFCaptureRecordSink*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetOutputMediaType([NativeTypeName("DWORD")] uint dwSinkStreamIndex, [NativeTypeName("IMFMediaType **")] IMFMediaType** ppMediaType)
        {
            return ((delegate* stdcall<IMFCaptureRecordSink*, uint, IMFMediaType**, int>)(lpVtbl[3]))((IMFCaptureRecordSink*)Unsafe.AsPointer(ref this), dwSinkStreamIndex, ppMediaType);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetService([NativeTypeName("DWORD")] uint dwSinkStreamIndex, [NativeTypeName("const GUID &")] Guid* rguidService, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("IUnknown **")] IUnknown** ppUnknown)
        {
            return ((delegate* stdcall<IMFCaptureRecordSink*, uint, Guid*, Guid*, IUnknown**, int>)(lpVtbl[4]))((IMFCaptureRecordSink*)Unsafe.AsPointer(ref this), dwSinkStreamIndex, rguidService, riid, ppUnknown);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddStream([NativeTypeName("DWORD")] uint dwSourceStreamIndex, [NativeTypeName("IMFMediaType *")] IMFMediaType* pMediaType, [NativeTypeName("IMFAttributes *")] IMFAttributes* pAttributes, [NativeTypeName("DWORD *")] uint* pdwSinkStreamIndex)
        {
            return ((delegate* stdcall<IMFCaptureRecordSink*, uint, IMFMediaType*, IMFAttributes*, uint*, int>)(lpVtbl[5]))((IMFCaptureRecordSink*)Unsafe.AsPointer(ref this), dwSourceStreamIndex, pMediaType, pAttributes, pdwSinkStreamIndex);
        }

        [return: NativeTypeName("HRESULT")]
        public int Prepare()
        {
            return ((delegate* stdcall<IMFCaptureRecordSink*, int>)(lpVtbl[6]))((IMFCaptureRecordSink*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveAllStreams()
        {
            return ((delegate* stdcall<IMFCaptureRecordSink*, int>)(lpVtbl[7]))((IMFCaptureRecordSink*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOutputByteStream([NativeTypeName("IMFByteStream *")] IMFByteStream* pByteStream, [NativeTypeName("const GUID &")] Guid* guidContainerType)
        {
            return ((delegate* stdcall<IMFCaptureRecordSink*, IMFByteStream*, Guid*, int>)(lpVtbl[8]))((IMFCaptureRecordSink*)Unsafe.AsPointer(ref this), pByteStream, guidContainerType);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOutputFileName([NativeTypeName("LPCWSTR")] ushort* fileName)
        {
            return ((delegate* stdcall<IMFCaptureRecordSink*, ushort*, int>)(lpVtbl[9]))((IMFCaptureRecordSink*)Unsafe.AsPointer(ref this), fileName);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSampleCallback([NativeTypeName("DWORD")] uint dwStreamSinkIndex, [NativeTypeName("IMFCaptureEngineOnSampleCallback *")] IMFCaptureEngineOnSampleCallback* pCallback)
        {
            return ((delegate* stdcall<IMFCaptureRecordSink*, uint, IMFCaptureEngineOnSampleCallback*, int>)(lpVtbl[10]))((IMFCaptureRecordSink*)Unsafe.AsPointer(ref this), dwStreamSinkIndex, pCallback);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCustomSink([NativeTypeName("IMFMediaSink *")] IMFMediaSink* pMediaSink)
        {
            return ((delegate* stdcall<IMFCaptureRecordSink*, IMFMediaSink*, int>)(lpVtbl[11]))((IMFCaptureRecordSink*)Unsafe.AsPointer(ref this), pMediaSink);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRotation([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("DWORD *")] uint* pdwRotationValue)
        {
            return ((delegate* stdcall<IMFCaptureRecordSink*, uint, uint*, int>)(lpVtbl[12]))((IMFCaptureRecordSink*)Unsafe.AsPointer(ref this), dwStreamIndex, pdwRotationValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRotation([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("DWORD")] uint dwRotationValue)
        {
            return ((delegate* stdcall<IMFCaptureRecordSink*, uint, uint, int>)(lpVtbl[13]))((IMFCaptureRecordSink*)Unsafe.AsPointer(ref this), dwStreamIndex, dwRotationValue);
        }
    }
}
