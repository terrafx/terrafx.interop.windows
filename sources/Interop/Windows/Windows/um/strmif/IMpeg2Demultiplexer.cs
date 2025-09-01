// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IMpeg2Demultiplexer.xml' path='doc/member[@name="IMpeg2Demultiplexer"]/*' />
[Guid("436EEE9C-264F-4242-90E1-4E330C107512")]
[NativeTypeName("struct IMpeg2Demultiplexer : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMpeg2Demultiplexer : IMpeg2Demultiplexer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IMpeg2Demultiplexer);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMpeg2Demultiplexer*, Guid*, void**, int>)(lpVtbl[0]))((IMpeg2Demultiplexer*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMpeg2Demultiplexer*, uint>)(lpVtbl[1]))((IMpeg2Demultiplexer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMpeg2Demultiplexer*, uint>)(lpVtbl[2]))((IMpeg2Demultiplexer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMpeg2Demultiplexer.xml' path='doc/member[@name="IMpeg2Demultiplexer.CreateOutputPin"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateOutputPin(AM_MEDIA_TYPE* pMediaType, [NativeTypeName("LPWSTR")] char* pszPinName, IPin** ppIPin)
    {
        return ((delegate* unmanaged[MemberFunction]<IMpeg2Demultiplexer*, AM_MEDIA_TYPE*, char*, IPin**, int>)(lpVtbl[3]))((IMpeg2Demultiplexer*)Unsafe.AsPointer(ref this), pMediaType, pszPinName, ppIPin);
    }

    /// <include file='IMpeg2Demultiplexer.xml' path='doc/member[@name="IMpeg2Demultiplexer.SetOutputPinMediaType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetOutputPinMediaType([NativeTypeName("LPWSTR")] char* pszPinName, AM_MEDIA_TYPE* pMediaType)
    {
        return ((delegate* unmanaged[MemberFunction]<IMpeg2Demultiplexer*, char*, AM_MEDIA_TYPE*, int>)(lpVtbl[4]))((IMpeg2Demultiplexer*)Unsafe.AsPointer(ref this), pszPinName, pMediaType);
    }

    /// <include file='IMpeg2Demultiplexer.xml' path='doc/member[@name="IMpeg2Demultiplexer.DeleteOutputPin"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT DeleteOutputPin([NativeTypeName("LPWSTR")] char* pszPinName)
    {
        return ((delegate* unmanaged[MemberFunction]<IMpeg2Demultiplexer*, char*, int>)(lpVtbl[5]))((IMpeg2Demultiplexer*)Unsafe.AsPointer(ref this), pszPinName);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateOutputPin(AM_MEDIA_TYPE* pMediaType, [NativeTypeName("LPWSTR")] char* pszPinName, IPin** ppIPin);

        [VtblIndex(4)]
        HRESULT SetOutputPinMediaType([NativeTypeName("LPWSTR")] char* pszPinName, AM_MEDIA_TYPE* pMediaType);

        [VtblIndex(5)]
        HRESULT DeleteOutputPin([NativeTypeName("LPWSTR")] char* pszPinName);
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

        [NativeTypeName("HRESULT (AM_MEDIA_TYPE *, LPWSTR, IPin **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AM_MEDIA_TYPE*, char*, IPin**, int> CreateOutputPin;

        [NativeTypeName("HRESULT (LPWSTR, AM_MEDIA_TYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, AM_MEDIA_TYPE*, int> SetOutputPinMediaType;

        [NativeTypeName("HRESULT (LPWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> DeleteOutputPin;
    }
}
