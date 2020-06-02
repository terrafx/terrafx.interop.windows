// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1F803A76-6871-48E8-987F-B975551C50F2")]
    public unsafe partial struct IDWriteFontResource
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDWriteFontResource*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDWriteFontResource*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDWriteFontResource*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFile([NativeTypeName("IDWriteFontFile **")] IDWriteFontFile** fontFile)
        {
            return lpVtbl->GetFontFile((IDWriteFontResource*)Unsafe.AsPointer(ref this), fontFile);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetFontFaceIndex()
        {
            return lpVtbl->GetFontFaceIndex((IDWriteFontResource*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT32")]
        public uint GetFontAxisCount()
        {
            return lpVtbl->GetFontAxisCount((IDWriteFontResource*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDefaultFontAxisValues([NativeTypeName("DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount)
        {
            return lpVtbl->GetDefaultFontAxisValues((IDWriteFontResource*)Unsafe.AsPointer(ref this), fontAxisValues, fontAxisValueCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontAxisRanges([NativeTypeName("DWRITE_FONT_AXIS_RANGE *")] DWRITE_FONT_AXIS_RANGE* fontAxisRanges, [NativeTypeName("UINT32")] uint fontAxisRangeCount)
        {
            return lpVtbl->GetFontAxisRanges((IDWriteFontResource*)Unsafe.AsPointer(ref this), fontAxisRanges, fontAxisRangeCount);
        }

        public DWRITE_FONT_AXIS_ATTRIBUTES GetFontAxisAttributes([NativeTypeName("UINT32")] uint axisIndex)
        {
            return lpVtbl->GetFontAxisAttributes((IDWriteFontResource*)Unsafe.AsPointer(ref this), axisIndex);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAxisNames([NativeTypeName("UINT32")] uint axisIndex, [NativeTypeName("IDWriteLocalizedStrings **")] IDWriteLocalizedStrings** names)
        {
            return lpVtbl->GetAxisNames((IDWriteFontResource*)Unsafe.AsPointer(ref this), axisIndex, names);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetAxisValueNameCount([NativeTypeName("UINT32")] uint axisIndex)
        {
            return lpVtbl->GetAxisValueNameCount((IDWriteFontResource*)Unsafe.AsPointer(ref this), axisIndex);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAxisValueNames([NativeTypeName("UINT32")] uint axisIndex, [NativeTypeName("UINT32")] uint axisValueIndex, [NativeTypeName("DWRITE_FONT_AXIS_RANGE *")] DWRITE_FONT_AXIS_RANGE* fontAxisRange, [NativeTypeName("IDWriteLocalizedStrings **")] IDWriteLocalizedStrings** names)
        {
            return lpVtbl->GetAxisValueNames((IDWriteFontResource*)Unsafe.AsPointer(ref this), axisIndex, axisValueIndex, fontAxisRange, names);
        }

        [return: NativeTypeName("BOOL")]
        public int HasVariations()
        {
            return lpVtbl->HasVariations((IDWriteFontResource*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFontFace(DWRITE_FONT_SIMULATIONS fontSimulations, [NativeTypeName("const DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount, [NativeTypeName("IDWriteFontFace5 **")] IDWriteFontFace5** fontFace)
        {
            return lpVtbl->CreateFontFace((IDWriteFontResource*)Unsafe.AsPointer(ref this), fontSimulations, fontAxisValues, fontAxisValueCount, fontFace);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFontFaceReference(DWRITE_FONT_SIMULATIONS fontSimulations, [NativeTypeName("const DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount, [NativeTypeName("IDWriteFontFaceReference1 **")] IDWriteFontFaceReference1** fontFaceReference)
        {
            return lpVtbl->CreateFontFaceReference((IDWriteFontResource*)Unsafe.AsPointer(ref this), fontSimulations, fontAxisValues, fontAxisValueCount, fontFaceReference);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontResource*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontResource*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontResource*, uint> Release;

            [NativeTypeName("HRESULT (IDWriteFontFile **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontResource*, IDWriteFontFile**, int> GetFontFile;

            [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontResource*, uint> GetFontFaceIndex;

            [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontResource*, uint> GetFontAxisCount;

            [NativeTypeName("HRESULT (DWRITE_FONT_AXIS_VALUE *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontResource*, DWRITE_FONT_AXIS_VALUE*, uint, int> GetDefaultFontAxisValues;

            [NativeTypeName("HRESULT (DWRITE_FONT_AXIS_RANGE *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontResource*, DWRITE_FONT_AXIS_RANGE*, uint, int> GetFontAxisRanges;

            [NativeTypeName("DWRITE_FONT_AXIS_ATTRIBUTES (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontResource*, uint, DWRITE_FONT_AXIS_ATTRIBUTES> GetFontAxisAttributes;

            [NativeTypeName("HRESULT (UINT32, IDWriteLocalizedStrings **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontResource*, uint, IDWriteLocalizedStrings**, int> GetAxisNames;

            [NativeTypeName("UINT32 (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontResource*, uint, uint> GetAxisValueNameCount;

            [NativeTypeName("HRESULT (UINT32, UINT32, DWRITE_FONT_AXIS_RANGE *, IDWriteLocalizedStrings **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontResource*, uint, uint, DWRITE_FONT_AXIS_RANGE*, IDWriteLocalizedStrings**, int> GetAxisValueNames;

            [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontResource*, int> HasVariations;

            [NativeTypeName("HRESULT (DWRITE_FONT_SIMULATIONS, const DWRITE_FONT_AXIS_VALUE *, UINT32, IDWriteFontFace5 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontResource*, DWRITE_FONT_SIMULATIONS, DWRITE_FONT_AXIS_VALUE*, uint, IDWriteFontFace5**, int> CreateFontFace;

            [NativeTypeName("HRESULT (DWRITE_FONT_SIMULATIONS, const DWRITE_FONT_AXIS_VALUE *, UINT32, IDWriteFontFaceReference1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontResource*, DWRITE_FONT_SIMULATIONS, DWRITE_FONT_AXIS_VALUE*, uint, IDWriteFontFaceReference1**, int> CreateFontFaceReference;
        }
    }
}
