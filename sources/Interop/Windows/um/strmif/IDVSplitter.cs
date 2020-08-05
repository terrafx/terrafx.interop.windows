// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("92A3A302-DA7C-4A1F-BA7E-1802BB5D2D02")]
    [NativeTypeName("struct IDVSplitter : IUnknown")]
    public unsafe partial struct IDVSplitter
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDVSplitter*, Guid*, void**, int>)(lpVtbl[0]))((IDVSplitter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDVSplitter*, uint>)(lpVtbl[1]))((IDVSplitter*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDVSplitter*, uint>)(lpVtbl[2]))((IDVSplitter*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int DiscardAlternateVideoFrames(int nDiscard)
        {
            return ((delegate* stdcall<IDVSplitter*, int, int>)(lpVtbl[3]))((IDVSplitter*)Unsafe.AsPointer(ref this), nDiscard);
        }
    }
}
