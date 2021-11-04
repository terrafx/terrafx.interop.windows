// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2F642AFE-9C68-4F40-B8BE-457401AFCB3D")]
    [NativeTypeName("struct IDWriteFontSetBuilder : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDWriteFontSetBuilder
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDWriteFontSetBuilder*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontSetBuilder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDWriteFontSetBuilder*, uint>)(lpVtbl[1]))((IDWriteFontSetBuilder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDWriteFontSetBuilder*, uint>)(lpVtbl[2]))((IDWriteFontSetBuilder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT AddFontFaceReference(IDWriteFontFaceReference* fontFaceReference, [NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* properties, [NativeTypeName("UINT32")] uint propertyCount)
        {
            return ((delegate* unmanaged<IDWriteFontSetBuilder*, IDWriteFontFaceReference*, DWRITE_FONT_PROPERTY*, uint, int>)(lpVtbl[3]))((IDWriteFontSetBuilder*)Unsafe.AsPointer(ref this), fontFaceReference, properties, propertyCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT AddFontFaceReference(IDWriteFontFaceReference* fontFaceReference)
        {
            return ((delegate* unmanaged<IDWriteFontSetBuilder*, IDWriteFontFaceReference*, int>)(lpVtbl[4]))((IDWriteFontSetBuilder*)Unsafe.AsPointer(ref this), fontFaceReference);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT AddFontSet(IDWriteFontSet* fontSet)
        {
            return ((delegate* unmanaged<IDWriteFontSetBuilder*, IDWriteFontSet*, int>)(lpVtbl[5]))((IDWriteFontSetBuilder*)Unsafe.AsPointer(ref this), fontSet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT CreateFontSet(IDWriteFontSet** fontSet)
        {
            return ((delegate* unmanaged<IDWriteFontSetBuilder*, IDWriteFontSet**, int>)(lpVtbl[6]))((IDWriteFontSetBuilder*)Unsafe.AsPointer(ref this), fontSet);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteFontSetBuilder*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteFontSetBuilder*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteFontSetBuilder*, uint> Release;

            [NativeTypeName("HRESULT (IDWriteFontFaceReference *, const DWRITE_FONT_PROPERTY *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteFontSetBuilder*, IDWriteFontFaceReference*, DWRITE_FONT_PROPERTY*, uint, int> AddFontFaceReference;

            [NativeTypeName("HRESULT (IDWriteFontFaceReference *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteFontSetBuilder*, IDWriteFontFaceReference*, int> AddFontFaceReference1;

            [NativeTypeName("HRESULT (IDWriteFontSet *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteFontSetBuilder*, IDWriteFontSet*, int> AddFontSet;

            [NativeTypeName("HRESULT (IDWriteFontSet **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteFontSetBuilder*, IDWriteFontSet**, int> CreateFontSet;
        }
    }
}
