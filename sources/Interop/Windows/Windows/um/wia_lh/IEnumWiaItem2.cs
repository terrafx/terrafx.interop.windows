// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wia_lh.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IEnumWiaItem2.xml' path='doc/member[@name="IEnumWiaItem2"]/*' />
[Guid("59970AF4-CD0D-44D9-AB24-52295630E582")]
[NativeTypeName("struct IEnumWiaItem2 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IEnumWiaItem2 : IEnumWiaItem2.Interface, INativeGuid
{
    /// <include file='IEnumWiaItem2.xml' path='doc/member[@name="IEnumWiaItem2.INativeGuid.NativeGuid"]/*' />
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IEnumWiaItem2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IEnumWiaItem2*, Guid*, void**, int>)(lpVtbl[0]))((IEnumWiaItem2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IEnumWiaItem2*, uint>)(lpVtbl[1]))((IEnumWiaItem2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IEnumWiaItem2*, uint>)(lpVtbl[2]))((IEnumWiaItem2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumWiaItem2.xml' path='doc/member[@name="IEnumWiaItem2.Next"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Next([NativeTypeName("ULONG")] uint cElt, IWiaItem2** ppIWiaItem2, [NativeTypeName("ULONG *")] uint* pcEltFetched)
    {
        return ((delegate* unmanaged[MemberFunction]<IEnumWiaItem2*, uint, IWiaItem2**, uint*, int>)(lpVtbl[3]))((IEnumWiaItem2*)Unsafe.AsPointer(ref this), cElt, ppIWiaItem2, pcEltFetched);
    }

    /// <include file='IEnumWiaItem2.xml' path='doc/member[@name="IEnumWiaItem2.Skip"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Skip([NativeTypeName("ULONG")] uint cElt)
    {
        return ((delegate* unmanaged[MemberFunction]<IEnumWiaItem2*, uint, int>)(lpVtbl[4]))((IEnumWiaItem2*)Unsafe.AsPointer(ref this), cElt);
    }

    /// <include file='IEnumWiaItem2.xml' path='doc/member[@name="IEnumWiaItem2.Reset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged[MemberFunction]<IEnumWiaItem2*, int>)(lpVtbl[5]))((IEnumWiaItem2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumWiaItem2.xml' path='doc/member[@name="IEnumWiaItem2.Clone"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Clone(IEnumWiaItem2** ppIEnum)
    {
        return ((delegate* unmanaged[MemberFunction]<IEnumWiaItem2*, IEnumWiaItem2**, int>)(lpVtbl[6]))((IEnumWiaItem2*)Unsafe.AsPointer(ref this), ppIEnum);
    }

    /// <include file='IEnumWiaItem2.xml' path='doc/member[@name="IEnumWiaItem2.GetCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetCount([NativeTypeName("ULONG *")] uint* cElt)
    {
        return ((delegate* unmanaged[MemberFunction]<IEnumWiaItem2*, uint*, int>)(lpVtbl[7]))((IEnumWiaItem2*)Unsafe.AsPointer(ref this), cElt);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Next([NativeTypeName("ULONG")] uint cElt, IWiaItem2** ppIWiaItem2, [NativeTypeName("ULONG *")] uint* pcEltFetched);

        [VtblIndex(4)]
        HRESULT Skip([NativeTypeName("ULONG")] uint cElt);

        [VtblIndex(5)]
        HRESULT Reset();

        [VtblIndex(6)]
        HRESULT Clone(IEnumWiaItem2** ppIEnum);

        [VtblIndex(7)]
        HRESULT GetCount([NativeTypeName("ULONG *")] uint* cElt);
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

        [NativeTypeName("HRESULT (ULONG, IWiaItem2 **, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IWiaItem2**, uint*, int> Next;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> Skip;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Reset;

        [NativeTypeName("HRESULT (IEnumWiaItem2 **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEnumWiaItem2**, int> Clone;

        [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetCount;
    }
}
