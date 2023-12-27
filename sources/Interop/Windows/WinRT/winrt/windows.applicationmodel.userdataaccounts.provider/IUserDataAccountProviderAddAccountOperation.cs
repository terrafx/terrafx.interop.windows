// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.userdataaccounts.provider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IUserDataAccountProviderAddAccountOperation.xml' path='doc/member[@name="IUserDataAccountProviderAddAccountOperation"]/*' />
[Guid("B9C72530-3F84-4B5D-8EAA-45E97AA842ED")]
[NativeTypeName("struct IUserDataAccountProviderAddAccountOperation : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IUserDataAccountProviderAddAccountOperation : IUserDataAccountProviderAddAccountOperation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUserDataAccountProviderAddAccountOperation));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountProviderAddAccountOperation*, Guid*, void**, int>)(lpVtbl[0]))((IUserDataAccountProviderAddAccountOperation*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountProviderAddAccountOperation*, uint>)(lpVtbl[1]))((IUserDataAccountProviderAddAccountOperation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountProviderAddAccountOperation*, uint>)(lpVtbl[2]))((IUserDataAccountProviderAddAccountOperation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountProviderAddAccountOperation*, uint*, Guid**, int>)(lpVtbl[3]))((IUserDataAccountProviderAddAccountOperation*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountProviderAddAccountOperation*, HSTRING*, int>)(lpVtbl[4]))((IUserDataAccountProviderAddAccountOperation*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountProviderAddAccountOperation*, TrustLevel*, int>)(lpVtbl[5]))((IUserDataAccountProviderAddAccountOperation*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IUserDataAccountProviderAddAccountOperation.xml' path='doc/member[@name="IUserDataAccountProviderAddAccountOperation.get_ContentKinds"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ContentKinds([NativeTypeName("ABI::Windows::ApplicationModel::UserDataAccounts::UserDataAccountContentKinds *")] UserDataAccountContentKinds* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountProviderAddAccountOperation*, UserDataAccountContentKinds*, int>)(lpVtbl[6]))((IUserDataAccountProviderAddAccountOperation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataAccountProviderAddAccountOperation.xml' path='doc/member[@name="IUserDataAccountProviderAddAccountOperation.get_PartnerAccountInfos"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_PartnerAccountInfos([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CApplicationModel__CUserDataAccounts__CProvider__CUserDataAccountPartnerAccountInfo_t **")] IVectorView<Pointer<IUserDataAccountPartnerAccountInfo>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountProviderAddAccountOperation*, IVectorView<Pointer<IUserDataAccountPartnerAccountInfo>>**, int>)(lpVtbl[7]))((IUserDataAccountProviderAddAccountOperation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUserDataAccountProviderAddAccountOperation.xml' path='doc/member[@name="IUserDataAccountProviderAddAccountOperation.ReportCompleted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ReportCompleted(HSTRING userDataAccountId)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountProviderAddAccountOperation*, HSTRING, int>)(lpVtbl[8]))((IUserDataAccountProviderAddAccountOperation*)Unsafe.AsPointer(ref this), userDataAccountId);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ContentKinds([NativeTypeName("ABI::Windows::ApplicationModel::UserDataAccounts::UserDataAccountContentKinds *")] UserDataAccountContentKinds* value);

        [VtblIndex(7)]
        HRESULT get_PartnerAccountInfos([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CApplicationModel__CUserDataAccounts__CProvider__CUserDataAccountPartnerAccountInfo_t **")] IVectorView<Pointer<IUserDataAccountPartnerAccountInfo>>** value);

        [VtblIndex(8)]
        HRESULT ReportCompleted(HSTRING userDataAccountId);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::UserDataAccounts::UserDataAccountContentKinds *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, UserDataAccountContentKinds*, int> get_ContentKinds;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CApplicationModel__CUserDataAccounts__CProvider__CUserDataAccountPartnerAccountInfo_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IUserDataAccountPartnerAccountInfo>>**, int> get_PartnerAccountInfos;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> ReportCompleted;
    }
}
