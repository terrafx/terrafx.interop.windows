// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IPresentStatusPresentStatistics.xml' path='doc/member[@name="IPresentStatusPresentStatistics"]/*' />
[Guid("C9ED2A41-79CB-435E-964E-C8553055420C")]
[NativeTypeName("struct IPresentStatusPresentStatistics : IPresentStatistics")]
[NativeInheritance("IPresentStatistics")]
public unsafe partial struct IPresentStatusPresentStatistics : IPresentStatusPresentStatistics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPresentStatusPresentStatistics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentStatusPresentStatistics*, Guid*, void**, int>)(lpVtbl[0]))((IPresentStatusPresentStatistics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentStatusPresentStatistics*, uint>)(lpVtbl[1]))((IPresentStatusPresentStatistics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentStatusPresentStatistics*, uint>)(lpVtbl[2]))((IPresentStatusPresentStatistics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IPresentStatistics.GetPresentId" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("UINT64")]
    public ulong GetPresentId()
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentStatusPresentStatistics*, ulong>)(lpVtbl[3]))((IPresentStatusPresentStatistics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IPresentStatistics.GetKind" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public PresentStatisticsKind GetKind()
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentStatusPresentStatistics*, PresentStatisticsKind>)(lpVtbl[4]))((IPresentStatusPresentStatistics*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPresentStatusPresentStatistics.xml' path='doc/member[@name="IPresentStatusPresentStatistics.GetCompositionFrameId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("CompositionFrameId")]
    public ulong GetCompositionFrameId()
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentStatusPresentStatistics*, ulong>)(lpVtbl[5]))((IPresentStatusPresentStatistics*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPresentStatusPresentStatistics.xml' path='doc/member[@name="IPresentStatusPresentStatistics.GetPresentStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public PresentStatus GetPresentStatus()
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentStatusPresentStatistics*, PresentStatus>)(lpVtbl[6]))((IPresentStatusPresentStatistics*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IPresentStatistics.Interface
    {
        [VtblIndex(5)]
        [return: NativeTypeName("CompositionFrameId")]
        ulong GetCompositionFrameId();

        [VtblIndex(6)]
        PresentStatus GetPresentStatus();
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

        [NativeTypeName("CompositionFrameId () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong> GetCompositionFrameId;

        [NativeTypeName("PresentStatus () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PresentStatus> GetPresentStatus;
    }
}
