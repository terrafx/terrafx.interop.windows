// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4556BE70-3ABD-4F70-90BE-421780A6F515")]
    public unsafe partial struct IDWriteGdiInterop1
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFontFromLOGFONT([NativeTypeName("const LOGFONTW *")] LOGFONTW* logFont, [NativeTypeName("IDWriteFont **")] IDWriteFont** font)
        {
            return lpVtbl->CreateFontFromLOGFONT((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), logFont, font);
        }

        [return: NativeTypeName("HRESULT")]
        public int ConvertFontToLOGFONT([NativeTypeName("IDWriteFont *")] IDWriteFont* font, [NativeTypeName("LOGFONTW *")] LOGFONTW* logFont, [NativeTypeName("BOOL *")] int* isSystemFont)
        {
            return lpVtbl->ConvertFontToLOGFONT((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), font, logFont, isSystemFont);
        }

        [return: NativeTypeName("HRESULT")]
        public int ConvertFontFaceToLOGFONT([NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* font, [NativeTypeName("LOGFONTW *")] LOGFONTW* logFont)
        {
            return lpVtbl->ConvertFontFaceToLOGFONT((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), font, logFont);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFontFaceFromHdc([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("IDWriteFontFace **")] IDWriteFontFace** fontFace)
        {
            return lpVtbl->CreateFontFaceFromHdc((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), hdc, fontFace);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapRenderTarget([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT32")] uint width, [NativeTypeName("UINT32")] uint height, [NativeTypeName("IDWriteBitmapRenderTarget **")] IDWriteBitmapRenderTarget** renderTarget)
        {
            return lpVtbl->CreateBitmapRenderTarget((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), hdc, width, height, renderTarget);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFontFromLOGFONT([NativeTypeName("const LOGFONTW *")] LOGFONTW* logFont, [NativeTypeName("IDWriteFontCollection *")] IDWriteFontCollection* fontCollection, [NativeTypeName("IDWriteFont **")] IDWriteFont** font)
        {
            return lpVtbl->CreateFontFromLOGFONT1((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), logFont, fontCollection, font);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontSignature([NativeTypeName("IDWriteFont *")] IDWriteFont* font, [NativeTypeName("FONTSIGNATURE *")] FONTSIGNATURE* fontSignature)
        {
            return lpVtbl->GetFontSignature((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), font, fontSignature);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontSignature([NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* fontFace, [NativeTypeName("FONTSIGNATURE *")] FONTSIGNATURE* fontSignature)
        {
            return lpVtbl->GetFontSignature1((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), fontFace, fontSignature);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMatchingFontsByLOGFONT([NativeTypeName("const LOGFONT *")] LOGFONTA* logFont, [NativeTypeName("IDWriteFontSet *")] IDWriteFontSet* fontSet, [NativeTypeName("IDWriteFontSet **")] IDWriteFontSet** filteredSet)
        {
            return lpVtbl->GetMatchingFontsByLOGFONT((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), logFont, fontSet, filteredSet);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteGdiInterop1*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteGdiInterop1*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteGdiInterop1*, uint> Release;

            [NativeTypeName("HRESULT (const LOGFONTW *, IDWriteFont **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteGdiInterop1*, LOGFONTW*, IDWriteFont**, int> CreateFontFromLOGFONT;

            [NativeTypeName("HRESULT (IDWriteFont *, LOGFONTW *, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteGdiInterop1*, IDWriteFont*, LOGFONTW*, int*, int> ConvertFontToLOGFONT;

            [NativeTypeName("HRESULT (IDWriteFontFace *, LOGFONTW *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteGdiInterop1*, IDWriteFontFace*, LOGFONTW*, int> ConvertFontFaceToLOGFONT;

            [NativeTypeName("HRESULT (HDC, IDWriteFontFace **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteGdiInterop1*, IntPtr, IDWriteFontFace**, int> CreateFontFaceFromHdc;

            [NativeTypeName("HRESULT (HDC, UINT32, UINT32, IDWriteBitmapRenderTarget **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteGdiInterop1*, IntPtr, uint, uint, IDWriteBitmapRenderTarget**, int> CreateBitmapRenderTarget;

            [NativeTypeName("HRESULT (const LOGFONTW *, IDWriteFontCollection *, IDWriteFont **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteGdiInterop1*, LOGFONTW*, IDWriteFontCollection*, IDWriteFont**, int> CreateFontFromLOGFONT1;

            [NativeTypeName("HRESULT (IDWriteFont *, FONTSIGNATURE *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteGdiInterop1*, IDWriteFont*, FONTSIGNATURE*, int> GetFontSignature;

            [NativeTypeName("HRESULT (IDWriteFontFace *, FONTSIGNATURE *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteGdiInterop1*, IDWriteFontFace*, FONTSIGNATURE*, int> GetFontSignature1;

            [NativeTypeName("HRESULT (const LOGFONT *, IDWriteFontSet *, IDWriteFontSet **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteGdiInterop1*, LOGFONTA*, IDWriteFontSet*, IDWriteFontSet**, int> GetMatchingFontsByLOGFONT;
        }
    }
}
