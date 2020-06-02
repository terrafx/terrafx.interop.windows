// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1EDD9491-9853-4299-898F-6432983B6F3A")]
    public unsafe partial struct IDWriteGdiInterop
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDWriteGdiInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDWriteGdiInterop*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDWriteGdiInterop*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFontFromLOGFONT([NativeTypeName("const LOGFONTW *")] LOGFONTW* logFont, [NativeTypeName("IDWriteFont **")] IDWriteFont** font)
        {
            return lpVtbl->CreateFontFromLOGFONT((IDWriteGdiInterop*)Unsafe.AsPointer(ref this), logFont, font);
        }

        [return: NativeTypeName("HRESULT")]
        public int ConvertFontToLOGFONT([NativeTypeName("IDWriteFont *")] IDWriteFont* font, [NativeTypeName("LOGFONTW *")] LOGFONTW* logFont, [NativeTypeName("BOOL *")] int* isSystemFont)
        {
            return lpVtbl->ConvertFontToLOGFONT((IDWriteGdiInterop*)Unsafe.AsPointer(ref this), font, logFont, isSystemFont);
        }

        [return: NativeTypeName("HRESULT")]
        public int ConvertFontFaceToLOGFONT([NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* font, [NativeTypeName("LOGFONTW *")] LOGFONTW* logFont)
        {
            return lpVtbl->ConvertFontFaceToLOGFONT((IDWriteGdiInterop*)Unsafe.AsPointer(ref this), font, logFont);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFontFaceFromHdc([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("IDWriteFontFace **")] IDWriteFontFace** fontFace)
        {
            return lpVtbl->CreateFontFaceFromHdc((IDWriteGdiInterop*)Unsafe.AsPointer(ref this), hdc, fontFace);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapRenderTarget([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT32")] uint width, [NativeTypeName("UINT32")] uint height, [NativeTypeName("IDWriteBitmapRenderTarget **")] IDWriteBitmapRenderTarget** renderTarget)
        {
            return lpVtbl->CreateBitmapRenderTarget((IDWriteGdiInterop*)Unsafe.AsPointer(ref this), hdc, width, height, renderTarget);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteGdiInterop*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteGdiInterop*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteGdiInterop*, uint> Release;

            [NativeTypeName("HRESULT (const LOGFONTW *, IDWriteFont **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteGdiInterop*, LOGFONTW*, IDWriteFont**, int> CreateFontFromLOGFONT;

            [NativeTypeName("HRESULT (IDWriteFont *, LOGFONTW *, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteGdiInterop*, IDWriteFont*, LOGFONTW*, int*, int> ConvertFontToLOGFONT;

            [NativeTypeName("HRESULT (IDWriteFontFace *, LOGFONTW *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteGdiInterop*, IDWriteFontFace*, LOGFONTW*, int> ConvertFontFaceToLOGFONT;

            [NativeTypeName("HRESULT (HDC, IDWriteFontFace **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteGdiInterop*, IntPtr, IDWriteFontFace**, int> CreateFontFaceFromHdc;

            [NativeTypeName("HRESULT (HDC, UINT32, UINT32, IDWriteBitmapRenderTarget **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteGdiInterop*, IntPtr, uint, uint, IDWriteBitmapRenderTarget**, int> CreateBitmapRenderTarget;
        }
    }
}
