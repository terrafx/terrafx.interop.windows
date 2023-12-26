// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.web.http.headers.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHttpLanguageRangeWithQualityHeaderValueFactory.xml' path='doc/member[@name="IHttpLanguageRangeWithQualityHeaderValueFactory"]/*' />
[Guid("7BB83970-780F-4C83-9FE4-DC3087F6BD55")]
[NativeTypeName("struct IHttpLanguageRangeWithQualityHeaderValueFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpLanguageRangeWithQualityHeaderValueFactory : IHttpLanguageRangeWithQualityHeaderValueFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpLanguageRangeWithQualityHeaderValueFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpLanguageRangeWithQualityHeaderValueFactory*, Guid*, void**, int>)(lpVtbl[0]))((IHttpLanguageRangeWithQualityHeaderValueFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpLanguageRangeWithQualityHeaderValueFactory*, uint>)(lpVtbl[1]))((IHttpLanguageRangeWithQualityHeaderValueFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpLanguageRangeWithQualityHeaderValueFactory*, uint>)(lpVtbl[2]))((IHttpLanguageRangeWithQualityHeaderValueFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpLanguageRangeWithQualityHeaderValueFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IHttpLanguageRangeWithQualityHeaderValueFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpLanguageRangeWithQualityHeaderValueFactory*, HSTRING*, int>)(lpVtbl[4]))((IHttpLanguageRangeWithQualityHeaderValueFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpLanguageRangeWithQualityHeaderValueFactory*, TrustLevel*, int>)(lpVtbl[5]))((IHttpLanguageRangeWithQualityHeaderValueFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHttpLanguageRangeWithQualityHeaderValueFactory.xml' path='doc/member[@name="IHttpLanguageRangeWithQualityHeaderValueFactory.CreateFromLanguageRange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFromLanguageRange(HSTRING languageRange, [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpLanguageRangeWithQualityHeaderValue **")] IHttpLanguageRangeWithQualityHeaderValue** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpLanguageRangeWithQualityHeaderValueFactory*, HSTRING, IHttpLanguageRangeWithQualityHeaderValue**, int>)(lpVtbl[6]))((IHttpLanguageRangeWithQualityHeaderValueFactory*)Unsafe.AsPointer(ref this), languageRange, value);
    }

    /// <include file='IHttpLanguageRangeWithQualityHeaderValueFactory.xml' path='doc/member[@name="IHttpLanguageRangeWithQualityHeaderValueFactory.CreateFromLanguageRangeWithQuality"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFromLanguageRangeWithQuality(HSTRING languageRange, double quality, [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpLanguageRangeWithQualityHeaderValue **")] IHttpLanguageRangeWithQualityHeaderValue** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpLanguageRangeWithQualityHeaderValueFactory*, HSTRING, double, IHttpLanguageRangeWithQualityHeaderValue**, int>)(lpVtbl[7]))((IHttpLanguageRangeWithQualityHeaderValueFactory*)Unsafe.AsPointer(ref this), languageRange, quality, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFromLanguageRange(HSTRING languageRange, [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpLanguageRangeWithQualityHeaderValue **")] IHttpLanguageRangeWithQualityHeaderValue** value);

        [VtblIndex(7)]
        HRESULT CreateFromLanguageRangeWithQuality(HSTRING languageRange, double quality, [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpLanguageRangeWithQualityHeaderValue **")] IHttpLanguageRangeWithQualityHeaderValue** value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IHttpLanguageRangeWithQualityHeaderValue**, int> CreateFromLanguageRange;

        [NativeTypeName("HRESULT (HSTRING, DOUBLE, ABI::Windows::Web::Http::Headers::IHttpLanguageRangeWithQualityHeaderValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, double, IHttpLanguageRangeWithQualityHeaderValue**, int> CreateFromLanguageRangeWithQuality;
    }
}
