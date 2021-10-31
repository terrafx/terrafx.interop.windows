// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AA80E80E-2021-11D2-93E0-0060B067B86E")]
    [NativeTypeName("struct ITfThreadMgrEventSink : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ITfThreadMgrEventSink
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfThreadMgrEventSink*, Guid*, void**, int>)(lpVtbl[0]))((ITfThreadMgrEventSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfThreadMgrEventSink*, uint>)(lpVtbl[1]))((ITfThreadMgrEventSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfThreadMgrEventSink*, uint>)(lpVtbl[2]))((ITfThreadMgrEventSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT OnInitDocumentMgr(ITfDocumentMgr* pdim)
        {
            return ((delegate* unmanaged<ITfThreadMgrEventSink*, ITfDocumentMgr*, int>)(lpVtbl[3]))((ITfThreadMgrEventSink*)Unsafe.AsPointer(ref this), pdim);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT OnUninitDocumentMgr(ITfDocumentMgr* pdim)
        {
            return ((delegate* unmanaged<ITfThreadMgrEventSink*, ITfDocumentMgr*, int>)(lpVtbl[4]))((ITfThreadMgrEventSink*)Unsafe.AsPointer(ref this), pdim);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT OnSetFocus(ITfDocumentMgr* pdimFocus, ITfDocumentMgr* pdimPrevFocus)
        {
            return ((delegate* unmanaged<ITfThreadMgrEventSink*, ITfDocumentMgr*, ITfDocumentMgr*, int>)(lpVtbl[5]))((ITfThreadMgrEventSink*)Unsafe.AsPointer(ref this), pdimFocus, pdimPrevFocus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT OnPushContext(ITfContext* pic)
        {
            return ((delegate* unmanaged<ITfThreadMgrEventSink*, ITfContext*, int>)(lpVtbl[6]))((ITfThreadMgrEventSink*)Unsafe.AsPointer(ref this), pic);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT OnPopContext(ITfContext* pic)
        {
            return ((delegate* unmanaged<ITfThreadMgrEventSink*, ITfContext*, int>)(lpVtbl[7]))((ITfThreadMgrEventSink*)Unsafe.AsPointer(ref this), pic);
        }
    }
}
