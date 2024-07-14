// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.web.http.headers.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHttpCredentialsHeaderValueFactory.xml' path='doc/member[@name="IHttpCredentialsHeaderValueFactory"]/*' />
[Guid("F21D9E91-4D1C-4182-BFD1-34470A62F950")]
[NativeTypeName("struct IHttpCredentialsHeaderValueFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpCredentialsHeaderValueFactory : IHttpCredentialsHeaderValueFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpCredentialsHeaderValueFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCredentialsHeaderValueFactory*, Guid*, void**, int>)(lpVtbl[0]))((IHttpCredentialsHeaderValueFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCredentialsHeaderValueFactory*, uint>)(lpVtbl[1]))((IHttpCredentialsHeaderValueFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCredentialsHeaderValueFactory*, uint>)(lpVtbl[2]))((IHttpCredentialsHeaderValueFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCredentialsHeaderValueFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IHttpCredentialsHeaderValueFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCredentialsHeaderValueFactory*, HSTRING*, int>)(lpVtbl[4]))((IHttpCredentialsHeaderValueFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCredentialsHeaderValueFactory*, TrustLevel*, int>)(lpVtbl[5]))((IHttpCredentialsHeaderValueFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHttpCredentialsHeaderValueFactory.xml' path='doc/member[@name="IHttpCredentialsHeaderValueFactory.CreateFromScheme"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFromScheme(HSTRING scheme, [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpCredentialsHeaderValue **")] IHttpCredentialsHeaderValue** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCredentialsHeaderValueFactory*, HSTRING, IHttpCredentialsHeaderValue**, int>)(lpVtbl[6]))((IHttpCredentialsHeaderValueFactory*)Unsafe.AsPointer(ref this), scheme, value);
    }

    /// <include file='IHttpCredentialsHeaderValueFactory.xml' path='doc/member[@name="IHttpCredentialsHeaderValueFactory.CreateFromSchemeWithToken"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFromSchemeWithToken(HSTRING scheme, HSTRING token, [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpCredentialsHeaderValue **")] IHttpCredentialsHeaderValue** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCredentialsHeaderValueFactory*, HSTRING, HSTRING, IHttpCredentialsHeaderValue**, int>)(lpVtbl[7]))((IHttpCredentialsHeaderValueFactory*)Unsafe.AsPointer(ref this), scheme, token, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFromScheme(HSTRING scheme, [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpCredentialsHeaderValue **")] IHttpCredentialsHeaderValue** value);

        [VtblIndex(7)]
        HRESULT CreateFromSchemeWithToken(HSTRING scheme, HSTRING token, [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpCredentialsHeaderValue **")] IHttpCredentialsHeaderValue** value);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Web::Http::Headers::IHttpCredentialsHeaderValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IHttpCredentialsHeaderValue**, int> CreateFromScheme;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Web::Http::Headers::IHttpCredentialsHeaderValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IHttpCredentialsHeaderValue**, int> CreateFromSchemeWithToken;
    }
}
