// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Presentation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IPresentStatistics.xml' path='doc/member[@name="IPresentStatistics"]/*' />
[Guid("B44B8BDA-7282-495D-9DD7-CEADD8B4BB86")]
[NativeTypeName("struct IPresentStatistics : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPresentStatistics : IPresentStatistics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPresentStatistics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentStatistics*, Guid*, void**, int>)(lpVtbl[0]))((IPresentStatistics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentStatistics*, uint>)(lpVtbl[1]))((IPresentStatistics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentStatistics*, uint>)(lpVtbl[2]))((IPresentStatistics*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPresentStatistics.xml' path='doc/member[@name="IPresentStatistics.GetPresentId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("UINT64")]
    public ulong GetPresentId()
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentStatistics*, ulong>)(lpVtbl[3]))((IPresentStatistics*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPresentStatistics.xml' path='doc/member[@name="IPresentStatistics.GetKind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public PresentStatisticsKind GetKind()
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentStatistics*, PresentStatisticsKind>)(lpVtbl[4]))((IPresentStatistics*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [return: NativeTypeName("UINT64")]
        ulong GetPresentId();

        [VtblIndex(4)]
        PresentStatisticsKind GetKind();
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

        [NativeTypeName("UINT64 () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong> GetPresentId;

        [NativeTypeName("PresentStatisticsKind () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PresentStatisticsKind> GetKind;
    }
}
