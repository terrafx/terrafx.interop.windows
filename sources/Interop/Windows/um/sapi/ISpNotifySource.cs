// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5EFF4AEF-8487-11D2-961C-00C04F8EE628")]
    [NativeTypeName("struct ISpNotifySource : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISpNotifySource
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpNotifySource*, Guid*, void**, int>)(lpVtbl[0]))((ISpNotifySource*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpNotifySource*, uint>)(lpVtbl[1]))((ISpNotifySource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpNotifySource*, uint>)(lpVtbl[2]))((ISpNotifySource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetNotifySink(ISpNotifySink* pNotifySink)
        {
            return ((delegate* unmanaged<ISpNotifySource*, ISpNotifySink*, int>)(lpVtbl[3]))((ISpNotifySource*)Unsafe.AsPointer(ref this), pNotifySink);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetNotifyWindowMessage(HWND hWnd, uint Msg, WPARAM wParam, LPARAM lParam)
        {
            return ((delegate* unmanaged<ISpNotifySource*, HWND, uint, WPARAM, LPARAM, int>)(lpVtbl[4]))((ISpNotifySource*)Unsafe.AsPointer(ref this), hWnd, Msg, wParam, lParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetNotifyCallbackFunction([NativeTypeName("SPNOTIFYCALLBACK *")] delegate* unmanaged<WPARAM, LPARAM, void> pfnCallback, WPARAM wParam, LPARAM lParam)
        {
            return ((delegate* unmanaged<ISpNotifySource*, delegate* unmanaged<WPARAM, LPARAM, void>, WPARAM, LPARAM, int>)(lpVtbl[5]))((ISpNotifySource*)Unsafe.AsPointer(ref this), pfnCallback, wParam, lParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetNotifyCallbackInterface(ISpNotifyCallback* pSpCallback, WPARAM wParam, LPARAM lParam)
        {
            return ((delegate* unmanaged<ISpNotifySource*, ISpNotifyCallback*, WPARAM, LPARAM, int>)(lpVtbl[6]))((ISpNotifySource*)Unsafe.AsPointer(ref this), pSpCallback, wParam, lParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetNotifyWin32Event()
        {
            return ((delegate* unmanaged<ISpNotifySource*, int>)(lpVtbl[7]))((ISpNotifySource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT WaitForNotifyEvent([NativeTypeName("DWORD")] uint dwMilliseconds)
        {
            return ((delegate* unmanaged<ISpNotifySource*, uint, int>)(lpVtbl[8]))((ISpNotifySource*)Unsafe.AsPointer(ref this), dwMilliseconds);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HANDLE GetNotifyEventHandle()
        {
            return ((HANDLE)(((delegate* unmanaged<ISpNotifySource*, void*>)(lpVtbl[9]))((ISpNotifySource*)Unsafe.AsPointer(ref this))));
        }
    }
}
