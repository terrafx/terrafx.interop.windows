// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.userdataaccounts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IUserDataAccountManagerStatics.xml' path='doc/member[@name="IUserDataAccountManagerStatics"]/*' />
[Guid("0D9B89EA-1928-4A20-86D5-3C737F7DC3B0")]
[NativeTypeName("struct IUserDataAccountManagerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IUserDataAccountManagerStatics : IUserDataAccountManagerStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUserDataAccountManagerStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountManagerStatics*, Guid*, void**, int>)(lpVtbl[0]))((IUserDataAccountManagerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountManagerStatics*, uint>)(lpVtbl[1]))((IUserDataAccountManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountManagerStatics*, uint>)(lpVtbl[2]))((IUserDataAccountManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountManagerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IUserDataAccountManagerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountManagerStatics*, HSTRING*, int>)(lpVtbl[4]))((IUserDataAccountManagerStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountManagerStatics*, TrustLevel*, int>)(lpVtbl[5]))((IUserDataAccountManagerStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IUserDataAccountManagerStatics.xml' path='doc/member[@name="IUserDataAccountManagerStatics.RequestStoreAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RequestStoreAsync([NativeTypeName("ABI::Windows::ApplicationModel::UserDataAccounts::UserDataAccountStoreAccessType")] UserDataAccountStoreAccessType storeAccessType, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CUserDataAccounts__CUserDataAccountStore_t **")] IAsyncOperation<Pointer<IUserDataAccountStore>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountManagerStatics*, UserDataAccountStoreAccessType, IAsyncOperation<Pointer<IUserDataAccountStore>>**, int>)(lpVtbl[6]))((IUserDataAccountManagerStatics*)Unsafe.AsPointer(ref this), storeAccessType, result);
    }

    /// <include file='IUserDataAccountManagerStatics.xml' path='doc/member[@name="IUserDataAccountManagerStatics.ShowAddAccountAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ShowAddAccountAsync([NativeTypeName("ABI::Windows::ApplicationModel::UserDataAccounts::UserDataAccountContentKinds")] UserDataAccountContentKinds contentKinds, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountManagerStatics*, UserDataAccountContentKinds, IAsyncOperation<HSTRING>**, int>)(lpVtbl[7]))((IUserDataAccountManagerStatics*)Unsafe.AsPointer(ref this), contentKinds, result);
    }

    /// <include file='IUserDataAccountManagerStatics.xml' path='doc/member[@name="IUserDataAccountManagerStatics.ShowAccountSettingsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ShowAccountSettingsAsync(HSTRING id, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountManagerStatics*, HSTRING, IAsyncAction**, int>)(lpVtbl[8]))((IUserDataAccountManagerStatics*)Unsafe.AsPointer(ref this), id, result);
    }

    /// <include file='IUserDataAccountManagerStatics.xml' path='doc/member[@name="IUserDataAccountManagerStatics.ShowAccountErrorResolverAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ShowAccountErrorResolverAsync(HSTRING id, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountManagerStatics*, HSTRING, IAsyncAction**, int>)(lpVtbl[9]))((IUserDataAccountManagerStatics*)Unsafe.AsPointer(ref this), id, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT RequestStoreAsync([NativeTypeName("ABI::Windows::ApplicationModel::UserDataAccounts::UserDataAccountStoreAccessType")] UserDataAccountStoreAccessType storeAccessType, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CUserDataAccounts__CUserDataAccountStore_t **")] IAsyncOperation<Pointer<IUserDataAccountStore>>** result);

        [VtblIndex(7)]
        HRESULT ShowAddAccountAsync([NativeTypeName("ABI::Windows::ApplicationModel::UserDataAccounts::UserDataAccountContentKinds")] UserDataAccountContentKinds contentKinds, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** result);

        [VtblIndex(8)]
        HRESULT ShowAccountSettingsAsync(HSTRING id, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result);

        [VtblIndex(9)]
        HRESULT ShowAccountErrorResolverAsync(HSTRING id, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::UserDataAccounts::UserDataAccountContentKinds, ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, UserDataAccountContentKinds, IAsyncOperation<HSTRING>**, int> ShowAddAccountAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncAction**, int> ShowAccountSettingsAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncAction**, int> ShowAccountErrorResolverAsync;
    }
}
