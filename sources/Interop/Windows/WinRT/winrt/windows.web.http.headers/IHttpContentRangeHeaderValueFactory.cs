// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.web.http.headers.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHttpContentRangeHeaderValueFactory.xml' path='doc/member[@name="IHttpContentRangeHeaderValueFactory"]/*' />
[Guid("3F5BD691-A03C-4456-9A6F-EF27ECD03CAE")]
[NativeTypeName("struct IHttpContentRangeHeaderValueFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpContentRangeHeaderValueFactory : IHttpContentRangeHeaderValueFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IHttpContentRangeHeaderValueFactory);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContentRangeHeaderValueFactory*, Guid*, void**, int>)(lpVtbl[0]))((IHttpContentRangeHeaderValueFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContentRangeHeaderValueFactory*, uint>)(lpVtbl[1]))((IHttpContentRangeHeaderValueFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContentRangeHeaderValueFactory*, uint>)(lpVtbl[2]))((IHttpContentRangeHeaderValueFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContentRangeHeaderValueFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IHttpContentRangeHeaderValueFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContentRangeHeaderValueFactory*, HSTRING*, int>)(lpVtbl[4]))((IHttpContentRangeHeaderValueFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContentRangeHeaderValueFactory*, TrustLevel*, int>)(lpVtbl[5]))((IHttpContentRangeHeaderValueFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHttpContentRangeHeaderValueFactory.xml' path='doc/member[@name="IHttpContentRangeHeaderValueFactory.CreateFromLength"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFromLength([NativeTypeName("UINT64")] ulong length, [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpContentRangeHeaderValue **")] IHttpContentRangeHeaderValue** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContentRangeHeaderValueFactory*, ulong, IHttpContentRangeHeaderValue**, int>)(lpVtbl[6]))((IHttpContentRangeHeaderValueFactory*)Unsafe.AsPointer(ref this), length, value);
    }

    /// <include file='IHttpContentRangeHeaderValueFactory.xml' path='doc/member[@name="IHttpContentRangeHeaderValueFactory.CreateFromRange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFromRange([NativeTypeName("UINT64")] ulong from, [NativeTypeName("UINT64")] ulong to, [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpContentRangeHeaderValue **")] IHttpContentRangeHeaderValue** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContentRangeHeaderValueFactory*, ulong, ulong, IHttpContentRangeHeaderValue**, int>)(lpVtbl[7]))((IHttpContentRangeHeaderValueFactory*)Unsafe.AsPointer(ref this), from, to, value);
    }

    /// <include file='IHttpContentRangeHeaderValueFactory.xml' path='doc/member[@name="IHttpContentRangeHeaderValueFactory.CreateFromRangeWithLength"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateFromRangeWithLength([NativeTypeName("UINT64")] ulong from, [NativeTypeName("UINT64")] ulong to, [NativeTypeName("UINT64")] ulong length, [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpContentRangeHeaderValue **")] IHttpContentRangeHeaderValue** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContentRangeHeaderValueFactory*, ulong, ulong, ulong, IHttpContentRangeHeaderValue**, int>)(lpVtbl[8]))((IHttpContentRangeHeaderValueFactory*)Unsafe.AsPointer(ref this), from, to, length, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFromLength([NativeTypeName("UINT64")] ulong length, [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpContentRangeHeaderValue **")] IHttpContentRangeHeaderValue** value);

        [VtblIndex(7)]
        HRESULT CreateFromRange([NativeTypeName("UINT64")] ulong from, [NativeTypeName("UINT64")] ulong to, [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpContentRangeHeaderValue **")] IHttpContentRangeHeaderValue** value);

        [VtblIndex(8)]
        HRESULT CreateFromRangeWithLength([NativeTypeName("UINT64")] ulong from, [NativeTypeName("UINT64")] ulong to, [NativeTypeName("UINT64")] ulong length, [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpContentRangeHeaderValue **")] IHttpContentRangeHeaderValue** value);
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

        [NativeTypeName("HRESULT (UINT64, ABI::Windows::Web::Http::Headers::IHttpContentRangeHeaderValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong, IHttpContentRangeHeaderValue**, int> CreateFromLength;

        [NativeTypeName("HRESULT (UINT64, UINT64, ABI::Windows::Web::Http::Headers::IHttpContentRangeHeaderValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong, ulong, IHttpContentRangeHeaderValue**, int> CreateFromRange;

        [NativeTypeName("HRESULT (UINT64, UINT64, UINT64, ABI::Windows::Web::Http::Headers::IHttpContentRangeHeaderValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong, ulong, ulong, IHttpContentRangeHeaderValue**, int> CreateFromRangeWithLength;
    }
}
