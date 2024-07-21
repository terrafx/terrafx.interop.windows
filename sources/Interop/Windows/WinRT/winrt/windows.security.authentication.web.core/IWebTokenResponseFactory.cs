// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.authentication.web.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IWebTokenResponseFactory.xml' path='doc/member[@name="IWebTokenResponseFactory"]/*' />
[Guid("AB6BF7F8-5450-4EF6-97F7-052B0431C0F0")]
[NativeTypeName("struct IWebTokenResponseFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWebTokenResponseFactory : IWebTokenResponseFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWebTokenResponseFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebTokenResponseFactory*, Guid*, void**, int>)(lpVtbl[0]))((IWebTokenResponseFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebTokenResponseFactory*, uint>)(lpVtbl[1]))((IWebTokenResponseFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebTokenResponseFactory*, uint>)(lpVtbl[2]))((IWebTokenResponseFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebTokenResponseFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IWebTokenResponseFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebTokenResponseFactory*, HSTRING*, int>)(lpVtbl[4]))((IWebTokenResponseFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebTokenResponseFactory*, TrustLevel*, int>)(lpVtbl[5]))((IWebTokenResponseFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IWebTokenResponseFactory.xml' path='doc/member[@name="IWebTokenResponseFactory.CreateWithToken"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateWithToken(HSTRING token, [NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::IWebTokenResponse **")] IWebTokenResponse** webTokenResponse)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebTokenResponseFactory*, HSTRING, IWebTokenResponse**, int>)(lpVtbl[6]))((IWebTokenResponseFactory*)Unsafe.AsPointer(ref this), token, webTokenResponse);
    }

    /// <include file='IWebTokenResponseFactory.xml' path='doc/member[@name="IWebTokenResponseFactory.CreateWithTokenAndAccount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateWithTokenAndAccount(HSTRING token, [NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")] IWebAccount* webAccount, [NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::IWebTokenResponse **")] IWebTokenResponse** webTokenResponse)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebTokenResponseFactory*, HSTRING, IWebAccount*, IWebTokenResponse**, int>)(lpVtbl[7]))((IWebTokenResponseFactory*)Unsafe.AsPointer(ref this), token, webAccount, webTokenResponse);
    }

    /// <include file='IWebTokenResponseFactory.xml' path='doc/member[@name="IWebTokenResponseFactory.CreateWithTokenAccountAndError"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateWithTokenAccountAndError(HSTRING token, [NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")] IWebAccount* webAccount, [NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::IWebProviderError *")] IWebProviderError* error, [NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::IWebTokenResponse **")] IWebTokenResponse** webTokenResponse)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebTokenResponseFactory*, HSTRING, IWebAccount*, IWebProviderError*, IWebTokenResponse**, int>)(lpVtbl[8]))((IWebTokenResponseFactory*)Unsafe.AsPointer(ref this), token, webAccount, error, webTokenResponse);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateWithToken(HSTRING token, [NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::IWebTokenResponse **")] IWebTokenResponse** webTokenResponse);

        [VtblIndex(7)]
        HRESULT CreateWithTokenAndAccount(HSTRING token, [NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")] IWebAccount* webAccount, [NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::IWebTokenResponse **")] IWebTokenResponse** webTokenResponse);

        [VtblIndex(8)]
        HRESULT CreateWithTokenAccountAndError(HSTRING token, [NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount *")] IWebAccount* webAccount, [NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::IWebProviderError *")] IWebProviderError* error, [NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::IWebTokenResponse **")] IWebTokenResponse** webTokenResponse);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Security::Authentication::Web::Core::IWebTokenResponse **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IWebTokenResponse**, int> CreateWithToken;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Security::Credentials::IWebAccount *, ABI::Windows::Security::Authentication::Web::Core::IWebTokenResponse **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IWebAccount*, IWebTokenResponse**, int> CreateWithTokenAndAccount;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Security::Credentials::IWebAccount *, ABI::Windows::Security::Authentication::Web::Core::IWebProviderError *, ABI::Windows::Security::Authentication::Web::Core::IWebTokenResponse **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IWebAccount*, IWebProviderError*, IWebTokenResponse**, int> CreateWithTokenAccountAndError;
    }
}
