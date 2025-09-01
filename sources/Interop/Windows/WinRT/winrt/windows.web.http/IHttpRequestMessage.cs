// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.web.http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHttpRequestMessage.xml' path='doc/member[@name="IHttpRequestMessage"]/*' />
[Guid("F5762B3C-74D4-4811-B5DC-9F8B4E2F9ABF")]
[NativeTypeName("struct IHttpRequestMessage : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpRequestMessage : IHttpRequestMessage.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IHttpRequestMessage);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestMessage*, Guid*, void**, int>)(lpVtbl[0]))((IHttpRequestMessage*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestMessage*, uint>)(lpVtbl[1]))((IHttpRequestMessage*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestMessage*, uint>)(lpVtbl[2]))((IHttpRequestMessage*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestMessage*, uint*, Guid**, int>)(lpVtbl[3]))((IHttpRequestMessage*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestMessage*, HSTRING*, int>)(lpVtbl[4]))((IHttpRequestMessage*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestMessage*, TrustLevel*, int>)(lpVtbl[5]))((IHttpRequestMessage*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHttpRequestMessage.xml' path='doc/member[@name="IHttpRequestMessage.get_Content"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Content([NativeTypeName("ABI::Windows::Web::Http::IHttpContent **")] IHttpContent** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestMessage*, IHttpContent**, int>)(lpVtbl[6]))((IHttpRequestMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpRequestMessage.xml' path='doc/member[@name="IHttpRequestMessage.put_Content"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Content([NativeTypeName("ABI::Windows::Web::Http::IHttpContent *")] IHttpContent* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestMessage*, IHttpContent*, int>)(lpVtbl[7]))((IHttpRequestMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpRequestMessage.xml' path='doc/member[@name="IHttpRequestMessage.get_Headers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Headers([NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpRequestHeaderCollection **")] IHttpRequestHeaderCollection** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestMessage*, IHttpRequestHeaderCollection**, int>)(lpVtbl[8]))((IHttpRequestMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpRequestMessage.xml' path='doc/member[@name="IHttpRequestMessage.get_Method"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Method([NativeTypeName("ABI::Windows::Web::Http::IHttpMethod **")] IHttpMethod** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestMessage*, IHttpMethod**, int>)(lpVtbl[9]))((IHttpRequestMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpRequestMessage.xml' path='doc/member[@name="IHttpRequestMessage.put_Method"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_Method([NativeTypeName("ABI::Windows::Web::Http::IHttpMethod *")] IHttpMethod* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestMessage*, IHttpMethod*, int>)(lpVtbl[10]))((IHttpRequestMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpRequestMessage.xml' path='doc/member[@name="IHttpRequestMessage.get_Properties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Properties([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_IInspectable_t **")] IMap<HSTRING, Pointer<IInspectable>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestMessage*, IMap<HSTRING, Pointer<IInspectable>>**, int>)(lpVtbl[11]))((IHttpRequestMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpRequestMessage.xml' path='doc/member[@name="IHttpRequestMessage.get_RequestUri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_RequestUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestMessage*, IUriRuntimeClass**, int>)(lpVtbl[12]))((IHttpRequestMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpRequestMessage.xml' path='doc/member[@name="IHttpRequestMessage.put_RequestUri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_RequestUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestMessage*, IUriRuntimeClass*, int>)(lpVtbl[13]))((IHttpRequestMessage*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpRequestMessage.xml' path='doc/member[@name="IHttpRequestMessage.get_TransportInformation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_TransportInformation([NativeTypeName("ABI::Windows::Web::Http::IHttpTransportInformation **")] IHttpTransportInformation** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestMessage*, IHttpTransportInformation**, int>)(lpVtbl[14]))((IHttpRequestMessage*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Content([NativeTypeName("ABI::Windows::Web::Http::IHttpContent **")] IHttpContent** value);

        [VtblIndex(7)]
        HRESULT put_Content([NativeTypeName("ABI::Windows::Web::Http::IHttpContent *")] IHttpContent* value);

        [VtblIndex(8)]
        HRESULT get_Headers([NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpRequestHeaderCollection **")] IHttpRequestHeaderCollection** value);

        [VtblIndex(9)]
        HRESULT get_Method([NativeTypeName("ABI::Windows::Web::Http::IHttpMethod **")] IHttpMethod** value);

        [VtblIndex(10)]
        HRESULT put_Method([NativeTypeName("ABI::Windows::Web::Http::IHttpMethod *")] IHttpMethod* value);

        [VtblIndex(11)]
        HRESULT get_Properties([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_IInspectable_t **")] IMap<HSTRING, Pointer<IInspectable>>** value);

        [VtblIndex(12)]
        HRESULT get_RequestUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value);

        [VtblIndex(13)]
        HRESULT put_RequestUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* value);

        [VtblIndex(14)]
        HRESULT get_TransportInformation([NativeTypeName("ABI::Windows::Web::Http::IHttpTransportInformation **")] IHttpTransportInformation** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::Headers::IHttpRequestHeaderCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpRequestHeaderCollection**, int> get_Headers;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::IHttpMethod **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpMethod**, int> get_Method;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::IHttpMethod *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpMethod*, int> put_Method;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_IInspectable_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMap<HSTRING, Pointer<IInspectable>>**, int> get_Properties;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass**, int> get_RequestUri;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, int> put_RequestUri;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::IHttpTransportInformation **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpTransportInformation**, int> get_TransportInformation;
    }
}
