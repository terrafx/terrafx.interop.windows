// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2E69F9E8-DD3F-4BF9-95BA-C04F49D788DF")]
    [NativeTypeName("struct ID2D1GdiMetafile1 : ID2D1GdiMetafile")]
    public unsafe partial struct ID2D1GdiMetafile1
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID2D1GdiMetafile1*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1GdiMetafile1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID2D1GdiMetafile1*, uint>)(lpVtbl[1]))((ID2D1GdiMetafile1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID2D1GdiMetafile1*, uint>)(lpVtbl[2]))((ID2D1GdiMetafile1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetFactory(ID2D1Factory** factory)
        {
            ((delegate* unmanaged<ID2D1GdiMetafile1*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1GdiMetafile1*)Unsafe.AsPointer(ref this), factory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Stream(ID2D1GdiMetafileSink* sink)
        {
            return ((delegate* unmanaged<ID2D1GdiMetafile1*, ID2D1GdiMetafileSink*, int>)(lpVtbl[4]))((ID2D1GdiMetafile1*)Unsafe.AsPointer(ref this), sink);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBounds([NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* bounds)
        {
            return ((delegate* unmanaged<ID2D1GdiMetafile1*, D2D_RECT_F*, int>)(lpVtbl[5]))((ID2D1GdiMetafile1*)Unsafe.AsPointer(ref this), bounds);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDpi([NativeTypeName("FLOAT *")] float* dpiX, [NativeTypeName("FLOAT *")] float* dpiY)
        {
            return ((delegate* unmanaged<ID2D1GdiMetafile1*, float*, float*, int>)(lpVtbl[6]))((ID2D1GdiMetafile1*)Unsafe.AsPointer(ref this), dpiX, dpiY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSourceBounds([NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* bounds)
        {
            return ((delegate* unmanaged<ID2D1GdiMetafile1*, D2D_RECT_F*, int>)(lpVtbl[7]))((ID2D1GdiMetafile1*)Unsafe.AsPointer(ref this), bounds);
        }
    }
}
