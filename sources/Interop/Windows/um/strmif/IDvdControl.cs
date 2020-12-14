// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A70EFE61-E2A3-11D0-A9BE-00AA0061BE93")]
    [NativeTypeName("struct IDvdControl : IUnknown")]
    public unsafe partial struct IDvdControl
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IDvdControl*, Guid*, void**, int>)(lpVtbl[0]))((IDvdControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDvdControl*, uint>)(lpVtbl[1]))((IDvdControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDvdControl*, uint>)(lpVtbl[2]))((IDvdControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int TitlePlay([NativeTypeName("ULONG")] uint ulTitle)
        {
            return ((delegate* unmanaged<IDvdControl*, uint, int>)(lpVtbl[3]))((IDvdControl*)Unsafe.AsPointer(ref this), ulTitle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ChapterPlay([NativeTypeName("ULONG")] uint ulTitle, [NativeTypeName("ULONG")] uint ulChapter)
        {
            return ((delegate* unmanaged<IDvdControl*, uint, uint, int>)(lpVtbl[4]))((IDvdControl*)Unsafe.AsPointer(ref this), ulTitle, ulChapter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int TimePlay([NativeTypeName("ULONG")] uint ulTitle, [NativeTypeName("ULONG")] uint bcdTime)
        {
            return ((delegate* unmanaged<IDvdControl*, uint, uint, int>)(lpVtbl[5]))((IDvdControl*)Unsafe.AsPointer(ref this), ulTitle, bcdTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int StopForResume()
        {
            return ((delegate* unmanaged<IDvdControl*, int>)(lpVtbl[6]))((IDvdControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GoUp()
        {
            return ((delegate* unmanaged<IDvdControl*, int>)(lpVtbl[7]))((IDvdControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int TimeSearch([NativeTypeName("ULONG")] uint bcdTime)
        {
            return ((delegate* unmanaged<IDvdControl*, uint, int>)(lpVtbl[8]))((IDvdControl*)Unsafe.AsPointer(ref this), bcdTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ChapterSearch([NativeTypeName("ULONG")] uint ulChapter)
        {
            return ((delegate* unmanaged<IDvdControl*, uint, int>)(lpVtbl[9]))((IDvdControl*)Unsafe.AsPointer(ref this), ulChapter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int PrevPGSearch()
        {
            return ((delegate* unmanaged<IDvdControl*, int>)(lpVtbl[10]))((IDvdControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int TopPGSearch()
        {
            return ((delegate* unmanaged<IDvdControl*, int>)(lpVtbl[11]))((IDvdControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int NextPGSearch()
        {
            return ((delegate* unmanaged<IDvdControl*, int>)(lpVtbl[12]))((IDvdControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ForwardScan(double dwSpeed)
        {
            return ((delegate* unmanaged<IDvdControl*, double, int>)(lpVtbl[13]))((IDvdControl*)Unsafe.AsPointer(ref this), dwSpeed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BackwardScan(double dwSpeed)
        {
            return ((delegate* unmanaged<IDvdControl*, double, int>)(lpVtbl[14]))((IDvdControl*)Unsafe.AsPointer(ref this), dwSpeed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MenuCall(DVD_MENU_ID MenuID)
        {
            return ((delegate* unmanaged<IDvdControl*, DVD_MENU_ID, int>)(lpVtbl[15]))((IDvdControl*)Unsafe.AsPointer(ref this), MenuID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Resume()
        {
            return ((delegate* unmanaged<IDvdControl*, int>)(lpVtbl[16]))((IDvdControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UpperButtonSelect()
        {
            return ((delegate* unmanaged<IDvdControl*, int>)(lpVtbl[17]))((IDvdControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LowerButtonSelect()
        {
            return ((delegate* unmanaged<IDvdControl*, int>)(lpVtbl[18]))((IDvdControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LeftButtonSelect()
        {
            return ((delegate* unmanaged<IDvdControl*, int>)(lpVtbl[19]))((IDvdControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RightButtonSelect()
        {
            return ((delegate* unmanaged<IDvdControl*, int>)(lpVtbl[20]))((IDvdControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ButtonActivate()
        {
            return ((delegate* unmanaged<IDvdControl*, int>)(lpVtbl[21]))((IDvdControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ButtonSelectAndActivate([NativeTypeName("ULONG")] uint ulButton)
        {
            return ((delegate* unmanaged<IDvdControl*, uint, int>)(lpVtbl[22]))((IDvdControl*)Unsafe.AsPointer(ref this), ulButton);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int StillOff()
        {
            return ((delegate* unmanaged<IDvdControl*, int>)(lpVtbl[23]))((IDvdControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int PauseOn()
        {
            return ((delegate* unmanaged<IDvdControl*, int>)(lpVtbl[24]))((IDvdControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int PauseOff()
        {
            return ((delegate* unmanaged<IDvdControl*, int>)(lpVtbl[25]))((IDvdControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MenuLanguageSelect([NativeTypeName("LCID")] uint Language)
        {
            return ((delegate* unmanaged<IDvdControl*, uint, int>)(lpVtbl[26]))((IDvdControl*)Unsafe.AsPointer(ref this), Language);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AudioStreamChange([NativeTypeName("ULONG")] uint ulAudio)
        {
            return ((delegate* unmanaged<IDvdControl*, uint, int>)(lpVtbl[27]))((IDvdControl*)Unsafe.AsPointer(ref this), ulAudio);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SubpictureStreamChange([NativeTypeName("ULONG")] uint ulSubPicture, [NativeTypeName("BOOL")] int bDisplay)
        {
            return ((delegate* unmanaged<IDvdControl*, uint, int, int>)(lpVtbl[28]))((IDvdControl*)Unsafe.AsPointer(ref this), ulSubPicture, bDisplay);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AngleChange([NativeTypeName("ULONG")] uint ulAngle)
        {
            return ((delegate* unmanaged<IDvdControl*, uint, int>)(lpVtbl[29]))((IDvdControl*)Unsafe.AsPointer(ref this), ulAngle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ParentalLevelSelect([NativeTypeName("ULONG")] uint ulParentalLevel)
        {
            return ((delegate* unmanaged<IDvdControl*, uint, int>)(lpVtbl[30]))((IDvdControl*)Unsafe.AsPointer(ref this), ulParentalLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ParentalCountrySelect([NativeTypeName("WORD")] ushort wCountry)
        {
            return ((delegate* unmanaged<IDvdControl*, ushort, int>)(lpVtbl[31]))((IDvdControl*)Unsafe.AsPointer(ref this), wCountry);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int KaraokeAudioPresentationModeChange([NativeTypeName("ULONG")] uint ulMode)
        {
            return ((delegate* unmanaged<IDvdControl*, uint, int>)(lpVtbl[32]))((IDvdControl*)Unsafe.AsPointer(ref this), ulMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int VideoModePreferrence([NativeTypeName("ULONG")] uint ulPreferredDisplayMode)
        {
            return ((delegate* unmanaged<IDvdControl*, uint, int>)(lpVtbl[33]))((IDvdControl*)Unsafe.AsPointer(ref this), ulPreferredDisplayMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetRoot([NativeTypeName("LPCWSTR")] ushort* pszPath)
        {
            return ((delegate* unmanaged<IDvdControl*, ushort*, int>)(lpVtbl[34]))((IDvdControl*)Unsafe.AsPointer(ref this), pszPath);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MouseActivate(POINT point)
        {
            return ((delegate* unmanaged<IDvdControl*, POINT, int>)(lpVtbl[35]))((IDvdControl*)Unsafe.AsPointer(ref this), point);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MouseSelect(POINT point)
        {
            return ((delegate* unmanaged<IDvdControl*, POINT, int>)(lpVtbl[36]))((IDvdControl*)Unsafe.AsPointer(ref this), point);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ChapterPlayAutoStop([NativeTypeName("ULONG")] uint ulTitle, [NativeTypeName("ULONG")] uint ulChapter, [NativeTypeName("ULONG")] uint ulChaptersToPlay)
        {
            return ((delegate* unmanaged<IDvdControl*, uint, uint, uint, int>)(lpVtbl[37]))((IDvdControl*)Unsafe.AsPointer(ref this), ulTitle, ulChapter, ulChaptersToPlay);
        }
    }
}
