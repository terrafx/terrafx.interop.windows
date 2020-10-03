// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfcaptureengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AEDA51C0-9025-4983-9012-DE597B88B089")]
    [NativeTypeName("struct IMFCaptureEngineOnEventCallback : IUnknown")]
    public unsafe partial struct IMFCaptureEngineOnEventCallback
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IMFCaptureEngineOnEventCallback*, Guid*, void**, int>)(lpVtbl[0]))((IMFCaptureEngineOnEventCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFCaptureEngineOnEventCallback*, uint>)(lpVtbl[1]))((IMFCaptureEngineOnEventCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFCaptureEngineOnEventCallback*, uint>)(lpVtbl[2]))((IMFCaptureEngineOnEventCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnEvent([NativeTypeName("IMFMediaEvent *")] IMFMediaEvent* pEvent)
        {
            return ((delegate* unmanaged<IMFCaptureEngineOnEventCallback*, IMFMediaEvent*, int>)(lpVtbl[3]))((IMFCaptureEngineOnEventCallback*)Unsafe.AsPointer(ref this), pEvent);
        }
    }
}
