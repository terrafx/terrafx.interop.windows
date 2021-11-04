// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfcaptureengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3323B55A-F92A-4FE2-8EDC-E9BFC0634D77")]
    [NativeTypeName("struct IMFCaptureRecordSink : IMFCaptureSink")]
    [NativeInheritance("IMFCaptureSink")]
    public unsafe partial struct IMFCaptureRecordSink
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFCaptureRecordSink*, Guid*, void**, int>)(lpVtbl[0]))((IMFCaptureRecordSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFCaptureRecordSink*, uint>)(lpVtbl[1]))((IMFCaptureRecordSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFCaptureRecordSink*, uint>)(lpVtbl[2]))((IMFCaptureRecordSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetOutputMediaType([NativeTypeName("DWORD")] uint dwSinkStreamIndex, IMFMediaType** ppMediaType)
        {
            return ((delegate* unmanaged<IMFCaptureRecordSink*, uint, IMFMediaType**, int>)(lpVtbl[3]))((IMFCaptureRecordSink*)Unsafe.AsPointer(ref this), dwSinkStreamIndex, ppMediaType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetService([NativeTypeName("DWORD")] uint dwSinkStreamIndex, [NativeTypeName("const GUID &")] Guid* rguidService, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppUnknown)
        {
            return ((delegate* unmanaged<IMFCaptureRecordSink*, uint, Guid*, Guid*, IUnknown**, int>)(lpVtbl[4]))((IMFCaptureRecordSink*)Unsafe.AsPointer(ref this), dwSinkStreamIndex, rguidService, riid, ppUnknown);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT AddStream([NativeTypeName("DWORD")] uint dwSourceStreamIndex, IMFMediaType* pMediaType, IMFAttributes* pAttributes, [NativeTypeName("DWORD *")] uint* pdwSinkStreamIndex)
        {
            return ((delegate* unmanaged<IMFCaptureRecordSink*, uint, IMFMediaType*, IMFAttributes*, uint*, int>)(lpVtbl[5]))((IMFCaptureRecordSink*)Unsafe.AsPointer(ref this), dwSourceStreamIndex, pMediaType, pAttributes, pdwSinkStreamIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Prepare()
        {
            return ((delegate* unmanaged<IMFCaptureRecordSink*, int>)(lpVtbl[6]))((IMFCaptureRecordSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT RemoveAllStreams()
        {
            return ((delegate* unmanaged<IMFCaptureRecordSink*, int>)(lpVtbl[7]))((IMFCaptureRecordSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT SetOutputByteStream(IMFByteStream* pByteStream, [NativeTypeName("const GUID &")] Guid* guidContainerType)
        {
            return ((delegate* unmanaged<IMFCaptureRecordSink*, IMFByteStream*, Guid*, int>)(lpVtbl[8]))((IMFCaptureRecordSink*)Unsafe.AsPointer(ref this), pByteStream, guidContainerType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT SetOutputFileName([NativeTypeName("LPCWSTR")] ushort* fileName)
        {
            return ((delegate* unmanaged<IMFCaptureRecordSink*, ushort*, int>)(lpVtbl[9]))((IMFCaptureRecordSink*)Unsafe.AsPointer(ref this), fileName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT SetSampleCallback([NativeTypeName("DWORD")] uint dwStreamSinkIndex, IMFCaptureEngineOnSampleCallback* pCallback)
        {
            return ((delegate* unmanaged<IMFCaptureRecordSink*, uint, IMFCaptureEngineOnSampleCallback*, int>)(lpVtbl[10]))((IMFCaptureRecordSink*)Unsafe.AsPointer(ref this), dwStreamSinkIndex, pCallback);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT SetCustomSink(IMFMediaSink* pMediaSink)
        {
            return ((delegate* unmanaged<IMFCaptureRecordSink*, IMFMediaSink*, int>)(lpVtbl[11]))((IMFCaptureRecordSink*)Unsafe.AsPointer(ref this), pMediaSink);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetRotation([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("DWORD *")] uint* pdwRotationValue)
        {
            return ((delegate* unmanaged<IMFCaptureRecordSink*, uint, uint*, int>)(lpVtbl[12]))((IMFCaptureRecordSink*)Unsafe.AsPointer(ref this), dwStreamIndex, pdwRotationValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT SetRotation([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("DWORD")] uint dwRotationValue)
        {
            return ((delegate* unmanaged<IMFCaptureRecordSink*, uint, uint, int>)(lpVtbl[13]))((IMFCaptureRecordSink*)Unsafe.AsPointer(ref this), dwStreamIndex, dwRotationValue);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFCaptureRecordSink*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFCaptureRecordSink*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFCaptureRecordSink*, uint> Release;

            [NativeTypeName("HRESULT (DWORD, IMFMediaType **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFCaptureRecordSink*, uint, IMFMediaType**, int> GetOutputMediaType;

            [NativeTypeName("HRESULT (DWORD, const GUID &, const IID &, IUnknown **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFCaptureRecordSink*, uint, Guid*, Guid*, IUnknown**, int> GetService;

            [NativeTypeName("HRESULT (DWORD, IMFMediaType *, IMFAttributes *, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFCaptureRecordSink*, uint, IMFMediaType*, IMFAttributes*, uint*, int> AddStream;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFCaptureRecordSink*, int> Prepare;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFCaptureRecordSink*, int> RemoveAllStreams;

            [NativeTypeName("HRESULT (IMFByteStream *, const GUID &) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFCaptureRecordSink*, IMFByteStream*, Guid*, int> SetOutputByteStream;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFCaptureRecordSink*, ushort*, int> SetOutputFileName;

            [NativeTypeName("HRESULT (DWORD, IMFCaptureEngineOnSampleCallback *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFCaptureRecordSink*, uint, IMFCaptureEngineOnSampleCallback*, int> SetSampleCallback;

            [NativeTypeName("HRESULT (IMFMediaSink *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFCaptureRecordSink*, IMFMediaSink*, int> SetCustomSink;

            [NativeTypeName("HRESULT (DWORD, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFCaptureRecordSink*, uint, uint*, int> GetRotation;

            [NativeTypeName("HRESULT (DWORD, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFCaptureRecordSink*, uint, uint, int> SetRotation;
        }
    }
}
