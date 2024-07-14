// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.authentication.web.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IWebTokenResponse.xml' path='doc/member[@name="IWebTokenResponse"]/*' />
[Guid("67A7C5CA-83F6-44C6-A3B1-0EB69E41FA8A")]
[NativeTypeName("struct IWebTokenResponse : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWebTokenResponse : IWebTokenResponse.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWebTokenResponse));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebTokenResponse*, Guid*, void**, int>)(lpVtbl[0]))((IWebTokenResponse*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebTokenResponse*, uint>)(lpVtbl[1]))((IWebTokenResponse*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebTokenResponse*, uint>)(lpVtbl[2]))((IWebTokenResponse*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebTokenResponse*, uint*, Guid**, int>)(lpVtbl[3]))((IWebTokenResponse*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebTokenResponse*, HSTRING*, int>)(lpVtbl[4]))((IWebTokenResponse*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebTokenResponse*, TrustLevel*, int>)(lpVtbl[5]))((IWebTokenResponse*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IWebTokenResponse.xml' path='doc/member[@name="IWebTokenResponse.get_Token"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Token(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebTokenResponse*, HSTRING*, int>)(lpVtbl[6]))((IWebTokenResponse*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWebTokenResponse.xml' path='doc/member[@name="IWebTokenResponse.get_ProviderError"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ProviderError([NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::IWebProviderError **")] IWebProviderError** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebTokenResponse*, IWebProviderError**, int>)(lpVtbl[7]))((IWebTokenResponse*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWebTokenResponse.xml' path='doc/member[@name="IWebTokenResponse.get_WebAccount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_WebAccount([NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount **")] IWebAccount** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebTokenResponse*, IWebAccount**, int>)(lpVtbl[8]))((IWebTokenResponse*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWebTokenResponse.xml' path='doc/member[@name="IWebTokenResponse.get_Properties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Properties([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_HSTRING_t **")] IMap<HSTRING, HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebTokenResponse*, IMap<HSTRING, HSTRING>**, int>)(lpVtbl[9]))((IWebTokenResponse*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Token(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_ProviderError([NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::IWebProviderError **")] IWebProviderError** value);

        [VtblIndex(8)]
        HRESULT get_WebAccount([NativeTypeName("ABI::Windows::Security::Credentials::IWebAccount **")] IWebAccount** value);

        [VtblIndex(9)]
        HRESULT get_Properties([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_HSTRING_t **")] IMap<HSTRING, HSTRING>** value);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Token;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Authentication::Web::Core::IWebProviderError **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWebProviderError**, int> get_ProviderError;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Credentials::IWebAccount **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWebAccount**, int> get_WebAccount;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMap<HSTRING, HSTRING>**, int> get_Properties;
    }
}
