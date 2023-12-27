// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.authentication.web.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IWebAuthenticationBrokerStatics.xml' path='doc/member[@name="IWebAuthenticationBrokerStatics"]/*' />
[Guid("2F149F1A-E673-40B5-BC22-201A6864A37B")]
[NativeTypeName("struct IWebAuthenticationBrokerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWebAuthenticationBrokerStatics : IWebAuthenticationBrokerStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWebAuthenticationBrokerStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationBrokerStatics*, Guid*, void**, int>)(lpVtbl[0]))((IWebAuthenticationBrokerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationBrokerStatics*, uint>)(lpVtbl[1]))((IWebAuthenticationBrokerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationBrokerStatics*, uint>)(lpVtbl[2]))((IWebAuthenticationBrokerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationBrokerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IWebAuthenticationBrokerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationBrokerStatics*, HSTRING*, int>)(lpVtbl[4]))((IWebAuthenticationBrokerStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationBrokerStatics*, TrustLevel*, int>)(lpVtbl[5]))((IWebAuthenticationBrokerStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IWebAuthenticationBrokerStatics.xml' path='doc/member[@name="IWebAuthenticationBrokerStatics.AuthenticateWithCallbackUriAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AuthenticateWithCallbackUriAsync([NativeTypeName("ABI::Windows::Security::Authentication::Web::WebAuthenticationOptions")] WebAuthenticationOptions options, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* requestUri, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* callbackUri, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CAuthentication__CWeb__CWebAuthenticationResult_t **")] IAsyncOperation<Pointer<IWebAuthenticationResult>>** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationBrokerStatics*, WebAuthenticationOptions, IUriRuntimeClass*, IUriRuntimeClass*, IAsyncOperation<Pointer<IWebAuthenticationResult>>**, int>)(lpVtbl[6]))((IWebAuthenticationBrokerStatics*)Unsafe.AsPointer(ref this), options, requestUri, callbackUri, asyncInfo);
    }

    /// <include file='IWebAuthenticationBrokerStatics.xml' path='doc/member[@name="IWebAuthenticationBrokerStatics.AuthenticateWithoutCallbackUriAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT AuthenticateWithoutCallbackUriAsync([NativeTypeName("ABI::Windows::Security::Authentication::Web::WebAuthenticationOptions")] WebAuthenticationOptions options, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* requestUri, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CAuthentication__CWeb__CWebAuthenticationResult_t **")] IAsyncOperation<Pointer<IWebAuthenticationResult>>** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationBrokerStatics*, WebAuthenticationOptions, IUriRuntimeClass*, IAsyncOperation<Pointer<IWebAuthenticationResult>>**, int>)(lpVtbl[7]))((IWebAuthenticationBrokerStatics*)Unsafe.AsPointer(ref this), options, requestUri, asyncInfo);
    }

    /// <include file='IWebAuthenticationBrokerStatics.xml' path='doc/member[@name="IWebAuthenticationBrokerStatics.GetCurrentApplicationCallbackUri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetCurrentApplicationCallbackUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** callbackUri)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationBrokerStatics*, IUriRuntimeClass**, int>)(lpVtbl[8]))((IWebAuthenticationBrokerStatics*)Unsafe.AsPointer(ref this), callbackUri);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT AuthenticateWithCallbackUriAsync([NativeTypeName("ABI::Windows::Security::Authentication::Web::WebAuthenticationOptions")] WebAuthenticationOptions options, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* requestUri, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* callbackUri, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CAuthentication__CWeb__CWebAuthenticationResult_t **")] IAsyncOperation<Pointer<IWebAuthenticationResult>>** asyncInfo);

        [VtblIndex(7)]
        HRESULT AuthenticateWithoutCallbackUriAsync([NativeTypeName("ABI::Windows::Security::Authentication::Web::WebAuthenticationOptions")] WebAuthenticationOptions options, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* requestUri, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CAuthentication__CWeb__CWebAuthenticationResult_t **")] IAsyncOperation<Pointer<IWebAuthenticationResult>>** asyncInfo);

        [VtblIndex(8)]
        HRESULT GetCurrentApplicationCallbackUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** callbackUri);
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

        [NativeTypeName("HRESULT (ABI::Windows::Security::Authentication::Web::WebAuthenticationOptions, ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CAuthentication__CWeb__CWebAuthenticationResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WebAuthenticationOptions, IUriRuntimeClass*, IUriRuntimeClass*, IAsyncOperation<Pointer<IWebAuthenticationResult>>**, int> AuthenticateWithCallbackUriAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Authentication::Web::WebAuthenticationOptions, ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CAuthentication__CWeb__CWebAuthenticationResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WebAuthenticationOptions, IUriRuntimeClass*, IAsyncOperation<Pointer<IWebAuthenticationResult>>**, int> AuthenticateWithoutCallbackUriAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass**, int> GetCurrentApplicationCallbackUri;
    }
}
