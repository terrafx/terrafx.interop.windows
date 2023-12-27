// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.authentication.web.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IWebAuthenticationCoreManagerStatics.xml' path='doc/member[@name="IWebAuthenticationCoreManagerStatics"]/*' />
[Guid("6ACA7C92-A581-4479-9C10-752EFF44FD34")]
[NativeTypeName("struct IWebAuthenticationCoreManagerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWebAuthenticationCoreManagerStatics : IWebAuthenticationCoreManagerStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWebAuthenticationCoreManagerStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationCoreManagerStatics*, Guid*, void**, int>)(lpVtbl[0]))((IWebAuthenticationCoreManagerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationCoreManagerStatics*, uint>)(lpVtbl[1]))((IWebAuthenticationCoreManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationCoreManagerStatics*, uint>)(lpVtbl[2]))((IWebAuthenticationCoreManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationCoreManagerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IWebAuthenticationCoreManagerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationCoreManagerStatics*, HSTRING*, int>)(lpVtbl[4]))((IWebAuthenticationCoreManagerStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationCoreManagerStatics*, TrustLevel*, int>)(lpVtbl[5]))((IWebAuthenticationCoreManagerStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IWebAuthenticationCoreManagerStatics.xml' path='doc/member[@name="IWebAuthenticationCoreManagerStatics.GetTokenSilentlyAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetTokenSilentlyAsync([NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::IWebTokenRequest *")] IWebTokenRequest* request, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CAuthentication__CWeb__CCore__CWebTokenRequestResult_t **")] IAsyncOperation<Pointer<IWebTokenRequestResult>>** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationCoreManagerStatics*, IWebTokenRequest*, IAsyncOperation<Pointer<IWebTokenRequestResult>>**, int>)(lpVtbl[6]))((IWebAuthenticationCoreManagerStatics*)Unsafe.AsPointer(ref this), request, asyncInfo);
    }

    /// <include file='IWebAuthenticationCoreManagerStatics.xml' path='doc/member[@name="IWebAuthenticationCoreManagerStatics.GetTokenSilentlyWithWebAccountAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetTokenSilentlyWithWebAccountAsync([NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::IWebTokenRequest *")] IWebTokenRequest* request, [NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")] IWebAccount* webAccount, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CAuthentication__CWeb__CCore__CWebTokenRequestResult_t **")] IAsyncOperation<Pointer<IWebTokenRequestResult>>** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationCoreManagerStatics*, IWebTokenRequest*, IWebAccount*, IAsyncOperation<Pointer<IWebTokenRequestResult>>**, int>)(lpVtbl[7]))((IWebAuthenticationCoreManagerStatics*)Unsafe.AsPointer(ref this), request, webAccount, asyncInfo);
    }

    /// <include file='IWebAuthenticationCoreManagerStatics.xml' path='doc/member[@name="IWebAuthenticationCoreManagerStatics.RequestTokenAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RequestTokenAsync([NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::IWebTokenRequest *")] IWebTokenRequest* request, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CAuthentication__CWeb__CCore__CWebTokenRequestResult_t **")] IAsyncOperation<Pointer<IWebTokenRequestResult>>** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationCoreManagerStatics*, IWebTokenRequest*, IAsyncOperation<Pointer<IWebTokenRequestResult>>**, int>)(lpVtbl[8]))((IWebAuthenticationCoreManagerStatics*)Unsafe.AsPointer(ref this), request, asyncInfo);
    }

    /// <include file='IWebAuthenticationCoreManagerStatics.xml' path='doc/member[@name="IWebAuthenticationCoreManagerStatics.RequestTokenWithWebAccountAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RequestTokenWithWebAccountAsync([NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::IWebTokenRequest *")] IWebTokenRequest* request, [NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")] IWebAccount* webAccount, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CAuthentication__CWeb__CCore__CWebTokenRequestResult_t **")] IAsyncOperation<Pointer<IWebTokenRequestResult>>** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationCoreManagerStatics*, IWebTokenRequest*, IWebAccount*, IAsyncOperation<Pointer<IWebTokenRequestResult>>**, int>)(lpVtbl[9]))((IWebAuthenticationCoreManagerStatics*)Unsafe.AsPointer(ref this), request, webAccount, asyncInfo);
    }

    /// <include file='IWebAuthenticationCoreManagerStatics.xml' path='doc/member[@name="IWebAuthenticationCoreManagerStatics.FindAccountAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT FindAccountAsync([NativeTypeName("ABI::Windows::Security::Credentials::IWebAccountProvider *")] IWebAccountProvider* provider, HSTRING webAccountId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CWebAccount_t **")] IAsyncOperation<Pointer<IWebAccount>>** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationCoreManagerStatics*, IWebAccountProvider*, HSTRING, IAsyncOperation<Pointer<IWebAccount>>**, int>)(lpVtbl[10]))((IWebAuthenticationCoreManagerStatics*)Unsafe.AsPointer(ref this), provider, webAccountId, asyncInfo);
    }

    /// <include file='IWebAuthenticationCoreManagerStatics.xml' path='doc/member[@name="IWebAuthenticationCoreManagerStatics.FindAccountProviderAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT FindAccountProviderAsync(HSTRING webAccountProviderId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CWebAccountProvider_t **")] IAsyncOperation<Pointer<IWebAccountProvider>>** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationCoreManagerStatics*, HSTRING, IAsyncOperation<Pointer<IWebAccountProvider>>**, int>)(lpVtbl[11]))((IWebAuthenticationCoreManagerStatics*)Unsafe.AsPointer(ref this), webAccountProviderId, asyncInfo);
    }

    /// <include file='IWebAuthenticationCoreManagerStatics.xml' path='doc/member[@name="IWebAuthenticationCoreManagerStatics.FindAccountProviderWithAuthorityAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT FindAccountProviderWithAuthorityAsync(HSTRING webAccountProviderId, HSTRING authority, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CWebAccountProvider_t **")] IAsyncOperation<Pointer<IWebAccountProvider>>** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationCoreManagerStatics*, HSTRING, HSTRING, IAsyncOperation<Pointer<IWebAccountProvider>>**, int>)(lpVtbl[12]))((IWebAuthenticationCoreManagerStatics*)Unsafe.AsPointer(ref this), webAccountProviderId, authority, asyncInfo);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetTokenSilentlyAsync([NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::IWebTokenRequest *")] IWebTokenRequest* request, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CAuthentication__CWeb__CCore__CWebTokenRequestResult_t **")] IAsyncOperation<Pointer<IWebTokenRequestResult>>** asyncInfo);

        [VtblIndex(7)]
        HRESULT GetTokenSilentlyWithWebAccountAsync([NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::IWebTokenRequest *")] IWebTokenRequest* request, [NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")] IWebAccount* webAccount, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CAuthentication__CWeb__CCore__CWebTokenRequestResult_t **")] IAsyncOperation<Pointer<IWebTokenRequestResult>>** asyncInfo);

        [VtblIndex(8)]
        HRESULT RequestTokenAsync([NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::IWebTokenRequest *")] IWebTokenRequest* request, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CAuthentication__CWeb__CCore__CWebTokenRequestResult_t **")] IAsyncOperation<Pointer<IWebTokenRequestResult>>** asyncInfo);

        [VtblIndex(9)]
        HRESULT RequestTokenWithWebAccountAsync([NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::IWebTokenRequest *")] IWebTokenRequest* request, [NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")] IWebAccount* webAccount, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CAuthentication__CWeb__CCore__CWebTokenRequestResult_t **")] IAsyncOperation<Pointer<IWebTokenRequestResult>>** asyncInfo);

        [VtblIndex(10)]
        HRESULT FindAccountAsync([NativeTypeName("ABI::Windows::Security::Credentials::IWebAccountProvider *")] IWebAccountProvider* provider, HSTRING webAccountId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CWebAccount_t **")] IAsyncOperation<Pointer<IWebAccount>>** asyncInfo);

        [VtblIndex(11)]
        HRESULT FindAccountProviderAsync(HSTRING webAccountProviderId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CWebAccountProvider_t **")] IAsyncOperation<Pointer<IWebAccountProvider>>** asyncInfo);

        [VtblIndex(12)]
        HRESULT FindAccountProviderWithAuthorityAsync(HSTRING webAccountProviderId, HSTRING authority, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CWebAccountProvider_t **")] IAsyncOperation<Pointer<IWebAccountProvider>>** asyncInfo);
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

        [NativeTypeName("HRESULT (ABI::Windows::Security::Authentication::Web::Core::IWebTokenRequest *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CAuthentication__CWeb__CCore__CWebTokenRequestResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWebTokenRequest*, IAsyncOperation<Pointer<IWebTokenRequestResult>>**, int> GetTokenSilentlyAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Authentication::Web::Core::IWebTokenRequest *, ABI::Windows::Security::Credentials::IWebAccount *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CAuthentication__CWeb__CCore__CWebTokenRequestResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWebTokenRequest*, IWebAccount*, IAsyncOperation<Pointer<IWebTokenRequestResult>>**, int> GetTokenSilentlyWithWebAccountAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Authentication::Web::Core::IWebTokenRequest *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CAuthentication__CWeb__CCore__CWebTokenRequestResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWebTokenRequest*, IAsyncOperation<Pointer<IWebTokenRequestResult>>**, int> RequestTokenAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Authentication::Web::Core::IWebTokenRequest *, ABI::Windows::Security::Credentials::IWebAccount *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CAuthentication__CWeb__CCore__CWebTokenRequestResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWebTokenRequest*, IWebAccount*, IAsyncOperation<Pointer<IWebTokenRequestResult>>**, int> RequestTokenWithWebAccountAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Credentials::IWebAccountProvider *, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CWebAccount_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWebAccountProvider*, HSTRING, IAsyncOperation<Pointer<IWebAccount>>**, int> FindAccountAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CWebAccountProvider_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IWebAccountProvider>>**, int> FindAccountProviderAsync;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CWebAccountProvider_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IAsyncOperation<Pointer<IWebAccountProvider>>**, int> FindAccountProviderWithAuthorityAsync;
    }
}
