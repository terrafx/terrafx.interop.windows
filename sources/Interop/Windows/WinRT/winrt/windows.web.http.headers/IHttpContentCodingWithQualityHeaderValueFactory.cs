// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.web.http.headers.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHttpContentCodingWithQualityHeaderValueFactory.xml' path='doc/member[@name="IHttpContentCodingWithQualityHeaderValueFactory"]/*' />
[Guid("C45EEE1A-C553-46FC-ADE2-D75C1D53DF7B")]
[NativeTypeName("struct IHttpContentCodingWithQualityHeaderValueFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpContentCodingWithQualityHeaderValueFactory : IHttpContentCodingWithQualityHeaderValueFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpContentCodingWithQualityHeaderValueFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContentCodingWithQualityHeaderValueFactory*, Guid*, void**, int>)(lpVtbl[0]))((IHttpContentCodingWithQualityHeaderValueFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContentCodingWithQualityHeaderValueFactory*, uint>)(lpVtbl[1]))((IHttpContentCodingWithQualityHeaderValueFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContentCodingWithQualityHeaderValueFactory*, uint>)(lpVtbl[2]))((IHttpContentCodingWithQualityHeaderValueFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContentCodingWithQualityHeaderValueFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IHttpContentCodingWithQualityHeaderValueFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContentCodingWithQualityHeaderValueFactory*, HSTRING*, int>)(lpVtbl[4]))((IHttpContentCodingWithQualityHeaderValueFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContentCodingWithQualityHeaderValueFactory*, TrustLevel*, int>)(lpVtbl[5]))((IHttpContentCodingWithQualityHeaderValueFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHttpContentCodingWithQualityHeaderValueFactory.xml' path='doc/member[@name="IHttpContentCodingWithQualityHeaderValueFactory.CreateFromValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFromValue(HSTRING contentCoding, [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpContentCodingWithQualityHeaderValue **")] IHttpContentCodingWithQualityHeaderValue** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContentCodingWithQualityHeaderValueFactory*, HSTRING, IHttpContentCodingWithQualityHeaderValue**, int>)(lpVtbl[6]))((IHttpContentCodingWithQualityHeaderValueFactory*)Unsafe.AsPointer(ref this), contentCoding, value);
    }

    /// <include file='IHttpContentCodingWithQualityHeaderValueFactory.xml' path='doc/member[@name="IHttpContentCodingWithQualityHeaderValueFactory.CreateFromValueWithQuality"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFromValueWithQuality(HSTRING contentCoding, double quality, [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpContentCodingWithQualityHeaderValue **")] IHttpContentCodingWithQualityHeaderValue** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContentCodingWithQualityHeaderValueFactory*, HSTRING, double, IHttpContentCodingWithQualityHeaderValue**, int>)(lpVtbl[7]))((IHttpContentCodingWithQualityHeaderValueFactory*)Unsafe.AsPointer(ref this), contentCoding, quality, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFromValue(HSTRING contentCoding, [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpContentCodingWithQualityHeaderValue **")] IHttpContentCodingWithQualityHeaderValue** value);

        [VtblIndex(7)]
        HRESULT CreateFromValueWithQuality(HSTRING contentCoding, double quality, [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpContentCodingWithQualityHeaderValue **")] IHttpContentCodingWithQualityHeaderValue** value);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Web::Http::Headers::IHttpContentCodingWithQualityHeaderValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IHttpContentCodingWithQualityHeaderValue**, int> CreateFromValue;

        [NativeTypeName("HRESULT (HSTRING, DOUBLE, ABI::Windows::Web::Http::Headers::IHttpContentCodingWithQualityHeaderValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, double, IHttpContentCodingWithQualityHeaderValue**, int> CreateFromValueWithQuality;
    }
}
