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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFPMediaPlayer*, Guid*, void**, int>)(lpVtbl[0]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFPMediaPlayer*, uint>)(lpVtbl[1]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFPMediaPlayer*, uint>)(lpVtbl[2]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Play()
        {
            return ((delegate* unmanaged[Stdcall]<IMFPMediaPlayer*, int>)(lpVtbl[3]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Pause()
        {
            return ((delegate* unmanaged[Stdcall]<IMFPMediaPlayer*, int>)(lpVtbl[4]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Stop()
        {
            return ((delegate* unmanaged[Stdcall]<IMFPMediaPlayer*, int>)(lpVtbl[5]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FrameStep()
        {
            return ((delegate* unmanaged[Stdcall]<IMFPMediaPlayer*, int>)(lpVtbl[6]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPosition([NativeTypeName("const GUID &")] Guid* guidPositionType, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvPositionValue)
        {
            return ((delegate* unmanaged[Stdcall]<IMFPMediaPlayer*, Guid*, PROPVARIANT*, int>)(lpVtbl[7]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), guidPositionType, pvPositionValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPosition([NativeTypeName("const GUID &")] Guid* guidPositionType, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pvPositionValue)
        {
            return ((delegate* unmanaged[Stdcall]<IMFPMediaPlayer*, Guid*, PROPVARIANT*, int>)(lpVtbl[8]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), guidPositionType, pvPositionValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDuration([NativeTypeName("const GUID &")] Guid* guidPositionType, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pvDurationValue)
        {
            return ((delegate* unmanaged[Stdcall]<IMFPMediaPlayer*, Guid*, PROPVARIANT*, int>)(lpVtbl[9]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), guidPositionType, pvDurationValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetRate(float flRate)
        {
            return ((delegate* unmanaged[Stdcall]<IMFPMediaPlayer*, float, int>)(lpVtbl[10]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), flRate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRate([NativeTypeName("float *")] float* pflRate)
        {
            return ((delegate* unmanaged[Stdcall]<IMFPMediaPlayer*, float*, int>)(lpVtbl[11]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), pflRate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSupportedRates([NativeTypeName("BOOL")] int fForwardDirection, [NativeTypeName("float *")] float* pflSlowestRate, [NativeTypeName("float *")] float* pflFastestRate)
        {
            return ((delegate* unmanaged[Stdcall]<IMFPMediaPlayer*, int, float*, float*, int>)(lpVtbl[12]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), fForwardDirection, pflSlowestRate, pflFastestRate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetState([NativeTypeName("MFP_MEDIAPLAYER_STATE *")] MFP_MEDIAPLAYER_STATE* peState)
        {
            return ((delegate* unmanaged[Stdcall]<IMFPMediaPlayer*, MFP_MEDIAPLAYER_STATE*, int>)(lpVtbl[13]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), peState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateMediaItemFromURL([NativeTypeName("LPCWSTR")] ushort* pwszURL, [NativeTypeName("BOOL")] int fSync, [NativeTypeName("DWORD_PTR")] nuint dwUserData, [NativeTypeName("IMFPMediaItem **")] IMFPMediaItem** ppMediaItem)
        {
            return ((delegate* unmanaged[Stdcall]<IMFPMediaPlayer*, ushort*, int, nuint, IMFPMediaItem**, int>)(lpVtbl[14]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), pwszURL, fSync, dwUserData, ppMediaItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateMediaItemFromObject([NativeTypeName("IUnknown *")] IUnknown* pIUnknownObj, [NativeTypeName("BOOL")] int fSync, [NativeTypeName("DWORD_PTR")] nuint dwUserData, [NativeTypeName("IMFPMediaItem **")] IMFPMediaItem** ppMediaItem)
        {
            return ((delegate* unmanaged[Stdcall]<IMFPMediaPlayer*, IUnknown*, int, nuint, IMFPMediaItem**, int>)(lpVtbl[15]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), pIUnknownObj, fSync, dwUserData, ppMediaItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetMediaItem([NativeTypeName("IMFPMediaItem *")] IMFPMediaItem* pIMFPMediaItem)
        {
            return ((delegate* unmanaged[Stdcall]<IMFPMediaPlayer*, IMFPMediaItem*, int>)(lpVtbl[16]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), pIMFPMediaItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ClearMediaItem()
        {
            return ((delegate* unmanaged[Stdcall]<IMFPMediaPlayer*, int>)(lpVtbl[17]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMediaItem([NativeTypeName("IMFPMediaItem **")] IMFPMediaItem** ppIMFPMediaItem)
        {
            return ((delegate* unmanaged[Stdcall]<IMFPMediaPlayer*, IMFPMediaItem**, int>)(lpVtbl[18]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), ppIMFPMediaItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVolume([NativeTypeName("float *")] float* pflVolume)
        {
            return ((delegate* unmanaged[Stdcall]<IMFPMediaPlayer*, float*, int>)(lpVtbl[19]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), pflVolume);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetVolume(float flVolume)
        {
            return ((delegate* unmanaged[Stdcall]<IMFPMediaPlayer*, float, int>)(lpVtbl[20]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), flVolume);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBalance([NativeTypeName("float *")] float* pflBalance)
        {
            return ((delegate* unmanaged[Stdcall]<IMFPMediaPlayer*, float*, int>)(lpVtbl[21]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), pflBalance);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBalance(float flBalance)
        {
            return ((delegate* unmanaged[Stdcall]<IMFPMediaPlayer*, float, int>)(lpVtbl[22]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), flBalance);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMute([NativeTypeName("BOOL *")] int* pfMute)
        {
            return ((delegate* unmanaged[Stdcall]<IMFPMediaPlayer*, int*, int>)(lpVtbl[23]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), pfMute);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetMute([NativeTypeName("BOOL")] int fMute)
        {
            return ((delegate* unmanaged[Stdcall]<IMFPMediaPlayer*, int, int>)(lpVtbl[24]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), fMute);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetNativeVideoSize([NativeTypeName("SIZE *")] SIZE* pszVideo, [NativeTypeName("SIZE *")] SIZE* pszARVideo)
        {
            return ((delegate* unmanaged[Stdcall]<IMFPMediaPlayer*, SIZE*, SIZE*, int>)(lpVtbl[25]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), pszVideo, pszARVideo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIdealVideoSize([NativeTypeName("SIZE *")] SIZE* pszMin, [NativeTypeName("SIZE *")] SIZE* pszMax)
        {
            return ((delegate* unmanaged[Stdcall]<IMFPMediaPlayer*, SIZE*, SIZE*, int>)(lpVtbl[26]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), pszMin, pszMax);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetVideoSourceRect([NativeTypeName("const MFVideoNormalizedRect *")] MFVideoNormalizedRect* pnrcSource)
        {
            return ((delegate* unmanaged[Stdcall]<IMFPMediaPlayer*, MFVideoNormalizedRect*, int>)(lpVtbl[27]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), pnrcSource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVideoSourceRect([NativeTypeName("MFVideoNormalizedRect *")] MFVideoNormalizedRect* pnrcSource)
        {
            return ((delegate* unmanaged[Stdcall]<IMFPMediaPlayer*, MFVideoNormalizedRect*, int>)(lpVtbl[28]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), pnrcSource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAspectRatioMode([NativeTypeName("DWORD")] uint dwAspectRatioMode)
        {
            return ((delegate* unmanaged[Stdcall]<IMFPMediaPlayer*, uint, int>)(lpVtbl[29]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), dwAspectRatioMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAspectRatioMode([NativeTypeName("DWORD *")] uint* pdwAspectRatioMode)
        {
            return ((delegate* unmanaged[Stdcall]<IMFPMediaPlayer*, uint*, int>)(lpVtbl[30]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), pdwAspectRatioMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVideoWindow([NativeTypeName("HWND *")] IntPtr* phwndVideo)
        {
            return ((delegate* unmanaged[Stdcall]<IMFPMediaPlayer*, IntPtr*, int>)(lpVtbl[31]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), phwndVideo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateVideo()
        {
            return ((delegate* unmanaged[Stdcall]<IMFPMediaPlayer*, int>)(lpVtbl[32]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBorderColor([NativeTypeName("COLORREF")] uint Clr)
        {
            return ((delegate* unmanaged[Stdcall]<IMFPMediaPlayer*, uint, int>)(lpVtbl[33]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), Clr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBorderColor([NativeTypeName("COLORREF *")] uint* pClr)
        {
            return ((delegate* unmanaged[Stdcall]<IMFPMediaPlayer*, uint*, int>)(lpVtbl[34]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), pClr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InsertEffect([NativeTypeName("IUnknown *")] IUnknown* pEffect, [NativeTypeName("BOOL")] int fOptional)
        {
            return ((delegate* unmanaged[Stdcall]<IMFPMediaPlayer*, IUnknown*, int, int>)(lpVtbl[35]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), pEffect, fOptional);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveEffect([NativeTypeName("IUnknown *")] IUnknown* pEffect)
        {
            return ((delegate* unmanaged[Stdcall]<IMFPMediaPlayer*, IUnknown*, int>)(lpVtbl[36]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), pEffect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveAllEffects()
        {
            return ((delegate* unmanaged[Stdcall]<IMFPMediaPlayer*, int>)(lpVtbl[37]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Shutdown()
        {
            return ((delegate* unmanaged[Stdcall]<IMFPMediaPlayer*, int>)(lpVtbl[38]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this));
        }
    }
}
