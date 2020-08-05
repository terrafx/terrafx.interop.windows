// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("98A1B0BB-03EB-4935-AE7C-93C1FA0E1C93")]
    [NativeTypeName("struct IMFMediaEngine : IUnknown")]
    public unsafe partial struct IMFMediaEngine
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFMediaEngine*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFMediaEngine*, uint>)(lpVtbl[1]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFMediaEngine*, uint>)(lpVtbl[2]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetError([NativeTypeName("IMFMediaError **")] IMFMediaError** ppError)
        {
            return ((delegate* stdcall<IMFMediaEngine*, IMFMediaError**, int>)(lpVtbl[3]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), ppError);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetErrorCode(MF_MEDIA_ENGINE_ERR error)
        {
            return ((delegate* stdcall<IMFMediaEngine*, MF_MEDIA_ENGINE_ERR, int>)(lpVtbl[4]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), error);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSourceElements([NativeTypeName("IMFMediaEngineSrcElements *")] IMFMediaEngineSrcElements* pSrcElements)
        {
            return ((delegate* stdcall<IMFMediaEngine*, IMFMediaEngineSrcElements*, int>)(lpVtbl[5]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), pSrcElements);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSource([NativeTypeName("BSTR")] ushort* pUrl)
        {
            return ((delegate* stdcall<IMFMediaEngine*, ushort*, int>)(lpVtbl[6]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), pUrl);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentSource([NativeTypeName("BSTR *")] ushort** ppUrl)
        {
            return ((delegate* stdcall<IMFMediaEngine*, ushort**, int>)(lpVtbl[7]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), ppUrl);
        }

        [return: NativeTypeName("USHORT")]
        public ushort GetNetworkState()
        {
            return ((delegate* stdcall<IMFMediaEngine*, ushort>)(lpVtbl[8]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
        }

        public MF_MEDIA_ENGINE_PRELOAD GetPreload()
        {
            return ((delegate* stdcall<IMFMediaEngine*, MF_MEDIA_ENGINE_PRELOAD>)(lpVtbl[9]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPreload(MF_MEDIA_ENGINE_PRELOAD Preload)
        {
            return ((delegate* stdcall<IMFMediaEngine*, MF_MEDIA_ENGINE_PRELOAD, int>)(lpVtbl[10]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), Preload);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBuffered([NativeTypeName("IMFMediaTimeRange **")] IMFMediaTimeRange** ppBuffered)
        {
            return ((delegate* stdcall<IMFMediaEngine*, IMFMediaTimeRange**, int>)(lpVtbl[11]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), ppBuffered);
        }

        [return: NativeTypeName("HRESULT")]
        public int Load()
        {
            return ((delegate* stdcall<IMFMediaEngine*, int>)(lpVtbl[12]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CanPlayType([NativeTypeName("BSTR")] ushort* type, [NativeTypeName("MF_MEDIA_ENGINE_CANPLAY *")] MF_MEDIA_ENGINE_CANPLAY* pAnswer)
        {
            return ((delegate* stdcall<IMFMediaEngine*, ushort*, MF_MEDIA_ENGINE_CANPLAY*, int>)(lpVtbl[13]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), type, pAnswer);
        }

        [return: NativeTypeName("USHORT")]
        public ushort GetReadyState()
        {
            return ((delegate* stdcall<IMFMediaEngine*, ushort>)(lpVtbl[14]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("BOOL")]
        public int IsSeeking()
        {
            return ((delegate* stdcall<IMFMediaEngine*, int>)(lpVtbl[15]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
        }

        public double GetCurrentTime()
        {
            return ((delegate* stdcall<IMFMediaEngine*, double>)(lpVtbl[16]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCurrentTime(double seekTime)
        {
            return ((delegate* stdcall<IMFMediaEngine*, double, int>)(lpVtbl[17]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), seekTime);
        }

        public double GetStartTime()
        {
            return ((delegate* stdcall<IMFMediaEngine*, double>)(lpVtbl[18]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
        }

        public double GetDuration()
        {
            return ((delegate* stdcall<IMFMediaEngine*, double>)(lpVtbl[19]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("BOOL")]
        public int IsPaused()
        {
            return ((delegate* stdcall<IMFMediaEngine*, int>)(lpVtbl[20]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
        }

        public double GetDefaultPlaybackRate()
        {
            return ((delegate* stdcall<IMFMediaEngine*, double>)(lpVtbl[21]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDefaultPlaybackRate(double Rate)
        {
            return ((delegate* stdcall<IMFMediaEngine*, double, int>)(lpVtbl[22]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), Rate);
        }

        public double GetPlaybackRate()
        {
            return ((delegate* stdcall<IMFMediaEngine*, double>)(lpVtbl[23]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPlaybackRate(double Rate)
        {
            return ((delegate* stdcall<IMFMediaEngine*, double, int>)(lpVtbl[24]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), Rate);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPlayed([NativeTypeName("IMFMediaTimeRange **")] IMFMediaTimeRange** ppPlayed)
        {
            return ((delegate* stdcall<IMFMediaEngine*, IMFMediaTimeRange**, int>)(lpVtbl[25]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), ppPlayed);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSeekable([NativeTypeName("IMFMediaTimeRange **")] IMFMediaTimeRange** ppSeekable)
        {
            return ((delegate* stdcall<IMFMediaEngine*, IMFMediaTimeRange**, int>)(lpVtbl[26]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), ppSeekable);
        }

        [return: NativeTypeName("BOOL")]
        public int IsEnded()
        {
            return ((delegate* stdcall<IMFMediaEngine*, int>)(lpVtbl[27]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("BOOL")]
        public int GetAutoPlay()
        {
            return ((delegate* stdcall<IMFMediaEngine*, int>)(lpVtbl[28]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAutoPlay([NativeTypeName("BOOL")] int AutoPlay)
        {
            return ((delegate* stdcall<IMFMediaEngine*, int, int>)(lpVtbl[29]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), AutoPlay);
        }

        [return: NativeTypeName("BOOL")]
        public int GetLoop()
        {
            return ((delegate* stdcall<IMFMediaEngine*, int>)(lpVtbl[30]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetLoop([NativeTypeName("BOOL")] int Loop)
        {
            return ((delegate* stdcall<IMFMediaEngine*, int, int>)(lpVtbl[31]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), Loop);
        }

        [return: NativeTypeName("HRESULT")]
        public int Play()
        {
            return ((delegate* stdcall<IMFMediaEngine*, int>)(lpVtbl[32]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Pause()
        {
            return ((delegate* stdcall<IMFMediaEngine*, int>)(lpVtbl[33]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("BOOL")]
        public int GetMuted()
        {
            return ((delegate* stdcall<IMFMediaEngine*, int>)(lpVtbl[34]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMuted([NativeTypeName("BOOL")] int Muted)
        {
            return ((delegate* stdcall<IMFMediaEngine*, int, int>)(lpVtbl[35]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), Muted);
        }

        public double GetVolume()
        {
            return ((delegate* stdcall<IMFMediaEngine*, double>)(lpVtbl[36]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVolume(double Volume)
        {
            return ((delegate* stdcall<IMFMediaEngine*, double, int>)(lpVtbl[37]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), Volume);
        }

        [return: NativeTypeName("BOOL")]
        public int HasVideo()
        {
            return ((delegate* stdcall<IMFMediaEngine*, int>)(lpVtbl[38]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("BOOL")]
        public int HasAudio()
        {
            return ((delegate* stdcall<IMFMediaEngine*, int>)(lpVtbl[39]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetNativeVideoSize([NativeTypeName("DWORD *")] uint* cx, [NativeTypeName("DWORD *")] uint* cy)
        {
            return ((delegate* stdcall<IMFMediaEngine*, uint*, uint*, int>)(lpVtbl[40]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), cx, cy);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVideoAspectRatio([NativeTypeName("DWORD *")] uint* cx, [NativeTypeName("DWORD *")] uint* cy)
        {
            return ((delegate* stdcall<IMFMediaEngine*, uint*, uint*, int>)(lpVtbl[41]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), cx, cy);
        }

        [return: NativeTypeName("HRESULT")]
        public int Shutdown()
        {
            return ((delegate* stdcall<IMFMediaEngine*, int>)(lpVtbl[42]))((IMFMediaEngine*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int TransferVideoFrame([NativeTypeName("IUnknown *")] IUnknown* pDstSurf, [NativeTypeName("const MFVideoNormalizedRect *")] MFVideoNormalizedRect* pSrc, [NativeTypeName("const RECT *")] RECT* pDst, [NativeTypeName("const MFARGB *")] MFARGB* pBorderClr)
        {
            return ((delegate* stdcall<IMFMediaEngine*, IUnknown*, MFVideoNormalizedRect*, RECT*, MFARGB*, int>)(lpVtbl[43]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), pDstSurf, pSrc, pDst, pBorderClr);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnVideoStreamTick([NativeTypeName("LONGLONG *")] long* pPts)
        {
            return ((delegate* stdcall<IMFMediaEngine*, long*, int>)(lpVtbl[44]))((IMFMediaEngine*)Unsafe.AsPointer(ref this), pPts);
        }
    }
}
