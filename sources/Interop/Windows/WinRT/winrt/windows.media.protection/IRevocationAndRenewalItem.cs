// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.protection.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRevocationAndRenewalItem.xml' path='doc/member[@name="IRevocationAndRenewalItem"]/*' />
[Guid("3099C20C-3CF0-49EA-902D-CAF32D2DDE2C")]
[NativeTypeName("struct IRevocationAndRenewalItem : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRevocationAndRenewalItem : IRevocationAndRenewalItem.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRevocationAndRenewalItem));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRevocationAndRenewalItem*, Guid*, void**, int>)(lpVtbl[0]))((IRevocationAndRenewalItem*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRevocationAndRenewalItem*, uint>)(lpVtbl[1]))((IRevocationAndRenewalItem*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRevocationAndRenewalItem*, uint>)(lpVtbl[2]))((IRevocationAndRenewalItem*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IRevocationAndRenewalItem*, uint*, Guid**, int>)(lpVtbl[3]))((IRevocationAndRenewalItem*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IRevocationAndRenewalItem*, HSTRING*, int>)(lpVtbl[4]))((IRevocationAndRenewalItem*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IRevocationAndRenewalItem*, TrustLevel*, int>)(lpVtbl[5]))((IRevocationAndRenewalItem*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IRevocationAndRenewalItem.xml' path='doc/member[@name="IRevocationAndRenewalItem.get_Reasons"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Reasons([NativeTypeName("ABI::Windows::Media::Protection::RevocationAndRenewalReasons *")] RevocationAndRenewalReasons* reasons)
    {
        return ((delegate* unmanaged[MemberFunction]<IRevocationAndRenewalItem*, RevocationAndRenewalReasons*, int>)(lpVtbl[6]))((IRevocationAndRenewalItem*)Unsafe.AsPointer(ref this), reasons);
    }

    /// <include file='IRevocationAndRenewalItem.xml' path='doc/member[@name="IRevocationAndRenewalItem.get_HeaderHash"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_HeaderHash(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRevocationAndRenewalItem*, HSTRING*, int>)(lpVtbl[7]))((IRevocationAndRenewalItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRevocationAndRenewalItem.xml' path='doc/member[@name="IRevocationAndRenewalItem.get_PublicKeyHash"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_PublicKeyHash(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRevocationAndRenewalItem*, HSTRING*, int>)(lpVtbl[8]))((IRevocationAndRenewalItem*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRevocationAndRenewalItem.xml' path='doc/member[@name="IRevocationAndRenewalItem.get_Name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Name(HSTRING* name)
    {
        return ((delegate* unmanaged[MemberFunction]<IRevocationAndRenewalItem*, HSTRING*, int>)(lpVtbl[9]))((IRevocationAndRenewalItem*)Unsafe.AsPointer(ref this), name);
    }

    /// <include file='IRevocationAndRenewalItem.xml' path='doc/member[@name="IRevocationAndRenewalItem.get_RenewalId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_RenewalId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRevocationAndRenewalItem*, HSTRING*, int>)(lpVtbl[10]))((IRevocationAndRenewalItem*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Reasons([NativeTypeName("ABI::Windows::Media::Protection::RevocationAndRenewalReasons *")] RevocationAndRenewalReasons* reasons);

        [VtblIndex(7)]
        HRESULT get_HeaderHash(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_PublicKeyHash(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_Name(HSTRING* name);

        [VtblIndex(10)]
        HRESULT get_RenewalId(HSTRING* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Protection::RevocationAndRenewalReasons *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, RevocationAndRenewalReasons*, int> get_Reasons;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_HeaderHash;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_PublicKeyHash;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Name;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_RenewalId;
    }
}
