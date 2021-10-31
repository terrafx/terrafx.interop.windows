// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("56A868A4-0AD4-11CE-B03A-0020AF0BA770")]
    [NativeTypeName("struct IEnumRegFilters : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IEnumRegFilters
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IEnumRegFilters*, Guid*, void**, int>)(lpVtbl[0]))((IEnumRegFilters*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEnumRegFilters*, uint>)(lpVtbl[1]))((IEnumRegFilters*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEnumRegFilters*, uint>)(lpVtbl[2]))((IEnumRegFilters*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Next([NativeTypeName("ULONG")] uint cFilters, REGFILTER** apRegFilter, [NativeTypeName("ULONG *")] uint* pcFetched)
        {
            return ((delegate* unmanaged<IEnumRegFilters*, uint, REGFILTER**, uint*, int>)(lpVtbl[3]))((IEnumRegFilters*)Unsafe.AsPointer(ref this), cFilters, apRegFilter, pcFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Skip([NativeTypeName("ULONG")] uint cFilters)
        {
            return ((delegate* unmanaged<IEnumRegFilters*, uint, int>)(lpVtbl[4]))((IEnumRegFilters*)Unsafe.AsPointer(ref this), cFilters);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Reset()
        {
            return ((delegate* unmanaged<IEnumRegFilters*, int>)(lpVtbl[5]))((IEnumRegFilters*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Clone(IEnumRegFilters** ppEnum)
        {
            return ((delegate* unmanaged<IEnumRegFilters*, IEnumRegFilters**, int>)(lpVtbl[6]))((IEnumRegFilters*)Unsafe.AsPointer(ref this), ppEnum);
        }
    }
}
