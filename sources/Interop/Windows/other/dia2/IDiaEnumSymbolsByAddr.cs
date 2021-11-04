// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("624B7D9C-24EA-4421-9D06-3B577471C1FA")]
    [NativeTypeName("struct IDiaEnumSymbolsByAddr : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDiaEnumSymbolsByAddr
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDiaEnumSymbolsByAddr*, Guid*, void**, int>)(lpVtbl[0]))((IDiaEnumSymbolsByAddr*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDiaEnumSymbolsByAddr*, uint>)(lpVtbl[1]))((IDiaEnumSymbolsByAddr*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDiaEnumSymbolsByAddr*, uint>)(lpVtbl[2]))((IDiaEnumSymbolsByAddr*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT symbolByAddr([NativeTypeName("DWORD")] uint isect, [NativeTypeName("DWORD")] uint offset, IDiaSymbol** ppSymbol)
        {
            return ((delegate* unmanaged<IDiaEnumSymbolsByAddr*, uint, uint, IDiaSymbol**, int>)(lpVtbl[3]))((IDiaEnumSymbolsByAddr*)Unsafe.AsPointer(ref this), isect, offset, ppSymbol);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT symbolByRVA([NativeTypeName("DWORD")] uint relativeVirtualAddress, IDiaSymbol** ppSymbol)
        {
            return ((delegate* unmanaged<IDiaEnumSymbolsByAddr*, uint, IDiaSymbol**, int>)(lpVtbl[4]))((IDiaEnumSymbolsByAddr*)Unsafe.AsPointer(ref this), relativeVirtualAddress, ppSymbol);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT symbolByVA([NativeTypeName("ULONGLONG")] ulong virtualAddress, IDiaSymbol** ppSymbol)
        {
            return ((delegate* unmanaged<IDiaEnumSymbolsByAddr*, ulong, IDiaSymbol**, int>)(lpVtbl[5]))((IDiaEnumSymbolsByAddr*)Unsafe.AsPointer(ref this), virtualAddress, ppSymbol);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Next([NativeTypeName("ULONG")] uint celt, IDiaSymbol** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
        {
            return ((delegate* unmanaged<IDiaEnumSymbolsByAddr*, uint, IDiaSymbol**, uint*, int>)(lpVtbl[6]))((IDiaEnumSymbolsByAddr*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT Prev([NativeTypeName("ULONG")] uint celt, IDiaSymbol** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
        {
            return ((delegate* unmanaged<IDiaEnumSymbolsByAddr*, uint, IDiaSymbol**, uint*, int>)(lpVtbl[7]))((IDiaEnumSymbolsByAddr*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT Clone(IDiaEnumSymbolsByAddr** ppenum)
        {
            return ((delegate* unmanaged<IDiaEnumSymbolsByAddr*, IDiaEnumSymbolsByAddr**, int>)(lpVtbl[8]))((IDiaEnumSymbolsByAddr*)Unsafe.AsPointer(ref this), ppenum);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumSymbolsByAddr*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumSymbolsByAddr*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumSymbolsByAddr*, uint> Release;

            [NativeTypeName("HRESULT (DWORD, DWORD, IDiaSymbol **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumSymbolsByAddr*, uint, uint, IDiaSymbol**, int> symbolByAddr;

            [NativeTypeName("HRESULT (DWORD, IDiaSymbol **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumSymbolsByAddr*, uint, IDiaSymbol**, int> symbolByRVA;

            [NativeTypeName("HRESULT (ULONGLONG, IDiaSymbol **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumSymbolsByAddr*, ulong, IDiaSymbol**, int> symbolByVA;

            [NativeTypeName("HRESULT (ULONG, IDiaSymbol **, ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumSymbolsByAddr*, uint, IDiaSymbol**, uint*, int> Next;

            [NativeTypeName("HRESULT (ULONG, IDiaSymbol **, ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumSymbolsByAddr*, uint, IDiaSymbol**, uint*, int> Prev;

            [NativeTypeName("HRESULT (IDiaEnumSymbolsByAddr **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumSymbolsByAddr*, IDiaEnumSymbolsByAddr**, int> Clone;
        }
    }
}
