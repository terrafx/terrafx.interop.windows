// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1CD4C13B-1C36-4191-A70A-7F3E611F367D")]
    [NativeTypeName("struct ITfKeyTraceEventSink : IUnknown")]
    public unsafe partial struct ITfKeyTraceEventSink
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfKeyTraceEventSink*, Guid*, void**, int>)(lpVtbl[0]))((ITfKeyTraceEventSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfKeyTraceEventSink*, uint>)(lpVtbl[1]))((ITfKeyTraceEventSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfKeyTraceEventSink*, uint>)(lpVtbl[2]))((ITfKeyTraceEventSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnKeyTraceDown([NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam)
        {
            return ((delegate* unmanaged<ITfKeyTraceEventSink*, nuint, nint, int>)(lpVtbl[3]))((ITfKeyTraceEventSink*)Unsafe.AsPointer(ref this), wParam, lParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnKeyTraceUp([NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam)
        {
            return ((delegate* unmanaged<ITfKeyTraceEventSink*, nuint, nint, int>)(lpVtbl[4]))((ITfKeyTraceEventSink*)Unsafe.AsPointer(ref this), wParam, lParam);
        }
    }
}
