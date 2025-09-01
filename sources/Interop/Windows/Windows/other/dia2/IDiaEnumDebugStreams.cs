// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IDiaEnumDebugStreams.xml' path='doc/member[@name="IDiaEnumDebugStreams"]/*' />
[Guid("08CBB41E-47A6-4F87-92F1-1C9C87CED044")]
[NativeTypeName("struct IDiaEnumDebugStreams : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDiaEnumDebugStreams : IDiaEnumDebugStreams.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IDiaEnumDebugStreams);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumDebugStreams*, Guid*, void**, int>)(lpVtbl[0]))((IDiaEnumDebugStreams*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumDebugStreams*, uint>)(lpVtbl[1]))((IDiaEnumDebugStreams*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumDebugStreams*, uint>)(lpVtbl[2]))((IDiaEnumDebugStreams*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDiaEnumDebugStreams.xml' path='doc/member[@name="IDiaEnumDebugStreams.get__NewEnum"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get__NewEnum(IUnknown** pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumDebugStreams*, IUnknown**, int>)(lpVtbl[3]))((IDiaEnumDebugStreams*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaEnumDebugStreams.xml' path='doc/member[@name="IDiaEnumDebugStreams.get_Count"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_Count([NativeTypeName("LONG *")] int* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumDebugStreams*, int*, int>)(lpVtbl[4]))((IDiaEnumDebugStreams*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaEnumDebugStreams.xml' path='doc/member[@name="IDiaEnumDebugStreams.Item"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Item(VARIANT index, IDiaEnumDebugStreamData** stream)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumDebugStreams*, VARIANT, IDiaEnumDebugStreamData**, int>)(lpVtbl[5]))((IDiaEnumDebugStreams*)Unsafe.AsPointer(ref this), index, stream);
    }

    /// <include file='IDiaEnumDebugStreams.xml' path='doc/member[@name="IDiaEnumDebugStreams.Next"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Next([NativeTypeName("ULONG")] uint celt, IDiaEnumDebugStreamData** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumDebugStreams*, uint, IDiaEnumDebugStreamData**, uint*, int>)(lpVtbl[6]))((IDiaEnumDebugStreams*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
    }

    /// <include file='IDiaEnumDebugStreams.xml' path='doc/member[@name="IDiaEnumDebugStreams.Skip"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Skip([NativeTypeName("ULONG")] uint celt)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumDebugStreams*, uint, int>)(lpVtbl[7]))((IDiaEnumDebugStreams*)Unsafe.AsPointer(ref this), celt);
    }

    /// <include file='IDiaEnumDebugStreams.xml' path='doc/member[@name="IDiaEnumDebugStreams.Reset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumDebugStreams*, int>)(lpVtbl[8]))((IDiaEnumDebugStreams*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDiaEnumDebugStreams.xml' path='doc/member[@name="IDiaEnumDebugStreams.Clone"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Clone(IDiaEnumDebugStreams** ppenum)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumDebugStreams*, IDiaEnumDebugStreams**, int>)(lpVtbl[9]))((IDiaEnumDebugStreams*)Unsafe.AsPointer(ref this), ppenum);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get__NewEnum(IUnknown** pRetVal);

        [VtblIndex(4)]
        HRESULT get_Count([NativeTypeName("LONG *")] int* pRetVal);

        [VtblIndex(5)]
        HRESULT Item(VARIANT index, IDiaEnumDebugStreamData** stream);

        [VtblIndex(6)]
        HRESULT Next([NativeTypeName("ULONG")] uint celt, IDiaEnumDebugStreamData** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched);

        [VtblIndex(7)]
        HRESULT Skip([NativeTypeName("ULONG")] uint celt);

        [VtblIndex(8)]
        HRESULT Reset();

        [VtblIndex(9)]
        HRESULT Clone(IDiaEnumDebugStreams** ppenum);
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

        [NativeTypeName("HRESULT (VARIANT, IDiaEnumDebugStreamData **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, IDiaEnumDebugStreamData**, int> Item;

        [NativeTypeName("HRESULT (ULONG, IDiaEnumDebugStreamData **, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IDiaEnumDebugStreamData**, uint*, int> Next;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> Skip;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Reset;

        [NativeTypeName("HRESULT (IDiaEnumDebugStreams **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDiaEnumDebugStreams**, int> Clone;
    }
}
