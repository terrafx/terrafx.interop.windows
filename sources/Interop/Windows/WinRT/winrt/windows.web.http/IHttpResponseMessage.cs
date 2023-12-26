// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.web.http.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHttpResponseMessage.xml' path='doc/member[@name="IHttpResponseMessage"]/*' />
[Guid("FEE200FB-8664-44E0-95D9-42696199BFFC")]
[NativeTypeName("struct IHttpResponseMessage : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpResponseMessage : IHttpResponseMessage.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpResponseMessage));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpResponseMessage*, Guid*, void**, int>)(lpVtbl[0]))((IHttpResponseMessage*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpResponseMessage*, uint>)(lpVtbl[1]))((IHttpResponseMessage*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpResponseMessage*, uint>)(lpVtbl[2]))((IHttpResponseMessage*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpResponseMessage*, uint*, Guid**, int>)(lpVtbl[3]))((IHttpResponseMessage*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpResponseMessage*, HSTRING*, int>)(lpVtbl[4]))((IHttpResponseMessage*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpResponseMessage*, TrustLevel*, int>)(lpVtbl[5]))((IHttpResponseMessage*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHttpResponseMessage.xml' path='doc/member[@name="IHttpResponseMessage.get_Content"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Content([NativeTypeName("ABI::Windows::Web::Http::IHttpContent **")] IHttpContent** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpResponseMessage*, IHttpContent**, int>)(lpVtbl[6]))((IHttpResponseMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpResponseMessage.xml' path='doc/member[@name="IHttpResponseMessage.put_Content"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Content([NativeTypeName("ABI::Windows::Web::Http::IHttpContent *")] IHttpContent* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpResponseMessage*, IHttpContent*, int>)(lpVtbl[7]))((IHttpResponseMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpResponseMessage.xml' path='doc/member[@name="IHttpResponseMessage.get_Headers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Headers([NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpResponseHeaderCollection **")] IHttpResponseHeaderCollection** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpResponseMessage*, IHttpResponseHeaderCollection**, int>)(lpVtbl[8]))((IHttpResponseMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpResponseMessage.xml' path='doc/member[@name="IHttpResponseMessage.get_IsSuccessStatusCode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_IsSuccessStatusCode([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpResponseMessage*, byte*, int>)(lpVtbl[9]))((IHttpResponseMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpResponseMessage.xml' path='doc/member[@name="IHttpResponseMessage.get_ReasonPhrase"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ReasonPhrase(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpResponseMessage*, HSTRING*, int>)(lpVtbl[10]))((IHttpResponseMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpResponseMessage.xml' path='doc/member[@name="IHttpResponseMessage.put_ReasonPhrase"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_ReasonPhrase(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpResponseMessage*, HSTRING, int>)(lpVtbl[11]))((IHttpResponseMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpResponseMessage.xml' path='doc/member[@name="IHttpResponseMessage.get_RequestMessage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_RequestMessage([NativeTypeName("ABI::Windows::Web::Http::IHttpRequestMessage **")] IHttpRequestMessage** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpResponseMessage*, IHttpRequestMessage**, int>)(lpVtbl[12]))((IHttpResponseMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpResponseMessage.xml' path='doc/member[@name="IHttpResponseMessage.put_RequestMessage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_RequestMessage([NativeTypeName("ABI::Windows::Web::Http::IHttpRequestMessage *")] IHttpRequestMessage* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpResponseMessage*, IHttpRequestMessage*, int>)(lpVtbl[13]))((IHttpResponseMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpResponseMessage.xml' path='doc/member[@name="IHttpResponseMessage.get_Source"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Source([NativeTypeName("ABI::Windows::Web::Http::HttpResponseMessageSource *")] HttpResponseMessageSource* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpResponseMessage*, HttpResponseMessageSource*, int>)(lpVtbl[14]))((IHttpResponseMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpResponseMessage.xml' path='doc/member[@name="IHttpResponseMessage.put_Source"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_Source([NativeTypeName("ABI::Windows::Web::Http::HttpResponseMessageSource")] HttpResponseMessageSource value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpResponseMessage*, HttpResponseMessageSource, int>)(lpVtbl[15]))((IHttpResponseMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpResponseMessage.xml' path='doc/member[@name="IHttpResponseMessage.get_StatusCode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_StatusCode([NativeTypeName("ABI::Windows::Web::Http::HttpStatusCode *")] HttpStatusCode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpResponseMessage*, HttpStatusCode*, int>)(lpVtbl[16]))((IHttpResponseMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpResponseMessage.xml' path='doc/member[@name="IHttpResponseMessage.put_StatusCode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_StatusCode([NativeTypeName("ABI::Windows::Web::Http::HttpStatusCode")] HttpStatusCode value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpResponseMessage*, HttpStatusCode, int>)(lpVtbl[17]))((IHttpResponseMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpResponseMessage.xml' path='doc/member[@name="IHttpResponseMessage.get_Version"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_Version([NativeTypeName("ABI::Windows::Web::Http::HttpVersion *")] HttpVersion* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpResponseMessage*, HttpVersion*, int>)(lpVtbl[18]))((IHttpResponseMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpResponseMessage.xml' path='doc/member[@name="IHttpResponseMessage.put_Version"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_Version([NativeTypeName("ABI::Windows::Web::Http::HttpVersion")] HttpVersion value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpResponseMessage*, HttpVersion, int>)(lpVtbl[19]))((IHttpResponseMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpResponseMessage.xml' path='doc/member[@name="IHttpResponseMessage.EnsureSuccessStatusCode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT EnsureSuccessStatusCode([NativeTypeName("ABI::Windows::Web::Http::IHttpResponseMessage **")] IHttpResponseMessage** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpResponseMessage*, IHttpResponseMessage**, int>)(lpVtbl[20]))((IHttpResponseMessage*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Content([NativeTypeName("ABI::Windows::Web::Http::IHttpContent **")] IHttpContent** value);

        [VtblIndex(7)]
        HRESULT put_Content([NativeTypeName("ABI::Windows::Web::Http::IHttpContent *")] IHttpContent* value);

        [VtblIndex(8)]
        HRESULT get_Headers([NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpResponseHeaderCollection **")] IHttpResponseHeaderCollection** value);

        [VtblIndex(9)]
        HRESULT get_IsSuccessStatusCode([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        HRESULT get_ReasonPhrase(HSTRING* value);

        [VtblIndex(11)]
        HRESULT put_ReasonPhrase(HSTRING value);

        [VtblIndex(12)]
        HRESULT get_RequestMessage([NativeTypeName("ABI::Windows::Web::Http::IHttpRequestMessage **")] IHttpRequestMessage** value);

        [VtblIndex(13)]
        HRESULT put_RequestMessage([NativeTypeName("ABI::Windows::Web::Http::IHttpRequestMessage *")] IHttpRequestMessage* value);

        [VtblIndex(14)]
        HRESULT get_Source([NativeTypeName("ABI::Windows::Web::Http::HttpResponseMessageSource *")] HttpResponseMessageSource* value);

        [VtblIndex(15)]
        HRESULT put_Source([NativeTypeName("ABI::Windows::Web::Http::HttpResponseMessageSource")] HttpResponseMessageSource value);

        [VtblIndex(16)]
        HRESULT get_StatusCode([NativeTypeName("ABI::Windows::Web::Http::HttpStatusCode *")] HttpStatusCode* value);

        [VtblIndex(17)]
        HRESULT put_StatusCode([NativeTypeName("ABI::Windows::Web::Http::HttpStatusCode")] HttpStatusCode value);

        [VtblIndex(18)]
        HRESULT get_Version([NativeTypeName("ABI::Windows::Web::Http::HttpVersion *")] HttpVersion* value);

        [VtblIndex(19)]
        HRESULT put_Version([NativeTypeName("ABI::Windows::Web::Http::HttpVersion")] HttpVersion value);

        [VtblIndex(20)]
        HRESULT EnsureSuccessStatusCode([NativeTypeName("ABI::Windows::Web::Http::IHttpResponseMessage **")] IHttpResponseMessage** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::IHttpContent **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpContent**, int> get_Content;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::IHttpContent *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpContent*, int> put_Content;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::Headers::IHttpResponseHeaderCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpResponseHeaderCollection**, int> get_Headers;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsSuccessStatusCode;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ReasonPhrase;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_ReasonPhrase;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::IHttpRequestMessage **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpRequestMessage**, int> get_RequestMessage;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::IHttpRequestMessage *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpRequestMessage*, int> put_RequestMessage;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::HttpResponseMessageSource *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HttpResponseMessageSource*, int> get_Source;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::HttpResponseMessageSource) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HttpResponseMessageSource, int> put_Source;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::HttpStatusCode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HttpStatusCode*, int> get_StatusCode;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::HttpStatusCode) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HttpStatusCode, int> put_StatusCode;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::HttpVersion *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HttpVersion*, int> get_Version;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::HttpVersion) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HttpVersion, int> put_Version;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::IHttpResponseMessage **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpResponseMessage**, int> EnsureSuccessStatusCode;
    }
}
