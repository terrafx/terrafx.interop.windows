// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.userdataaccounts.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IUserDataAccountPartnerAccountInfo.xml' path='doc/member[@name="IUserDataAccountPartnerAccountInfo"]/*' />
[Guid("5F200037-F6EF-4EC3-8630-012C59C1149F")]
[NativeTypeName("struct IUserDataAccountPartnerAccountInfo : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IUserDataAccountPartnerAccountInfo : IUserDataAccountPartnerAccountInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUserDataAccountPartnerAccountInfo));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountPartnerAccountInfo*, Guid*, void**, int>)(lpVtbl[0]))((IUserDataAccountPartnerAccountInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountPartnerAccountInfo*, uint>)(lpVtbl[1]))((IUserDataAccountPartnerAccountInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountPartnerAccountInfo*, uint>)(lpVtbl[2]))((IUserDataAccountPartnerAccountInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountPartnerAccountInfo*, uint*, Guid**, int>)(lpVtbl[3]))((IUserDataAccountPartnerAccountInfo*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountPartnerAccountInfo*, HSTRING*, int>)(lpVtbl[4]))((IUserDataAccountPartnerAccountInfo*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountPartnerAccountInfo*, TrustLevel*, int>)(lpVtbl[5]))((IUserDataAccountPartnerAccountInfo*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IUserDataAccountPartnerAccountInfo.xml' path='doc/member[@name="IUserDataAccountPartnerAccountInfo.get_DisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountPartnerAccountInfo*, HSTRING*, int>)(lpVtbl[6]))((IUserDataAccountPartnerAccountInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataAccountPartnerAccountInfo.xml' path='doc/member[@name="IUserDataAccountPartnerAccountInfo.get_Priority"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Priority([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountPartnerAccountInfo*, uint*, int>)(lpVtbl[7]))((IUserDataAccountPartnerAccountInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataAccountPartnerAccountInfo.xml' path='doc/member[@name="IUserDataAccountPartnerAccountInfo.get_AccountKind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_AccountKind([NativeTypeName("ABI::Windows::ApplicationModel::UserDataAccounts::Provider::UserDataAccountProviderPartnerAccountKind *")] UserDataAccountProviderPartnerAccountKind* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountPartnerAccountInfo*, UserDataAccountProviderPartnerAccountKind*, int>)(lpVtbl[8]))((IUserDataAccountPartnerAccountInfo*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DisplayName(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_Priority([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(8)]
        HRESULT get_AccountKind([NativeTypeName("ABI::Windows::ApplicationModel::UserDataAccounts::Provider::UserDataAccountProviderPartnerAccountKind *")] UserDataAccountProviderPartnerAccountKind* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DisplayName;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_Priority;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::UserDataAccounts::Provider::UserDataAccountProviderPartnerAccountKind *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, UserDataAccountProviderPartnerAccountKind*, int> get_AccountKind;
    }
}
