// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("34151510-EEC0-11D2-8201-00A0C9D74842")]
    public unsafe partial struct IDvdInfo2
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDvdInfo2*, Guid*, void**, int>)(lpVtbl[0]))((IDvdInfo2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDvdInfo2*, uint>)(lpVtbl[1]))((IDvdInfo2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDvdInfo2*, uint>)(lpVtbl[2]))((IDvdInfo2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentDomain([NativeTypeName("DVD_DOMAIN *")] DVD_DOMAIN* pDomain)
        {
            return ((delegate* stdcall<IDvdInfo2*, DVD_DOMAIN*, int>)(lpVtbl[3]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pDomain);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentLocation([NativeTypeName("DVD_PLAYBACK_LOCATION2 *")] DVD_PLAYBACK_LOCATION2* pLocation)
        {
            return ((delegate* stdcall<IDvdInfo2*, DVD_PLAYBACK_LOCATION2*, int>)(lpVtbl[4]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pLocation);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTotalTitleTime([NativeTypeName("DVD_HMSF_TIMECODE *")] DVD_HMSF_TIMECODE* pTotalTime, [NativeTypeName("ULONG *")] uint* ulTimeCodeFlags)
        {
            return ((delegate* stdcall<IDvdInfo2*, DVD_HMSF_TIMECODE*, uint*, int>)(lpVtbl[5]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pTotalTime, ulTimeCodeFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentButton([NativeTypeName("ULONG *")] uint* pulButtonsAvailable, [NativeTypeName("ULONG *")] uint* pulCurrentButton)
        {
            return ((delegate* stdcall<IDvdInfo2*, uint*, uint*, int>)(lpVtbl[6]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pulButtonsAvailable, pulCurrentButton);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentAngle([NativeTypeName("ULONG *")] uint* pulAnglesAvailable, [NativeTypeName("ULONG *")] uint* pulCurrentAngle)
        {
            return ((delegate* stdcall<IDvdInfo2*, uint*, uint*, int>)(lpVtbl[7]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pulAnglesAvailable, pulCurrentAngle);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentAudio([NativeTypeName("ULONG *")] uint* pulStreamsAvailable, [NativeTypeName("ULONG *")] uint* pulCurrentStream)
        {
            return ((delegate* stdcall<IDvdInfo2*, uint*, uint*, int>)(lpVtbl[8]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pulStreamsAvailable, pulCurrentStream);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentSubpicture([NativeTypeName("ULONG *")] uint* pulStreamsAvailable, [NativeTypeName("ULONG *")] uint* pulCurrentStream, [NativeTypeName("BOOL *")] int* pbIsDisabled)
        {
            return ((delegate* stdcall<IDvdInfo2*, uint*, uint*, int*, int>)(lpVtbl[9]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pulStreamsAvailable, pulCurrentStream, pbIsDisabled);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentUOPS([NativeTypeName("ULONG *")] uint* pulUOPs)
        {
            return ((delegate* stdcall<IDvdInfo2*, uint*, int>)(lpVtbl[10]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pulUOPs);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAllSPRMs([NativeTypeName("SPRMARRAY *")] ushort** pRegisterArray)
        {
            return ((delegate* stdcall<IDvdInfo2*, ushort**, int>)(lpVtbl[11]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pRegisterArray);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAllGPRMs([NativeTypeName("GPRMARRAY *")] ushort** pRegisterArray)
        {
            return ((delegate* stdcall<IDvdInfo2*, ushort**, int>)(lpVtbl[12]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pRegisterArray);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAudioLanguage([NativeTypeName("ULONG")] uint ulStream, [NativeTypeName("LCID *")] uint* pLanguage)
        {
            return ((delegate* stdcall<IDvdInfo2*, uint, uint*, int>)(lpVtbl[13]))((IDvdInfo2*)Unsafe.AsPointer(ref this), ulStream, pLanguage);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSubpictureLanguage([NativeTypeName("ULONG")] uint ulStream, [NativeTypeName("LCID *")] uint* pLanguage)
        {
            return ((delegate* stdcall<IDvdInfo2*, uint, uint*, int>)(lpVtbl[14]))((IDvdInfo2*)Unsafe.AsPointer(ref this), ulStream, pLanguage);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTitleAttributes([NativeTypeName("ULONG")] uint ulTitle, [NativeTypeName("DVD_MenuAttributes *")] DVD_MenuAttributes* pMenu, [NativeTypeName("DVD_TitleAttributes *")] DVD_TitleAttributes* pTitle)
        {
            return ((delegate* stdcall<IDvdInfo2*, uint, DVD_MenuAttributes*, DVD_TitleAttributes*, int>)(lpVtbl[15]))((IDvdInfo2*)Unsafe.AsPointer(ref this), ulTitle, pMenu, pTitle);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVMGAttributes([NativeTypeName("DVD_MenuAttributes *")] DVD_MenuAttributes* pATR)
        {
            return ((delegate* stdcall<IDvdInfo2*, DVD_MenuAttributes*, int>)(lpVtbl[16]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pATR);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentVideoAttributes([NativeTypeName("DVD_VideoAttributes *")] DVD_VideoAttributes* pATR)
        {
            return ((delegate* stdcall<IDvdInfo2*, DVD_VideoAttributes*, int>)(lpVtbl[17]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pATR);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAudioAttributes([NativeTypeName("ULONG")] uint ulStream, [NativeTypeName("DVD_AudioAttributes *")] DVD_AudioAttributes* pATR)
        {
            return ((delegate* stdcall<IDvdInfo2*, uint, DVD_AudioAttributes*, int>)(lpVtbl[18]))((IDvdInfo2*)Unsafe.AsPointer(ref this), ulStream, pATR);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetKaraokeAttributes([NativeTypeName("ULONG")] uint ulStream, [NativeTypeName("DVD_KaraokeAttributes *")] DVD_KaraokeAttributes* pAttributes)
        {
            return ((delegate* stdcall<IDvdInfo2*, uint, DVD_KaraokeAttributes*, int>)(lpVtbl[19]))((IDvdInfo2*)Unsafe.AsPointer(ref this), ulStream, pAttributes);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSubpictureAttributes([NativeTypeName("ULONG")] uint ulStream, [NativeTypeName("DVD_SubpictureAttributes *")] DVD_SubpictureAttributes* pATR)
        {
            return ((delegate* stdcall<IDvdInfo2*, uint, DVD_SubpictureAttributes*, int>)(lpVtbl[20]))((IDvdInfo2*)Unsafe.AsPointer(ref this), ulStream, pATR);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDVDVolumeInfo([NativeTypeName("ULONG *")] uint* pulNumOfVolumes, [NativeTypeName("ULONG *")] uint* pulVolume, [NativeTypeName("DVD_DISC_SIDE *")] DVD_DISC_SIDE* pSide, [NativeTypeName("ULONG *")] uint* pulNumOfTitles)
        {
            return ((delegate* stdcall<IDvdInfo2*, uint*, uint*, DVD_DISC_SIDE*, uint*, int>)(lpVtbl[21]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pulNumOfVolumes, pulVolume, pSide, pulNumOfTitles);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDVDTextNumberOfLanguages([NativeTypeName("ULONG *")] uint* pulNumOfLangs)
        {
            return ((delegate* stdcall<IDvdInfo2*, uint*, int>)(lpVtbl[22]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pulNumOfLangs);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDVDTextLanguageInfo([NativeTypeName("ULONG")] uint ulLangIndex, [NativeTypeName("ULONG *")] uint* pulNumOfStrings, [NativeTypeName("LCID *")] uint* pLangCode, [NativeTypeName("enum DVD_TextCharSet *")] DVD_TextCharSet* pbCharacterSet)
        {
            return ((delegate* stdcall<IDvdInfo2*, uint, uint*, uint*, DVD_TextCharSet*, int>)(lpVtbl[23]))((IDvdInfo2*)Unsafe.AsPointer(ref this), ulLangIndex, pulNumOfStrings, pLangCode, pbCharacterSet);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDVDTextStringAsNative([NativeTypeName("ULONG")] uint ulLangIndex, [NativeTypeName("ULONG")] uint ulStringIndex, [NativeTypeName("BYTE *")] byte* pbBuffer, [NativeTypeName("ULONG")] uint ulMaxBufferSize, [NativeTypeName("ULONG *")] uint* pulActualSize, [NativeTypeName("enum DVD_TextStringType *")] DVD_TextStringType* pType)
        {
            return ((delegate* stdcall<IDvdInfo2*, uint, uint, byte*, uint, uint*, DVD_TextStringType*, int>)(lpVtbl[24]))((IDvdInfo2*)Unsafe.AsPointer(ref this), ulLangIndex, ulStringIndex, pbBuffer, ulMaxBufferSize, pulActualSize, pType);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDVDTextStringAsUnicode([NativeTypeName("ULONG")] uint ulLangIndex, [NativeTypeName("ULONG")] uint ulStringIndex, [NativeTypeName("WCHAR *")] ushort* pchwBuffer, [NativeTypeName("ULONG")] uint ulMaxBufferSize, [NativeTypeName("ULONG *")] uint* pulActualSize, [NativeTypeName("enum DVD_TextStringType *")] DVD_TextStringType* pType)
        {
            return ((delegate* stdcall<IDvdInfo2*, uint, uint, ushort*, uint, uint*, DVD_TextStringType*, int>)(lpVtbl[25]))((IDvdInfo2*)Unsafe.AsPointer(ref this), ulLangIndex, ulStringIndex, pchwBuffer, ulMaxBufferSize, pulActualSize, pType);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPlayerParentalLevel([NativeTypeName("ULONG *")] uint* pulParentalLevel, [NativeTypeName("BYTE [2]")] byte* pbCountryCode)
        {
            return ((delegate* stdcall<IDvdInfo2*, uint*, byte*, int>)(lpVtbl[26]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pulParentalLevel, pbCountryCode);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetNumberOfChapters([NativeTypeName("ULONG")] uint ulTitle, [NativeTypeName("ULONG *")] uint* pulNumOfChapters)
        {
            return ((delegate* stdcall<IDvdInfo2*, uint, uint*, int>)(lpVtbl[27]))((IDvdInfo2*)Unsafe.AsPointer(ref this), ulTitle, pulNumOfChapters);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTitleParentalLevels([NativeTypeName("ULONG")] uint ulTitle, [NativeTypeName("ULONG *")] uint* pulParentalLevels)
        {
            return ((delegate* stdcall<IDvdInfo2*, uint, uint*, int>)(lpVtbl[28]))((IDvdInfo2*)Unsafe.AsPointer(ref this), ulTitle, pulParentalLevels);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDVDDirectory([NativeTypeName("LPWSTR")] ushort* pszwPath, [NativeTypeName("ULONG")] uint ulMaxSize, [NativeTypeName("ULONG *")] uint* pulActualSize)
        {
            return ((delegate* stdcall<IDvdInfo2*, ushort*, uint, uint*, int>)(lpVtbl[29]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pszwPath, ulMaxSize, pulActualSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsAudioStreamEnabled([NativeTypeName("ULONG")] uint ulStreamNum, [NativeTypeName("BOOL *")] int* pbEnabled)
        {
            return ((delegate* stdcall<IDvdInfo2*, uint, int*, int>)(lpVtbl[30]))((IDvdInfo2*)Unsafe.AsPointer(ref this), ulStreamNum, pbEnabled);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDiscID([NativeTypeName("LPCWSTR")] ushort* pszwPath, [NativeTypeName("ULONGLONG *")] ulong* pullDiscID)
        {
            return ((delegate* stdcall<IDvdInfo2*, ushort*, ulong*, int>)(lpVtbl[31]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pszwPath, pullDiscID);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetState([NativeTypeName("IDvdState **")] IDvdState** pStateData)
        {
            return ((delegate* stdcall<IDvdInfo2*, IDvdState**, int>)(lpVtbl[32]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pStateData);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMenuLanguages([NativeTypeName("LCID *")] uint* pLanguages, [NativeTypeName("ULONG")] uint ulMaxLanguages, [NativeTypeName("ULONG *")] uint* pulActualLanguages)
        {
            return ((delegate* stdcall<IDvdInfo2*, uint*, uint, uint*, int>)(lpVtbl[33]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pLanguages, ulMaxLanguages, pulActualLanguages);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetButtonAtPosition(POINT point, [NativeTypeName("ULONG *")] uint* pulButtonIndex)
        {
            return ((delegate* stdcall<IDvdInfo2*, POINT, uint*, int>)(lpVtbl[34]))((IDvdInfo2*)Unsafe.AsPointer(ref this), point, pulButtonIndex);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCmdFromEvent([NativeTypeName("LONG_PTR")] nint lParam1, [NativeTypeName("IDvdCmd **")] IDvdCmd** pCmdObj)
        {
            return ((delegate* stdcall<IDvdInfo2*, nint, IDvdCmd**, int>)(lpVtbl[35]))((IDvdInfo2*)Unsafe.AsPointer(ref this), lParam1, pCmdObj);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDefaultMenuLanguage([NativeTypeName("LCID *")] uint* pLanguage)
        {
            return ((delegate* stdcall<IDvdInfo2*, uint*, int>)(lpVtbl[36]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pLanguage);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDefaultAudioLanguage([NativeTypeName("LCID *")] uint* pLanguage, [NativeTypeName("DVD_AUDIO_LANG_EXT *")] DVD_AUDIO_LANG_EXT* pAudioExtension)
        {
            return ((delegate* stdcall<IDvdInfo2*, uint*, DVD_AUDIO_LANG_EXT*, int>)(lpVtbl[37]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pLanguage, pAudioExtension);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDefaultSubpictureLanguage([NativeTypeName("LCID *")] uint* pLanguage, [NativeTypeName("DVD_SUBPICTURE_LANG_EXT *")] DVD_SUBPICTURE_LANG_EXT* pSubpictureExtension)
        {
            return ((delegate* stdcall<IDvdInfo2*, uint*, DVD_SUBPICTURE_LANG_EXT*, int>)(lpVtbl[38]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pLanguage, pSubpictureExtension);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDecoderCaps([NativeTypeName("DVD_DECODER_CAPS *")] DVD_DECODER_CAPS* pCaps)
        {
            return ((delegate* stdcall<IDvdInfo2*, DVD_DECODER_CAPS*, int>)(lpVtbl[39]))((IDvdInfo2*)Unsafe.AsPointer(ref this), pCaps);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetButtonRect([NativeTypeName("ULONG")] uint ulButton, [NativeTypeName("RECT *")] RECT* pRect)
        {
            return ((delegate* stdcall<IDvdInfo2*, uint, RECT*, int>)(lpVtbl[40]))((IDvdInfo2*)Unsafe.AsPointer(ref this), ulButton, pRect);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsSubpictureStreamEnabled([NativeTypeName("ULONG")] uint ulStreamNum, [NativeTypeName("BOOL *")] int* pbEnabled)
        {
            return ((delegate* stdcall<IDvdInfo2*, uint, int*, int>)(lpVtbl[41]))((IDvdInfo2*)Unsafe.AsPointer(ref this), ulStreamNum, pbEnabled);
        }
    }
}
