// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("83015EAD-B1E6-40D0-A98A-37145FFE1AD1")]
    [NativeTypeName("struct IMFMediaEngineEx : IMFMediaEngine")]
    public unsafe partial struct IMFMediaEngineEx
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, uint>)(lpVtbl[1]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, uint>)(lpVtbl[2]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetError([NativeTypeName("IMFMediaError **")] IMFMediaError** ppError)
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, IMFMediaError**, int>)(lpVtbl[3]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), ppError);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetErrorCode(MF_MEDIA_ENGINE_ERR error)
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, MF_MEDIA_ENGINE_ERR, int>)(lpVtbl[4]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), error);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSourceElements([NativeTypeName("IMFMediaEngineSrcElements *")] IMFMediaEngineSrcElements* pSrcElements)
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, IMFMediaEngineSrcElements*, int>)(lpVtbl[5]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), pSrcElements);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSource([NativeTypeName("BSTR")] ushort* pUrl)
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, ushort*, int>)(lpVtbl[6]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), pUrl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentSource([NativeTypeName("BSTR *")] ushort** ppUrl)
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, ushort**, int>)(lpVtbl[7]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), ppUrl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("USHORT")]
        public ushort GetNetworkState()
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, ushort>)(lpVtbl[8]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public MF_MEDIA_ENGINE_PRELOAD GetPreload()
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, MF_MEDIA_ENGINE_PRELOAD>)(lpVtbl[9]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPreload(MF_MEDIA_ENGINE_PRELOAD Preload)
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, MF_MEDIA_ENGINE_PRELOAD, int>)(lpVtbl[10]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), Preload);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBuffered([NativeTypeName("IMFMediaTimeRange **")] IMFMediaTimeRange** ppBuffered)
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, IMFMediaTimeRange**, int>)(lpVtbl[11]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), ppBuffered);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Load()
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, int>)(lpVtbl[12]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CanPlayType([NativeTypeName("BSTR")] ushort* type, [NativeTypeName("MF_MEDIA_ENGINE_CANPLAY *")] MF_MEDIA_ENGINE_CANPLAY* pAnswer)
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, ushort*, MF_MEDIA_ENGINE_CANPLAY*, int>)(lpVtbl[13]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), type, pAnswer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("USHORT")]
        public ushort GetReadyState()
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, ushort>)(lpVtbl[14]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int IsSeeking()
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, int>)(lpVtbl[15]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double GetCurrentTime()
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, double>)(lpVtbl[16]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetCurrentTime(double seekTime)
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, double, int>)(lpVtbl[17]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), seekTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double GetStartTime()
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, double>)(lpVtbl[18]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double GetDuration()
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, double>)(lpVtbl[19]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int IsPaused()
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, int>)(lpVtbl[20]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double GetDefaultPlaybackRate()
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, double>)(lpVtbl[21]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDefaultPlaybackRate(double Rate)
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, double, int>)(lpVtbl[22]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), Rate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double GetPlaybackRate()
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, double>)(lpVtbl[23]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPlaybackRate(double Rate)
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, double, int>)(lpVtbl[24]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), Rate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPlayed([NativeTypeName("IMFMediaTimeRange **")] IMFMediaTimeRange** ppPlayed)
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, IMFMediaTimeRange**, int>)(lpVtbl[25]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), ppPlayed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSeekable([NativeTypeName("IMFMediaTimeRange **")] IMFMediaTimeRange** ppSeekable)
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, IMFMediaTimeRange**, int>)(lpVtbl[26]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), ppSeekable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int IsEnded()
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, int>)(lpVtbl[27]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int GetAutoPlay()
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, int>)(lpVtbl[28]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAutoPlay([NativeTypeName("BOOL")] int AutoPlay)
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, int, int>)(lpVtbl[29]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), AutoPlay);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int GetLoop()
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, int>)(lpVtbl[30]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetLoop([NativeTypeName("BOOL")] int Loop)
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, int, int>)(lpVtbl[31]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), Loop);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Play()
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, int>)(lpVtbl[32]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Pause()
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, int>)(lpVtbl[33]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int GetMuted()
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, int>)(lpVtbl[34]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetMuted([NativeTypeName("BOOL")] int Muted)
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, int, int>)(lpVtbl[35]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), Muted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double GetVolume()
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, double>)(lpVtbl[36]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetVolume(double Volume)
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, double, int>)(lpVtbl[37]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), Volume);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int HasVideo()
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, int>)(lpVtbl[38]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int HasAudio()
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, int>)(lpVtbl[39]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetNativeVideoSize([NativeTypeName("DWORD *")] uint* cx, [NativeTypeName("DWORD *")] uint* cy)
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, uint*, uint*, int>)(lpVtbl[40]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), cx, cy);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVideoAspectRatio([NativeTypeName("DWORD *")] uint* cx, [NativeTypeName("DWORD *")] uint* cy)
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, uint*, uint*, int>)(lpVtbl[41]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), cx, cy);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Shutdown()
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, int>)(lpVtbl[42]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int TransferVideoFrame([NativeTypeName("IUnknown *")] IUnknown* pDstSurf, [NativeTypeName("const MFVideoNormalizedRect *")] MFVideoNormalizedRect* pSrc, [NativeTypeName("const RECT *")] RECT* pDst, [NativeTypeName("const MFARGB *")] MFARGB* pBorderClr)
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, IUnknown*, MFVideoNormalizedRect*, RECT*, MFARGB*, int>)(lpVtbl[43]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), pDstSurf, pSrc, pDst, pBorderClr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnVideoStreamTick([NativeTypeName("LONGLONG *")] long* pPts)
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, long*, int>)(lpVtbl[44]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), pPts);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSourceFromByteStream([NativeTypeName("IMFByteStream *")] IMFByteStream* pByteStream, [NativeTypeName("BSTR")] ushort* pURL)
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, IMFByteStream*, ushort*, int>)(lpVtbl[45]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), pByteStream, pURL);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStatistics(MF_MEDIA_ENGINE_STATISTIC StatisticID, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pStatistic)
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, MF_MEDIA_ENGINE_STATISTIC, PROPVARIANT*, int>)(lpVtbl[46]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), StatisticID, pStatistic);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateVideoStream([NativeTypeName("const MFVideoNormalizedRect *")] MFVideoNormalizedRect* pSrc, [NativeTypeName("const RECT *")] RECT* pDst, [NativeTypeName("const MFARGB *")] MFARGB* pBorderClr)
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, MFVideoNormalizedRect*, RECT*, MFARGB*, int>)(lpVtbl[47]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), pSrc, pDst, pBorderClr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double GetBalance()
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, double>)(lpVtbl[48]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBalance(double balance)
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, double, int>)(lpVtbl[49]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), balance);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int IsPlaybackRateSupported(double rate)
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, double, int>)(lpVtbl[50]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), rate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FrameStep([NativeTypeName("BOOL")] int Forward)
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, int, int>)(lpVtbl[51]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), Forward);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetResourceCharacteristics([NativeTypeName("DWORD *")] uint* pCharacteristics)
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, uint*, int>)(lpVtbl[52]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), pCharacteristics);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPresentationAttribute([NativeTypeName("const GUID &")] Guid* guidMFAttribute, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pvValue)
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, Guid*, PROPVARIANT*, int>)(lpVtbl[53]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), guidMFAttribute, pvValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetNumberOfStreams([NativeTypeName("DWORD *")] uint* pdwStreamCount)
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, uint*, int>)(lpVtbl[54]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), pdwStreamCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStreamAttribute([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("const GUID &")] Guid* guidMFAttribute, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pvValue)
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, uint, Guid*, PROPVARIANT*, int>)(lpVtbl[55]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), dwStreamIndex, guidMFAttribute, pvValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStreamSelection([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("BOOL *")] int* pEnabled)
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, uint, int*, int>)(lpVtbl[56]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), dwStreamIndex, pEnabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetStreamSelection([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("BOOL")] int Enabled)
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, uint, int, int>)(lpVtbl[57]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), dwStreamIndex, Enabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ApplyStreamSelections()
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, int>)(lpVtbl[58]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsProtected([NativeTypeName("BOOL *")] int* pProtected)
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, int*, int>)(lpVtbl[59]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), pProtected);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InsertVideoEffect([NativeTypeName("IUnknown *")] IUnknown* pEffect, [NativeTypeName("BOOL")] int fOptional)
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, IUnknown*, int, int>)(lpVtbl[60]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), pEffect, fOptional);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InsertAudioEffect([NativeTypeName("IUnknown *")] IUnknown* pEffect, [NativeTypeName("BOOL")] int fOptional)
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, IUnknown*, int, int>)(lpVtbl[61]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), pEffect, fOptional);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveAllEffects()
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, int>)(lpVtbl[62]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTimelineMarkerTimer(double timeToFire)
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, double, int>)(lpVtbl[63]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), timeToFire);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTimelineMarkerTimer([NativeTypeName("double *")] double* pTimeToFire)
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, double*, int>)(lpVtbl[64]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), pTimeToFire);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CancelTimelineMarkerTimer()
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, int>)(lpVtbl[65]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int IsStereo3D()
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, int>)(lpVtbl[66]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStereo3DFramePackingMode([NativeTypeName("MF_MEDIA_ENGINE_S3D_PACKING_MODE *")] MF_MEDIA_ENGINE_S3D_PACKING_MODE* packMode)
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, MF_MEDIA_ENGINE_S3D_PACKING_MODE*, int>)(lpVtbl[67]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), packMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetStereo3DFramePackingMode(MF_MEDIA_ENGINE_S3D_PACKING_MODE packMode)
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, MF_MEDIA_ENGINE_S3D_PACKING_MODE, int>)(lpVtbl[68]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), packMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStereo3DRenderMode([NativeTypeName("MF3DVideoOutputType *")] MF3DVideoOutputType* outputType)
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, MF3DVideoOutputType*, int>)(lpVtbl[69]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), outputType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetStereo3DRenderMode(MF3DVideoOutputType outputType)
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, MF3DVideoOutputType, int>)(lpVtbl[70]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), outputType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnableWindowlessSwapchainMode([NativeTypeName("BOOL")] int fEnable)
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, int, int>)(lpVtbl[71]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), fEnable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVideoSwapchainHandle([NativeTypeName("HANDLE *")] IntPtr* phSwapchain)
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, IntPtr*, int>)(lpVtbl[72]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), phSwapchain);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnableHorizontalMirrorMode([NativeTypeName("BOOL")] int fEnable)
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, int, int>)(lpVtbl[73]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), fEnable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAudioStreamCategory([NativeTypeName("UINT32 *")] uint* pCategory)
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, uint*, int>)(lpVtbl[74]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), pCategory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAudioStreamCategory([NativeTypeName("UINT32")] uint category)
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, uint, int>)(lpVtbl[75]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), category);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAudioEndpointRole([NativeTypeName("UINT32 *")] uint* pRole)
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, uint*, int>)(lpVtbl[76]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), pRole);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAudioEndpointRole([NativeTypeName("UINT32")] uint role)
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, uint, int>)(lpVtbl[77]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), role);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRealTimeMode([NativeTypeName("BOOL *")] int* pfEnabled)
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, int*, int>)(lpVtbl[78]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), pfEnabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetRealTimeMode([NativeTypeName("BOOL")] int fEnable)
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, int, int>)(lpVtbl[79]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), fEnable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetCurrentTimeEx(double seekTime, MF_MEDIA_ENGINE_SEEK_MODE seekMode)
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, double, MF_MEDIA_ENGINE_SEEK_MODE, int>)(lpVtbl[80]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), seekTime, seekMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnableTimeUpdateTimer([NativeTypeName("BOOL")] int fEnableTimer)
        {
            return ((delegate* stdcall<IMFMediaEngineEx*, int, int>)(lpVtbl[81]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), fEnableTimer);
        }
    }
}
