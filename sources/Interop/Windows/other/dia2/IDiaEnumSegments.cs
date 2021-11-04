// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E8368CA9-01D1-419D-AC0C-E31235DBDA9F")]
    [NativeTypeName("struct IDiaEnumSegments : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDiaEnumSegments : IDiaEnumSegments.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDiaEnumSegments*, Guid*, void**, int>)(lpVtbl[0]))((IDiaEnumSegments*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDiaEnumSegments*, uint>)(lpVtbl[1]))((IDiaEnumSegments*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDiaEnumSegments*, uint>)(lpVtbl[2]))((IDiaEnumSegments*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT get__NewEnum(IUnknown** pRetVal)
        {
            return ((delegate* unmanaged<IDiaEnumSegments*, IUnknown**, int>)(lpVtbl[3]))((IDiaEnumSegments*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT get_Count([NativeTypeName("LONG *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaEnumSegments*, int*, int>)(lpVtbl[4]))((IDiaEnumSegments*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Item([NativeTypeName("DWORD")] uint index, IDiaSegment** segment)
        {
            return ((delegate* unmanaged<IDiaEnumSegments*, uint, IDiaSegment**, int>)(lpVtbl[5]))((IDiaEnumSegments*)Unsafe.AsPointer(ref this), index, segment);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Next([NativeTypeName("ULONG")] uint celt, IDiaSegment** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
        {
            return ((delegate* unmanaged<IDiaEnumSegments*, uint, IDiaSegment**, uint*, int>)(lpVtbl[6]))((IDiaEnumSegments*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT Skip([NativeTypeName("ULONG")] uint celt)
        {
            return ((delegate* unmanaged<IDiaEnumSegments*, uint, int>)(lpVtbl[7]))((IDiaEnumSegments*)Unsafe.AsPointer(ref this), celt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT Reset()
        {
            return ((delegate* unmanaged<IDiaEnumSegments*, int>)(lpVtbl[8]))((IDiaEnumSegments*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT Clone(IDiaEnumSegments** ppenum)
        {
            return ((delegate* unmanaged<IDiaEnumSegments*, IDiaEnumSegments**, int>)(lpVtbl[9]))((IDiaEnumSegments*)Unsafe.AsPointer(ref this), ppenum);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT get__NewEnum(IUnknown** pRetVal);

            [VtblIndex(4)]
            HRESULT get_Count([NativeTypeName("LONG *")] int* pRetVal);

            [VtblIndex(5)]
            HRESULT Item([NativeTypeName("DWORD")] uint index, IDiaSegment** segment);

            [VtblIndex(6)]
            HRESULT Next([NativeTypeName("ULONG")] uint celt, IDiaSegment** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched);

            [VtblIndex(7)]
            HRESULT Skip([NativeTypeName("ULONG")] uint celt);

            [VtblIndex(8)]
            HRESULT Reset();

            [VtblIndex(9)]
            HRESULT Clone(IDiaEnumSegments** ppenum);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumSegments*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumSegments*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumSegments*, uint> Release;

            [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumSegments*, IUnknown**, int> get__NewEnum;

            [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumSegments*, int*, int> get_Count;

            [NativeTypeName("HRESULT (DWORD, IDiaSegment **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumSegments*, uint, IDiaSegment**, int> Item;

            [NativeTypeName("HRESULT (ULONG, IDiaSegment **, ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumSegments*, uint, IDiaSegment**, uint*, int> Next;

            [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumSegments*, uint, int> Skip;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumSegments*, int> Reset;

            [NativeTypeName("HRESULT (IDiaEnumSegments **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumSegments*, IDiaEnumSegments**, int> Clone;
        }
    }
}
