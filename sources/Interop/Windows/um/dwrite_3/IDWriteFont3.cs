// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("29748ED6-8C9C-4A6A-BE0B-D912E8538944")]
    [NativeTypeName("struct IDWriteFont3 : IDWriteFont2")]
    public unsafe partial struct IDWriteFont3
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDWriteFont3*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFont3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDWriteFont3*, uint>)(lpVtbl[1]))((IDWriteFont3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDWriteFont3*, uint>)(lpVtbl[2]))((IDWriteFont3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontFamily([NativeTypeName("IDWriteFontFamily **")] IDWriteFontFamily** fontFamily)
        {
            return ((delegate* stdcall<IDWriteFont3*, IDWriteFontFamily**, int>)(lpVtbl[3]))((IDWriteFont3*)Unsafe.AsPointer(ref this), fontFamily);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_FONT_WEIGHT GetWeight()
        {
            return ((delegate* stdcall<IDWriteFont3*, DWRITE_FONT_WEIGHT>)(lpVtbl[4]))((IDWriteFont3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_FONT_STRETCH GetStretch()
        {
            return ((delegate* stdcall<IDWriteFont3*, DWRITE_FONT_STRETCH>)(lpVtbl[5]))((IDWriteFont3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_FONT_STYLE GetStyle()
        {
            return ((delegate* stdcall<IDWriteFont3*, DWRITE_FONT_STYLE>)(lpVtbl[6]))((IDWriteFont3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int IsSymbolFont()
        {
            return ((delegate* stdcall<IDWriteFont3*, int>)(lpVtbl[7]))((IDWriteFont3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFaceNames([NativeTypeName("IDWriteLocalizedStrings **")] IDWriteLocalizedStrings** names)
        {
            return ((delegate* stdcall<IDWriteFont3*, IDWriteLocalizedStrings**, int>)(lpVtbl[8]))((IDWriteFont3*)Unsafe.AsPointer(ref this), names);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetInformationalStrings(DWRITE_INFORMATIONAL_STRING_ID informationalStringID, [NativeTypeName("IDWriteLocalizedStrings **")] IDWriteLocalizedStrings** informationalStrings, [NativeTypeName("BOOL *")] int* exists)
        {
            return ((delegate* stdcall<IDWriteFont3*, DWRITE_INFORMATIONAL_STRING_ID, IDWriteLocalizedStrings**, int*, int>)(lpVtbl[9]))((IDWriteFont3*)Unsafe.AsPointer(ref this), informationalStringID, informationalStrings, exists);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_FONT_SIMULATIONS GetSimulations()
        {
            return ((delegate* stdcall<IDWriteFont3*, DWRITE_FONT_SIMULATIONS>)(lpVtbl[10]))((IDWriteFont3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetMetrics([NativeTypeName("DWRITE_FONT_METRICS *")] DWRITE_FONT_METRICS* fontMetrics)
        {
            ((delegate* stdcall<IDWriteFont3*, DWRITE_FONT_METRICS*, void>)(lpVtbl[11]))((IDWriteFont3*)Unsafe.AsPointer(ref this), fontMetrics);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int HasCharacter([NativeTypeName("UINT32")] uint unicodeValue, [NativeTypeName("BOOL *")] int* exists)
        {
            return ((delegate* stdcall<IDWriteFont3*, uint, int*, int>)(lpVtbl[12]))((IDWriteFont3*)Unsafe.AsPointer(ref this), unicodeValue, exists);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFontFace([NativeTypeName("IDWriteFontFace **")] IDWriteFontFace** fontFace)
        {
            return ((delegate* stdcall<IDWriteFont3*, IDWriteFontFace**, int>)(lpVtbl[13]))((IDWriteFont3*)Unsafe.AsPointer(ref this), fontFace);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetMetrics([NativeTypeName("DWRITE_FONT_METRICS1 *")] DWRITE_FONT_METRICS1* fontMetrics)
        {
            ((delegate* stdcall<IDWriteFont3*, DWRITE_FONT_METRICS1*, void>)(lpVtbl[14]))((IDWriteFont3*)Unsafe.AsPointer(ref this), fontMetrics);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetPanose([NativeTypeName("DWRITE_PANOSE *")] DWRITE_PANOSE* panose)
        {
            ((delegate* stdcall<IDWriteFont3*, DWRITE_PANOSE*, void>)(lpVtbl[15]))((IDWriteFont3*)Unsafe.AsPointer(ref this), panose);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetUnicodeRanges([NativeTypeName("UINT32")] uint maxRangeCount, [NativeTypeName("DWRITE_UNICODE_RANGE *")] DWRITE_UNICODE_RANGE* unicodeRanges, [NativeTypeName("UINT32 *")] uint* actualRangeCount)
        {
            return ((delegate* stdcall<IDWriteFont3*, uint, DWRITE_UNICODE_RANGE*, uint*, int>)(lpVtbl[16]))((IDWriteFont3*)Unsafe.AsPointer(ref this), maxRangeCount, unicodeRanges, actualRangeCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int IsMonospacedFont()
        {
            return ((delegate* stdcall<IDWriteFont3*, int>)(lpVtbl[17]))((IDWriteFont3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int IsColorFont()
        {
            return ((delegate* stdcall<IDWriteFont3*, int>)(lpVtbl[18]))((IDWriteFont3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFontFace([NativeTypeName("IDWriteFontFace3 **")] IDWriteFontFace3** fontFace)
        {
            return ((delegate* stdcall<IDWriteFont3*, IDWriteFontFace3**, int>)(lpVtbl[19]))((IDWriteFont3*)Unsafe.AsPointer(ref this), fontFace);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int Equals([NativeTypeName("IDWriteFont *")] IDWriteFont* font)
        {
            return ((delegate* stdcall<IDWriteFont3*, IDWriteFont*, int>)(lpVtbl[20]))((IDWriteFont3*)Unsafe.AsPointer(ref this), font);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontFaceReference([NativeTypeName("IDWriteFontFaceReference **")] IDWriteFontFaceReference** fontFaceReference)
        {
            return ((delegate* stdcall<IDWriteFont3*, IDWriteFontFaceReference**, int>)(lpVtbl[21]))((IDWriteFont3*)Unsafe.AsPointer(ref this), fontFaceReference);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int HasCharacter([NativeTypeName("UINT32")] uint unicodeValue)
        {
            return ((delegate* stdcall<IDWriteFont3*, uint, int>)(lpVtbl[22]))((IDWriteFont3*)Unsafe.AsPointer(ref this), unicodeValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_LOCALITY GetLocality()
        {
            return ((delegate* stdcall<IDWriteFont3*, DWRITE_LOCALITY>)(lpVtbl[23]))((IDWriteFont3*)Unsafe.AsPointer(ref this));
        }
    }
}
