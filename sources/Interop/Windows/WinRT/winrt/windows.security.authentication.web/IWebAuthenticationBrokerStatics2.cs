// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.authentication.web.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IWebAuthenticationBrokerStatics2.xml' path='doc/member[@name="IWebAuthenticationBrokerStatics2"]/*' />
[Guid("73CDFB9E-14E7-41DA-A971-AAF4410B621E")]
[NativeTypeName("struct IWebAuthenticationBrokerStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWebAuthenticationBrokerStatics2 : IWebAuthenticationBrokerStatics2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IWebAuthenticationBrokerStatics2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationBrokerStatics2*, Guid*, void**, int>)(lpVtbl[0]))((IWebAuthenticationBrokerStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationBrokerStatics2*, uint>)(lpVtbl[1]))((IWebAuthenticationBrokerStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationBrokerStatics2*, uint>)(lpVtbl[2]))((IWebAuthenticationBrokerStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationBrokerStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((IWebAuthenticationBrokerStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationBrokerStatics2*, HSTRING*, int>)(lpVtbl[4]))((IWebAuthenticationBrokerStatics2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationBrokerStatics2*, TrustLevel*, int>)(lpVtbl[5]))((IWebAuthenticationBrokerStatics2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IWebAuthenticationBrokerStatics2.xml' path='doc/member[@name="IWebAuthenticationBrokerStatics2.AuthenticateAndContinue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AuthenticateAndContinue([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* requestUri)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationBrokerStatics2*, IUriRuntimeClass*, int>)(lpVtbl[6]))((IWebAuthenticationBrokerStatics2*)Unsafe.AsPointer(ref this), requestUri);
    }

    /// <include file='IWebAuthenticationBrokerStatics2.xml' path='doc/member[@name="IWebAuthenticationBrokerStatics2.AuthenticateWithCallbackUriAndContinue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT AuthenticateWithCallbackUriAndContinue([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* requestUri, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* callbackUri)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationBrokerStatics2*, IUriRuntimeClass*, IUriRuntimeClass*, int>)(lpVtbl[7]))((IWebAuthenticationBrokerStatics2*)Unsafe.AsPointer(ref this), requestUri, callbackUri);
    }

    /// <include file='IWebAuthenticationBrokerStatics2.xml' path='doc/member[@name="IWebAuthenticationBrokerStatics2.AuthenticateWithCallbackUriContinuationDataAndOptionsAndContinue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT AuthenticateWithCallbackUriContinuationDataAndOptionsAndContinue([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* requestUri, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* callbackUri, [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* continuationData, [NativeTypeName("ABI::Windows::Security::Authentication::Web::WebAuthenticationOptions")] WebAuthenticationOptions options)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationBrokerStatics2*, IUriRuntimeClass*, IUriRuntimeClass*, IPropertySet*, WebAuthenticationOptions, int>)(lpVtbl[8]))((IWebAuthenticationBrokerStatics2*)Unsafe.AsPointer(ref this), requestUri, callbackUri, continuationData, options);
    }

    /// <include file='IWebAuthenticationBrokerStatics2.xml' path='doc/member[@name="IWebAuthenticationBrokerStatics2.AuthenticateSilentlyAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT AuthenticateSilentlyAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* requestUri, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CAuthentication__CWeb__CWebAuthenticationResult_t **")] IAsyncOperation<Pointer<IWebAuthenticationResult>>** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationBrokerStatics2*, IUriRuntimeClass*, IAsyncOperation<Pointer<IWebAuthenticationResult>>**, int>)(lpVtbl[9]))((IWebAuthenticationBrokerStatics2*)Unsafe.AsPointer(ref this), requestUri, asyncInfo);
    }

    /// <include file='IWebAuthenticationBrokerStatics2.xml' path='doc/member[@name="IWebAuthenticationBrokerStatics2.AuthenticateSilentlyWithOptionsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT AuthenticateSilentlyWithOptionsAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* requestUri, [NativeTypeName("ABI::Windows::Security::Authentication::Web::WebAuthenticationOptions")] WebAuthenticationOptions options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CAuthentication__CWeb__CWebAuthenticationResult_t **")] IAsyncOperation<Pointer<IWebAuthenticationResult>>** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationBrokerStatics2*, IUriRuntimeClass*, WebAuthenticationOptions, IAsyncOperation<Pointer<IWebAuthenticationResult>>**, int>)(lpVtbl[10]))((IWebAuthenticationBrokerStatics2*)Unsafe.AsPointer(ref this), requestUri, options, asyncInfo);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT AuthenticateAndContinue([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* requestUri);

        [VtblIndex(7)]
        HRESULT AuthenticateWithCallbackUriAndContinue([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* requestUri, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* callbackUri);

        [VtblIndex(8)]
        HRESULT AuthenticateWithCallbackUriContinuationDataAndOptionsAndContinue([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* requestUri, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* callbackUri, [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* continuationData, [NativeTypeName("ABI::Windows::Security::Authentication::Web::WebAuthenticationOptions")] WebAuthenticationOptions options);

        [VtblIndex(9)]
        HRESULT AuthenticateSilentlyAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* requestUri, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CAuthentication__CWeb__CWebAuthenticationResult_t **")] IAsyncOperation<Pointer<IWebAuthenticationResult>>** asyncInfo);

        [VtblIndex(10)]
        HRESULT AuthenticateSilentlyWithOptionsAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* requestUri, [NativeTypeName("ABI::Windows::Security::Authentication::Web::WebAuthenticationOptions")] WebAuthenticationOptions options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CAuthentication__CWeb__CWebAuthenticationResult_t **")] IAsyncOperation<Pointer<IWebAuthenticationResult>>** asyncInfo);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, int> AuthenticateAndContinue;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::IUriRuntimeClass *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, IUriRuntimeClass*, int> AuthenticateWithCallbackUriAndContinue;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::Collections::IPropertySet *, ABI::Windows::Security::Authentication::Web::WebAuthenticationOptions) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, IUriRuntimeClass*, IPropertySet*, WebAuthenticationOptions, int> AuthenticateWithCallbackUriContinuationDataAndOptionsAndContinue;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CAuthentication__CWeb__CWebAuthenticationResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, IAsyncOperation<Pointer<IWebAuthenticationResult>>**, int> AuthenticateSilentlyAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Security::Authentication::Web::WebAuthenticationOptions, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CAuthentication__CWeb__CWebAuthenticationResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, WebAuthenticationOptions, IAsyncOperation<Pointer<IWebAuthenticationResult>>**, int> AuthenticateSilentlyWithOptionsAsync;
    }
}
