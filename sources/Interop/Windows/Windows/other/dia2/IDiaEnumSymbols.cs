// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("CAB72C48-443B-48F5-9B0B-42F0820AB29A")]
    [NativeTypeName("struct IDiaEnumSymbols : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDiaEnumSymbols : IDiaEnumSymbols.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDiaEnumSymbols*, Guid*, void**, int>)(lpVtbl[0]))((IDiaEnumSymbols*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDiaEnumSymbols*, uint>)(lpVtbl[1]))((IDiaEnumSymbols*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDiaEnumSymbols*, uint>)(lpVtbl[2]))((IDiaEnumSymbols*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT get__NewEnum(IUnknown** pRetVal)
        {
            return ((delegate* unmanaged<IDiaEnumSymbols*, IUnknown**, int>)(lpVtbl[3]))((IDiaEnumSymbols*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT get_Count([NativeTypeName("LONG *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaEnumSymbols*, int*, int>)(lpVtbl[4]))((IDiaEnumSymbols*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Item([NativeTypeName("DWORD")] uint index, IDiaSymbol** symbol)
        {
            return ((delegate* unmanaged<IDiaEnumSymbols*, uint, IDiaSymbol**, int>)(lpVtbl[5]))((IDiaEnumSymbols*)Unsafe.AsPointer(ref this), index, symbol);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Next([NativeTypeName("ULONG")] uint celt, IDiaSymbol** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
        {
            return ((delegate* unmanaged<IDiaEnumSymbols*, uint, IDiaSymbol**, uint*, int>)(lpVtbl[6]))((IDiaEnumSymbols*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT Skip([NativeTypeName("ULONG")] uint celt)
        {
            return ((delegate* unmanaged<IDiaEnumSymbols*, uint, int>)(lpVtbl[7]))((IDiaEnumSymbols*)Unsafe.AsPointer(ref this), celt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT Reset()
        {
            return ((delegate* unmanaged<IDiaEnumSymbols*, int>)(lpVtbl[8]))((IDiaEnumSymbols*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT Clone(IDiaEnumSymbols** ppenum)
        {
            return ((delegate* unmanaged<IDiaEnumSymbols*, IDiaEnumSymbols**, int>)(lpVtbl[9]))((IDiaEnumSymbols*)Unsafe.AsPointer(ref this), ppenum);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT get__NewEnum(IUnknown** pRetVal);

            [VtblIndex(4)]
            HRESULT get_Count([NativeTypeName("LONG *")] int* pRetVal);

            [VtblIndex(5)]
            HRESULT Item([NativeTypeName("DWORD")] uint index, IDiaSymbol** symbol);

            [VtblIndex(6)]
            HRESULT Next([NativeTypeName("ULONG")] uint celt, IDiaSymbol** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched);

            [VtblIndex(7)]
            HRESULT Skip([NativeTypeName("ULONG")] uint celt);

            [VtblIndex(8)]
            HRESULT Reset();

            [VtblIndex(9)]
            HRESULT Clone(IDiaEnumSymbols** ppenum);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumSymbols*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumSymbols*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumSymbols*, uint> Release;

            [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumSymbols*, IUnknown**, int> get__NewEnum;

            [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumSymbols*, int*, int> get_Count;

            [NativeTypeName("HRESULT (DWORD, IDiaSymbol **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumSymbols*, uint, IDiaSymbol**, int> Item;

            [NativeTypeName("HRESULT (ULONG, IDiaSymbol **, ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumSymbols*, uint, IDiaSymbol**, uint*, int> Next;

            [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumSymbols*, uint, int> Skip;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumSymbols*, int> Reset;

            [NativeTypeName("HRESULT (IDiaEnumSymbols **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumSymbols*, IDiaEnumSymbols**, int> Clone;
        }
    }
}
