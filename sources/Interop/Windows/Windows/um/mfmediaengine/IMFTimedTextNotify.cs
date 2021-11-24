// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

[SupportedOSPlatform("windows10.0")]
[Guid("DF6B87B6-CE12-45DB-ABA7-432FE054E57D")]
[NativeTypeName("struct IMFTimedTextNotify : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFTimedTextNotify : IMFTimedTextNotify.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFTimedTextNotify*, Guid*, void**, int>)(lpVtbl[0]))((IMFTimedTextNotify*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFTimedTextNotify*, uint>)(lpVtbl[1]))((IMFTimedTextNotify*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFTimedTextNotify*, uint>)(lpVtbl[2]))((IMFTimedTextNotify*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void TrackAdded([NativeTypeName("DWORD")] uint trackId)
    {
        ((delegate* unmanaged<IMFTimedTextNotify*, uint, void>)(lpVtbl[3]))((IMFTimedTextNotify*)Unsafe.AsPointer(ref this), trackId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void TrackRemoved([NativeTypeName("DWORD")] uint trackId)
    {
        ((delegate* unmanaged<IMFTimedTextNotify*, uint, void>)(lpVtbl[4]))((IMFTimedTextNotify*)Unsafe.AsPointer(ref this), trackId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void TrackSelected([NativeTypeName("DWORD")] uint trackId, BOOL selected)
    {
        ((delegate* unmanaged<IMFTimedTextNotify*, uint, BOOL, void>)(lpVtbl[5]))((IMFTimedTextNotify*)Unsafe.AsPointer(ref this), trackId, selected);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public void TrackReadyStateChanged([NativeTypeName("DWORD")] uint trackId)
    {
        ((delegate* unmanaged<IMFTimedTextNotify*, uint, void>)(lpVtbl[6]))((IMFTimedTextNotify*)Unsafe.AsPointer(ref this), trackId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void Error(MF_TIMED_TEXT_ERROR_CODE errorCode, HRESULT extendedErrorCode, [NativeTypeName("DWORD")] uint sourceTrackId)
    {
        ((delegate* unmanaged<IMFTimedTextNotify*, MF_TIMED_TEXT_ERROR_CODE, HRESULT, uint, void>)(lpVtbl[7]))((IMFTimedTextNotify*)Unsafe.AsPointer(ref this), errorCode, extendedErrorCode, sourceTrackId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void Cue(MF_TIMED_TEXT_CUE_EVENT cueEvent, double currentTime, IMFTimedTextCue* cue)
    {
        ((delegate* unmanaged<IMFTimedTextNotify*, MF_TIMED_TEXT_CUE_EVENT, double, IMFTimedTextCue*, void>)(lpVtbl[8]))((IMFTimedTextNotify*)Unsafe.AsPointer(ref this), cueEvent, currentTime, cue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public void Reset()
    {
        ((delegate* unmanaged<IMFTimedTextNotify*, void>)(lpVtbl[9]))((IMFTimedTextNotify*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        void TrackAdded([NativeTypeName("DWORD")] uint trackId);

        [VtblIndex(4)]
        void TrackRemoved([NativeTypeName("DWORD")] uint trackId);

        [VtblIndex(5)]
        void TrackSelected([NativeTypeName("DWORD")] uint trackId, BOOL selected);

        [VtblIndex(6)]
        void TrackReadyStateChanged([NativeTypeName("DWORD")] uint trackId);

        [VtblIndex(7)]
        void Error(MF_TIMED_TEXT_ERROR_CODE errorCode, HRESULT extendedErrorCode, [NativeTypeName("DWORD")] uint sourceTrackId);

        [VtblIndex(8)]
        void Cue(MF_TIMED_TEXT_CUE_EVENT cueEvent, double currentTime, IMFTimedTextCue* cue);

        [VtblIndex(9)]
        void Reset();
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFTimedTextNotify*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IMFTimedTextNotify*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IMFTimedTextNotify*, uint> Release;

        [NativeTypeName("void (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFTimedTextNotify*, uint, void> TrackAdded;

        [NativeTypeName("void (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFTimedTextNotify*, uint, void> TrackRemoved;

        [NativeTypeName("void (DWORD, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFTimedTextNotify*, uint, BOOL, void> TrackSelected;

        [NativeTypeName("void (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFTimedTextNotify*, uint, void> TrackReadyStateChanged;

        [NativeTypeName("void (MF_TIMED_TEXT_ERROR_CODE, HRESULT, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFTimedTextNotify*, MF_TIMED_TEXT_ERROR_CODE, HRESULT, uint, void> Error;

        [NativeTypeName("void (MF_TIMED_TEXT_CUE_EVENT, double, IMFTimedTextCue *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFTimedTextNotify*, MF_TIMED_TEXT_CUE_EVENT, double, IMFTimedTextCue*, void> Cue;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<IMFTimedTextNotify*, void> Reset;
    }
}
