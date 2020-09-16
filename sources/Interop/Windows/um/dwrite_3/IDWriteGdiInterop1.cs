// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4556BE70-3ABD-4F70-90BE-421780A6F515")]
    [NativeTypeName("struct IDWriteGdiInterop1 : IDWriteGdiInterop")]
    public unsafe partial struct IDWriteGdiInterop1
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IDWriteGdiInterop1*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDWriteGdiInterop1*, uint>)(lpVtbl[1]))((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDWriteGdiInterop1*, uint>)(lpVtbl[2]))((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFontFromLOGFONT([NativeTypeName("const LOGFONTW *")] LOGFONTW* logFont, [NativeTypeName("IDWriteFont **")] IDWriteFont** font)
        {
            return ((delegate* unmanaged<IDWriteGdiInterop1*, LOGFONTW*, IDWriteFont**, int>)(lpVtbl[3]))((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), logFont, font);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ConvertFontToLOGFONT([NativeTypeName("IDWriteFont *")] IDWriteFont* font, [NativeTypeName("LOGFONTW *")] LOGFONTW* logFont, [NativeTypeName("BOOL *")] int* isSystemFont)
        {
            return ((delegate* unmanaged<IDWriteGdiInterop1*, IDWriteFont*, LOGFONTW*, int*, int>)(lpVtbl[4]))((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), font, logFont, isSystemFont);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ConvertFontFaceToLOGFONT([NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* font, [NativeTypeName("LOGFONTW *")] LOGFONTW* logFont)
        {
            return ((delegate* unmanaged<IDWriteGdiInterop1*, IDWriteFontFace*, LOGFONTW*, int>)(lpVtbl[5]))((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), font, logFont);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFontFaceFromHdc([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("IDWriteFontFace **")] IDWriteFontFace** fontFace)
        {
            return ((delegate* unmanaged<IDWriteGdiInterop1*, IntPtr, IDWriteFontFace**, int>)(lpVtbl[6]))((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), hdc, fontFace);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapRenderTarget([NativeTypeName("HDC")] IntPtr hdc, [NativeTypeName("UINT32")] uint width, [NativeTypeName("UINT32")] uint height, [NativeTypeName("IDWriteBitmapRenderTarget **")] IDWriteBitmapRenderTarget** renderTarget)
        {
            return ((delegate* unmanaged<IDWriteGdiInterop1*, IntPtr, uint, uint, IDWriteBitmapRenderTarget**, int>)(lpVtbl[7]))((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), hdc, width, height, renderTarget);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFontFromLOGFONT([NativeTypeName("const LOGFONTW *")] LOGFONTW* logFont, [NativeTypeName("IDWriteFontCollection *")] IDWriteFontCollection* fontCollection, [NativeTypeName("IDWriteFont **")] IDWriteFont** font)
        {
            return ((delegate* unmanaged<IDWriteGdiInterop1*, LOGFONTW*, IDWriteFontCollection*, IDWriteFont**, int>)(lpVtbl[8]))((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), logFont, fontCollection, font);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontSignature([NativeTypeName("IDWriteFont *")] IDWriteFont* font, [NativeTypeName("FONTSIGNATURE *")] FONTSIGNATURE* fontSignature)
        {
            return ((delegate* unmanaged<IDWriteGdiInterop1*, IDWriteFont*, FONTSIGNATURE*, int>)(lpVtbl[9]))((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), font, fontSignature);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontSignature([NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* fontFace, [NativeTypeName("FONTSIGNATURE *")] FONTSIGNATURE* fontSignature)
        {
            return ((delegate* unmanaged<IDWriteGdiInterop1*, IDWriteFontFace*, FONTSIGNATURE*, int>)(lpVtbl[10]))((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), fontFace, fontSignature);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMatchingFontsByLOGFONT([NativeTypeName("const LOGFONT *")] LOGFONTW* logFont, [NativeTypeName("IDWriteFontSet *")] IDWriteFontSet* fontSet, [NativeTypeName("IDWriteFontSet **")] IDWriteFontSet** filteredSet)
        {
            return ((delegate* unmanaged<IDWriteGdiInterop1*, LOGFONTW*, IDWriteFontSet*, IDWriteFontSet**, int>)(lpVtbl[11]))((IDWriteGdiInterop1*)Unsafe.AsPointer(ref this), logFont, fontSet, filteredSet);
        }
    }
}
