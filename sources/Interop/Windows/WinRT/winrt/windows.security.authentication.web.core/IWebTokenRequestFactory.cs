// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.authentication.web.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IWebTokenRequestFactory.xml' path='doc/member[@name="IWebTokenRequestFactory"]/*' />
[Guid("6CF2141C-0FF0-4C67-B84F-99DDBE4A72C9")]
[NativeTypeName("struct IWebTokenRequestFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWebTokenRequestFactory : IWebTokenRequestFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWebTokenRequestFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebTokenRequestFactory*, Guid*, void**, int>)(lpVtbl[0]))((IWebTokenRequestFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebTokenRequestFactory*, uint>)(lpVtbl[1]))((IWebTokenRequestFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebTokenRequestFactory*, uint>)(lpVtbl[2]))((IWebTokenRequestFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebTokenRequestFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IWebTokenRequestFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebTokenRequestFactory*, HSTRING*, int>)(lpVtbl[4]))((IWebTokenRequestFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebTokenRequestFactory*, TrustLevel*, int>)(lpVtbl[5]))((IWebTokenRequestFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IWebTokenRequestFactory.xml' path='doc/member[@name="IWebTokenRequestFactory.Create"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create([NativeTypeName("ABI::Windows::Security::Credentials::IWebAccountProvider *")] IWebAccountProvider* provider, HSTRING scope, HSTRING clientId, [NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::IWebTokenRequest **")] IWebTokenRequest** webTokenRequest)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebTokenRequestFactory*, IWebAccountProvider*, HSTRING, HSTRING, IWebTokenRequest**, int>)(lpVtbl[6]))((IWebTokenRequestFactory*)Unsafe.AsPointer(ref this), provider, scope, clientId, webTokenRequest);
    }

    /// <include file='IWebTokenRequestFactory.xml' path='doc/member[@name="IWebTokenRequestFactory.CreateWithPromptType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateWithPromptType([NativeTypeName("ABI::Windows::Security::Credentials::IWebAccountProvider *")] IWebAccountProvider* provider, HSTRING scope, HSTRING clientId, [NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::WebTokenRequestPromptType")] WebTokenRequestPromptType promptType, [NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::IWebTokenRequest **")] IWebTokenRequest** webTokenRequest)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebTokenRequestFactory*, IWebAccountProvider*, HSTRING, HSTRING, WebTokenRequestPromptType, IWebTokenRequest**, int>)(lpVtbl[7]))((IWebTokenRequestFactory*)Unsafe.AsPointer(ref this), provider, scope, clientId, promptType, webTokenRequest);
    }

    /// <include file='IWebTokenRequestFactory.xml' path='doc/member[@name="IWebTokenRequestFactory.CreateWithProvider"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateWithProvider([NativeTypeName("ABI::Windows::Security::Credentials::IWebAccountProvider *")] IWebAccountProvider* provider, [NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::IWebTokenRequest **")] IWebTokenRequest** webTokenRequest)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebTokenRequestFactory*, IWebAccountProvider*, IWebTokenRequest**, int>)(lpVtbl[8]))((IWebTokenRequestFactory*)Unsafe.AsPointer(ref this), provider, webTokenRequest);
    }

    /// <include file='IWebTokenRequestFactory.xml' path='doc/member[@name="IWebTokenRequestFactory.CreateWithScope"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateWithScope([NativeTypeName("ABI::Windows::Security::Credentials::IWebAccountProvider *")] IWebAccountProvider* provider, HSTRING scope, [NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::IWebTokenRequest **")] IWebTokenRequest** webTokenRequest)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebTokenRequestFactory*, IWebAccountProvider*, HSTRING, IWebTokenRequest**, int>)(lpVtbl[9]))((IWebTokenRequestFactory*)Unsafe.AsPointer(ref this), provider, scope, webTokenRequest);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create([NativeTypeName("ABI::Windows::Security::Credentials::IWebAccountProvider *")] IWebAccountProvider* provider, HSTRING scope, HSTRING clientId, [NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::IWebTokenRequest **")] IWebTokenRequest** webTokenRequest);

        [VtblIndex(7)]
        HRESULT CreateWithPromptType([NativeTypeName("ABI::Windows::Security::Credentials::IWebAccountProvider *")] IWebAccountProvider* provider, HSTRING scope, HSTRING clientId, [NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::WebTokenRequestPromptType")] WebTokenRequestPromptType promptType, [NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::IWebTokenRequest **")] IWebTokenRequest** webTokenRequest);

        [VtblIndex(8)]
        HRESULT CreateWithProvider([NativeTypeName("ABI::Windows::Security::Credentials::IWebAccountProvider *")] IWebAccountProvider* provider, [NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::IWebTokenRequest **")] IWebTokenRequest** webTokenRequest);

        [VtblIndex(9)]
        HRESULT CreateWithScope([NativeTypeName("ABI::Windows::Security::Credentials::IWebAccountProvider *")] IWebAccountProvider* provider, HSTRING scope, [NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::IWebTokenRequest **")] IWebTokenRequest** webTokenRequest);
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

        [NativeTypeName("HRESULT (ABI::Windows::Security::Credentials::IWebAccountProvider *, HSTRING, HSTRING, ABI::Windows::Security::Authentication::Web::Core::IWebTokenRequest **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWebAccountProvider*, HSTRING, HSTRING, IWebTokenRequest**, int> Create;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Credentials::IWebAccountProvider *, HSTRING, HSTRING, ABI::Windows::Security::Authentication::Web::Core::WebTokenRequestPromptType, ABI::Windows::Security::Authentication::Web::Core::IWebTokenRequest **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWebAccountProvider*, HSTRING, HSTRING, WebTokenRequestPromptType, IWebTokenRequest**, int> CreateWithPromptType;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Credentials::IWebAccountProvider *, ABI::Windows::Security::Authentication::Web::Core::IWebTokenRequest **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWebAccountProvider*, IWebTokenRequest**, int> CreateWithProvider;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Credentials::IWebAccountProvider *, HSTRING, ABI::Windows::Security::Authentication::Web::Core::IWebTokenRequest **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWebAccountProvider*, HSTRING, IWebTokenRequest**, int> CreateWithScope;
    }
}
