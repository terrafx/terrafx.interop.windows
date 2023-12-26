// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.web.http.headers.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHttpProductInfoHeaderValueFactory.xml' path='doc/member[@name="IHttpProductInfoHeaderValueFactory"]/*' />
[Guid("24220FBE-EABE-4464-B460-EC010B7C41E2")]
[NativeTypeName("struct IHttpProductInfoHeaderValueFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpProductInfoHeaderValueFactory : IHttpProductInfoHeaderValueFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpProductInfoHeaderValueFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpProductInfoHeaderValueFactory*, Guid*, void**, int>)(lpVtbl[0]))((IHttpProductInfoHeaderValueFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpProductInfoHeaderValueFactory*, uint>)(lpVtbl[1]))((IHttpProductInfoHeaderValueFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpProductInfoHeaderValueFactory*, uint>)(lpVtbl[2]))((IHttpProductInfoHeaderValueFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpProductInfoHeaderValueFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IHttpProductInfoHeaderValueFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpProductInfoHeaderValueFactory*, HSTRING*, int>)(lpVtbl[4]))((IHttpProductInfoHeaderValueFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpProductInfoHeaderValueFactory*, TrustLevel*, int>)(lpVtbl[5]))((IHttpProductInfoHeaderValueFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHttpProductInfoHeaderValueFactory.xml' path='doc/member[@name="IHttpProductInfoHeaderValueFactory.CreateFromComment"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFromComment(HSTRING productComment, [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpProductInfoHeaderValue **")] IHttpProductInfoHeaderValue** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpProductInfoHeaderValueFactory*, HSTRING, IHttpProductInfoHeaderValue**, int>)(lpVtbl[6]))((IHttpProductInfoHeaderValueFactory*)Unsafe.AsPointer(ref this), productComment, value);
    }

    /// <include file='IHttpProductInfoHeaderValueFactory.xml' path='doc/member[@name="IHttpProductInfoHeaderValueFactory.CreateFromNameWithVersion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFromNameWithVersion(HSTRING productName, HSTRING productVersion, [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpProductInfoHeaderValue **")] IHttpProductInfoHeaderValue** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpProductInfoHeaderValueFactory*, HSTRING, HSTRING, IHttpProductInfoHeaderValue**, int>)(lpVtbl[7]))((IHttpProductInfoHeaderValueFactory*)Unsafe.AsPointer(ref this), productName, productVersion, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFromComment(HSTRING productComment, [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpProductInfoHeaderValue **")] IHttpProductInfoHeaderValue** value);

        [VtblIndex(7)]
        HRESULT CreateFromNameWithVersion(HSTRING productName, HSTRING productVersion, [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpProductInfoHeaderValue **")] IHttpProductInfoHeaderValue** value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IHttpProductInfoHeaderValue**, int> CreateFromComment;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Web::Http::Headers::IHttpProductInfoHeaderValue **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IHttpProductInfoHeaderValue**, int> CreateFromNameWithVersion;
    }
}
