// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.web.http.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHttpMultipartFormDataContent.xml' path='doc/member[@name="IHttpMultipartFormDataContent"]/*' />
[Guid("64D337E2-E967-4624-B6D1-CF74604A4A42")]
[NativeTypeName("struct IHttpMultipartFormDataContent : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpMultipartFormDataContent : IHttpMultipartFormDataContent.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpMultipartFormDataContent));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpMultipartFormDataContent*, Guid*, void**, int>)(lpVtbl[0]))((IHttpMultipartFormDataContent*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpMultipartFormDataContent*, uint>)(lpVtbl[1]))((IHttpMultipartFormDataContent*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpMultipartFormDataContent*, uint>)(lpVtbl[2]))((IHttpMultipartFormDataContent*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpMultipartFormDataContent*, uint*, Guid**, int>)(lpVtbl[3]))((IHttpMultipartFormDataContent*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpMultipartFormDataContent*, HSTRING*, int>)(lpVtbl[4]))((IHttpMultipartFormDataContent*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpMultipartFormDataContent*, TrustLevel*, int>)(lpVtbl[5]))((IHttpMultipartFormDataContent*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHttpMultipartFormDataContent.xml' path='doc/member[@name="IHttpMultipartFormDataContent.Add"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Add([NativeTypeName("ABI::Windows::Web::Http::IHttpContent *")] IHttpContent* content)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpMultipartFormDataContent*, IHttpContent*, int>)(lpVtbl[6]))((IHttpMultipartFormDataContent*)Unsafe.AsPointer(ref this), content);
    }

    /// <include file='IHttpMultipartFormDataContent.xml' path='doc/member[@name="IHttpMultipartFormDataContent.AddWithName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT AddWithName([NativeTypeName("ABI::Windows::Web::Http::IHttpContent *")] IHttpContent* content, HSTRING name)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpMultipartFormDataContent*, IHttpContent*, HSTRING, int>)(lpVtbl[7]))((IHttpMultipartFormDataContent*)Unsafe.AsPointer(ref this), content, name);
    }

    /// <include file='IHttpMultipartFormDataContent.xml' path='doc/member[@name="IHttpMultipartFormDataContent.AddWithNameAndFileName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT AddWithNameAndFileName([NativeTypeName("ABI::Windows::Web::Http::IHttpContent *")] IHttpContent* content, HSTRING name, HSTRING fileName)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpMultipartFormDataContent*, IHttpContent*, HSTRING, HSTRING, int>)(lpVtbl[8]))((IHttpMultipartFormDataContent*)Unsafe.AsPointer(ref this), content, name, fileName);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Add([NativeTypeName("ABI::Windows::Web::Http::IHttpContent *")] IHttpContent* content);

        [VtblIndex(7)]
        HRESULT AddWithName([NativeTypeName("ABI::Windows::Web::Http::IHttpContent *")] IHttpContent* content, HSTRING name);

        [VtblIndex(8)]
        HRESULT AddWithNameAndFileName([NativeTypeName("ABI::Windows::Web::Http::IHttpContent *")] IHttpContent* content, HSTRING name, HSTRING fileName);
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

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::IHttpContent *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpContent*, int> Add;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::IHttpContent *, HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpContent*, HSTRING, int> AddWithName;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::IHttpContent *, HSTRING, HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpContent*, HSTRING, HSTRING, int> AddWithNameAndFileName;
    }
}
