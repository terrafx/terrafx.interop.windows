// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("56A868A2-0AD4-11CE-B03A-0020AF0BA770")]
    [NativeTypeName("struct IMediaEventSink : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMediaEventSink
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMediaEventSink*, Guid*, void**, int>)(lpVtbl[0]))((IMediaEventSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMediaEventSink*, uint>)(lpVtbl[1]))((IMediaEventSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMediaEventSink*, uint>)(lpVtbl[2]))((IMediaEventSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Notify([NativeTypeName("long")] int EventCode, [NativeTypeName("LONG_PTR")] nint EventParam1, [NativeTypeName("LONG_PTR")] nint EventParam2)
        {
            return ((delegate* unmanaged<IMediaEventSink*, int, nint, nint, int>)(lpVtbl[3]))((IMediaEventSink*)Unsafe.AsPointer(ref this), EventCode, EventParam1, EventParam2);
        }
    }
}
