// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1F2A94C9-A3DF-430D-9D0F-ACD85DDC29AF")]
    [NativeTypeName("struct IMFTimedText : IUnknown")]
    public unsafe partial struct IMFTimedText
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedText*, Guid*, void**, int>)(lpVtbl[0]))((IMFTimedText*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedText*, uint>)(lpVtbl[1]))((IMFTimedText*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedText*, uint>)(lpVtbl[2]))((IMFTimedText*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterNotifications([NativeTypeName("IMFTimedTextNotify *")] IMFTimedTextNotify* notify)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFTimedTextNotify*, int>)(lpVtbl[3]))((IMFTimedText*)Unsafe.AsPointer(ref this), notify);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SelectTrack([NativeTypeName("DWORD")] uint trackId, [NativeTypeName("BOOL")] int selected)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedText*, uint, int, int>)(lpVtbl[4]))((IMFTimedText*)Unsafe.AsPointer(ref this), trackId, selected);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddDataSource([NativeTypeName("IMFByteStream *")] IMFByteStream* byteStream, [NativeTypeName("LPCWSTR")] ushort* label, [NativeTypeName("LPCWSTR")] ushort* language, MF_TIMED_TEXT_TRACK_KIND kind, [NativeTypeName("BOOL")] int isDefault, [NativeTypeName("DWORD *")] uint* trackId)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFByteStream*, ushort*, ushort*, MF_TIMED_TEXT_TRACK_KIND, int, uint*, int>)(lpVtbl[5]))((IMFTimedText*)Unsafe.AsPointer(ref this), byteStream, label, language, kind, isDefault, trackId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddDataSourceFromUrl([NativeTypeName("LPCWSTR")] ushort* url, [NativeTypeName("LPCWSTR")] ushort* label, [NativeTypeName("LPCWSTR")] ushort* language, MF_TIMED_TEXT_TRACK_KIND kind, [NativeTypeName("BOOL")] int isDefault, [NativeTypeName("DWORD *")] uint* trackId)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedText*, ushort*, ushort*, ushort*, MF_TIMED_TEXT_TRACK_KIND, int, uint*, int>)(lpVtbl[6]))((IMFTimedText*)Unsafe.AsPointer(ref this), url, label, language, kind, isDefault, trackId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddTrack([NativeTypeName("LPCWSTR")] ushort* label, [NativeTypeName("LPCWSTR")] ushort* language, MF_TIMED_TEXT_TRACK_KIND kind, [NativeTypeName("IMFTimedTextTrack **")] IMFTimedTextTrack** track)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedText*, ushort*, ushort*, MF_TIMED_TEXT_TRACK_KIND, IMFTimedTextTrack**, int>)(lpVtbl[7]))((IMFTimedText*)Unsafe.AsPointer(ref this), label, language, kind, track);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveTrack([NativeTypeName("IMFTimedTextTrack *")] IMFTimedTextTrack* track)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFTimedTextTrack*, int>)(lpVtbl[8]))((IMFTimedText*)Unsafe.AsPointer(ref this), track);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCueTimeOffset([NativeTypeName("double *")] double* offset)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedText*, double*, int>)(lpVtbl[9]))((IMFTimedText*)Unsafe.AsPointer(ref this), offset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetCueTimeOffset(double offset)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedText*, double, int>)(lpVtbl[10]))((IMFTimedText*)Unsafe.AsPointer(ref this), offset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTracks([NativeTypeName("IMFTimedTextTrackList **")] IMFTimedTextTrackList** tracks)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFTimedTextTrackList**, int>)(lpVtbl[11]))((IMFTimedText*)Unsafe.AsPointer(ref this), tracks);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetActiveTracks([NativeTypeName("IMFTimedTextTrackList **")] IMFTimedTextTrackList** activeTracks)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFTimedTextTrackList**, int>)(lpVtbl[12]))((IMFTimedText*)Unsafe.AsPointer(ref this), activeTracks);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTextTracks([NativeTypeName("IMFTimedTextTrackList **")] IMFTimedTextTrackList** textTracks)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFTimedTextTrackList**, int>)(lpVtbl[13]))((IMFTimedText*)Unsafe.AsPointer(ref this), textTracks);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMetadataTracks([NativeTypeName("IMFTimedTextTrackList **")] IMFTimedTextTrackList** metadataTracks)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedText*, IMFTimedTextTrackList**, int>)(lpVtbl[14]))((IMFTimedText*)Unsafe.AsPointer(ref this), metadataTracks);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetInBandEnabled([NativeTypeName("BOOL")] int enabled)
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedText*, int, int>)(lpVtbl[15]))((IMFTimedText*)Unsafe.AsPointer(ref this), enabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int IsInBandEnabled()
        {
            return ((delegate* unmanaged[Stdcall]<IMFTimedText*, int>)(lpVtbl[16]))((IMFTimedText*)Unsafe.AsPointer(ref this));
        }
    }
}
