// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.userdataaccounts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IUserDataAccountManagerForUser.xml' path='doc/member[@name="IUserDataAccountManagerForUser"]/*' />
[Guid("56A6E8DB-DB8F-41AB-A65F-8C5971AAC982")]
[NativeTypeName("struct IUserDataAccountManagerForUser : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IUserDataAccountManagerForUser : IUserDataAccountManagerForUser.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUserDataAccountManagerForUser));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountManagerForUser*, Guid*, void**, int>)(lpVtbl[0]))((IUserDataAccountManagerForUser*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountManagerForUser*, uint>)(lpVtbl[1]))((IUserDataAccountManagerForUser*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountManagerForUser*, uint>)(lpVtbl[2]))((IUserDataAccountManagerForUser*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountManagerForUser*, uint*, Guid**, int>)(lpVtbl[3]))((IUserDataAccountManagerForUser*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountManagerForUser*, HSTRING*, int>)(lpVtbl[4]))((IUserDataAccountManagerForUser*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountManagerForUser*, TrustLevel*, int>)(lpVtbl[5]))((IUserDataAccountManagerForUser*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IUserDataAccountManagerForUser.xml' path='doc/member[@name="IUserDataAccountManagerForUser.RequestStoreAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RequestStoreAsync([NativeTypeName("ABI::Windows::ApplicationModel::UserDataAccounts::UserDataAccountStoreAccessType")] UserDataAccountStoreAccessType storeAccessType, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CUserDataAccounts__CUserDataAccountStore_t **")] IAsyncOperation<Pointer<IUserDataAccountStore>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountManagerForUser*, UserDataAccountStoreAccessType, IAsyncOperation<Pointer<IUserDataAccountStore>>**, int>)(lpVtbl[6]))((IUserDataAccountManagerForUser*)Unsafe.AsPointer(ref this), storeAccessType, result);
    }

    /// <include file='IUserDataAccountManagerForUser.xml' path='doc/member[@name="IUserDataAccountManagerForUser.get_User"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_User([NativeTypeName("ABI::Windows::System::IUser **")] IUser** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountManagerForUser*, IUser**, int>)(lpVtbl[7]))((IUserDataAccountManagerForUser*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT RequestStoreAsync([NativeTypeName("ABI::Windows::ApplicationModel::UserDataAccounts::UserDataAccountStoreAccessType")] UserDataAccountStoreAccessType storeAccessType, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CUserDataAccounts__CUserDataAccountStore_t **")] IAsyncOperation<Pointer<IUserDataAccountStore>>** result);

        [VtblIndex(7)]
        HRESULT get_User([NativeTypeName("ABI::Windows::System::IUser **")] IUser** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::UserDataAccounts::UserDataAccountStoreAccessType, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CUserDataAccounts__CUserDataAccountStore_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, UserDataAccountStoreAccessType, IAsyncOperation<Pointer<IUserDataAccountStore>>**, int> RequestStoreAsync;

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUser**, int> get_User;
    }
}
