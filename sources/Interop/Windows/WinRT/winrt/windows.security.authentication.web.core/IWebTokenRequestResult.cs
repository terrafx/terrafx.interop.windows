// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.authentication.web.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IWebTokenRequestResult.xml' path='doc/member[@name="IWebTokenRequestResult"]/*' />
[Guid("C12A8305-D1F8-4483-8D54-38FE292784FF")]
[NativeTypeName("struct IWebTokenRequestResult : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWebTokenRequestResult : IWebTokenRequestResult.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWebTokenRequestResult));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebTokenRequestResult*, Guid*, void**, int>)(lpVtbl[0]))((IWebTokenRequestResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebTokenRequestResult*, uint>)(lpVtbl[1]))((IWebTokenRequestResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWebTokenRequestResult*, uint>)(lpVtbl[2]))((IWebTokenRequestResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebTokenRequestResult*, uint*, Guid**, int>)(lpVtbl[3]))((IWebTokenRequestResult*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebTokenRequestResult*, HSTRING*, int>)(lpVtbl[4]))((IWebTokenRequestResult*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebTokenRequestResult*, TrustLevel*, int>)(lpVtbl[5]))((IWebTokenRequestResult*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IWebTokenRequestResult.xml' path='doc/member[@name="IWebTokenRequestResult.get_ResponseData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ResponseData([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSecurity__CAuthentication__CWeb__CCore__CWebTokenResponse_t **")] IVectorView<Pointer<IWebTokenResponse>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebTokenRequestResult*, IVectorView<Pointer<IWebTokenResponse>>**, int>)(lpVtbl[6]))((IWebTokenRequestResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWebTokenRequestResult.xml' path='doc/member[@name="IWebTokenRequestResult.get_ResponseStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ResponseStatus([NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::WebTokenRequestStatus *")] WebTokenRequestStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebTokenRequestResult*, WebTokenRequestStatus*, int>)(lpVtbl[7]))((IWebTokenRequestResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWebTokenRequestResult.xml' path='doc/member[@name="IWebTokenRequestResult.get_ResponseError"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ResponseError([NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::IWebProviderError **")] IWebProviderError** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebTokenRequestResult*, IWebProviderError**, int>)(lpVtbl[8]))((IWebTokenRequestResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWebTokenRequestResult.xml' path='doc/member[@name="IWebTokenRequestResult.InvalidateCacheAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT InvalidateCacheAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IWebTokenRequestResult*, IAsyncAction**, int>)(lpVtbl[9]))((IWebTokenRequestResult*)Unsafe.AsPointer(ref this), asyncInfo);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ResponseData([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSecurity__CAuthentication__CWeb__CCore__CWebTokenResponse_t **")] IVectorView<Pointer<IWebTokenResponse>>** value);

        [VtblIndex(7)]
        HRESULT get_ResponseStatus([NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::WebTokenRequestStatus *")] WebTokenRequestStatus* value);

        [VtblIndex(8)]
        HRESULT get_ResponseError([NativeTypeName("ABI::Windows::Security::Authentication::Web::Core::IWebProviderError **")] IWebProviderError** value);

        [VtblIndex(9)]
        HRESULT InvalidateCacheAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSecurity__CAuthentication__CWeb__CCore__CWebTokenResponse_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IWebTokenResponse>>**, int> get_ResponseData;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Authentication::Web::Core::WebTokenRequestStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WebTokenRequestStatus*, int> get_ResponseStatus;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Authentication::Web::Core::IWebProviderError **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWebProviderError**, int> get_ResponseError;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction**, int> InvalidateCacheAsync;
    }
}
