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
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ITfKeyEventSink
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfKeyEventSink*, Guid*, void**, int>)(lpVtbl[0]))((ITfKeyEventSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfKeyEventSink*, uint>)(lpVtbl[1]))((ITfKeyEventSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfKeyEventSink*, uint>)(lpVtbl[2]))((ITfKeyEventSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT OnSetFocus(BOOL fForeground)
        {
            return ((delegate* unmanaged<ITfKeyEventSink*, BOOL, int>)(lpVtbl[3]))((ITfKeyEventSink*)Unsafe.AsPointer(ref this), fForeground);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT OnTestKeyDown(ITfContext* pic, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam, BOOL* pfEaten)
        {
            return ((delegate* unmanaged<ITfKeyEventSink*, ITfContext*, nuint, nint, BOOL*, int>)(lpVtbl[4]))((ITfKeyEventSink*)Unsafe.AsPointer(ref this), pic, wParam, lParam, pfEaten);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT OnTestKeyUp(ITfContext* pic, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam, BOOL* pfEaten)
        {
            return ((delegate* unmanaged<ITfKeyEventSink*, ITfContext*, nuint, nint, BOOL*, int>)(lpVtbl[5]))((ITfKeyEventSink*)Unsafe.AsPointer(ref this), pic, wParam, lParam, pfEaten);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT OnKeyDown(ITfContext* pic, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam, BOOL* pfEaten)
        {
            return ((delegate* unmanaged<ITfKeyEventSink*, ITfContext*, nuint, nint, BOOL*, int>)(lpVtbl[6]))((ITfKeyEventSink*)Unsafe.AsPointer(ref this), pic, wParam, lParam, pfEaten);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT OnKeyUp(ITfContext* pic, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam, BOOL* pfEaten)
        {
            return ((delegate* unmanaged<ITfKeyEventSink*, ITfContext*, nuint, nint, BOOL*, int>)(lpVtbl[7]))((ITfKeyEventSink*)Unsafe.AsPointer(ref this), pic, wParam, lParam, pfEaten);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT OnPreservedKey(ITfContext* pic, [NativeTypeName("const GUID &")] Guid* rguid, BOOL* pfEaten)
        {
            return ((delegate* unmanaged<ITfKeyEventSink*, ITfContext*, Guid*, BOOL*, int>)(lpVtbl[8]))((ITfKeyEventSink*)Unsafe.AsPointer(ref this), pic, rguid, pfEaten);
        }
    }
}
