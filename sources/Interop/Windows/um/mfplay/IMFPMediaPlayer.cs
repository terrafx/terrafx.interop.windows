// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfplay.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A714590A-58AF-430A-85BF-44F5EC838D85")]
    [NativeTypeName("struct IMFPMediaPlayer : IUnknown")]
    public unsafe partial struct IMFPMediaPlayer
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFPMediaPlayer*, Guid*, void**, int>)(lpVtbl[0]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFPMediaPlayer*, uint>)(lpVtbl[1]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFPMediaPlayer*, uint>)(lpVtbl[2]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Play()
        {
            return ((delegate* stdcall<IMFPMediaPlayer*, int>)(lpVtbl[3]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Pause()
        {
            return ((delegate* stdcall<IMFPMediaPlayer*, int>)(lpVtbl[4]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Stop()
        {
            return ((delegate* stdcall<IMFPMediaPlayer*, int>)(lpVtbl[5]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int FrameStep()
        {
            return ((delegate* stdcall<IMFPMediaPlayer*, int>)(lpVtbl[6]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPosition([NativeTypeName("const GUID &")] Guid* guidPositionType, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvPositionValue)
        {
            return ((delegate* stdcall<IMFPMediaPlayer*, Guid*, PROPVARIANT*, int>)(lpVtbl[7]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), guidPositionType, pvPositionValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPosition([NativeTypeName("const GUID &")] Guid* guidPositionType, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pvPositionValue)
        {
            return ((delegate* stdcall<IMFPMediaPlayer*, Guid*, PROPVARIANT*, int>)(lpVtbl[8]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), guidPositionType, pvPositionValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDuration([NativeTypeName("const GUID &")] Guid* guidPositionType, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pvDurationValue)
        {
            return ((delegate* stdcall<IMFPMediaPlayer*, Guid*, PROPVARIANT*, int>)(lpVtbl[9]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), guidPositionType, pvDurationValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRate(float flRate)
        {
            return ((delegate* stdcall<IMFPMediaPlayer*, float, int>)(lpVtbl[10]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), flRate);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRate([NativeTypeName("float *")] float* pflRate)
        {
            return ((delegate* stdcall<IMFPMediaPlayer*, float*, int>)(lpVtbl[11]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), pflRate);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSupportedRates([NativeTypeName("BOOL")] int fForwardDirection, [NativeTypeName("float *")] float* pflSlowestRate, [NativeTypeName("float *")] float* pflFastestRate)
        {
            return ((delegate* stdcall<IMFPMediaPlayer*, int, float*, float*, int>)(lpVtbl[12]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), fForwardDirection, pflSlowestRate, pflFastestRate);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetState([NativeTypeName("MFP_MEDIAPLAYER_STATE *")] MFP_MEDIAPLAYER_STATE* peState)
        {
            return ((delegate* stdcall<IMFPMediaPlayer*, MFP_MEDIAPLAYER_STATE*, int>)(lpVtbl[13]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), peState);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateMediaItemFromURL([NativeTypeName("LPCWSTR")] ushort* pwszURL, [NativeTypeName("BOOL")] int fSync, [NativeTypeName("DWORD_PTR")] nuint dwUserData, [NativeTypeName("IMFPMediaItem **")] IMFPMediaItem** ppMediaItem)
        {
            return ((delegate* stdcall<IMFPMediaPlayer*, ushort*, int, nuint, IMFPMediaItem**, int>)(lpVtbl[14]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), pwszURL, fSync, dwUserData, ppMediaItem);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateMediaItemFromObject([NativeTypeName("IUnknown *")] IUnknown* pIUnknownObj, [NativeTypeName("BOOL")] int fSync, [NativeTypeName("DWORD_PTR")] nuint dwUserData, [NativeTypeName("IMFPMediaItem **")] IMFPMediaItem** ppMediaItem)
        {
            return ((delegate* stdcall<IMFPMediaPlayer*, IUnknown*, int, nuint, IMFPMediaItem**, int>)(lpVtbl[15]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), pIUnknownObj, fSync, dwUserData, ppMediaItem);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMediaItem([NativeTypeName("IMFPMediaItem *")] IMFPMediaItem* pIMFPMediaItem)
        {
            return ((delegate* stdcall<IMFPMediaPlayer*, IMFPMediaItem*, int>)(lpVtbl[16]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), pIMFPMediaItem);
        }

        [return: NativeTypeName("HRESULT")]
        public int ClearMediaItem()
        {
            return ((delegate* stdcall<IMFPMediaPlayer*, int>)(lpVtbl[17]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMediaItem([NativeTypeName("IMFPMediaItem **")] IMFPMediaItem** ppIMFPMediaItem)
        {
            return ((delegate* stdcall<IMFPMediaPlayer*, IMFPMediaItem**, int>)(lpVtbl[18]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), ppIMFPMediaItem);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVolume([NativeTypeName("float *")] float* pflVolume)
        {
            return ((delegate* stdcall<IMFPMediaPlayer*, float*, int>)(lpVtbl[19]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), pflVolume);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVolume(float flVolume)
        {
            return ((delegate* stdcall<IMFPMediaPlayer*, float, int>)(lpVtbl[20]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), flVolume);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBalance([NativeTypeName("float *")] float* pflBalance)
        {
            return ((delegate* stdcall<IMFPMediaPlayer*, float*, int>)(lpVtbl[21]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), pflBalance);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBalance(float flBalance)
        {
            return ((delegate* stdcall<IMFPMediaPlayer*, float, int>)(lpVtbl[22]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), flBalance);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMute([NativeTypeName("BOOL *")] int* pfMute)
        {
            return ((delegate* stdcall<IMFPMediaPlayer*, int*, int>)(lpVtbl[23]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), pfMute);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMute([NativeTypeName("BOOL")] int fMute)
        {
            return ((delegate* stdcall<IMFPMediaPlayer*, int, int>)(lpVtbl[24]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), fMute);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetNativeVideoSize([NativeTypeName("SIZE *")] SIZE* pszVideo, [NativeTypeName("SIZE *")] SIZE* pszARVideo)
        {
            return ((delegate* stdcall<IMFPMediaPlayer*, SIZE*, SIZE*, int>)(lpVtbl[25]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), pszVideo, pszARVideo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIdealVideoSize([NativeTypeName("SIZE *")] SIZE* pszMin, [NativeTypeName("SIZE *")] SIZE* pszMax)
        {
            return ((delegate* stdcall<IMFPMediaPlayer*, SIZE*, SIZE*, int>)(lpVtbl[26]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), pszMin, pszMax);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVideoSourceRect([NativeTypeName("const MFVideoNormalizedRect *")] MFVideoNormalizedRect* pnrcSource)
        {
            return ((delegate* stdcall<IMFPMediaPlayer*, MFVideoNormalizedRect*, int>)(lpVtbl[27]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), pnrcSource);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVideoSourceRect([NativeTypeName("MFVideoNormalizedRect *")] MFVideoNormalizedRect* pnrcSource)
        {
            return ((delegate* stdcall<IMFPMediaPlayer*, MFVideoNormalizedRect*, int>)(lpVtbl[28]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), pnrcSource);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAspectRatioMode([NativeTypeName("DWORD")] uint dwAspectRatioMode)
        {
            return ((delegate* stdcall<IMFPMediaPlayer*, uint, int>)(lpVtbl[29]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), dwAspectRatioMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAspectRatioMode([NativeTypeName("DWORD *")] uint* pdwAspectRatioMode)
        {
            return ((delegate* stdcall<IMFPMediaPlayer*, uint*, int>)(lpVtbl[30]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), pdwAspectRatioMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVideoWindow([NativeTypeName("HWND *")] IntPtr* phwndVideo)
        {
            return ((delegate* stdcall<IMFPMediaPlayer*, IntPtr*, int>)(lpVtbl[31]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), phwndVideo);
        }

        [return: NativeTypeName("HRESULT")]
        public int UpdateVideo()
        {
            return ((delegate* stdcall<IMFPMediaPlayer*, int>)(lpVtbl[32]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBorderColor([NativeTypeName("COLORREF")] uint Clr)
        {
            return ((delegate* stdcall<IMFPMediaPlayer*, uint, int>)(lpVtbl[33]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), Clr);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBorderColor([NativeTypeName("COLORREF *")] uint* pClr)
        {
            return ((delegate* stdcall<IMFPMediaPlayer*, uint*, int>)(lpVtbl[34]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), pClr);
        }

        [return: NativeTypeName("HRESULT")]
        public int InsertEffect([NativeTypeName("IUnknown *")] IUnknown* pEffect, [NativeTypeName("BOOL")] int fOptional)
        {
            return ((delegate* stdcall<IMFPMediaPlayer*, IUnknown*, int, int>)(lpVtbl[35]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), pEffect, fOptional);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveEffect([NativeTypeName("IUnknown *")] IUnknown* pEffect)
        {
            return ((delegate* stdcall<IMFPMediaPlayer*, IUnknown*, int>)(lpVtbl[36]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), pEffect);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveAllEffects()
        {
            return ((delegate* stdcall<IMFPMediaPlayer*, int>)(lpVtbl[37]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Shutdown()
        {
            return ((delegate* stdcall<IMFPMediaPlayer*, int>)(lpVtbl[38]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this));
        }
    }
}
