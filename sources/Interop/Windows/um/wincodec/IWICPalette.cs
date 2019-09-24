// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000040-A8F2-4877-BA0A-FD2B6645FB94")]
    public unsafe struct IWICPalette
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IWICPalette* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWICPalette* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWICPalette* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _InitializePredefined(IWICPalette* This, WICBitmapPaletteType ePaletteType, [NativeTypeName("BOOL")] int fAddTransparentColor);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _InitializeCustom(IWICPalette* This, [NativeTypeName("WICColor[]")] uint* pColors, [NativeTypeName("UINT")] uint cCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _InitializeFromBitmap(IWICPalette* This, [Optional] IWICBitmapSource* pISurface, [NativeTypeName("UINT")] uint cCount, [NativeTypeName("BOOL")] int fAddTransparentColor);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _InitializeFromPalette(IWICPalette* This, IWICPalette* pIPalette = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int __GetType(IWICPalette* This, WICBitmapPaletteType* pePaletteType);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetColorCount(IWICPalette* This, [NativeTypeName("UINT")] uint* pcCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetColors(IWICPalette* This, [NativeTypeName("UINT")] uint cCount, [NativeTypeName("WICColor[]")] uint* pColors, [NativeTypeName("UINT")] uint* pcActualColors);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _IsBlackWhite(IWICPalette* This, [NativeTypeName("BOOL")] int* pfIsBlackWhite);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _IsGrayscale(IWICPalette* This, [NativeTypeName("BOOL")] int* pfIsGrayscale);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _HasAlpha(IWICPalette* This, [NativeTypeName("BOOL")] int* pfHasAlpha);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IWICPalette* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IWICPalette* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICPalette* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int InitializePredefined(WICBitmapPaletteType ePaletteType, [NativeTypeName("BOOL")] int fAddTransparentColor)
        {
            fixed (IWICPalette* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_InitializePredefined>(lpVtbl->InitializePredefined)(This, ePaletteType, fAddTransparentColor);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int InitializeCustom([NativeTypeName("WICColor[]")] uint* pColors, [NativeTypeName("UINT")] uint cCount)
        {
            fixed (IWICPalette* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_InitializeCustom>(lpVtbl->InitializeCustom)(This, pColors, cCount);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int InitializeFromBitmap([Optional] IWICBitmapSource* pISurface, [NativeTypeName("UINT")] uint cCount, [NativeTypeName("BOOL")] int fAddTransparentColor)
        {
            fixed (IWICPalette* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_InitializeFromBitmap>(lpVtbl->InitializeFromBitmap)(This, pISurface, cCount, fAddTransparentColor);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int InitializeFromPalette(IWICPalette* pIPalette = null)
        {
            fixed (IWICPalette* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_InitializeFromPalette>(lpVtbl->InitializeFromPalette)(This, pIPalette);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int _GetType(WICBitmapPaletteType* pePaletteType)
        {
            fixed (IWICPalette* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<__GetType>(lpVtbl->_GetType)(This, pePaletteType);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetColorCount([NativeTypeName("UINT")] uint* pcCount)
        {
            fixed (IWICPalette* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetColorCount>(lpVtbl->GetColorCount)(This, pcCount);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetColors([NativeTypeName("UINT")] uint cCount, [NativeTypeName("WICColor[]")] uint* pColors, [NativeTypeName("UINT")] uint* pcActualColors)
        {
            fixed (IWICPalette* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetColors>(lpVtbl->GetColors)(This, cCount, pColors, pcActualColors);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int IsBlackWhite([NativeTypeName("BOOL")] int* pfIsBlackWhite)
        {
            fixed (IWICPalette* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_IsBlackWhite>(lpVtbl->IsBlackWhite)(This, pfIsBlackWhite);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int IsGrayscale([NativeTypeName("BOOL")] int* pfIsGrayscale)
        {
            fixed (IWICPalette* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_IsGrayscale>(lpVtbl->IsGrayscale)(This, pfIsGrayscale);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int HasAlpha([NativeTypeName("BOOL")] int* pfHasAlpha)
        {
            fixed (IWICPalette* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_HasAlpha>(lpVtbl->HasAlpha)(This, pfHasAlpha);
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr InitializePredefined;

            public IntPtr InitializeCustom;

            public IntPtr InitializeFromBitmap;

            public IntPtr InitializeFromPalette;

            public IntPtr _GetType;

            public IntPtr GetColorCount;

            public IntPtr GetColors;

            public IntPtr IsBlackWhite;

            public IntPtr IsGrayscale;

            public IntPtr HasAlpha;
        }
    }
}
