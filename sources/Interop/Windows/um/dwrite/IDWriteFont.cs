// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("ACD16696-8C14-4F5D-877E-FE3FC1D32737")]
    public unsafe partial struct IDWriteFont
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDWriteFont*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFont*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDWriteFont*, uint>)(lpVtbl[1]))((IDWriteFont*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDWriteFont*, uint>)(lpVtbl[2]))((IDWriteFont*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFamily([NativeTypeName("IDWriteFontFamily **")] IDWriteFontFamily** fontFamily)
        {
            return ((delegate* stdcall<IDWriteFont*, IDWriteFontFamily**, int>)(lpVtbl[3]))((IDWriteFont*)Unsafe.AsPointer(ref this), fontFamily);
        }

        public DWRITE_FONT_WEIGHT GetWeight()
        {
            return ((delegate* stdcall<IDWriteFont*, DWRITE_FONT_WEIGHT>)(lpVtbl[4]))((IDWriteFont*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_FONT_STRETCH GetStretch()
        {
            return ((delegate* stdcall<IDWriteFont*, DWRITE_FONT_STRETCH>)(lpVtbl[5]))((IDWriteFont*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_FONT_STYLE GetStyle()
        {
            return ((delegate* stdcall<IDWriteFont*, DWRITE_FONT_STYLE>)(lpVtbl[6]))((IDWriteFont*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("BOOL")]
        public int IsSymbolFont()
        {
            return ((delegate* stdcall<IDWriteFont*, int>)(lpVtbl[7]))((IDWriteFont*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFaceNames([NativeTypeName("IDWriteLocalizedStrings **")] IDWriteLocalizedStrings** names)
        {
            return ((delegate* stdcall<IDWriteFont*, IDWriteLocalizedStrings**, int>)(lpVtbl[8]))((IDWriteFont*)Unsafe.AsPointer(ref this), names);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetInformationalStrings(DWRITE_INFORMATIONAL_STRING_ID informationalStringID, [NativeTypeName("IDWriteLocalizedStrings **")] IDWriteLocalizedStrings** informationalStrings, [NativeTypeName("BOOL *")] int* exists)
        {
            return ((delegate* stdcall<IDWriteFont*, DWRITE_INFORMATIONAL_STRING_ID, IDWriteLocalizedStrings**, int*, int>)(lpVtbl[9]))((IDWriteFont*)Unsafe.AsPointer(ref this), informationalStringID, informationalStrings, exists);
        }

        public DWRITE_FONT_SIMULATIONS GetSimulations()
        {
            return ((delegate* stdcall<IDWriteFont*, DWRITE_FONT_SIMULATIONS>)(lpVtbl[10]))((IDWriteFont*)Unsafe.AsPointer(ref this));
        }

        public void GetMetrics([NativeTypeName("DWRITE_FONT_METRICS *")] DWRITE_FONT_METRICS* fontMetrics)
        {
            ((delegate* stdcall<IDWriteFont*, DWRITE_FONT_METRICS*, void>)(lpVtbl[11]))((IDWriteFont*)Unsafe.AsPointer(ref this), fontMetrics);
        }

        [return: NativeTypeName("HRESULT")]
        public int HasCharacter([NativeTypeName("UINT32")] uint unicodeValue, [NativeTypeName("BOOL *")] int* exists)
        {
            return ((delegate* stdcall<IDWriteFont*, uint, int*, int>)(lpVtbl[12]))((IDWriteFont*)Unsafe.AsPointer(ref this), unicodeValue, exists);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFontFace([NativeTypeName("IDWriteFontFace **")] IDWriteFontFace** fontFace)
        {
            return ((delegate* stdcall<IDWriteFont*, IDWriteFontFace**, int>)(lpVtbl[13]))((IDWriteFont*)Unsafe.AsPointer(ref this), fontFace);
        }
    }
}
