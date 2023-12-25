// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.web.http.headers.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHttpContentRangeHeaderValue.xml' path='doc/member[@name="IHttpContentRangeHeaderValue"]/*' />
[Guid("04D967D3-A4F6-495C-9530-8579FCBA8AA9")]
[NativeTypeName("struct IHttpContentRangeHeaderValue : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpContentRangeHeaderValue : IHttpContentRangeHeaderValue.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpContentRangeHeaderValue));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContentRangeHeaderValue*, Guid*, void**, int>)(lpVtbl[0]))((IHttpContentRangeHeaderValue*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContentRangeHeaderValue*, uint>)(lpVtbl[1]))((IHttpContentRangeHeaderValue*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContentRangeHeaderValue*, uint>)(lpVtbl[2]))((IHttpContentRangeHeaderValue*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContentRangeHeaderValue*, uint*, Guid**, int>)(lpVtbl[3]))((IHttpContentRangeHeaderValue*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContentRangeHeaderValue*, HSTRING*, int>)(lpVtbl[4]))((IHttpContentRangeHeaderValue*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContentRangeHeaderValue*, TrustLevel*, int>)(lpVtbl[5]))((IHttpContentRangeHeaderValue*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHttpContentRangeHeaderValue.xml' path='doc/member[@name="IHttpContentRangeHeaderValue.get_FirstBytePosition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_FirstBytePosition([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT64_t **")] IReference<ulong>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContentRangeHeaderValue*, IReference<ulong>**, int>)(lpVtbl[6]))((IHttpContentRangeHeaderValue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpContentRangeHeaderValue.xml' path='doc/member[@name="IHttpContentRangeHeaderValue.get_LastBytePosition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_LastBytePosition([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT64_t **")] IReference<ulong>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContentRangeHeaderValue*, IReference<ulong>**, int>)(lpVtbl[7]))((IHttpContentRangeHeaderValue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpContentRangeHeaderValue.xml' path='doc/member[@name="IHttpContentRangeHeaderValue.get_Length"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Length([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT64_t **")] IReference<ulong>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContentRangeHeaderValue*, IReference<ulong>**, int>)(lpVtbl[8]))((IHttpContentRangeHeaderValue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpContentRangeHeaderValue.xml' path='doc/member[@name="IHttpContentRangeHeaderValue.get_Unit"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Unit(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContentRangeHeaderValue*, HSTRING*, int>)(lpVtbl[9]))((IHttpContentRangeHeaderValue*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHttpContentRangeHeaderValue.xml' path='doc/member[@name="IHttpContentRangeHeaderValue.put_Unit"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_Unit(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContentRangeHeaderValue*, HSTRING, int>)(lpVtbl[10]))((IHttpContentRangeHeaderValue*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_FirstBytePosition([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT64_t **")] IReference<ulong>** value);

        [VtblIndex(7)]
        HRESULT get_LastBytePosition([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT64_t **")] IReference<ulong>** value);

        [VtblIndex(8)]
        HRESULT get_Length([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT64_t **")] IReference<ulong>** value);

        [VtblIndex(9)]
        HRESULT get_Unit(HSTRING* value);

        [VtblIndex(10)]
        HRESULT put_Unit(HSTRING value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT64_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<ulong>**, int> get_FirstBytePosition;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT64_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<ulong>**, int> get_LastBytePosition;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT64_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<ulong>**, int> get_Length;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Unit;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Unit;
    }
}
