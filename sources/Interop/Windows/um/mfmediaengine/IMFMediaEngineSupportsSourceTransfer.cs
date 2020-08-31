// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A724B056-1B2E-4642-A6F3-DB9420C52908")]
    [NativeTypeName("struct IMFMediaEngineSupportsSourceTransfer : IUnknown")]
    public unsafe partial struct IMFMediaEngineSupportsSourceTransfer
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFMediaEngineSupportsSourceTransfer*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaEngineSupportsSourceTransfer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFMediaEngineSupportsSourceTransfer*, uint>)(lpVtbl[1]))((IMFMediaEngineSupportsSourceTransfer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFMediaEngineSupportsSourceTransfer*, uint>)(lpVtbl[2]))((IMFMediaEngineSupportsSourceTransfer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ShouldTransferSource([NativeTypeName("BOOL *")] int* pfShouldTransfer)
        {
            return ((delegate* stdcall<IMFMediaEngineSupportsSourceTransfer*, int*, int>)(lpVtbl[3]))((IMFMediaEngineSupportsSourceTransfer*)Unsafe.AsPointer(ref this), pfShouldTransfer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DetachMediaSource([NativeTypeName("IMFByteStream **")] IMFByteStream** ppByteStream, [NativeTypeName("IMFMediaSource **")] IMFMediaSource** ppMediaSource, [NativeTypeName("IMFMediaSourceExtension **")] IMFMediaSourceExtension** ppMSE)
        {
            return ((delegate* stdcall<IMFMediaEngineSupportsSourceTransfer*, IMFByteStream**, IMFMediaSource**, IMFMediaSourceExtension**, int>)(lpVtbl[4]))((IMFMediaEngineSupportsSourceTransfer*)Unsafe.AsPointer(ref this), ppByteStream, ppMediaSource, ppMSE);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AttachMediaSource([NativeTypeName("IMFByteStream *")] IMFByteStream* pByteStream, [NativeTypeName("IMFMediaSource *")] IMFMediaSource* pMediaSource, [NativeTypeName("IMFMediaSourceExtension *")] IMFMediaSourceExtension* pMSE)
        {
            return ((delegate* stdcall<IMFMediaEngineSupportsSourceTransfer*, IMFByteStream*, IMFMediaSource*, IMFMediaSourceExtension*, int>)(lpVtbl[5]))((IMFMediaEngineSupportsSourceTransfer*)Unsafe.AsPointer(ref this), pByteStream, pMediaSource, pMSE);
        }
    }
}
