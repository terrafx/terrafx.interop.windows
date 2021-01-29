// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6E4E2102-F9CD-433D-B496-303CE03A6507")]
    [NativeTypeName("struct ITfTextInputProcessorEx : ITfTextInputProcessor")]
    public unsafe partial struct ITfTextInputProcessorEx
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ITfTextInputProcessorEx*, Guid*, void**, int>)(lpVtbl[0]))((ITfTextInputProcessorEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfTextInputProcessorEx*, uint>)(lpVtbl[1]))((ITfTextInputProcessorEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfTextInputProcessorEx*, uint>)(lpVtbl[2]))((ITfTextInputProcessorEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Activate([NativeTypeName("ITfThreadMgr *")] ITfThreadMgr* ptim, [NativeTypeName("TfClientId")] uint tid)
        {
            return ((delegate* unmanaged<ITfTextInputProcessorEx*, ITfThreadMgr*, uint, int>)(lpVtbl[3]))((ITfTextInputProcessorEx*)Unsafe.AsPointer(ref this), ptim, tid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Deactivate()
        {
            return ((delegate* unmanaged<ITfTextInputProcessorEx*, int>)(lpVtbl[4]))((ITfTextInputProcessorEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ActivateEx([NativeTypeName("ITfThreadMgr *")] ITfThreadMgr* ptim, [NativeTypeName("TfClientId")] uint tid, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<ITfTextInputProcessorEx*, ITfThreadMgr*, uint, uint, int>)(lpVtbl[5]))((ITfTextInputProcessorEx*)Unsafe.AsPointer(ref this), ptim, tid, dwFlags);
        }
    }
}
