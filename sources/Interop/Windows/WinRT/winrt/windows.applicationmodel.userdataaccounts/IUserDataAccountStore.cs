// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.userdataaccounts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IUserDataAccountStore.xml' path='doc/member[@name="IUserDataAccountStore"]/*' />
[Guid("2073B0AD-7D0A-4E76-BF45-2368F978A59A")]
[NativeTypeName("struct IUserDataAccountStore : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IUserDataAccountStore : IUserDataAccountStore.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IUserDataAccountStore);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountStore*, Guid*, void**, int>)(lpVtbl[0]))((IUserDataAccountStore*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountStore*, uint>)(lpVtbl[1]))((IUserDataAccountStore*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountStore*, uint>)(lpVtbl[2]))((IUserDataAccountStore*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountStore*, uint*, Guid**, int>)(lpVtbl[3]))((IUserDataAccountStore*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountStore*, HSTRING*, int>)(lpVtbl[4]))((IUserDataAccountStore*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountStore*, TrustLevel*, int>)(lpVtbl[5]))((IUserDataAccountStore*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IUserDataAccountStore.xml' path='doc/member[@name="IUserDataAccountStore.FindAccountsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FindAccountsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CUserDataAccounts__CUserDataAccount_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IUserDataAccount>>>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountStore*, IAsyncOperation<Pointer<IVectorView<Pointer<IUserDataAccount>>>>**, int>)(lpVtbl[6]))((IUserDataAccountStore*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IUserDataAccountStore.xml' path='doc/member[@name="IUserDataAccountStore.GetAccountAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetAccountAsync(HSTRING id, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CUserDataAccounts__CUserDataAccount_t **")] IAsyncOperation<Pointer<IUserDataAccount>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountStore*, HSTRING, IAsyncOperation<Pointer<IUserDataAccount>>**, int>)(lpVtbl[7]))((IUserDataAccountStore*)Unsafe.AsPointer(ref this), id, result);
    }

    /// <include file='IUserDataAccountStore.xml' path='doc/member[@name="IUserDataAccountStore.CreateAccountAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateAccountAsync(HSTRING userDisplayName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CUserDataAccounts__CUserDataAccount_t **")] IAsyncOperation<Pointer<IUserDataAccount>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountStore*, HSTRING, IAsyncOperation<Pointer<IUserDataAccount>>**, int>)(lpVtbl[8]))((IUserDataAccountStore*)Unsafe.AsPointer(ref this), userDisplayName, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT FindAccountsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CUserDataAccounts__CUserDataAccount_t **")] IAsyncOperation<Pointer<IVectorView<Pointer<IUserDataAccount>>>>** result);

        [VtblIndex(7)]
        HRESULT GetAccountAsync(HSTRING id, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CUserDataAccounts__CUserDataAccount_t **")] IAsyncOperation<Pointer<IUserDataAccount>>** result);

        [VtblIndex(8)]
        HRESULT CreateAccountAsync(HSTRING userDisplayName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CUserDataAccounts__CUserDataAccount_t **")] IAsyncOperation<Pointer<IUserDataAccount>>** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CUserDataAccounts__CUserDataAccount_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IVectorView<Pointer<IUserDataAccount>>>>**, int> FindAccountsAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CUserDataAccounts__CUserDataAccount_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IUserDataAccount>>**, int> GetAccountAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CUserDataAccounts__CUserDataAccount_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IUserDataAccount>>**, int> CreateAccountAsync;
    }
}
