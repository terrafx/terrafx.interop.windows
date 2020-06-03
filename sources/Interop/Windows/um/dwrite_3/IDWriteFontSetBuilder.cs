// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2F642AFE-9C68-4F40-B8BE-457401AFCB3D")]
    public unsafe partial struct IDWriteFontSetBuilder
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDWriteFontSetBuilder*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontSetBuilder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDWriteFontSetBuilder*, uint>)(lpVtbl[1]))((IDWriteFontSetBuilder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDWriteFontSetBuilder*, uint>)(lpVtbl[2]))((IDWriteFontSetBuilder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int AddFontFaceReference([NativeTypeName("IDWriteFontFaceReference *")] IDWriteFontFaceReference* fontFaceReference)
        {
            return ((delegate* stdcall<IDWriteFontSetBuilder*, IDWriteFontFaceReference*, int>)(lpVtbl[3]))((IDWriteFontSetBuilder*)Unsafe.AsPointer(ref this), fontFaceReference);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddFontFaceReference([NativeTypeName("IDWriteFontFaceReference *")] IDWriteFontFaceReference* fontFaceReference, [NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* properties, [NativeTypeName("UINT32")] uint propertyCount)
        {
            return ((delegate* stdcall<IDWriteFontSetBuilder*, IDWriteFontFaceReference*, DWRITE_FONT_PROPERTY*, uint, int>)(lpVtbl[4]))((IDWriteFontSetBuilder*)Unsafe.AsPointer(ref this), fontFaceReference, properties, propertyCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddFontSet([NativeTypeName("IDWriteFontSet *")] IDWriteFontSet* fontSet)
        {
            return ((delegate* stdcall<IDWriteFontSetBuilder*, IDWriteFontSet*, int>)(lpVtbl[5]))((IDWriteFontSetBuilder*)Unsafe.AsPointer(ref this), fontSet);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFontSet([NativeTypeName("IDWriteFontSet **")] IDWriteFontSet** fontSet)
        {
            return ((delegate* stdcall<IDWriteFontSetBuilder*, IDWriteFontSet**, int>)(lpVtbl[6]))((IDWriteFontSetBuilder*)Unsafe.AsPointer(ref this), fontSet);
        }
    }
}
