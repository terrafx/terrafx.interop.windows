// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5F20AA40-B57A-4F34-96AB-3576F377CC79")]
    [NativeTypeName("struct ITfContextOwnerCompositionSink : IUnknown")]
    public unsafe partial struct ITfContextOwnerCompositionSink
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfContextOwnerCompositionSink*, Guid*, void**, int>)(lpVtbl[0]))((ITfContextOwnerCompositionSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfContextOwnerCompositionSink*, uint>)(lpVtbl[1]))((ITfContextOwnerCompositionSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfContextOwnerCompositionSink*, uint>)(lpVtbl[2]))((ITfContextOwnerCompositionSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnStartComposition(ITfCompositionView* pComposition, [NativeTypeName("BOOL *")] int* pfOk)
        {
            return ((delegate* unmanaged<ITfContextOwnerCompositionSink*, ITfCompositionView*, int*, int>)(lpVtbl[3]))((ITfContextOwnerCompositionSink*)Unsafe.AsPointer(ref this), pComposition, pfOk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnUpdateComposition(ITfCompositionView* pComposition, ITfRange* pRangeNew)
        {
            return ((delegate* unmanaged<ITfContextOwnerCompositionSink*, ITfCompositionView*, ITfRange*, int>)(lpVtbl[4]))((ITfContextOwnerCompositionSink*)Unsafe.AsPointer(ref this), pComposition, pRangeNew);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnEndComposition(ITfCompositionView* pComposition)
        {
            return ((delegate* unmanaged<ITfContextOwnerCompositionSink*, ITfCompositionView*, int>)(lpVtbl[5]))((ITfContextOwnerCompositionSink*)Unsafe.AsPointer(ref this), pComposition);
        }
    }
}
