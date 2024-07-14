// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.web.http.headers.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHttpChallengeHeaderValueFactory.xml' path='doc/member[@name="IHttpChallengeHeaderValueFactory"]/*' />
[Guid("C452C451-D99C-40AA-9399-90EEB98FC613")]
[NativeTypeName("struct IHttpChallengeHeaderValueFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpChallengeHeaderValueFactory : IHttpChallengeHeaderValueFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpChallengeHeaderValueFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpChallengeHeaderValueFactory*, Guid*, void**, int>)(lpVtbl[0]))((IHttpChallengeHeaderValueFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpChallengeHeaderValueFactory*, uint>)(lpVtbl[1]))((IHttpChallengeHeaderValueFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpChallengeHeaderValueFactory*, uint>)(lpVtbl[2]))((IHttpChallengeHeaderValueFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpChallengeHeaderValueFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IHttpChallengeHeaderValueFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpChallengeHeaderValueFactory*, HSTRING*, int>)(lpVtbl[4]))((IHttpChallengeHeaderValueFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpChallengeHeaderValueFactory*, TrustLevel*, int>)(lpVtbl[5]))((IHttpChallengeHeaderValueFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHttpChallengeHeaderValueFactory.xml' path='doc/member[@name="IHttpChallengeHeaderValueFactory.CreateFromScheme"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFromScheme(HSTRING scheme, [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpChallengeHeaderValue **")] IHttpChallengeHeaderValue** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpChallengeHeaderValueFactory*, HSTRING, IHttpChallengeHeaderValue**, int>)(lpVtbl[6]))((IHttpChallengeHeaderValueFactory*)Unsafe.AsPointer(ref this), scheme, value);
    }

    /// <include file='IHttpChallengeHeaderValueFactory.xml' path='doc/member[@name="IHttpChallengeHeaderValueFactory.CreateFromSchemeWithToken"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFromSchemeWithToken(HSTRING scheme, HSTRING token, [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpChallengeHeaderValue **")] IHttpChallengeHeaderValue** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpChallengeHeaderValueFactory*, HSTRING, HSTRING, IHttpChallengeHeaderValue**, int>)(lpVtbl[7]))((IHttpChallengeHeaderValueFactory*)Unsafe.AsPointer(ref this), scheme, token, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFromScheme(HSTRING scheme, [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpChallengeHeaderValue **")] IHttpChallengeHeaderValue** value);

        [VtblIndex(7)]
        HRESULT CreateFromSchemeWithToken(HSTRING scheme, HSTRING token, [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpChallengeHeaderValue **")] IHttpChallengeHeaderValue** value);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Web::Http::Headers::IHttpChallengeHeaderValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IHttpChallengeHeaderValue**, int> CreateFromScheme;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Web::Http::Headers::IHttpChallengeHeaderValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IHttpChallengeHeaderValue**, int> CreateFromSchemeWithToken;
    }
}
