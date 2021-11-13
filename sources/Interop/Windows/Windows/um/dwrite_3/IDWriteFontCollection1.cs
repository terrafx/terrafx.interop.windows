// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("53585141-D9F8-4095-8321-D73CF6BD116C")]
    [NativeTypeName("struct IDWriteFontCollection1 : IDWriteFontCollection")]
    [NativeInheritance("IDWriteFontCollection")]
    public unsafe partial struct IDWriteFontCollection1 : IDWriteFontCollection1.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDWriteFontCollection1*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontCollection1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDWriteFontCollection1*, uint>)(lpVtbl[1]))((IDWriteFontCollection1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDWriteFontCollection1*, uint>)(lpVtbl[2]))((IDWriteFontCollection1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("UINT32")]
        public uint GetFontFamilyCount()
        {
            return ((delegate* unmanaged<IDWriteFontCollection1*, uint>)(lpVtbl[3]))((IDWriteFontCollection1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetFontFamily([NativeTypeName("UINT32")] uint index, IDWriteFontFamily** fontFamily)
        {
            return ((delegate* unmanaged<IDWriteFontCollection1*, uint, IDWriteFontFamily**, int>)(lpVtbl[4]))((IDWriteFontCollection1*)Unsafe.AsPointer(ref this), index, fontFamily);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT FindFamilyName([NativeTypeName("const WCHAR *")] ushort* familyName, [NativeTypeName("UINT32 *")] uint* index, BOOL* exists)
        {
            return ((delegate* unmanaged<IDWriteFontCollection1*, ushort*, uint*, BOOL*, int>)(lpVtbl[5]))((IDWriteFontCollection1*)Unsafe.AsPointer(ref this), familyName, index, exists);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetFontFromFontFace(IDWriteFontFace* fontFace, IDWriteFont** font)
        {
            return ((delegate* unmanaged<IDWriteFontCollection1*, IDWriteFontFace*, IDWriteFont**, int>)(lpVtbl[6]))((IDWriteFontCollection1*)Unsafe.AsPointer(ref this), fontFace, font);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetFontSet(IDWriteFontSet** fontSet)
        {
            return ((delegate* unmanaged<IDWriteFontCollection1*, IDWriteFontSet**, int>)(lpVtbl[7]))((IDWriteFontCollection1*)Unsafe.AsPointer(ref this), fontSet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetFontFamily([NativeTypeName("UINT32")] uint index, IDWriteFontFamily1** fontFamily)
        {
            return ((delegate* unmanaged<IDWriteFontCollection1*, uint, IDWriteFontFamily1**, int>)(lpVtbl[8]))((IDWriteFontCollection1*)Unsafe.AsPointer(ref this), index, fontFamily);
        }

        public interface Interface : IDWriteFontCollection.Interface
        {
            [VtblIndex(7)]
            HRESULT GetFontSet(IDWriteFontSet** fontSet);

            [VtblIndex(8)]
            HRESULT GetFontFamily([NativeTypeName("UINT32")] uint index, IDWriteFontFamily1** fontFamily);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteFontCollection1*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteFontCollection1*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteFontCollection1*, uint> Release;

            [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteFontCollection1*, uint> GetFontFamilyCount;

            [NativeTypeName("HRESULT (UINT32, IDWriteFontFamily **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteFontCollection1*, uint, IDWriteFontFamily**, int> GetFontFamily;

            [NativeTypeName("HRESULT (const WCHAR *, UINT32 *, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteFontCollection1*, ushort*, uint*, BOOL*, int> FindFamilyName;

            [NativeTypeName("HRESULT (IDWriteFontFace *, IDWriteFont **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteFontCollection1*, IDWriteFontFace*, IDWriteFont**, int> GetFontFromFontFace;

            [NativeTypeName("HRESULT (IDWriteFontSet **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteFontCollection1*, IDWriteFontSet**, int> GetFontSet;

            [NativeTypeName("HRESULT (UINT32, IDWriteFontFamily1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDWriteFontCollection1*, uint, IDWriteFontFamily1**, int> GetFontFamily1;
        }
    }
}
