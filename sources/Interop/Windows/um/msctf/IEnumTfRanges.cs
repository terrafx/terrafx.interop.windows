// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F99D3F40-8E32-11D2-BF46-00105A2799B5")]
    [NativeTypeName("struct IEnumTfRanges : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IEnumTfRanges
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IEnumTfRanges*, Guid*, void**, int>)(lpVtbl[0]))((IEnumTfRanges*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEnumTfRanges*, uint>)(lpVtbl[1]))((IEnumTfRanges*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEnumTfRanges*, uint>)(lpVtbl[2]))((IEnumTfRanges*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Clone(IEnumTfRanges** ppEnum)
        {
            return ((delegate* unmanaged<IEnumTfRanges*, IEnumTfRanges**, int>)(lpVtbl[3]))((IEnumTfRanges*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint ulCount, ITfRange** ppRange, [NativeTypeName("ULONG *")] uint* pcFetched)
        {
            return ((delegate* unmanaged<IEnumTfRanges*, uint, ITfRange**, uint*, int>)(lpVtbl[4]))((IEnumTfRanges*)Unsafe.AsPointer(ref this), ulCount, ppRange, pcFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged<IEnumTfRanges*, int>)(lpVtbl[5]))((IEnumTfRanges*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint ulCount)
        {
            return ((delegate* unmanaged<IEnumTfRanges*, uint, int>)(lpVtbl[6]))((IEnumTfRanges*)Unsafe.AsPointer(ref this), ulCount);
        }
    }
}
