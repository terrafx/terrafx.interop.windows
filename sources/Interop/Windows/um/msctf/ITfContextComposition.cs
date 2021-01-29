// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D40C8AAE-AC92-4FC7-9A11-0EE0E23AA39B")]
    [NativeTypeName("struct ITfContextComposition : IUnknown")]
    public unsafe partial struct ITfContextComposition
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ITfContextComposition*, Guid*, void**, int>)(lpVtbl[0]))((ITfContextComposition*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfContextComposition*, uint>)(lpVtbl[1]))((ITfContextComposition*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfContextComposition*, uint>)(lpVtbl[2]))((ITfContextComposition*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int StartComposition([NativeTypeName("TfEditCookie")] uint ecWrite, [NativeTypeName("ITfRange *")] ITfRange* pCompositionRange, [NativeTypeName("ITfCompositionSink *")] ITfCompositionSink* pSink, [NativeTypeName("ITfComposition **")] ITfComposition** ppComposition)
        {
            return ((delegate* unmanaged<ITfContextComposition*, uint, ITfRange*, ITfCompositionSink*, ITfComposition**, int>)(lpVtbl[3]))((ITfContextComposition*)Unsafe.AsPointer(ref this), ecWrite, pCompositionRange, pSink, ppComposition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumCompositions([NativeTypeName("IEnumITfCompositionView **")] IEnumITfCompositionView** ppEnum)
        {
            return ((delegate* unmanaged<ITfContextComposition*, IEnumITfCompositionView**, int>)(lpVtbl[4]))((ITfContextComposition*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FindComposition([NativeTypeName("TfEditCookie")] uint ecRead, [NativeTypeName("ITfRange *")] ITfRange* pTestRange, [NativeTypeName("IEnumITfCompositionView **")] IEnumITfCompositionView** ppEnum)
        {
            return ((delegate* unmanaged<ITfContextComposition*, uint, ITfRange*, IEnumITfCompositionView**, int>)(lpVtbl[5]))((ITfContextComposition*)Unsafe.AsPointer(ref this), ecRead, pTestRange, ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int TakeOwnership([NativeTypeName("TfEditCookie")] uint ecWrite, [NativeTypeName("ITfCompositionView *")] ITfCompositionView* pComposition, [NativeTypeName("ITfCompositionSink *")] ITfCompositionSink* pSink, [NativeTypeName("ITfComposition **")] ITfComposition** ppComposition)
        {
            return ((delegate* unmanaged<ITfContextComposition*, uint, ITfCompositionView*, ITfCompositionSink*, ITfComposition**, int>)(lpVtbl[6]))((ITfContextComposition*)Unsafe.AsPointer(ref this), ecWrite, pComposition, pSink, ppComposition);
        }
    }
}
