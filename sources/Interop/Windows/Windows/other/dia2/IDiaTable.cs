// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='IDiaTable.xml' path='doc/member[@name="IDiaTable"]/*' />
[Guid("4A59FB77-ABAC-469B-A30B-9ECC85BFEF14")]
[NativeTypeName("struct IDiaTable : IEnumUnknown")]
[NativeInheritance("IEnumUnknown")]
public unsafe partial struct IDiaTable : IDiaTable.Interface
{
    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDiaTable*, Guid*, void**, int>)(lpVtbl[0]))((IDiaTable*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDiaTable*, uint>)(lpVtbl[1]))((IDiaTable*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDiaTable*, uint>)(lpVtbl[2]))((IDiaTable*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IEnumUnknown.Next" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Next([NativeTypeName("ULONG")] uint celt, IUnknown** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
    {
        return ((delegate* unmanaged<IDiaTable*, uint, IUnknown**, uint*, int>)(lpVtbl[3]))((IDiaTable*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
    }

    /// <inheritdoc cref="IEnumUnknown.Skip" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Skip([NativeTypeName("ULONG")] uint celt)
    {
        return ((delegate* unmanaged<IDiaTable*, uint, int>)(lpVtbl[4]))((IDiaTable*)Unsafe.AsPointer(ref this), celt);
    }

    /// <inheritdoc cref="IEnumUnknown.Reset" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IDiaTable*, int>)(lpVtbl[5]))((IDiaTable*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IEnumUnknown.Clone" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Clone(IEnumUnknown** ppenum)
    {
        return ((delegate* unmanaged<IDiaTable*, IEnumUnknown**, int>)(lpVtbl[6]))((IDiaTable*)Unsafe.AsPointer(ref this), ppenum);
    }

    /// <include file='IDiaTable.xml' path='doc/member[@name="IDiaTable.get__NewEnum"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get__NewEnum(IUnknown** pRetVal)
    {
        return ((delegate* unmanaged<IDiaTable*, IUnknown**, int>)(lpVtbl[7]))((IDiaTable*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaTable.xml' path='doc/member[@name="IDiaTable.get_name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_name([NativeTypeName("BSTR *")] ushort** pRetVal)
    {
        return ((delegate* unmanaged<IDiaTable*, ushort**, int>)(lpVtbl[8]))((IDiaTable*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaTable.xml' path='doc/member[@name="IDiaTable.get_Count"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Count([NativeTypeName("LONG *")] int* pRetVal)
    {
        return ((delegate* unmanaged<IDiaTable*, int*, int>)(lpVtbl[9]))((IDiaTable*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaTable.xml' path='doc/member[@name="IDiaTable.Item"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Item([NativeTypeName("DWORD")] uint index, IUnknown** element)
    {
        return ((delegate* unmanaged<IDiaTable*, uint, IUnknown**, int>)(lpVtbl[10]))((IDiaTable*)Unsafe.AsPointer(ref this), index, element);
    }

    public interface Interface : IEnumUnknown.Interface
    {
        [VtblIndex(7)]
        HRESULT get__NewEnum(IUnknown** pRetVal);

        [VtblIndex(8)]
        HRESULT get_name([NativeTypeName("BSTR *")] ushort** pRetVal);

        [VtblIndex(9)]
        HRESULT get_Count([NativeTypeName("LONG *")] int* pRetVal);

        [VtblIndex(10)]
        HRESULT Item([NativeTypeName("DWORD")] uint index, IUnknown** element);
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

        [NativeTypeName("HRESULT (ULONG, IUnknown **, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IUnknown**, uint*, int> Next;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Skip;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;

        [NativeTypeName("HRESULT (IEnumUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumUnknown**, int> Clone;

        [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown**, int> get__NewEnum;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_name;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Count;

        [NativeTypeName("HRESULT (DWORD, IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IUnknown**, int> Item;
    }
}
