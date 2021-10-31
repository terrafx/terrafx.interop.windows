// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("98A1B0BB-03EB-4935-AE7C-93C1FA0E1C93")]
    [NativeTypeName("struct IMFMediaEngine : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFMediaEngine
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFMediaEngine*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFMediaEngine*, uint>)(lpVtbl[1]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFMediaEngine*, uint>)(lpVtbl[2]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetError(IMFMediaError** ppError)
        {
            return ((delegate* unmanaged<IMFMediaEngine*, IMFMediaError**, int>)(lpVtbl[3]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), ppError);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetErrorCode(MF_MEDIA_ENGINE_ERR error)
        {
            return ((delegate* unmanaged<IMFMediaEngine*, MF_MEDIA_ENGINE_ERR, int>)(lpVtbl[4]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), error);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int SetSourceElements(IMFMediaEngineSrcElements* pSrcElements)
        {
            return ((delegate* unmanaged<IMFMediaEngine*, IMFMediaEngineSrcElements*, int>)(lpVtbl[5]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), pSrcElements);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int SetSource([NativeTypeName("BSTR")] ushort* pUrl)
        {
            return ((delegate* unmanaged<IMFMediaEngine*, ushort*, int>)(lpVtbl[6]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), pUrl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentSource([NativeTypeName("BSTR *")] ushort** ppUrl)
        {
            return ((delegate* unmanaged<IMFMediaEngine*, ushort**, int>)(lpVtbl[7]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), ppUrl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("USHORT")]
        public ushort GetNetworkState()
        {
            return ((delegate* unmanaged<IMFMediaEngine*, ushort>)(lpVtbl[8]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public MF_MEDIA_ENGINE_PRELOAD GetPreload()
        {
            return ((delegate* unmanaged<IMFMediaEngine*, MF_MEDIA_ENGINE_PRELOAD>)(lpVtbl[9]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int SetPreload(MF_MEDIA_ENGINE_PRELOAD Preload)
        {
            return ((delegate* unmanaged<IMFMediaEngine*, MF_MEDIA_ENGINE_PRELOAD, int>)(lpVtbl[10]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), Preload);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int GetBuffered(IMFMediaTimeRange** ppBuffered)
        {
            return ((delegate* unmanaged<IMFMediaEngine*, IMFMediaTimeRange**, int>)(lpVtbl[11]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), ppBuffered);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int Load()
        {
            return ((delegate* unmanaged<IMFMediaEngine*, int>)(lpVtbl[12]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int CanPlayType([NativeTypeName("BSTR")] ushort* type, MF_MEDIA_ENGINE_CANPLAY* pAnswer)
        {
            return ((delegate* unmanaged<IMFMediaEngine*, ushort*, MF_MEDIA_ENGINE_CANPLAY*, int>)(lpVtbl[13]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), type, pAnswer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("USHORT")]
        public ushort GetReadyState()
        {
            return ((delegate* unmanaged<IMFMediaEngine*, ushort>)(lpVtbl[14]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public BOOL IsSeeking()
        {
            return ((delegate* unmanaged<IMFMediaEngine*, int>)(lpVtbl[15]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public double GetCurrentTime()
        {
            return ((delegate* unmanaged<IMFMediaEngine*, double>)(lpVtbl[16]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int SetCurrentTime(double seekTime)
        {
            return ((delegate* unmanaged<IMFMediaEngine*, double, int>)(lpVtbl[17]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), seekTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public double GetStartTime()
        {
            return ((delegate* unmanaged<IMFMediaEngine*, double>)(lpVtbl[18]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public double GetDuration()
        {
            return ((delegate* unmanaged<IMFMediaEngine*, double>)(lpVtbl[19]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public BOOL IsPaused()
        {
            return ((delegate* unmanaged<IMFMediaEngine*, int>)(lpVtbl[20]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public double GetDefaultPlaybackRate()
        {
            return ((delegate* unmanaged<IMFMediaEngine*, double>)(lpVtbl[21]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int SetDefaultPlaybackRate(double Rate)
        {
            return ((delegate* unmanaged<IMFMediaEngine*, double, int>)(lpVtbl[22]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), Rate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public double GetPlaybackRate()
        {
            return ((delegate* unmanaged<IMFMediaEngine*, double>)(lpVtbl[23]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int SetPlaybackRate(double Rate)
        {
            return ((delegate* unmanaged<IMFMediaEngine*, double, int>)(lpVtbl[24]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), Rate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int GetPlayed(IMFMediaTimeRange** ppPlayed)
        {
            return ((delegate* unmanaged<IMFMediaEngine*, IMFMediaTimeRange**, int>)(lpVtbl[25]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), ppPlayed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int GetSeekable(IMFMediaTimeRange** ppSeekable)
        {
            return ((delegate* unmanaged<IMFMediaEngine*, IMFMediaTimeRange**, int>)(lpVtbl[26]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), ppSeekable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public BOOL IsEnded()
        {
            return ((delegate* unmanaged<IMFMediaEngine*, int>)(lpVtbl[27]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public BOOL GetAutoPlay()
        {
            return ((delegate* unmanaged<IMFMediaEngine*, int>)(lpVtbl[28]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int SetAutoPlay(BOOL AutoPlay)
        {
            return ((delegate* unmanaged<IMFMediaEngine*, BOOL, int>)(lpVtbl[29]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), AutoPlay);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public BOOL GetLoop()
        {
            return ((delegate* unmanaged<IMFMediaEngine*, int>)(lpVtbl[30]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int SetLoop(BOOL Loop)
        {
            return ((delegate* unmanaged<IMFMediaEngine*, BOOL, int>)(lpVtbl[31]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), Loop);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        public int Play()
        {
            return ((delegate* unmanaged<IMFMediaEngine*, int>)(lpVtbl[32]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        [return: NativeTypeName("HRESULT")]
        public int Pause()
        {
            return ((delegate* unmanaged<IMFMediaEngine*, int>)(lpVtbl[33]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public BOOL GetMuted()
        {
            return ((delegate* unmanaged<IMFMediaEngine*, int>)(lpVtbl[34]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        [return: NativeTypeName("HRESULT")]
        public int SetMuted(BOOL Muted)
        {
            return ((delegate* unmanaged<IMFMediaEngine*, BOOL, int>)(lpVtbl[35]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), Muted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public double GetVolume()
        {
            return ((delegate* unmanaged<IMFMediaEngine*, double>)(lpVtbl[36]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        [return: NativeTypeName("HRESULT")]
        public int SetVolume(double Volume)
        {
            return ((delegate* unmanaged<IMFMediaEngine*, double, int>)(lpVtbl[37]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), Volume);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public BOOL HasVideo()
        {
            return ((delegate* unmanaged<IMFMediaEngine*, int>)(lpVtbl[38]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public BOOL HasAudio()
        {
            return ((delegate* unmanaged<IMFMediaEngine*, int>)(lpVtbl[39]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        [return: NativeTypeName("HRESULT")]
        public int GetNativeVideoSize([NativeTypeName("DWORD *")] uint* cx, [NativeTypeName("DWORD *")] uint* cy)
        {
            return ((delegate* unmanaged<IMFMediaEngine*, uint*, uint*, int>)(lpVtbl[40]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), cx, cy);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        [return: NativeTypeName("HRESULT")]
        public int GetVideoAspectRatio([NativeTypeName("DWORD *")] uint* cx, [NativeTypeName("DWORD *")] uint* cy)
        {
            return ((delegate* unmanaged<IMFMediaEngine*, uint*, uint*, int>)(lpVtbl[41]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), cx, cy);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        [return: NativeTypeName("HRESULT")]
        public int Shutdown()
        {
            return ((delegate* unmanaged<IMFMediaEngine*, int>)(lpVtbl[42]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        [return: NativeTypeName("HRESULT")]
        public int TransferVideoFrame(IUnknown* pDstSurf, [NativeTypeName("const MFVideoNormalizedRect *")] MFVideoNormalizedRect* pSrc, [NativeTypeName("const RECT *")] RECT* pDst, [NativeTypeName("const MFARGB *")] MFARGB* pBorderClr)
        {
            return ((delegate* unmanaged<IMFMediaEngine*, IUnknown*, MFVideoNormalizedRect*, RECT*, MFARGB*, int>)(lpVtbl[43]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), pDstSurf, pSrc, pDst, pBorderClr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        [return: NativeTypeName("HRESULT")]
        public int OnVideoStreamTick([NativeTypeName("LONGLONG *")] long* pPts)
        {
            return ((delegate* unmanaged<IMFMediaEngine*, long*, int>)(lpVtbl[44]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), pPts);
        }
    }
}
