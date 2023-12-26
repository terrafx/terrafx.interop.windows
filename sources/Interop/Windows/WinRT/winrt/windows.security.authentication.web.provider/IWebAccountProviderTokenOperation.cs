// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.authentication.web.provider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IWebAccountProviderTokenOperation.xml' path='doc/member[@name="IWebAccountProviderTokenOperation"]/*' />
[Guid("95C613BE-2034-4C38-9434-D26C14B2B4B2")]
[NativeTypeName("struct IWebAccountProviderTokenOperation : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWebAccountProviderTokenOperation : IWebAccountProviderTokenOperation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWebAccountProviderTokenOperation));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountProviderTokenOperation*, Guid*, void**, int>)(lpVtbl[0]))((IWebAccountProviderTokenOperation*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountProviderTokenOperation*, uint>)(lpVtbl[1]))((IWebAccountProviderTokenOperation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountProviderTokenOperation*, uint>)(lpVtbl[2]))((IWebAccountProviderTokenOperation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountProviderTokenOperation*, uint*, Guid**, int>)(lpVtbl[3]))((IWebAccountProviderTokenOperation*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountProviderTokenOperation*, HSTRING*, int>)(lpVtbl[4]))((IWebAccountProviderTokenOperation*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountProviderTokenOperation*, TrustLevel*, int>)(lpVtbl[5]))((IWebAccountProviderTokenOperation*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IWebAccountProviderTokenOperation.xml' path='doc/member[@name="IWebAccountProviderTokenOperation.get_ProviderRequest"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ProviderRequest([NativeTypeName("ABI::Windows::Security::Authentication::Web::Provider::IWebProviderTokenRequest **")] IWebProviderTokenRequest** webTokenRequest)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountProviderTokenOperation*, IWebProviderTokenRequest**, int>)(lpVtbl[6]))((IWebAccountProviderTokenOperation*)Unsafe.AsPointer(ref this), webTokenRequest);
    }

    /// <include file='IWebAccountProviderTokenOperation.xml' path='doc/member[@name="IWebAccountProviderTokenOperation.get_ProviderResponses"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ProviderResponses([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CSecurity__CAuthentication__CWeb__CProvider__CWebProviderTokenResponse_t **")] IVector<IntPtr>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountProviderTokenOperation*, IVector<IntPtr>**, int>)(lpVtbl[7]))((IWebAccountProviderTokenOperation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWebAccountProviderTokenOperation.xml' path='doc/member[@name="IWebAccountProviderTokenOperation.put_CacheExpirationTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_CacheExpirationTime([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountProviderTokenOperation*, WinRTDateTime, int>)(lpVtbl[8]))((IWebAccountProviderTokenOperation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWebAccountProviderTokenOperation.xml' path='doc/member[@name="IWebAccountProviderTokenOperation.get_CacheExpirationTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_CacheExpirationTime([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebAccountProviderTokenOperation*, WinRTDateTime*, int>)(lpVtbl[9]))((IWebAccountProviderTokenOperation*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ProviderRequest([NativeTypeName("ABI::Windows::Security::Authentication::Web::Provider::IWebProviderTokenRequest **")] IWebProviderTokenRequest** webTokenRequest);

        [VtblIndex(7)]
        HRESULT get_ProviderResponses([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CSecurity__CAuthentication__CWeb__CProvider__CWebProviderTokenResponse_t **")] IVector<IntPtr>** value);

        [VtblIndex(8)]
        HRESULT put_CacheExpirationTime([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime value);

        [VtblIndex(9)]
        HRESULT get_CacheExpirationTime([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Security::Authentication::Web::Provider::IWebProviderTokenRequest **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWebProviderTokenRequest**, int> get_ProviderRequest;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CSecurity__CAuthentication__CWeb__CProvider__CWebProviderTokenResponse_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<IntPtr>**, int> get_ProviderResponses;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime, int> put_CacheExpirationTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime*, int> get_CacheExpirationTime;
    }
}
