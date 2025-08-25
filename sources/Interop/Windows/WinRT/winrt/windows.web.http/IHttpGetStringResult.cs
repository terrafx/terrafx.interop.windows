// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.web.http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHttpGetStringResult.xml' path='doc/member[@name="IHttpGetStringResult"]/*' />
[Guid("9BAC466D-8509-4775-B16D-8953F47A7F5F")]
[NativeTypeName("struct IHttpGetStringResult : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpGetStringResult : IHttpGetStringResult.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IHttpGetStringResult);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpGetStringResult*, Guid*, void**, int>)(lpVtbl[0]))((IHttpGetStringResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpGetStringResult*, uint>)(lpVtbl[1]))((IHttpGetStringResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpGetStringResult*, uint>)(lpVtbl[2]))((IHttpGetStringResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpGetStringResult*, uint*, Guid**, int>)(lpVtbl[3]))((IHttpGetStringResult*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpGetStringResult*, HSTRING*, int>)(lpVtbl[4]))((IHttpGetStringResult*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpGetStringResult*, TrustLevel*, int>)(lpVtbl[5]))((IHttpGetStringResult*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHttpGetStringResult.xml' path='doc/member[@name="IHttpGetStringResult.get_ExtendedError"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ExtendedError(HRESULT* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpGetStringResult*, HRESULT*, int>)(lpVtbl[6]))((IHttpGetStringResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpGetStringResult.xml' path='doc/member[@name="IHttpGetStringResult.get_RequestMessage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_RequestMessage([NativeTypeName("ABI::Windows::Web::Http::IHttpRequestMessage **")] IHttpRequestMessage** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpGetStringResult*, IHttpRequestMessage**, int>)(lpVtbl[7]))((IHttpGetStringResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpGetStringResult.xml' path='doc/member[@name="IHttpGetStringResult.get_ResponseMessage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ResponseMessage([NativeTypeName("ABI::Windows::Web::Http::IHttpResponseMessage **")] IHttpResponseMessage** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpGetStringResult*, IHttpResponseMessage**, int>)(lpVtbl[8]))((IHttpGetStringResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpGetStringResult.xml' path='doc/member[@name="IHttpGetStringResult.get_Succeeded"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Succeeded([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpGetStringResult*, byte*, int>)(lpVtbl[9]))((IHttpGetStringResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpGetStringResult.xml' path='doc/member[@name="IHttpGetStringResult.get_Value"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Value(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpGetStringResult*, HSTRING*, int>)(lpVtbl[10]))((IHttpGetStringResult*)Unsafe.AsPointer(ref this), value);
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

        [VtblIndex(10)]
        HRESULT get_Value(HSTRING* value);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Value;
    }
}
