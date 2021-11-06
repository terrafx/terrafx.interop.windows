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
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ITfEditTransactionSink : ITfEditTransactionSink.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfEditTransactionSink*, Guid*, void**, int>)(lpVtbl[0]))((ITfEditTransactionSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfEditTransactionSink*, uint>)(lpVtbl[1]))((ITfEditTransactionSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfEditTransactionSink*, uint>)(lpVtbl[2]))((ITfEditTransactionSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT OnStartEditTransaction(ITfContext* pic)
        {
            return ((delegate* unmanaged<ITfEditTransactionSink*, ITfContext*, int>)(lpVtbl[3]))((ITfEditTransactionSink*)Unsafe.AsPointer(ref this), pic);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT OnEndEditTransaction(ITfContext* pic)
        {
            return ((delegate* unmanaged<ITfEditTransactionSink*, ITfContext*, int>)(lpVtbl[4]))((ITfEditTransactionSink*)Unsafe.AsPointer(ref this), pic);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT OnStartEditTransaction(ITfContext* pic);

            [VtblIndex(4)]
            HRESULT OnEndEditTransaction(ITfContext* pic);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfEditTransactionSink*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITfEditTransactionSink*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITfEditTransactionSink*, uint> Release;

            [NativeTypeName("HRESULT (ITfContext *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfEditTransactionSink*, ITfContext*, int> OnStartEditTransaction;

            [NativeTypeName("HRESULT (ITfContext *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfEditTransactionSink*, ITfContext*, int> OnEndEditTransaction;
        }
    }
}
