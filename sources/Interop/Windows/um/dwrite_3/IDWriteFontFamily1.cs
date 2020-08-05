// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DA20D8EF-812A-4C43-9802-62EC4ABD7ADF")]
    [NativeTypeName("struct IDWriteFontFamily1 : IDWriteFontFamily")]
    public unsafe partial struct IDWriteFontFamily1
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDWriteFontFamily1*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontFamily1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDWriteFontFamily1*, uint>)(lpVtbl[1]))((IDWriteFontFamily1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDWriteFontFamily1*, uint>)(lpVtbl[2]))((IDWriteFontFamily1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontCollection([NativeTypeName("IDWriteFontCollection **")] IDWriteFontCollection** fontCollection)
        {
            return ((delegate* stdcall<IDWriteFontFamily1*, IDWriteFontCollection**, int>)(lpVtbl[3]))((IDWriteFontFamily1*)Unsafe.AsPointer(ref this), fontCollection);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetFontCount()
        {
            return ((delegate* stdcall<IDWriteFontFamily1*, uint>)(lpVtbl[4]))((IDWriteFontFamily1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFont([NativeTypeName("UINT32")] uint index, [NativeTypeName("IDWriteFont **")] IDWriteFont** font)
        {
            return ((delegate* stdcall<IDWriteFontFamily1*, uint, IDWriteFont**, int>)(lpVtbl[5]))((IDWriteFontFamily1*)Unsafe.AsPointer(ref this), index, font);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFamilyNames([NativeTypeName("IDWriteLocalizedStrings **")] IDWriteLocalizedStrings** names)
        {
            return ((delegate* stdcall<IDWriteFontFamily1*, IDWriteLocalizedStrings**, int>)(lpVtbl[6]))((IDWriteFontFamily1*)Unsafe.AsPointer(ref this), names);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFirstMatchingFont(DWRITE_FONT_WEIGHT weight, DWRITE_FONT_STRETCH stretch, DWRITE_FONT_STYLE style, [NativeTypeName("IDWriteFont **")] IDWriteFont** matchingFont)
        {
            return ((delegate* stdcall<IDWriteFontFamily1*, DWRITE_FONT_WEIGHT, DWRITE_FONT_STRETCH, DWRITE_FONT_STYLE, IDWriteFont**, int>)(lpVtbl[7]))((IDWriteFontFamily1*)Unsafe.AsPointer(ref this), weight, stretch, style, matchingFont);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMatchingFonts(DWRITE_FONT_WEIGHT weight, DWRITE_FONT_STRETCH stretch, DWRITE_FONT_STYLE style, [NativeTypeName("IDWriteFontList **")] IDWriteFontList** matchingFonts)
        {
            return ((delegate* stdcall<IDWriteFontFamily1*, DWRITE_FONT_WEIGHT, DWRITE_FONT_STRETCH, DWRITE_FONT_STYLE, IDWriteFontList**, int>)(lpVtbl[8]))((IDWriteFontFamily1*)Unsafe.AsPointer(ref this), weight, stretch, style, matchingFonts);
        }

        public DWRITE_LOCALITY GetFontLocality([NativeTypeName("UINT32")] uint listIndex)
        {
            return ((delegate* stdcall<IDWriteFontFamily1*, uint, DWRITE_LOCALITY>)(lpVtbl[9]))((IDWriteFontFamily1*)Unsafe.AsPointer(ref this), listIndex);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFont([NativeTypeName("UINT32")] uint listIndex, [NativeTypeName("IDWriteFont3 **")] IDWriteFont3** font)
        {
            return ((delegate* stdcall<IDWriteFontFamily1*, uint, IDWriteFont3**, int>)(lpVtbl[10]))((IDWriteFontFamily1*)Unsafe.AsPointer(ref this), listIndex, font);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFaceReference([NativeTypeName("UINT32")] uint listIndex, [NativeTypeName("IDWriteFontFaceReference **")] IDWriteFontFaceReference** fontFaceReference)
        {
            return ((delegate* stdcall<IDWriteFontFamily1*, uint, IDWriteFontFaceReference**, int>)(lpVtbl[11]))((IDWriteFontFamily1*)Unsafe.AsPointer(ref this), listIndex, fontFaceReference);
        }
    }
}
