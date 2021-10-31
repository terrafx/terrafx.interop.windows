// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A84CEE02-3EEA-4EEE-A827-87C1A02A0FCC")]
    [NativeTypeName("struct IDWriteFontCollection : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDWriteFontCollection
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDWriteFontCollection*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontCollection*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDWriteFontCollection*, uint>)(lpVtbl[1]))((IDWriteFontCollection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDWriteFontCollection*, uint>)(lpVtbl[2]))((IDWriteFontCollection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("UINT32")]
        public uint GetFontFamilyCount()
        {
            return ((delegate* unmanaged<IDWriteFontCollection*, uint>)(lpVtbl[3]))((IDWriteFontCollection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontFamily([NativeTypeName("UINT32")] uint index, IDWriteFontFamily** fontFamily)
        {
            return ((delegate* unmanaged<IDWriteFontCollection*, uint, IDWriteFontFamily**, int>)(lpVtbl[4]))((IDWriteFontCollection*)Unsafe.AsPointer(ref this), index, fontFamily);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int FindFamilyName([NativeTypeName("const WCHAR *")] ushort* familyName, [NativeTypeName("UINT32 *")] uint* index, BOOL* exists)
        {
            return ((delegate* unmanaged<IDWriteFontCollection*, ushort*, uint*, BOOL*, int>)(lpVtbl[5]))((IDWriteFontCollection*)Unsafe.AsPointer(ref this), familyName, index, exists);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontFromFontFace(IDWriteFontFace* fontFace, IDWriteFont** font)
        {
            return ((delegate* unmanaged<IDWriteFontCollection*, IDWriteFontFace*, IDWriteFont**, int>)(lpVtbl[6]))((IDWriteFontCollection*)Unsafe.AsPointer(ref this), fontFace, font);
        }
    }
}
