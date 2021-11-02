// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0552BA5D-C835-4934-BF50-846AAA67432F")]
    [NativeTypeName("struct ITfContextKeyEventSink : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ITfContextKeyEventSink
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfContextKeyEventSink*, Guid*, void**, int>)(lpVtbl[0]))((ITfContextKeyEventSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfContextKeyEventSink*, uint>)(lpVtbl[1]))((ITfContextKeyEventSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfContextKeyEventSink*, uint>)(lpVtbl[2]))((ITfContextKeyEventSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT OnKeyDown(WPARAM wParam, LPARAM lParam, BOOL* pfEaten)
        {
            return ((delegate* unmanaged<ITfContextKeyEventSink*, WPARAM, LPARAM, BOOL*, int>)(lpVtbl[3]))((ITfContextKeyEventSink*)Unsafe.AsPointer(ref this), wParam, lParam, pfEaten);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT OnKeyUp(WPARAM wParam, LPARAM lParam, BOOL* pfEaten)
        {
            return ((delegate* unmanaged<ITfContextKeyEventSink*, WPARAM, LPARAM, BOOL*, int>)(lpVtbl[4]))((ITfContextKeyEventSink*)Unsafe.AsPointer(ref this), wParam, lParam, pfEaten);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT OnTestKeyDown(WPARAM wParam, LPARAM lParam, BOOL* pfEaten)
        {
            return ((delegate* unmanaged<ITfContextKeyEventSink*, WPARAM, LPARAM, BOOL*, int>)(lpVtbl[5]))((ITfContextKeyEventSink*)Unsafe.AsPointer(ref this), wParam, lParam, pfEaten);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT OnTestKeyUp(WPARAM wParam, LPARAM lParam, BOOL* pfEaten)
        {
            return ((delegate* unmanaged<ITfContextKeyEventSink*, WPARAM, LPARAM, BOOL*, int>)(lpVtbl[6]))((ITfContextKeyEventSink*)Unsafe.AsPointer(ref this), wParam, lParam, pfEaten);
        }
    }
}
