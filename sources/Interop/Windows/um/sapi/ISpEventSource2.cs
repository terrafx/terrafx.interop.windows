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
    public unsafe partial struct ISpEventSource2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpEventSource2*, Guid*, void**, int>)(lpVtbl[0]))((ISpEventSource2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpEventSource2*, uint>)(lpVtbl[1]))((ISpEventSource2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpEventSource2*, uint>)(lpVtbl[2]))((ISpEventSource2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetNotifySink(ISpNotifySink* pNotifySink)
        {
            return ((delegate* unmanaged<ISpEventSource2*, ISpNotifySink*, int>)(lpVtbl[3]))((ISpEventSource2*)Unsafe.AsPointer(ref this), pNotifySink);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetNotifyWindowMessage([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam)
        {
            return ((delegate* unmanaged<ISpEventSource2*, IntPtr, uint, nuint, nint, int>)(lpVtbl[4]))((ISpEventSource2*)Unsafe.AsPointer(ref this), hWnd, Msg, wParam, lParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetNotifyCallbackFunction([NativeTypeName("SPNOTIFYCALLBACK *")] delegate* unmanaged<nuint, nint, void> pfnCallback, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam)
        {
            return ((delegate* unmanaged<ISpEventSource2*, delegate* unmanaged<nuint, nint, void>, nuint, nint, int>)(lpVtbl[5]))((ISpEventSource2*)Unsafe.AsPointer(ref this), pfnCallback, wParam, lParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetNotifyCallbackInterface(ISpNotifyCallback* pSpCallback, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam)
        {
            return ((delegate* unmanaged<ISpEventSource2*, ISpNotifyCallback*, nuint, nint, int>)(lpVtbl[6]))((ISpEventSource2*)Unsafe.AsPointer(ref this), pSpCallback, wParam, lParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetNotifyWin32Event()
        {
            return ((delegate* unmanaged<ISpEventSource2*, int>)(lpVtbl[7]))((ISpEventSource2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WaitForNotifyEvent([NativeTypeName("DWORD")] uint dwMilliseconds)
        {
            return ((delegate* unmanaged<ISpEventSource2*, uint, int>)(lpVtbl[8]))((ISpEventSource2*)Unsafe.AsPointer(ref this), dwMilliseconds);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HANDLE")]
        public IntPtr GetNotifyEventHandle()
        {
            return ((delegate* unmanaged<ISpEventSource2*, IntPtr>)(lpVtbl[9]))((ISpEventSource2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetInterest([NativeTypeName("ULONGLONG")] ulong ullEventInterest, [NativeTypeName("ULONGLONG")] ulong ullQueuedInterest)
        {
            return ((delegate* unmanaged<ISpEventSource2*, ulong, ulong, int>)(lpVtbl[10]))((ISpEventSource2*)Unsafe.AsPointer(ref this), ullEventInterest, ullQueuedInterest);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetEvents([NativeTypeName("ULONG")] uint ulCount, SPEVENT* pEventArray, [NativeTypeName("ULONG *")] uint* pulFetched)
        {
            return ((delegate* unmanaged<ISpEventSource2*, uint, SPEVENT*, uint*, int>)(lpVtbl[11]))((ISpEventSource2*)Unsafe.AsPointer(ref this), ulCount, pEventArray, pulFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetInfo(SPEVENTSOURCEINFO* pInfo)
        {
            return ((delegate* unmanaged<ISpEventSource2*, SPEVENTSOURCEINFO*, int>)(lpVtbl[12]))((ISpEventSource2*)Unsafe.AsPointer(ref this), pInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetEventsEx([NativeTypeName("ULONG")] uint ulCount, SPEVENTEX* pEventArray, [NativeTypeName("ULONG *")] uint* pulFetched)
        {
            return ((delegate* unmanaged<ISpEventSource2*, uint, SPEVENTEX*, uint*, int>)(lpVtbl[13]))((ISpEventSource2*)Unsafe.AsPointer(ref this), ulCount, pEventArray, pulFetched);
        }
    }
}
