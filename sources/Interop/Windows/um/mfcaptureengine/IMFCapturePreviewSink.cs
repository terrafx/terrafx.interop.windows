// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfcaptureengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("77346CFD-5B49-4D73-ACE0-5B52A859F2E0")]
    public unsafe partial struct IMFCapturePreviewSink
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFCapturePreviewSink*, Guid*, void**, int>)(lpVtbl[0]))((IMFCapturePreviewSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFCapturePreviewSink*, uint>)(lpVtbl[1]))((IMFCapturePreviewSink*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFCapturePreviewSink*, uint>)(lpVtbl[2]))((IMFCapturePreviewSink*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetOutputMediaType([NativeTypeName("DWORD")] uint dwSinkStreamIndex, [NativeTypeName("IMFMediaType **")] IMFMediaType** ppMediaType)
        {
            return ((delegate* stdcall<IMFCapturePreviewSink*, uint, IMFMediaType**, int>)(lpVtbl[3]))((IMFCapturePreviewSink*)Unsafe.AsPointer(ref this), dwSinkStreamIndex, ppMediaType);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetService([NativeTypeName("DWORD")] uint dwSinkStreamIndex, [NativeTypeName("const GUID &")] Guid* rguidService, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("IUnknown **")] IUnknown** ppUnknown)
        {
            return ((delegate* stdcall<IMFCapturePreviewSink*, uint, Guid*, Guid*, IUnknown**, int>)(lpVtbl[4]))((IMFCapturePreviewSink*)Unsafe.AsPointer(ref this), dwSinkStreamIndex, rguidService, riid, ppUnknown);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddStream([NativeTypeName("DWORD")] uint dwSourceStreamIndex, [NativeTypeName("IMFMediaType *")] IMFMediaType* pMediaType, [NativeTypeName("IMFAttributes *")] IMFAttributes* pAttributes, [NativeTypeName("DWORD *")] uint* pdwSinkStreamIndex)
        {
            return ((delegate* stdcall<IMFCapturePreviewSink*, uint, IMFMediaType*, IMFAttributes*, uint*, int>)(lpVtbl[5]))((IMFCapturePreviewSink*)Unsafe.AsPointer(ref this), dwSourceStreamIndex, pMediaType, pAttributes, pdwSinkStreamIndex);
        }

        [return: NativeTypeName("HRESULT")]
        public int Prepare()
        {
            return ((delegate* stdcall<IMFCapturePreviewSink*, int>)(lpVtbl[6]))((IMFCapturePreviewSink*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveAllStreams()
        {
            return ((delegate* stdcall<IMFCapturePreviewSink*, int>)(lpVtbl[7]))((IMFCapturePreviewSink*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRenderHandle([NativeTypeName("HANDLE")] IntPtr handle)
        {
            return ((delegate* stdcall<IMFCapturePreviewSink*, IntPtr, int>)(lpVtbl[8]))((IMFCapturePreviewSink*)Unsafe.AsPointer(ref this), handle);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRenderSurface([NativeTypeName("IUnknown *")] IUnknown* pSurface)
        {
            return ((delegate* stdcall<IMFCapturePreviewSink*, IUnknown*, int>)(lpVtbl[9]))((IMFCapturePreviewSink*)Unsafe.AsPointer(ref this), pSurface);
        }

        [return: NativeTypeName("HRESULT")]
        public int UpdateVideo([NativeTypeName("const MFVideoNormalizedRect *")] MFVideoNormalizedRect* pSrc, [NativeTypeName("const RECT *")] RECT* pDst, [NativeTypeName("const COLORREF *")] uint* pBorderClr)
        {
            return ((delegate* stdcall<IMFCapturePreviewSink*, MFVideoNormalizedRect*, RECT*, uint*, int>)(lpVtbl[10]))((IMFCapturePreviewSink*)Unsafe.AsPointer(ref this), pSrc, pDst, pBorderClr);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSampleCallback([NativeTypeName("DWORD")] uint dwStreamSinkIndex, [NativeTypeName("IMFCaptureEngineOnSampleCallback *")] IMFCaptureEngineOnSampleCallback* pCallback)
        {
            return ((delegate* stdcall<IMFCapturePreviewSink*, uint, IMFCaptureEngineOnSampleCallback*, int>)(lpVtbl[11]))((IMFCapturePreviewSink*)Unsafe.AsPointer(ref this), dwStreamSinkIndex, pCallback);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMirrorState([NativeTypeName("BOOL *")] int* pfMirrorState)
        {
            return ((delegate* stdcall<IMFCapturePreviewSink*, int*, int>)(lpVtbl[12]))((IMFCapturePreviewSink*)Unsafe.AsPointer(ref this), pfMirrorState);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMirrorState([NativeTypeName("BOOL")] int fMirrorState)
        {
            return ((delegate* stdcall<IMFCapturePreviewSink*, int, int>)(lpVtbl[13]))((IMFCapturePreviewSink*)Unsafe.AsPointer(ref this), fMirrorState);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRotation([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("DWORD *")] uint* pdwRotationValue)
        {
            return ((delegate* stdcall<IMFCapturePreviewSink*, uint, uint*, int>)(lpVtbl[14]))((IMFCapturePreviewSink*)Unsafe.AsPointer(ref this), dwStreamIndex, pdwRotationValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRotation([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("DWORD")] uint dwRotationValue)
        {
            return ((delegate* stdcall<IMFCapturePreviewSink*, uint, uint, int>)(lpVtbl[15]))((IMFCapturePreviewSink*)Unsafe.AsPointer(ref this), dwStreamIndex, dwRotationValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCustomSink([NativeTypeName("IMFMediaSink *")] IMFMediaSink* pMediaSink)
        {
            return ((delegate* stdcall<IMFCapturePreviewSink*, IMFMediaSink*, int>)(lpVtbl[16]))((IMFCapturePreviewSink*)Unsafe.AsPointer(ref this), pMediaSink);
        }
    }
}
