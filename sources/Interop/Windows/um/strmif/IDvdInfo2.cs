// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("34151510-EEC0-11D2-8201-00A0C9D74842")]
    [NativeTypeName("struct IDvdInfo2 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDvdInfo2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDvdInfo2*, Guid*, void**, int>)(lpVtbl[0]))((IDvdInfo2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDvdInfo2*, uint>)(lpVtbl[1]))((IDvdInfo2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDvdInfo2*, uint>)(lpVtbl[2]))((IDvdInfo2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetCurrentDomain(DVD_DOMAIN* pDomain)
        {
            return ((delegate* unmanaged<IDvdInfo2*, DVD_DOMAIN*, int>)(lpVtbl[3]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pDomain);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetCurrentLocation(DVD_PLAYBACK_LOCATION2* pLocation)
        {
            return ((delegate* unmanaged<IDvdInfo2*, DVD_PLAYBACK_LOCATION2*, int>)(lpVtbl[4]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pLocation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetTotalTitleTime(DVD_HMSF_TIMECODE* pTotalTime, [NativeTypeName("ULONG *")] uint* ulTimeCodeFlags)
        {
            return ((delegate* unmanaged<IDvdInfo2*, DVD_HMSF_TIMECODE*, uint*, int>)(lpVtbl[5]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pTotalTime, ulTimeCodeFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetCurrentButton([NativeTypeName("ULONG *")] uint* pulButtonsAvailable, [NativeTypeName("ULONG *")] uint* pulCurrentButton)
        {
            return ((delegate* unmanaged<IDvdInfo2*, uint*, uint*, int>)(lpVtbl[6]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pulButtonsAvailable, pulCurrentButton);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetCurrentAngle([NativeTypeName("ULONG *")] uint* pulAnglesAvailable, [NativeTypeName("ULONG *")] uint* pulCurrentAngle)
        {
            return ((delegate* unmanaged<IDvdInfo2*, uint*, uint*, int>)(lpVtbl[7]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pulAnglesAvailable, pulCurrentAngle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetCurrentAudio([NativeTypeName("ULONG *")] uint* pulStreamsAvailable, [NativeTypeName("ULONG *")] uint* pulCurrentStream)
        {
            return ((delegate* unmanaged<IDvdInfo2*, uint*, uint*, int>)(lpVtbl[8]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pulStreamsAvailable, pulCurrentStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetCurrentSubpicture([NativeTypeName("ULONG *")] uint* pulStreamsAvailable, [NativeTypeName("ULONG *")] uint* pulCurrentStream, BOOL* pbIsDisabled)
        {
            return ((delegate* unmanaged<IDvdInfo2*, uint*, uint*, BOOL*, int>)(lpVtbl[9]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pulStreamsAvailable, pulCurrentStream, pbIsDisabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetCurrentUOPS([NativeTypeName("ULONG *")] uint* pulUOPs)
        {
            return ((delegate* unmanaged<IDvdInfo2*, uint*, int>)(lpVtbl[10]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pulUOPs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetAllSPRMs([NativeTypeName("SPRMARRAY *")] ushort** pRegisterArray)
        {
            return ((delegate* unmanaged<IDvdInfo2*, ushort**, int>)(lpVtbl[11]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pRegisterArray);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetAllGPRMs([NativeTypeName("GPRMARRAY *")] ushort** pRegisterArray)
        {
            return ((delegate* unmanaged<IDvdInfo2*, ushort**, int>)(lpVtbl[12]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pRegisterArray);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetAudioLanguage([NativeTypeName("ULONG")] uint ulStream, [NativeTypeName("LCID *")] uint* pLanguage)
        {
            return ((delegate* unmanaged<IDvdInfo2*, uint, uint*, int>)(lpVtbl[13]))((IDvdInfo2*)Unsafe.AsPointer(ref this), ulStream, pLanguage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT GetSubpictureLanguage([NativeTypeName("ULONG")] uint ulStream, [NativeTypeName("LCID *")] uint* pLanguage)
        {
            return ((delegate* unmanaged<IDvdInfo2*, uint, uint*, int>)(lpVtbl[14]))((IDvdInfo2*)Unsafe.AsPointer(ref this), ulStream, pLanguage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT GetTitleAttributes([NativeTypeName("ULONG")] uint ulTitle, DVD_MenuAttributes* pMenu, DVD_TitleAttributes* pTitle)
        {
            return ((delegate* unmanaged<IDvdInfo2*, uint, DVD_MenuAttributes*, DVD_TitleAttributes*, int>)(lpVtbl[15]))((IDvdInfo2*)Unsafe.AsPointer(ref this), ulTitle, pMenu, pTitle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT GetVMGAttributes(DVD_MenuAttributes* pATR)
        {
            return ((delegate* unmanaged<IDvdInfo2*, DVD_MenuAttributes*, int>)(lpVtbl[16]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pATR);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT GetCurrentVideoAttributes(DVD_VideoAttributes* pATR)
        {
            return ((delegate* unmanaged<IDvdInfo2*, DVD_VideoAttributes*, int>)(lpVtbl[17]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pATR);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT GetAudioAttributes([NativeTypeName("ULONG")] uint ulStream, DVD_AudioAttributes* pATR)
        {
            return ((delegate* unmanaged<IDvdInfo2*, uint, DVD_AudioAttributes*, int>)(lpVtbl[18]))((IDvdInfo2*)Unsafe.AsPointer(ref this), ulStream, pATR);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT GetKaraokeAttributes([NativeTypeName("ULONG")] uint ulStream, DVD_KaraokeAttributes* pAttributes)
        {
            return ((delegate* unmanaged<IDvdInfo2*, uint, DVD_KaraokeAttributes*, int>)(lpVtbl[19]))((IDvdInfo2*)Unsafe.AsPointer(ref this), ulStream, pAttributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT GetSubpictureAttributes([NativeTypeName("ULONG")] uint ulStream, DVD_SubpictureAttributes* pATR)
        {
            return ((delegate* unmanaged<IDvdInfo2*, uint, DVD_SubpictureAttributes*, int>)(lpVtbl[20]))((IDvdInfo2*)Unsafe.AsPointer(ref this), ulStream, pATR);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT GetDVDVolumeInfo([NativeTypeName("ULONG *")] uint* pulNumOfVolumes, [NativeTypeName("ULONG *")] uint* pulVolume, DVD_DISC_SIDE* pSide, [NativeTypeName("ULONG *")] uint* pulNumOfTitles)
        {
            return ((delegate* unmanaged<IDvdInfo2*, uint*, uint*, DVD_DISC_SIDE*, uint*, int>)(lpVtbl[21]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pulNumOfVolumes, pulVolume, pSide, pulNumOfTitles);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT GetDVDTextNumberOfLanguages([NativeTypeName("ULONG *")] uint* pulNumOfLangs)
        {
            return ((delegate* unmanaged<IDvdInfo2*, uint*, int>)(lpVtbl[22]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pulNumOfLangs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT GetDVDTextLanguageInfo([NativeTypeName("ULONG")] uint ulLangIndex, [NativeTypeName("ULONG *")] uint* pulNumOfStrings, [NativeTypeName("LCID *")] uint* pLangCode, [NativeTypeName("enum DVD_TextCharSet *")] DVD_TextCharSet* pbCharacterSet)
        {
            return ((delegate* unmanaged<IDvdInfo2*, uint, uint*, uint*, DVD_TextCharSet*, int>)(lpVtbl[23]))((IDvdInfo2*)Unsafe.AsPointer(ref this), ulLangIndex, pulNumOfStrings, pLangCode, pbCharacterSet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT GetDVDTextStringAsNative([NativeTypeName("ULONG")] uint ulLangIndex, [NativeTypeName("ULONG")] uint ulStringIndex, [NativeTypeName("BYTE *")] byte* pbBuffer, [NativeTypeName("ULONG")] uint ulMaxBufferSize, [NativeTypeName("ULONG *")] uint* pulActualSize, [NativeTypeName("enum DVD_TextStringType *")] DVD_TextStringType* pType)
        {
            return ((delegate* unmanaged<IDvdInfo2*, uint, uint, byte*, uint, uint*, DVD_TextStringType*, int>)(lpVtbl[24]))((IDvdInfo2*)Unsafe.AsPointer(ref this), ulLangIndex, ulStringIndex, pbBuffer, ulMaxBufferSize, pulActualSize, pType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT GetDVDTextStringAsUnicode([NativeTypeName("ULONG")] uint ulLangIndex, [NativeTypeName("ULONG")] uint ulStringIndex, [NativeTypeName("WCHAR *")] ushort* pchwBuffer, [NativeTypeName("ULONG")] uint ulMaxBufferSize, [NativeTypeName("ULONG *")] uint* pulActualSize, [NativeTypeName("enum DVD_TextStringType *")] DVD_TextStringType* pType)
        {
            return ((delegate* unmanaged<IDvdInfo2*, uint, uint, ushort*, uint, uint*, DVD_TextStringType*, int>)(lpVtbl[25]))((IDvdInfo2*)Unsafe.AsPointer(ref this), ulLangIndex, ulStringIndex, pchwBuffer, ulMaxBufferSize, pulActualSize, pType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT GetPlayerParentalLevel([NativeTypeName("ULONG *")] uint* pulParentalLevel, [NativeTypeName("BYTE [2]")] byte* pbCountryCode)
        {
            return ((delegate* unmanaged<IDvdInfo2*, uint*, byte*, int>)(lpVtbl[26]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pulParentalLevel, pbCountryCode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT GetNumberOfChapters([NativeTypeName("ULONG")] uint ulTitle, [NativeTypeName("ULONG *")] uint* pulNumOfChapters)
        {
            return ((delegate* unmanaged<IDvdInfo2*, uint, uint*, int>)(lpVtbl[27]))((IDvdInfo2*)Unsafe.AsPointer(ref this), ulTitle, pulNumOfChapters);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT GetTitleParentalLevels([NativeTypeName("ULONG")] uint ulTitle, [NativeTypeName("ULONG *")] uint* pulParentalLevels)
        {
            return ((delegate* unmanaged<IDvdInfo2*, uint, uint*, int>)(lpVtbl[28]))((IDvdInfo2*)Unsafe.AsPointer(ref this), ulTitle, pulParentalLevels);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT GetDVDDirectory([NativeTypeName("LPWSTR")] ushort* pszwPath, [NativeTypeName("ULONG")] uint ulMaxSize, [NativeTypeName("ULONG *")] uint* pulActualSize)
        {
            return ((delegate* unmanaged<IDvdInfo2*, ushort*, uint, uint*, int>)(lpVtbl[29]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pszwPath, ulMaxSize, pulActualSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT IsAudioStreamEnabled([NativeTypeName("ULONG")] uint ulStreamNum, BOOL* pbEnabled)
        {
            return ((delegate* unmanaged<IDvdInfo2*, uint, BOOL*, int>)(lpVtbl[30]))((IDvdInfo2*)Unsafe.AsPointer(ref this), ulStreamNum, pbEnabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT GetDiscID([NativeTypeName("LPCWSTR")] ushort* pszwPath, [NativeTypeName("ULONGLONG *")] ulong* pullDiscID)
        {
            return ((delegate* unmanaged<IDvdInfo2*, ushort*, ulong*, int>)(lpVtbl[31]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pszwPath, pullDiscID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT GetState(IDvdState** pStateData)
        {
            return ((delegate* unmanaged<IDvdInfo2*, IDvdState**, int>)(lpVtbl[32]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pStateData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT GetMenuLanguages([NativeTypeName("LCID *")] uint* pLanguages, [NativeTypeName("ULONG")] uint ulMaxLanguages, [NativeTypeName("ULONG *")] uint* pulActualLanguages)
        {
            return ((delegate* unmanaged<IDvdInfo2*, uint*, uint, uint*, int>)(lpVtbl[33]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pLanguages, ulMaxLanguages, pulActualLanguages);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT GetButtonAtPosition(POINT point, [NativeTypeName("ULONG *")] uint* pulButtonIndex)
        {
            return ((delegate* unmanaged<IDvdInfo2*, POINT, uint*, int>)(lpVtbl[34]))((IDvdInfo2*)Unsafe.AsPointer(ref this), point, pulButtonIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT GetCmdFromEvent([NativeTypeName("LONG_PTR")] nint lParam1, IDvdCmd** pCmdObj)
        {
            return ((delegate* unmanaged<IDvdInfo2*, nint, IDvdCmd**, int>)(lpVtbl[35]))((IDvdInfo2*)Unsafe.AsPointer(ref this), lParam1, pCmdObj);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HRESULT GetDefaultMenuLanguage([NativeTypeName("LCID *")] uint* pLanguage)
        {
            return ((delegate* unmanaged<IDvdInfo2*, uint*, int>)(lpVtbl[36]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pLanguage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public HRESULT GetDefaultAudioLanguage([NativeTypeName("LCID *")] uint* pLanguage, DVD_AUDIO_LANG_EXT* pAudioExtension)
        {
            return ((delegate* unmanaged<IDvdInfo2*, uint*, DVD_AUDIO_LANG_EXT*, int>)(lpVtbl[37]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pLanguage, pAudioExtension);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public HRESULT GetDefaultSubpictureLanguage([NativeTypeName("LCID *")] uint* pLanguage, DVD_SUBPICTURE_LANG_EXT* pSubpictureExtension)
        {
            return ((delegate* unmanaged<IDvdInfo2*, uint*, DVD_SUBPICTURE_LANG_EXT*, int>)(lpVtbl[38]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pLanguage, pSubpictureExtension);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public HRESULT GetDecoderCaps(DVD_DECODER_CAPS* pCaps)
        {
            return ((delegate* unmanaged<IDvdInfo2*, DVD_DECODER_CAPS*, int>)(lpVtbl[39]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pCaps);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        public HRESULT GetButtonRect([NativeTypeName("ULONG")] uint ulButton, RECT* pRect)
        {
            return ((delegate* unmanaged<IDvdInfo2*, uint, RECT*, int>)(lpVtbl[40]))((IDvdInfo2*)Unsafe.AsPointer(ref this), ulButton, pRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        public HRESULT IsSubpictureStreamEnabled([NativeTypeName("ULONG")] uint ulStreamNum, BOOL* pbEnabled)
        {
            return ((delegate* unmanaged<IDvdInfo2*, uint, BOOL*, int>)(lpVtbl[41]))((IDvdInfo2*)Unsafe.AsPointer(ref this), ulStreamNum, pbEnabled);
        }
    }
}
