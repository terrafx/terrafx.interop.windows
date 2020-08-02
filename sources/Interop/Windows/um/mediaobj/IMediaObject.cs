// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mediaobj.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D8AD0F58-5494-4102-97C5-EC798E59BCF4")]
    public unsafe partial struct IMediaObject
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMediaObject*, Guid*, void**, int>)(lpVtbl[0]))((IMediaObject*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMediaObject*, uint>)(lpVtbl[1]))((IMediaObject*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMediaObject*, uint>)(lpVtbl[2]))((IMediaObject*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStreamCount([NativeTypeName("DWORD *")] uint* pcInputStreams, [NativeTypeName("DWORD *")] uint* pcOutputStreams)
        {
            return ((delegate* stdcall<IMediaObject*, uint*, uint*, int>)(lpVtbl[3]))((IMediaObject*)Unsafe.AsPointer(ref this), pcInputStreams, pcOutputStreams);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetInputStreamInfo([NativeTypeName("DWORD")] uint dwInputStreamIndex, [NativeTypeName("DWORD *")] uint* pdwFlags)
        {
            return ((delegate* stdcall<IMediaObject*, uint, uint*, int>)(lpVtbl[4]))((IMediaObject*)Unsafe.AsPointer(ref this), dwInputStreamIndex, pdwFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetOutputStreamInfo([NativeTypeName("DWORD")] uint dwOutputStreamIndex, [NativeTypeName("DWORD *")] uint* pdwFlags)
        {
            return ((delegate* stdcall<IMediaObject*, uint, uint*, int>)(lpVtbl[5]))((IMediaObject*)Unsafe.AsPointer(ref this), dwOutputStreamIndex, pdwFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetInputType([NativeTypeName("DWORD")] uint dwInputStreamIndex, [NativeTypeName("DWORD")] uint dwTypeIndex, [NativeTypeName("DMO_MEDIA_TYPE *")] DMO_MEDIA_TYPE* pmt)
        {
            return ((delegate* stdcall<IMediaObject*, uint, uint, DMO_MEDIA_TYPE*, int>)(lpVtbl[6]))((IMediaObject*)Unsafe.AsPointer(ref this), dwInputStreamIndex, dwTypeIndex, pmt);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetOutputType([NativeTypeName("DWORD")] uint dwOutputStreamIndex, [NativeTypeName("DWORD")] uint dwTypeIndex, [NativeTypeName("DMO_MEDIA_TYPE *")] DMO_MEDIA_TYPE* pmt)
        {
            return ((delegate* stdcall<IMediaObject*, uint, uint, DMO_MEDIA_TYPE*, int>)(lpVtbl[7]))((IMediaObject*)Unsafe.AsPointer(ref this), dwOutputStreamIndex, dwTypeIndex, pmt);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetInputType([NativeTypeName("DWORD")] uint dwInputStreamIndex, [NativeTypeName("const DMO_MEDIA_TYPE *")] DMO_MEDIA_TYPE* pmt, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* stdcall<IMediaObject*, uint, DMO_MEDIA_TYPE*, uint, int>)(lpVtbl[8]))((IMediaObject*)Unsafe.AsPointer(ref this), dwInputStreamIndex, pmt, dwFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOutputType([NativeTypeName("DWORD")] uint dwOutputStreamIndex, [NativeTypeName("const DMO_MEDIA_TYPE *")] DMO_MEDIA_TYPE* pmt, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* stdcall<IMediaObject*, uint, DMO_MEDIA_TYPE*, uint, int>)(lpVtbl[9]))((IMediaObject*)Unsafe.AsPointer(ref this), dwOutputStreamIndex, pmt, dwFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetInputCurrentType([NativeTypeName("DWORD")] uint dwInputStreamIndex, [NativeTypeName("DMO_MEDIA_TYPE *")] DMO_MEDIA_TYPE* pmt)
        {
            return ((delegate* stdcall<IMediaObject*, uint, DMO_MEDIA_TYPE*, int>)(lpVtbl[10]))((IMediaObject*)Unsafe.AsPointer(ref this), dwInputStreamIndex, pmt);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetOutputCurrentType([NativeTypeName("DWORD")] uint dwOutputStreamIndex, [NativeTypeName("DMO_MEDIA_TYPE *")] DMO_MEDIA_TYPE* pmt)
        {
            return ((delegate* stdcall<IMediaObject*, uint, DMO_MEDIA_TYPE*, int>)(lpVtbl[11]))((IMediaObject*)Unsafe.AsPointer(ref this), dwOutputStreamIndex, pmt);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetInputSizeInfo([NativeTypeName("DWORD")] uint dwInputStreamIndex, [NativeTypeName("DWORD *")] uint* pcbSize, [NativeTypeName("DWORD *")] uint* pcbMaxLookahead, [NativeTypeName("DWORD *")] uint* pcbAlignment)
        {
            return ((delegate* stdcall<IMediaObject*, uint, uint*, uint*, uint*, int>)(lpVtbl[12]))((IMediaObject*)Unsafe.AsPointer(ref this), dwInputStreamIndex, pcbSize, pcbMaxLookahead, pcbAlignment);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetOutputSizeInfo([NativeTypeName("DWORD")] uint dwOutputStreamIndex, [NativeTypeName("DWORD *")] uint* pcbSize, [NativeTypeName("DWORD *")] uint* pcbAlignment)
        {
            return ((delegate* stdcall<IMediaObject*, uint, uint*, uint*, int>)(lpVtbl[13]))((IMediaObject*)Unsafe.AsPointer(ref this), dwOutputStreamIndex, pcbSize, pcbAlignment);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetInputMaxLatency([NativeTypeName("DWORD")] uint dwInputStreamIndex, [NativeTypeName("REFERENCE_TIME *")] long* prtMaxLatency)
        {
            return ((delegate* stdcall<IMediaObject*, uint, long*, int>)(lpVtbl[14]))((IMediaObject*)Unsafe.AsPointer(ref this), dwInputStreamIndex, prtMaxLatency);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetInputMaxLatency([NativeTypeName("DWORD")] uint dwInputStreamIndex, [NativeTypeName("REFERENCE_TIME")] long rtMaxLatency)
        {
            return ((delegate* stdcall<IMediaObject*, uint, long, int>)(lpVtbl[15]))((IMediaObject*)Unsafe.AsPointer(ref this), dwInputStreamIndex, rtMaxLatency);
        }

        [return: NativeTypeName("HRESULT")]
        public int Flush()
        {
            return ((delegate* stdcall<IMediaObject*, int>)(lpVtbl[16]))((IMediaObject*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Discontinuity([NativeTypeName("DWORD")] uint dwInputStreamIndex)
        {
            return ((delegate* stdcall<IMediaObject*, uint, int>)(lpVtbl[17]))((IMediaObject*)Unsafe.AsPointer(ref this), dwInputStreamIndex);
        }

        [return: NativeTypeName("HRESULT")]
        public int AllocateStreamingResources()
        {
            return ((delegate* stdcall<IMediaObject*, int>)(lpVtbl[18]))((IMediaObject*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int FreeStreamingResources()
        {
            return ((delegate* stdcall<IMediaObject*, int>)(lpVtbl[19]))((IMediaObject*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetInputStatus([NativeTypeName("DWORD")] uint dwInputStreamIndex, [NativeTypeName("DWORD *")] uint* dwFlags)
        {
            return ((delegate* stdcall<IMediaObject*, uint, uint*, int>)(lpVtbl[20]))((IMediaObject*)Unsafe.AsPointer(ref this), dwInputStreamIndex, dwFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int ProcessInput([NativeTypeName("DWORD")] uint dwInputStreamIndex, [NativeTypeName("IMediaBuffer *")] IMediaBuffer* pBuffer, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("REFERENCE_TIME")] long rtTimestamp, [NativeTypeName("REFERENCE_TIME")] long rtTimelength)
        {
            return ((delegate* stdcall<IMediaObject*, uint, IMediaBuffer*, uint, long, long, int>)(lpVtbl[21]))((IMediaObject*)Unsafe.AsPointer(ref this), dwInputStreamIndex, pBuffer, dwFlags, rtTimestamp, rtTimelength);
        }

        [return: NativeTypeName("HRESULT")]
        public int ProcessOutput([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint cOutputBufferCount, [NativeTypeName("DMO_OUTPUT_DATA_BUFFER *")] DMO_OUTPUT_DATA_BUFFER* pOutputBuffers, [NativeTypeName("DWORD *")] uint* pdwStatus)
        {
            return ((delegate* stdcall<IMediaObject*, uint, uint, DMO_OUTPUT_DATA_BUFFER*, uint*, int>)(lpVtbl[22]))((IMediaObject*)Unsafe.AsPointer(ref this), dwFlags, cOutputBufferCount, pOutputBuffers, pdwStatus);
        }

        [return: NativeTypeName("HRESULT")]
        public int Lock([NativeTypeName("LONG")] int bLock)
        {
            return ((delegate* stdcall<IMediaObject*, int, int>)(lpVtbl[23]))((IMediaObject*)Unsafe.AsPointer(ref this), bLock);
        }
    }
}
