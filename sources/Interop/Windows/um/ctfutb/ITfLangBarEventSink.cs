// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctfutb.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("18A4E900-E0AE-11D2-AFDD-00105A2799B5")]
    [NativeTypeName("struct ITfLangBarEventSink : IUnknown")]
    public unsafe partial struct ITfLangBarEventSink
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ITfLangBarEventSink*, Guid*, void**, int>)(lpVtbl[0]))((ITfLangBarEventSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfLangBarEventSink*, uint>)(lpVtbl[1]))((ITfLangBarEventSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfLangBarEventSink*, uint>)(lpVtbl[2]))((ITfLangBarEventSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnSetFocus([NativeTypeName("DWORD")] uint dwThreadId)
        {
            return ((delegate* unmanaged<ITfLangBarEventSink*, uint, int>)(lpVtbl[3]))((ITfLangBarEventSink*)Unsafe.AsPointer(ref this), dwThreadId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnThreadTerminate([NativeTypeName("DWORD")] uint dwThreadId)
        {
            return ((delegate* unmanaged<ITfLangBarEventSink*, uint, int>)(lpVtbl[4]))((ITfLangBarEventSink*)Unsafe.AsPointer(ref this), dwThreadId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnThreadItemChange([NativeTypeName("DWORD")] uint dwThreadId)
        {
            return ((delegate* unmanaged<ITfLangBarEventSink*, uint, int>)(lpVtbl[5]))((ITfLangBarEventSink*)Unsafe.AsPointer(ref this), dwThreadId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnModalInput([NativeTypeName("DWORD")] uint dwThreadId, [NativeTypeName("UINT")] uint uMsg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam)
        {
            return ((delegate* unmanaged<ITfLangBarEventSink*, uint, uint, nuint, nint, int>)(lpVtbl[6]))((ITfLangBarEventSink*)Unsafe.AsPointer(ref this), dwThreadId, uMsg, wParam, lParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ShowFloating([NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<ITfLangBarEventSink*, uint, int>)(lpVtbl[7]))((ITfLangBarEventSink*)Unsafe.AsPointer(ref this), dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetItemFloatingRect([NativeTypeName("DWORD")] uint dwThreadId, [NativeTypeName("const GUID &")] Guid* rguid, [NativeTypeName("RECT *")] RECT* prc)
        {
            return ((delegate* unmanaged<ITfLangBarEventSink*, uint, Guid*, RECT*, int>)(lpVtbl[8]))((ITfLangBarEventSink*)Unsafe.AsPointer(ref this), dwThreadId, rguid, prc);
        }
    }
}
