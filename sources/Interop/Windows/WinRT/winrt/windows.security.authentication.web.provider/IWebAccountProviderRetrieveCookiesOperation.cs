// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.authentication.web.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IWebAccountProviderRetrieveCookiesOperation.xml' path='doc/member[@name="IWebAccountProviderRetrieveCookiesOperation"]/*' />
[Guid("5A040441-0FA3-4AB1-A01C-20B110358594")]
[NativeTypeName("struct IWebAccountProviderRetrieveCookiesOperation : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWebAccountProviderRetrieveCookiesOperation : IWebAccountProviderRetrieveCookiesOperation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IWebAccountProviderRetrieveCookiesOperation);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountProviderRetrieveCookiesOperation*, Guid*, void**, int>)(lpVtbl[0]))((IWebAccountProviderRetrieveCookiesOperation*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountProviderRetrieveCookiesOperation*, uint>)(lpVtbl[1]))((IWebAccountProviderRetrieveCookiesOperation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountProviderRetrieveCookiesOperation*, uint>)(lpVtbl[2]))((IWebAccountProviderRetrieveCookiesOperation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountProviderRetrieveCookiesOperation*, uint*, Guid**, int>)(lpVtbl[3]))((IWebAccountProviderRetrieveCookiesOperation*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountProviderRetrieveCookiesOperation*, HSTRING*, int>)(lpVtbl[4]))((IWebAccountProviderRetrieveCookiesOperation*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountProviderRetrieveCookiesOperation*, TrustLevel*, int>)(lpVtbl[5]))((IWebAccountProviderRetrieveCookiesOperation*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IWebAccountProviderRetrieveCookiesOperation.xml' path='doc/member[@name="IWebAccountProviderRetrieveCookiesOperation.get_Context"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Context([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** webCookieRequestContext)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountProviderRetrieveCookiesOperation*, IUriRuntimeClass**, int>)(lpVtbl[6]))((IWebAccountProviderRetrieveCookiesOperation*)Unsafe.AsPointer(ref this), webCookieRequestContext);
    }

    /// <include file='IWebAccountProviderRetrieveCookiesOperation.xml' path='doc/member[@name="IWebAccountProviderRetrieveCookiesOperation.get_Cookies"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Cookies([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CWeb__CHttp__CHttpCookie_t **")] IVector<Pointer<IHttpCookie>>** cookies)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountProviderRetrieveCookiesOperation*, IVector<Pointer<IHttpCookie>>**, int>)(lpVtbl[7]))((IWebAccountProviderRetrieveCookiesOperation*)Unsafe.AsPointer(ref this), cookies);
    }

    /// <include file='IWebAccountProviderRetrieveCookiesOperation.xml' path='doc/member[@name="IWebAccountProviderRetrieveCookiesOperation.put_Uri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_Uri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountProviderRetrieveCookiesOperation*, IUriRuntimeClass*, int>)(lpVtbl[8]))((IWebAccountProviderRetrieveCookiesOperation*)Unsafe.AsPointer(ref this), uri);
    }

    /// <include file='IWebAccountProviderRetrieveCookiesOperation.xml' path='doc/member[@name="IWebAccountProviderRetrieveCookiesOperation.get_Uri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Uri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** uri)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountProviderRetrieveCookiesOperation*, IUriRuntimeClass**, int>)(lpVtbl[9]))((IWebAccountProviderRetrieveCookiesOperation*)Unsafe.AsPointer(ref this), uri);
    }

    /// <include file='IWebAccountProviderRetrieveCookiesOperation.xml' path='doc/member[@name="IWebAccountProviderRetrieveCookiesOperation.get_ApplicationCallbackUri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ApplicationCallbackUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountProviderRetrieveCookiesOperation*, IUriRuntimeClass**, int>)(lpVtbl[10]))((IWebAccountProviderRetrieveCookiesOperation*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Context([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** webCookieRequestContext);

        [VtblIndex(7)]
        HRESULT get_Cookies([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CWeb__CHttp__CHttpCookie_t **")] IVector<Pointer<IHttpCookie>>** cookies);

        [VtblIndex(8)]
        HRESULT put_Uri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri);

        [VtblIndex(9)]
        HRESULT get_Uri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** uri);

        [VtblIndex(10)]
        HRESULT get_ApplicationCallbackUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass**, int> get_Context;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CWeb__CHttp__CHttpCookie_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<Pointer<IHttpCookie>>**, int> get_Cookies;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, int> put_Uri;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass**, int> get_Uri;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass**, int> get_ApplicationCallbackUri;
    }
}
