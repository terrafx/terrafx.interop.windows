// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("56A86893-0AD4-11CE-B03A-0020AF0BA770")]
    [NativeTypeName("struct IEnumFilters : IUnknown")]
    public unsafe partial struct IEnumFilters
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IEnumFilters*, Guid*, void**, int>)(lpVtbl[0]))((IEnumFilters*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEnumFilters*, uint>)(lpVtbl[1]))((IEnumFilters*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEnumFilters*, uint>)(lpVtbl[2]))((IEnumFilters*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint cFilters, IBaseFilter** ppFilter, [NativeTypeName("ULONG *")] uint* pcFetched)
        {
            return ((delegate* unmanaged<IEnumFilters*, uint, IBaseFilter**, uint*, int>)(lpVtbl[3]))((IEnumFilters*)Unsafe.AsPointer(ref this), cFilters, ppFilter, pcFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint cFilters)
        {
            return ((delegate* unmanaged<IEnumFilters*, uint, int>)(lpVtbl[4]))((IEnumFilters*)Unsafe.AsPointer(ref this), cFilters);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged<IEnumFilters*, int>)(lpVtbl[5]))((IEnumFilters*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Clone(IEnumFilters** ppEnum)
        {
            return ((delegate* unmanaged<IEnumFilters*, IEnumFilters**, int>)(lpVtbl[6]))((IEnumFilters*)Unsafe.AsPointer(ref this), ppEnum);
        }
    }
}
