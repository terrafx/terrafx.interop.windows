// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A781718C-579A-4B15-A280-32B8577ACC5E")]
    [NativeTypeName("struct ITfCompositionSink : IUnknown")]
    public unsafe partial struct ITfCompositionSink
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfCompositionSink*, Guid*, void**, int>)(lpVtbl[0]))((ITfCompositionSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfCompositionSink*, uint>)(lpVtbl[1]))((ITfCompositionSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfCompositionSink*, uint>)(lpVtbl[2]))((ITfCompositionSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnCompositionTerminated([NativeTypeName("TfEditCookie")] uint ecWrite, ITfComposition* pComposition)
        {
            return ((delegate* unmanaged<ITfCompositionSink*, uint, ITfComposition*, int>)(lpVtbl[3]))((ITfCompositionSink*)Unsafe.AsPointer(ref this), ecWrite, pComposition);
        }
    }
}
