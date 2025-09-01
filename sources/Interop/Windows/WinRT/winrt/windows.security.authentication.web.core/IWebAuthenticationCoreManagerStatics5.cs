// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.authentication.web.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IWebAuthenticationCoreManagerStatics5.xml' path='doc/member[@name="IWebAuthenticationCoreManagerStatics5"]/*' />
[Guid("D07C1DED-270F-4554-9966-27B7DF05B965")]
[NativeTypeName("struct IWebAuthenticationCoreManagerStatics5 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWebAuthenticationCoreManagerStatics5 : IWebAuthenticationCoreManagerStatics5.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IWebAuthenticationCoreManagerStatics5);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationCoreManagerStatics5*, Guid*, void**, int>)(lpVtbl[0]))((IWebAuthenticationCoreManagerStatics5*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationCoreManagerStatics5*, uint>)(lpVtbl[1]))((IWebAuthenticationCoreManagerStatics5*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationCoreManagerStatics5*, uint>)(lpVtbl[2]))((IWebAuthenticationCoreManagerStatics5*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationCoreManagerStatics5*, uint*, Guid**, int>)(lpVtbl[3]))((IWebAuthenticationCoreManagerStatics5*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationCoreManagerStatics5*, HSTRING*, int>)(lpVtbl[4]))((IWebAuthenticationCoreManagerStatics5*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationCoreManagerStatics5*, TrustLevel*, int>)(lpVtbl[5]))((IWebAuthenticationCoreManagerStatics5*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IWebAuthenticationCoreManagerStatics5.xml' path='doc/member[@name="IWebAuthenticationCoreManagerStatics5.AddAccountWithTransferTokenAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AddAccountWithTransferTokenAsync([NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::IWebAuthenticationTransferTokenRequest *")] IWebAuthenticationTransferTokenRequest* request, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CAuthentication__CWeb__CCore__CWebAuthenticationAddAccountResult_t **")] IAsyncOperation<Pointer<IWebAuthenticationAddAccountResult>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationCoreManagerStatics5*, IWebAuthenticationTransferTokenRequest*, IAsyncOperation<Pointer<IWebAuthenticationAddAccountResult>>**, int>)(lpVtbl[6]))((IWebAuthenticationCoreManagerStatics5*)Unsafe.AsPointer(ref this), request, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT AddAccountWithTransferTokenAsync([NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::IWebAuthenticationTransferTokenRequest *")] IWebAuthenticationTransferTokenRequest* request, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CAuthentication__CWeb__CCore__CWebAuthenticationAddAccountResult_t **")] IAsyncOperation<Pointer<IWebAuthenticationAddAccountResult>>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Security::Authentication::Web::Core::IWebAuthenticationTransferTokenRequest *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CAuthentication__CWeb__CCore__CWebAuthenticationAddAccountResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWebAuthenticationTransferTokenRequest*, IAsyncOperation<Pointer<IWebAuthenticationAddAccountResult>>**, int> AddAccountWithTransferTokenAsync;
    }
}
