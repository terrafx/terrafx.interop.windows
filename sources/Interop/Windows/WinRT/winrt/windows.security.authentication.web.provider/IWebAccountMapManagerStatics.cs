// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.authentication.web.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IWebAccountMapManagerStatics.xml' path='doc/member[@name="IWebAccountMapManagerStatics"]/*' />
[Guid("E8FA446F-3A1B-48A4-8E90-1E59CA6F54DB")]
[NativeTypeName("struct IWebAccountMapManagerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWebAccountMapManagerStatics : IWebAccountMapManagerStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWebAccountMapManagerStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountMapManagerStatics*, Guid*, void**, int>)(lpVtbl[0]))((IWebAccountMapManagerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountMapManagerStatics*, uint>)(lpVtbl[1]))((IWebAccountMapManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountMapManagerStatics*, uint>)(lpVtbl[2]))((IWebAccountMapManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountMapManagerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IWebAccountMapManagerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountMapManagerStatics*, HSTRING*, int>)(lpVtbl[4]))((IWebAccountMapManagerStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountMapManagerStatics*, TrustLevel*, int>)(lpVtbl[5]))((IWebAccountMapManagerStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IWebAccountMapManagerStatics.xml' path='doc/member[@name="IWebAccountMapManagerStatics.AddWebAccountWithScopeAndMapAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AddWebAccountWithScopeAndMapAsync(HSTRING webAccountId, HSTRING webAccountUserName, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_HSTRING_t *")] IMapView<HSTRING, HSTRING>* props, [NativeTypeName("ABI::Windows::Security::Authentication::Web::Provider::WebAccountScope")] WebAccountScope scope, HSTRING perUserWebAccountId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CWebAccount_t **")] IAsyncOperation<Pointer<IWebAccount>>** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountMapManagerStatics*, HSTRING, HSTRING, IMapView<HSTRING, HSTRING>*, WebAccountScope, HSTRING, IAsyncOperation<Pointer<IWebAccount>>**, int>)(lpVtbl[6]))((IWebAccountMapManagerStatics*)Unsafe.AsPointer(ref this), webAccountId, webAccountUserName, props, scope, perUserWebAccountId, asyncInfo);
    }

    /// <include file='IWebAccountMapManagerStatics.xml' path='doc/member[@name="IWebAccountMapManagerStatics.SetPerAppToPerUserAccountAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetPerAppToPerUserAccountAsync([NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")] IWebAccount* perAppAccount, HSTRING perUserWebAccountId, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountMapManagerStatics*, IWebAccount*, HSTRING, IAsyncAction**, int>)(lpVtbl[7]))((IWebAccountMapManagerStatics*)Unsafe.AsPointer(ref this), perAppAccount, perUserWebAccountId, asyncInfo);
    }

    /// <include file='IWebAccountMapManagerStatics.xml' path='doc/member[@name="IWebAccountMapManagerStatics.GetPerUserFromPerAppAccountAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetPerUserFromPerAppAccountAsync([NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")] IWebAccount* perAppAccount, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CWebAccount_t **")] IAsyncOperation<Pointer<IWebAccount>>** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountMapManagerStatics*, IWebAccount*, IAsyncOperation<Pointer<IWebAccount>>**, int>)(lpVtbl[8]))((IWebAccountMapManagerStatics*)Unsafe.AsPointer(ref this), perAppAccount, asyncInfo);
    }

    /// <include file='IWebAccountMapManagerStatics.xml' path='doc/member[@name="IWebAccountMapManagerStatics.ClearPerUserFromPerAppAccountAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ClearPerUserFromPerAppAccountAsync([NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")] IWebAccount* perAppAccount, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountMapManagerStatics*, IWebAccount*, IAsyncAction**, int>)(lpVtbl[9]))((IWebAccountMapManagerStatics*)Unsafe.AsPointer(ref this), perAppAccount, asyncInfo);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT AddWebAccountWithScopeAndMapAsync(HSTRING webAccountId, HSTRING webAccountUserName, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_HSTRING_t *")] IMapView<HSTRING, HSTRING>* props, [NativeTypeName("ABI::Windows::Security::Authentication::Web::Provider::WebAccountScope")] WebAccountScope scope, HSTRING perUserWebAccountId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CWebAccount_t **")] IAsyncOperation<Pointer<IWebAccount>>** asyncInfo);

        [VtblIndex(7)]
        HRESULT SetPerAppToPerUserAccountAsync([NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")] IWebAccount* perAppAccount, HSTRING perUserWebAccountId, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo);

        [VtblIndex(8)]
        HRESULT GetPerUserFromPerAppAccountAsync([NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")] IWebAccount* perAppAccount, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CWebAccount_t **")] IAsyncOperation<Pointer<IWebAccount>>** asyncInfo);

        [VtblIndex(9)]
        HRESULT ClearPerUserFromPerAppAccountAsync([NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")] IWebAccount* perAppAccount, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo);
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

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_HSTRING_t *, ABI::Windows::Security::Authentication::Web::Provider::WebAccountScope, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CWebAccount_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IMapView<HSTRING, HSTRING>*, WebAccountScope, HSTRING, IAsyncOperation<Pointer<IWebAccount>>**, int> AddWebAccountWithScopeAndMapAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Credentials::IWebAccount *, HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWebAccount*, HSTRING, IAsyncAction**, int> SetPerAppToPerUserAccountAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Credentials::IWebAccount *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CWebAccount_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWebAccount*, IAsyncOperation<Pointer<IWebAccount>>**, int> GetPerUserFromPerAppAccountAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Credentials::IWebAccount *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWebAccount*, IAsyncAction**, int> ClearPerUserFromPerAppAccountAsync;
    }
}
