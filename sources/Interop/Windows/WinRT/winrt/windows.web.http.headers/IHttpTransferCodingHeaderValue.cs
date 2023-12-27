// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.web.http.headers.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHttpTransferCodingHeaderValue.xml' path='doc/member[@name="IHttpTransferCodingHeaderValue"]/*' />
[Guid("436F32F9-3DED-42BD-B38A-5496A2511CE6")]
[NativeTypeName("struct IHttpTransferCodingHeaderValue : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpTransferCodingHeaderValue : IHttpTransferCodingHeaderValue.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpTransferCodingHeaderValue));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpTransferCodingHeaderValue*, Guid*, void**, int>)(lpVtbl[0]))((IHttpTransferCodingHeaderValue*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpTransferCodingHeaderValue*, uint>)(lpVtbl[1]))((IHttpTransferCodingHeaderValue*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpTransferCodingHeaderValue*, uint>)(lpVtbl[2]))((IHttpTransferCodingHeaderValue*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpTransferCodingHeaderValue*, uint*, Guid**, int>)(lpVtbl[3]))((IHttpTransferCodingHeaderValue*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpTransferCodingHeaderValue*, HSTRING*, int>)(lpVtbl[4]))((IHttpTransferCodingHeaderValue*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpTransferCodingHeaderValue*, TrustLevel*, int>)(lpVtbl[5]))((IHttpTransferCodingHeaderValue*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHttpTransferCodingHeaderValue.xml' path='doc/member[@name="IHttpTransferCodingHeaderValue.get_Parameters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Parameters([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CWeb__CHttp__CHeaders__CHttpNameValueHeaderValue_t **")] IVector<Pointer<IHttpNameValueHeaderValue>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpTransferCodingHeaderValue*, IVector<Pointer<IHttpNameValueHeaderValue>>**, int>)(lpVtbl[6]))((IHttpTransferCodingHeaderValue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpTransferCodingHeaderValue.xml' path='doc/member[@name="IHttpTransferCodingHeaderValue.get_Value"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Value(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpTransferCodingHeaderValue*, HSTRING*, int>)(lpVtbl[7]))((IHttpTransferCodingHeaderValue*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Parameters([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CWeb__CHttp__CHeaders__CHttpNameValueHeaderValue_t **")] IVector<Pointer<IHttpNameValueHeaderValue>>** value);

        [VtblIndex(7)]
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CWeb__CHttp__CHeaders__CHttpNameValueHeaderValue_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<Pointer<IHttpNameValueHeaderValue>>**, int> get_Parameters;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Value;
    }
}
