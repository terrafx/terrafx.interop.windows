// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AA80E7F7-2021-11D2-93E0-0060B067B86E")]
    [NativeTypeName("struct ITfTextInputProcessor : IUnknown")]
    public unsafe partial struct ITfTextInputProcessor
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfTextInputProcessor*, Guid*, void**, int>)(lpVtbl[0]))((ITfTextInputProcessor*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfTextInputProcessor*, uint>)(lpVtbl[1]))((ITfTextInputProcessor*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfTextInputProcessor*, uint>)(lpVtbl[2]))((ITfTextInputProcessor*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Activate(ITfThreadMgr* ptim, [NativeTypeName("TfClientId")] uint tid)
        {
            return ((delegate* unmanaged<ITfTextInputProcessor*, ITfThreadMgr*, uint, int>)(lpVtbl[3]))((ITfTextInputProcessor*)Unsafe.AsPointer(ref this), ptim, tid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Deactivate()
        {
            return ((delegate* unmanaged<ITfTextInputProcessor*, int>)(lpVtbl[4]))((ITfTextInputProcessor*)Unsafe.AsPointer(ref this));
        }
    }
}
