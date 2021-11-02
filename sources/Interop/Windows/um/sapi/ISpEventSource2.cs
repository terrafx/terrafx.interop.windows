// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2373A435-6A4B-429E-A6AC-D4231A61975B")]
    [NativeTypeName("struct ISpEventSource2 : ISpEventSource")]
    [NativeInheritance("ISpEventSource")]
    public unsafe partial struct ISpEventSource2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpEventSource2*, Guid*, void**, int>)(lpVtbl[0]))((ISpEventSource2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpEventSource2*, uint>)(lpVtbl[1]))((ISpEventSource2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpEventSource2*, uint>)(lpVtbl[2]))((ISpEventSource2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetNotifySink(ISpNotifySink* pNotifySink)
        {
            return ((delegate* unmanaged<ISpEventSource2*, ISpNotifySink*, int>)(lpVtbl[3]))((ISpEventSource2*)Unsafe.AsPointer(ref this), pNotifySink);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetNotifyWindowMessage(HWND hWnd, uint Msg, WPARAM wParam, LPARAM lParam)
        {
            return ((delegate* unmanaged<ISpEventSource2*, HWND, uint, WPARAM, LPARAM, int>)(lpVtbl[4]))((ISpEventSource2*)Unsafe.AsPointer(ref this), hWnd, Msg, wParam, lParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetNotifyCallbackFunction([NativeTypeName("SPNOTIFYCALLBACK *")] delegate* unmanaged<WPARAM, LPARAM, void> pfnCallback, WPARAM wParam, LPARAM lParam)
        {
            return ((delegate* unmanaged<ISpEventSource2*, delegate* unmanaged<WPARAM, LPARAM, void>, WPARAM, LPARAM, int>)(lpVtbl[5]))((ISpEventSource2*)Unsafe.AsPointer(ref this), pfnCallback, wParam, lParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetNotifyCallbackInterface(ISpNotifyCallback* pSpCallback, WPARAM wParam, LPARAM lParam)
        {
            return ((delegate* unmanaged<ISpEventSource2*, ISpNotifyCallback*, WPARAM, LPARAM, int>)(lpVtbl[6]))((ISpEventSource2*)Unsafe.AsPointer(ref this), pSpCallback, wParam, lParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetNotifyWin32Event()
        {
            return ((delegate* unmanaged<ISpEventSource2*, int>)(lpVtbl[7]))((ISpEventSource2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT WaitForNotifyEvent([NativeTypeName("DWORD")] uint dwMilliseconds)
        {
            return ((delegate* unmanaged<ISpEventSource2*, uint, int>)(lpVtbl[8]))((ISpEventSource2*)Unsafe.AsPointer(ref this), dwMilliseconds);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HANDLE GetNotifyEventHandle()
        {
            return ((HANDLE)(((delegate* unmanaged<ISpEventSource2*, void*>)(lpVtbl[9]))((ISpEventSource2*)Unsafe.AsPointer(ref this))));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT SetInterest([NativeTypeName("ULONGLONG")] ulong ullEventInterest, [NativeTypeName("ULONGLONG")] ulong ullQueuedInterest)
        {
            return ((delegate* unmanaged<ISpEventSource2*, ulong, ulong, int>)(lpVtbl[10]))((ISpEventSource2*)Unsafe.AsPointer(ref this), ullEventInterest, ullQueuedInterest);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetEvents([NativeTypeName("ULONG")] uint ulCount, SPEVENT* pEventArray, [NativeTypeName("ULONG *")] uint* pulFetched)
        {
            return ((delegate* unmanaged<ISpEventSource2*, uint, SPEVENT*, uint*, int>)(lpVtbl[11]))((ISpEventSource2*)Unsafe.AsPointer(ref this), ulCount, pEventArray, pulFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetInfo(SPEVENTSOURCEINFO* pInfo)
        {
            return ((delegate* unmanaged<ISpEventSource2*, SPEVENTSOURCEINFO*, int>)(lpVtbl[12]))((ISpEventSource2*)Unsafe.AsPointer(ref this), pInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetEventsEx([NativeTypeName("ULONG")] uint ulCount, SPEVENTEX* pEventArray, [NativeTypeName("ULONG *")] uint* pulFetched)
        {
            return ((delegate* unmanaged<ISpEventSource2*, uint, SPEVENTEX*, uint*, int>)(lpVtbl[13]))((ISpEventSource2*)Unsafe.AsPointer(ref this), ulCount, pEventArray, pulFetched);
        }
    }
}
