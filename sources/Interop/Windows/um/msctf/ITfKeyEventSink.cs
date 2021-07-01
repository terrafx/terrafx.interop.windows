// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AA80E7F5-2021-11D2-93E0-0060B067B86E")]
    [NativeTypeName("struct ITfKeyEventSink : IUnknown")]
    public unsafe partial struct ITfKeyEventSink
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfKeyEventSink*, Guid*, void**, int>)(lpVtbl[0]))((ITfKeyEventSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfKeyEventSink*, uint>)(lpVtbl[1]))((ITfKeyEventSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfKeyEventSink*, uint>)(lpVtbl[2]))((ITfKeyEventSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnSetFocus([NativeTypeName("BOOL")] int fForeground)
        {
            return ((delegate* unmanaged<ITfKeyEventSink*, int, int>)(lpVtbl[3]))((ITfKeyEventSink*)Unsafe.AsPointer(ref this), fForeground);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnTestKeyDown(ITfContext* pic, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam, [NativeTypeName("BOOL *")] int* pfEaten)
        {
            return ((delegate* unmanaged<ITfKeyEventSink*, ITfContext*, nuint, nint, int*, int>)(lpVtbl[4]))((ITfKeyEventSink*)Unsafe.AsPointer(ref this), pic, wParam, lParam, pfEaten);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnTestKeyUp(ITfContext* pic, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam, [NativeTypeName("BOOL *")] int* pfEaten)
        {
            return ((delegate* unmanaged<ITfKeyEventSink*, ITfContext*, nuint, nint, int*, int>)(lpVtbl[5]))((ITfKeyEventSink*)Unsafe.AsPointer(ref this), pic, wParam, lParam, pfEaten);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnKeyDown(ITfContext* pic, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam, [NativeTypeName("BOOL *")] int* pfEaten)
        {
            return ((delegate* unmanaged<ITfKeyEventSink*, ITfContext*, nuint, nint, int*, int>)(lpVtbl[6]))((ITfKeyEventSink*)Unsafe.AsPointer(ref this), pic, wParam, lParam, pfEaten);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnKeyUp(ITfContext* pic, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam, [NativeTypeName("BOOL *")] int* pfEaten)
        {
            return ((delegate* unmanaged<ITfKeyEventSink*, ITfContext*, nuint, nint, int*, int>)(lpVtbl[7]))((ITfKeyEventSink*)Unsafe.AsPointer(ref this), pic, wParam, lParam, pfEaten);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnPreservedKey(ITfContext* pic, [NativeTypeName("const GUID &")] Guid* rguid, [NativeTypeName("BOOL *")] int* pfEaten)
        {
            return ((delegate* unmanaged<ITfKeyEventSink*, ITfContext*, Guid*, int*, int>)(lpVtbl[8]))((ITfKeyEventSink*)Unsafe.AsPointer(ref this), pic, rguid, pfEaten);
        }
    }
}
