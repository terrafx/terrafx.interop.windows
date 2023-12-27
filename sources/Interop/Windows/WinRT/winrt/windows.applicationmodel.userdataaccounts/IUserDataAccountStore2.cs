// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.userdataaccounts.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IUserDataAccountStore2.xml' path='doc/member[@name="IUserDataAccountStore2"]/*' />
[Guid("B1E0AEF7-9560-4631-8AF0-061D30161469")]
[NativeTypeName("struct IUserDataAccountStore2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IUserDataAccountStore2 : IUserDataAccountStore2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUserDataAccountStore2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountStore2*, Guid*, void**, int>)(lpVtbl[0]))((IUserDataAccountStore2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountStore2*, uint>)(lpVtbl[1]))((IUserDataAccountStore2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountStore2*, uint>)(lpVtbl[2]))((IUserDataAccountStore2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountStore2*, uint*, Guid**, int>)(lpVtbl[3]))((IUserDataAccountStore2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountStore2*, HSTRING*, int>)(lpVtbl[4]))((IUserDataAccountStore2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountStore2*, TrustLevel*, int>)(lpVtbl[5]))((IUserDataAccountStore2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IUserDataAccountStore2.xml' path='doc/member[@name="IUserDataAccountStore2.CreateAccountWithPackageRelativeAppIdAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateAccountWithPackageRelativeAppIdAsync(HSTRING userDisplayName, HSTRING packageRelativeAppId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CUserDataAccounts__CUserDataAccount_t **")] IAsyncOperation<Pointer<IUserDataAccount>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountStore2*, HSTRING, HSTRING, IAsyncOperation<Pointer<IUserDataAccount>>**, int>)(lpVtbl[6]))((IUserDataAccountStore2*)Unsafe.AsPointer(ref this), userDisplayName, packageRelativeAppId, result);
    }

    /// <include file='IUserDataAccountStore2.xml' path='doc/member[@name="IUserDataAccountStore2.add_StoreChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT add_StoreChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CUserDataAccounts__CUserDataAccountStore_Windows__CApplicationModel__CUserDataAccounts__CUserDataAccountStoreChangedEventArgs_t *")] ITypedEventHandler<Pointer<IUserDataAccountStore>, Pointer<IUserDataAccountStoreChangedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountStore2*, ITypedEventHandler<Pointer<IUserDataAccountStore>, Pointer<IUserDataAccountStoreChangedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[7]))((IUserDataAccountStore2*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IUserDataAccountStore2.xml' path='doc/member[@name="IUserDataAccountStore2.remove_StoreChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT remove_StoreChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountStore2*, EventRegistrationToken, int>)(lpVtbl[8]))((IUserDataAccountStore2*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateAccountWithPackageRelativeAppIdAsync(HSTRING userDisplayName, HSTRING packageRelativeAppId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CUserDataAccounts__CUserDataAccount_t **")] IAsyncOperation<Pointer<IUserDataAccount>>** result);

        [VtblIndex(7)]
        HRESULT add_StoreChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CUserDataAccounts__CUserDataAccountStore_Windows__CApplicationModel__CUserDataAccounts__CUserDataAccountStoreChangedEventArgs_t *")] ITypedEventHandler<Pointer<IUserDataAccountStore>, Pointer<IUserDataAccountStoreChangedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(8)]
        HRESULT remove_StoreChanged(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CUserDataAccounts__CUserDataAccount_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IAsyncOperation<Pointer<IUserDataAccount>>**, int> CreateAccountWithPackageRelativeAppIdAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CUserDataAccounts__CUserDataAccountStore_Windows__CApplicationModel__CUserDataAccounts__CUserDataAccountStoreChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IUserDataAccountStore>, Pointer<IUserDataAccountStoreChangedEventArgs>>*, EventRegistrationToken*, int> add_StoreChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_StoreChanged;
    }
}
