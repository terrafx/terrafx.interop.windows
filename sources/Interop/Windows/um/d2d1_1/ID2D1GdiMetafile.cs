// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2F543DC3-CFC1-4211-864F-CFD91C6F3395")]
    [NativeTypeName("struct ID2D1GdiMetafile : ID2D1Resource")]
    public unsafe partial struct ID2D1GdiMetafile
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID2D1GdiMetafile*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1GdiMetafile*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID2D1GdiMetafile*, uint>)(lpVtbl[1]))((ID2D1GdiMetafile*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID2D1GdiMetafile*, uint>)(lpVtbl[2]))((ID2D1GdiMetafile*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetFactory(ID2D1Factory** factory)
        {
            ((delegate* unmanaged<ID2D1GdiMetafile*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1GdiMetafile*)Unsafe.AsPointer(ref this), factory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Stream(ID2D1GdiMetafileSink* sink)
        {
            return ((delegate* unmanaged<ID2D1GdiMetafile*, ID2D1GdiMetafileSink*, int>)(lpVtbl[4]))((ID2D1GdiMetafile*)Unsafe.AsPointer(ref this), sink);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBounds([NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* bounds)
        {
            return ((delegate* unmanaged<ID2D1GdiMetafile*, D2D_RECT_F*, int>)(lpVtbl[5]))((ID2D1GdiMetafile*)Unsafe.AsPointer(ref this), bounds);
        }
    }
}
