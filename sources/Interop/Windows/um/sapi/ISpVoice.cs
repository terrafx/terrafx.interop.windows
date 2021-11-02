// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6C44DF74-72B9-4992-A1EC-EF996E0422D4")]
    [NativeTypeName("struct ISpVoice : ISpEventSource")]
    [NativeInheritance("ISpEventSource")]
    public unsafe partial struct ISpVoice
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpVoice*, Guid*, void**, int>)(lpVtbl[0]))((ISpVoice*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpVoice*, uint>)(lpVtbl[1]))((ISpVoice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpVoice*, uint>)(lpVtbl[2]))((ISpVoice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetNotifySink(ISpNotifySink* pNotifySink)
        {
            return ((delegate* unmanaged<ISpVoice*, ISpNotifySink*, int>)(lpVtbl[3]))((ISpVoice*)Unsafe.AsPointer(ref this), pNotifySink);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetNotifyWindowMessage(HWND hWnd, uint Msg, WPARAM wParam, LPARAM lParam)
        {
            return ((delegate* unmanaged<ISpVoice*, HWND, uint, WPARAM, LPARAM, int>)(lpVtbl[4]))((ISpVoice*)Unsafe.AsPointer(ref this), hWnd, Msg, wParam, lParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetNotifyCallbackFunction([NativeTypeName("SPNOTIFYCALLBACK *")] delegate* unmanaged<WPARAM, LPARAM, void> pfnCallback, WPARAM wParam, LPARAM lParam)
        {
            return ((delegate* unmanaged<ISpVoice*, delegate* unmanaged<WPARAM, LPARAM, void>, WPARAM, LPARAM, int>)(lpVtbl[5]))((ISpVoice*)Unsafe.AsPointer(ref this), pfnCallback, wParam, lParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetNotifyCallbackInterface(ISpNotifyCallback* pSpCallback, WPARAM wParam, LPARAM lParam)
        {
            return ((delegate* unmanaged<ISpVoice*, ISpNotifyCallback*, WPARAM, LPARAM, int>)(lpVtbl[6]))((ISpVoice*)Unsafe.AsPointer(ref this), pSpCallback, wParam, lParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetNotifyWin32Event()
        {
            return ((delegate* unmanaged<ISpVoice*, int>)(lpVtbl[7]))((ISpVoice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT WaitForNotifyEvent([NativeTypeName("DWORD")] uint dwMilliseconds)
        {
            return ((delegate* unmanaged<ISpVoice*, uint, int>)(lpVtbl[8]))((ISpVoice*)Unsafe.AsPointer(ref this), dwMilliseconds);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HANDLE GetNotifyEventHandle()
        {
            return ((HANDLE)(((delegate* unmanaged<ISpVoice*, void*>)(lpVtbl[9]))((ISpVoice*)Unsafe.AsPointer(ref this))));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT SetInterest([NativeTypeName("ULONGLONG")] ulong ullEventInterest, [NativeTypeName("ULONGLONG")] ulong ullQueuedInterest)
        {
            return ((delegate* unmanaged<ISpVoice*, ulong, ulong, int>)(lpVtbl[10]))((ISpVoice*)Unsafe.AsPointer(ref this), ullEventInterest, ullQueuedInterest);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetEvents([NativeTypeName("ULONG")] uint ulCount, SPEVENT* pEventArray, [NativeTypeName("ULONG *")] uint* pulFetched)
        {
            return ((delegate* unmanaged<ISpVoice*, uint, SPEVENT*, uint*, int>)(lpVtbl[11]))((ISpVoice*)Unsafe.AsPointer(ref this), ulCount, pEventArray, pulFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetInfo(SPEVENTSOURCEINFO* pInfo)
        {
            return ((delegate* unmanaged<ISpVoice*, SPEVENTSOURCEINFO*, int>)(lpVtbl[12]))((ISpVoice*)Unsafe.AsPointer(ref this), pInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT SetOutput(IUnknown* pUnkOutput, BOOL fAllowFormatChanges)
        {
            return ((delegate* unmanaged<ISpVoice*, IUnknown*, BOOL, int>)(lpVtbl[13]))((ISpVoice*)Unsafe.AsPointer(ref this), pUnkOutput, fAllowFormatChanges);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT GetOutputObjectToken(ISpObjectToken** ppObjectToken)
        {
            return ((delegate* unmanaged<ISpVoice*, ISpObjectToken**, int>)(lpVtbl[14]))((ISpVoice*)Unsafe.AsPointer(ref this), ppObjectToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT GetOutputStream(ISpStreamFormat** ppStream)
        {
            return ((delegate* unmanaged<ISpVoice*, ISpStreamFormat**, int>)(lpVtbl[15]))((ISpVoice*)Unsafe.AsPointer(ref this), ppStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT Pause()
        {
            return ((delegate* unmanaged<ISpVoice*, int>)(lpVtbl[16]))((ISpVoice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT Resume()
        {
            return ((delegate* unmanaged<ISpVoice*, int>)(lpVtbl[17]))((ISpVoice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT SetVoice(ISpObjectToken* pToken)
        {
            return ((delegate* unmanaged<ISpVoice*, ISpObjectToken*, int>)(lpVtbl[18]))((ISpVoice*)Unsafe.AsPointer(ref this), pToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT GetVoice(ISpObjectToken** ppToken)
        {
            return ((delegate* unmanaged<ISpVoice*, ISpObjectToken**, int>)(lpVtbl[19]))((ISpVoice*)Unsafe.AsPointer(ref this), ppToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT Speak([NativeTypeName("LPCWSTR")] ushort* pwcs, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ULONG *")] uint* pulStreamNumber)
        {
            return ((delegate* unmanaged<ISpVoice*, ushort*, uint, uint*, int>)(lpVtbl[20]))((ISpVoice*)Unsafe.AsPointer(ref this), pwcs, dwFlags, pulStreamNumber);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT SpeakStream(IStream* pStream, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ULONG *")] uint* pulStreamNumber)
        {
            return ((delegate* unmanaged<ISpVoice*, IStream*, uint, uint*, int>)(lpVtbl[21]))((ISpVoice*)Unsafe.AsPointer(ref this), pStream, dwFlags, pulStreamNumber);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT GetStatus(SPVOICESTATUS* pStatus, [NativeTypeName("LPWSTR *")] ushort** ppszLastBookmark)
        {
            return ((delegate* unmanaged<ISpVoice*, SPVOICESTATUS*, ushort**, int>)(lpVtbl[22]))((ISpVoice*)Unsafe.AsPointer(ref this), pStatus, ppszLastBookmark);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT Skip([NativeTypeName("LPCWSTR")] ushort* pItemType, [NativeTypeName("long")] int lNumItems, [NativeTypeName("ULONG *")] uint* pulNumSkipped)
        {
            return ((delegate* unmanaged<ISpVoice*, ushort*, int, uint*, int>)(lpVtbl[23]))((ISpVoice*)Unsafe.AsPointer(ref this), pItemType, lNumItems, pulNumSkipped);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT SetPriority(SPVPRIORITY ePriority)
        {
            return ((delegate* unmanaged<ISpVoice*, SPVPRIORITY, int>)(lpVtbl[24]))((ISpVoice*)Unsafe.AsPointer(ref this), ePriority);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT GetPriority(SPVPRIORITY* pePriority)
        {
            return ((delegate* unmanaged<ISpVoice*, SPVPRIORITY*, int>)(lpVtbl[25]))((ISpVoice*)Unsafe.AsPointer(ref this), pePriority);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT SetAlertBoundary(SPEVENTENUM eBoundary)
        {
            return ((delegate* unmanaged<ISpVoice*, SPEVENTENUM, int>)(lpVtbl[26]))((ISpVoice*)Unsafe.AsPointer(ref this), eBoundary);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT GetAlertBoundary(SPEVENTENUM* peBoundary)
        {
            return ((delegate* unmanaged<ISpVoice*, SPEVENTENUM*, int>)(lpVtbl[27]))((ISpVoice*)Unsafe.AsPointer(ref this), peBoundary);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT SetRate([NativeTypeName("long")] int RateAdjust)
        {
            return ((delegate* unmanaged<ISpVoice*, int, int>)(lpVtbl[28]))((ISpVoice*)Unsafe.AsPointer(ref this), RateAdjust);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT GetRate([NativeTypeName("long *")] int* pRateAdjust)
        {
            return ((delegate* unmanaged<ISpVoice*, int*, int>)(lpVtbl[29]))((ISpVoice*)Unsafe.AsPointer(ref this), pRateAdjust);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT SetVolume(ushort usVolume)
        {
            return ((delegate* unmanaged<ISpVoice*, ushort, int>)(lpVtbl[30]))((ISpVoice*)Unsafe.AsPointer(ref this), usVolume);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT GetVolume(ushort* pusVolume)
        {
            return ((delegate* unmanaged<ISpVoice*, ushort*, int>)(lpVtbl[31]))((ISpVoice*)Unsafe.AsPointer(ref this), pusVolume);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT WaitUntilDone([NativeTypeName("ULONG")] uint msTimeout)
        {
            return ((delegate* unmanaged<ISpVoice*, uint, int>)(lpVtbl[32]))((ISpVoice*)Unsafe.AsPointer(ref this), msTimeout);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT SetSyncSpeakTimeout([NativeTypeName("ULONG")] uint msTimeout)
        {
            return ((delegate* unmanaged<ISpVoice*, uint, int>)(lpVtbl[33]))((ISpVoice*)Unsafe.AsPointer(ref this), msTimeout);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT GetSyncSpeakTimeout([NativeTypeName("ULONG *")] uint* pmsTimeout)
        {
            return ((delegate* unmanaged<ISpVoice*, uint*, int>)(lpVtbl[34]))((ISpVoice*)Unsafe.AsPointer(ref this), pmsTimeout);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HANDLE SpeakCompleteEvent()
        {
            return ((HANDLE)(((delegate* unmanaged<ISpVoice*, void*>)(lpVtbl[35]))((ISpVoice*)Unsafe.AsPointer(ref this))));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HRESULT IsUISupported([NativeTypeName("LPCWSTR")] ushort* pszTypeOfUI, void* pvExtraData, [NativeTypeName("ULONG")] uint cbExtraData, BOOL* pfSupported)
        {
            return ((delegate* unmanaged<ISpVoice*, ushort*, void*, uint, BOOL*, int>)(lpVtbl[36]))((ISpVoice*)Unsafe.AsPointer(ref this), pszTypeOfUI, pvExtraData, cbExtraData, pfSupported);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public HRESULT DisplayUI(HWND hwndParent, [NativeTypeName("LPCWSTR")] ushort* pszTitle, [NativeTypeName("LPCWSTR")] ushort* pszTypeOfUI, void* pvExtraData, [NativeTypeName("ULONG")] uint cbExtraData)
        {
            return ((delegate* unmanaged<ISpVoice*, HWND, ushort*, ushort*, void*, uint, int>)(lpVtbl[37]))((ISpVoice*)Unsafe.AsPointer(ref this), hwndParent, pszTitle, pszTypeOfUI, pvExtraData, cbExtraData);
        }
    }
}
