// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BE7A9CCE-5F9E-11D2-960F-00C04F8EE628")]
    [NativeTypeName("struct ISpEventSource : ISpNotifySource")]
    public unsafe partial struct ISpEventSource
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpEventSource*, Guid*, void**, int>)(lpVtbl[0]))((ISpEventSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISpEventSource*, uint>)(lpVtbl[1]))((ISpEventSource*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISpEventSource*, uint>)(lpVtbl[2]))((ISpEventSource*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetNotifySink([NativeTypeName("ISpNotifySink *")] ISpNotifySink* pNotifySink)
        {
            return ((delegate* stdcall<ISpEventSource*, ISpNotifySink*, int>)(lpVtbl[3]))((ISpEventSource*)Unsafe.AsPointer(ref this), pNotifySink);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetNotifyWindowMessage([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam)
        {
            return ((delegate* stdcall<ISpEventSource*, IntPtr, uint, nuint, nint, int>)(lpVtbl[4]))((ISpEventSource*)Unsafe.AsPointer(ref this), hWnd, Msg, wParam, lParam);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetNotifyCallbackFunction([NativeTypeName("SPNOTIFYCALLBACK *")] delegate* stdcall<nuint, nint, void>* pfnCallback, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam)
        {
            return ((delegate* stdcall<ISpEventSource*, delegate* stdcall<nuint, nint, void>*, nuint, nint, int>)(lpVtbl[5]))((ISpEventSource*)Unsafe.AsPointer(ref this), pfnCallback, wParam, lParam);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetNotifyCallbackInterface([NativeTypeName("ISpNotifyCallback *")] ISpNotifyCallback* pSpCallback, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam)
        {
            return ((delegate* stdcall<ISpEventSource*, ISpNotifyCallback*, nuint, nint, int>)(lpVtbl[6]))((ISpEventSource*)Unsafe.AsPointer(ref this), pSpCallback, wParam, lParam);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetNotifyWin32Event()
        {
            return ((delegate* stdcall<ISpEventSource*, int>)(lpVtbl[7]))((ISpEventSource*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int WaitForNotifyEvent([NativeTypeName("DWORD")] uint dwMilliseconds)
        {
            return ((delegate* stdcall<ISpEventSource*, uint, int>)(lpVtbl[8]))((ISpEventSource*)Unsafe.AsPointer(ref this), dwMilliseconds);
        }

        [return: NativeTypeName("HANDLE")]
        public IntPtr GetNotifyEventHandle()
        {
            return ((delegate* stdcall<ISpEventSource*, IntPtr>)(lpVtbl[9]))((ISpEventSource*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetInterest([NativeTypeName("ULONGLONG")] ulong ullEventInterest, [NativeTypeName("ULONGLONG")] ulong ullQueuedInterest)
        {
            return ((delegate* stdcall<ISpEventSource*, ulong, ulong, int>)(lpVtbl[10]))((ISpEventSource*)Unsafe.AsPointer(ref this), ullEventInterest, ullQueuedInterest);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEvents([NativeTypeName("ULONG")] uint ulCount, [NativeTypeName("SPEVENT *")] SPEVENT* pEventArray, [NativeTypeName("ULONG *")] uint* pulFetched)
        {
            return ((delegate* stdcall<ISpEventSource*, uint, SPEVENT*, uint*, int>)(lpVtbl[11]))((ISpEventSource*)Unsafe.AsPointer(ref this), ulCount, pEventArray, pulFetched);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetInfo([NativeTypeName("SPEVENTSOURCEINFO *")] SPEVENTSOURCEINFO* pInfo)
        {
            return ((delegate* stdcall<ISpEventSource*, SPEVENTSOURCEINFO*, int>)(lpVtbl[12]))((ISpEventSource*)Unsafe.AsPointer(ref this), pInfo);
        }
    }
}
