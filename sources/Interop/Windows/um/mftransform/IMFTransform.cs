// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mftransform.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BF94C121-5B05-4E6F-8000-BA598961414D")]
    [NativeTypeName("struct IMFTransform : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFTransform
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFTransform*, Guid*, void**, int>)(lpVtbl[0]))((IMFTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFTransform*, uint>)(lpVtbl[1]))((IMFTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFTransform*, uint>)(lpVtbl[2]))((IMFTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetStreamLimits([NativeTypeName("DWORD *")] uint* pdwInputMinimum, [NativeTypeName("DWORD *")] uint* pdwInputMaximum, [NativeTypeName("DWORD *")] uint* pdwOutputMinimum, [NativeTypeName("DWORD *")] uint* pdwOutputMaximum)
        {
            return ((delegate* unmanaged<IMFTransform*, uint*, uint*, uint*, uint*, int>)(lpVtbl[3]))((IMFTransform*)Unsafe.AsPointer(ref this), pdwInputMinimum, pdwInputMaximum, pdwOutputMinimum, pdwOutputMaximum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetStreamCount([NativeTypeName("DWORD *")] uint* pcInputStreams, [NativeTypeName("DWORD *")] uint* pcOutputStreams)
        {
            return ((delegate* unmanaged<IMFTransform*, uint*, uint*, int>)(lpVtbl[4]))((IMFTransform*)Unsafe.AsPointer(ref this), pcInputStreams, pcOutputStreams);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetStreamIDs([NativeTypeName("DWORD")] uint dwInputIDArraySize, [NativeTypeName("DWORD *")] uint* pdwInputIDs, [NativeTypeName("DWORD")] uint dwOutputIDArraySize, [NativeTypeName("DWORD *")] uint* pdwOutputIDs)
        {
            return ((delegate* unmanaged<IMFTransform*, uint, uint*, uint, uint*, int>)(lpVtbl[5]))((IMFTransform*)Unsafe.AsPointer(ref this), dwInputIDArraySize, pdwInputIDs, dwOutputIDArraySize, pdwOutputIDs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetInputStreamInfo([NativeTypeName("DWORD")] uint dwInputStreamID, MFT_INPUT_STREAM_INFO* pStreamInfo)
        {
            return ((delegate* unmanaged<IMFTransform*, uint, MFT_INPUT_STREAM_INFO*, int>)(lpVtbl[6]))((IMFTransform*)Unsafe.AsPointer(ref this), dwInputStreamID, pStreamInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetOutputStreamInfo([NativeTypeName("DWORD")] uint dwOutputStreamID, MFT_OUTPUT_STREAM_INFO* pStreamInfo)
        {
            return ((delegate* unmanaged<IMFTransform*, uint, MFT_OUTPUT_STREAM_INFO*, int>)(lpVtbl[7]))((IMFTransform*)Unsafe.AsPointer(ref this), dwOutputStreamID, pStreamInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetAttributes(IMFAttributes** pAttributes)
        {
            return ((delegate* unmanaged<IMFTransform*, IMFAttributes**, int>)(lpVtbl[8]))((IMFTransform*)Unsafe.AsPointer(ref this), pAttributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetInputStreamAttributes([NativeTypeName("DWORD")] uint dwInputStreamID, IMFAttributes** pAttributes)
        {
            return ((delegate* unmanaged<IMFTransform*, uint, IMFAttributes**, int>)(lpVtbl[9]))((IMFTransform*)Unsafe.AsPointer(ref this), dwInputStreamID, pAttributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetOutputStreamAttributes([NativeTypeName("DWORD")] uint dwOutputStreamID, IMFAttributes** pAttributes)
        {
            return ((delegate* unmanaged<IMFTransform*, uint, IMFAttributes**, int>)(lpVtbl[10]))((IMFTransform*)Unsafe.AsPointer(ref this), dwOutputStreamID, pAttributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT DeleteInputStream([NativeTypeName("DWORD")] uint dwStreamID)
        {
            return ((delegate* unmanaged<IMFTransform*, uint, int>)(lpVtbl[11]))((IMFTransform*)Unsafe.AsPointer(ref this), dwStreamID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT AddInputStreams([NativeTypeName("DWORD")] uint cStreams, [NativeTypeName("DWORD *")] uint* adwStreamIDs)
        {
            return ((delegate* unmanaged<IMFTransform*, uint, uint*, int>)(lpVtbl[12]))((IMFTransform*)Unsafe.AsPointer(ref this), cStreams, adwStreamIDs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetInputAvailableType([NativeTypeName("DWORD")] uint dwInputStreamID, [NativeTypeName("DWORD")] uint dwTypeIndex, IMFMediaType** ppType)
        {
            return ((delegate* unmanaged<IMFTransform*, uint, uint, IMFMediaType**, int>)(lpVtbl[13]))((IMFTransform*)Unsafe.AsPointer(ref this), dwInputStreamID, dwTypeIndex, ppType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT GetOutputAvailableType([NativeTypeName("DWORD")] uint dwOutputStreamID, [NativeTypeName("DWORD")] uint dwTypeIndex, IMFMediaType** ppType)
        {
            return ((delegate* unmanaged<IMFTransform*, uint, uint, IMFMediaType**, int>)(lpVtbl[14]))((IMFTransform*)Unsafe.AsPointer(ref this), dwOutputStreamID, dwTypeIndex, ppType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT SetInputType([NativeTypeName("DWORD")] uint dwInputStreamID, IMFMediaType* pType, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IMFTransform*, uint, IMFMediaType*, uint, int>)(lpVtbl[15]))((IMFTransform*)Unsafe.AsPointer(ref this), dwInputStreamID, pType, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT SetOutputType([NativeTypeName("DWORD")] uint dwOutputStreamID, IMFMediaType* pType, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IMFTransform*, uint, IMFMediaType*, uint, int>)(lpVtbl[16]))((IMFTransform*)Unsafe.AsPointer(ref this), dwOutputStreamID, pType, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT GetInputCurrentType([NativeTypeName("DWORD")] uint dwInputStreamID, IMFMediaType** ppType)
        {
            return ((delegate* unmanaged<IMFTransform*, uint, IMFMediaType**, int>)(lpVtbl[17]))((IMFTransform*)Unsafe.AsPointer(ref this), dwInputStreamID, ppType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT GetOutputCurrentType([NativeTypeName("DWORD")] uint dwOutputStreamID, IMFMediaType** ppType)
        {
            return ((delegate* unmanaged<IMFTransform*, uint, IMFMediaType**, int>)(lpVtbl[18]))((IMFTransform*)Unsafe.AsPointer(ref this), dwOutputStreamID, ppType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT GetInputStatus([NativeTypeName("DWORD")] uint dwInputStreamID, [NativeTypeName("DWORD *")] uint* pdwFlags)
        {
            return ((delegate* unmanaged<IMFTransform*, uint, uint*, int>)(lpVtbl[19]))((IMFTransform*)Unsafe.AsPointer(ref this), dwInputStreamID, pdwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT GetOutputStatus([NativeTypeName("DWORD *")] uint* pdwFlags)
        {
            return ((delegate* unmanaged<IMFTransform*, uint*, int>)(lpVtbl[20]))((IMFTransform*)Unsafe.AsPointer(ref this), pdwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT SetOutputBounds([NativeTypeName("LONGLONG")] long hnsLowerBound, [NativeTypeName("LONGLONG")] long hnsUpperBound)
        {
            return ((delegate* unmanaged<IMFTransform*, long, long, int>)(lpVtbl[21]))((IMFTransform*)Unsafe.AsPointer(ref this), hnsLowerBound, hnsUpperBound);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT ProcessEvent([NativeTypeName("DWORD")] uint dwInputStreamID, IMFMediaEvent* pEvent)
        {
            return ((delegate* unmanaged<IMFTransform*, uint, IMFMediaEvent*, int>)(lpVtbl[22]))((IMFTransform*)Unsafe.AsPointer(ref this), dwInputStreamID, pEvent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT ProcessMessage(MFT_MESSAGE_TYPE eMessage, [NativeTypeName("ULONG_PTR")] nuint ulParam)
        {
            return ((delegate* unmanaged<IMFTransform*, MFT_MESSAGE_TYPE, nuint, int>)(lpVtbl[23]))((IMFTransform*)Unsafe.AsPointer(ref this), eMessage, ulParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT ProcessInput([NativeTypeName("DWORD")] uint dwInputStreamID, IMFSample* pSample, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IMFTransform*, uint, IMFSample*, uint, int>)(lpVtbl[24]))((IMFTransform*)Unsafe.AsPointer(ref this), dwInputStreamID, pSample, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT ProcessOutput([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint cOutputBufferCount, MFT_OUTPUT_DATA_BUFFER* pOutputSamples, [NativeTypeName("DWORD *")] uint* pdwStatus)
        {
            return ((delegate* unmanaged<IMFTransform*, uint, uint, MFT_OUTPUT_DATA_BUFFER*, uint*, int>)(lpVtbl[25]))((IMFTransform*)Unsafe.AsPointer(ref this), dwFlags, cOutputBufferCount, pOutputSamples, pdwStatus);
        }
    }
}
