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

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1SpriteBatch* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1SpriteBatch* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1SpriteBatch* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetFactory(ID2D1SpriteBatch* pThis, [NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AddSprites(ID2D1SpriteBatch* pThis, [NativeTypeName("UINT32")] uint spriteCount, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangles, [NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* sourceRectangles = null, [NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* colors = null, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transforms = null, [NativeTypeName("UINT32")] uint destinationRectanglesStride = 16, [NativeTypeName("UINT32")] uint sourceRectanglesStride = 16, [NativeTypeName("UINT32")] uint colorsStride = 16, [NativeTypeName("UINT32")] uint transformsStride = 24);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetSprites(ID2D1SpriteBatch* pThis, [NativeTypeName("UINT32")] uint startIndex, [NativeTypeName("UINT32")] uint spriteCount, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangles = null, [NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* sourceRectangles = null, [NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* colors = null, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transforms = null, [NativeTypeName("UINT32")] uint destinationRectanglesStride = 16, [NativeTypeName("UINT32")] uint sourceRectanglesStride = 16, [NativeTypeName("UINT32")] uint colorsStride = 16, [NativeTypeName("UINT32")] uint transformsStride = 24);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSprites(ID2D1SpriteBatch* pThis, [NativeTypeName("UINT32")] uint startIndex, [NativeTypeName("UINT32")] uint spriteCount, [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* destinationRectangles = null, [NativeTypeName("D2D1_RECT_U *")] D2D_RECT_U* sourceRectangles = null, [NativeTypeName("D2D1_COLOR_F *")] DXGI_RGBA* colors = null, [NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transforms = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetSpriteCount(ID2D1SpriteBatch* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _Clear(ID2D1SpriteBatch* pThis);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID2D1SpriteBatch*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID2D1SpriteBatch*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID2D1SpriteBatch*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)((ID2D1SpriteBatch*)Unsafe.AsPointer(ref this), factory);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddSprites([NativeTypeName("UINT32")] uint spriteCount, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangles, [NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* sourceRectangles = null, [NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* colors = null, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transforms = null, [NativeTypeName("UINT32")] uint destinationRectanglesStride = 16, [NativeTypeName("UINT32")] uint sourceRectanglesStride = 16, [NativeTypeName("UINT32")] uint colorsStride = 16, [NativeTypeName("UINT32")] uint transformsStride = 24)
        {
            return Marshal.GetDelegateForFunctionPointer<_AddSprites>(lpVtbl->AddSprites)((ID2D1SpriteBatch*)Unsafe.AsPointer(ref this), spriteCount, destinationRectangles, sourceRectangles, colors, transforms, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSprites([NativeTypeName("UINT32")] uint startIndex, [NativeTypeName("UINT32")] uint spriteCount, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangles = null, [NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* sourceRectangles = null, [NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* colors = null, [NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transforms = null, [NativeTypeName("UINT32")] uint destinationRectanglesStride = 16, [NativeTypeName("UINT32")] uint sourceRectanglesStride = 16, [NativeTypeName("UINT32")] uint colorsStride = 16, [NativeTypeName("UINT32")] uint transformsStride = 24)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetSprites>(lpVtbl->SetSprites)((ID2D1SpriteBatch*)Unsafe.AsPointer(ref this), startIndex, spriteCount, destinationRectangles, sourceRectangles, colors, transforms, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSprites([NativeTypeName("UINT32")] uint startIndex, [NativeTypeName("UINT32")] uint spriteCount, [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* destinationRectangles = null, [NativeTypeName("D2D1_RECT_U *")] D2D_RECT_U* sourceRectangles = null, [NativeTypeName("D2D1_COLOR_F *")] DXGI_RGBA* colors = null, [NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transforms = null)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetSprites>(lpVtbl->GetSprites)((ID2D1SpriteBatch*)Unsafe.AsPointer(ref this), startIndex, spriteCount, destinationRectangles, sourceRectangles, colors, transforms);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetSpriteCount()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetSpriteCount>(lpVtbl->GetSpriteCount)((ID2D1SpriteBatch*)Unsafe.AsPointer(ref this));
        }

        public void Clear()
        {
            Marshal.GetDelegateForFunctionPointer<_Clear>(lpVtbl->Clear)((ID2D1SpriteBatch*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFactory;

            [NativeTypeName("HRESULT (UINT32, const D2D1_RECT_F *, const D2D1_RECT_U *, const D2D1_COLOR_F *, const D2D1_MATRIX_3X2_F *, UINT32, UINT32, UINT32, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr AddSprites;

            [NativeTypeName("HRESULT (UINT32, UINT32, const D2D1_RECT_F *, const D2D1_RECT_U *, const D2D1_COLOR_F *, const D2D1_MATRIX_3X2_F *, UINT32, UINT32, UINT32, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetSprites;

            [NativeTypeName("HRESULT (UINT32, UINT32, D2D1_RECT_F *, D2D1_RECT_U *, D2D1_COLOR_F *, D2D1_MATRIX_3X2_F *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetSprites;

            [NativeTypeName("UINT32 () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetSpriteCount;

            [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr Clear;
        }
    }
}
