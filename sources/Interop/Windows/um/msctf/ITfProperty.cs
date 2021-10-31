// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E2449660-9542-11D2-BF46-00105A2799B5")]
    [NativeTypeName("struct ITfProperty : ITfReadOnlyProperty")]
    [NativeInheritance("ITfReadOnlyProperty")]
    public unsafe partial struct ITfProperty
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfProperty*, Guid*, void**, int>)(lpVtbl[0]))((ITfProperty*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfProperty*, uint>)(lpVtbl[1]))((ITfProperty*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfProperty*, uint>)(lpVtbl[2]))((ITfProperty*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetType([NativeTypeName("GUID *")] Guid* pguid)
        {
            return ((delegate* unmanaged<ITfProperty*, Guid*, int>)(lpVtbl[3]))((ITfProperty*)Unsafe.AsPointer(ref this), pguid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT EnumRanges([NativeTypeName("TfEditCookie")] uint ec, IEnumTfRanges** ppEnum, ITfRange* pTargetRange)
        {
            return ((delegate* unmanaged<ITfProperty*, uint, IEnumTfRanges**, ITfRange*, int>)(lpVtbl[4]))((ITfProperty*)Unsafe.AsPointer(ref this), ec, ppEnum, pTargetRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetValue([NativeTypeName("TfEditCookie")] uint ec, ITfRange* pRange, VARIANT* pvarValue)
        {
            return ((delegate* unmanaged<ITfProperty*, uint, ITfRange*, VARIANT*, int>)(lpVtbl[5]))((ITfProperty*)Unsafe.AsPointer(ref this), ec, pRange, pvarValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetContext(ITfContext** ppContext)
        {
            return ((delegate* unmanaged<ITfProperty*, ITfContext**, int>)(lpVtbl[6]))((ITfProperty*)Unsafe.AsPointer(ref this), ppContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT FindRange([NativeTypeName("TfEditCookie")] uint ec, ITfRange* pRange, ITfRange** ppRange, TfAnchor aPos)
        {
            return ((delegate* unmanaged<ITfProperty*, uint, ITfRange*, ITfRange**, TfAnchor, int>)(lpVtbl[7]))((ITfProperty*)Unsafe.AsPointer(ref this), ec, pRange, ppRange, aPos);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT SetValueStore([NativeTypeName("TfEditCookie")] uint ec, ITfRange* pRange, ITfPropertyStore* pPropStore)
        {
            return ((delegate* unmanaged<ITfProperty*, uint, ITfRange*, ITfPropertyStore*, int>)(lpVtbl[8]))((ITfProperty*)Unsafe.AsPointer(ref this), ec, pRange, pPropStore);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT SetValue([NativeTypeName("TfEditCookie")] uint ec, ITfRange* pRange, [NativeTypeName("const VARIANT *")] VARIANT* pvarValue)
        {
            return ((delegate* unmanaged<ITfProperty*, uint, ITfRange*, VARIANT*, int>)(lpVtbl[9]))((ITfProperty*)Unsafe.AsPointer(ref this), ec, pRange, pvarValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT Clear([NativeTypeName("TfEditCookie")] uint ec, ITfRange* pRange)
        {
            return ((delegate* unmanaged<ITfProperty*, uint, ITfRange*, int>)(lpVtbl[10]))((ITfProperty*)Unsafe.AsPointer(ref this), ec, pRange);
        }
    }
}
