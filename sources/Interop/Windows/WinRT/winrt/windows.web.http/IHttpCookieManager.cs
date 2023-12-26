// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.web.http.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHttpCookieManager.xml' path='doc/member[@name="IHttpCookieManager"]/*' />
[Guid("7A431780-CD4F-4E57-A84A-5B0A53D6BB96")]
[NativeTypeName("struct IHttpCookieManager : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpCookieManager : IHttpCookieManager.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpCookieManager));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCookieManager*, Guid*, void**, int>)(lpVtbl[0]))((IHttpCookieManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCookieManager*, uint>)(lpVtbl[1]))((IHttpCookieManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCookieManager*, uint>)(lpVtbl[2]))((IHttpCookieManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCookieManager*, uint*, Guid**, int>)(lpVtbl[3]))((IHttpCookieManager*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCookieManager*, HSTRING*, int>)(lpVtbl[4]))((IHttpCookieManager*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCookieManager*, TrustLevel*, int>)(lpVtbl[5]))((IHttpCookieManager*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHttpCookieManager.xml' path='doc/member[@name="IHttpCookieManager.SetCookie"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetCookie([NativeTypeName("ABI::Windows::Web::Http::IHttpCookie *")] IHttpCookie* cookie, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCookieManager*, IHttpCookie*, byte*, int>)(lpVtbl[6]))((IHttpCookieManager*)Unsafe.AsPointer(ref this), cookie, result);
    }

    /// <include file='IHttpCookieManager.xml' path='doc/member[@name="IHttpCookieManager.SetCookieWithThirdParty"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetCookieWithThirdParty([NativeTypeName("ABI::Windows::Web::Http::IHttpCookie *")] IHttpCookie* cookie, [NativeTypeName("boolean")] byte thirdParty, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCookieManager*, IHttpCookie*, byte, byte*, int>)(lpVtbl[7]))((IHttpCookieManager*)Unsafe.AsPointer(ref this), cookie, thirdParty, result);
    }

    /// <include file='IHttpCookieManager.xml' path='doc/member[@name="IHttpCookieManager.DeleteCookie"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT DeleteCookie([NativeTypeName("ABI::Windows::Web::Http::IHttpCookie *")] IHttpCookie* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCookieManager*, IHttpCookie*, int>)(lpVtbl[8]))((IHttpCookieManager*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='IHttpCookieManager.xml' path='doc/member[@name="IHttpCookieManager.GetCookies"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetCookies([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CWeb__CHttp__CHttpCookie_t **")] IVectorView<IntPtr>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpCookieManager*, IUriRuntimeClass*, IVectorView<IntPtr>**, int>)(lpVtbl[9]))((IHttpCookieManager*)Unsafe.AsPointer(ref this), uri, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT SetCookie([NativeTypeName("ABI::Windows::Web::Http::IHttpCookie *")] IHttpCookie* cookie, [NativeTypeName("boolean *")] byte* result);

        [VtblIndex(7)]
        HRESULT SetCookieWithThirdParty([NativeTypeName("ABI::Windows::Web::Http::IHttpCookie *")] IHttpCookie* cookie, [NativeTypeName("boolean")] byte thirdParty, [NativeTypeName("boolean *")] byte* result);

        [VtblIndex(8)]
        HRESULT DeleteCookie([NativeTypeName("ABI::Windows::Web::Http::IHttpCookie *")] IHttpCookie* cookie);

        [VtblIndex(9)]
        HRESULT GetCookies([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CWeb__CHttp__CHttpCookie_t **")] IVectorView<IntPtr>** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::IHttpCookie *, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpCookie*, byte*, int> SetCookie;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::IHttpCookie *, boolean, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpCookie*, byte, byte*, int> SetCookieWithThirdParty;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::IHttpCookie *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpCookie*, int> DeleteCookie;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CWeb__CHttp__CHttpCookie_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, IVectorView<IntPtr>**, int> GetCookies;
    }
}
