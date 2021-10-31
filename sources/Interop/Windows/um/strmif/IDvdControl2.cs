// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("33BC7430-EEC0-11D2-8201-00A0C9D74842")]
    [NativeTypeName("struct IDvdControl2 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDvdControl2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDvdControl2*, Guid*, void**, int>)(lpVtbl[0]))((IDvdControl2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDvdControl2*, uint>)(lpVtbl[1]))((IDvdControl2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDvdControl2*, uint>)(lpVtbl[2]))((IDvdControl2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT PlayTitle([NativeTypeName("ULONG")] uint ulTitle, [NativeTypeName("DWORD")] uint dwFlags, IDvdCmd** ppCmd)
        {
            return ((delegate* unmanaged<IDvdControl2*, uint, uint, IDvdCmd**, int>)(lpVtbl[3]))((IDvdControl2*)Unsafe.AsPointer(ref this), ulTitle, dwFlags, ppCmd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT PlayChapterInTitle([NativeTypeName("ULONG")] uint ulTitle, [NativeTypeName("ULONG")] uint ulChapter, [NativeTypeName("DWORD")] uint dwFlags, IDvdCmd** ppCmd)
        {
            return ((delegate* unmanaged<IDvdControl2*, uint, uint, uint, IDvdCmd**, int>)(lpVtbl[4]))((IDvdControl2*)Unsafe.AsPointer(ref this), ulTitle, ulChapter, dwFlags, ppCmd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT PlayAtTimeInTitle([NativeTypeName("ULONG")] uint ulTitle, DVD_HMSF_TIMECODE* pStartTime, [NativeTypeName("DWORD")] uint dwFlags, IDvdCmd** ppCmd)
        {
            return ((delegate* unmanaged<IDvdControl2*, uint, DVD_HMSF_TIMECODE*, uint, IDvdCmd**, int>)(lpVtbl[5]))((IDvdControl2*)Unsafe.AsPointer(ref this), ulTitle, pStartTime, dwFlags, ppCmd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Stop()
        {
            return ((delegate* unmanaged<IDvdControl2*, int>)(lpVtbl[6]))((IDvdControl2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT ReturnFromSubmenu([NativeTypeName("DWORD")] uint dwFlags, IDvdCmd** ppCmd)
        {
            return ((delegate* unmanaged<IDvdControl2*, uint, IDvdCmd**, int>)(lpVtbl[7]))((IDvdControl2*)Unsafe.AsPointer(ref this), dwFlags, ppCmd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT PlayAtTime(DVD_HMSF_TIMECODE* pTime, [NativeTypeName("DWORD")] uint dwFlags, IDvdCmd** ppCmd)
        {
            return ((delegate* unmanaged<IDvdControl2*, DVD_HMSF_TIMECODE*, uint, IDvdCmd**, int>)(lpVtbl[8]))((IDvdControl2*)Unsafe.AsPointer(ref this), pTime, dwFlags, ppCmd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT PlayChapter([NativeTypeName("ULONG")] uint ulChapter, [NativeTypeName("DWORD")] uint dwFlags, IDvdCmd** ppCmd)
        {
            return ((delegate* unmanaged<IDvdControl2*, uint, uint, IDvdCmd**, int>)(lpVtbl[9]))((IDvdControl2*)Unsafe.AsPointer(ref this), ulChapter, dwFlags, ppCmd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT PlayPrevChapter([NativeTypeName("DWORD")] uint dwFlags, IDvdCmd** ppCmd)
        {
            return ((delegate* unmanaged<IDvdControl2*, uint, IDvdCmd**, int>)(lpVtbl[10]))((IDvdControl2*)Unsafe.AsPointer(ref this), dwFlags, ppCmd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT ReplayChapter([NativeTypeName("DWORD")] uint dwFlags, IDvdCmd** ppCmd)
        {
            return ((delegate* unmanaged<IDvdControl2*, uint, IDvdCmd**, int>)(lpVtbl[11]))((IDvdControl2*)Unsafe.AsPointer(ref this), dwFlags, ppCmd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT PlayNextChapter([NativeTypeName("DWORD")] uint dwFlags, IDvdCmd** ppCmd)
        {
            return ((delegate* unmanaged<IDvdControl2*, uint, IDvdCmd**, int>)(lpVtbl[12]))((IDvdControl2*)Unsafe.AsPointer(ref this), dwFlags, ppCmd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT PlayForwards(double dSpeed, [NativeTypeName("DWORD")] uint dwFlags, IDvdCmd** ppCmd)
        {
            return ((delegate* unmanaged<IDvdControl2*, double, uint, IDvdCmd**, int>)(lpVtbl[13]))((IDvdControl2*)Unsafe.AsPointer(ref this), dSpeed, dwFlags, ppCmd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT PlayBackwards(double dSpeed, [NativeTypeName("DWORD")] uint dwFlags, IDvdCmd** ppCmd)
        {
            return ((delegate* unmanaged<IDvdControl2*, double, uint, IDvdCmd**, int>)(lpVtbl[14]))((IDvdControl2*)Unsafe.AsPointer(ref this), dSpeed, dwFlags, ppCmd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT ShowMenu(DVD_MENU_ID MenuID, [NativeTypeName("DWORD")] uint dwFlags, IDvdCmd** ppCmd)
        {
            return ((delegate* unmanaged<IDvdControl2*, DVD_MENU_ID, uint, IDvdCmd**, int>)(lpVtbl[15]))((IDvdControl2*)Unsafe.AsPointer(ref this), MenuID, dwFlags, ppCmd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT Resume([NativeTypeName("DWORD")] uint dwFlags, IDvdCmd** ppCmd)
        {
            return ((delegate* unmanaged<IDvdControl2*, uint, IDvdCmd**, int>)(lpVtbl[16]))((IDvdControl2*)Unsafe.AsPointer(ref this), dwFlags, ppCmd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT SelectRelativeButton(DVD_RELATIVE_BUTTON buttonDir)
        {
            return ((delegate* unmanaged<IDvdControl2*, DVD_RELATIVE_BUTTON, int>)(lpVtbl[17]))((IDvdControl2*)Unsafe.AsPointer(ref this), buttonDir);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT ActivateButton()
        {
            return ((delegate* unmanaged<IDvdControl2*, int>)(lpVtbl[18]))((IDvdControl2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT SelectButton([NativeTypeName("ULONG")] uint ulButton)
        {
            return ((delegate* unmanaged<IDvdControl2*, uint, int>)(lpVtbl[19]))((IDvdControl2*)Unsafe.AsPointer(ref this), ulButton);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT SelectAndActivateButton([NativeTypeName("ULONG")] uint ulButton)
        {
            return ((delegate* unmanaged<IDvdControl2*, uint, int>)(lpVtbl[20]))((IDvdControl2*)Unsafe.AsPointer(ref this), ulButton);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT StillOff()
        {
            return ((delegate* unmanaged<IDvdControl2*, int>)(lpVtbl[21]))((IDvdControl2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT Pause(BOOL bState)
        {
            return ((delegate* unmanaged<IDvdControl2*, BOOL, int>)(lpVtbl[22]))((IDvdControl2*)Unsafe.AsPointer(ref this), bState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT SelectAudioStream([NativeTypeName("ULONG")] uint ulAudio, [NativeTypeName("DWORD")] uint dwFlags, IDvdCmd** ppCmd)
        {
            return ((delegate* unmanaged<IDvdControl2*, uint, uint, IDvdCmd**, int>)(lpVtbl[23]))((IDvdControl2*)Unsafe.AsPointer(ref this), ulAudio, dwFlags, ppCmd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT SelectSubpictureStream([NativeTypeName("ULONG")] uint ulSubPicture, [NativeTypeName("DWORD")] uint dwFlags, IDvdCmd** ppCmd)
        {
            return ((delegate* unmanaged<IDvdControl2*, uint, uint, IDvdCmd**, int>)(lpVtbl[24]))((IDvdControl2*)Unsafe.AsPointer(ref this), ulSubPicture, dwFlags, ppCmd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT SetSubpictureState(BOOL bState, [NativeTypeName("DWORD")] uint dwFlags, IDvdCmd** ppCmd)
        {
            return ((delegate* unmanaged<IDvdControl2*, BOOL, uint, IDvdCmd**, int>)(lpVtbl[25]))((IDvdControl2*)Unsafe.AsPointer(ref this), bState, dwFlags, ppCmd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT SelectAngle([NativeTypeName("ULONG")] uint ulAngle, [NativeTypeName("DWORD")] uint dwFlags, IDvdCmd** ppCmd)
        {
            return ((delegate* unmanaged<IDvdControl2*, uint, uint, IDvdCmd**, int>)(lpVtbl[26]))((IDvdControl2*)Unsafe.AsPointer(ref this), ulAngle, dwFlags, ppCmd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT SelectParentalLevel([NativeTypeName("ULONG")] uint ulParentalLevel)
        {
            return ((delegate* unmanaged<IDvdControl2*, uint, int>)(lpVtbl[27]))((IDvdControl2*)Unsafe.AsPointer(ref this), ulParentalLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT SelectParentalCountry([NativeTypeName("BYTE [2]")] byte* bCountry)
        {
            return ((delegate* unmanaged<IDvdControl2*, byte*, int>)(lpVtbl[28]))((IDvdControl2*)Unsafe.AsPointer(ref this), bCountry);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT SelectKaraokeAudioPresentationMode([NativeTypeName("ULONG")] uint ulMode)
        {
            return ((delegate* unmanaged<IDvdControl2*, uint, int>)(lpVtbl[29]))((IDvdControl2*)Unsafe.AsPointer(ref this), ulMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT SelectVideoModePreference([NativeTypeName("ULONG")] uint ulPreferredDisplayMode)
        {
            return ((delegate* unmanaged<IDvdControl2*, uint, int>)(lpVtbl[30]))((IDvdControl2*)Unsafe.AsPointer(ref this), ulPreferredDisplayMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT SetDVDDirectory([NativeTypeName("LPCWSTR")] ushort* pszwPath)
        {
            return ((delegate* unmanaged<IDvdControl2*, ushort*, int>)(lpVtbl[31]))((IDvdControl2*)Unsafe.AsPointer(ref this), pszwPath);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT ActivateAtPosition(POINT point)
        {
            return ((delegate* unmanaged<IDvdControl2*, POINT, int>)(lpVtbl[32]))((IDvdControl2*)Unsafe.AsPointer(ref this), point);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT SelectAtPosition(POINT point)
        {
            return ((delegate* unmanaged<IDvdControl2*, POINT, int>)(lpVtbl[33]))((IDvdControl2*)Unsafe.AsPointer(ref this), point);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT PlayChaptersAutoStop([NativeTypeName("ULONG")] uint ulTitle, [NativeTypeName("ULONG")] uint ulChapter, [NativeTypeName("ULONG")] uint ulChaptersToPlay, [NativeTypeName("DWORD")] uint dwFlags, IDvdCmd** ppCmd)
        {
            return ((delegate* unmanaged<IDvdControl2*, uint, uint, uint, uint, IDvdCmd**, int>)(lpVtbl[34]))((IDvdControl2*)Unsafe.AsPointer(ref this), ulTitle, ulChapter, ulChaptersToPlay, dwFlags, ppCmd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT AcceptParentalLevelChange(BOOL bAccept)
        {
            return ((delegate* unmanaged<IDvdControl2*, BOOL, int>)(lpVtbl[35]))((IDvdControl2*)Unsafe.AsPointer(ref this), bAccept);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HRESULT SetOption(DVD_OPTION_FLAG flag, BOOL fState)
        {
            return ((delegate* unmanaged<IDvdControl2*, DVD_OPTION_FLAG, BOOL, int>)(lpVtbl[36]))((IDvdControl2*)Unsafe.AsPointer(ref this), flag, fState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public HRESULT SetState(IDvdState* pState, [NativeTypeName("DWORD")] uint dwFlags, IDvdCmd** ppCmd)
        {
            return ((delegate* unmanaged<IDvdControl2*, IDvdState*, uint, IDvdCmd**, int>)(lpVtbl[37]))((IDvdControl2*)Unsafe.AsPointer(ref this), pState, dwFlags, ppCmd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public HRESULT PlayPeriodInTitleAutoStop([NativeTypeName("ULONG")] uint ulTitle, DVD_HMSF_TIMECODE* pStartTime, DVD_HMSF_TIMECODE* pEndTime, [NativeTypeName("DWORD")] uint dwFlags, IDvdCmd** ppCmd)
        {
            return ((delegate* unmanaged<IDvdControl2*, uint, DVD_HMSF_TIMECODE*, DVD_HMSF_TIMECODE*, uint, IDvdCmd**, int>)(lpVtbl[38]))((IDvdControl2*)Unsafe.AsPointer(ref this), ulTitle, pStartTime, pEndTime, dwFlags, ppCmd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public HRESULT SetGPRM([NativeTypeName("ULONG")] uint ulIndex, [NativeTypeName("WORD")] ushort wValue, [NativeTypeName("DWORD")] uint dwFlags, IDvdCmd** ppCmd)
        {
            return ((delegate* unmanaged<IDvdControl2*, uint, ushort, uint, IDvdCmd**, int>)(lpVtbl[39]))((IDvdControl2*)Unsafe.AsPointer(ref this), ulIndex, wValue, dwFlags, ppCmd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        public HRESULT SelectDefaultMenuLanguage([NativeTypeName("LCID")] uint Language)
        {
            return ((delegate* unmanaged<IDvdControl2*, uint, int>)(lpVtbl[40]))((IDvdControl2*)Unsafe.AsPointer(ref this), Language);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        public HRESULT SelectDefaultAudioLanguage([NativeTypeName("LCID")] uint Language, DVD_AUDIO_LANG_EXT audioExtension)
        {
            return ((delegate* unmanaged<IDvdControl2*, uint, DVD_AUDIO_LANG_EXT, int>)(lpVtbl[41]))((IDvdControl2*)Unsafe.AsPointer(ref this), Language, audioExtension);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        public HRESULT SelectDefaultSubpictureLanguage([NativeTypeName("LCID")] uint Language, DVD_SUBPICTURE_LANG_EXT subpictureExtension)
        {
            return ((delegate* unmanaged<IDvdControl2*, uint, DVD_SUBPICTURE_LANG_EXT, int>)(lpVtbl[42]))((IDvdControl2*)Unsafe.AsPointer(ref this), Language, subpictureExtension);
        }
    }
}
