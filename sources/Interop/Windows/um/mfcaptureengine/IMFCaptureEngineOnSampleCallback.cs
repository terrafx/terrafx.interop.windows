// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfcaptureengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("52150B82-AB39-4467-980F-E48BF0822ECD")]
    [NativeTypeName("struct IMFCaptureEngineOnSampleCallback : IUnknown")]
    public unsafe partial struct IMFCaptureEngineOnSampleCallback
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFCaptureEngineOnSampleCallback*, Guid*, void**, int>)(lpVtbl[0]))((IMFCaptureEngineOnSampleCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFCaptureEngineOnSampleCallback*, uint>)(lpVtbl[1]))((IMFCaptureEngineOnSampleCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFCaptureEngineOnSampleCallback*, uint>)(lpVtbl[2]))((IMFCaptureEngineOnSampleCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnSample([NativeTypeName("IMFSample *")] IMFSample* pSample)
        {
            return ((delegate* unmanaged[Stdcall]<IMFCaptureEngineOnSampleCallback*, IMFSample*, int>)(lpVtbl[3]))((IMFCaptureEngineOnSampleCallback*)Unsafe.AsPointer(ref this), pSample);
        }
    }
}
