// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.authentication.web.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IWebAuthenticationCoreManagerStatics4.xml' path='doc/member[@name="IWebAuthenticationCoreManagerStatics4"]/*' />
[Guid("54E633FE-96E0-41E8-9832-1298897C2AAF")]
[NativeTypeName("struct IWebAuthenticationCoreManagerStatics4 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWebAuthenticationCoreManagerStatics4 : IWebAuthenticationCoreManagerStatics4.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWebAuthenticationCoreManagerStatics4));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationCoreManagerStatics4*, Guid*, void**, int>)(lpVtbl[0]))((IWebAuthenticationCoreManagerStatics4*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationCoreManagerStatics4*, uint>)(lpVtbl[1]))((IWebAuthenticationCoreManagerStatics4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationCoreManagerStatics4*, uint>)(lpVtbl[2]))((IWebAuthenticationCoreManagerStatics4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationCoreManagerStatics4*, uint*, Guid**, int>)(lpVtbl[3]))((IWebAuthenticationCoreManagerStatics4*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationCoreManagerStatics4*, HSTRING*, int>)(lpVtbl[4]))((IWebAuthenticationCoreManagerStatics4*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationCoreManagerStatics4*, TrustLevel*, int>)(lpVtbl[5]))((IWebAuthenticationCoreManagerStatics4*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IWebAuthenticationCoreManagerStatics4.xml' path='doc/member[@name="IWebAuthenticationCoreManagerStatics4.FindAllAccountsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FindAllAccountsAsync([NativeTypeName("ABI::Windows::Security::Credentials::IWebAccountProvider *")] IWebAccountProvider* provider, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CAuthentication__CWeb__CCore__CFindAllAccountsResult_t **")] IAsyncOperation<IntPtr>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationCoreManagerStatics4*, IWebAccountProvider*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[6]))((IWebAuthenticationCoreManagerStatics4*)Unsafe.AsPointer(ref this), provider, operation);
    }

    /// <include file='IWebAuthenticationCoreManagerStatics4.xml' path='doc/member[@name="IWebAuthenticationCoreManagerStatics4.FindAllAccountsWithClientIdAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT FindAllAccountsWithClientIdAsync([NativeTypeName("ABI::Windows::Security::Credentials::IWebAccountProvider *")] IWebAccountProvider* provider, HSTRING clientId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CAuthentication__CWeb__CCore__CFindAllAccountsResult_t **")] IAsyncOperation<IntPtr>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationCoreManagerStatics4*, IWebAccountProvider*, HSTRING, IAsyncOperation<IntPtr>**, int>)(lpVtbl[7]))((IWebAuthenticationCoreManagerStatics4*)Unsafe.AsPointer(ref this), provider, clientId, operation);
    }

    /// <include file='IWebAuthenticationCoreManagerStatics4.xml' path='doc/member[@name="IWebAuthenticationCoreManagerStatics4.FindSystemAccountProviderAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT FindSystemAccountProviderAsync(HSTRING webAccountProviderId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CWebAccountProvider_t **")] IAsyncOperation<IntPtr>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationCoreManagerStatics4*, HSTRING, IAsyncOperation<IntPtr>**, int>)(lpVtbl[8]))((IWebAuthenticationCoreManagerStatics4*)Unsafe.AsPointer(ref this), webAccountProviderId, operation);
    }

    /// <include file='IWebAuthenticationCoreManagerStatics4.xml' path='doc/member[@name="IWebAuthenticationCoreManagerStatics4.FindSystemAccountProviderWithAuthorityAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT FindSystemAccountProviderWithAuthorityAsync(HSTRING webAccountProviderId, HSTRING authority, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CWebAccountProvider_t **")] IAsyncOperation<IntPtr>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationCoreManagerStatics4*, HSTRING, HSTRING, IAsyncOperation<IntPtr>**, int>)(lpVtbl[9]))((IWebAuthenticationCoreManagerStatics4*)Unsafe.AsPointer(ref this), webAccountProviderId, authority, operation);
    }

    /// <include file='IWebAuthenticationCoreManagerStatics4.xml' path='doc/member[@name="IWebAuthenticationCoreManagerStatics4.FindSystemAccountProviderWithAuthorityForUserAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT FindSystemAccountProviderWithAuthorityForUserAsync(HSTRING webAccountProviderId, HSTRING authority, [NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CWebAccountProvider_t **")] IAsyncOperation<IntPtr>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationCoreManagerStatics4*, HSTRING, HSTRING, IUser*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[10]))((IWebAuthenticationCoreManagerStatics4*)Unsafe.AsPointer(ref this), webAccountProviderId, authority, user, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT FindAllAccountsAsync([NativeTypeName("ABI::Windows::Security::Credentials::IWebAccountProvider *")] IWebAccountProvider* provider, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CAuthentication__CWeb__CCore__CFindAllAccountsResult_t **")] IAsyncOperation<IntPtr>** operation);

        [VtblIndex(7)]
        HRESULT FindAllAccountsWithClientIdAsync([NativeTypeName("ABI::Windows::Security::Credentials::IWebAccountProvider *")] IWebAccountProvider* provider, HSTRING clientId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CAuthentication__CWeb__CCore__CFindAllAccountsResult_t **")] IAsyncOperation<IntPtr>** operation);

        [VtblIndex(8)]
        HRESULT FindSystemAccountProviderAsync(HSTRING webAccountProviderId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CWebAccountProvider_t **")] IAsyncOperation<IntPtr>** operation);

        [VtblIndex(9)]
        HRESULT FindSystemAccountProviderWithAuthorityAsync(HSTRING webAccountProviderId, HSTRING authority, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CWebAccountProvider_t **")] IAsyncOperation<IntPtr>** operation);

        [VtblIndex(10)]
        HRESULT FindSystemAccountProviderWithAuthorityForUserAsync(HSTRING webAccountProviderId, HSTRING authority, [NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CWebAccountProvider_t **")] IAsyncOperation<IntPtr>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Security::Credentials::IWebAccountProvider *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CAuthentication__CWeb__CCore__CFindAllAccountsResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWebAccountProvider*, IAsyncOperation<IntPtr>**, int> FindAllAccountsAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Credentials::IWebAccountProvider *, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CAuthentication__CWeb__CCore__CFindAllAccountsResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWebAccountProvider*, HSTRING, IAsyncOperation<IntPtr>**, int> FindAllAccountsWithClientIdAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CWebAccountProvider_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<IntPtr>**, int> FindSystemAccountProviderAsync;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CWebAccountProvider_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IAsyncOperation<IntPtr>**, int> FindSystemAccountProviderWithAuthorityAsync;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::System::IUser *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CWebAccountProvider_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IUser*, IAsyncOperation<IntPtr>**, int> FindSystemAccountProviderWithAuthorityForUserAsync;
    }
}
