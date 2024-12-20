// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.DirectX;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='ICompositionFramePresentStatistics.xml' path='doc/member[@name="ICompositionFramePresentStatistics"]/*' />
[Guid("AB41D127-C101-4C0A-911D-F9F2E9D08E64")]
[NativeTypeName("struct ICompositionFramePresentStatistics : IPresentStatistics")]
[NativeInheritance("IPresentStatistics")]
public unsafe partial struct ICompositionFramePresentStatistics : ICompositionFramePresentStatistics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositionFramePresentStatistics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionFramePresentStatistics*, Guid*, void**, int>)(lpVtbl[0]))((ICompositionFramePresentStatistics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionFramePresentStatistics*, uint>)(lpVtbl[1]))((ICompositionFramePresentStatistics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionFramePresentStatistics*, uint>)(lpVtbl[2]))((ICompositionFramePresentStatistics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IPresentStatistics.GetPresentId" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("UINT64")]
    public ulong GetPresentId()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionFramePresentStatistics*, ulong>)(lpVtbl[3]))((ICompositionFramePresentStatistics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IPresentStatistics.GetKind" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public PresentStatisticsKind GetKind()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionFramePresentStatistics*, PresentStatisticsKind>)(lpVtbl[4]))((ICompositionFramePresentStatistics*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICompositionFramePresentStatistics.xml' path='doc/member[@name="ICompositionFramePresentStatistics.GetContentTag"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("UINT_PTR")]
    public nuint GetContentTag()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionFramePresentStatistics*, nuint>)(lpVtbl[5]))((ICompositionFramePresentStatistics*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICompositionFramePresentStatistics.xml' path='doc/member[@name="ICompositionFramePresentStatistics.GetCompositionFrameId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [return: NativeTypeName("CompositionFrameId")]
    public ulong GetCompositionFrameId()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionFramePresentStatistics*, ulong>)(lpVtbl[6]))((ICompositionFramePresentStatistics*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICompositionFramePresentStatistics.xml' path='doc/member[@name="ICompositionFramePresentStatistics.GetDisplayInstanceArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void GetDisplayInstanceArray(uint* displayInstanceArrayCount, [NativeTypeName("const CompositionFrameDisplayInstance **")] CompositionFrameDisplayInstance** displayInstanceArray)
    {
        ((delegate* unmanaged[MemberFunction]<ICompositionFramePresentStatistics*, uint*, CompositionFrameDisplayInstance**, void>)(lpVtbl[7]))((ICompositionFramePresentStatistics*)Unsafe.AsPointer(ref this), displayInstanceArrayCount, displayInstanceArray);
    }

    public interface Interface : IPresentStatistics.Interface
    {
        [VtblIndex(5)]
        [return: NativeTypeName("UINT_PTR")]
        nuint GetContentTag();

        [VtblIndex(6)]
        [return: NativeTypeName("CompositionFrameId")]
        ulong GetCompositionFrameId();

        [VtblIndex(7)]
        void GetDisplayInstanceArray(uint* displayInstanceArrayCount, [NativeTypeName("const CompositionFrameDisplayInstance **")] CompositionFrameDisplayInstance** displayInstanceArray);
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

        [NativeTypeName("UINT_PTR () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, nuint> GetContentTag;

        [NativeTypeName("CompositionFrameId () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong> GetCompositionFrameId;

        [NativeTypeName("void (UINT *, const CompositionFrameDisplayInstance **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, CompositionFrameDisplayInstance**, void> GetDisplayInstanceArray;
    }
}
