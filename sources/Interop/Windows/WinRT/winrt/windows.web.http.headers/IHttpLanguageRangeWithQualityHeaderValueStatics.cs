// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.web.http.headers.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHttpLanguageRangeWithQualityHeaderValueStatics.xml' path='doc/member[@name="IHttpLanguageRangeWithQualityHeaderValueStatics"]/*' />
[Guid("2541E146-F308-46F5-B695-42F54024EC68")]
[NativeTypeName("struct IHttpLanguageRangeWithQualityHeaderValueStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpLanguageRangeWithQualityHeaderValueStatics : IHttpLanguageRangeWithQualityHeaderValueStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpLanguageRangeWithQualityHeaderValueStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpLanguageRangeWithQualityHeaderValueStatics*, Guid*, void**, int>)(lpVtbl[0]))((IHttpLanguageRangeWithQualityHeaderValueStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpLanguageRangeWithQualityHeaderValueStatics*, uint>)(lpVtbl[1]))((IHttpLanguageRangeWithQualityHeaderValueStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpLanguageRangeWithQualityHeaderValueStatics*, uint>)(lpVtbl[2]))((IHttpLanguageRangeWithQualityHeaderValueStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpLanguageRangeWithQualityHeaderValueStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IHttpLanguageRangeWithQualityHeaderValueStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpLanguageRangeWithQualityHeaderValueStatics*, HSTRING*, int>)(lpVtbl[4]))((IHttpLanguageRangeWithQualityHeaderValueStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpLanguageRangeWithQualityHeaderValueStatics*, TrustLevel*, int>)(lpVtbl[5]))((IHttpLanguageRangeWithQualityHeaderValueStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHttpLanguageRangeWithQualityHeaderValueStatics.xml' path='doc/member[@name="IHttpLanguageRangeWithQualityHeaderValueStatics.Parse"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Parse(HSTRING input, [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpLanguageRangeWithQualityHeaderValue **")] IHttpLanguageRangeWithQualityHeaderValue** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpLanguageRangeWithQualityHeaderValueStatics*, HSTRING, IHttpLanguageRangeWithQualityHeaderValue**, int>)(lpVtbl[6]))((IHttpLanguageRangeWithQualityHeaderValueStatics*)Unsafe.AsPointer(ref this), input, result);
    }

    /// <include file='IHttpLanguageRangeWithQualityHeaderValueStatics.xml' path='doc/member[@name="IHttpLanguageRangeWithQualityHeaderValueStatics.TryParse"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT TryParse(HSTRING input, [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpLanguageRangeWithQualityHeaderValue **")] IHttpLanguageRangeWithQualityHeaderValue** languageRangeWithQualityHeaderValue, [NativeTypeName("boolean *")] byte* succeeded)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpLanguageRangeWithQualityHeaderValueStatics*, HSTRING, IHttpLanguageRangeWithQualityHeaderValue**, byte*, int>)(lpVtbl[7]))((IHttpLanguageRangeWithQualityHeaderValueStatics*)Unsafe.AsPointer(ref this), input, languageRangeWithQualityHeaderValue, succeeded);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Parse(HSTRING input, [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpLanguageRangeWithQualityHeaderValue **")] IHttpLanguageRangeWithQualityHeaderValue** result);

        [VtblIndex(7)]
        HRESULT TryParse(HSTRING input, [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpLanguageRangeWithQualityHeaderValue **")] IHttpLanguageRangeWithQualityHeaderValue** languageRangeWithQualityHeaderValue, [NativeTypeName("boolean *")] byte* succeeded);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Web::Http::Headers::IHttpLanguageRangeWithQualityHeaderValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IHttpLanguageRangeWithQualityHeaderValue**, int> Parse;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Web::Http::Headers::IHttpLanguageRangeWithQualityHeaderValue **, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IHttpLanguageRangeWithQualityHeaderValue**, byte*, int> TryParse;
    }
}
