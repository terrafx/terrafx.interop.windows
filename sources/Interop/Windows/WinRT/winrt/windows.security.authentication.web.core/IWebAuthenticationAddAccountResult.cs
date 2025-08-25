// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.authentication.web.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IWebAuthenticationAddAccountResult.xml' path='doc/member[@name="IWebAuthenticationAddAccountResult"]/*' />
[Guid("88FAD03C-901D-5FFA-9259-701D3CA08EF2")]
[NativeTypeName("struct IWebAuthenticationAddAccountResult : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWebAuthenticationAddAccountResult : IWebAuthenticationAddAccountResult.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IWebAuthenticationAddAccountResult);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationAddAccountResult*, Guid*, void**, int>)(lpVtbl[0]))((IWebAuthenticationAddAccountResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationAddAccountResult*, uint>)(lpVtbl[1]))((IWebAuthenticationAddAccountResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationAddAccountResult*, uint>)(lpVtbl[2]))((IWebAuthenticationAddAccountResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationAddAccountResult*, uint*, Guid**, int>)(lpVtbl[3]))((IWebAuthenticationAddAccountResult*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationAddAccountResult*, HSTRING*, int>)(lpVtbl[4]))((IWebAuthenticationAddAccountResult*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationAddAccountResult*, TrustLevel*, int>)(lpVtbl[5]))((IWebAuthenticationAddAccountResult*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IWebAuthenticationAddAccountResult.xml' path='doc/member[@name="IWebAuthenticationAddAccountResult.get_ResponseData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ResponseData([NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::IWebAuthenticationAddAccountResponse **")] IWebAuthenticationAddAccountResponse** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationAddAccountResult*, IWebAuthenticationAddAccountResponse**, int>)(lpVtbl[6]))((IWebAuthenticationAddAccountResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWebAuthenticationAddAccountResult.xml' path='doc/member[@name="IWebAuthenticationAddAccountResult.get_ResponseStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ResponseStatus([NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::WebAuthenticationAddAccountStatus *")] WebAuthenticationAddAccountStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationAddAccountResult*, WebAuthenticationAddAccountStatus*, int>)(lpVtbl[7]))((IWebAuthenticationAddAccountResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWebAuthenticationAddAccountResult.xml' path='doc/member[@name="IWebAuthenticationAddAccountResult.get_ResponseError"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ResponseError([NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::IWebProviderError **")] IWebProviderError** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationAddAccountResult*, IWebProviderError**, int>)(lpVtbl[8]))((IWebAuthenticationAddAccountResult*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ResponseData([NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::IWebAuthenticationAddAccountResponse **")] IWebAuthenticationAddAccountResponse** value);

        [VtblIndex(7)]
        HRESULT get_ResponseStatus([NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::WebAuthenticationAddAccountStatus *")] WebAuthenticationAddAccountStatus* value);

        [VtblIndex(8)]
        HRESULT get_ResponseError([NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::IWebProviderError **")] IWebProviderError** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Security::Authentication::Web::Core::IWebAuthenticationAddAccountResponse **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWebAuthenticationAddAccountResponse**, int> get_ResponseData;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Authentication::Web::Core::WebAuthenticationAddAccountStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WebAuthenticationAddAccountStatus*, int> get_ResponseStatus;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Authentication::Web::Core::IWebProviderError **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWebProviderError**, int> get_ResponseError;
    }
}
