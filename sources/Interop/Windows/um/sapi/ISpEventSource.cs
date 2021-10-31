// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BE7A9CCE-5F9E-11D2-960F-00C04F8EE628")]
    [NativeTypeName("struct ISpEventSource : ISpNotifySource")]
    [NativeInheritance("ISpNotifySource")]
    public unsafe partial struct ISpEventSource
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpEventSource*, Guid*, void**, int>)(lpVtbl[0]))((ISpEventSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpEventSource*, uint>)(lpVtbl[1]))((ISpEventSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpEventSource*, uint>)(lpVtbl[2]))((ISpEventSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetNotifySink(ISpNotifySink* pNotifySink)
        {
            return ((delegate* unmanaged<ISpEventSource*, ISpNotifySink*, int>)(lpVtbl[3]))((ISpEventSource*)Unsafe.AsPointer(ref this), pNotifySink);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetNotifyWindowMessage(HWND hWnd, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam)
        {
            return ((delegate* unmanaged<ISpEventSource*, HWND, uint, nuint, nint, int>)(lpVtbl[4]))((ISpEventSource*)Unsafe.AsPointer(ref this), hWnd, Msg, wParam, lParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetNotifyCallbackFunction([NativeTypeName("SPNOTIFYCALLBACK *")] delegate* unmanaged<nuint, nint, void> pfnCallback, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam)
        {
            return ((delegate* unmanaged<ISpEventSource*, delegate* unmanaged<nuint, nint, void>, nuint, nint, int>)(lpVtbl[5]))((ISpEventSource*)Unsafe.AsPointer(ref this), pfnCallback, wParam, lParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetNotifyCallbackInterface(ISpNotifyCallback* pSpCallback, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam)
        {
            return ((delegate* unmanaged<ISpEventSource*, ISpNotifyCallback*, nuint, nint, int>)(lpVtbl[6]))((ISpEventSource*)Unsafe.AsPointer(ref this), pSpCallback, wParam, lParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetNotifyWin32Event()
        {
            return ((delegate* unmanaged<ISpEventSource*, int>)(lpVtbl[7]))((ISpEventSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT WaitForNotifyEvent([NativeTypeName("DWORD")] uint dwMilliseconds)
        {
            return ((delegate* unmanaged<ISpEventSource*, uint, int>)(lpVtbl[8]))((ISpEventSource*)Unsafe.AsPointer(ref this), dwMilliseconds);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HANDLE GetNotifyEventHandle()
        {
            return ((delegate* unmanaged<ISpEventSource*, nint>)(lpVtbl[9]))((ISpEventSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT SetInterest([NativeTypeName("ULONGLONG")] ulong ullEventInterest, [NativeTypeName("ULONGLONG")] ulong ullQueuedInterest)
        {
            return ((delegate* unmanaged<ISpEventSource*, ulong, ulong, int>)(lpVtbl[10]))((ISpEventSource*)Unsafe.AsPointer(ref this), ullEventInterest, ullQueuedInterest);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetEvents([NativeTypeName("ULONG")] uint ulCount, SPEVENT* pEventArray, [NativeTypeName("ULONG *")] uint* pulFetched)
        {
            return ((delegate* unmanaged<ISpEventSource*, uint, SPEVENT*, uint*, int>)(lpVtbl[11]))((ISpEventSource*)Unsafe.AsPointer(ref this), ulCount, pEventArray, pulFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetInfo(SPEVENTSOURCEINFO* pInfo)
        {
            return ((delegate* unmanaged<ISpEventSource*, SPEVENTSOURCEINFO*, int>)(lpVtbl[12]))((ISpEventSource*)Unsafe.AsPointer(ref this), pInfo);
        }
    }
}
