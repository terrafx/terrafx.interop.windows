// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='IDiaSectionContrib.xml' path='doc/member[@name="IDiaSectionContrib"]/*' />
[Guid("0CF4B60E-35B1-4C6C-BDD8-854B9C8E3857")]
[NativeTypeName("struct IDiaSectionContrib : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDiaSectionContrib : IDiaSectionContrib.Interface
{
    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDiaSectionContrib*, Guid*, void**, int>)(lpVtbl[0]))((IDiaSectionContrib*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDiaSectionContrib*, uint>)(lpVtbl[1]))((IDiaSectionContrib*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDiaSectionContrib*, uint>)(lpVtbl[2]))((IDiaSectionContrib*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDiaSectionContrib.xml' path='doc/member[@name="IDiaSectionContrib.get_compiland"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_compiland(IDiaSymbol** pRetVal)
    {
        return ((delegate* unmanaged<IDiaSectionContrib*, IDiaSymbol**, int>)(lpVtbl[3]))((IDiaSectionContrib*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaSectionContrib.xml' path='doc/member[@name="IDiaSectionContrib.get_addressSection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_addressSection([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged<IDiaSectionContrib*, uint*, int>)(lpVtbl[4]))((IDiaSectionContrib*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaSectionContrib.xml' path='doc/member[@name="IDiaSectionContrib.get_addressOffset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT get_addressOffset([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged<IDiaSectionContrib*, uint*, int>)(lpVtbl[5]))((IDiaSectionContrib*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaSectionContrib.xml' path='doc/member[@name="IDiaSectionContrib.get_relativeVirtualAddress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_relativeVirtualAddress([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged<IDiaSectionContrib*, uint*, int>)(lpVtbl[6]))((IDiaSectionContrib*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaSectionContrib.xml' path='doc/member[@name="IDiaSectionContrib.get_virtualAddress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_virtualAddress([NativeTypeName("ULONGLONG *")] ulong* pRetVal)
    {
        return ((delegate* unmanaged<IDiaSectionContrib*, ulong*, int>)(lpVtbl[7]))((IDiaSectionContrib*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaSectionContrib.xml' path='doc/member[@name="IDiaSectionContrib.get_length"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_length([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged<IDiaSectionContrib*, uint*, int>)(lpVtbl[8]))((IDiaSectionContrib*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaSectionContrib.xml' path='doc/member[@name="IDiaSectionContrib.get_notPaged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_notPaged(BOOL* pRetVal)
    {
        return ((delegate* unmanaged<IDiaSectionContrib*, BOOL*, int>)(lpVtbl[9]))((IDiaSectionContrib*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaSectionContrib.xml' path='doc/member[@name="IDiaSectionContrib.get_code"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_code(BOOL* pRetVal)
    {
        return ((delegate* unmanaged<IDiaSectionContrib*, BOOL*, int>)(lpVtbl[10]))((IDiaSectionContrib*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaSectionContrib.xml' path='doc/member[@name="IDiaSectionContrib.get_initializedData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_initializedData(BOOL* pRetVal)
    {
        return ((delegate* unmanaged<IDiaSectionContrib*, BOOL*, int>)(lpVtbl[11]))((IDiaSectionContrib*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaSectionContrib.xml' path='doc/member[@name="IDiaSectionContrib.get_uninitializedData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_uninitializedData(BOOL* pRetVal)
    {
        return ((delegate* unmanaged<IDiaSectionContrib*, BOOL*, int>)(lpVtbl[12]))((IDiaSectionContrib*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaSectionContrib.xml' path='doc/member[@name="IDiaSectionContrib.get_remove"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_remove(BOOL* pRetVal)
    {
        return ((delegate* unmanaged<IDiaSectionContrib*, BOOL*, int>)(lpVtbl[13]))((IDiaSectionContrib*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaSectionContrib.xml' path='doc/member[@name="IDiaSectionContrib.get_comdat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_comdat(BOOL* pRetVal)
    {
        return ((delegate* unmanaged<IDiaSectionContrib*, BOOL*, int>)(lpVtbl[14]))((IDiaSectionContrib*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaSectionContrib.xml' path='doc/member[@name="IDiaSectionContrib.get_discardable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_discardable(BOOL* pRetVal)
    {
        return ((delegate* unmanaged<IDiaSectionContrib*, BOOL*, int>)(lpVtbl[15]))((IDiaSectionContrib*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaSectionContrib.xml' path='doc/member[@name="IDiaSectionContrib.get_notCached"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_notCached(BOOL* pRetVal)
    {
        return ((delegate* unmanaged<IDiaSectionContrib*, BOOL*, int>)(lpVtbl[16]))((IDiaSectionContrib*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaSectionContrib.xml' path='doc/member[@name="IDiaSectionContrib.get_share"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_share(BOOL* pRetVal)
    {
        return ((delegate* unmanaged<IDiaSectionContrib*, BOOL*, int>)(lpVtbl[17]))((IDiaSectionContrib*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaSectionContrib.xml' path='doc/member[@name="IDiaSectionContrib.get_execute"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_execute(BOOL* pRetVal)
    {
        return ((delegate* unmanaged<IDiaSectionContrib*, BOOL*, int>)(lpVtbl[18]))((IDiaSectionContrib*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaSectionContrib.xml' path='doc/member[@name="IDiaSectionContrib.get_read"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_read(BOOL* pRetVal)
    {
        return ((delegate* unmanaged<IDiaSectionContrib*, BOOL*, int>)(lpVtbl[19]))((IDiaSectionContrib*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaSectionContrib.xml' path='doc/member[@name="IDiaSectionContrib.get_write"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_write(BOOL* pRetVal)
    {
        return ((delegate* unmanaged<IDiaSectionContrib*, BOOL*, int>)(lpVtbl[20]))((IDiaSectionContrib*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaSectionContrib.xml' path='doc/member[@name="IDiaSectionContrib.get_dataCrc"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_dataCrc([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged<IDiaSectionContrib*, uint*, int>)(lpVtbl[21]))((IDiaSectionContrib*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaSectionContrib.xml' path='doc/member[@name="IDiaSectionContrib.get_relocationsCrc"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_relocationsCrc([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged<IDiaSectionContrib*, uint*, int>)(lpVtbl[22]))((IDiaSectionContrib*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaSectionContrib.xml' path='doc/member[@name="IDiaSectionContrib.get_compilandId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_compilandId([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged<IDiaSectionContrib*, uint*, int>)(lpVtbl[23]))((IDiaSectionContrib*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaSectionContrib.xml' path='doc/member[@name="IDiaSectionContrib.get_code16bit"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_code16bit(BOOL* pRetVal)
    {
        return ((delegate* unmanaged<IDiaSectionContrib*, BOOL*, int>)(lpVtbl[24]))((IDiaSectionContrib*)Unsafe.AsPointer(ref this), pRetVal);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_compiland(IDiaSymbol** pRetVal);

        [VtblIndex(4)]
        HRESULT get_addressSection([NativeTypeName("DWORD *")] uint* pRetVal);

        [VtblIndex(5)]
        HRESULT get_addressOffset([NativeTypeName("DWORD *")] uint* pRetVal);

        [VtblIndex(6)]
        HRESULT get_relativeVirtualAddress([NativeTypeName("DWORD *")] uint* pRetVal);

        [VtblIndex(7)]
        HRESULT get_virtualAddress([NativeTypeName("ULONGLONG *")] ulong* pRetVal);

        [VtblIndex(8)]
        HRESULT get_length([NativeTypeName("DWORD *")] uint* pRetVal);

        [VtblIndex(9)]
        HRESULT get_notPaged(BOOL* pRetVal);

        [VtblIndex(10)]
        HRESULT get_code(BOOL* pRetVal);

        [VtblIndex(11)]
        HRESULT get_initializedData(BOOL* pRetVal);

        [VtblIndex(12)]
        HRESULT get_uninitializedData(BOOL* pRetVal);

        [VtblIndex(13)]
        HRESULT get_remove(BOOL* pRetVal);

        [VtblIndex(14)]
        HRESULT get_comdat(BOOL* pRetVal);

        [VtblIndex(15)]
        HRESULT get_discardable(BOOL* pRetVal);

        [VtblIndex(16)]
        HRESULT get_notCached(BOOL* pRetVal);

        [VtblIndex(17)]
        HRESULT get_share(BOOL* pRetVal);

        [VtblIndex(18)]
        HRESULT get_execute(BOOL* pRetVal);

        [VtblIndex(19)]
        HRESULT get_read(BOOL* pRetVal);

        [VtblIndex(20)]
        HRESULT get_write(BOOL* pRetVal);

        [VtblIndex(21)]
        HRESULT get_dataCrc([NativeTypeName("DWORD *")] uint* pRetVal);

        [VtblIndex(22)]
        HRESULT get_relocationsCrc([NativeTypeName("DWORD *")] uint* pRetVal);

        [VtblIndex(23)]
        HRESULT get_compilandId([NativeTypeName("DWORD *")] uint* pRetVal);

        [VtblIndex(24)]
        HRESULT get_code16bit(BOOL* pRetVal);
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

        [NativeTypeName("HRESULT (IDiaSymbol **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDiaSymbol**, int> get_compiland;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_addressSection;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_addressOffset;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_relativeVirtualAddress;

        [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_virtualAddress;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_length;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> get_notPaged;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> get_code;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> get_initializedData;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> get_uninitializedData;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> get_remove;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> get_comdat;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> get_discardable;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> get_notCached;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> get_share;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> get_execute;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> get_read;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> get_write;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_dataCrc;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_relocationsCrc;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_compilandId;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> get_code16bit;
    }
}
