// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfcaptureengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A6BBA433-176B-48B2-B375-53AA03473207")]
    [NativeTypeName("struct IMFCaptureEngine : IUnknown")]
    public unsafe partial struct IMFCaptureEngine
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFCaptureEngine*, Guid*, void**, int>)(lpVtbl[0]))((IMFCaptureEngine*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFCaptureEngine*, uint>)(lpVtbl[1]))((IMFCaptureEngine*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFCaptureEngine*, uint>)(lpVtbl[2]))((IMFCaptureEngine*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Initialize(IMFCaptureEngineOnEventCallback* pEventCallback, IMFAttributes* pAttributes, IUnknown* pAudioSource, IUnknown* pVideoSource)
        {
            return ((delegate* unmanaged<IMFCaptureEngine*, IMFCaptureEngineOnEventCallback*, IMFAttributes*, IUnknown*, IUnknown*, int>)(lpVtbl[3]))((IMFCaptureEngine*)Unsafe.AsPointer(ref this), pEventCallback, pAttributes, pAudioSource, pVideoSource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int StartPreview()
        {
            return ((delegate* unmanaged<IMFCaptureEngine*, int>)(lpVtbl[4]))((IMFCaptureEngine*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int StopPreview()
        {
            return ((delegate* unmanaged<IMFCaptureEngine*, int>)(lpVtbl[5]))((IMFCaptureEngine*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int StartRecord()
        {
            return ((delegate* unmanaged<IMFCaptureEngine*, int>)(lpVtbl[6]))((IMFCaptureEngine*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int StopRecord([NativeTypeName("BOOL")] int bFinalize, [NativeTypeName("BOOL")] int bFlushUnprocessedSamples)
        {
            return ((delegate* unmanaged<IMFCaptureEngine*, int, int, int>)(lpVtbl[7]))((IMFCaptureEngine*)Unsafe.AsPointer(ref this), bFinalize, bFlushUnprocessedSamples);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int TakePhoto()
        {
            return ((delegate* unmanaged<IMFCaptureEngine*, int>)(lpVtbl[8]))((IMFCaptureEngine*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSink(MF_CAPTURE_ENGINE_SINK_TYPE mfCaptureEngineSinkType, IMFCaptureSink** ppSink)
        {
            return ((delegate* unmanaged<IMFCaptureEngine*, MF_CAPTURE_ENGINE_SINK_TYPE, IMFCaptureSink**, int>)(lpVtbl[9]))((IMFCaptureEngine*)Unsafe.AsPointer(ref this), mfCaptureEngineSinkType, ppSink);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSource(IMFCaptureSource** ppSource)
        {
            return ((delegate* unmanaged<IMFCaptureEngine*, IMFCaptureSource**, int>)(lpVtbl[10]))((IMFCaptureEngine*)Unsafe.AsPointer(ref this), ppSource);
        }
    }
}
