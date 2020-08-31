// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_2.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EFA008F9-F7A1-48BF-B05C-F224713CC0FF")]
    [NativeTypeName("struct IDWriteFontFallback : IUnknown")]
    public unsafe partial struct IDWriteFontFallback
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDWriteFontFallback*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontFallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDWriteFontFallback*, uint>)(lpVtbl[1]))((IDWriteFontFallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDWriteFontFallback*, uint>)(lpVtbl[2]))((IDWriteFontFallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MapCharacters([NativeTypeName("IDWriteTextAnalysisSource *")] IDWriteTextAnalysisSource* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("IDWriteFontCollection *")] IDWriteFontCollection* baseFontCollection, [NativeTypeName("const wchar_t *")] ushort* baseFamilyName, DWRITE_FONT_WEIGHT baseWeight, DWRITE_FONT_STYLE baseStyle, DWRITE_FONT_STRETCH baseStretch, [NativeTypeName("UINT32 *")] uint* mappedLength, [NativeTypeName("IDWriteFont **")] IDWriteFont** mappedFont, [NativeTypeName("FLOAT *")] float* scale)
        {
            return ((delegate* stdcall<IDWriteFontFallback*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, ushort*, DWRITE_FONT_WEIGHT, DWRITE_FONT_STYLE, DWRITE_FONT_STRETCH, uint*, IDWriteFont**, float*, int>)(lpVtbl[3]))((IDWriteFontFallback*)Unsafe.AsPointer(ref this), analysisSource, textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scale);
        }
    }
}
