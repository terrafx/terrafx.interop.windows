// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPrintPageRangeOptions.xml' path='doc/member[@name="IPrintPageRangeOptions"]/*' />
[Guid("CE6DB728-1357-46B2-A923-79F995F448FC")]
[NativeTypeName("struct IPrintPageRangeOptions : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintPageRangeOptions : IPrintPageRangeOptions.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPrintPageRangeOptions));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintPageRangeOptions*, Guid*, void**, int>)(lpVtbl[0]))((IPrintPageRangeOptions*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintPageRangeOptions*, uint>)(lpVtbl[1]))((IPrintPageRangeOptions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintPageRangeOptions*, uint>)(lpVtbl[2]))((IPrintPageRangeOptions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintPageRangeOptions*, uint*, Guid**, int>)(lpVtbl[3]))((IPrintPageRangeOptions*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintPageRangeOptions*, HSTRING*, int>)(lpVtbl[4]))((IPrintPageRangeOptions*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintPageRangeOptions*, TrustLevel*, int>)(lpVtbl[5]))((IPrintPageRangeOptions*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPrintPageRangeOptions.xml' path='doc/member[@name="IPrintPageRangeOptions.put_AllowAllPages"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_AllowAllPages([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintPageRangeOptions*, byte, int>)(lpVtbl[6]))((IPrintPageRangeOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintPageRangeOptions.xml' path='doc/member[@name="IPrintPageRangeOptions.get_AllowAllPages"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_AllowAllPages([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintPageRangeOptions*, byte*, int>)(lpVtbl[7]))((IPrintPageRangeOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintPageRangeOptions.xml' path='doc/member[@name="IPrintPageRangeOptions.put_AllowCurrentPage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_AllowCurrentPage([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintPageRangeOptions*, byte, int>)(lpVtbl[8]))((IPrintPageRangeOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintPageRangeOptions.xml' path='doc/member[@name="IPrintPageRangeOptions.get_AllowCurrentPage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_AllowCurrentPage([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintPageRangeOptions*, byte*, int>)(lpVtbl[9]))((IPrintPageRangeOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintPageRangeOptions.xml' path='doc/member[@name="IPrintPageRangeOptions.put_AllowCustomSetOfPages"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_AllowCustomSetOfPages([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintPageRangeOptions*, byte, int>)(lpVtbl[10]))((IPrintPageRangeOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintPageRangeOptions.xml' path='doc/member[@name="IPrintPageRangeOptions.get_AllowCustomSetOfPages"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_AllowCustomSetOfPages([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintPageRangeOptions*, byte*, int>)(lpVtbl[11]))((IPrintPageRangeOptions*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_AllowAllPages([NativeTypeName("boolean")] byte value);

        [VtblIndex(7)]
        HRESULT get_AllowAllPages([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT put_AllowCurrentPage([NativeTypeName("boolean")] byte value);

        [VtblIndex(9)]
        HRESULT get_AllowCurrentPage([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        HRESULT put_AllowCustomSetOfPages([NativeTypeName("boolean")] byte value);

        [VtblIndex(11)]
        HRESULT get_AllowCustomSetOfPages([NativeTypeName("boolean *")] byte* value);
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_AllowAllPages;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_AllowAllPages;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_AllowCurrentPage;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_AllowCurrentPage;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_AllowCustomSetOfPages;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_AllowCustomSetOfPages;
    }
}
