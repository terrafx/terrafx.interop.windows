// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.web.http.headers.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHttpCookiePairHeaderValueFactory.xml' path='doc/member[@name="IHttpCookiePairHeaderValueFactory"]/*' />
[Guid("635E326F-146F-4F56-AA21-2CB7D6D58B1E")]
[NativeTypeName("struct IHttpCookiePairHeaderValueFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpCookiePairHeaderValueFactory : IHttpCookiePairHeaderValueFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpCookiePairHeaderValueFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCookiePairHeaderValueFactory*, Guid*, void**, int>)(lpVtbl[0]))((IHttpCookiePairHeaderValueFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCookiePairHeaderValueFactory*, uint>)(lpVtbl[1]))((IHttpCookiePairHeaderValueFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCookiePairHeaderValueFactory*, uint>)(lpVtbl[2]))((IHttpCookiePairHeaderValueFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCookiePairHeaderValueFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IHttpCookiePairHeaderValueFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCookiePairHeaderValueFactory*, HSTRING*, int>)(lpVtbl[4]))((IHttpCookiePairHeaderValueFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCookiePairHeaderValueFactory*, TrustLevel*, int>)(lpVtbl[5]))((IHttpCookiePairHeaderValueFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHttpCookiePairHeaderValueFactory.xml' path='doc/member[@name="IHttpCookiePairHeaderValueFactory.CreateFromName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFromName(HSTRING name, [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpCookiePairHeaderValue **")] IHttpCookiePairHeaderValue** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCookiePairHeaderValueFactory*, HSTRING, IHttpCookiePairHeaderValue**, int>)(lpVtbl[6]))((IHttpCookiePairHeaderValueFactory*)Unsafe.AsPointer(ref this), name, value);
    }

    /// <include file='IHttpCookiePairHeaderValueFactory.xml' path='doc/member[@name="IHttpCookiePairHeaderValueFactory.CreateFromNameWithValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFromNameWithValue(HSTRING name, HSTRING value, [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpCookiePairHeaderValue **")] IHttpCookiePairHeaderValue** cookiePairHeaderValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCookiePairHeaderValueFactory*, HSTRING, HSTRING, IHttpCookiePairHeaderValue**, int>)(lpVtbl[7]))((IHttpCookiePairHeaderValueFactory*)Unsafe.AsPointer(ref this), name, value, cookiePairHeaderValue);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFromName(HSTRING name, [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpCookiePairHeaderValue **")] IHttpCookiePairHeaderValue** value);

        [VtblIndex(7)]
        HRESULT CreateFromNameWithValue(HSTRING name, HSTRING value, [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpCookiePairHeaderValue **")] IHttpCookiePairHeaderValue** cookiePairHeaderValue);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Web::Http::Headers::IHttpCookiePairHeaderValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IHttpCookiePairHeaderValue**, int> CreateFromName;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Web::Http::Headers::IHttpCookiePairHeaderValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IHttpCookiePairHeaderValue**, int> CreateFromNameWithValue;
    }
}
