// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='IDiaEnumInjectedSources.xml' path='doc/member[@name="IDiaEnumInjectedSources"]/*' />
[Guid("D5612573-6925-4468-8883-98CDEC8C384A")]
[NativeTypeName("struct IDiaEnumInjectedSources : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDiaEnumInjectedSources : IDiaEnumInjectedSources.Interface
{
    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDiaEnumInjectedSources*, Guid*, void**, int>)(lpVtbl[0]))((IDiaEnumInjectedSources*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDiaEnumInjectedSources*, uint>)(lpVtbl[1]))((IDiaEnumInjectedSources*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDiaEnumInjectedSources*, uint>)(lpVtbl[2]))((IDiaEnumInjectedSources*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDiaEnumInjectedSources.xml' path='doc/member[@name="IDiaEnumInjectedSources.get__NewEnum"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get__NewEnum(IUnknown** pRetVal)
    {
        return ((delegate* unmanaged<IDiaEnumInjectedSources*, IUnknown**, int>)(lpVtbl[3]))((IDiaEnumInjectedSources*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaEnumInjectedSources.xml' path='doc/member[@name="IDiaEnumInjectedSources.get_Count"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_Count([NativeTypeName("LONG *")] int* pRetVal)
    {
        return ((delegate* unmanaged<IDiaEnumInjectedSources*, int*, int>)(lpVtbl[4]))((IDiaEnumInjectedSources*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaEnumInjectedSources.xml' path='doc/member[@name="IDiaEnumInjectedSources.Item"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Item([NativeTypeName("DWORD")] uint index, IDiaInjectedSource** injectedSource)
    {
        return ((delegate* unmanaged<IDiaEnumInjectedSources*, uint, IDiaInjectedSource**, int>)(lpVtbl[5]))((IDiaEnumInjectedSources*)Unsafe.AsPointer(ref this), index, injectedSource);
    }

    /// <include file='IDiaEnumInjectedSources.xml' path='doc/member[@name="IDiaEnumInjectedSources.Next"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Next([NativeTypeName("ULONG")] uint celt, IDiaInjectedSource** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
    {
        return ((delegate* unmanaged<IDiaEnumInjectedSources*, uint, IDiaInjectedSource**, uint*, int>)(lpVtbl[6]))((IDiaEnumInjectedSources*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
    }

    /// <include file='IDiaEnumInjectedSources.xml' path='doc/member[@name="IDiaEnumInjectedSources.Skip"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Skip([NativeTypeName("ULONG")] uint celt)
    {
        return ((delegate* unmanaged<IDiaEnumInjectedSources*, uint, int>)(lpVtbl[7]))((IDiaEnumInjectedSources*)Unsafe.AsPointer(ref this), celt);
    }

    /// <include file='IDiaEnumInjectedSources.xml' path='doc/member[@name="IDiaEnumInjectedSources.Reset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IDiaEnumInjectedSources*, int>)(lpVtbl[8]))((IDiaEnumInjectedSources*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDiaEnumInjectedSources.xml' path='doc/member[@name="IDiaEnumInjectedSources.Clone"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Clone(IDiaEnumInjectedSources** ppenum)
    {
        return ((delegate* unmanaged<IDiaEnumInjectedSources*, IDiaEnumInjectedSources**, int>)(lpVtbl[9]))((IDiaEnumInjectedSources*)Unsafe.AsPointer(ref this), ppenum);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get__NewEnum(IUnknown** pRetVal);

        [VtblIndex(4)]
        HRESULT get_Count([NativeTypeName("LONG *")] int* pRetVal);

        [VtblIndex(5)]
        HRESULT Item([NativeTypeName("DWORD")] uint index, IDiaInjectedSource** injectedSource);

        [VtblIndex(6)]
        HRESULT Next([NativeTypeName("ULONG")] uint celt, IDiaInjectedSource** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched);

        [VtblIndex(7)]
        HRESULT Skip([NativeTypeName("ULONG")] uint celt);

        [VtblIndex(8)]
        HRESULT Reset();

        [VtblIndex(9)]
        HRESULT Clone(IDiaEnumInjectedSources** ppenum);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown**, int> get__NewEnum;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Count;

        [NativeTypeName("HRESULT (DWORD, IDiaInjectedSource **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDiaInjectedSource**, int> Item;

        [NativeTypeName("HRESULT (ULONG, IDiaInjectedSource **, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDiaInjectedSource**, uint*, int> Next;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Skip;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;

        [NativeTypeName("HRESULT (IDiaEnumInjectedSources **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDiaEnumInjectedSources**, int> Clone;
    }
}
