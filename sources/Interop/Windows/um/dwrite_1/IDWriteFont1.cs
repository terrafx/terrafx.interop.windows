// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("ACD16696-8C14-4F5D-877E-FE3FC1D32738")]
    [NativeTypeName("struct IDWriteFont1 : IDWriteFont")]
    public unsafe partial struct IDWriteFont1
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDWriteFont1*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFont1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDWriteFont1*, uint>)(lpVtbl[1]))((IDWriteFont1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDWriteFont1*, uint>)(lpVtbl[2]))((IDWriteFont1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontFamily([NativeTypeName("IDWriteFontFamily **")] IDWriteFontFamily** fontFamily)
        {
            return ((delegate* stdcall<IDWriteFont1*, IDWriteFontFamily**, int>)(lpVtbl[3]))((IDWriteFont1*)Unsafe.AsPointer(ref this), fontFamily);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_FONT_WEIGHT GetWeight()
        {
            return ((delegate* stdcall<IDWriteFont1*, DWRITE_FONT_WEIGHT>)(lpVtbl[4]))((IDWriteFont1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_FONT_STRETCH GetStretch()
        {
            return ((delegate* stdcall<IDWriteFont1*, DWRITE_FONT_STRETCH>)(lpVtbl[5]))((IDWriteFont1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_FONT_STYLE GetStyle()
        {
            return ((delegate* stdcall<IDWriteFont1*, DWRITE_FONT_STYLE>)(lpVtbl[6]))((IDWriteFont1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int IsSymbolFont()
        {
            return ((delegate* stdcall<IDWriteFont1*, int>)(lpVtbl[7]))((IDWriteFont1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFaceNames([NativeTypeName("IDWriteLocalizedStrings **")] IDWriteLocalizedStrings** names)
        {
            return ((delegate* stdcall<IDWriteFont1*, IDWriteLocalizedStrings**, int>)(lpVtbl[8]))((IDWriteFont1*)Unsafe.AsPointer(ref this), names);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetInformationalStrings(DWRITE_INFORMATIONAL_STRING_ID informationalStringID, [NativeTypeName("IDWriteLocalizedStrings **")] IDWriteLocalizedStrings** informationalStrings, [NativeTypeName("BOOL *")] int* exists)
        {
            return ((delegate* stdcall<IDWriteFont1*, DWRITE_INFORMATIONAL_STRING_ID, IDWriteLocalizedStrings**, int*, int>)(lpVtbl[9]))((IDWriteFont1*)Unsafe.AsPointer(ref this), informationalStringID, informationalStrings, exists);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public DWRITE_FONT_SIMULATIONS GetSimulations()
        {
            return ((delegate* stdcall<IDWriteFont1*, DWRITE_FONT_SIMULATIONS>)(lpVtbl[10]))((IDWriteFont1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetMetrics([NativeTypeName("DWRITE_FONT_METRICS *")] DWRITE_FONT_METRICS* fontMetrics)
        {
            ((delegate* stdcall<IDWriteFont1*, DWRITE_FONT_METRICS*, void>)(lpVtbl[11]))((IDWriteFont1*)Unsafe.AsPointer(ref this), fontMetrics);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int HasCharacter([NativeTypeName("UINT32")] uint unicodeValue, [NativeTypeName("BOOL *")] int* exists)
        {
            return ((delegate* stdcall<IDWriteFont1*, uint, int*, int>)(lpVtbl[12]))((IDWriteFont1*)Unsafe.AsPointer(ref this), unicodeValue, exists);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFontFace([NativeTypeName("IDWriteFontFace **")] IDWriteFontFace** fontFace)
        {
            return ((delegate* stdcall<IDWriteFont1*, IDWriteFontFace**, int>)(lpVtbl[13]))((IDWriteFont1*)Unsafe.AsPointer(ref this), fontFace);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetMetrics([NativeTypeName("DWRITE_FONT_METRICS1 *")] DWRITE_FONT_METRICS1* fontMetrics)
        {
            ((delegate* stdcall<IDWriteFont1*, DWRITE_FONT_METRICS1*, void>)(lpVtbl[14]))((IDWriteFont1*)Unsafe.AsPointer(ref this), fontMetrics);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetPanose([NativeTypeName("DWRITE_PANOSE *")] DWRITE_PANOSE* panose)
        {
            ((delegate* stdcall<IDWriteFont1*, DWRITE_PANOSE*, void>)(lpVtbl[15]))((IDWriteFont1*)Unsafe.AsPointer(ref this), panose);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetUnicodeRanges([NativeTypeName("UINT32")] uint maxRangeCount, [NativeTypeName("DWRITE_UNICODE_RANGE *")] DWRITE_UNICODE_RANGE* unicodeRanges, [NativeTypeName("UINT32 *")] uint* actualRangeCount)
        {
            return ((delegate* stdcall<IDWriteFont1*, uint, DWRITE_UNICODE_RANGE*, uint*, int>)(lpVtbl[16]))((IDWriteFont1*)Unsafe.AsPointer(ref this), maxRangeCount, unicodeRanges, actualRangeCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int IsMonospacedFont()
        {
            return ((delegate* stdcall<IDWriteFont1*, int>)(lpVtbl[17]))((IDWriteFont1*)Unsafe.AsPointer(ref this));
        }
    }
}
