// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPhoneCallHistoryEntryAddress.xml' path='doc/member[@name="IPhoneCallHistoryEntryAddress"]/*' />
[Guid("30F159DA-3955-4042-84E6-66EEBF82E67F")]
[NativeTypeName("struct IPhoneCallHistoryEntryAddress : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPhoneCallHistoryEntryAddress : IPhoneCallHistoryEntryAddress.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IPhoneCallHistoryEntryAddress);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntryAddress*, Guid*, void**, int>)(lpVtbl[0]))((IPhoneCallHistoryEntryAddress*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntryAddress*, uint>)(lpVtbl[1]))((IPhoneCallHistoryEntryAddress*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntryAddress*, uint>)(lpVtbl[2]))((IPhoneCallHistoryEntryAddress*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntryAddress*, uint*, Guid**, int>)(lpVtbl[3]))((IPhoneCallHistoryEntryAddress*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntryAddress*, HSTRING*, int>)(lpVtbl[4]))((IPhoneCallHistoryEntryAddress*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntryAddress*, TrustLevel*, int>)(lpVtbl[5]))((IPhoneCallHistoryEntryAddress*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPhoneCallHistoryEntryAddress.xml' path='doc/member[@name="IPhoneCallHistoryEntryAddress.get_ContactId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ContactId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntryAddress*, HSTRING*, int>)(lpVtbl[6]))((IPhoneCallHistoryEntryAddress*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCallHistoryEntryAddress.xml' path='doc/member[@name="IPhoneCallHistoryEntryAddress.put_ContactId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_ContactId(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntryAddress*, HSTRING, int>)(lpVtbl[7]))((IPhoneCallHistoryEntryAddress*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCallHistoryEntryAddress.xml' path='doc/member[@name="IPhoneCallHistoryEntryAddress.get_DisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_DisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntryAddress*, HSTRING*, int>)(lpVtbl[8]))((IPhoneCallHistoryEntryAddress*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCallHistoryEntryAddress.xml' path='doc/member[@name="IPhoneCallHistoryEntryAddress.put_DisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_DisplayName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntryAddress*, HSTRING, int>)(lpVtbl[9]))((IPhoneCallHistoryEntryAddress*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCallHistoryEntryAddress.xml' path='doc/member[@name="IPhoneCallHistoryEntryAddress.get_RawAddress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_RawAddress(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntryAddress*, HSTRING*, int>)(lpVtbl[10]))((IPhoneCallHistoryEntryAddress*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCallHistoryEntryAddress.xml' path='doc/member[@name="IPhoneCallHistoryEntryAddress.put_RawAddress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_RawAddress(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntryAddress*, HSTRING, int>)(lpVtbl[11]))((IPhoneCallHistoryEntryAddress*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCallHistoryEntryAddress.xml' path='doc/member[@name="IPhoneCallHistoryEntryAddress.get_RawAddressKind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_RawAddressKind([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallHistoryEntryRawAddressKind *")] PhoneCallHistoryEntryRawAddressKind* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntryAddress*, PhoneCallHistoryEntryRawAddressKind*, int>)(lpVtbl[12]))((IPhoneCallHistoryEntryAddress*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCallHistoryEntryAddress.xml' path='doc/member[@name="IPhoneCallHistoryEntryAddress.put_RawAddressKind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_RawAddressKind([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallHistoryEntryRawAddressKind")] PhoneCallHistoryEntryRawAddressKind value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntryAddress*, PhoneCallHistoryEntryRawAddressKind, int>)(lpVtbl[13]))((IPhoneCallHistoryEntryAddress*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ContactId(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_ContactId(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_DisplayName(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_DisplayName(HSTRING value);

        [VtblIndex(10)]
        HRESULT get_RawAddress(HSTRING* value);

        [VtblIndex(11)]
        HRESULT put_RawAddress(HSTRING value);

        [VtblIndex(12)]
        HRESULT get_RawAddressKind([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallHistoryEntryRawAddressKind *")] PhoneCallHistoryEntryRawAddressKind* value);

        [VtblIndex(13)]
        HRESULT put_RawAddressKind([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallHistoryEntryRawAddressKind")] PhoneCallHistoryEntryRawAddressKind value);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ContactId;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_ContactId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DisplayName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_DisplayName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_RawAddress;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_RawAddress;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneCallHistoryEntryRawAddressKind *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PhoneCallHistoryEntryRawAddressKind*, int> get_RawAddressKind;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneCallHistoryEntryRawAddressKind) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PhoneCallHistoryEntryRawAddressKind, int> put_RawAddressKind;
    }
}
