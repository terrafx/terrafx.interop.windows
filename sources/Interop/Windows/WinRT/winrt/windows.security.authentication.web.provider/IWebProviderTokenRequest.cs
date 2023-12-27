// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.authentication.web.provider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IWebProviderTokenRequest.xml' path='doc/member[@name="IWebProviderTokenRequest"]/*' />
[Guid("1E18778B-8805-454B-9F11-468D2AF1095A")]
[NativeTypeName("struct IWebProviderTokenRequest : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWebProviderTokenRequest : IWebProviderTokenRequest.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWebProviderTokenRequest));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebProviderTokenRequest*, Guid*, void**, int>)(lpVtbl[0]))((IWebProviderTokenRequest*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebProviderTokenRequest*, uint>)(lpVtbl[1]))((IWebProviderTokenRequest*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebProviderTokenRequest*, uint>)(lpVtbl[2]))((IWebProviderTokenRequest*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebProviderTokenRequest*, uint*, Guid**, int>)(lpVtbl[3]))((IWebProviderTokenRequest*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebProviderTokenRequest*, HSTRING*, int>)(lpVtbl[4]))((IWebProviderTokenRequest*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebProviderTokenRequest*, TrustLevel*, int>)(lpVtbl[5]))((IWebProviderTokenRequest*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IWebProviderTokenRequest.xml' path='doc/member[@name="IWebProviderTokenRequest.get_ClientRequest"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ClientRequest([NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::IWebTokenRequest **")] IWebTokenRequest** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebProviderTokenRequest*, IWebTokenRequest**, int>)(lpVtbl[6]))((IWebProviderTokenRequest*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWebProviderTokenRequest.xml' path='doc/member[@name="IWebProviderTokenRequest.get_WebAccounts"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_WebAccounts([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSecurity__CCredentials__CWebAccount_t **")] IVectorView<Pointer<IWebAccount>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebProviderTokenRequest*, IVectorView<Pointer<IWebAccount>>**, int>)(lpVtbl[7]))((IWebProviderTokenRequest*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWebProviderTokenRequest.xml' path='doc/member[@name="IWebProviderTokenRequest.get_WebAccountSelectionOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_WebAccountSelectionOptions([NativeTypeName("ABI::Windows::Security::Authentication::Web::Provider::WebAccountSelectionOptions *")] WebAccountSelectionOptions* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebProviderTokenRequest*, WebAccountSelectionOptions*, int>)(lpVtbl[8]))((IWebProviderTokenRequest*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWebProviderTokenRequest.xml' path='doc/member[@name="IWebProviderTokenRequest.get_ApplicationCallbackUri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ApplicationCallbackUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebProviderTokenRequest*, IUriRuntimeClass**, int>)(lpVtbl[9]))((IWebProviderTokenRequest*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWebProviderTokenRequest.xml' path='doc/member[@name="IWebProviderTokenRequest.GetApplicationTokenBindingKeyAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetApplicationTokenBindingKeyAsync([NativeTypeName("ABI::Windows::Security::Authentication::Web::TokenBindingKeyType")] TokenBindingKeyType keyType, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* target, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCryptography__CCore__CCryptographicKey_t **")] IAsyncOperation<Pointer<ICryptographicKey>>** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebProviderTokenRequest*, TokenBindingKeyType, IUriRuntimeClass*, IAsyncOperation<Pointer<ICryptographicKey>>**, int>)(lpVtbl[10]))((IWebProviderTokenRequest*)Unsafe.AsPointer(ref this), keyType, target, asyncInfo);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ClientRequest([NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::IWebTokenRequest **")] IWebTokenRequest** value);

        [VtblIndex(7)]
        HRESULT get_WebAccounts([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSecurity__CCredentials__CWebAccount_t **")] IVectorView<Pointer<IWebAccount>>** value);

        [VtblIndex(8)]
        HRESULT get_WebAccountSelectionOptions([NativeTypeName("ABI::Windows::Security::Authentication::Web::Provider::WebAccountSelectionOptions *")] WebAccountSelectionOptions* value);

        [VtblIndex(9)]
        HRESULT get_ApplicationCallbackUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value);

        [VtblIndex(10)]
        HRESULT GetApplicationTokenBindingKeyAsync([NativeTypeName("ABI::Windows::Security::Authentication::Web::TokenBindingKeyType")] TokenBindingKeyType keyType, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* target, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCryptography__CCore__CCryptographicKey_t **")] IAsyncOperation<Pointer<ICryptographicKey>>** asyncInfo);
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

        [NativeTypeName("HRESULT (ABI::Windows::Security::Authentication::Web::Core::IWebTokenRequest **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWebTokenRequest**, int> get_ClientRequest;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSecurity__CCredentials__CWebAccount_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IWebAccount>>**, int> get_WebAccounts;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Authentication::Web::Provider::WebAccountSelectionOptions *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WebAccountSelectionOptions*, int> get_WebAccountSelectionOptions;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass**, int> get_ApplicationCallbackUri;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Authentication::Web::TokenBindingKeyType, ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CCryptography__CCore__CCryptographicKey_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TokenBindingKeyType, IUriRuntimeClass*, IAsyncOperation<Pointer<ICryptographicKey>>**, int> GetApplicationTokenBindingKeyAsync;
    }
}
