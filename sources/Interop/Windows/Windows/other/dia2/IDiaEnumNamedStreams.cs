// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IDiaEnumNamedStreams.xml' path='doc/member[@name="IDiaEnumNamedStreams"]/*' />
[Guid("2B01F5E0-98DB-4824-A9A0-5192833BEF47")]
[NativeTypeName("struct IDiaEnumNamedStreams : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDiaEnumNamedStreams : IDiaEnumNamedStreams.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IDiaEnumNamedStreams);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumNamedStreams*, Guid*, void**, int>)(lpVtbl[0]))((IDiaEnumNamedStreams*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumNamedStreams*, uint>)(lpVtbl[1]))((IDiaEnumNamedStreams*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumNamedStreams*, uint>)(lpVtbl[2]))((IDiaEnumNamedStreams*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDiaEnumNamedStreams.xml' path='doc/member[@name="IDiaEnumNamedStreams.get__NewEnum"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get__NewEnum(IUnknown** pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumNamedStreams*, IUnknown**, int>)(lpVtbl[3]))((IDiaEnumNamedStreams*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaEnumNamedStreams.xml' path='doc/member[@name="IDiaEnumNamedStreams.get_Count"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_Count([NativeTypeName("LONG *")] int* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumNamedStreams*, int*, int>)(lpVtbl[4]))((IDiaEnumNamedStreams*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaEnumNamedStreams.xml' path='doc/member[@name="IDiaEnumNamedStreams.Next"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Next([NativeTypeName("BSTR *")] char** pName)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumNamedStreams*, char**, int>)(lpVtbl[5]))((IDiaEnumNamedStreams*)Unsafe.AsPointer(ref this), pName);
    }

    /// <include file='IDiaEnumNamedStreams.xml' path='doc/member[@name="IDiaEnumNamedStreams.Skip"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Skip([NativeTypeName("ULONG")] uint celt)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumNamedStreams*, uint, int>)(lpVtbl[6]))((IDiaEnumNamedStreams*)Unsafe.AsPointer(ref this), celt);
    }

    /// <include file='IDiaEnumNamedStreams.xml' path='doc/member[@name="IDiaEnumNamedStreams.Reset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumNamedStreams*, int>)(lpVtbl[7]))((IDiaEnumNamedStreams*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDiaEnumNamedStreams.xml' path='doc/member[@name="IDiaEnumNamedStreams.Clone"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Clone(IDiaEnumNamedStreams** ppenum)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaEnumNamedStreams*, IDiaEnumNamedStreams**, int>)(lpVtbl[8]))((IDiaEnumNamedStreams*)Unsafe.AsPointer(ref this), ppenum);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get__NewEnum(IUnknown** pRetVal);

        [VtblIndex(4)]
        HRESULT get_Count([NativeTypeName("LONG *")] int* pRetVal);

        [VtblIndex(5)]
        HRESULT Next([NativeTypeName("BSTR *")] char** pName);

        [VtblIndex(6)]
        HRESULT Skip([NativeTypeName("ULONG")] uint celt);

        [VtblIndex(7)]
        HRESULT Reset();

        [VtblIndex(8)]
        HRESULT Clone(IDiaEnumNamedStreams** ppenum);
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

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> Next;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> Skip;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Reset;

        [NativeTypeName("HRESULT (IDiaEnumNamedStreams **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDiaEnumNamedStreams**, int> Clone;
    }
}
