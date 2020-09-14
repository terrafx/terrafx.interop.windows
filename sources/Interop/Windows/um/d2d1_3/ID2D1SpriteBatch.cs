// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4DC583BF-3A10-438A-8722-E9765224F1F1")]
    [NativeTypeName("struct ID2D1SpriteBatch : ID2D1Resource")]
    public unsafe partial struct ID2D1SpriteBatch
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ID2D1SpriteBatch*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1SpriteBatch*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID2D1SpriteBatch*, uint>)(lpVtbl[1]))((ID2D1SpriteBatch*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID2D1SpriteBatch*, uint>)(lpVtbl[2]))((ID2D1SpriteBatch*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            ((delegate* unmanaged<ID2D1SpriteBatch*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1SpriteBatch*)Unsafe.AsPointer(ref this), factory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddSprites([NativeTypeName("UINT32")] uint spriteCount, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangles, [NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* sourceRectangles = null, [NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* colors = null, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transforms = null, [NativeTypeName("UINT32")] uint destinationRectanglesStride = unchecked(16), [NativeTypeName("UINT32")] uint sourceRectanglesStride = unchecked(16), [NativeTypeName("UINT32")] uint colorsStride = unchecked(16), [NativeTypeName("UINT32")] uint transformsStride = unchecked(24))
        {
            return ((delegate* unmanaged<ID2D1SpriteBatch*, uint, D2D_RECT_F*, D2D_RECT_U*, DXGI_RGBA*, D2D_MATRIX_3X2_F*, uint, uint, uint, uint, int>)(lpVtbl[4]))((ID2D1SpriteBatch*)Unsafe.AsPointer(ref this), spriteCount, destinationRectangles, sourceRectangles, colors, transforms, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSprites([NativeTypeName("UINT32")] uint startIndex, [NativeTypeName("UINT32")] uint spriteCount, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangles = null, [NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* sourceRectangles = null, [NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* colors = null, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transforms = null, [NativeTypeName("UINT32")] uint destinationRectanglesStride = unchecked(16), [NativeTypeName("UINT32")] uint sourceRectanglesStride = unchecked(16), [NativeTypeName("UINT32")] uint colorsStride = unchecked(16), [NativeTypeName("UINT32")] uint transformsStride = unchecked(24))
        {
            return ((delegate* unmanaged<ID2D1SpriteBatch*, uint, uint, D2D_RECT_F*, D2D_RECT_U*, DXGI_RGBA*, D2D_MATRIX_3X2_F*, uint, uint, uint, uint, int>)(lpVtbl[5]))((ID2D1SpriteBatch*)Unsafe.AsPointer(ref this), startIndex, spriteCount, destinationRectangles, sourceRectangles, colors, transforms, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSprites([NativeTypeName("UINT32")] uint startIndex, [NativeTypeName("UINT32")] uint spriteCount, [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* destinationRectangles = null, [NativeTypeName("D2D1_RECT_U *")] D2D_RECT_U* sourceRectangles = null, [NativeTypeName("D2D1_COLOR_F *")] DXGI_RGBA* colors = null, [NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transforms = null)
        {
            return ((delegate* unmanaged<ID2D1SpriteBatch*, uint, uint, D2D_RECT_F*, D2D_RECT_U*, DXGI_RGBA*, D2D_MATRIX_3X2_F*, int>)(lpVtbl[6]))((ID2D1SpriteBatch*)Unsafe.AsPointer(ref this), startIndex, spriteCount, destinationRectangles, sourceRectangles, colors, transforms);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT32")]
        public uint GetSpriteCount()
        {
            return ((delegate* unmanaged<ID2D1SpriteBatch*, uint>)(lpVtbl[7]))((ID2D1SpriteBatch*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Clear()
        {
            ((delegate* unmanaged<ID2D1SpriteBatch*, void>)(lpVtbl[8]))((ID2D1SpriteBatch*)Unsafe.AsPointer(ref this));
        }
    }
}
