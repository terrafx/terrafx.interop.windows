// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("2AF2D06A-DD5B-4927-A0B4-54F19C91FADE")]
    [NativeTypeName("struct ITfTextLayoutSink : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ITfTextLayoutSink : ITfTextLayoutSink.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfTextLayoutSink*, Guid*, void**, int>)(lpVtbl[0]))((ITfTextLayoutSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfTextLayoutSink*, uint>)(lpVtbl[1]))((ITfTextLayoutSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfTextLayoutSink*, uint>)(lpVtbl[2]))((ITfTextLayoutSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT OnLayoutChange(ITfContext* pic, TfLayoutCode lcode, ITfContextView* pView)
        {
            return ((delegate* unmanaged<ITfTextLayoutSink*, ITfContext*, TfLayoutCode, ITfContextView*, int>)(lpVtbl[3]))((ITfTextLayoutSink*)Unsafe.AsPointer(ref this), pic, lcode, pView);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT OnLayoutChange(ITfContext* pic, TfLayoutCode lcode, ITfContextView* pView);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfTextLayoutSink*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITfTextLayoutSink*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITfTextLayoutSink*, uint> Release;

            [NativeTypeName("HRESULT (ITfContext *, TfLayoutCode, ITfContextView *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfTextLayoutSink*, ITfContext*, TfLayoutCode, ITfContextView*, int> OnLayoutChange;
        }
    }
}
