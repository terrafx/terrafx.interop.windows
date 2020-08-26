// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A70EFE60-E2A3-11D0-A9BE-00AA0061BE93")]
    [NativeTypeName("struct IDvdInfo : IUnknown")]
    public unsafe partial struct IDvdInfo
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDvdInfo*, Guid*, void**, int>)(lpVtbl[0]))((IDvdInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDvdInfo*, uint>)(lpVtbl[1]))((IDvdInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDvdInfo*, uint>)(lpVtbl[2]))((IDvdInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentDomain([NativeTypeName("DVD_DOMAIN *")] DVD_DOMAIN* pDomain)
        {
            return ((delegate* stdcall<IDvdInfo*, DVD_DOMAIN*, int>)(lpVtbl[3]))((IDvdInfo*)Unsafe.AsPointer(ref this), pDomain);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentLocation([NativeTypeName("DVD_PLAYBACK_LOCATION *")] DVD_PLAYBACK_LOCATION* pLocation)
        {
            return ((delegate* stdcall<IDvdInfo*, DVD_PLAYBACK_LOCATION*, int>)(lpVtbl[4]))((IDvdInfo*)Unsafe.AsPointer(ref this), pLocation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTotalTitleTime([NativeTypeName("ULONG *")] uint* pulTotalTime)
        {
            return ((delegate* stdcall<IDvdInfo*, uint*, int>)(lpVtbl[5]))((IDvdInfo*)Unsafe.AsPointer(ref this), pulTotalTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentButton([NativeTypeName("ULONG *")] uint* pulButtonsAvailable, [NativeTypeName("ULONG *")] uint* pulCurrentButton)
        {
            return ((delegate* stdcall<IDvdInfo*, uint*, uint*, int>)(lpVtbl[6]))((IDvdInfo*)Unsafe.AsPointer(ref this), pulButtonsAvailable, pulCurrentButton);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentAngle([NativeTypeName("ULONG *")] uint* pulAnglesAvailable, [NativeTypeName("ULONG *")] uint* pulCurrentAngle)
        {
            return ((delegate* stdcall<IDvdInfo*, uint*, uint*, int>)(lpVtbl[7]))((IDvdInfo*)Unsafe.AsPointer(ref this), pulAnglesAvailable, pulCurrentAngle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentAudio([NativeTypeName("ULONG *")] uint* pulStreamsAvailable, [NativeTypeName("ULONG *")] uint* pulCurrentStream)
        {
            return ((delegate* stdcall<IDvdInfo*, uint*, uint*, int>)(lpVtbl[8]))((IDvdInfo*)Unsafe.AsPointer(ref this), pulStreamsAvailable, pulCurrentStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentSubpicture([NativeTypeName("ULONG *")] uint* pulStreamsAvailable, [NativeTypeName("ULONG *")] uint* pulCurrentStream, [NativeTypeName("BOOL *")] int* pIsDisabled)
        {
            return ((delegate* stdcall<IDvdInfo*, uint*, uint*, int*, int>)(lpVtbl[9]))((IDvdInfo*)Unsafe.AsPointer(ref this), pulStreamsAvailable, pulCurrentStream, pIsDisabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentUOPS([NativeTypeName("VALID_UOP_SOMTHING_OR_OTHER *")] uint* pUOP)
        {
            return ((delegate* stdcall<IDvdInfo*, uint*, int>)(lpVtbl[10]))((IDvdInfo*)Unsafe.AsPointer(ref this), pUOP);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAllSPRMs([NativeTypeName("SPRMARRAY *")] ushort** pRegisterArray)
        {
            return ((delegate* stdcall<IDvdInfo*, ushort**, int>)(lpVtbl[11]))((IDvdInfo*)Unsafe.AsPointer(ref this), pRegisterArray);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAllGPRMs([NativeTypeName("GPRMARRAY *")] ushort** pRegisterArray)
        {
            return ((delegate* stdcall<IDvdInfo*, ushort**, int>)(lpVtbl[12]))((IDvdInfo*)Unsafe.AsPointer(ref this), pRegisterArray);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAudioLanguage([NativeTypeName("ULONG")] uint ulStream, [NativeTypeName("LCID *")] uint* pLanguage)
        {
            return ((delegate* stdcall<IDvdInfo*, uint, uint*, int>)(lpVtbl[13]))((IDvdInfo*)Unsafe.AsPointer(ref this), ulStream, pLanguage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSubpictureLanguage([NativeTypeName("ULONG")] uint ulStream, [NativeTypeName("LCID *")] uint* pLanguage)
        {
            return ((delegate* stdcall<IDvdInfo*, uint, uint*, int>)(lpVtbl[14]))((IDvdInfo*)Unsafe.AsPointer(ref this), ulStream, pLanguage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTitleAttributes([NativeTypeName("ULONG")] uint ulTitle, [NativeTypeName("DVD_ATR *")] DVD_ATR* pATR)
        {
            return ((delegate* stdcall<IDvdInfo*, uint, DVD_ATR*, int>)(lpVtbl[15]))((IDvdInfo*)Unsafe.AsPointer(ref this), ulTitle, pATR);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVMGAttributes([NativeTypeName("DVD_ATR *")] DVD_ATR* pATR)
        {
            return ((delegate* stdcall<IDvdInfo*, DVD_ATR*, int>)(lpVtbl[16]))((IDvdInfo*)Unsafe.AsPointer(ref this), pATR);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentVideoAttributes([NativeTypeName("DVD_VideoATR *")] byte** pATR)
        {
            return ((delegate* stdcall<IDvdInfo*, byte**, int>)(lpVtbl[17]))((IDvdInfo*)Unsafe.AsPointer(ref this), pATR);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentAudioAttributes([NativeTypeName("DVD_AudioATR *")] byte** pATR)
        {
            return ((delegate* stdcall<IDvdInfo*, byte**, int>)(lpVtbl[18]))((IDvdInfo*)Unsafe.AsPointer(ref this), pATR);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentSubpictureAttributes([NativeTypeName("DVD_SubpictureATR *")] byte** pATR)
        {
            return ((delegate* stdcall<IDvdInfo*, byte**, int>)(lpVtbl[19]))((IDvdInfo*)Unsafe.AsPointer(ref this), pATR);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentVolumeInfo([NativeTypeName("ULONG *")] uint* pulNumOfVol, [NativeTypeName("ULONG *")] uint* pulThisVolNum, [NativeTypeName("DVD_DISC_SIDE *")] DVD_DISC_SIDE* pSide, [NativeTypeName("ULONG *")] uint* pulNumOfTitles)
        {
            return ((delegate* stdcall<IDvdInfo*, uint*, uint*, DVD_DISC_SIDE*, uint*, int>)(lpVtbl[20]))((IDvdInfo*)Unsafe.AsPointer(ref this), pulNumOfVol, pulThisVolNum, pSide, pulNumOfTitles);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDVDTextInfo([NativeTypeName("BYTE *")] byte* pTextManager, [NativeTypeName("ULONG")] uint ulBufSize, [NativeTypeName("ULONG *")] uint* pulActualSize)
        {
            return ((delegate* stdcall<IDvdInfo*, byte*, uint, uint*, int>)(lpVtbl[21]))((IDvdInfo*)Unsafe.AsPointer(ref this), pTextManager, ulBufSize, pulActualSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPlayerParentalLevel([NativeTypeName("ULONG *")] uint* pulParentalLevel, [NativeTypeName("ULONG *")] uint* pulCountryCode)
        {
            return ((delegate* stdcall<IDvdInfo*, uint*, uint*, int>)(lpVtbl[22]))((IDvdInfo*)Unsafe.AsPointer(ref this), pulParentalLevel, pulCountryCode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetNumberOfChapters([NativeTypeName("ULONG")] uint ulTitle, [NativeTypeName("ULONG *")] uint* pulNumberOfChapters)
        {
            return ((delegate* stdcall<IDvdInfo*, uint, uint*, int>)(lpVtbl[23]))((IDvdInfo*)Unsafe.AsPointer(ref this), ulTitle, pulNumberOfChapters);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTitleParentalLevels([NativeTypeName("ULONG")] uint ulTitle, [NativeTypeName("ULONG *")] uint* pulParentalLevels)
        {
            return ((delegate* stdcall<IDvdInfo*, uint, uint*, int>)(lpVtbl[24]))((IDvdInfo*)Unsafe.AsPointer(ref this), ulTitle, pulParentalLevels);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRoot([NativeTypeName("LPSTR")] sbyte* pRoot, [NativeTypeName("ULONG")] uint ulBufSize, [NativeTypeName("ULONG *")] uint* pulActualSize)
        {
            return ((delegate* stdcall<IDvdInfo*, sbyte*, uint, uint*, int>)(lpVtbl[25]))((IDvdInfo*)Unsafe.AsPointer(ref this), pRoot, ulBufSize, pulActualSize);
        }
    }
}
