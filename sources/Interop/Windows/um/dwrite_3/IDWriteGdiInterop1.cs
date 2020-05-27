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

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWriteGdiInterop1* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWriteGdiInterop1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWriteGdiInterop1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateFontFromLOGFONT(IDWriteGdiInterop1* pThis, [NativeTypeName("const LOGFONTW *")] LOGFONTW* logFont, [NativeTypeName("IDWriteFont **")] IDWriteFont** font);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ConvertFontToLOGFONT(IDWriteGdiInterop1* pThis, [NativeTypeName("IDWriteFont *")] IDWriteFont* font, [NativeTypeName("LOGFONTW *")] LOGFONTW* logFont, [NativeTypeName("BOOL *")] int* isSystemFont);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ConvertFontFaceToLOGFONT(IDWriteGdiInterop1* pThis, [NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* font, [NativeTypeName("LOGFONTW *")] LOGFONTW* logFont);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateFontFaceFromHdc(IDWriteGdiInterop1* pThis, [NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("IDWriteFontFace **")] IDWriteFontFace** fontFace);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateBitmapRenderTarget(IDWriteGdiInterop1* pThis, [NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT32")] uint width, [NativeTypeName("UINT32")] uint height, [NativeTypeName("IDWriteBitmapRenderTarget **")] IDWriteBitmapRenderTarget** renderTarget);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateFontFromLOGFONT1(IDWriteGdiInterop1* pThis, [NativeTypeName("const LOGFONTW *")] LOGFONTW* logFont, [NativeTypeName("IDWriteFontCollection *")] IDWriteFontCollection* fontCollection, [NativeTypeName("IDWriteFont **")] IDWriteFont** font);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFontSignature(IDWriteGdiInterop1* pThis, [NativeTypeName("IDWriteFont *")] IDWriteFont* font, [NativeTypeName("FONTSIGNATURE *")] FONTSIGNATURE* fontSignature);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFontSignature1(IDWriteGdiInterop1* pThis, [NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* fontFace, [NativeTypeName("FONTSIGNATURE *")] FONTSIGNATURE* fontSignature);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetMatchingFontsByLOGFONT(IDWriteGdiInterop1* pThis, [NativeTypeName("const LOGFONT *")] LOGFONTA* logFont, [NativeTypeName("IDWriteFontSet *")] IDWriteFontSet* fontSet, [NativeTypeName("IDWriteFontSet **")] IDWriteFontSet** filteredSet);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFontFromLOGFONT([NativeTypeName("const LOGFONTW *")] LOGFONTW* logFont, [NativeTypeName("IDWriteFont **")] IDWriteFont** font)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateFontFromLOGFONT>(lpVtbl->CreateFontFromLOGFONT)((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), logFont, font);
        }

        [return: NativeTypeName("HRESULT")]
        public int ConvertFontToLOGFONT([NativeTypeName("IDWriteFont *")] IDWriteFont* font, [NativeTypeName("LOGFONTW *")] LOGFONTW* logFont, [NativeTypeName("BOOL *")] int* isSystemFont)
        {
            return Marshal.GetDelegateForFunctionPointer<_ConvertFontToLOGFONT>(lpVtbl->ConvertFontToLOGFONT)((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), font, logFont, isSystemFont);
        }

        [return: NativeTypeName("HRESULT")]
        public int ConvertFontFaceToLOGFONT([NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* font, [NativeTypeName("LOGFONTW *")] LOGFONTW* logFont)
        {
            return Marshal.GetDelegateForFunctionPointer<_ConvertFontFaceToLOGFONT>(lpVtbl->ConvertFontFaceToLOGFONT)((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), font, logFont);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFontFaceFromHdc([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("IDWriteFontFace **")] IDWriteFontFace** fontFace)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateFontFaceFromHdc>(lpVtbl->CreateFontFaceFromHdc)((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), hdc, fontFace);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapRenderTarget([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT32")] uint width, [NativeTypeName("UINT32")] uint height, [NativeTypeName("IDWriteBitmapRenderTarget **")] IDWriteBitmapRenderTarget** renderTarget)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateBitmapRenderTarget>(lpVtbl->CreateBitmapRenderTarget)((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), hdc, width, height, renderTarget);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFontFromLOGFONT([NativeTypeName("const LOGFONTW *")] LOGFONTW* logFont, [NativeTypeName("IDWriteFontCollection *")] IDWriteFontCollection* fontCollection, [NativeTypeName("IDWriteFont **")] IDWriteFont** font)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateFontFromLOGFONT1>(lpVtbl->CreateFontFromLOGFONT1)((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), logFont, fontCollection, font);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontSignature([NativeTypeName("IDWriteFont *")] IDWriteFont* font, [NativeTypeName("FONTSIGNATURE *")] FONTSIGNATURE* fontSignature)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontSignature>(lpVtbl->GetFontSignature)((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), font, fontSignature);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontSignature([NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* fontFace, [NativeTypeName("FONTSIGNATURE *")] FONTSIGNATURE* fontSignature)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFontSignature1>(lpVtbl->GetFontSignature1)((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), fontFace, fontSignature);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMatchingFontsByLOGFONT([NativeTypeName("const LOGFONT *")] LOGFONTA* logFont, [NativeTypeName("IDWriteFontSet *")] IDWriteFontSet* fontSet, [NativeTypeName("IDWriteFontSet **")] IDWriteFontSet** filteredSet)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetMatchingFontsByLOGFONT>(lpVtbl->GetMatchingFontsByLOGFONT)((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), logFont, fontSet, filteredSet);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (const LOGFONTW *, IDWriteFont **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateFontFromLOGFONT;

            [NativeTypeName("HRESULT (IDWriteFont *, LOGFONTW *, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr ConvertFontToLOGFONT;

            [NativeTypeName("HRESULT (IDWriteFontFace *, LOGFONTW *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr ConvertFontFaceToLOGFONT;

            [NativeTypeName("HRESULT (HDC, IDWriteFontFace **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateFontFaceFromHdc;

            [NativeTypeName("HRESULT (HDC, UINT32, UINT32, IDWriteBitmapRenderTarget **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateBitmapRenderTarget;

            [NativeTypeName("HRESULT (const LOGFONTW *, IDWriteFontCollection *, IDWriteFont **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr CreateFontFromLOGFONT1;

            [NativeTypeName("HRESULT (IDWriteFont *, FONTSIGNATURE *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFontSignature;

            [NativeTypeName("HRESULT (IDWriteFontFace *, FONTSIGNATURE *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFontSignature1;

            [NativeTypeName("HRESULT (const LOGFONT *, IDWriteFontSet *, IDWriteFontSet **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetMatchingFontsByLOGFONT;
        }
    }
}
