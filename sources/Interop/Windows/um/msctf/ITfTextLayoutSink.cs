// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2AF2D06A-DD5B-4927-A0B4-54F19C91FADE")]
    [NativeTypeName("struct ITfTextLayoutSink : IUnknown")]
    public unsafe partial struct ITfTextLayoutSink
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfTextLayoutSink*, Guid*, void**, int>)(lpVtbl[0]))((ITfTextLayoutSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfTextLayoutSink*, uint>)(lpVtbl[1]))((ITfTextLayoutSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfTextLayoutSink*, uint>)(lpVtbl[2]))((ITfTextLayoutSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnLayoutChange(ITfContext* pic, TfLayoutCode lcode, ITfContextView* pView)
        {
            return ((delegate* unmanaged<ITfTextLayoutSink*, ITfContext*, TfLayoutCode, ITfContextView*, int>)(lpVtbl[3]))((ITfTextLayoutSink*)Unsafe.AsPointer(ref this), pic, lcode, pView);
        }
    }
}
