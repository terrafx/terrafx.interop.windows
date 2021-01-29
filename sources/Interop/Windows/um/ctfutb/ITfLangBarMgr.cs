// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctfutb.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("87955690-E627-11D2-8DDB-00105A2799B5")]
    [NativeTypeName("struct ITfLangBarMgr : IUnknown")]
    public unsafe partial struct ITfLangBarMgr
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ITfLangBarMgr*, Guid*, void**, int>)(lpVtbl[0]))((ITfLangBarMgr*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfLangBarMgr*, uint>)(lpVtbl[1]))((ITfLangBarMgr*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfLangBarMgr*, uint>)(lpVtbl[2]))((ITfLangBarMgr*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AdviseEventSink([NativeTypeName("ITfLangBarEventSink *")] ITfLangBarEventSink* pSink, [NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return ((delegate* unmanaged<ITfLangBarMgr*, ITfLangBarEventSink*, IntPtr, uint, uint*, int>)(lpVtbl[3]))((ITfLangBarMgr*)Unsafe.AsPointer(ref this), pSink, hwnd, dwFlags, pdwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnadviseEventSink([NativeTypeName("DWORD")] uint dwCookie)
        {
            return ((delegate* unmanaged<ITfLangBarMgr*, uint, int>)(lpVtbl[4]))((ITfLangBarMgr*)Unsafe.AsPointer(ref this), dwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetThreadMarshalInterface([NativeTypeName("DWORD")] uint dwThreadId, [NativeTypeName("DWORD")] uint dwType, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("IUnknown **")] IUnknown** ppunk)
        {
            return ((delegate* unmanaged<ITfLangBarMgr*, uint, uint, Guid*, IUnknown**, int>)(lpVtbl[5]))((ITfLangBarMgr*)Unsafe.AsPointer(ref this), dwThreadId, dwType, riid, ppunk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetThreadLangBarItemMgr([NativeTypeName("DWORD")] uint dwThreadId, [NativeTypeName("ITfLangBarItemMgr **")] ITfLangBarItemMgr** pplbi, [NativeTypeName("DWORD *")] uint* pdwThreadid)
        {
            return ((delegate* unmanaged<ITfLangBarMgr*, uint, ITfLangBarItemMgr**, uint*, int>)(lpVtbl[6]))((ITfLangBarMgr*)Unsafe.AsPointer(ref this), dwThreadId, pplbi, pdwThreadid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetInputProcessorProfiles([NativeTypeName("DWORD")] uint dwThreadId, [NativeTypeName("ITfInputProcessorProfiles **")] ITfInputProcessorProfiles** ppaip, [NativeTypeName("DWORD *")] uint* pdwThreadid)
        {
            return ((delegate* unmanaged<ITfLangBarMgr*, uint, ITfInputProcessorProfiles**, uint*, int>)(lpVtbl[7]))((ITfLangBarMgr*)Unsafe.AsPointer(ref this), dwThreadId, ppaip, pdwThreadid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RestoreLastFocus([NativeTypeName("DWORD *")] uint* pdwThreadId, [NativeTypeName("BOOL")] int fPrev)
        {
            return ((delegate* unmanaged<ITfLangBarMgr*, uint*, int, int>)(lpVtbl[8]))((ITfLangBarMgr*)Unsafe.AsPointer(ref this), pdwThreadId, fPrev);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetModalInput([NativeTypeName("ITfLangBarEventSink *")] ITfLangBarEventSink* pSink, [NativeTypeName("DWORD")] uint dwThreadId, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<ITfLangBarMgr*, ITfLangBarEventSink*, uint, uint, int>)(lpVtbl[9]))((ITfLangBarMgr*)Unsafe.AsPointer(ref this), pSink, dwThreadId, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ShowFloating([NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<ITfLangBarMgr*, uint, int>)(lpVtbl[10]))((ITfLangBarMgr*)Unsafe.AsPointer(ref this), dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetShowFloatingStatus([NativeTypeName("DWORD *")] uint* pdwFlags)
        {
            return ((delegate* unmanaged<ITfLangBarMgr*, uint*, int>)(lpVtbl[11]))((ITfLangBarMgr*)Unsafe.AsPointer(ref this), pdwFlags);
        }
    }
}
