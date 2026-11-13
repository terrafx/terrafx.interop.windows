// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wia_lh.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IEnumWiaItem.xml' path='doc/member[@name="IEnumWiaItem"]/*' />
[Guid("5E8383FC-3391-11D2-9A33-00C04FA36145")]
[NativeTypeName("struct IEnumWiaItem : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IEnumWiaItem : IEnumWiaItem.Interface, INativeGuid
{
    /// <include file='IEnumWiaItem.xml' path='doc/member[@name="IEnumWiaItem.INativeGuid.NativeGuid"]/*' />
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IEnumWiaItem);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IEnumWiaItem*, Guid*, void**, int>)(lpVtbl[0]))((IEnumWiaItem*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IEnumWiaItem*, uint>)(lpVtbl[1]))((IEnumWiaItem*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IEnumWiaItem*, uint>)(lpVtbl[2]))((IEnumWiaItem*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumWiaItem.xml' path='doc/member[@name="IEnumWiaItem.Next"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Next([NativeTypeName("ULONG")] uint celt, IWiaItem** ppIWiaItem, [NativeTypeName("ULONG *")] uint* pceltFetched)
    {
        return ((delegate* unmanaged[MemberFunction]<IEnumWiaItem*, uint, IWiaItem**, uint*, int>)(lpVtbl[3]))((IEnumWiaItem*)Unsafe.AsPointer(ref this), celt, ppIWiaItem, pceltFetched);
    }

    /// <include file='IEnumWiaItem.xml' path='doc/member[@name="IEnumWiaItem.Skip"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Skip([NativeTypeName("ULONG")] uint celt)
    {
        return ((delegate* unmanaged[MemberFunction]<IEnumWiaItem*, uint, int>)(lpVtbl[4]))((IEnumWiaItem*)Unsafe.AsPointer(ref this), celt);
    }

    /// <include file='IEnumWiaItem.xml' path='doc/member[@name="IEnumWiaItem.Reset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged[MemberFunction]<IEnumWiaItem*, int>)(lpVtbl[5]))((IEnumWiaItem*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumWiaItem.xml' path='doc/member[@name="IEnumWiaItem.Clone"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Clone(IEnumWiaItem** ppIEnum)
    {
        return ((delegate* unmanaged[MemberFunction]<IEnumWiaItem*, IEnumWiaItem**, int>)(lpVtbl[6]))((IEnumWiaItem*)Unsafe.AsPointer(ref this), ppIEnum);
    }

    /// <include file='IEnumWiaItem.xml' path='doc/member[@name="IEnumWiaItem.GetCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetCount([NativeTypeName("ULONG *")] uint* celt)
    {
        return ((delegate* unmanaged[MemberFunction]<IEnumWiaItem*, uint*, int>)(lpVtbl[7]))((IEnumWiaItem*)Unsafe.AsPointer(ref this), celt);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Next([NativeTypeName("ULONG")] uint celt, IWiaItem** ppIWiaItem, [NativeTypeName("ULONG *")] uint* pceltFetched);

        [VtblIndex(4)]
        HRESULT Skip([NativeTypeName("ULONG")] uint celt);

        [VtblIndex(5)]
        HRESULT Reset();

        [VtblIndex(6)]
        HRESULT Clone(IEnumWiaItem** ppIEnum);

        [VtblIndex(7)]
        HRESULT GetCount([NativeTypeName("ULONG *")] uint* celt);
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

        [NativeTypeName("HRESULT (ULONG, IWiaItem **, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IWiaItem**, uint*, int> Next;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> Skip;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Reset;

        [NativeTypeName("HRESULT (IEnumWiaItem **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEnumWiaItem**, int> Clone;

        [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetCount;
    }
}
