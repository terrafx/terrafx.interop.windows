// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.web.http.headers.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHttpMediaTypeWithQualityHeaderValueFactory.xml' path='doc/member[@name="IHttpMediaTypeWithQualityHeaderValueFactory"]/*' />
[Guid("4C6D20F4-9457-44E6-A323-D122B958780B")]
[NativeTypeName("struct IHttpMediaTypeWithQualityHeaderValueFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpMediaTypeWithQualityHeaderValueFactory : IHttpMediaTypeWithQualityHeaderValueFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpMediaTypeWithQualityHeaderValueFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpMediaTypeWithQualityHeaderValueFactory*, Guid*, void**, int>)(lpVtbl[0]))((IHttpMediaTypeWithQualityHeaderValueFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpMediaTypeWithQualityHeaderValueFactory*, uint>)(lpVtbl[1]))((IHttpMediaTypeWithQualityHeaderValueFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpMediaTypeWithQualityHeaderValueFactory*, uint>)(lpVtbl[2]))((IHttpMediaTypeWithQualityHeaderValueFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpMediaTypeWithQualityHeaderValueFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IHttpMediaTypeWithQualityHeaderValueFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpMediaTypeWithQualityHeaderValueFactory*, HSTRING*, int>)(lpVtbl[4]))((IHttpMediaTypeWithQualityHeaderValueFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpMediaTypeWithQualityHeaderValueFactory*, TrustLevel*, int>)(lpVtbl[5]))((IHttpMediaTypeWithQualityHeaderValueFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHttpMediaTypeWithQualityHeaderValueFactory.xml' path='doc/member[@name="IHttpMediaTypeWithQualityHeaderValueFactory.CreateFromMediaType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFromMediaType(HSTRING mediaType, [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpMediaTypeWithQualityHeaderValue **")] IHttpMediaTypeWithQualityHeaderValue** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpMediaTypeWithQualityHeaderValueFactory*, HSTRING, IHttpMediaTypeWithQualityHeaderValue**, int>)(lpVtbl[6]))((IHttpMediaTypeWithQualityHeaderValueFactory*)Unsafe.AsPointer(ref this), mediaType, value);
    }

    /// <include file='IHttpMediaTypeWithQualityHeaderValueFactory.xml' path='doc/member[@name="IHttpMediaTypeWithQualityHeaderValueFactory.CreateFromMediaTypeWithQuality"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFromMediaTypeWithQuality(HSTRING mediaType, double quality, [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpMediaTypeWithQualityHeaderValue **")] IHttpMediaTypeWithQualityHeaderValue** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpMediaTypeWithQualityHeaderValueFactory*, HSTRING, double, IHttpMediaTypeWithQualityHeaderValue**, int>)(lpVtbl[7]))((IHttpMediaTypeWithQualityHeaderValueFactory*)Unsafe.AsPointer(ref this), mediaType, quality, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFromMediaType(HSTRING mediaType, [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpMediaTypeWithQualityHeaderValue **")] IHttpMediaTypeWithQualityHeaderValue** value);

        [VtblIndex(7)]
        HRESULT CreateFromMediaTypeWithQuality(HSTRING mediaType, double quality, [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpMediaTypeWithQualityHeaderValue **")] IHttpMediaTypeWithQualityHeaderValue** value);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Web::Http::Headers::IHttpMediaTypeWithQualityHeaderValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IHttpMediaTypeWithQualityHeaderValue**, int> CreateFromMediaType;

        [NativeTypeName("HRESULT (HSTRING, DOUBLE, ABI::Windows::Web::Http::Headers::IHttpMediaTypeWithQualityHeaderValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, double, IHttpMediaTypeWithQualityHeaderValue**, int> CreateFromMediaTypeWithQuality;
    }
}
