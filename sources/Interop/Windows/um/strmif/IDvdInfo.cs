// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A70EFE60-E2A3-11D0-A9BE-00AA0061BE93")]
    [NativeTypeName("struct IDvdInfo : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDvdInfo
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDvdInfo*, Guid*, void**, int>)(lpVtbl[0]))((IDvdInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDvdInfo*, uint>)(lpVtbl[1]))((IDvdInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDvdInfo*, uint>)(lpVtbl[2]))((IDvdInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetCurrentDomain(DVD_DOMAIN* pDomain)
        {
            return ((delegate* unmanaged<IDvdInfo*, DVD_DOMAIN*, int>)(lpVtbl[3]))((IDvdInfo*)Unsafe.AsPointer(ref this), pDomain);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetCurrentLocation(DVD_PLAYBACK_LOCATION* pLocation)
        {
            return ((delegate* unmanaged<IDvdInfo*, DVD_PLAYBACK_LOCATION*, int>)(lpVtbl[4]))((IDvdInfo*)Unsafe.AsPointer(ref this), pLocation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetTotalTitleTime([NativeTypeName("ULONG *")] uint* pulTotalTime)
        {
            return ((delegate* unmanaged<IDvdInfo*, uint*, int>)(lpVtbl[5]))((IDvdInfo*)Unsafe.AsPointer(ref this), pulTotalTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetCurrentButton([NativeTypeName("ULONG *")] uint* pulButtonsAvailable, [NativeTypeName("ULONG *")] uint* pulCurrentButton)
        {
            return ((delegate* unmanaged<IDvdInfo*, uint*, uint*, int>)(lpVtbl[6]))((IDvdInfo*)Unsafe.AsPointer(ref this), pulButtonsAvailable, pulCurrentButton);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetCurrentAngle([NativeTypeName("ULONG *")] uint* pulAnglesAvailable, [NativeTypeName("ULONG *")] uint* pulCurrentAngle)
        {
            return ((delegate* unmanaged<IDvdInfo*, uint*, uint*, int>)(lpVtbl[7]))((IDvdInfo*)Unsafe.AsPointer(ref this), pulAnglesAvailable, pulCurrentAngle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetCurrentAudio([NativeTypeName("ULONG *")] uint* pulStreamsAvailable, [NativeTypeName("ULONG *")] uint* pulCurrentStream)
        {
            return ((delegate* unmanaged<IDvdInfo*, uint*, uint*, int>)(lpVtbl[8]))((IDvdInfo*)Unsafe.AsPointer(ref this), pulStreamsAvailable, pulCurrentStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetCurrentSubpicture([NativeTypeName("ULONG *")] uint* pulStreamsAvailable, [NativeTypeName("ULONG *")] uint* pulCurrentStream, BOOL* pIsDisabled)
        {
            return ((delegate* unmanaged<IDvdInfo*, uint*, uint*, BOOL*, int>)(lpVtbl[9]))((IDvdInfo*)Unsafe.AsPointer(ref this), pulStreamsAvailable, pulCurrentStream, pIsDisabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetCurrentUOPS([NativeTypeName("VALID_UOP_SOMTHING_OR_OTHER *")] uint* pUOP)
        {
            return ((delegate* unmanaged<IDvdInfo*, uint*, int>)(lpVtbl[10]))((IDvdInfo*)Unsafe.AsPointer(ref this), pUOP);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetAllSPRMs([NativeTypeName("SPRMARRAY *")] ushort** pRegisterArray)
        {
            return ((delegate* unmanaged<IDvdInfo*, ushort**, int>)(lpVtbl[11]))((IDvdInfo*)Unsafe.AsPointer(ref this), pRegisterArray);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetAllGPRMs([NativeTypeName("GPRMARRAY *")] ushort** pRegisterArray)
        {
            return ((delegate* unmanaged<IDvdInfo*, ushort**, int>)(lpVtbl[12]))((IDvdInfo*)Unsafe.AsPointer(ref this), pRegisterArray);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetAudioLanguage([NativeTypeName("ULONG")] uint ulStream, [NativeTypeName("LCID *")] uint* pLanguage)
        {
            return ((delegate* unmanaged<IDvdInfo*, uint, uint*, int>)(lpVtbl[13]))((IDvdInfo*)Unsafe.AsPointer(ref this), ulStream, pLanguage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT GetSubpictureLanguage([NativeTypeName("ULONG")] uint ulStream, [NativeTypeName("LCID *")] uint* pLanguage)
        {
            return ((delegate* unmanaged<IDvdInfo*, uint, uint*, int>)(lpVtbl[14]))((IDvdInfo*)Unsafe.AsPointer(ref this), ulStream, pLanguage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT GetTitleAttributes([NativeTypeName("ULONG")] uint ulTitle, DVD_ATR* pATR)
        {
            return ((delegate* unmanaged<IDvdInfo*, uint, DVD_ATR*, int>)(lpVtbl[15]))((IDvdInfo*)Unsafe.AsPointer(ref this), ulTitle, pATR);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT GetVMGAttributes(DVD_ATR* pATR)
        {
            return ((delegate* unmanaged<IDvdInfo*, DVD_ATR*, int>)(lpVtbl[16]))((IDvdInfo*)Unsafe.AsPointer(ref this), pATR);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT GetCurrentVideoAttributes([NativeTypeName("DVD_VideoATR *")] byte** pATR)
        {
            return ((delegate* unmanaged<IDvdInfo*, byte**, int>)(lpVtbl[17]))((IDvdInfo*)Unsafe.AsPointer(ref this), pATR);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT GetCurrentAudioAttributes([NativeTypeName("DVD_AudioATR *")] byte** pATR)
        {
            return ((delegate* unmanaged<IDvdInfo*, byte**, int>)(lpVtbl[18]))((IDvdInfo*)Unsafe.AsPointer(ref this), pATR);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT GetCurrentSubpictureAttributes([NativeTypeName("DVD_SubpictureATR *")] byte** pATR)
        {
            return ((delegate* unmanaged<IDvdInfo*, byte**, int>)(lpVtbl[19]))((IDvdInfo*)Unsafe.AsPointer(ref this), pATR);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT GetCurrentVolumeInfo([NativeTypeName("ULONG *")] uint* pulNumOfVol, [NativeTypeName("ULONG *")] uint* pulThisVolNum, DVD_DISC_SIDE* pSide, [NativeTypeName("ULONG *")] uint* pulNumOfTitles)
        {
            return ((delegate* unmanaged<IDvdInfo*, uint*, uint*, DVD_DISC_SIDE*, uint*, int>)(lpVtbl[20]))((IDvdInfo*)Unsafe.AsPointer(ref this), pulNumOfVol, pulThisVolNum, pSide, pulNumOfTitles);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT GetDVDTextInfo(byte* pTextManager, [NativeTypeName("ULONG")] uint ulBufSize, [NativeTypeName("ULONG *")] uint* pulActualSize)
        {
            return ((delegate* unmanaged<IDvdInfo*, byte*, uint, uint*, int>)(lpVtbl[21]))((IDvdInfo*)Unsafe.AsPointer(ref this), pTextManager, ulBufSize, pulActualSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT GetPlayerParentalLevel([NativeTypeName("ULONG *")] uint* pulParentalLevel, [NativeTypeName("ULONG *")] uint* pulCountryCode)
        {
            return ((delegate* unmanaged<IDvdInfo*, uint*, uint*, int>)(lpVtbl[22]))((IDvdInfo*)Unsafe.AsPointer(ref this), pulParentalLevel, pulCountryCode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT GetNumberOfChapters([NativeTypeName("ULONG")] uint ulTitle, [NativeTypeName("ULONG *")] uint* pulNumberOfChapters)
        {
            return ((delegate* unmanaged<IDvdInfo*, uint, uint*, int>)(lpVtbl[23]))((IDvdInfo*)Unsafe.AsPointer(ref this), ulTitle, pulNumberOfChapters);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT GetTitleParentalLevels([NativeTypeName("ULONG")] uint ulTitle, [NativeTypeName("ULONG *")] uint* pulParentalLevels)
        {
            return ((delegate* unmanaged<IDvdInfo*, uint, uint*, int>)(lpVtbl[24]))((IDvdInfo*)Unsafe.AsPointer(ref this), ulTitle, pulParentalLevels);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT GetRoot([NativeTypeName("LPSTR")] sbyte* pRoot, [NativeTypeName("ULONG")] uint ulBufSize, [NativeTypeName("ULONG *")] uint* pulActualSize)
        {
            return ((delegate* unmanaged<IDvdInfo*, sbyte*, uint, uint*, int>)(lpVtbl[25]))((IDvdInfo*)Unsafe.AsPointer(ref this), pRoot, ulBufSize, pulActualSize);
        }
    }
}
