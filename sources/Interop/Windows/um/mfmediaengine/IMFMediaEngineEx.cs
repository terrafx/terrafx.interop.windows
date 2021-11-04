// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("83015EAD-B1E6-40D0-A98A-37145FFE1AD1")]
    [NativeTypeName("struct IMFMediaEngineEx : IMFMediaEngine")]
    [NativeInheritance("IMFMediaEngine")]
    public unsafe partial struct IMFMediaEngineEx : IMFMediaEngineEx.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, uint>)(lpVtbl[1]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, uint>)(lpVtbl[2]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetError(IMFMediaError** ppError)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, IMFMediaError**, int>)(lpVtbl[3]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), ppError);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetErrorCode(MF_MEDIA_ENGINE_ERR error)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, MF_MEDIA_ENGINE_ERR, int>)(lpVtbl[4]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), error);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetSourceElements(IMFMediaEngineSrcElements* pSrcElements)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, IMFMediaEngineSrcElements*, int>)(lpVtbl[5]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), pSrcElements);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetSource([NativeTypeName("BSTR")] ushort* pUrl)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, ushort*, int>)(lpVtbl[6]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), pUrl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetCurrentSource([NativeTypeName("BSTR *")] ushort** ppUrl)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, ushort**, int>)(lpVtbl[7]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), ppUrl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public ushort GetNetworkState()
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, ushort>)(lpVtbl[8]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public MF_MEDIA_ENGINE_PRELOAD GetPreload()
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, MF_MEDIA_ENGINE_PRELOAD>)(lpVtbl[9]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT SetPreload(MF_MEDIA_ENGINE_PRELOAD Preload)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, MF_MEDIA_ENGINE_PRELOAD, int>)(lpVtbl[10]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), Preload);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetBuffered(IMFMediaTimeRange** ppBuffered)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, IMFMediaTimeRange**, int>)(lpVtbl[11]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), ppBuffered);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT Load()
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, int>)(lpVtbl[12]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT CanPlayType([NativeTypeName("BSTR")] ushort* type, MF_MEDIA_ENGINE_CANPLAY* pAnswer)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, ushort*, MF_MEDIA_ENGINE_CANPLAY*, int>)(lpVtbl[13]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), type, pAnswer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public ushort GetReadyState()
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, ushort>)(lpVtbl[14]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public BOOL IsSeeking()
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, int>)(lpVtbl[15]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public double GetCurrentTime()
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, double>)(lpVtbl[16]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT SetCurrentTime(double seekTime)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, double, int>)(lpVtbl[17]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), seekTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public double GetStartTime()
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, double>)(lpVtbl[18]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public double GetDuration()
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, double>)(lpVtbl[19]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public BOOL IsPaused()
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, int>)(lpVtbl[20]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public double GetDefaultPlaybackRate()
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, double>)(lpVtbl[21]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT SetDefaultPlaybackRate(double Rate)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, double, int>)(lpVtbl[22]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), Rate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public double GetPlaybackRate()
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, double>)(lpVtbl[23]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT SetPlaybackRate(double Rate)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, double, int>)(lpVtbl[24]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), Rate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT GetPlayed(IMFMediaTimeRange** ppPlayed)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, IMFMediaTimeRange**, int>)(lpVtbl[25]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), ppPlayed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT GetSeekable(IMFMediaTimeRange** ppSeekable)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, IMFMediaTimeRange**, int>)(lpVtbl[26]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), ppSeekable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public BOOL IsEnded()
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, int>)(lpVtbl[27]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public BOOL GetAutoPlay()
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, int>)(lpVtbl[28]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT SetAutoPlay(BOOL AutoPlay)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, BOOL, int>)(lpVtbl[29]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), AutoPlay);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public BOOL GetLoop()
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, int>)(lpVtbl[30]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT SetLoop(BOOL Loop)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, BOOL, int>)(lpVtbl[31]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), Loop);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT Play()
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, int>)(lpVtbl[32]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT Pause()
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, int>)(lpVtbl[33]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public BOOL GetMuted()
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, int>)(lpVtbl[34]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT SetMuted(BOOL Muted)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, BOOL, int>)(lpVtbl[35]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), Muted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public double GetVolume()
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, double>)(lpVtbl[36]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public HRESULT SetVolume(double Volume)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, double, int>)(lpVtbl[37]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), Volume);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public BOOL HasVideo()
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, int>)(lpVtbl[38]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public BOOL HasAudio()
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, int>)(lpVtbl[39]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        public HRESULT GetNativeVideoSize([NativeTypeName("DWORD *")] uint* cx, [NativeTypeName("DWORD *")] uint* cy)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, uint*, uint*, int>)(lpVtbl[40]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), cx, cy);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        public HRESULT GetVideoAspectRatio([NativeTypeName("DWORD *")] uint* cx, [NativeTypeName("DWORD *")] uint* cy)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, uint*, uint*, int>)(lpVtbl[41]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), cx, cy);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        public HRESULT Shutdown()
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, int>)(lpVtbl[42]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        public HRESULT TransferVideoFrame(IUnknown* pDstSurf, [NativeTypeName("const MFVideoNormalizedRect *")] MFVideoNormalizedRect* pSrc, [NativeTypeName("const RECT *")] RECT* pDst, [NativeTypeName("const MFARGB *")] MFARGB* pBorderClr)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, IUnknown*, MFVideoNormalizedRect*, RECT*, MFARGB*, int>)(lpVtbl[43]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), pDstSurf, pSrc, pDst, pBorderClr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        public HRESULT OnVideoStreamTick([NativeTypeName("LONGLONG *")] long* pPts)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, long*, int>)(lpVtbl[44]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), pPts);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        public HRESULT SetSourceFromByteStream(IMFByteStream* pByteStream, [NativeTypeName("BSTR")] ushort* pURL)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, IMFByteStream*, ushort*, int>)(lpVtbl[45]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), pByteStream, pURL);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        public HRESULT GetStatistics(MF_MEDIA_ENGINE_STATISTIC StatisticID, PROPVARIANT* pStatistic)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, MF_MEDIA_ENGINE_STATISTIC, PROPVARIANT*, int>)(lpVtbl[46]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), StatisticID, pStatistic);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        public HRESULT UpdateVideoStream([NativeTypeName("const MFVideoNormalizedRect *")] MFVideoNormalizedRect* pSrc, [NativeTypeName("const RECT *")] RECT* pDst, [NativeTypeName("const MFARGB *")] MFARGB* pBorderClr)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, MFVideoNormalizedRect*, RECT*, MFARGB*, int>)(lpVtbl[47]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), pSrc, pDst, pBorderClr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        public double GetBalance()
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, double>)(lpVtbl[48]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        public HRESULT SetBalance(double balance)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, double, int>)(lpVtbl[49]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), balance);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        public BOOL IsPlaybackRateSupported(double rate)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, double, int>)(lpVtbl[50]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), rate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        public HRESULT FrameStep(BOOL Forward)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, BOOL, int>)(lpVtbl[51]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), Forward);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        public HRESULT GetResourceCharacteristics([NativeTypeName("DWORD *")] uint* pCharacteristics)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, uint*, int>)(lpVtbl[52]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), pCharacteristics);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        public HRESULT GetPresentationAttribute([NativeTypeName("const GUID &")] Guid* guidMFAttribute, PROPVARIANT* pvValue)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, Guid*, PROPVARIANT*, int>)(lpVtbl[53]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), guidMFAttribute, pvValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        public HRESULT GetNumberOfStreams([NativeTypeName("DWORD *")] uint* pdwStreamCount)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, uint*, int>)(lpVtbl[54]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), pdwStreamCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        public HRESULT GetStreamAttribute([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("const GUID &")] Guid* guidMFAttribute, PROPVARIANT* pvValue)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, uint, Guid*, PROPVARIANT*, int>)(lpVtbl[55]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), dwStreamIndex, guidMFAttribute, pvValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        public HRESULT GetStreamSelection([NativeTypeName("DWORD")] uint dwStreamIndex, BOOL* pEnabled)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, uint, BOOL*, int>)(lpVtbl[56]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), dwStreamIndex, pEnabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        public HRESULT SetStreamSelection([NativeTypeName("DWORD")] uint dwStreamIndex, BOOL Enabled)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, uint, BOOL, int>)(lpVtbl[57]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), dwStreamIndex, Enabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        public HRESULT ApplyStreamSelections()
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, int>)(lpVtbl[58]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        public HRESULT IsProtected(BOOL* pProtected)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, BOOL*, int>)(lpVtbl[59]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), pProtected);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(60)]
        public HRESULT InsertVideoEffect(IUnknown* pEffect, BOOL fOptional)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, IUnknown*, BOOL, int>)(lpVtbl[60]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), pEffect, fOptional);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(61)]
        public HRESULT InsertAudioEffect(IUnknown* pEffect, BOOL fOptional)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, IUnknown*, BOOL, int>)(lpVtbl[61]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), pEffect, fOptional);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(62)]
        public HRESULT RemoveAllEffects()
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, int>)(lpVtbl[62]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(63)]
        public HRESULT SetTimelineMarkerTimer(double timeToFire)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, double, int>)(lpVtbl[63]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), timeToFire);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(64)]
        public HRESULT GetTimelineMarkerTimer(double* pTimeToFire)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, double*, int>)(lpVtbl[64]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), pTimeToFire);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(65)]
        public HRESULT CancelTimelineMarkerTimer()
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, int>)(lpVtbl[65]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(66)]
        public BOOL IsStereo3D()
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, int>)(lpVtbl[66]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(67)]
        public HRESULT GetStereo3DFramePackingMode(MF_MEDIA_ENGINE_S3D_PACKING_MODE* packMode)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, MF_MEDIA_ENGINE_S3D_PACKING_MODE*, int>)(lpVtbl[67]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), packMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(68)]
        public HRESULT SetStereo3DFramePackingMode(MF_MEDIA_ENGINE_S3D_PACKING_MODE packMode)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, MF_MEDIA_ENGINE_S3D_PACKING_MODE, int>)(lpVtbl[68]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), packMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(69)]
        public HRESULT GetStereo3DRenderMode(MF3DVideoOutputType* outputType)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, MF3DVideoOutputType*, int>)(lpVtbl[69]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), outputType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(70)]
        public HRESULT SetStereo3DRenderMode(MF3DVideoOutputType outputType)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, MF3DVideoOutputType, int>)(lpVtbl[70]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), outputType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(71)]
        public HRESULT EnableWindowlessSwapchainMode(BOOL fEnable)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, BOOL, int>)(lpVtbl[71]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), fEnable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(72)]
        public HRESULT GetVideoSwapchainHandle(HANDLE* phSwapchain)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, HANDLE*, int>)(lpVtbl[72]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), phSwapchain);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(73)]
        public HRESULT EnableHorizontalMirrorMode(BOOL fEnable)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, BOOL, int>)(lpVtbl[73]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), fEnable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(74)]
        public HRESULT GetAudioStreamCategory([NativeTypeName("UINT32 *")] uint* pCategory)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, uint*, int>)(lpVtbl[74]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), pCategory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(75)]
        public HRESULT SetAudioStreamCategory([NativeTypeName("UINT32")] uint category)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, uint, int>)(lpVtbl[75]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), category);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(76)]
        public HRESULT GetAudioEndpointRole([NativeTypeName("UINT32 *")] uint* pRole)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, uint*, int>)(lpVtbl[76]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), pRole);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(77)]
        public HRESULT SetAudioEndpointRole([NativeTypeName("UINT32")] uint role)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, uint, int>)(lpVtbl[77]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), role);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(78)]
        public HRESULT GetRealTimeMode(BOOL* pfEnabled)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, BOOL*, int>)(lpVtbl[78]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), pfEnabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(79)]
        public HRESULT SetRealTimeMode(BOOL fEnable)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, BOOL, int>)(lpVtbl[79]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), fEnable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(80)]
        public HRESULT SetCurrentTimeEx(double seekTime, MF_MEDIA_ENGINE_SEEK_MODE seekMode)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, double, MF_MEDIA_ENGINE_SEEK_MODE, int>)(lpVtbl[80]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), seekTime, seekMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(81)]
        public HRESULT EnableTimeUpdateTimer(BOOL fEnableTimer)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, BOOL, int>)(lpVtbl[81]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), fEnableTimer);
        }

        public interface Interface : IMFMediaEngine.Interface
        {
            [VtblIndex(45)]
            HRESULT SetSourceFromByteStream(IMFByteStream* pByteStream, [NativeTypeName("BSTR")] ushort* pURL);

            [VtblIndex(46)]
            HRESULT GetStatistics(MF_MEDIA_ENGINE_STATISTIC StatisticID, PROPVARIANT* pStatistic);

            [VtblIndex(47)]
            HRESULT UpdateVideoStream([NativeTypeName("const MFVideoNormalizedRect *")] MFVideoNormalizedRect* pSrc, [NativeTypeName("const RECT *")] RECT* pDst, [NativeTypeName("const MFARGB *")] MFARGB* pBorderClr);

            [VtblIndex(48)]
            double GetBalance();

            [VtblIndex(49)]
            HRESULT SetBalance(double balance);

            [VtblIndex(50)]
            BOOL IsPlaybackRateSupported(double rate);

            [VtblIndex(51)]
            HRESULT FrameStep(BOOL Forward);

            [VtblIndex(52)]
            HRESULT GetResourceCharacteristics([NativeTypeName("DWORD *")] uint* pCharacteristics);

            [VtblIndex(53)]
            HRESULT GetPresentationAttribute([NativeTypeName("const GUID &")] Guid* guidMFAttribute, PROPVARIANT* pvValue);

            [VtblIndex(54)]
            HRESULT GetNumberOfStreams([NativeTypeName("DWORD *")] uint* pdwStreamCount);

            [VtblIndex(55)]
            HRESULT GetStreamAttribute([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("const GUID &")] Guid* guidMFAttribute, PROPVARIANT* pvValue);

            [VtblIndex(56)]
            HRESULT GetStreamSelection([NativeTypeName("DWORD")] uint dwStreamIndex, BOOL* pEnabled);

            [VtblIndex(57)]
            HRESULT SetStreamSelection([NativeTypeName("DWORD")] uint dwStreamIndex, BOOL Enabled);

            [VtblIndex(58)]
            HRESULT ApplyStreamSelections();

            [VtblIndex(59)]
            HRESULT IsProtected(BOOL* pProtected);

            [VtblIndex(60)]
            HRESULT InsertVideoEffect(IUnknown* pEffect, BOOL fOptional);

            [VtblIndex(61)]
            HRESULT InsertAudioEffect(IUnknown* pEffect, BOOL fOptional);

            [VtblIndex(62)]
            HRESULT RemoveAllEffects();

            [VtblIndex(63)]
            HRESULT SetTimelineMarkerTimer(double timeToFire);

            [VtblIndex(64)]
            HRESULT GetTimelineMarkerTimer(double* pTimeToFire);

            [VtblIndex(65)]
            HRESULT CancelTimelineMarkerTimer();

            [VtblIndex(66)]
            BOOL IsStereo3D();

            [VtblIndex(67)]
            HRESULT GetStereo3DFramePackingMode(MF_MEDIA_ENGINE_S3D_PACKING_MODE* packMode);

            [VtblIndex(68)]
            HRESULT SetStereo3DFramePackingMode(MF_MEDIA_ENGINE_S3D_PACKING_MODE packMode);

            [VtblIndex(69)]
            HRESULT GetStereo3DRenderMode(MF3DVideoOutputType* outputType);

            [VtblIndex(70)]
            HRESULT SetStereo3DRenderMode(MF3DVideoOutputType outputType);

            [VtblIndex(71)]
            HRESULT EnableWindowlessSwapchainMode(BOOL fEnable);

            [VtblIndex(72)]
            HRESULT GetVideoSwapchainHandle(HANDLE* phSwapchain);

            [VtblIndex(73)]
            HRESULT EnableHorizontalMirrorMode(BOOL fEnable);

            [VtblIndex(74)]
            HRESULT GetAudioStreamCategory([NativeTypeName("UINT32 *")] uint* pCategory);

            [VtblIndex(75)]
            HRESULT SetAudioStreamCategory([NativeTypeName("UINT32")] uint category);

            [VtblIndex(76)]
            HRESULT GetAudioEndpointRole([NativeTypeName("UINT32 *")] uint* pRole);

            [VtblIndex(77)]
            HRESULT SetAudioEndpointRole([NativeTypeName("UINT32")] uint role);

            [VtblIndex(78)]
            HRESULT GetRealTimeMode(BOOL* pfEnabled);

            [VtblIndex(79)]
            HRESULT SetRealTimeMode(BOOL fEnable);

            [VtblIndex(80)]
            HRESULT SetCurrentTimeEx(double seekTime, MF_MEDIA_ENGINE_SEEK_MODE seekMode);

            [VtblIndex(81)]
            HRESULT EnableTimeUpdateTimer(BOOL fEnableTimer);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, uint> Release;

            [NativeTypeName("HRESULT (IMFMediaError **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, IMFMediaError**, int> GetError;

            [NativeTypeName("HRESULT (MF_MEDIA_ENGINE_ERR) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, MF_MEDIA_ENGINE_ERR, int> SetErrorCode;

            [NativeTypeName("HRESULT (IMFMediaEngineSrcElements *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, IMFMediaEngineSrcElements*, int> SetSourceElements;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, ushort*, int> SetSource;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, ushort**, int> GetCurrentSource;

            [NativeTypeName("USHORT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, ushort> GetNetworkState;

            [NativeTypeName("MF_MEDIA_ENGINE_PRELOAD () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, MF_MEDIA_ENGINE_PRELOAD> GetPreload;

            [NativeTypeName("HRESULT (MF_MEDIA_ENGINE_PRELOAD) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, MF_MEDIA_ENGINE_PRELOAD, int> SetPreload;

            [NativeTypeName("HRESULT (IMFMediaTimeRange **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, IMFMediaTimeRange**, int> GetBuffered;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, int> Load;

            [NativeTypeName("HRESULT (BSTR, MF_MEDIA_ENGINE_CANPLAY *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, ushort*, MF_MEDIA_ENGINE_CANPLAY*, int> CanPlayType;

            [NativeTypeName("USHORT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, ushort> GetReadyState;

            [NativeTypeName("BOOL () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, int> IsSeeking;

            [NativeTypeName("double () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, double> GetCurrentTime;

            [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, double, int> SetCurrentTime;

            [NativeTypeName("double () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, double> GetStartTime;

            [NativeTypeName("double () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, double> GetDuration;

            [NativeTypeName("BOOL () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, int> IsPaused;

            [NativeTypeName("double () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, double> GetDefaultPlaybackRate;

            [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, double, int> SetDefaultPlaybackRate;

            [NativeTypeName("double () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, double> GetPlaybackRate;

            [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, double, int> SetPlaybackRate;

            [NativeTypeName("HRESULT (IMFMediaTimeRange **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, IMFMediaTimeRange**, int> GetPlayed;

            [NativeTypeName("HRESULT (IMFMediaTimeRange **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, IMFMediaTimeRange**, int> GetSeekable;

            [NativeTypeName("BOOL () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, int> IsEnded;

            [NativeTypeName("BOOL () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, int> GetAutoPlay;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, BOOL, int> SetAutoPlay;

            [NativeTypeName("BOOL () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, int> GetLoop;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, BOOL, int> SetLoop;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, int> Play;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, int> Pause;

            [NativeTypeName("BOOL () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, int> GetMuted;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, BOOL, int> SetMuted;

            [NativeTypeName("double () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, double> GetVolume;

            [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, double, int> SetVolume;

            [NativeTypeName("BOOL () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, int> HasVideo;

            [NativeTypeName("BOOL () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, int> HasAudio;

            [NativeTypeName("HRESULT (DWORD *, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, uint*, uint*, int> GetNativeVideoSize;

            [NativeTypeName("HRESULT (DWORD *, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, uint*, uint*, int> GetVideoAspectRatio;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, int> Shutdown;

            [NativeTypeName("HRESULT (IUnknown *, const MFVideoNormalizedRect *, const RECT *, const MFARGB *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, IUnknown*, MFVideoNormalizedRect*, RECT*, MFARGB*, int> TransferVideoFrame;

            [NativeTypeName("HRESULT (LONGLONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, long*, int> OnVideoStreamTick;

            [NativeTypeName("HRESULT (IMFByteStream *, BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, IMFByteStream*, ushort*, int> SetSourceFromByteStream;

            [NativeTypeName("HRESULT (MF_MEDIA_ENGINE_STATISTIC, PROPVARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, MF_MEDIA_ENGINE_STATISTIC, PROPVARIANT*, int> GetStatistics;

            [NativeTypeName("HRESULT (const MFVideoNormalizedRect *, const RECT *, const MFARGB *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, MFVideoNormalizedRect*, RECT*, MFARGB*, int> UpdateVideoStream;

            [NativeTypeName("double () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, double> GetBalance;

            [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, double, int> SetBalance;

            [NativeTypeName("BOOL (double) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, double, int> IsPlaybackRateSupported;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, BOOL, int> FrameStep;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, uint*, int> GetResourceCharacteristics;

            [NativeTypeName("HRESULT (const GUID &, PROPVARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, Guid*, PROPVARIANT*, int> GetPresentationAttribute;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, uint*, int> GetNumberOfStreams;

            [NativeTypeName("HRESULT (DWORD, const GUID &, PROPVARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, uint, Guid*, PROPVARIANT*, int> GetStreamAttribute;

            [NativeTypeName("HRESULT (DWORD, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, uint, BOOL*, int> GetStreamSelection;

            [NativeTypeName("HRESULT (DWORD, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, uint, BOOL, int> SetStreamSelection;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, int> ApplyStreamSelections;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, BOOL*, int> IsProtected;

            [NativeTypeName("HRESULT (IUnknown *, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, IUnknown*, BOOL, int> InsertVideoEffect;

            [NativeTypeName("HRESULT (IUnknown *, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, IUnknown*, BOOL, int> InsertAudioEffect;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, int> RemoveAllEffects;

            [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, double, int> SetTimelineMarkerTimer;

            [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, double*, int> GetTimelineMarkerTimer;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, int> CancelTimelineMarkerTimer;

            [NativeTypeName("BOOL () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, int> IsStereo3D;

            [NativeTypeName("HRESULT (MF_MEDIA_ENGINE_S3D_PACKING_MODE *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, MF_MEDIA_ENGINE_S3D_PACKING_MODE*, int> GetStereo3DFramePackingMode;

            [NativeTypeName("HRESULT (MF_MEDIA_ENGINE_S3D_PACKING_MODE) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, MF_MEDIA_ENGINE_S3D_PACKING_MODE, int> SetStereo3DFramePackingMode;

            [NativeTypeName("HRESULT (MF3DVideoOutputType *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, MF3DVideoOutputType*, int> GetStereo3DRenderMode;

            [NativeTypeName("HRESULT (MF3DVideoOutputType) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, MF3DVideoOutputType, int> SetStereo3DRenderMode;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, BOOL, int> EnableWindowlessSwapchainMode;

            [NativeTypeName("HRESULT (HANDLE *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, HANDLE*, int> GetVideoSwapchainHandle;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, BOOL, int> EnableHorizontalMirrorMode;

            [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, uint*, int> GetAudioStreamCategory;

            [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, uint, int> SetAudioStreamCategory;

            [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, uint*, int> GetAudioEndpointRole;

            [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, uint, int> SetAudioEndpointRole;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, BOOL*, int> GetRealTimeMode;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, BOOL, int> SetRealTimeMode;

            [NativeTypeName("HRESULT (double, MF_MEDIA_ENGINE_SEEK_MODE) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, double, MF_MEDIA_ENGINE_SEEK_MODE, int> SetCurrentTimeEx;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineEx*, BOOL, int> EnableTimeUpdateTimer;
        }
    }
}
