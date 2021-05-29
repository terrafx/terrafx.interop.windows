// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("708FBF70-B520-416B-B06C-2C41AB44F8BA")]
    [NativeTypeName("struct ITfEditTransactionSink : IUnknown")]
    public unsafe partial struct ITfEditTransactionSink
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfEditTransactionSink*, Guid*, void**, int>)(lpVtbl[0]))((ITfEditTransactionSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfEditTransactionSink*, uint>)(lpVtbl[1]))((ITfEditTransactionSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfEditTransactionSink*, uint>)(lpVtbl[2]))((ITfEditTransactionSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnStartEditTransaction(ITfContext* pic)
        {
            return ((delegate* unmanaged<ITfEditTransactionSink*, ITfContext*, int>)(lpVtbl[3]))((ITfEditTransactionSink*)Unsafe.AsPointer(ref this), pic);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnEndEditTransaction(ITfContext* pic)
        {
            return ((delegate* unmanaged<ITfEditTransactionSink*, ITfContext*, int>)(lpVtbl[4]))((ITfEditTransactionSink*)Unsafe.AsPointer(ref this), pic);
        }
    }
}
