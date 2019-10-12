// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4DC583BF-3A10-438A-8722-E9765224F1F1")]
    public unsafe partial struct ID2D1SpriteBatch
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1SpriteBatch* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1SpriteBatch* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1SpriteBatch* This);

        /// <summary>Retrieve the factory associated with this resource.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetFactory(ID2D1SpriteBatch* This, ID2D1Factory** factory);

        /// <summary>Adds sprites to the end of the sprite batch.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AddSprites(ID2D1SpriteBatch* This, [NativeTypeName("UINT32")] uint spriteCount, [NativeTypeName("D2D1_RECT_F[]")] D2D_RECT_F* destinationRectangles, [NativeTypeName("D2D1_RECT_U[]")] D2D_RECT_U* sourceRectangles = null, [NativeTypeName("D2D1_COLOR_F[]")] DXGI_RGBA* colors = null, [NativeTypeName("D2D1_MATRIX_3X2_F[]")] D2D_MATRIX_3X2_F* transforms = null, [NativeTypeName("UINT32")] uint destinationRectanglesStride = 16, [NativeTypeName("UINT32")] uint sourceRectanglesStride = 16, [NativeTypeName("UINT32")] uint colorsStride = 16, [NativeTypeName("UINT32")] uint transformsStride = 24);

        /// <summary>Set properties for existing sprites. All properties not specified are unmodified.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetSprites(ID2D1SpriteBatch* This, [NativeTypeName("UINT32")] uint startIndex, [NativeTypeName("UINT32")] uint spriteCount, [NativeTypeName("D2D1_RECT_F[]")] D2D_RECT_F* destinationRectangles = null, [NativeTypeName("D2D1_RECT_U[]")] D2D_RECT_U* sourceRectangles = null, [NativeTypeName("D2D1_COLOR_F[]")] DXGI_RGBA* colors = null, [NativeTypeName("D2D1_MATRIX_3X2_F[]")] D2D_MATRIX_3X2_F* transforms = null, [NativeTypeName("UINT32")] uint destinationRectanglesStride = 16, [NativeTypeName("UINT32")] uint sourceRectanglesStride = 16, [NativeTypeName("UINT32")] uint colorsStride = 16, [NativeTypeName("UINT32")] uint transformsStride = 24);

        /// <summary>Retrieves sprite properties.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSprites(ID2D1SpriteBatch* This, [NativeTypeName("UINT32")] uint startIndex, [NativeTypeName("UINT32")] uint spriteCount, [NativeTypeName("D2D1_RECT_F[]")] D2D_RECT_F* destinationRectangles = null, [NativeTypeName("D2D1_RECT_U[]")] D2D_RECT_U* sourceRectangles = null, [NativeTypeName("D2D1_COLOR_F[]")] DXGI_RGBA* colors = null, [NativeTypeName("D2D1_MATRIX_3X2_F[]")] D2D_MATRIX_3X2_F* transforms = null);

        /// <summary>Retrieves the number of sprites in the sprite batch.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetSpriteCount(ID2D1SpriteBatch* This);

        /// <summary>Removes all sprites from the sprite batch.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _Clear(ID2D1SpriteBatch* This);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID2D1SpriteBatch* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1SpriteBatch* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1SpriteBatch* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        public void GetFactory(ID2D1Factory** factory)
        {
            fixed (ID2D1SpriteBatch* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)(This, factory);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int AddSprites([NativeTypeName("UINT32")] uint spriteCount, [NativeTypeName("D2D1_RECT_F[]")] D2D_RECT_F* destinationRectangles, [NativeTypeName("D2D1_RECT_U[]")] D2D_RECT_U* sourceRectangles = null, [NativeTypeName("D2D1_COLOR_F[]")] DXGI_RGBA* colors = null, [NativeTypeName("D2D1_MATRIX_3X2_F[]")] D2D_MATRIX_3X2_F* transforms = null, [NativeTypeName("UINT32")] uint destinationRectanglesStride = 16, [NativeTypeName("UINT32")] uint sourceRectanglesStride = 16, [NativeTypeName("UINT32")] uint colorsStride = 16, [NativeTypeName("UINT32")] uint transformsStride = 24)
        {
            fixed (ID2D1SpriteBatch* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddSprites>(lpVtbl->AddSprites)(This, spriteCount, destinationRectangles, sourceRectangles, colors, transforms, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSprites([NativeTypeName("UINT32")] uint startIndex, [NativeTypeName("UINT32")] uint spriteCount, [NativeTypeName("D2D1_RECT_F[]")] D2D_RECT_F* destinationRectangles = null, [NativeTypeName("D2D1_RECT_U[]")] D2D_RECT_U* sourceRectangles = null, [NativeTypeName("D2D1_COLOR_F[]")] DXGI_RGBA* colors = null, [NativeTypeName("D2D1_MATRIX_3X2_F[]")] D2D_MATRIX_3X2_F* transforms = null, [NativeTypeName("UINT32")] uint destinationRectanglesStride = 16, [NativeTypeName("UINT32")] uint sourceRectanglesStride = 16, [NativeTypeName("UINT32")] uint colorsStride = 16, [NativeTypeName("UINT32")] uint transformsStride = 24)
        {
            fixed (ID2D1SpriteBatch* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetSprites>(lpVtbl->SetSprites)(This, startIndex, spriteCount, destinationRectangles, sourceRectangles, colors, transforms, destinationRectanglesStride, sourceRectanglesStride, colorsStride, transformsStride);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSprites([NativeTypeName("UINT32")] uint startIndex, [NativeTypeName("UINT32")] uint spriteCount, [NativeTypeName("D2D1_RECT_F[]")] D2D_RECT_F* destinationRectangles = null, [NativeTypeName("D2D1_RECT_U[]")] D2D_RECT_U* sourceRectangles = null, [NativeTypeName("D2D1_COLOR_F[]")] DXGI_RGBA* colors = null, [NativeTypeName("D2D1_MATRIX_3X2_F[]")] D2D_MATRIX_3X2_F* transforms = null)
        {
            fixed (ID2D1SpriteBatch* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSprites>(lpVtbl->GetSprites)(This, startIndex, spriteCount, destinationRectangles, sourceRectangles, colors, transforms);
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetSpriteCount()
        {
            fixed (ID2D1SpriteBatch* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSpriteCount>(lpVtbl->GetSpriteCount)(This);
            }
        }

        public void Clear()
        {
            fixed (ID2D1SpriteBatch* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_Clear>(lpVtbl->Clear)(This);
            }
        }

        public partial struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetFactory;

            public IntPtr AddSprites;

            public IntPtr SetSprites;

            public IntPtr GetSprites;

            public IntPtr GetSpriteCount;

            public IntPtr Clear;
        }
    }
}
