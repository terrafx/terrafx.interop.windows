// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4DC583BF-3A10-438A-8722-E9765224F1F1")]
    public unsafe partial struct ID2D1SpriteBatch
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID2D1SpriteBatch*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID2D1SpriteBatch*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID2D1SpriteBatch*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            lpVtbl->GetFactory((ID2D1SpriteBatch*)Unsafe.AsPointer(ref this), factory);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddSprites([NativeTypeName("UINT32")] uint spriteCount, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangles, [NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* sourceRectangles = null, [NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* colors = null, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transforms = null, [NativeTypeName("UINT32")] uint destinationRectanglesStride = 16, [NativeTypeName("UINT32")] uint sourceRectanglesStride = 16, [NativeTypeName("UINT32")] uint colorsStride = 16, [NativeTypeName("UINT32")] uint transformsStride = 24)
        {
            return lpVtbl->AddSprites((ID2D1SpriteBatch*)Unsafe.AsPointer(ref this), spriteCount, destinationRectangles, sourceRectangles, colors, transforms, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSprites([NativeTypeName("UINT32")] uint startIndex, [NativeTypeName("UINT32")] uint spriteCount, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangles = null, [NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* sourceRectangles = null, [NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* colors = null, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transforms = null, [NativeTypeName("UINT32")] uint destinationRectanglesStride = 16, [NativeTypeName("UINT32")] uint sourceRectanglesStride = 16, [NativeTypeName("UINT32")] uint colorsStride = 16, [NativeTypeName("UINT32")] uint transformsStride = 24)
        {
            return lpVtbl->SetSprites((ID2D1SpriteBatch*)Unsafe.AsPointer(ref this), startIndex, spriteCount, destinationRectangles, sourceRectangles, colors, transforms, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSprites([NativeTypeName("UINT32")] uint startIndex, [NativeTypeName("UINT32")] uint spriteCount, [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* destinationRectangles = null, [NativeTypeName("D2D1_RECT_U *")] D2D_RECT_U* sourceRectangles = null, [NativeTypeName("D2D1_COLOR_F *")] DXGI_RGBA* colors = null, [NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transforms = null)
        {
            return lpVtbl->GetSprites((ID2D1SpriteBatch*)Unsafe.AsPointer(ref this), startIndex, spriteCount, destinationRectangles, sourceRectangles, colors, transforms);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetSpriteCount()
        {
            return lpVtbl->GetSpriteCount((ID2D1SpriteBatch*)Unsafe.AsPointer(ref this));
        }

        public void Clear()
        {
            lpVtbl->Clear((ID2D1SpriteBatch*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SpriteBatch*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SpriteBatch*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SpriteBatch*, uint> Release;

            [NativeTypeName("void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SpriteBatch*, ID2D1Factory**, void> GetFactory;

            [NativeTypeName("HRESULT (UINT32, const D2D1_RECT_F *, const D2D1_RECT_U *, const D2D1_COLOR_F *, const D2D1_MATRIX_3X2_F *, UINT32, UINT32, UINT32, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SpriteBatch*, uint, D2D_RECT_F*, D2D_RECT_U*, DXGI_RGBA*, D2D_MATRIX_3X2_F*, uint, uint, uint, uint, int> AddSprites;

            [NativeTypeName("HRESULT (UINT32, UINT32, const D2D1_RECT_F *, const D2D1_RECT_U *, const D2D1_COLOR_F *, const D2D1_MATRIX_3X2_F *, UINT32, UINT32, UINT32, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SpriteBatch*, uint, uint, D2D_RECT_F*, D2D_RECT_U*, DXGI_RGBA*, D2D_MATRIX_3X2_F*, uint, uint, uint, uint, int> SetSprites;

            [NativeTypeName("HRESULT (UINT32, UINT32, D2D1_RECT_F *, D2D1_RECT_U *, D2D1_COLOR_F *, D2D1_MATRIX_3X2_F *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SpriteBatch*, uint, uint, D2D_RECT_F*, D2D_RECT_U*, DXGI_RGBA*, D2D_MATRIX_3X2_F*, int> GetSprites;

            [NativeTypeName("UINT32 () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SpriteBatch*, uint> GetSpriteCount;

            [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1SpriteBatch*, void> Clear;
        }
    }
}
