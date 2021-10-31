// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3FF7715F-3CDC-4DC6-9B72-EC5621DCCAFD")]
    [NativeTypeName("struct IDWriteFontSetBuilder1 : IDWriteFontSetBuilder")]
    [NativeInheritance("IDWriteFontSetBuilder")]
    public unsafe partial struct IDWriteFontSetBuilder1
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDWriteFontSetBuilder1*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontSetBuilder1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDWriteFontSetBuilder1*, uint>)(lpVtbl[1]))((IDWriteFontSetBuilder1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDWriteFontSetBuilder1*, uint>)(lpVtbl[2]))((IDWriteFontSetBuilder1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT AddFontFaceReference(IDWriteFontFaceReference* fontFaceReference)
        {
            return ((delegate* unmanaged<IDWriteFontSetBuilder1*, IDWriteFontFaceReference*, int>)(lpVtbl[4]))((IDWriteFontSetBuilder1*)Unsafe.AsPointer(ref this), fontFaceReference);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT AddFontFaceReference(IDWriteFontFaceReference* fontFaceReference, [NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* properties, [NativeTypeName("UINT32")] uint propertyCount)
        {
            return ((delegate* unmanaged<IDWriteFontSetBuilder1*, IDWriteFontFaceReference*, DWRITE_FONT_PROPERTY*, uint, int>)(lpVtbl[3]))((IDWriteFontSetBuilder1*)Unsafe.AsPointer(ref this), fontFaceReference, properties, propertyCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT AddFontSet(IDWriteFontSet* fontSet)
        {
            return ((delegate* unmanaged<IDWriteFontSetBuilder1*, IDWriteFontSet*, int>)(lpVtbl[5]))((IDWriteFontSetBuilder1*)Unsafe.AsPointer(ref this), fontSet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT CreateFontSet(IDWriteFontSet** fontSet)
        {
            return ((delegate* unmanaged<IDWriteFontSetBuilder1*, IDWriteFontSet**, int>)(lpVtbl[6]))((IDWriteFontSetBuilder1*)Unsafe.AsPointer(ref this), fontSet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT AddFontFile(IDWriteFontFile* fontFile)
        {
            return ((delegate* unmanaged<IDWriteFontSetBuilder1*, IDWriteFontFile*, int>)(lpVtbl[7]))((IDWriteFontSetBuilder1*)Unsafe.AsPointer(ref this), fontFile);
        }
    }
}
