// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Presentation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IPresentationManager.xml' path='doc/member[@name="IPresentationManager"]/*' />
[Guid("FB562F82-6292-470A-88B1-843661E7F20C")]
[NativeTypeName("struct IPresentationManager : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPresentationManager : IPresentationManager.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPresentationManager));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentationManager*, Guid*, void**, int>)(lpVtbl[0]))((IPresentationManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentationManager*, uint>)(lpVtbl[1]))((IPresentationManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentationManager*, uint>)(lpVtbl[2]))((IPresentationManager*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPresentationManager.xml' path='doc/member[@name="IPresentationManager.AddBufferFromResource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddBufferFromResource(IUnknown* resource, IPresentationBuffer** presentationBuffer)
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentationManager*, IUnknown*, IPresentationBuffer**, int>)(lpVtbl[3]))((IPresentationManager*)Unsafe.AsPointer(ref this), resource, presentationBuffer);
    }

    /// <include file='IPresentationManager.xml' path='doc/member[@name="IPresentationManager.CreatePresentationSurface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreatePresentationSurface(HANDLE compositionSurfaceHandle, IPresentationSurface** presentationSurface)
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentationManager*, HANDLE, IPresentationSurface**, int>)(lpVtbl[4]))((IPresentationManager*)Unsafe.AsPointer(ref this), compositionSurfaceHandle, presentationSurface);
    }

    /// <include file='IPresentationManager.xml' path='doc/member[@name="IPresentationManager.GetNextPresentId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("UINT64")]
    public ulong GetNextPresentId()
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentationManager*, ulong>)(lpVtbl[5]))((IPresentationManager*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPresentationManager.xml' path='doc/member[@name="IPresentationManager.SetTargetTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetTargetTime(SystemInterruptTime targetTime)
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentationManager*, SystemInterruptTime, int>)(lpVtbl[6]))((IPresentationManager*)Unsafe.AsPointer(ref this), targetTime);
    }

    /// <include file='IPresentationManager.xml' path='doc/member[@name="IPresentationManager.SetPreferredPresentDuration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetPreferredPresentDuration(SystemInterruptTime preferredDuration, SystemInterruptTime deviationTolerance)
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentationManager*, SystemInterruptTime, SystemInterruptTime, int>)(lpVtbl[7]))((IPresentationManager*)Unsafe.AsPointer(ref this), preferredDuration, deviationTolerance);
    }

    /// <include file='IPresentationManager.xml' path='doc/member[@name="IPresentationManager.ForceVSyncInterrupt"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ForceVSyncInterrupt([NativeTypeName("boolean")] byte forceVsyncInterrupt)
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentationManager*, byte, int>)(lpVtbl[8]))((IPresentationManager*)Unsafe.AsPointer(ref this), forceVsyncInterrupt);
    }

    /// <include file='IPresentationManager.xml' path='doc/member[@name="IPresentationManager.Present"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Present()
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentationManager*, int>)(lpVtbl[9]))((IPresentationManager*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPresentationManager.xml' path='doc/member[@name="IPresentationManager.GetPresentRetiringFence"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetPresentRetiringFence([NativeTypeName("const IID &")] Guid* riid, void** fence)
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentationManager*, Guid*, void**, int>)(lpVtbl[10]))((IPresentationManager*)Unsafe.AsPointer(ref this), riid, fence);
    }

    /// <include file='IPresentationManager.xml' path='doc/member[@name="IPresentationManager.CancelPresentsFrom"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CancelPresentsFrom([NativeTypeName("UINT64")] ulong presentIdToCancelFrom)
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentationManager*, ulong, int>)(lpVtbl[11]))((IPresentationManager*)Unsafe.AsPointer(ref this), presentIdToCancelFrom);
    }

    /// <include file='IPresentationManager.xml' path='doc/member[@name="IPresentationManager.GetLostEvent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetLostEvent(HANDLE* lostEventHandle)
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentationManager*, HANDLE*, int>)(lpVtbl[12]))((IPresentationManager*)Unsafe.AsPointer(ref this), lostEventHandle);
    }

    /// <include file='IPresentationManager.xml' path='doc/member[@name="IPresentationManager.GetPresentStatisticsAvailableEvent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetPresentStatisticsAvailableEvent(HANDLE* presentStatisticsAvailableEventHandle)
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentationManager*, HANDLE*, int>)(lpVtbl[13]))((IPresentationManager*)Unsafe.AsPointer(ref this), presentStatisticsAvailableEventHandle);
    }

    /// <include file='IPresentationManager.xml' path='doc/member[@name="IPresentationManager.EnablePresentStatisticsKind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT EnablePresentStatisticsKind(PresentStatisticsKind presentStatisticsKind, [NativeTypeName("boolean")] byte enabled)
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentationManager*, PresentStatisticsKind, byte, int>)(lpVtbl[14]))((IPresentationManager*)Unsafe.AsPointer(ref this), presentStatisticsKind, enabled);
    }

    /// <include file='IPresentationManager.xml' path='doc/member[@name="IPresentationManager.GetNextPresentStatistics"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetNextPresentStatistics(IPresentStatistics** nextPresentStatistics)
    {
        return ((delegate* unmanaged[MemberFunction]<IPresentationManager*, IPresentStatistics**, int>)(lpVtbl[15]))((IPresentationManager*)Unsafe.AsPointer(ref this), nextPresentStatistics);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AddBufferFromResource(IUnknown* resource, IPresentationBuffer** presentationBuffer);

        [VtblIndex(4)]
        HRESULT CreatePresentationSurface(HANDLE compositionSurfaceHandle, IPresentationSurface** presentationSurface);

        [VtblIndex(5)]
        [return: NativeTypeName("UINT64")]
        ulong GetNextPresentId();

        [VtblIndex(6)]
        HRESULT SetTargetTime(SystemInterruptTime targetTime);

        [VtblIndex(7)]
        HRESULT SetPreferredPresentDuration(SystemInterruptTime preferredDuration, SystemInterruptTime deviationTolerance);

        [VtblIndex(8)]
        HRESULT ForceVSyncInterrupt([NativeTypeName("boolean")] byte forceVsyncInterrupt);

        [VtblIndex(9)]
        HRESULT Present();

        [VtblIndex(10)]
        HRESULT GetPresentRetiringFence([NativeTypeName("const IID &")] Guid* riid, void** fence);

        [VtblIndex(11)]
        HRESULT CancelPresentsFrom([NativeTypeName("UINT64")] ulong presentIdToCancelFrom);

        [VtblIndex(12)]
        HRESULT GetLostEvent(HANDLE* lostEventHandle);

        [VtblIndex(13)]
        HRESULT GetPresentStatisticsAvailableEvent(HANDLE* presentStatisticsAvailableEventHandle);

        [VtblIndex(14)]
        HRESULT EnablePresentStatisticsKind(PresentStatisticsKind presentStatisticsKind, [NativeTypeName("boolean")] byte enabled);

        [VtblIndex(15)]
        HRESULT GetNextPresentStatistics(IPresentStatistics** nextPresentStatistics);
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

        [NativeTypeName("HRESULT (IUnknown *, IPresentationBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUnknown*, IPresentationBuffer**, int> AddBufferFromResource;

        [NativeTypeName("HRESULT (HANDLE, IPresentationSurface **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HANDLE, IPresentationSurface**, int> CreatePresentationSurface;

        [NativeTypeName("UINT64 () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong> GetNextPresentId;

        [NativeTypeName("HRESULT (SystemInterruptTime) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SystemInterruptTime, int> SetTargetTime;

        [NativeTypeName("HRESULT (SystemInterruptTime, SystemInterruptTime) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SystemInterruptTime, SystemInterruptTime, int> SetPreferredPresentDuration;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> ForceVSyncInterrupt;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Present;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> GetPresentRetiringFence;

        [NativeTypeName("HRESULT (UINT64) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong, int> CancelPresentsFrom;

        [NativeTypeName("HRESULT (HANDLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HANDLE*, int> GetLostEvent;

        [NativeTypeName("HRESULT (HANDLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HANDLE*, int> GetPresentStatisticsAvailableEvent;

        [NativeTypeName("HRESULT (PresentStatisticsKind, boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PresentStatisticsKind, byte, int> EnablePresentStatisticsKind;

        [NativeTypeName("HRESULT (IPresentStatistics **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPresentStatistics**, int> GetNextPresentStatistics;
    }
}
