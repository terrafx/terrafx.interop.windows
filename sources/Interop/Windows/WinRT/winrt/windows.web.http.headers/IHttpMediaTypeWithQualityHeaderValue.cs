// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.web.http.headers.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHttpMediaTypeWithQualityHeaderValue.xml' path='doc/member[@name="IHttpMediaTypeWithQualityHeaderValue"]/*' />
[Guid("188D5E32-76BE-44A0-B1CD-2074BDED2DDE")]
[NativeTypeName("struct IHttpMediaTypeWithQualityHeaderValue : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpMediaTypeWithQualityHeaderValue : IHttpMediaTypeWithQualityHeaderValue.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpMediaTypeWithQualityHeaderValue));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpMediaTypeWithQualityHeaderValue*, Guid*, void**, int>)(lpVtbl[0]))((IHttpMediaTypeWithQualityHeaderValue*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpMediaTypeWithQualityHeaderValue*, uint>)(lpVtbl[1]))((IHttpMediaTypeWithQualityHeaderValue*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpMediaTypeWithQualityHeaderValue*, uint>)(lpVtbl[2]))((IHttpMediaTypeWithQualityHeaderValue*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpMediaTypeWithQualityHeaderValue*, uint*, Guid**, int>)(lpVtbl[3]))((IHttpMediaTypeWithQualityHeaderValue*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpMediaTypeWithQualityHeaderValue*, HSTRING*, int>)(lpVtbl[4]))((IHttpMediaTypeWithQualityHeaderValue*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpMediaTypeWithQualityHeaderValue*, TrustLevel*, int>)(lpVtbl[5]))((IHttpMediaTypeWithQualityHeaderValue*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHttpMediaTypeWithQualityHeaderValue.xml' path='doc/member[@name="IHttpMediaTypeWithQualityHeaderValue.get_CharSet"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CharSet(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpMediaTypeWithQualityHeaderValue*, HSTRING*, int>)(lpVtbl[6]))((IHttpMediaTypeWithQualityHeaderValue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpMediaTypeWithQualityHeaderValue.xml' path='doc/member[@name="IHttpMediaTypeWithQualityHeaderValue.put_CharSet"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_CharSet(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpMediaTypeWithQualityHeaderValue*, HSTRING, int>)(lpVtbl[7]))((IHttpMediaTypeWithQualityHeaderValue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpMediaTypeWithQualityHeaderValue.xml' path='doc/member[@name="IHttpMediaTypeWithQualityHeaderValue.get_MediaType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_MediaType(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpMediaTypeWithQualityHeaderValue*, HSTRING*, int>)(lpVtbl[8]))((IHttpMediaTypeWithQualityHeaderValue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpMediaTypeWithQualityHeaderValue.xml' path='doc/member[@name="IHttpMediaTypeWithQualityHeaderValue.put_MediaType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_MediaType(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpMediaTypeWithQualityHeaderValue*, HSTRING, int>)(lpVtbl[9]))((IHttpMediaTypeWithQualityHeaderValue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpMediaTypeWithQualityHeaderValue.xml' path='doc/member[@name="IHttpMediaTypeWithQualityHeaderValue.get_Parameters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Parameters([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CWeb__CHttp__CHeaders__CHttpNameValueHeaderValue_t **")] IVector<IntPtr>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpMediaTypeWithQualityHeaderValue*, IVector<IntPtr>**, int>)(lpVtbl[10]))((IHttpMediaTypeWithQualityHeaderValue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpMediaTypeWithQualityHeaderValue.xml' path='doc/member[@name="IHttpMediaTypeWithQualityHeaderValue.get_Quality"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Quality([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")] IReference<double>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpMediaTypeWithQualityHeaderValue*, IReference<double>**, int>)(lpVtbl[11]))((IHttpMediaTypeWithQualityHeaderValue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpMediaTypeWithQualityHeaderValue.xml' path='doc/member[@name="IHttpMediaTypeWithQualityHeaderValue.put_Quality"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_Quality([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t *")] IReference<double>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpMediaTypeWithQualityHeaderValue*, IReference<double>*, int>)(lpVtbl[12]))((IHttpMediaTypeWithQualityHeaderValue*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_CharSet(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_CharSet(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_MediaType(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_MediaType(HSTRING value);

        [VtblIndex(10)]
        HRESULT get_Parameters([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CWeb__CHttp__CHeaders__CHttpNameValueHeaderValue_t **")] IVector<IntPtr>** value);

        [VtblIndex(11)]
        HRESULT get_Quality([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")] IReference<double>** value);

        [VtblIndex(12)]
        HRESULT put_Quality([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t *")] IReference<double>* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_CharSet;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_CharSet;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_MediaType;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_MediaType;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CWeb__CHttp__CHeaders__CHttpNameValueHeaderValue_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<IntPtr>**, int> get_Parameters;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_double_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<double>**, int> get_Quality;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_double_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<double>*, int> put_Quality;
    }
}
