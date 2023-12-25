// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.web.http.headers.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHttpProductInfoHeaderValueStatics.xml' path='doc/member[@name="IHttpProductInfoHeaderValueStatics"]/*' />
[Guid("DB7FD857-327A-4E73-81E5-7059A302B042")]
[NativeTypeName("struct IHttpProductInfoHeaderValueStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpProductInfoHeaderValueStatics : IHttpProductInfoHeaderValueStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpProductInfoHeaderValueStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpProductInfoHeaderValueStatics*, Guid*, void**, int>)(lpVtbl[0]))((IHttpProductInfoHeaderValueStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpProductInfoHeaderValueStatics*, uint>)(lpVtbl[1]))((IHttpProductInfoHeaderValueStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpProductInfoHeaderValueStatics*, uint>)(lpVtbl[2]))((IHttpProductInfoHeaderValueStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpProductInfoHeaderValueStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IHttpProductInfoHeaderValueStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpProductInfoHeaderValueStatics*, HSTRING*, int>)(lpVtbl[4]))((IHttpProductInfoHeaderValueStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpProductInfoHeaderValueStatics*, TrustLevel*, int>)(lpVtbl[5]))((IHttpProductInfoHeaderValueStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHttpProductInfoHeaderValueStatics.xml' path='doc/member[@name="IHttpProductInfoHeaderValueStatics.Parse"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Parse(HSTRING input, [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpProductInfoHeaderValue **")] IHttpProductInfoHeaderValue** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpProductInfoHeaderValueStatics*, HSTRING, IHttpProductInfoHeaderValue**, int>)(lpVtbl[6]))((IHttpProductInfoHeaderValueStatics*)Unsafe.AsPointer(ref this), input, result);
    }

    /// <include file='IHttpProductInfoHeaderValueStatics.xml' path='doc/member[@name="IHttpProductInfoHeaderValueStatics.TryParse"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT TryParse(HSTRING input, [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpProductInfoHeaderValue **")] IHttpProductInfoHeaderValue** productInfoHeaderValue, [NativeTypeName("boolean *")] byte* succeeded)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpProductInfoHeaderValueStatics*, HSTRING, IHttpProductInfoHeaderValue**, byte*, int>)(lpVtbl[7]))((IHttpProductInfoHeaderValueStatics*)Unsafe.AsPointer(ref this), input, productInfoHeaderValue, succeeded);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Parse(HSTRING input, [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpProductInfoHeaderValue **")] IHttpProductInfoHeaderValue** result);

        [VtblIndex(7)]
        HRESULT TryParse(HSTRING input, [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpProductInfoHeaderValue **")] IHttpProductInfoHeaderValue** productInfoHeaderValue, [NativeTypeName("boolean *")] byte* succeeded);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Web::Http::Headers::IHttpProductInfoHeaderValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IHttpProductInfoHeaderValue**, int> Parse;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Web::Http::Headers::IHttpProductInfoHeaderValue **, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IHttpProductInfoHeaderValue**, byte*, int> TryParse;
    }
}
