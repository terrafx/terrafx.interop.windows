// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.web.http.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHttpStringContentFactory.xml' path='doc/member[@name="IHttpStringContentFactory"]/*' />
[Guid("46649D5B-2E93-48EB-8E61-19677878E57F")]
[NativeTypeName("struct IHttpStringContentFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpStringContentFactory : IHttpStringContentFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpStringContentFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpStringContentFactory*, Guid*, void**, int>)(lpVtbl[0]))((IHttpStringContentFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpStringContentFactory*, uint>)(lpVtbl[1]))((IHttpStringContentFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpStringContentFactory*, uint>)(lpVtbl[2]))((IHttpStringContentFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpStringContentFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IHttpStringContentFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpStringContentFactory*, HSTRING*, int>)(lpVtbl[4]))((IHttpStringContentFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpStringContentFactory*, TrustLevel*, int>)(lpVtbl[5]))((IHttpStringContentFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHttpStringContentFactory.xml' path='doc/member[@name="IHttpStringContentFactory.CreateFromString"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFromString(HSTRING content, [NativeTypeName("ABI::Windows::Web::Http::IHttpContent **")] IHttpContent** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpStringContentFactory*, HSTRING, IHttpContent**, int>)(lpVtbl[6]))((IHttpStringContentFactory*)Unsafe.AsPointer(ref this), content, value);
    }

    /// <include file='IHttpStringContentFactory.xml' path='doc/member[@name="IHttpStringContentFactory.CreateFromStringWithEncoding"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFromStringWithEncoding(HSTRING content, [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")] UnicodeEncoding encoding, [NativeTypeName("ABI::Windows::Web::Http::IHttpContent **")] IHttpContent** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpStringContentFactory*, HSTRING, UnicodeEncoding, IHttpContent**, int>)(lpVtbl[7]))((IHttpStringContentFactory*)Unsafe.AsPointer(ref this), content, encoding, value);
    }

    /// <include file='IHttpStringContentFactory.xml' path='doc/member[@name="IHttpStringContentFactory.CreateFromStringWithEncodingAndMediaType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateFromStringWithEncodingAndMediaType(HSTRING content, [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")] UnicodeEncoding encoding, HSTRING mediaType, [NativeTypeName("ABI::Windows::Web::Http::IHttpContent **")] IHttpContent** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpStringContentFactory*, HSTRING, UnicodeEncoding, HSTRING, IHttpContent**, int>)(lpVtbl[8]))((IHttpStringContentFactory*)Unsafe.AsPointer(ref this), content, encoding, mediaType, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFromString(HSTRING content, [NativeTypeName("ABI::Windows::Web::Http::IHttpContent **")] IHttpContent** value);

        [VtblIndex(7)]
        HRESULT CreateFromStringWithEncoding(HSTRING content, [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")] UnicodeEncoding encoding, [NativeTypeName("ABI::Windows::Web::Http::IHttpContent **")] IHttpContent** value);

        [VtblIndex(8)]
        HRESULT CreateFromStringWithEncodingAndMediaType(HSTRING content, [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")] UnicodeEncoding encoding, HSTRING mediaType, [NativeTypeName("ABI::Windows::Web::Http::IHttpContent **")] IHttpContent** value);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Web::Http::IHttpContent **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IHttpContent**, int> CreateFromString;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Storage::Streams::UnicodeEncoding, ABI::Windows::Web::Http::IHttpContent **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, UnicodeEncoding, IHttpContent**, int> CreateFromStringWithEncoding;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Storage::Streams::UnicodeEncoding, HSTRING, ABI::Windows::Web::Http::IHttpContent **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, UnicodeEncoding, HSTRING, IHttpContent**, int> CreateFromStringWithEncodingAndMediaType;
    }
}
