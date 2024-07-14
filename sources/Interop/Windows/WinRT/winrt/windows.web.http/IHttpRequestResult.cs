// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.web.http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHttpRequestResult.xml' path='doc/member[@name="IHttpRequestResult"]/*' />
[Guid("6ACF4DA8-B5EB-4A35-A902-4217FBE820C5")]
[NativeTypeName("struct IHttpRequestResult : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpRequestResult : IHttpRequestResult.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpRequestResult));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestResult*, Guid*, void**, int>)(lpVtbl[0]))((IHttpRequestResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestResult*, uint>)(lpVtbl[1]))((IHttpRequestResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestResult*, uint>)(lpVtbl[2]))((IHttpRequestResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestResult*, uint*, Guid**, int>)(lpVtbl[3]))((IHttpRequestResult*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestResult*, HSTRING*, int>)(lpVtbl[4]))((IHttpRequestResult*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestResult*, TrustLevel*, int>)(lpVtbl[5]))((IHttpRequestResult*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHttpRequestResult.xml' path='doc/member[@name="IHttpRequestResult.get_ExtendedError"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ExtendedError(HRESULT* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestResult*, HRESULT*, int>)(lpVtbl[6]))((IHttpRequestResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpRequestResult.xml' path='doc/member[@name="IHttpRequestResult.get_RequestMessage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_RequestMessage([NativeTypeName("ABI::Windows::Web::Http::IHttpRequestMessage **")] IHttpRequestMessage** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestResult*, IHttpRequestMessage**, int>)(lpVtbl[7]))((IHttpRequestResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpRequestResult.xml' path='doc/member[@name="IHttpRequestResult.get_ResponseMessage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ResponseMessage([NativeTypeName("ABI::Windows::Web::Http::IHttpResponseMessage **")] IHttpResponseMessage** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestResult*, IHttpResponseMessage**, int>)(lpVtbl[8]))((IHttpRequestResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpRequestResult.xml' path='doc/member[@name="IHttpRequestResult.get_Succeeded"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Succeeded([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpRequestResult*, byte*, int>)(lpVtbl[9]))((IHttpRequestResult*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ExtendedError(HRESULT* value);

        [VtblIndex(7)]
        HRESULT get_RequestMessage([NativeTypeName("ABI::Windows::Web::Http::IHttpRequestMessage **")] IHttpRequestMessage** value);

        [VtblIndex(8)]
        HRESULT get_ResponseMessage([NativeTypeName("ABI::Windows::Web::Http::IHttpResponseMessage **")] IHttpResponseMessage** value);

        [VtblIndex(9)]
        HRESULT get_Succeeded([NativeTypeName("boolean *")] byte* value);
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

        [NativeTypeName("HRESULT (HRESULT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HRESULT*, int> get_ExtendedError;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::IHttpRequestMessage **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpRequestMessage**, int> get_RequestMessage;

        [NativeTypeName("HRESULT (ABI::Windows::Web::Http::IHttpResponseMessage **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpResponseMessage**, int> get_ResponseMessage;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_Succeeded;
    }
}
