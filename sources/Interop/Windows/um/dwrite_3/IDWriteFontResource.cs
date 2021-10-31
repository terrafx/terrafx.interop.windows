// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1F803A76-6871-48E8-987F-B975551C50F2")]
    [NativeTypeName("struct IDWriteFontResource : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDWriteFontResource
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDWriteFontResource*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontResource*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDWriteFontResource*, uint>)(lpVtbl[1]))((IDWriteFontResource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDWriteFontResource*, uint>)(lpVtbl[2]))((IDWriteFontResource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontFile(IDWriteFontFile** fontFile)
        {
            return ((delegate* unmanaged<IDWriteFontResource*, IDWriteFontFile**, int>)(lpVtbl[3]))((IDWriteFontResource*)Unsafe.AsPointer(ref this), fontFile);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("UINT32")]
        public uint GetFontFaceIndex()
        {
            return ((delegate* unmanaged<IDWriteFontResource*, uint>)(lpVtbl[4]))((IDWriteFontResource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("UINT32")]
        public uint GetFontAxisCount()
        {
            return ((delegate* unmanaged<IDWriteFontResource*, uint>)(lpVtbl[5]))((IDWriteFontResource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetDefaultFontAxisValues(DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount)
        {
            return ((delegate* unmanaged<IDWriteFontResource*, DWRITE_FONT_AXIS_VALUE*, uint, int>)(lpVtbl[6]))((IDWriteFontResource*)Unsafe.AsPointer(ref this), fontAxisValues, fontAxisValueCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontAxisRanges(DWRITE_FONT_AXIS_RANGE* fontAxisRanges, [NativeTypeName("UINT32")] uint fontAxisRangeCount)
        {
            return ((delegate* unmanaged<IDWriteFontResource*, DWRITE_FONT_AXIS_RANGE*, uint, int>)(lpVtbl[7]))((IDWriteFontResource*)Unsafe.AsPointer(ref this), fontAxisRanges, fontAxisRangeCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public DWRITE_FONT_AXIS_ATTRIBUTES GetFontAxisAttributes([NativeTypeName("UINT32")] uint axisIndex)
        {
            return ((delegate* unmanaged<IDWriteFontResource*, uint, DWRITE_FONT_AXIS_ATTRIBUTES>)(lpVtbl[8]))((IDWriteFontResource*)Unsafe.AsPointer(ref this), axisIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int GetAxisNames([NativeTypeName("UINT32")] uint axisIndex, IDWriteLocalizedStrings** names)
        {
            return ((delegate* unmanaged<IDWriteFontResource*, uint, IDWriteLocalizedStrings**, int>)(lpVtbl[9]))((IDWriteFontResource*)Unsafe.AsPointer(ref this), axisIndex, names);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("UINT32")]
        public uint GetAxisValueNameCount([NativeTypeName("UINT32")] uint axisIndex)
        {
            return ((delegate* unmanaged<IDWriteFontResource*, uint, uint>)(lpVtbl[10]))((IDWriteFontResource*)Unsafe.AsPointer(ref this), axisIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int GetAxisValueNames([NativeTypeName("UINT32")] uint axisIndex, [NativeTypeName("UINT32")] uint axisValueIndex, DWRITE_FONT_AXIS_RANGE* fontAxisRange, IDWriteLocalizedStrings** names)
        {
            return ((delegate* unmanaged<IDWriteFontResource*, uint, uint, DWRITE_FONT_AXIS_RANGE*, IDWriteLocalizedStrings**, int>)(lpVtbl[11]))((IDWriteFontResource*)Unsafe.AsPointer(ref this), axisIndex, axisValueIndex, fontAxisRange, names);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public BOOL HasVariations()
        {
            return ((delegate* unmanaged<IDWriteFontResource*, int>)(lpVtbl[12]))((IDWriteFontResource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFontFace(DWRITE_FONT_SIMULATIONS fontSimulations, [NativeTypeName("const DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount, IDWriteFontFace5** fontFace)
        {
            return ((delegate* unmanaged<IDWriteFontResource*, DWRITE_FONT_SIMULATIONS, DWRITE_FONT_AXIS_VALUE*, uint, IDWriteFontFace5**, int>)(lpVtbl[13]))((IDWriteFontResource*)Unsafe.AsPointer(ref this), fontSimulations, fontAxisValues, fontAxisValueCount, fontFace);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFontFaceReference(DWRITE_FONT_SIMULATIONS fontSimulations, [NativeTypeName("const DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount, IDWriteFontFaceReference1** fontFaceReference)
        {
            return ((delegate* unmanaged<IDWriteFontResource*, DWRITE_FONT_SIMULATIONS, DWRITE_FONT_AXIS_VALUE*, uint, IDWriteFontFaceReference1**, int>)(lpVtbl[14]))((IDWriteFontResource*)Unsafe.AsPointer(ref this), fontSimulations, fontAxisValues, fontAxisValueCount, fontFaceReference);
        }
    }
}
