// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.web.http.filters.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHttpBaseProtocolFilter4.xml' path='doc/member[@name="IHttpBaseProtocolFilter4"]/*' />
[Guid("9FE36CCF-2983-4893-941F-EB518CA8CEF9")]
[NativeTypeName("struct IHttpBaseProtocolFilter4 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpBaseProtocolFilter4 : IHttpBaseProtocolFilter4.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpBaseProtocolFilter4));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpBaseProtocolFilter4*, Guid*, void**, int>)(lpVtbl[0]))((IHttpBaseProtocolFilter4*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpBaseProtocolFilter4*, uint>)(lpVtbl[1]))((IHttpBaseProtocolFilter4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpBaseProtocolFilter4*, uint>)(lpVtbl[2]))((IHttpBaseProtocolFilter4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpBaseProtocolFilter4*, uint*, Guid**, int>)(lpVtbl[3]))((IHttpBaseProtocolFilter4*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpBaseProtocolFilter4*, HSTRING*, int>)(lpVtbl[4]))((IHttpBaseProtocolFilter4*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpBaseProtocolFilter4*, TrustLevel*, int>)(lpVtbl[5]))((IHttpBaseProtocolFilter4*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHttpBaseProtocolFilter4.xml' path='doc/member[@name="IHttpBaseProtocolFilter4.add_ServerCustomValidationRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_ServerCustomValidationRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CWeb__CHttp__CFilters__CHttpBaseProtocolFilter_Windows__CWeb__CHttp__CFilters__CHttpServerCustomValidationRequestedEventArgs_t *")] ITypedEventHandler<Pointer<IHttpBaseProtocolFilter>, Pointer<IHttpServerCustomValidationRequestedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpBaseProtocolFilter4*, ITypedEventHandler<Pointer<IHttpBaseProtocolFilter>, Pointer<IHttpServerCustomValidationRequestedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IHttpBaseProtocolFilter4*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IHttpBaseProtocolFilter4.xml' path='doc/member[@name="IHttpBaseProtocolFilter4.remove_ServerCustomValidationRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_ServerCustomValidationRequested(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpBaseProtocolFilter4*, EventRegistrationToken, int>)(lpVtbl[7]))((IHttpBaseProtocolFilter4*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IHttpBaseProtocolFilter4.xml' path='doc/member[@name="IHttpBaseProtocolFilter4.ClearAuthenticationCache"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ClearAuthenticationCache()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpBaseProtocolFilter4*, int>)(lpVtbl[8]))((IHttpBaseProtocolFilter4*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_ServerCustomValidationRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CWeb__CHttp__CFilters__CHttpBaseProtocolFilter_Windows__CWeb__CHttp__CFilters__CHttpServerCustomValidationRequestedEventArgs_t *")] ITypedEventHandler<Pointer<IHttpBaseProtocolFilter>, Pointer<IHttpServerCustomValidationRequestedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_ServerCustomValidationRequested(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT ClearAuthenticationCache();
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CWeb__CHttp__CFilters__CHttpBaseProtocolFilter_Windows__CWeb__CHttp__CFilters__CHttpServerCustomValidationRequestedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IHttpBaseProtocolFilter>, Pointer<IHttpServerCustomValidationRequestedEventArgs>>*, EventRegistrationToken*, int> add_ServerCustomValidationRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ServerCustomValidationRequested;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> ClearAuthenticationCache;
    }
}
