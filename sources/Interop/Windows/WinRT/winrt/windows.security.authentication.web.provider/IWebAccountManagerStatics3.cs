// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.authentication.web.provider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IWebAccountManagerStatics3.xml' path='doc/member[@name="IWebAccountManagerStatics3"]/*' />
[Guid("DD4523A6-8A4F-4AA2-B15E-03F550AF1359")]
[NativeTypeName("struct IWebAccountManagerStatics3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWebAccountManagerStatics3 : IWebAccountManagerStatics3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWebAccountManagerStatics3));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountManagerStatics3*, Guid*, void**, int>)(lpVtbl[0]))((IWebAccountManagerStatics3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountManagerStatics3*, uint>)(lpVtbl[1]))((IWebAccountManagerStatics3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountManagerStatics3*, uint>)(lpVtbl[2]))((IWebAccountManagerStatics3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountManagerStatics3*, uint*, Guid**, int>)(lpVtbl[3]))((IWebAccountManagerStatics3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountManagerStatics3*, HSTRING*, int>)(lpVtbl[4]))((IWebAccountManagerStatics3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountManagerStatics3*, TrustLevel*, int>)(lpVtbl[5]))((IWebAccountManagerStatics3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IWebAccountManagerStatics3.xml' path='doc/member[@name="IWebAccountManagerStatics3.FindAllProviderWebAccountsForUserAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FindAllProviderWebAccountsForUserAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CSecurity__CCredentials__CWebAccount_t **")] IAsyncOperation<IntPtr>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountManagerStatics3*, IUser*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[6]))((IWebAccountManagerStatics3*)Unsafe.AsPointer(ref this), user, operation);
    }

    /// <include file='IWebAccountManagerStatics3.xml' path='doc/member[@name="IWebAccountManagerStatics3.AddWebAccountForUserAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT AddWebAccountForUserAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, HSTRING webAccountId, HSTRING webAccountUserName, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_HSTRING_t *")] IMapView<HSTRING, HSTRING>* props, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CWebAccount_t **")] IAsyncOperation<IntPtr>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountManagerStatics3*, IUser*, HSTRING, HSTRING, IMapView<HSTRING, HSTRING>*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[7]))((IWebAccountManagerStatics3*)Unsafe.AsPointer(ref this), user, webAccountId, webAccountUserName, props, operation);
    }

    /// <include file='IWebAccountManagerStatics3.xml' path='doc/member[@name="IWebAccountManagerStatics3.AddWebAccountWithScopeForUserAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT AddWebAccountWithScopeForUserAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, HSTRING webAccountId, HSTRING webAccountUserName, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_HSTRING_t *")] IMapView<HSTRING, HSTRING>* props, [NativeTypeName("ABI::Windows::Security::Authentication::Web::Provider::WebAccountScope")] WebAccountScope scope, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CWebAccount_t **")] IAsyncOperation<IntPtr>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountManagerStatics3*, IUser*, HSTRING, HSTRING, IMapView<HSTRING, HSTRING>*, WebAccountScope, IAsyncOperation<IntPtr>**, int>)(lpVtbl[8]))((IWebAccountManagerStatics3*)Unsafe.AsPointer(ref this), user, webAccountId, webAccountUserName, props, scope, operation);
    }

    /// <include file='IWebAccountManagerStatics3.xml' path='doc/member[@name="IWebAccountManagerStatics3.AddWebAccountWithScopeAndMapForUserAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT AddWebAccountWithScopeAndMapForUserAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, HSTRING webAccountId, HSTRING webAccountUserName, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_HSTRING_t *")] IMapView<HSTRING, HSTRING>* props, [NativeTypeName("ABI::Windows::Security::Authentication::Web::Provider::WebAccountScope")] WebAccountScope scope, HSTRING perUserWebAccountId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CWebAccount_t **")] IAsyncOperation<IntPtr>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountManagerStatics3*, IUser*, HSTRING, HSTRING, IMapView<HSTRING, HSTRING>*, WebAccountScope, HSTRING, IAsyncOperation<IntPtr>**, int>)(lpVtbl[9]))((IWebAccountManagerStatics3*)Unsafe.AsPointer(ref this), user, webAccountId, webAccountUserName, props, scope, perUserWebAccountId, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT FindAllProviderWebAccountsForUserAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CSecurity__CCredentials__CWebAccount_t **")] IAsyncOperation<IntPtr>** operation);

        [VtblIndex(7)]
        HRESULT AddWebAccountForUserAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, HSTRING webAccountId, HSTRING webAccountUserName, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_HSTRING_t *")] IMapView<HSTRING, HSTRING>* props, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CWebAccount_t **")] IAsyncOperation<IntPtr>** operation);

        [VtblIndex(8)]
        HRESULT AddWebAccountWithScopeForUserAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, HSTRING webAccountId, HSTRING webAccountUserName, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_HSTRING_t *")] IMapView<HSTRING, HSTRING>* props, [NativeTypeName("ABI::Windows::Security::Authentication::Web::Provider::WebAccountScope")] WebAccountScope scope, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CWebAccount_t **")] IAsyncOperation<IntPtr>** operation);

        [VtblIndex(9)]
        HRESULT AddWebAccountWithScopeAndMapForUserAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, HSTRING webAccountId, HSTRING webAccountUserName, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_HSTRING_t *")] IMapView<HSTRING, HSTRING>* props, [NativeTypeName("ABI::Windows::Security::Authentication::Web::Provider::WebAccountScope")] WebAccountScope scope, HSTRING perUserWebAccountId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CWebAccount_t **")] IAsyncOperation<IntPtr>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser *, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CSecurity__CCredentials__CWebAccount_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUser*, IAsyncOperation<IntPtr>**, int> FindAllProviderWebAccountsForUserAsync;

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser *, HSTRING, HSTRING, ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_HSTRING_t *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CWebAccount_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUser*, HSTRING, HSTRING, IMapView<HSTRING, HSTRING>*, IAsyncOperation<IntPtr>**, int> AddWebAccountForUserAsync;

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser *, HSTRING, HSTRING, ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_HSTRING_t *, ABI::Windows::Security::Authentication::Web::Provider::WebAccountScope, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CWebAccount_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUser*, HSTRING, HSTRING, IMapView<HSTRING, HSTRING>*, WebAccountScope, IAsyncOperation<IntPtr>**, int> AddWebAccountWithScopeForUserAsync;

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser *, HSTRING, HSTRING, ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_HSTRING_t *, ABI::Windows::Security::Authentication::Web::Provider::WebAccountScope, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CWebAccount_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUser*, HSTRING, HSTRING, IMapView<HSTRING, HSTRING>*, WebAccountScope, HSTRING, IAsyncOperation<IntPtr>**, int> AddWebAccountWithScopeAndMapForUserAsync;
    }
}
