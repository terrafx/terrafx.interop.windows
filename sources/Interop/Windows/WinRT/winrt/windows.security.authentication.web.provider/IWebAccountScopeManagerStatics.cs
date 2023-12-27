// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.authentication.web.provider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IWebAccountScopeManagerStatics.xml' path='doc/member[@name="IWebAccountScopeManagerStatics"]/*' />
[Guid("5C6CE37C-12B2-423A-BF3D-85B8D7E53656")]
[NativeTypeName("struct IWebAccountScopeManagerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWebAccountScopeManagerStatics : IWebAccountScopeManagerStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWebAccountScopeManagerStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountScopeManagerStatics*, Guid*, void**, int>)(lpVtbl[0]))((IWebAccountScopeManagerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountScopeManagerStatics*, uint>)(lpVtbl[1]))((IWebAccountScopeManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountScopeManagerStatics*, uint>)(lpVtbl[2]))((IWebAccountScopeManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountScopeManagerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IWebAccountScopeManagerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountScopeManagerStatics*, HSTRING*, int>)(lpVtbl[4]))((IWebAccountScopeManagerStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountScopeManagerStatics*, TrustLevel*, int>)(lpVtbl[5]))((IWebAccountScopeManagerStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IWebAccountScopeManagerStatics.xml' path='doc/member[@name="IWebAccountScopeManagerStatics.AddWebAccountWithScopeAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AddWebAccountWithScopeAsync(HSTRING webAccountId, HSTRING webAccountUserName, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_HSTRING_t *")] IMapView<HSTRING, HSTRING>* props, [NativeTypeName("ABI::Windows::Security::Authentication::Web::Provider::WebAccountScope")] WebAccountScope scope, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CWebAccount_t **")] IAsyncOperation<Pointer<IWebAccount>>** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountScopeManagerStatics*, HSTRING, HSTRING, IMapView<HSTRING, HSTRING>*, WebAccountScope, IAsyncOperation<Pointer<IWebAccount>>**, int>)(lpVtbl[6]))((IWebAccountScopeManagerStatics*)Unsafe.AsPointer(ref this), webAccountId, webAccountUserName, props, scope, asyncInfo);
    }

    /// <include file='IWebAccountScopeManagerStatics.xml' path='doc/member[@name="IWebAccountScopeManagerStatics.SetScopeAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetScopeAsync([NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")] IWebAccount* webAccount, [NativeTypeName("ABI::Windows::Security::Authentication::Web::Provider::WebAccountScope")] WebAccountScope scope, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountScopeManagerStatics*, IWebAccount*, WebAccountScope, IAsyncAction**, int>)(lpVtbl[7]))((IWebAccountScopeManagerStatics*)Unsafe.AsPointer(ref this), webAccount, scope, asyncInfo);
    }

    /// <include file='IWebAccountScopeManagerStatics.xml' path='doc/member[@name="IWebAccountScopeManagerStatics.GetScope"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetScope([NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")] IWebAccount* webAccount, [NativeTypeName("ABI::Windows::Security::Authentication::Web::Provider::WebAccountScope *")] WebAccountScope* scope)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountScopeManagerStatics*, IWebAccount*, WebAccountScope*, int>)(lpVtbl[8]))((IWebAccountScopeManagerStatics*)Unsafe.AsPointer(ref this), webAccount, scope);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT AddWebAccountWithScopeAsync(HSTRING webAccountId, HSTRING webAccountUserName, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_HSTRING_t *")] IMapView<HSTRING, HSTRING>* props, [NativeTypeName("ABI::Windows::Security::Authentication::Web::Provider::WebAccountScope")] WebAccountScope scope, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CWebAccount_t **")] IAsyncOperation<Pointer<IWebAccount>>** asyncInfo);

        [VtblIndex(7)]
        HRESULT SetScopeAsync([NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")] IWebAccount* webAccount, [NativeTypeName("ABI::Windows::Security::Authentication::Web::Provider::WebAccountScope")] WebAccountScope scope, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo);

        [VtblIndex(8)]
        HRESULT GetScope([NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")] IWebAccount* webAccount, [NativeTypeName("ABI::Windows::Security::Authentication::Web::Provider::WebAccountScope *")] WebAccountScope* scope);
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

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_HSTRING_t *, ABI::Windows::Security::Authentication::Web::Provider::WebAccountScope, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCredentials__CWebAccount_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IMapView<HSTRING, HSTRING>*, WebAccountScope, IAsyncOperation<Pointer<IWebAccount>>**, int> AddWebAccountWithScopeAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Credentials::IWebAccount *, ABI::Windows::Security::Authentication::Web::Provider::WebAccountScope, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWebAccount*, WebAccountScope, IAsyncAction**, int> SetScopeAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Credentials::IWebAccount *, ABI::Windows::Security::Authentication::Web::Provider::WebAccountScope *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWebAccount*, WebAccountScope*, int> GetScope;
    }
}
