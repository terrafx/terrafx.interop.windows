// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("514039C6-4617-4064-BF8B-92EA83E506E0")]
    [NativeTypeName("struct IDWriteFontCollection2 : IDWriteFontCollection1")]
    [NativeInheritance("IDWriteFontCollection1")]
    public unsafe partial struct IDWriteFontCollection2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDWriteFontCollection2*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontCollection2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDWriteFontCollection2*, uint>)(lpVtbl[1]))((IDWriteFontCollection2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDWriteFontCollection2*, uint>)(lpVtbl[2]))((IDWriteFontCollection2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("UINT32")]
        public uint GetFontFamilyCount()
        {
            return ((delegate* unmanaged<IDWriteFontCollection2*, uint>)(lpVtbl[3]))((IDWriteFontCollection2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetFontFamily([NativeTypeName("UINT32")] uint index, IDWriteFontFamily** fontFamily)
        {
            return ((delegate* unmanaged<IDWriteFontCollection2*, uint, IDWriteFontFamily**, int>)(lpVtbl[4]))((IDWriteFontCollection2*)Unsafe.AsPointer(ref this), index, fontFamily);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT FindFamilyName([NativeTypeName("const WCHAR *")] ushort* familyName, [NativeTypeName("UINT32 *")] uint* index, BOOL* exists)
        {
            return ((delegate* unmanaged<IDWriteFontCollection2*, ushort*, uint*, BOOL*, int>)(lpVtbl[5]))((IDWriteFontCollection2*)Unsafe.AsPointer(ref this), familyName, index, exists);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetFontFromFontFace(IDWriteFontFace* fontFace, IDWriteFont** font)
        {
            return ((delegate* unmanaged<IDWriteFontCollection2*, IDWriteFontFace*, IDWriteFont**, int>)(lpVtbl[6]))((IDWriteFontCollection2*)Unsafe.AsPointer(ref this), fontFace, font);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetFontSet(IDWriteFontSet** fontSet)
        {
            return ((delegate* unmanaged<IDWriteFontCollection2*, IDWriteFontSet**, int>)(lpVtbl[7]))((IDWriteFontCollection2*)Unsafe.AsPointer(ref this), fontSet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetFontFamily([NativeTypeName("UINT32")] uint index, IDWriteFontFamily1** fontFamily)
        {
            return ((delegate* unmanaged<IDWriteFontCollection2*, uint, IDWriteFontFamily1**, int>)(lpVtbl[8]))((IDWriteFontCollection2*)Unsafe.AsPointer(ref this), index, fontFamily);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetFontFamily([NativeTypeName("UINT32")] uint index, IDWriteFontFamily2** fontFamily)
        {
            return ((delegate* unmanaged<IDWriteFontCollection2*, uint, IDWriteFontFamily2**, int>)(lpVtbl[9]))((IDWriteFontCollection2*)Unsafe.AsPointer(ref this), index, fontFamily);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetMatchingFonts([NativeTypeName("const WCHAR *")] ushort* familyName, [NativeTypeName("const DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount, IDWriteFontList2** fontList)
        {
            return ((delegate* unmanaged<IDWriteFontCollection2*, ushort*, DWRITE_FONT_AXIS_VALUE*, uint, IDWriteFontList2**, int>)(lpVtbl[10]))((IDWriteFontCollection2*)Unsafe.AsPointer(ref this), familyName, fontAxisValues, fontAxisValueCount, fontList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public DWRITE_FONT_FAMILY_MODEL GetFontFamilyModel()
        {
            return ((delegate* unmanaged<IDWriteFontCollection2*, DWRITE_FONT_FAMILY_MODEL>)(lpVtbl[11]))((IDWriteFontCollection2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetFontSet(IDWriteFontSet1** fontSet)
        {
            return ((delegate* unmanaged<IDWriteFontCollection2*, IDWriteFontSet1**, int>)(lpVtbl[12]))((IDWriteFontCollection2*)Unsafe.AsPointer(ref this), fontSet);
        }
    }
}
