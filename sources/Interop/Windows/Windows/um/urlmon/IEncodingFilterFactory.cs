// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IEncodingFilterFactory.xml' path='doc/member[@name="IEncodingFilterFactory"]/*' />
[Guid("70BDDE00-C18E-11D0-A9CE-006097942311")]
[NativeTypeName("struct IEncodingFilterFactory : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IEncodingFilterFactory : IEncodingFilterFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEncodingFilterFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IEncodingFilterFactory*, Guid*, void**, int>)(lpVtbl[0]))((IEncodingFilterFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IEncodingFilterFactory*, uint>)(lpVtbl[1]))((IEncodingFilterFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IEncodingFilterFactory*, uint>)(lpVtbl[2]))((IEncodingFilterFactory*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEncodingFilterFactory.xml' path='doc/member[@name="IEncodingFilterFactory.FindBestFilter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT FindBestFilter([NativeTypeName("LPCWSTR")] char* pwzCodeIn, [NativeTypeName("LPCWSTR")] char* pwzCodeOut, DATAINFO info, IDataFilter** ppDF)
    {
        return ((delegate* unmanaged[MemberFunction]<IEncodingFilterFactory*, char*, char*, DATAINFO, IDataFilter**, int>)(lpVtbl[3]))((IEncodingFilterFactory*)Unsafe.AsPointer(ref this), pwzCodeIn, pwzCodeOut, info, ppDF);
    }

    /// <include file='IEncodingFilterFactory.xml' path='doc/member[@name="IEncodingFilterFactory.GetDefaultFilter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetDefaultFilter([NativeTypeName("LPCWSTR")] char* pwzCodeIn, [NativeTypeName("LPCWSTR")] char* pwzCodeOut, IDataFilter** ppDF)
    {
        return ((delegate* unmanaged[MemberFunction]<IEncodingFilterFactory*, char*, char*, IDataFilter**, int>)(lpVtbl[4]))((IEncodingFilterFactory*)Unsafe.AsPointer(ref this), pwzCodeIn, pwzCodeOut, ppDF);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT FindBestFilter([NativeTypeName("LPCWSTR")] char* pwzCodeIn, [NativeTypeName("LPCWSTR")] char* pwzCodeOut, DATAINFO info, IDataFilter** ppDF);

        [VtblIndex(4)]
        HRESULT GetDefaultFilter([NativeTypeName("LPCWSTR")] char* pwzCodeIn, [NativeTypeName("LPCWSTR")] char* pwzCodeOut, IDataFilter** ppDF);
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

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, DATAINFO, IDataFilter **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, DATAINFO, IDataFilter**, int> FindBestFilter;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, IDataFilter **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, IDataFilter**, int> GetDefaultFilter;
    }
}
