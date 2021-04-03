// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("01689689-7ACB-4E9B-AB7C-7EA46B12B522")]
    [NativeTypeName("struct ITfCleanupContextSink : IUnknown")]
    public unsafe partial struct ITfCleanupContextSink
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfCleanupContextSink*, Guid*, void**, int>)(lpVtbl[0]))((ITfCleanupContextSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfCleanupContextSink*, uint>)(lpVtbl[1]))((ITfCleanupContextSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfCleanupContextSink*, uint>)(lpVtbl[2]))((ITfCleanupContextSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnCleanupContext([NativeTypeName("TfEditCookie")] uint ecWrite, ITfContext* pic)
        {
            return ((delegate* unmanaged<ITfCleanupContextSink*, uint, ITfContext*, int>)(lpVtbl[3]))((ITfCleanupContextSink*)Unsafe.AsPointer(ref this), ecWrite, pic);
        }
    }
}
