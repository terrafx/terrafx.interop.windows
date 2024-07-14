// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.web.http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHttpGetBufferResult.xml' path='doc/member[@name="IHttpGetBufferResult"]/*' />
[Guid("53D08E7C-E209-404E-9A49-742D8236FD3A")]
[NativeTypeName("struct IHttpGetBufferResult : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpGetBufferResult : IHttpGetBufferResult.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpGetBufferResult));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpGetBufferResult*, Guid*, void**, int>)(lpVtbl[0]))((IHttpGetBufferResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpGetBufferResult*, uint>)(lpVtbl[1]))((IHttpGetBufferResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpGetBufferResult*, uint>)(lpVtbl[2]))((IHttpGetBufferResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpGetBufferResult*, uint*, Guid**, int>)(lpVtbl[3]))((IHttpGetBufferResult*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpGetBufferResult*, HSTRING*, int>)(lpVtbl[4]))((IHttpGetBufferResult*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpGetBufferResult*, TrustLevel*, int>)(lpVtbl[5]))((IHttpGetBufferResult*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHttpGetBufferResult.xml' path='doc/member[@name="IHttpGetBufferResult.get_ExtendedError"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ExtendedError(HRESULT* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpGetBufferResult*, HRESULT*, int>)(lpVtbl[6]))((IHttpGetBufferResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpGetBufferResult.xml' path='doc/member[@name="IHttpGetBufferResult.get_RequestMessage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_RequestMessage([NativeTypeName("ABI::Windows::Web::Http::IHttpRequestMessage **")] IHttpRequestMessage** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpGetBufferResult*, IHttpRequestMessage**, int>)(lpVtbl[7]))((IHttpGetBufferResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpGetBufferResult.xml' path='doc/member[@name="IHttpGetBufferResult.get_ResponseMessage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ResponseMessage([NativeTypeName("ABI::Windows::Web::Http::IHttpResponseMessage **")] IHttpResponseMessage** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpGetBufferResult*, IHttpResponseMessage**, int>)(lpVtbl[8]))((IHttpGetBufferResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpGetBufferResult.xml' path='doc/member[@name="IHttpGetBufferResult.get_Succeeded"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Succeeded([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpGetBufferResult*, byte*, int>)(lpVtbl[9]))((IHttpGetBufferResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpGetBufferResult.xml' path='doc/member[@name="IHttpGetBufferResult.get_Value"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Value([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpGetBufferResult*, IBuffer**, int>)(lpVtbl[10]))((IHttpGetBufferResult*)Unsafe.AsPointer(ref this), value);
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
        HRESULT get_Value([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer**, int> get_Value;
    }
}
