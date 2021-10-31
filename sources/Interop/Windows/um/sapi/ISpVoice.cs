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
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
        [return: NativeTypeName("HRESULT")]
        public int SetNotifySink(ISpNotifySink* pNotifySink)
        {
            return ((delegate* unmanaged<ISpVoice*, ISpNotifySink*, int>)(lpVtbl[3]))((ISpVoice*)Unsafe.AsPointer(ref this), pNotifySink);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetNotifyWindowMessage([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam)
        {
            return ((delegate* unmanaged<ISpVoice*, IntPtr, uint, nuint, nint, int>)(lpVtbl[4]))((ISpVoice*)Unsafe.AsPointer(ref this), hWnd, Msg, wParam, lParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int SetNotifyCallbackFunction([NativeTypeName("SPNOTIFYCALLBACK *")] delegate* unmanaged<nuint, nint, void> pfnCallback, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam)
        {
            return ((delegate* unmanaged<ISpVoice*, delegate* unmanaged<nuint, nint, void>, nuint, nint, int>)(lpVtbl[5]))((ISpVoice*)Unsafe.AsPointer(ref this), pfnCallback, wParam, lParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int SetNotifyCallbackInterface(ISpNotifyCallback* pSpCallback, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam)
        {
            return ((delegate* unmanaged<ISpVoice*, ISpNotifyCallback*, nuint, nint, int>)(lpVtbl[6]))((ISpVoice*)Unsafe.AsPointer(ref this), pSpCallback, wParam, lParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int SetNotifyWin32Event()
        {
            return ((delegate* unmanaged<ISpVoice*, int>)(lpVtbl[7]))((ISpVoice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int WaitForNotifyEvent([NativeTypeName("DWORD")] uint dwMilliseconds)
        {
            return ((delegate* unmanaged<ISpVoice*, uint, int>)(lpVtbl[8]))((ISpVoice*)Unsafe.AsPointer(ref this), dwMilliseconds);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HANDLE")]
        public IntPtr GetNotifyEventHandle()
        {
            return ((delegate* unmanaged<ISpVoice*, IntPtr>)(lpVtbl[9]))((ISpVoice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int SetInterest([NativeTypeName("ULONGLONG")] ulong ullEventInterest, [NativeTypeName("ULONGLONG")] ulong ullQueuedInterest)
        {
            return ((delegate* unmanaged<ISpVoice*, ulong, ulong, int>)(lpVtbl[10]))((ISpVoice*)Unsafe.AsPointer(ref this), ullEventInterest, ullQueuedInterest);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int GetEvents([NativeTypeName("ULONG")] uint ulCount, SPEVENT* pEventArray, [NativeTypeName("ULONG *")] uint* pulFetched)
        {
            return ((delegate* unmanaged<ISpVoice*, uint, SPEVENT*, uint*, int>)(lpVtbl[11]))((ISpVoice*)Unsafe.AsPointer(ref this), ulCount, pEventArray, pulFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int GetInfo(SPEVENTSOURCEINFO* pInfo)
        {
            return ((delegate* unmanaged<ISpVoice*, SPEVENTSOURCEINFO*, int>)(lpVtbl[12]))((ISpVoice*)Unsafe.AsPointer(ref this), pInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int SetOutput(IUnknown* pUnkOutput, BOOL fAllowFormatChanges)
        {
            return ((delegate* unmanaged<ISpVoice*, IUnknown*, BOOL, int>)(lpVtbl[13]))((ISpVoice*)Unsafe.AsPointer(ref this), pUnkOutput, fAllowFormatChanges);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int GetOutputObjectToken(ISpObjectToken** ppObjectToken)
        {
            return ((delegate* unmanaged<ISpVoice*, ISpObjectToken**, int>)(lpVtbl[14]))((ISpVoice*)Unsafe.AsPointer(ref this), ppObjectToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int GetOutputStream(ISpStreamFormat** ppStream)
        {
            return ((delegate* unmanaged<ISpVoice*, ISpStreamFormat**, int>)(lpVtbl[15]))((ISpVoice*)Unsafe.AsPointer(ref this), ppStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int Pause()
        {
            return ((delegate* unmanaged<ISpVoice*, int>)(lpVtbl[16]))((ISpVoice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int Resume()
        {
            return ((delegate* unmanaged<ISpVoice*, int>)(lpVtbl[17]))((ISpVoice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int SetVoice(ISpObjectToken* pToken)
        {
            return ((delegate* unmanaged<ISpVoice*, ISpObjectToken*, int>)(lpVtbl[18]))((ISpVoice*)Unsafe.AsPointer(ref this), pToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int GetVoice(ISpObjectToken** ppToken)
        {
            return ((delegate* unmanaged<ISpVoice*, ISpObjectToken**, int>)(lpVtbl[19]))((ISpVoice*)Unsafe.AsPointer(ref this), ppToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int Speak([NativeTypeName("LPCWSTR")] ushort* pwcs, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ULONG *")] uint* pulStreamNumber)
        {
            return ((delegate* unmanaged<ISpVoice*, ushort*, uint, uint*, int>)(lpVtbl[20]))((ISpVoice*)Unsafe.AsPointer(ref this), pwcs, dwFlags, pulStreamNumber);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int SpeakStream(IStream* pStream, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ULONG *")] uint* pulStreamNumber)
        {
            return ((delegate* unmanaged<ISpVoice*, IStream*, uint, uint*, int>)(lpVtbl[21]))((ISpVoice*)Unsafe.AsPointer(ref this), pStream, dwFlags, pulStreamNumber);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int GetStatus(SPVOICESTATUS* pStatus, [NativeTypeName("LPWSTR *")] ushort** ppszLastBookmark)
        {
            return ((delegate* unmanaged<ISpVoice*, SPVOICESTATUS*, ushort**, int>)(lpVtbl[22]))((ISpVoice*)Unsafe.AsPointer(ref this), pStatus, ppszLastBookmark);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("LPCWSTR")] ushort* pItemType, [NativeTypeName("long")] int lNumItems, [NativeTypeName("ULONG *")] uint* pulNumSkipped)
        {
            return ((delegate* unmanaged<ISpVoice*, ushort*, int, uint*, int>)(lpVtbl[23]))((ISpVoice*)Unsafe.AsPointer(ref this), pItemType, lNumItems, pulNumSkipped);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int SetPriority(SPVPRIORITY ePriority)
        {
            return ((delegate* unmanaged<ISpVoice*, SPVPRIORITY, int>)(lpVtbl[24]))((ISpVoice*)Unsafe.AsPointer(ref this), ePriority);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int GetPriority(SPVPRIORITY* pePriority)
        {
            return ((delegate* unmanaged<ISpVoice*, SPVPRIORITY*, int>)(lpVtbl[25]))((ISpVoice*)Unsafe.AsPointer(ref this), pePriority);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int SetAlertBoundary(SPEVENTENUM eBoundary)
        {
            return ((delegate* unmanaged<ISpVoice*, SPEVENTENUM, int>)(lpVtbl[26]))((ISpVoice*)Unsafe.AsPointer(ref this), eBoundary);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int GetAlertBoundary(SPEVENTENUM* peBoundary)
        {
            return ((delegate* unmanaged<ISpVoice*, SPEVENTENUM*, int>)(lpVtbl[27]))((ISpVoice*)Unsafe.AsPointer(ref this), peBoundary);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int SetRate([NativeTypeName("long")] int RateAdjust)
        {
            return ((delegate* unmanaged<ISpVoice*, int, int>)(lpVtbl[28]))((ISpVoice*)Unsafe.AsPointer(ref this), RateAdjust);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int GetRate([NativeTypeName("long *")] int* pRateAdjust)
        {
            return ((delegate* unmanaged<ISpVoice*, int*, int>)(lpVtbl[29]))((ISpVoice*)Unsafe.AsPointer(ref this), pRateAdjust);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int SetVolume([NativeTypeName("USHORT")] ushort usVolume)
        {
            return ((delegate* unmanaged<ISpVoice*, ushort, int>)(lpVtbl[30]))((ISpVoice*)Unsafe.AsPointer(ref this), usVolume);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int GetVolume([NativeTypeName("USHORT *")] ushort* pusVolume)
        {
            return ((delegate* unmanaged<ISpVoice*, ushort*, int>)(lpVtbl[31]))((ISpVoice*)Unsafe.AsPointer(ref this), pusVolume);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        public int WaitUntilDone([NativeTypeName("ULONG")] uint msTimeout)
        {
            return ((delegate* unmanaged<ISpVoice*, uint, int>)(lpVtbl[32]))((ISpVoice*)Unsafe.AsPointer(ref this), msTimeout);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        [return: NativeTypeName("HRESULT")]
        public int SetSyncSpeakTimeout([NativeTypeName("ULONG")] uint msTimeout)
        {
            return ((delegate* unmanaged<ISpVoice*, uint, int>)(lpVtbl[33]))((ISpVoice*)Unsafe.AsPointer(ref this), msTimeout);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        [return: NativeTypeName("HRESULT")]
        public int GetSyncSpeakTimeout([NativeTypeName("ULONG *")] uint* pmsTimeout)
        {
            return ((delegate* unmanaged<ISpVoice*, uint*, int>)(lpVtbl[34]))((ISpVoice*)Unsafe.AsPointer(ref this), pmsTimeout);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        [return: NativeTypeName("HANDLE")]
        public IntPtr SpeakCompleteEvent()
        {
            return ((delegate* unmanaged<ISpVoice*, IntPtr>)(lpVtbl[35]))((ISpVoice*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        [return: NativeTypeName("HRESULT")]
        public int IsUISupported([NativeTypeName("LPCWSTR")] ushort* pszTypeOfUI, void* pvExtraData, [NativeTypeName("ULONG")] uint cbExtraData, BOOL* pfSupported)
        {
            return ((delegate* unmanaged<ISpVoice*, ushort*, void*, uint, BOOL*, int>)(lpVtbl[36]))((ISpVoice*)Unsafe.AsPointer(ref this), pszTypeOfUI, pvExtraData, cbExtraData, pfSupported);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        [return: NativeTypeName("HRESULT")]
        public int DisplayUI([NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("LPCWSTR")] ushort* pszTitle, [NativeTypeName("LPCWSTR")] ushort* pszTypeOfUI, void* pvExtraData, [NativeTypeName("ULONG")] uint cbExtraData)
        {
            return ((delegate* unmanaged<ISpVoice*, IntPtr, ushort*, ushort*, void*, uint, int>)(lpVtbl[37]))((ISpVoice*)Unsafe.AsPointer(ref this), hwndParent, pszTitle, pszTypeOfUI, pvExtraData, cbExtraData);
        }
    }
}
