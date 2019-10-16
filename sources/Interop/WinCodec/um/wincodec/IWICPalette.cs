// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct IWICPalette
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IWICPalette* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWICPalette* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWICPalette* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _InitializePredefined(IWICPalette* pThis, WICBitmapPaletteType ePaletteType, [NativeTypeName("BOOL")] int fAddTransparentColor);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _InitializeCustom(IWICPalette* pThis, [NativeTypeName("WICColor *")] uint* pColors, [NativeTypeName("UINT")] uint cCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _InitializeFromBitmap(IWICPalette* pThis, [NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* pISurface, [NativeTypeName("UINT")] uint cCount, [NativeTypeName("BOOL")] int fAddTransparentColor);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _InitializeFromPalette(IWICPalette* pThis, [NativeTypeName("IWICPalette *")] IWICPalette* pIPalette);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetType(IWICPalette* pThis, [NativeTypeName("WICBitmapPaletteType *")] WICBitmapPaletteType* pePaletteType);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetColorCount(IWICPalette* pThis, [NativeTypeName("UINT *")] uint* pcCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetColors(IWICPalette* pThis, [NativeTypeName("UINT")] uint cCount, [NativeTypeName("WICColor *")] uint* pColors, [NativeTypeName("UINT *")] uint* pcActualColors);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _IsBlackWhite(IWICPalette* pThis, [NativeTypeName("BOOL *")] int* pfIsBlackWhite);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _IsGrayscale(IWICPalette* pThis, [NativeTypeName("BOOL *")] int* pfIsGrayscale);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _HasAlpha(IWICPalette* pThis, [NativeTypeName("BOOL *")] int* pfHasAlpha);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IWICPalette*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IWICPalette*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IWICPalette*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int InitializePredefined(WICBitmapPaletteType ePaletteType, [NativeTypeName("BOOL")] int fAddTransparentColor)
        {
            return Marshal.GetDelegateForFunctionPointer<_InitializePredefined>(lpVtbl->InitializePredefined)((IWICPalette*)Unsafe.AsPointer(ref this), ePaletteType, fAddTransparentColor);
        }

        [return: NativeTypeName("HRESULT")]
        public int InitializeCustom([NativeTypeName("WICColor *")] uint* pColors, [NativeTypeName("UINT")] uint cCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_InitializeCustom>(lpVtbl->InitializeCustom)((IWICPalette*)Unsafe.AsPointer(ref this), pColors, cCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int InitializeFromBitmap([NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* pISurface, [NativeTypeName("UINT")] uint cCount, [NativeTypeName("BOOL")] int fAddTransparentColor)
        {
            return Marshal.GetDelegateForFunctionPointer<_InitializeFromBitmap>(lpVtbl->InitializeFromBitmap)((IWICPalette*)Unsafe.AsPointer(ref this), pISurface, cCount, fAddTransparentColor);
        }

        [return: NativeTypeName("HRESULT")]
        public int InitializeFromPalette([NativeTypeName("IWICPalette *")] IWICPalette* pIPalette)
        {
            return Marshal.GetDelegateForFunctionPointer<_InitializeFromPalette>(lpVtbl->InitializeFromPalette)((IWICPalette*)Unsafe.AsPointer(ref this), pIPalette);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetType([NativeTypeName("WICBitmapPaletteType *")] WICBitmapPaletteType* pePaletteType)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetType>(lpVtbl->GetType)((IWICPalette*)Unsafe.AsPointer(ref this), pePaletteType);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetColorCount([NativeTypeName("UINT *")] uint* pcCount)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetColorCount>(lpVtbl->GetColorCount)((IWICPalette*)Unsafe.AsPointer(ref this), pcCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetColors([NativeTypeName("UINT")] uint cCount, [NativeTypeName("WICColor *")] uint* pColors, [NativeTypeName("UINT *")] uint* pcActualColors)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetColors>(lpVtbl->GetColors)((IWICPalette*)Unsafe.AsPointer(ref this), cCount, pColors, pcActualColors);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsBlackWhite([NativeTypeName("BOOL *")] int* pfIsBlackWhite)
        {
            return Marshal.GetDelegateForFunctionPointer<_IsBlackWhite>(lpVtbl->IsBlackWhite)((IWICPalette*)Unsafe.AsPointer(ref this), pfIsBlackWhite);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsGrayscale([NativeTypeName("BOOL *")] int* pfIsGrayscale)
        {
            return Marshal.GetDelegateForFunctionPointer<_IsGrayscale>(lpVtbl->IsGrayscale)((IWICPalette*)Unsafe.AsPointer(ref this), pfIsGrayscale);
        }

        [return: NativeTypeName("HRESULT")]
        public int HasAlpha([NativeTypeName("BOOL *")] int* pfHasAlpha)
        {
            return Marshal.GetDelegateForFunctionPointer<_HasAlpha>(lpVtbl->HasAlpha)((IWICPalette*)Unsafe.AsPointer(ref this), pfHasAlpha);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (WICBitmapPaletteType, BOOL) __attribute__((stdcall))")]
            public IntPtr InitializePredefined;

            [NativeTypeName("HRESULT (WICColor *, UINT) __attribute__((stdcall))")]
            public IntPtr InitializeCustom;

            [NativeTypeName("HRESULT (IWICBitmapSource *, UINT, BOOL) __attribute__((stdcall))")]
            public IntPtr InitializeFromBitmap;

            [NativeTypeName("HRESULT (IWICPalette *) __attribute__((stdcall))")]
            public IntPtr InitializeFromPalette;

            [NativeTypeName("HRESULT (WICBitmapPaletteType *) __attribute__((stdcall))")]
            public new IntPtr GetType;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public IntPtr GetColorCount;

            [NativeTypeName("HRESULT (UINT, WICColor *, UINT *) __attribute__((stdcall))")]
            public IntPtr GetColors;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public IntPtr IsBlackWhite;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public IntPtr IsGrayscale;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public IntPtr HasAlpha;
        }
    }
}
