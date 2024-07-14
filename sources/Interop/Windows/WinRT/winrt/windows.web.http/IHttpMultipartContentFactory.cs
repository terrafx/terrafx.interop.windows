// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.web.http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHttpMultipartContentFactory.xml' path='doc/member[@name="IHttpMultipartContentFactory"]/*' />
[Guid("7EB42E62-0222-4F20-B372-47D5DB5D33B4")]
[NativeTypeName("struct IHttpMultipartContentFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpMultipartContentFactory : IHttpMultipartContentFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpMultipartContentFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpMultipartContentFactory*, Guid*, void**, int>)(lpVtbl[0]))((IHttpMultipartContentFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpMultipartContentFactory*, uint>)(lpVtbl[1]))((IHttpMultipartContentFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpMultipartContentFactory*, uint>)(lpVtbl[2]))((IHttpMultipartContentFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpMultipartContentFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IHttpMultipartContentFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpMultipartContentFactory*, HSTRING*, int>)(lpVtbl[4]))((IHttpMultipartContentFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpMultipartContentFactory*, TrustLevel*, int>)(lpVtbl[5]))((IHttpMultipartContentFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHttpMultipartContentFactory.xml' path='doc/member[@name="IHttpMultipartContentFactory.CreateWithSubtype"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateWithSubtype(HSTRING subtype, [NativeTypeName("ABI::Windows::Web::Http::IHttpContent **")] IHttpContent** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpMultipartContentFactory*, HSTRING, IHttpContent**, int>)(lpVtbl[6]))((IHttpMultipartContentFactory*)Unsafe.AsPointer(ref this), subtype, value);
    }

    /// <include file='IHttpMultipartContentFactory.xml' path='doc/member[@name="IHttpMultipartContentFactory.CreateWithSubtypeAndBoundary"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateWithSubtypeAndBoundary(HSTRING subtype, HSTRING boundary, [NativeTypeName("ABI::Windows::Web::Http::IHttpContent **")] IHttpContent** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpMultipartContentFactory*, HSTRING, HSTRING, IHttpContent**, int>)(lpVtbl[7]))((IHttpMultipartContentFactory*)Unsafe.AsPointer(ref this), subtype, boundary, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateWithSubtype(HSTRING subtype, [NativeTypeName("ABI::Windows::Web::Http::IHttpContent **")] IHttpContent** value);

        [VtblIndex(7)]
        HRESULT CreateWithSubtypeAndBoundary(HSTRING subtype, HSTRING boundary, [NativeTypeName("ABI::Windows::Web::Http::IHttpContent **")] IHttpContent** value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IHttpContent**, int> CreateWithSubtype;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Web::Http::IHttpContent **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IHttpContent**, int> CreateWithSubtypeAndBoundary;
    }
}
