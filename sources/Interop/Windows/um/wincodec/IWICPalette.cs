// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000040-A8F2-4877-BA0A-FD2B6645FB94")]
    public unsafe partial struct IWICPalette
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICPalette*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICPalette*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICPalette*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int InitializePredefined(WICBitmapPaletteType ePaletteType, [NativeTypeName("BOOL")] int fAddTransparentColor)
        {
            return lpVtbl->InitializePredefined((IWICPalette*)Unsafe.AsPointer(ref this), ePaletteType, fAddTransparentColor);
        }

        [return: NativeTypeName("HRESULT")]
        public int InitializeCustom([NativeTypeName("WICColor *")] uint* pColors, [NativeTypeName("UINT")] uint cCount)
        {
            return lpVtbl->InitializeCustom((IWICPalette*)Unsafe.AsPointer(ref this), pColors, cCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int InitializeFromBitmap([NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* pISurface, [NativeTypeName("UINT")] uint cCount, [NativeTypeName("BOOL")] int fAddTransparentColor)
        {
            return lpVtbl->InitializeFromBitmap((IWICPalette*)Unsafe.AsPointer(ref this), pISurface, cCount, fAddTransparentColor);
        }

        [return: NativeTypeName("HRESULT")]
        public int InitializeFromPalette([NativeTypeName("IWICPalette *")] IWICPalette* pIPalette)
        {
            return lpVtbl->InitializeFromPalette((IWICPalette*)Unsafe.AsPointer(ref this), pIPalette);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetType([NativeTypeName("WICBitmapPaletteType *")] WICBitmapPaletteType* pePaletteType)
        {
            return lpVtbl->GetType((IWICPalette*)Unsafe.AsPointer(ref this), pePaletteType);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetColorCount([NativeTypeName("UINT *")] uint* pcCount)
        {
            return lpVtbl->GetColorCount((IWICPalette*)Unsafe.AsPointer(ref this), pcCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetColors([NativeTypeName("UINT")] uint cCount, [NativeTypeName("WICColor *")] uint* pColors, [NativeTypeName("UINT *")] uint* pcActualColors)
        {
            return lpVtbl->GetColors((IWICPalette*)Unsafe.AsPointer(ref this), cCount, pColors, pcActualColors);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsBlackWhite([NativeTypeName("BOOL *")] int* pfIsBlackWhite)
        {
            return lpVtbl->IsBlackWhite((IWICPalette*)Unsafe.AsPointer(ref this), pfIsBlackWhite);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsGrayscale([NativeTypeName("BOOL *")] int* pfIsGrayscale)
        {
            return lpVtbl->IsGrayscale((IWICPalette*)Unsafe.AsPointer(ref this), pfIsGrayscale);
        }

        [return: NativeTypeName("HRESULT")]
        public int HasAlpha([NativeTypeName("BOOL *")] int* pfHasAlpha)
        {
            return lpVtbl->HasAlpha((IWICPalette*)Unsafe.AsPointer(ref this), pfHasAlpha);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICPalette*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWICPalette*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWICPalette*, uint> Release;

            [NativeTypeName("HRESULT (WICBitmapPaletteType, BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IWICPalette*, WICBitmapPaletteType, int, int> InitializePredefined;

            [NativeTypeName("HRESULT (WICColor *, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<IWICPalette*, uint*, uint, int> InitializeCustom;

            [NativeTypeName("HRESULT (IWICBitmapSource *, UINT, BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IWICPalette*, IWICBitmapSource*, uint, int, int> InitializeFromBitmap;

            [NativeTypeName("HRESULT (IWICPalette *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICPalette*, IWICPalette*, int> InitializeFromPalette;

            [NativeTypeName("HRESULT (WICBitmapPaletteType *) __attribute__((stdcall))")]
            public new delegate* stdcall<IWICPalette*, WICBitmapPaletteType*, int> GetType;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICPalette*, uint*, int> GetColorCount;

            [NativeTypeName("HRESULT (UINT, WICColor *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICPalette*, uint, uint*, uint*, int> GetColors;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICPalette*, int*, int> IsBlackWhite;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICPalette*, int*, int> IsGrayscale;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICPalette*, int*, int> HasAlpha;
        }
    }
}
