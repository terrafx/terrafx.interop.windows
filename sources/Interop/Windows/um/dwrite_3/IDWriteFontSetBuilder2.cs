// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EE5BA612-B131-463C-8F4F-3189B9401E45")]
    public unsafe partial struct IDWriteFontSetBuilder2
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDWriteFontSetBuilder2*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontSetBuilder2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDWriteFontSetBuilder2*, uint>)(lpVtbl[1]))((IDWriteFontSetBuilder2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDWriteFontSetBuilder2*, uint>)(lpVtbl[2]))((IDWriteFontSetBuilder2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int AddFontFaceReference([NativeTypeName("IDWriteFontFaceReference *")] IDWriteFontFaceReference* fontFaceReference)
        {
            return ((delegate* stdcall<IDWriteFontSetBuilder2*, IDWriteFontFaceReference*, int>)(lpVtbl[3]))((IDWriteFontSetBuilder2*)Unsafe.AsPointer(ref this), fontFaceReference);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddFontFaceReference([NativeTypeName("IDWriteFontFaceReference *")] IDWriteFontFaceReference* fontFaceReference, [NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* properties, [NativeTypeName("UINT32")] uint propertyCount)
        {
            return ((delegate* stdcall<IDWriteFontSetBuilder2*, IDWriteFontFaceReference*, DWRITE_FONT_PROPERTY*, uint, int>)(lpVtbl[4]))((IDWriteFontSetBuilder2*)Unsafe.AsPointer(ref this), fontFaceReference, properties, propertyCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddFontSet([NativeTypeName("IDWriteFontSet *")] IDWriteFontSet* fontSet)
        {
            return ((delegate* stdcall<IDWriteFontSetBuilder2*, IDWriteFontSet*, int>)(lpVtbl[5]))((IDWriteFontSetBuilder2*)Unsafe.AsPointer(ref this), fontSet);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFontSet([NativeTypeName("IDWriteFontSet **")] IDWriteFontSet** fontSet)
        {
            return ((delegate* stdcall<IDWriteFontSetBuilder2*, IDWriteFontSet**, int>)(lpVtbl[6]))((IDWriteFontSetBuilder2*)Unsafe.AsPointer(ref this), fontSet);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddFontFile([NativeTypeName("IDWriteFontFile *")] IDWriteFontFile* fontFile)
        {
            return ((delegate* stdcall<IDWriteFontSetBuilder2*, IDWriteFontFile*, int>)(lpVtbl[7]))((IDWriteFontSetBuilder2*)Unsafe.AsPointer(ref this), fontFile);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddFont([NativeTypeName("IDWriteFontFile *")] IDWriteFontFile* fontFile, [NativeTypeName("UINT32")] uint fontFaceIndex, DWRITE_FONT_SIMULATIONS fontSimulations, [NativeTypeName("const DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount, [NativeTypeName("const DWRITE_FONT_AXIS_RANGE *")] DWRITE_FONT_AXIS_RANGE* fontAxisRanges, [NativeTypeName("UINT32")] uint fontAxisRangeCount, [NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* properties, [NativeTypeName("UINT32")] uint propertyCount)
        {
            return ((delegate* stdcall<IDWriteFontSetBuilder2*, IDWriteFontFile*, uint, DWRITE_FONT_SIMULATIONS, DWRITE_FONT_AXIS_VALUE*, uint, DWRITE_FONT_AXIS_RANGE*, uint, DWRITE_FONT_PROPERTY*, uint, int>)(lpVtbl[8]))((IDWriteFontSetBuilder2*)Unsafe.AsPointer(ref this), fontFile, fontFaceIndex, fontSimulations, fontAxisValues, fontAxisValueCount, fontAxisRanges, fontAxisRangeCount, properties, propertyCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddFontFile([NativeTypeName("const WCHAR *")] ushort* filePath)
        {
            return ((delegate* stdcall<IDWriteFontSetBuilder2*, ushort*, int>)(lpVtbl[9]))((IDWriteFontSetBuilder2*)Unsafe.AsPointer(ref this), filePath);
        }
    }
}
