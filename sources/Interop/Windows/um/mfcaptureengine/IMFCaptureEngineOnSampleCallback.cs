// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfcaptureengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("52150B82-AB39-4467-980F-E48BF0822ECD")]
    [NativeTypeName("struct IMFCaptureEngineOnSampleCallback : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFCaptureEngineOnSampleCallback
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFCaptureEngineOnSampleCallback*, Guid*, void**, int>)(lpVtbl[0]))((IMFCaptureEngineOnSampleCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFCaptureEngineOnSampleCallback*, uint>)(lpVtbl[1]))((IMFCaptureEngineOnSampleCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFCaptureEngineOnSampleCallback*, uint>)(lpVtbl[2]))((IMFCaptureEngineOnSampleCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int OnSample(IMFSample* pSample)
        {
            return ((delegate* unmanaged<IMFCaptureEngineOnSampleCallback*, IMFSample*, int>)(lpVtbl[3]))((IMFCaptureEngineOnSampleCallback*)Unsafe.AsPointer(ref this), pSample);
        }
    }
}
