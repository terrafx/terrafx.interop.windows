// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2397599D-DD0D-4681-BD6A-F4F31EAADE77")]
    [NativeTypeName("struct IDWriteFontFallback1 : IDWriteFontFallback")]
    [NativeInheritance("IDWriteFontFallback")]
    public unsafe partial struct IDWriteFontFallback1
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDWriteFontFallback1*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontFallback1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDWriteFontFallback1*, uint>)(lpVtbl[1]))((IDWriteFontFallback1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDWriteFontFallback1*, uint>)(lpVtbl[2]))((IDWriteFontFallback1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT MapCharacters(IDWriteTextAnalysisSource* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, IDWriteFontCollection* baseFontCollection, [NativeTypeName("const wchar_t *")] ushort* baseFamilyName, DWRITE_FONT_WEIGHT baseWeight, DWRITE_FONT_STYLE baseStyle, DWRITE_FONT_STRETCH baseStretch, [NativeTypeName("UINT32 *")] uint* mappedLength, IDWriteFont** mappedFont, float* scale)
        {
            return ((delegate* unmanaged<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, ushort*, DWRITE_FONT_WEIGHT, DWRITE_FONT_STYLE, DWRITE_FONT_STRETCH, uint*, IDWriteFont**, float*, int>)(lpVtbl[3]))((IDWriteFontFallback1*)Unsafe.AsPointer(ref this), analysisSource, textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scale);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT MapCharacters(IDWriteTextAnalysisSource* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, IDWriteFontCollection* baseFontCollection, [NativeTypeName("const WCHAR *")] ushort* baseFamilyName, [NativeTypeName("const DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount, [NativeTypeName("UINT32 *")] uint* mappedLength, float* scale, IDWriteFontFace5** mappedFontFace)
        {
            return ((delegate* unmanaged<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, ushort*, DWRITE_FONT_AXIS_VALUE*, uint, uint*, float*, IDWriteFontFace5**, int>)(lpVtbl[4]))((IDWriteFontFallback1*)Unsafe.AsPointer(ref this), analysisSource, textPosition, textLength, baseFontCollection, baseFamilyName, fontAxisValues, fontAxisValueCount, mappedLength, scale, mappedFontFace);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteFontFallback1*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteFontFallback1*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteFontFallback1*, uint> Release;

            [NativeTypeName("HRESULT (IDWriteTextAnalysisSource *, UINT32, UINT32, IDWriteFontCollection *, const wchar_t *, DWRITE_FONT_WEIGHT, DWRITE_FONT_STYLE, DWRITE_FONT_STRETCH, UINT32 *, IDWriteFont **, FLOAT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, ushort*, DWRITE_FONT_WEIGHT, DWRITE_FONT_STYLE, DWRITE_FONT_STRETCH, uint*, IDWriteFont**, float*, int> MapCharacters;

            [NativeTypeName("HRESULT (IDWriteTextAnalysisSource *, UINT32, UINT32, IDWriteFontCollection *, const WCHAR *, const DWRITE_FONT_AXIS_VALUE *, UINT32, UINT32 *, FLOAT *, IDWriteFontFace5 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, ushort*, DWRITE_FONT_AXIS_VALUE*, uint, uint*, float*, IDWriteFontFace5**, int> MapCharacters1;
        }
    }
}
