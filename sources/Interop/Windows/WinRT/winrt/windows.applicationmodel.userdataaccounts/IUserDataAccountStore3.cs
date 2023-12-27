// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.userdataaccounts.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IUserDataAccountStore3.xml' path='doc/member[@name="IUserDataAccountStore3"]/*' />
[Guid("8142C094-F3C9-478B-B117-6585BEBB6789")]
[NativeTypeName("struct IUserDataAccountStore3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IUserDataAccountStore3 : IUserDataAccountStore3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUserDataAccountStore3));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountStore3*, Guid*, void**, int>)(lpVtbl[0]))((IUserDataAccountStore3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountStore3*, uint>)(lpVtbl[1]))((IUserDataAccountStore3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountStore3*, uint>)(lpVtbl[2]))((IUserDataAccountStore3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountStore3*, uint*, Guid**, int>)(lpVtbl[3]))((IUserDataAccountStore3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountStore3*, HSTRING*, int>)(lpVtbl[4]))((IUserDataAccountStore3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountStore3*, TrustLevel*, int>)(lpVtbl[5]))((IUserDataAccountStore3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IUserDataAccountStore3.xml' path='doc/member[@name="IUserDataAccountStore3.CreateAccountWithPackageRelativeAppIdAndEnterpriseIdAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateAccountWithPackageRelativeAppIdAndEnterpriseIdAsync(HSTRING userDisplayName, HSTRING packageRelativeAppId, HSTRING enterpriseId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CUserDataAccounts__CUserDataAccount_t **")] IAsyncOperation<Pointer<IUserDataAccount>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IUserDataAccountStore3*, HSTRING, HSTRING, HSTRING, IAsyncOperation<Pointer<IUserDataAccount>>**, int>)(lpVtbl[6]))((IUserDataAccountStore3*)Unsafe.AsPointer(ref this), userDisplayName, packageRelativeAppId, enterpriseId, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateAccountWithPackageRelativeAppIdAndEnterpriseIdAsync(HSTRING userDisplayName, HSTRING packageRelativeAppId, HSTRING enterpriseId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CUserDataAccounts__CUserDataAccount_t **")] IAsyncOperation<Pointer<IUserDataAccount>>** result);
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

        [NativeTypeName("HRESULT (HSTRING, HSTRING, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CUserDataAccounts__CUserDataAccount_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, HSTRING, IAsyncOperation<Pointer<IUserDataAccount>>**, int> CreateAccountWithPackageRelativeAppIdAndEnterpriseIdAsync;
    }
}
