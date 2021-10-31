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
    public unsafe partial struct IMFMediaEngineEx
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
        [return: NativeTypeName("HRESULT")]
        public int GetError(IMFMediaError** ppError)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, IMFMediaError**, int>)(lpVtbl[3]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), ppError);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetErrorCode(MF_MEDIA_ENGINE_ERR error)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, MF_MEDIA_ENGINE_ERR, int>)(lpVtbl[4]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), error);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int SetSourceElements(IMFMediaEngineSrcElements* pSrcElements)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, IMFMediaEngineSrcElements*, int>)(lpVtbl[5]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), pSrcElements);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int SetSource([NativeTypeName("BSTR")] ushort* pUrl)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, ushort*, int>)(lpVtbl[6]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), pUrl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentSource([NativeTypeName("BSTR *")] ushort** ppUrl)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, ushort**, int>)(lpVtbl[7]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), ppUrl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("USHORT")]
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
        [return: NativeTypeName("HRESULT")]
        public int SetPreload(MF_MEDIA_ENGINE_PRELOAD Preload)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, MF_MEDIA_ENGINE_PRELOAD, int>)(lpVtbl[10]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), Preload);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int GetBuffered(IMFMediaTimeRange** ppBuffered)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, IMFMediaTimeRange**, int>)(lpVtbl[11]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), ppBuffered);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int Load()
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, int>)(lpVtbl[12]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int CanPlayType([NativeTypeName("BSTR")] ushort* type, MF_MEDIA_ENGINE_CANPLAY* pAnswer)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, ushort*, MF_MEDIA_ENGINE_CANPLAY*, int>)(lpVtbl[13]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), type, pAnswer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("USHORT")]
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
        [return: NativeTypeName("HRESULT")]
        public int SetCurrentTime(double seekTime)
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
        [return: NativeTypeName("HRESULT")]
        public int SetDefaultPlaybackRate(double Rate)
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
        [return: NativeTypeName("HRESULT")]
        public int SetPlaybackRate(double Rate)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, double, int>)(lpVtbl[24]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), Rate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int GetPlayed(IMFMediaTimeRange** ppPlayed)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, IMFMediaTimeRange**, int>)(lpVtbl[25]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), ppPlayed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int GetSeekable(IMFMediaTimeRange** ppSeekable)
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
        [return: NativeTypeName("HRESULT")]
        public int SetAutoPlay(BOOL AutoPlay)
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
        [return: NativeTypeName("HRESULT")]
        public int SetLoop(BOOL Loop)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, BOOL, int>)(lpVtbl[31]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), Loop);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        public int Play()
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, int>)(lpVtbl[32]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        [return: NativeTypeName("HRESULT")]
        public int Pause()
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
        [return: NativeTypeName("HRESULT")]
        public int SetMuted(BOOL Muted)
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
        [return: NativeTypeName("HRESULT")]
        public int SetVolume(double Volume)
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
        [return: NativeTypeName("HRESULT")]
        public int GetNativeVideoSize([NativeTypeName("DWORD *")] uint* cx, [NativeTypeName("DWORD *")] uint* cy)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, uint*, uint*, int>)(lpVtbl[40]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), cx, cy);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        [return: NativeTypeName("HRESULT")]
        public int GetVideoAspectRatio([NativeTypeName("DWORD *")] uint* cx, [NativeTypeName("DWORD *")] uint* cy)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, uint*, uint*, int>)(lpVtbl[41]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), cx, cy);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        [return: NativeTypeName("HRESULT")]
        public int Shutdown()
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, int>)(lpVtbl[42]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        [return: NativeTypeName("HRESULT")]
        public int TransferVideoFrame(IUnknown* pDstSurf, [NativeTypeName("const MFVideoNormalizedRect *")] MFVideoNormalizedRect* pSrc, [NativeTypeName("const RECT *")] RECT* pDst, [NativeTypeName("const MFARGB *")] MFARGB* pBorderClr)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, IUnknown*, MFVideoNormalizedRect*, RECT*, MFARGB*, int>)(lpVtbl[43]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), pDstSurf, pSrc, pDst, pBorderClr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        [return: NativeTypeName("HRESULT")]
        public int OnVideoStreamTick([NativeTypeName("LONGLONG *")] long* pPts)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, long*, int>)(lpVtbl[44]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), pPts);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        [return: NativeTypeName("HRESULT")]
        public int SetSourceFromByteStream(IMFByteStream* pByteStream, [NativeTypeName("BSTR")] ushort* pURL)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, IMFByteStream*, ushort*, int>)(lpVtbl[45]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), pByteStream, pURL);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        [return: NativeTypeName("HRESULT")]
        public int GetStatistics(MF_MEDIA_ENGINE_STATISTIC StatisticID, PROPVARIANT* pStatistic)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, MF_MEDIA_ENGINE_STATISTIC, PROPVARIANT*, int>)(lpVtbl[46]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), StatisticID, pStatistic);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateVideoStream([NativeTypeName("const MFVideoNormalizedRect *")] MFVideoNormalizedRect* pSrc, [NativeTypeName("const RECT *")] RECT* pDst, [NativeTypeName("const MFARGB *")] MFARGB* pBorderClr)
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
        [return: NativeTypeName("HRESULT")]
        public int SetBalance(double balance)
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
        [return: NativeTypeName("HRESULT")]
        public int FrameStep(BOOL Forward)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, BOOL, int>)(lpVtbl[51]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), Forward);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        [return: NativeTypeName("HRESULT")]
        public int GetResourceCharacteristics([NativeTypeName("DWORD *")] uint* pCharacteristics)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, uint*, int>)(lpVtbl[52]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), pCharacteristics);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        [return: NativeTypeName("HRESULT")]
        public int GetPresentationAttribute([NativeTypeName("const GUID &")] Guid* guidMFAttribute, PROPVARIANT* pvValue)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, Guid*, PROPVARIANT*, int>)(lpVtbl[53]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), guidMFAttribute, pvValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        [return: NativeTypeName("HRESULT")]
        public int GetNumberOfStreams([NativeTypeName("DWORD *")] uint* pdwStreamCount)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, uint*, int>)(lpVtbl[54]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), pdwStreamCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        [return: NativeTypeName("HRESULT")]
        public int GetStreamAttribute([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("const GUID &")] Guid* guidMFAttribute, PROPVARIANT* pvValue)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, uint, Guid*, PROPVARIANT*, int>)(lpVtbl[55]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), dwStreamIndex, guidMFAttribute, pvValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        [return: NativeTypeName("HRESULT")]
        public int GetStreamSelection([NativeTypeName("DWORD")] uint dwStreamIndex, BOOL* pEnabled)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, uint, BOOL*, int>)(lpVtbl[56]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), dwStreamIndex, pEnabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        [return: NativeTypeName("HRESULT")]
        public int SetStreamSelection([NativeTypeName("DWORD")] uint dwStreamIndex, BOOL Enabled)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, uint, BOOL, int>)(lpVtbl[57]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), dwStreamIndex, Enabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        [return: NativeTypeName("HRESULT")]
        public int ApplyStreamSelections()
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, int>)(lpVtbl[58]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        [return: NativeTypeName("HRESULT")]
        public int IsProtected(BOOL* pProtected)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, BOOL*, int>)(lpVtbl[59]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), pProtected);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(60)]
        [return: NativeTypeName("HRESULT")]
        public int InsertVideoEffect(IUnknown* pEffect, BOOL fOptional)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, IUnknown*, BOOL, int>)(lpVtbl[60]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), pEffect, fOptional);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(61)]
        [return: NativeTypeName("HRESULT")]
        public int InsertAudioEffect(IUnknown* pEffect, BOOL fOptional)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, IUnknown*, BOOL, int>)(lpVtbl[61]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), pEffect, fOptional);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(62)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveAllEffects()
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, int>)(lpVtbl[62]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(63)]
        [return: NativeTypeName("HRESULT")]
        public int SetTimelineMarkerTimer(double timeToFire)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, double, int>)(lpVtbl[63]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), timeToFire);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(64)]
        [return: NativeTypeName("HRESULT")]
        public int GetTimelineMarkerTimer(double* pTimeToFire)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, double*, int>)(lpVtbl[64]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), pTimeToFire);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(65)]
        [return: NativeTypeName("HRESULT")]
        public int CancelTimelineMarkerTimer()
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
        [return: NativeTypeName("HRESULT")]
        public int GetStereo3DFramePackingMode(MF_MEDIA_ENGINE_S3D_PACKING_MODE* packMode)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, MF_MEDIA_ENGINE_S3D_PACKING_MODE*, int>)(lpVtbl[67]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), packMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(68)]
        [return: NativeTypeName("HRESULT")]
        public int SetStereo3DFramePackingMode(MF_MEDIA_ENGINE_S3D_PACKING_MODE packMode)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, MF_MEDIA_ENGINE_S3D_PACKING_MODE, int>)(lpVtbl[68]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), packMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(69)]
        [return: NativeTypeName("HRESULT")]
        public int GetStereo3DRenderMode(MF3DVideoOutputType* outputType)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, MF3DVideoOutputType*, int>)(lpVtbl[69]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), outputType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(70)]
        [return: NativeTypeName("HRESULT")]
        public int SetStereo3DRenderMode(MF3DVideoOutputType outputType)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, MF3DVideoOutputType, int>)(lpVtbl[70]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), outputType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(71)]
        [return: NativeTypeName("HRESULT")]
        public int EnableWindowlessSwapchainMode(BOOL fEnable)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, BOOL, int>)(lpVtbl[71]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), fEnable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(72)]
        [return: NativeTypeName("HRESULT")]
        public int GetVideoSwapchainHandle([NativeTypeName("HANDLE *")] IntPtr* phSwapchain)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, IntPtr*, int>)(lpVtbl[72]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), phSwapchain);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(73)]
        [return: NativeTypeName("HRESULT")]
        public int EnableHorizontalMirrorMode(BOOL fEnable)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, BOOL, int>)(lpVtbl[73]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), fEnable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(74)]
        [return: NativeTypeName("HRESULT")]
        public int GetAudioStreamCategory([NativeTypeName("UINT32 *")] uint* pCategory)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, uint*, int>)(lpVtbl[74]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), pCategory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(75)]
        [return: NativeTypeName("HRESULT")]
        public int SetAudioStreamCategory([NativeTypeName("UINT32")] uint category)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, uint, int>)(lpVtbl[75]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), category);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(76)]
        [return: NativeTypeName("HRESULT")]
        public int GetAudioEndpointRole([NativeTypeName("UINT32 *")] uint* pRole)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, uint*, int>)(lpVtbl[76]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), pRole);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(77)]
        [return: NativeTypeName("HRESULT")]
        public int SetAudioEndpointRole([NativeTypeName("UINT32")] uint role)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, uint, int>)(lpVtbl[77]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), role);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(78)]
        [return: NativeTypeName("HRESULT")]
        public int GetRealTimeMode(BOOL* pfEnabled)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, BOOL*, int>)(lpVtbl[78]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), pfEnabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(79)]
        [return: NativeTypeName("HRESULT")]
        public int SetRealTimeMode(BOOL fEnable)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, BOOL, int>)(lpVtbl[79]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), fEnable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(80)]
        [return: NativeTypeName("HRESULT")]
        public int SetCurrentTimeEx(double seekTime, MF_MEDIA_ENGINE_SEEK_MODE seekMode)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, double, MF_MEDIA_ENGINE_SEEK_MODE, int>)(lpVtbl[80]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), seekTime, seekMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(81)]
        [return: NativeTypeName("HRESULT")]
        public int EnableTimeUpdateTimer(BOOL fEnableTimer)
        {
            return ((delegate* unmanaged<IMFMediaEngineEx*, BOOL, int>)(lpVtbl[81]))((IMFMediaEngineEx*)Unsafe.AsPointer(ref this), fEnableTimer);
        }
    }
}
