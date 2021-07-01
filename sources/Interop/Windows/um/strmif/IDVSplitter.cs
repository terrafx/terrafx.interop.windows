// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDVSplitter*, Guid*, void**, int>)(lpVtbl[0]))((IDVSplitter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDVSplitter*, uint>)(lpVtbl[1]))((IDVSplitter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDVSplitter*, uint>)(lpVtbl[2]))((IDVSplitter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DiscardAlternateVideoFrames(int nDiscard)
        {
            return ((delegate* unmanaged<IDVSplitter*, int, int>)(lpVtbl[3]))((IDVSplitter*)Unsafe.AsPointer(ref this), nDiscard);
        }
    }
}
