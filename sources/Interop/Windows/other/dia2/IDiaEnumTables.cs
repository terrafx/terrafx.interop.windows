// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C65C2B0A-1150-4D7A-AFCC-E05BF3DEE81E")]
    [NativeTypeName("struct IDiaEnumTables : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDiaEnumTables : IDiaEnumTables.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDiaEnumTables*, Guid*, void**, int>)(lpVtbl[0]))((IDiaEnumTables*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDiaEnumTables*, uint>)(lpVtbl[1]))((IDiaEnumTables*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDiaEnumTables*, uint>)(lpVtbl[2]))((IDiaEnumTables*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT get__NewEnum(IUnknown** pRetVal)
        {
            return ((delegate* unmanaged<IDiaEnumTables*, IUnknown**, int>)(lpVtbl[3]))((IDiaEnumTables*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT get_Count([NativeTypeName("LONG *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaEnumTables*, int*, int>)(lpVtbl[4]))((IDiaEnumTables*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Item(VARIANT index, IDiaTable** table)
        {
            return ((delegate* unmanaged<IDiaEnumTables*, VARIANT, IDiaTable**, int>)(lpVtbl[5]))((IDiaEnumTables*)Unsafe.AsPointer(ref this), index, table);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Next([NativeTypeName("ULONG")] uint celt, IDiaTable** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
        {
            return ((delegate* unmanaged<IDiaEnumTables*, uint, IDiaTable**, uint*, int>)(lpVtbl[6]))((IDiaEnumTables*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT Skip([NativeTypeName("ULONG")] uint celt)
        {
            return ((delegate* unmanaged<IDiaEnumTables*, uint, int>)(lpVtbl[7]))((IDiaEnumTables*)Unsafe.AsPointer(ref this), celt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT Reset()
        {
            return ((delegate* unmanaged<IDiaEnumTables*, int>)(lpVtbl[8]))((IDiaEnumTables*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT Clone(IDiaEnumTables** ppenum)
        {
            return ((delegate* unmanaged<IDiaEnumTables*, IDiaEnumTables**, int>)(lpVtbl[9]))((IDiaEnumTables*)Unsafe.AsPointer(ref this), ppenum);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT get__NewEnum(IUnknown** pRetVal);

            [VtblIndex(4)]
            HRESULT get_Count([NativeTypeName("LONG *")] int* pRetVal);

            [VtblIndex(5)]
            HRESULT Item(VARIANT index, IDiaTable** table);

            [VtblIndex(6)]
            HRESULT Next([NativeTypeName("ULONG")] uint celt, IDiaTable** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched);

            [VtblIndex(7)]
            HRESULT Skip([NativeTypeName("ULONG")] uint celt);

            [VtblIndex(8)]
            HRESULT Reset();

            [VtblIndex(9)]
            HRESULT Clone(IDiaEnumTables** ppenum);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumTables*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumTables*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumTables*, uint> Release;

            [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumTables*, IUnknown**, int> get__NewEnum;

            [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumTables*, int*, int> get_Count;

            [NativeTypeName("HRESULT (VARIANT, IDiaTable **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumTables*, VARIANT, IDiaTable**, int> Item;

            [NativeTypeName("HRESULT (ULONG, IDiaTable **, ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumTables*, uint, IDiaTable**, uint*, int> Next;

            [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumTables*, uint, int> Skip;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumTables*, int> Reset;

            [NativeTypeName("HRESULT (IDiaEnumTables **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumTables*, IDiaEnumTables**, int> Clone;
        }
    }
}
