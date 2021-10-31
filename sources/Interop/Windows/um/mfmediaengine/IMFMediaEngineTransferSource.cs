// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("24230452-FE54-40CC-94F3-FCC394C340D6")]
    [NativeTypeName("struct IMFMediaEngineTransferSource : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFMediaEngineTransferSource
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFMediaEngineTransferSource*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaEngineTransferSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFMediaEngineTransferSource*, uint>)(lpVtbl[1]))((IMFMediaEngineTransferSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFMediaEngineTransferSource*, uint>)(lpVtbl[2]))((IMFMediaEngineTransferSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT TransferSourceToMediaEngine(IMFMediaEngine* destination)
        {
            return ((delegate* unmanaged<IMFMediaEngineTransferSource*, IMFMediaEngine*, int>)(lpVtbl[3]))((IMFMediaEngineTransferSource*)Unsafe.AsPointer(ref this), destination);
        }
    }
}
