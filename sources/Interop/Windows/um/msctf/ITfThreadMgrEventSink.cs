// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AA80E80E-2021-11D2-93E0-0060B067B86E")]
    [NativeTypeName("struct ITfThreadMgrEventSink : IUnknown")]
    public unsafe partial struct ITfThreadMgrEventSink
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ITfThreadMgrEventSink*, Guid*, void**, int>)(lpVtbl[0]))((ITfThreadMgrEventSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfThreadMgrEventSink*, uint>)(lpVtbl[1]))((ITfThreadMgrEventSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfThreadMgrEventSink*, uint>)(lpVtbl[2]))((ITfThreadMgrEventSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnInitDocumentMgr([NativeTypeName("ITfDocumentMgr *")] ITfDocumentMgr* pdim)
        {
            return ((delegate* unmanaged<ITfThreadMgrEventSink*, ITfDocumentMgr*, int>)(lpVtbl[3]))((ITfThreadMgrEventSink*)Unsafe.AsPointer(ref this), pdim);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnUninitDocumentMgr([NativeTypeName("ITfDocumentMgr *")] ITfDocumentMgr* pdim)
        {
            return ((delegate* unmanaged<ITfThreadMgrEventSink*, ITfDocumentMgr*, int>)(lpVtbl[4]))((ITfThreadMgrEventSink*)Unsafe.AsPointer(ref this), pdim);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnSetFocus([NativeTypeName("ITfDocumentMgr *")] ITfDocumentMgr* pdimFocus, [NativeTypeName("ITfDocumentMgr *")] ITfDocumentMgr* pdimPrevFocus)
        {
            return ((delegate* unmanaged<ITfThreadMgrEventSink*, ITfDocumentMgr*, ITfDocumentMgr*, int>)(lpVtbl[5]))((ITfThreadMgrEventSink*)Unsafe.AsPointer(ref this), pdimFocus, pdimPrevFocus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnPushContext([NativeTypeName("ITfContext *")] ITfContext* pic)
        {
            return ((delegate* unmanaged<ITfThreadMgrEventSink*, ITfContext*, int>)(lpVtbl[6]))((ITfThreadMgrEventSink*)Unsafe.AsPointer(ref this), pic);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnPopContext([NativeTypeName("ITfContext *")] ITfContext* pic)
        {
            return ((delegate* unmanaged<ITfThreadMgrEventSink*, ITfContext*, int>)(lpVtbl[7]))((ITfThreadMgrEventSink*)Unsafe.AsPointer(ref this), pic);
        }
    }
}
