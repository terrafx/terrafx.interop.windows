// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A84CEE02-3EEA-4EEE-A827-87C1A02A0FCC")]
    public unsafe partial struct IDWriteFontCollection
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDWriteFontCollection*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontCollection*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDWriteFontCollection*, uint>)(lpVtbl[1]))((IDWriteFontCollection*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDWriteFontCollection*, uint>)(lpVtbl[2]))((IDWriteFontCollection*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT32")]
        public uint GetFontFamilyCount()
        {
            return ((delegate* stdcall<IDWriteFontCollection*, uint>)(lpVtbl[3]))((IDWriteFontCollection*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFamily([NativeTypeName("UINT32")] uint index, [NativeTypeName("IDWriteFontFamily **")] IDWriteFontFamily** fontFamily)
        {
            return ((delegate* stdcall<IDWriteFontCollection*, uint, IDWriteFontFamily**, int>)(lpVtbl[4]))((IDWriteFontCollection*)Unsafe.AsPointer(ref this), index, fontFamily);
        }

        [return: NativeTypeName("HRESULT")]
        public int FindFamilyName([NativeTypeName("const WCHAR *")] ushort* familyName, [NativeTypeName("UINT32 *")] uint* index, [NativeTypeName("BOOL *")] int* exists)
        {
            return ((delegate* stdcall<IDWriteFontCollection*, ushort*, uint*, int*, int>)(lpVtbl[5]))((IDWriteFontCollection*)Unsafe.AsPointer(ref this), familyName, index, exists);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFromFontFace([NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* fontFace, [NativeTypeName("IDWriteFont **")] IDWriteFont** font)
        {
            return ((delegate* stdcall<IDWriteFontCollection*, IDWriteFontFace*, IDWriteFont**, int>)(lpVtbl[6]))((IDWriteFontCollection*)Unsafe.AsPointer(ref this), fontFace, font);
        }
    }
}
