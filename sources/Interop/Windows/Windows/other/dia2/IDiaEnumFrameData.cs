// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IDiaEnumFrameData.xml' path='doc/member[@name="IDiaEnumFrameData"]/*' />
[Guid("9FC77A4B-3C1C-44ED-A798-6C1DEEA53E1F")]
[NativeTypeName("struct IDiaEnumFrameData : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDiaEnumFrameData : IDiaEnumFrameData.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IDiaEnumFrameData);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumFrameData*, Guid*, void**, int>)(lpVtbl[0]))((IDiaEnumFrameData*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumFrameData*, uint>)(lpVtbl[1]))((IDiaEnumFrameData*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumFrameData*, uint>)(lpVtbl[2]))((IDiaEnumFrameData*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDiaEnumFrameData.xml' path='doc/member[@name="IDiaEnumFrameData.get__NewEnum"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get__NewEnum(IUnknown** pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumFrameData*, IUnknown**, int>)(lpVtbl[3]))((IDiaEnumFrameData*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaEnumFrameData.xml' path='doc/member[@name="IDiaEnumFrameData.get_Count"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_Count([NativeTypeName("LONG *")] int* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumFrameData*, int*, int>)(lpVtbl[4]))((IDiaEnumFrameData*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaEnumFrameData.xml' path='doc/member[@name="IDiaEnumFrameData.Item"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Item([NativeTypeName("DWORD")] uint index, IDiaFrameData** frame)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumFrameData*, uint, IDiaFrameData**, int>)(lpVtbl[5]))((IDiaEnumFrameData*)Unsafe.AsPointer(ref this), index, frame);
    }

    /// <include file='IDiaEnumFrameData.xml' path='doc/member[@name="IDiaEnumFrameData.Next"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Next([NativeTypeName("ULONG")] uint celt, IDiaFrameData** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumFrameData*, uint, IDiaFrameData**, uint*, int>)(lpVtbl[6]))((IDiaEnumFrameData*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
    }

    /// <include file='IDiaEnumFrameData.xml' path='doc/member[@name="IDiaEnumFrameData.Skip"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Skip([NativeTypeName("ULONG")] uint celt)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumFrameData*, uint, int>)(lpVtbl[7]))((IDiaEnumFrameData*)Unsafe.AsPointer(ref this), celt);
    }

    /// <include file='IDiaEnumFrameData.xml' path='doc/member[@name="IDiaEnumFrameData.Reset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumFrameData*, int>)(lpVtbl[8]))((IDiaEnumFrameData*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDiaEnumFrameData.xml' path='doc/member[@name="IDiaEnumFrameData.Clone"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Clone(IDiaEnumFrameData** ppenum)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumFrameData*, IDiaEnumFrameData**, int>)(lpVtbl[9]))((IDiaEnumFrameData*)Unsafe.AsPointer(ref this), ppenum);
    }

    /// <include file='IDiaEnumFrameData.xml' path='doc/member[@name="IDiaEnumFrameData.frameByRVA"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT frameByRVA([NativeTypeName("DWORD")] uint relativeVirtualAddress, IDiaFrameData** frame)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumFrameData*, uint, IDiaFrameData**, int>)(lpVtbl[10]))((IDiaEnumFrameData*)Unsafe.AsPointer(ref this), relativeVirtualAddress, frame);
    }

    /// <include file='IDiaEnumFrameData.xml' path='doc/member[@name="IDiaEnumFrameData.frameByVA"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT frameByVA([NativeTypeName("ULONGLONG")] ulong virtualAddress, IDiaFrameData** frame)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumFrameData*, ulong, IDiaFrameData**, int>)(lpVtbl[11]))((IDiaEnumFrameData*)Unsafe.AsPointer(ref this), virtualAddress, frame);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get__NewEnum(IUnknown** pRetVal);

        [VtblIndex(4)]
        HRESULT get_Count([NativeTypeName("LONG *")] int* pRetVal);

        [VtblIndex(5)]
        HRESULT Item([NativeTypeName("DWORD")] uint index, IDiaFrameData** frame);

        [VtblIndex(6)]
        HRESULT Next([NativeTypeName("ULONG")] uint celt, IDiaFrameData** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched);

        [VtblIndex(7)]
        HRESULT Skip([NativeTypeName("ULONG")] uint celt);

        [VtblIndex(8)]
        HRESULT Reset();

        [VtblIndex(9)]
        HRESULT Clone(IDiaEnumFrameData** ppenum);

        [VtblIndex(10)]
        HRESULT frameByRVA([NativeTypeName("DWORD")] uint relativeVirtualAddress, IDiaFrameData** frame);

        [VtblIndex(11)]
        HRESULT frameByVA([NativeTypeName("ULONGLONG")] ulong virtualAddress, IDiaFrameData** frame);
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

        [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUnknown**, int> get__NewEnum;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_Count;

        [NativeTypeName("HRESULT (DWORD, IDiaFrameData **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IDiaFrameData**, int> Item;

        [NativeTypeName("HRESULT (ULONG, IDiaFrameData **, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IDiaFrameData**, uint*, int> Next;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> Skip;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Reset;

        [NativeTypeName("HRESULT (IDiaEnumFrameData **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDiaEnumFrameData**, int> Clone;

        [NativeTypeName("HRESULT (DWORD, IDiaFrameData **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IDiaFrameData**, int> frameByRVA;

        [NativeTypeName("HRESULT (ULONGLONG, IDiaFrameData **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong, IDiaFrameData**, int> frameByVA;
    }
}
