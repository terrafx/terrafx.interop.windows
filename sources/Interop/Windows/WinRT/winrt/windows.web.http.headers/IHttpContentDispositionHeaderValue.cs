// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.web.http.headers.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHttpContentDispositionHeaderValue.xml' path='doc/member[@name="IHttpContentDispositionHeaderValue"]/*' />
[Guid("F2A2EEDC-2629-4B49-9908-96A168E9365E")]
[NativeTypeName("struct IHttpContentDispositionHeaderValue : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpContentDispositionHeaderValue : IHttpContentDispositionHeaderValue.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IHttpContentDispositionHeaderValue);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContentDispositionHeaderValue*, Guid*, void**, int>)(lpVtbl[0]))((IHttpContentDispositionHeaderValue*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContentDispositionHeaderValue*, uint>)(lpVtbl[1]))((IHttpContentDispositionHeaderValue*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContentDispositionHeaderValue*, uint>)(lpVtbl[2]))((IHttpContentDispositionHeaderValue*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContentDispositionHeaderValue*, uint*, Guid**, int>)(lpVtbl[3]))((IHttpContentDispositionHeaderValue*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContentDispositionHeaderValue*, HSTRING*, int>)(lpVtbl[4]))((IHttpContentDispositionHeaderValue*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContentDispositionHeaderValue*, TrustLevel*, int>)(lpVtbl[5]))((IHttpContentDispositionHeaderValue*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHttpContentDispositionHeaderValue.xml' path='doc/member[@name="IHttpContentDispositionHeaderValue.get_DispositionType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DispositionType(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContentDispositionHeaderValue*, HSTRING*, int>)(lpVtbl[6]))((IHttpContentDispositionHeaderValue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpContentDispositionHeaderValue.xml' path='doc/member[@name="IHttpContentDispositionHeaderValue.put_DispositionType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_DispositionType(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContentDispositionHeaderValue*, HSTRING, int>)(lpVtbl[7]))((IHttpContentDispositionHeaderValue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpContentDispositionHeaderValue.xml' path='doc/member[@name="IHttpContentDispositionHeaderValue.get_FileName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_FileName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContentDispositionHeaderValue*, HSTRING*, int>)(lpVtbl[8]))((IHttpContentDispositionHeaderValue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpContentDispositionHeaderValue.xml' path='doc/member[@name="IHttpContentDispositionHeaderValue.put_FileName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_FileName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContentDispositionHeaderValue*, HSTRING, int>)(lpVtbl[9]))((IHttpContentDispositionHeaderValue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpContentDispositionHeaderValue.xml' path='doc/member[@name="IHttpContentDispositionHeaderValue.get_FileNameStar"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_FileNameStar(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContentDispositionHeaderValue*, HSTRING*, int>)(lpVtbl[10]))((IHttpContentDispositionHeaderValue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpContentDispositionHeaderValue.xml' path='doc/member[@name="IHttpContentDispositionHeaderValue.put_FileNameStar"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_FileNameStar(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContentDispositionHeaderValue*, HSTRING, int>)(lpVtbl[11]))((IHttpContentDispositionHeaderValue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpContentDispositionHeaderValue.xml' path='doc/member[@name="IHttpContentDispositionHeaderValue.get_Name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Name(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContentDispositionHeaderValue*, HSTRING*, int>)(lpVtbl[12]))((IHttpContentDispositionHeaderValue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpContentDispositionHeaderValue.xml' path='doc/member[@name="IHttpContentDispositionHeaderValue.put_Name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_Name(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContentDispositionHeaderValue*, HSTRING, int>)(lpVtbl[13]))((IHttpContentDispositionHeaderValue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpContentDispositionHeaderValue.xml' path='doc/member[@name="IHttpContentDispositionHeaderValue.get_Parameters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Parameters([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CWeb__CHttp__CHeaders__CHttpNameValueHeaderValue_t **")] IVector<Pointer<IHttpNameValueHeaderValue>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContentDispositionHeaderValue*, IVector<Pointer<IHttpNameValueHeaderValue>>**, int>)(lpVtbl[14]))((IHttpContentDispositionHeaderValue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpContentDispositionHeaderValue.xml' path='doc/member[@name="IHttpContentDispositionHeaderValue.get_Size"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_Size([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT64_t **")] IReference<ulong>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContentDispositionHeaderValue*, IReference<ulong>**, int>)(lpVtbl[15]))((IHttpContentDispositionHeaderValue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpContentDispositionHeaderValue.xml' path='doc/member[@name="IHttpContentDispositionHeaderValue.put_Size"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_Size([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT64_t *")] IReference<ulong>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContentDispositionHeaderValue*, IReference<ulong>*, int>)(lpVtbl[16]))((IHttpContentDispositionHeaderValue*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DispositionType(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_DispositionType(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_FileName(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_FileName(HSTRING value);

        [VtblIndex(10)]
        HRESULT get_FileNameStar(HSTRING* value);

        [VtblIndex(11)]
        HRESULT put_FileNameStar(HSTRING value);

        [VtblIndex(12)]
        HRESULT get_Name(HSTRING* value);

        [VtblIndex(13)]
        HRESULT put_Name(HSTRING value);

        [VtblIndex(14)]
        HRESULT get_Parameters([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CWeb__CHttp__CHeaders__CHttpNameValueHeaderValue_t **")] IVector<Pointer<IHttpNameValueHeaderValue>>** value);

        [VtblIndex(15)]
        HRESULT get_Size([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT64_t **")] IReference<ulong>** value);

        [VtblIndex(16)]
        HRESULT put_Size([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT64_t *")] IReference<ulong>* value);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DispositionType;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_DispositionType;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_FileName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_FileName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_FileNameStar;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_FileNameStar;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Name;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Name;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CWeb__CHttp__CHeaders__CHttpNameValueHeaderValue_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<Pointer<IHttpNameValueHeaderValue>>**, int> get_Parameters;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT64_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<ulong>**, int> get_Size;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT64_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<ulong>*, int> put_Size;
    }
}
