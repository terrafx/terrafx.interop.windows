// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.authentication.web.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IWebAuthenticationAddAccountResponseFactory.xml' path='doc/member[@name="IWebAuthenticationAddAccountResponseFactory"]/*' />
[Guid("325F903E-77BE-5365-81D9-0321CDD82195")]
[NativeTypeName("struct IWebAuthenticationAddAccountResponseFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWebAuthenticationAddAccountResponseFactory : IWebAuthenticationAddAccountResponseFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IWebAuthenticationAddAccountResponseFactory);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationAddAccountResponseFactory*, Guid*, void**, int>)(lpVtbl[0]))((IWebAuthenticationAddAccountResponseFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationAddAccountResponseFactory*, uint>)(lpVtbl[1]))((IWebAuthenticationAddAccountResponseFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationAddAccountResponseFactory*, uint>)(lpVtbl[2]))((IWebAuthenticationAddAccountResponseFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationAddAccountResponseFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IWebAuthenticationAddAccountResponseFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationAddAccountResponseFactory*, HSTRING*, int>)(lpVtbl[4]))((IWebAuthenticationAddAccountResponseFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationAddAccountResponseFactory*, TrustLevel*, int>)(lpVtbl[5]))((IWebAuthenticationAddAccountResponseFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IWebAuthenticationAddAccountResponseFactory.xml' path='doc/member[@name="IWebAuthenticationAddAccountResponseFactory.CreateWithAccount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateWithAccount([NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")] IWebAccount* webAccount, [NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::IWebAuthenticationAddAccountResponse **")] IWebAuthenticationAddAccountResponse** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationAddAccountResponseFactory*, IWebAccount*, IWebAuthenticationAddAccountResponse**, int>)(lpVtbl[6]))((IWebAuthenticationAddAccountResponseFactory*)Unsafe.AsPointer(ref this), webAccount, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateWithAccount([NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")] IWebAccount* webAccount, [NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::IWebAuthenticationAddAccountResponse **")] IWebAuthenticationAddAccountResponse** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Security::Credentials::IWebAccount *, ABI::Windows::Security::Authentication::Web::Core::IWebAuthenticationAddAccountResponse **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWebAccount*, IWebAuthenticationAddAccountResponse**, int> CreateWithAccount;
    }
}
