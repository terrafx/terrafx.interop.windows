// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A615096F-1C57-4813-8A15-55EE6E5A839C")]
    [NativeTypeName("struct ITfTransitoryExtensionSink : IUnknown")]
    public unsafe partial struct ITfTransitoryExtensionSink
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ITfTransitoryExtensionSink*, Guid*, void**, int>)(lpVtbl[0]))((ITfTransitoryExtensionSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfTransitoryExtensionSink*, uint>)(lpVtbl[1]))((ITfTransitoryExtensionSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfTransitoryExtensionSink*, uint>)(lpVtbl[2]))((ITfTransitoryExtensionSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnTransitoryExtensionUpdated([NativeTypeName("ITfContext *")] ITfContext* pic, [NativeTypeName("TfEditCookie")] uint ecReadOnly, [NativeTypeName("ITfRange *")] ITfRange* pResultRange, [NativeTypeName("ITfRange *")] ITfRange* pCompositionRange, [NativeTypeName("BOOL *")] int* pfDeleteResultRange)
        {
            return ((delegate* unmanaged<ITfTransitoryExtensionSink*, ITfContext*, uint, ITfRange*, ITfRange*, int*, int>)(lpVtbl[3]))((ITfTransitoryExtensionSink*)Unsafe.AsPointer(ref this), pic, ecReadOnly, pResultRange, pCompositionRange, pfDeleteResultRange);
        }
    }
}
