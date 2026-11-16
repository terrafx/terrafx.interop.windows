// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wia_lh.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IWiaSegmentationFilter.xml' path='doc/member[@name="IWiaSegmentationFilter"]/*' />
[Guid("EC46A697-AC04-4447-8F65-FF63D5154B21")]
[NativeTypeName("struct IWiaSegmentationFilter : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWiaSegmentationFilter : IWiaSegmentationFilter.Interface, INativeGuid
{
    /// <include file='IWiaSegmentationFilter.xml' path='doc/member[@name="IWiaSegmentationFilter.INativeGuid.NativeGuid"]/*' />
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IWiaSegmentationFilter);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaSegmentationFilter*, Guid*, void**, int>)(lpVtbl[0]))((IWiaSegmentationFilter*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaSegmentationFilter*, uint>)(lpVtbl[1]))((IWiaSegmentationFilter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaSegmentationFilter*, uint>)(lpVtbl[2]))((IWiaSegmentationFilter*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWiaSegmentationFilter.xml' path='doc/member[@name="IWiaSegmentationFilter.DetectRegions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT DetectRegions([NativeTypeName("LONG")] int lFlags, IStream* pInputStream, IWiaItem2* pWiaItem2)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaSegmentationFilter*, int, IStream*, IWiaItem2*, int>)(lpVtbl[3]))((IWiaSegmentationFilter*)Unsafe.AsPointer(ref this), lFlags, pInputStream, pWiaItem2);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT DetectRegions([NativeTypeName("LONG")] int lFlags, IStream* pInputStream, IWiaItem2* pWiaItem2);
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

        [NativeTypeName("HRESULT (LONG, IStream *, IWiaItem2 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, IStream*, IWiaItem2*, int> DetectRegions;
    }
}
