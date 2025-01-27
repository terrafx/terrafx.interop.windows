// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Presentation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IIndependentFlipFramePresentStatistics.xml' path='doc/member[@name="IIndependentFlipFramePresentStatistics"]/*' />
[Guid("8C93BE27-AD94-4DA0-8FD4-2413132D124E")]
[NativeTypeName("struct IIndependentFlipFramePresentStatistics : IPresentStatistics")]
[NativeInheritance("IPresentStatistics")]
public unsafe partial struct IIndependentFlipFramePresentStatistics : IIndependentFlipFramePresentStatistics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IIndependentFlipFramePresentStatistics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IIndependentFlipFramePresentStatistics*, Guid*, void**, int>)(lpVtbl[0]))((IIndependentFlipFramePresentStatistics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IIndependentFlipFramePresentStatistics*, uint>)(lpVtbl[1]))((IIndependentFlipFramePresentStatistics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IIndependentFlipFramePresentStatistics*, uint>)(lpVtbl[2]))((IIndependentFlipFramePresentStatistics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IPresentStatistics.GetPresentId" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("UINT64")]
    public ulong GetPresentId()
    {
        return ((delegate* unmanaged[MemberFunction]<IIndependentFlipFramePresentStatistics*, ulong>)(lpVtbl[3]))((IIndependentFlipFramePresentStatistics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IPresentStatistics.GetKind" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public PresentStatisticsKind GetKind()
    {
        return ((delegate* unmanaged[MemberFunction]<IIndependentFlipFramePresentStatistics*, PresentStatisticsKind>)(lpVtbl[4]))((IIndependentFlipFramePresentStatistics*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IIndependentFlipFramePresentStatistics.xml' path='doc/member[@name="IIndependentFlipFramePresentStatistics.GetOutputAdapterLUID"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public LUID GetOutputAdapterLUID()
    {
        return ((delegate* unmanaged[MemberFunction]<IIndependentFlipFramePresentStatistics*, LUID>)(lpVtbl[5]))((IIndependentFlipFramePresentStatistics*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IIndependentFlipFramePresentStatistics.xml' path='doc/member[@name="IIndependentFlipFramePresentStatistics.GetOutputVidPnSourceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public uint GetOutputVidPnSourceId()
    {
        return ((delegate* unmanaged[MemberFunction]<IIndependentFlipFramePresentStatistics*, uint>)(lpVtbl[6]))((IIndependentFlipFramePresentStatistics*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IIndependentFlipFramePresentStatistics.xml' path='doc/member[@name="IIndependentFlipFramePresentStatistics.GetContentTag"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [return: NativeTypeName("UINT_PTR")]
    public nuint GetContentTag()
    {
        return ((delegate* unmanaged[MemberFunction]<IIndependentFlipFramePresentStatistics*, nuint>)(lpVtbl[7]))((IIndependentFlipFramePresentStatistics*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IIndependentFlipFramePresentStatistics.xml' path='doc/member[@name="IIndependentFlipFramePresentStatistics.GetDisplayedTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public SystemInterruptTime GetDisplayedTime()
    {
        return ((delegate* unmanaged[MemberFunction]<IIndependentFlipFramePresentStatistics*, SystemInterruptTime>)(lpVtbl[8]))((IIndependentFlipFramePresentStatistics*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IIndependentFlipFramePresentStatistics.xml' path='doc/member[@name="IIndependentFlipFramePresentStatistics.GetPresentDuration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public SystemInterruptTime GetPresentDuration()
    {
        return ((delegate* unmanaged[MemberFunction]<IIndependentFlipFramePresentStatistics*, SystemInterruptTime>)(lpVtbl[9]))((IIndependentFlipFramePresentStatistics*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IPresentStatistics.Interface
    {
        [VtblIndex(5)]
        LUID GetOutputAdapterLUID();

        [VtblIndex(6)]
        uint GetOutputVidPnSourceId();

        [VtblIndex(7)]
        [return: NativeTypeName("UINT_PTR")]
        nuint GetContentTag();

        [VtblIndex(8)]
        SystemInterruptTime GetDisplayedTime();

        [VtblIndex(9)]
        SystemInterruptTime GetPresentDuration();
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

        [NativeTypeName("LUID () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, LUID> GetOutputAdapterLUID;

        [NativeTypeName("UINT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> GetOutputVidPnSourceId;

        [NativeTypeName("UINT_PTR () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, nuint> GetContentTag;

        [NativeTypeName("SystemInterruptTime () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SystemInterruptTime> GetDisplayedTime;

        [NativeTypeName("SystemInterruptTime () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SystemInterruptTime> GetPresentDuration;
    }
}
