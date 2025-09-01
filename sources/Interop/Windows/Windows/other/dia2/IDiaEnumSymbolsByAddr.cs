// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IDiaEnumSymbolsByAddr.xml' path='doc/member[@name="IDiaEnumSymbolsByAddr"]/*' />
[Guid("624B7D9C-24EA-4421-9D06-3B577471C1FA")]
[NativeTypeName("struct IDiaEnumSymbolsByAddr : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDiaEnumSymbolsByAddr : IDiaEnumSymbolsByAddr.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IDiaEnumSymbolsByAddr);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumSymbolsByAddr*, Guid*, void**, int>)(lpVtbl[0]))((IDiaEnumSymbolsByAddr*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumSymbolsByAddr*, uint>)(lpVtbl[1]))((IDiaEnumSymbolsByAddr*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumSymbolsByAddr*, uint>)(lpVtbl[2]))((IDiaEnumSymbolsByAddr*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDiaEnumSymbolsByAddr.xml' path='doc/member[@name="IDiaEnumSymbolsByAddr.symbolByAddr"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT symbolByAddr([NativeTypeName("DWORD")] uint isect, [NativeTypeName("DWORD")] uint offset, IDiaSymbol** ppSymbol)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumSymbolsByAddr*, uint, uint, IDiaSymbol**, int>)(lpVtbl[3]))((IDiaEnumSymbolsByAddr*)Unsafe.AsPointer(ref this), isect, offset, ppSymbol);
    }

    /// <include file='IDiaEnumSymbolsByAddr.xml' path='doc/member[@name="IDiaEnumSymbolsByAddr.symbolByRVA"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT symbolByRVA([NativeTypeName("DWORD")] uint relativeVirtualAddress, IDiaSymbol** ppSymbol)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumSymbolsByAddr*, uint, IDiaSymbol**, int>)(lpVtbl[4]))((IDiaEnumSymbolsByAddr*)Unsafe.AsPointer(ref this), relativeVirtualAddress, ppSymbol);
    }

    /// <include file='IDiaEnumSymbolsByAddr.xml' path='doc/member[@name="IDiaEnumSymbolsByAddr.symbolByVA"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT symbolByVA([NativeTypeName("ULONGLONG")] ulong virtualAddress, IDiaSymbol** ppSymbol)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumSymbolsByAddr*, ulong, IDiaSymbol**, int>)(lpVtbl[5]))((IDiaEnumSymbolsByAddr*)Unsafe.AsPointer(ref this), virtualAddress, ppSymbol);
    }

    /// <include file='IDiaEnumSymbolsByAddr.xml' path='doc/member[@name="IDiaEnumSymbolsByAddr.Next"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Next([NativeTypeName("ULONG")] uint celt, IDiaSymbol** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumSymbolsByAddr*, uint, IDiaSymbol**, uint*, int>)(lpVtbl[6]))((IDiaEnumSymbolsByAddr*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
    }

    /// <include file='IDiaEnumSymbolsByAddr.xml' path='doc/member[@name="IDiaEnumSymbolsByAddr.Prev"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Prev([NativeTypeName("ULONG")] uint celt, IDiaSymbol** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumSymbolsByAddr*, uint, IDiaSymbol**, uint*, int>)(lpVtbl[7]))((IDiaEnumSymbolsByAddr*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
    }

    /// <include file='IDiaEnumSymbolsByAddr.xml' path='doc/member[@name="IDiaEnumSymbolsByAddr.Clone"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Clone(IDiaEnumSymbolsByAddr** ppenum)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumSymbolsByAddr*, IDiaEnumSymbolsByAddr**, int>)(lpVtbl[8]))((IDiaEnumSymbolsByAddr*)Unsafe.AsPointer(ref this), ppenum);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT symbolByAddr([NativeTypeName("DWORD")] uint isect, [NativeTypeName("DWORD")] uint offset, IDiaSymbol** ppSymbol);

        [VtblIndex(4)]
        HRESULT symbolByRVA([NativeTypeName("DWORD")] uint relativeVirtualAddress, IDiaSymbol** ppSymbol);

        [VtblIndex(5)]
        HRESULT symbolByVA([NativeTypeName("ULONGLONG")] ulong virtualAddress, IDiaSymbol** ppSymbol);

        [VtblIndex(6)]
        HRESULT Next([NativeTypeName("ULONG")] uint celt, IDiaSymbol** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched);

        [VtblIndex(7)]
        HRESULT Prev([NativeTypeName("ULONG")] uint celt, IDiaSymbol** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched);

        [VtblIndex(8)]
        HRESULT Clone(IDiaEnumSymbolsByAddr** ppenum);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (DWORD, DWORD, IDiaSymbol **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, IDiaSymbol**, int> symbolByAddr;

        [NativeTypeName("HRESULT (DWORD, IDiaSymbol **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IDiaSymbol**, int> symbolByRVA;

        [NativeTypeName("HRESULT (ULONGLONG, IDiaSymbol **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong, IDiaSymbol**, int> symbolByVA;

        [NativeTypeName("HRESULT (ULONG, IDiaSymbol **, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IDiaSymbol**, uint*, int> Next;

        [NativeTypeName("HRESULT (ULONG, IDiaSymbol **, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IDiaSymbol**, uint*, int> Prev;

        [NativeTypeName("HRESULT (IDiaEnumSymbolsByAddr **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDiaEnumSymbolsByAddr**, int> Clone;
    }
}
