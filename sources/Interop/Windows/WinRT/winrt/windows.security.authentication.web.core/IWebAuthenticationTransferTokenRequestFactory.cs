// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.authentication.web.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IWebAuthenticationTransferTokenRequestFactory.xml' path='doc/member[@name="IWebAuthenticationTransferTokenRequestFactory"]/*' />
[Guid("5F16B627-04C4-5F0B-8683-8BAB58965656")]
[NativeTypeName("struct IWebAuthenticationTransferTokenRequestFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWebAuthenticationTransferTokenRequestFactory : IWebAuthenticationTransferTokenRequestFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IWebAuthenticationTransferTokenRequestFactory);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationTransferTokenRequestFactory*, Guid*, void**, int>)(lpVtbl[0]))((IWebAuthenticationTransferTokenRequestFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationTransferTokenRequestFactory*, uint>)(lpVtbl[1]))((IWebAuthenticationTransferTokenRequestFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationTransferTokenRequestFactory*, uint>)(lpVtbl[2]))((IWebAuthenticationTransferTokenRequestFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationTransferTokenRequestFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IWebAuthenticationTransferTokenRequestFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationTransferTokenRequestFactory*, HSTRING*, int>)(lpVtbl[4]))((IWebAuthenticationTransferTokenRequestFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationTransferTokenRequestFactory*, TrustLevel*, int>)(lpVtbl[5]))((IWebAuthenticationTransferTokenRequestFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IWebAuthenticationTransferTokenRequestFactory.xml' path='doc/member[@name="IWebAuthenticationTransferTokenRequestFactory.Create"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create([NativeTypeName("ABI::Windows::Security::Credentials::IWebAccountProvider *")] IWebAccountProvider* provider, HSTRING transferToken, [NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::IWebAuthenticationTransferTokenRequest **")] IWebAuthenticationTransferTokenRequest** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationTransferTokenRequestFactory*, IWebAccountProvider*, HSTRING, IWebAuthenticationTransferTokenRequest**, int>)(lpVtbl[6]))((IWebAuthenticationTransferTokenRequestFactory*)Unsafe.AsPointer(ref this), provider, transferToken, value);
    }

    /// <include file='IWebAuthenticationTransferTokenRequestFactory.xml' path='doc/member[@name="IWebAuthenticationTransferTokenRequestFactory.CreateWithCorrelationId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateWithCorrelationId([NativeTypeName("ABI::Windows::Security::Credentials::IWebAccountProvider *")] IWebAccountProvider* provider, HSTRING transferToken, HSTRING correlationId, [NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::IWebAuthenticationTransferTokenRequest **")] IWebAuthenticationTransferTokenRequest** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAuthenticationTransferTokenRequestFactory*, IWebAccountProvider*, HSTRING, HSTRING, IWebAuthenticationTransferTokenRequest**, int>)(lpVtbl[7]))((IWebAuthenticationTransferTokenRequestFactory*)Unsafe.AsPointer(ref this), provider, transferToken, correlationId, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create([NativeTypeName("ABI::Windows::Security::Credentials::IWebAccountProvider *")] IWebAccountProvider* provider, HSTRING transferToken, [NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::IWebAuthenticationTransferTokenRequest **")] IWebAuthenticationTransferTokenRequest** value);

        [VtblIndex(7)]
        HRESULT CreateWithCorrelationId([NativeTypeName("ABI::Windows::Security::Credentials::IWebAccountProvider *")] IWebAccountProvider* provider, HSTRING transferToken, HSTRING correlationId, [NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::IWebAuthenticationTransferTokenRequest **")] IWebAuthenticationTransferTokenRequest** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Security::Credentials::IWebAccountProvider *, HSTRING, ABI::Windows::Security::Authentication::Web::Core::IWebAuthenticationTransferTokenRequest **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWebAccountProvider*, HSTRING, IWebAuthenticationTransferTokenRequest**, int> Create;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Credentials::IWebAccountProvider *, HSTRING, HSTRING, ABI::Windows::Security::Authentication::Web::Core::IWebAuthenticationTransferTokenRequest **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWebAccountProvider*, HSTRING, HSTRING, IWebAuthenticationTransferTokenRequest**, int> CreateWithCorrelationId;
    }
}
