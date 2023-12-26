// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.authentication.web.provider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IWebAccountManagerStatics.xml' path='doc/member[@name="IWebAccountManagerStatics"]/*' />
[Guid("B2E8E1A6-D49A-4032-84BF-1A2847747BF1")]
[NativeTypeName("struct IWebAccountManagerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWebAccountManagerStatics : IWebAccountManagerStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWebAccountManagerStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountManagerStatics*, Guid*, void**, int>)(lpVtbl[0]))((IWebAccountManagerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountManagerStatics*, uint>)(lpVtbl[1]))((IWebAccountManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountManagerStatics*, uint>)(lpVtbl[2]))((IWebAccountManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountManagerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IWebAccountManagerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountManagerStatics*, HSTRING*, int>)(lpVtbl[4]))((IWebAccountManagerStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountManagerStatics*, TrustLevel*, int>)(lpVtbl[5]))((IWebAccountManagerStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IWebAccountManagerStatics.xml' path='doc/member[@name="IWebAccountManagerStatics.UpdateWebAccountPropertiesAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT UpdateWebAccountPropertiesAsync([NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")] IWebAccount* webAccount, HSTRING webAccountUserName, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_HSTRING_t *")] IMapView<HSTRING, HSTRING>* additionalProperties, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountManagerStatics*, IWebAccount*, HSTRING, IMapView<HSTRING, HSTRING>*, IAsyncAction**, int>)(lpVtbl[6]))((IWebAccountManagerStatics*)Unsafe.AsPointer(ref this), webAccount, webAccountUserName, additionalProperties, asyncInfo);
    }

    /// <include file='IWebAccountManagerStatics.xml' path='doc/member[@name="IWebAccountManagerStatics.AddWebAccountAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT AddWebAccountAsync(HSTRING webAccountId, HSTRING webAccountUserName, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_HSTRING_t *")] IMapView<HSTRING, HSTRING>* props, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CWebAccount_t **")] IAsyncOperation<IntPtr>** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountManagerStatics*, HSTRING, HSTRING, IMapView<HSTRING, HSTRING>*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[7]))((IWebAccountManagerStatics*)Unsafe.AsPointer(ref this), webAccountId, webAccountUserName, props, asyncInfo);
    }

    /// <include file='IWebAccountManagerStatics.xml' path='doc/member[@name="IWebAccountManagerStatics.DeleteWebAccountAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT DeleteWebAccountAsync([NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")] IWebAccount* webAccount, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountManagerStatics*, IWebAccount*, IAsyncAction**, int>)(lpVtbl[8]))((IWebAccountManagerStatics*)Unsafe.AsPointer(ref this), webAccount, asyncInfo);
    }

    /// <include file='IWebAccountManagerStatics.xml' path='doc/member[@name="IWebAccountManagerStatics.FindAllProviderWebAccountsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT FindAllProviderWebAccountsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CSecurity__CCredentials__CWebAccount_t **")] IAsyncOperation<IntPtr>** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountManagerStatics*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[9]))((IWebAccountManagerStatics*)Unsafe.AsPointer(ref this), asyncInfo);
    }

    /// <include file='IWebAccountManagerStatics.xml' path='doc/member[@name="IWebAccountManagerStatics.PushCookiesAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT PushCookiesAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CWeb__CHttp__CHttpCookie_t *")] IVectorView<IntPtr>* cookies, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountManagerStatics*, IUriRuntimeClass*, IVectorView<IntPtr>*, IAsyncAction**, int>)(lpVtbl[10]))((IWebAccountManagerStatics*)Unsafe.AsPointer(ref this), uri, cookies, asyncInfo);
    }

    /// <include file='IWebAccountManagerStatics.xml' path='doc/member[@name="IWebAccountManagerStatics.SetViewAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetViewAsync([NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")] IWebAccount* webAccount, [NativeTypeName("ABI::Windows::Security::Authentication::Web::Provider::IWebAccountClientView *")] IWebAccountClientView* view, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountManagerStatics*, IWebAccount*, IWebAccountClientView*, IAsyncAction**, int>)(lpVtbl[11]))((IWebAccountManagerStatics*)Unsafe.AsPointer(ref this), webAccount, view, asyncInfo);
    }

    /// <include file='IWebAccountManagerStatics.xml' path='doc/member[@name="IWebAccountManagerStatics.ClearViewAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT ClearViewAsync([NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")] IWebAccount* webAccount, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* applicationCallbackUri, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountManagerStatics*, IWebAccount*, IUriRuntimeClass*, IAsyncAction**, int>)(lpVtbl[12]))((IWebAccountManagerStatics*)Unsafe.AsPointer(ref this), webAccount, applicationCallbackUri, asyncInfo);
    }

    /// <include file='IWebAccountManagerStatics.xml' path='doc/member[@name="IWebAccountManagerStatics.GetViewsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetViewsAsync([NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")] IWebAccount* webAccount, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CSecurity__CAuthentication__CWeb__CProvider__CWebAccountClientView_t **")] IAsyncOperation<IntPtr>** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountManagerStatics*, IWebAccount*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[13]))((IWebAccountManagerStatics*)Unsafe.AsPointer(ref this), webAccount, asyncInfo);
    }

    /// <include file='IWebAccountManagerStatics.xml' path='doc/member[@name="IWebAccountManagerStatics.SetWebAccountPictureAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetWebAccountPictureAsync([NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")] IWebAccount* webAccount, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* webAccountPicture, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountManagerStatics*, IWebAccount*, IRandomAccessStream*, IAsyncAction**, int>)(lpVtbl[14]))((IWebAccountManagerStatics*)Unsafe.AsPointer(ref this), webAccount, webAccountPicture, asyncInfo);
    }

    /// <include file='IWebAccountManagerStatics.xml' path='doc/member[@name="IWebAccountManagerStatics.ClearWebAccountPictureAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT ClearWebAccountPictureAsync([NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")] IWebAccount* webAccount, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountManagerStatics*, IWebAccount*, IAsyncAction**, int>)(lpVtbl[15]))((IWebAccountManagerStatics*)Unsafe.AsPointer(ref this), webAccount, asyncInfo);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT UpdateWebAccountPropertiesAsync([NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")] IWebAccount* webAccount, HSTRING webAccountUserName, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_HSTRING_t *")] IMapView<HSTRING, HSTRING>* additionalProperties, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo);

        [VtblIndex(7)]
        HRESULT AddWebAccountAsync(HSTRING webAccountId, HSTRING webAccountUserName, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_HSTRING_t *")] IMapView<HSTRING, HSTRING>* props, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CWebAccount_t **")] IAsyncOperation<IntPtr>** asyncInfo);

        [VtblIndex(8)]
        HRESULT DeleteWebAccountAsync([NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")] IWebAccount* webAccount, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo);

        [VtblIndex(9)]
        HRESULT FindAllProviderWebAccountsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CSecurity__CCredentials__CWebAccount_t **")] IAsyncOperation<IntPtr>** asyncInfo);

        [VtblIndex(10)]
        HRESULT PushCookiesAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CWeb__CHttp__CHttpCookie_t *")] IVectorView<IntPtr>* cookies, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo);

        [VtblIndex(11)]
        HRESULT SetViewAsync([NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")] IWebAccount* webAccount, [NativeTypeName("ABI::Windows::Security::Authentication::Web::Provider::IWebAccountClientView *")] IWebAccountClientView* view, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo);

        [VtblIndex(12)]
        HRESULT ClearViewAsync([NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")] IWebAccount* webAccount, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* applicationCallbackUri, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo);

        [VtblIndex(13)]
        HRESULT GetViewsAsync([NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")] IWebAccount* webAccount, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CSecurity__CAuthentication__CWeb__CProvider__CWebAccountClientView_t **")] IAsyncOperation<IntPtr>** asyncInfo);

        [VtblIndex(14)]
        HRESULT SetWebAccountPictureAsync([NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")] IWebAccount* webAccount, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")] IRandomAccessStream* webAccountPicture, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo);

        [VtblIndex(15)]
        HRESULT ClearWebAccountPictureAsync([NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")] IWebAccount* webAccount, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo);
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

        [NativeTypeName("HRESULT (ABI::Windows::Security::Credentials::IWebAccount *, HSTRING, ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_HSTRING_t *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWebAccount*, HSTRING, IMapView<HSTRING, HSTRING>*, IAsyncAction**, int> UpdateWebAccountPropertiesAsync;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_HSTRING_t *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CWebAccount_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IMapView<HSTRING, HSTRING>*, IAsyncOperation<IntPtr>**, int> AddWebAccountAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Credentials::IWebAccount *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWebAccount*, IAsyncAction**, int> DeleteWebAccountAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CSecurity__CCredentials__CWebAccount_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<IntPtr>**, int> FindAllProviderWebAccountsAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CWeb__CHttp__CHttpCookie_t *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, IVectorView<IntPtr>*, IAsyncAction**, int> PushCookiesAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Credentials::IWebAccount *, ABI::Windows::Security::Authentication::Web::Provider::IWebAccountClientView *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWebAccount*, IWebAccountClientView*, IAsyncAction**, int> SetViewAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Credentials::IWebAccount *, ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWebAccount*, IUriRuntimeClass*, IAsyncAction**, int> ClearViewAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Credentials::IWebAccount *, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CSecurity__CAuthentication__CWeb__CProvider__CWebAccountClientView_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWebAccount*, IAsyncOperation<IntPtr>**, int> GetViewsAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Credentials::IWebAccount *, ABI::Windows::Storage::Streams::IRandomAccessStream *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWebAccount*, IRandomAccessStream*, IAsyncAction**, int> SetWebAccountPictureAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Credentials::IWebAccount *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWebAccount*, IAsyncAction**, int> ClearWebAccountPictureAsync;
    }
}
