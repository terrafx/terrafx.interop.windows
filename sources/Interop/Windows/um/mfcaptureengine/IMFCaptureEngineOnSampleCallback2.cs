// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfcaptureengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E37CEED7-340F-4514-9F4D-9C2AE026100B")]
    [NativeTypeName("struct IMFCaptureEngineOnSampleCallback2 : IMFCaptureEngineOnSampleCallback")]
    public unsafe partial struct IMFCaptureEngineOnSampleCallback2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IMFCaptureEngineOnSampleCallback2*, Guid*, void**, int>)(lpVtbl[0]))((IMFCaptureEngineOnSampleCallback2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFCaptureEngineOnSampleCallback2*, uint>)(lpVtbl[1]))((IMFCaptureEngineOnSampleCallback2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFCaptureEngineOnSampleCallback2*, uint>)(lpVtbl[2]))((IMFCaptureEngineOnSampleCallback2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnSample([NativeTypeName("IMFSample *")] IMFSample* pSample)
        {
            return ((delegate* unmanaged<IMFCaptureEngineOnSampleCallback2*, IMFSample*, int>)(lpVtbl[3]))((IMFCaptureEngineOnSampleCallback2*)Unsafe.AsPointer(ref this), pSample);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnSynchronizedEvent([NativeTypeName("IMFMediaEvent *")] IMFMediaEvent* pEvent)
        {
            return ((delegate* unmanaged<IMFCaptureEngineOnSampleCallback2*, IMFMediaEvent*, int>)(lpVtbl[4]))((IMFCaptureEngineOnSampleCallback2*)Unsafe.AsPointer(ref this), pEvent);
        }
    }
}
