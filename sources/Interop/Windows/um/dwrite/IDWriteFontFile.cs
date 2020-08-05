// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("739D886A-CEF5-47DC-8769-1A8B41BEBBB0")]
    [NativeTypeName("struct IDWriteFontFile : IUnknown")]
    public unsafe partial struct IDWriteFontFile
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDWriteFontFile*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontFile*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDWriteFontFile*, uint>)(lpVtbl[1]))((IDWriteFontFile*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDWriteFontFile*, uint>)(lpVtbl[2]))((IDWriteFontFile*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetReferenceKey([NativeTypeName("const void **")] void** fontFileReferenceKey, [NativeTypeName("UINT32 *")] uint* fontFileReferenceKeySize)
        {
            return ((delegate* stdcall<IDWriteFontFile*, void**, uint*, int>)(lpVtbl[3]))((IDWriteFontFile*)Unsafe.AsPointer(ref this), fontFileReferenceKey, fontFileReferenceKeySize);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLoader([NativeTypeName("IDWriteFontFileLoader **")] IDWriteFontFileLoader** fontFileLoader)
        {
            return ((delegate* stdcall<IDWriteFontFile*, IDWriteFontFileLoader**, int>)(lpVtbl[4]))((IDWriteFontFile*)Unsafe.AsPointer(ref this), fontFileLoader);
        }

        [return: NativeTypeName("HRESULT")]
        public int Analyze([NativeTypeName("BOOL *")] int* isSupportedFontType, [NativeTypeName("DWRITE_FONT_FILE_TYPE *")] DWRITE_FONT_FILE_TYPE* fontFileType, [NativeTypeName("DWRITE_FONT_FACE_TYPE *")] DWRITE_FONT_FACE_TYPE* fontFaceType, [NativeTypeName("UINT32 *")] uint* numberOfFaces)
        {
            return ((delegate* stdcall<IDWriteFontFile*, int*, DWRITE_FONT_FILE_TYPE*, DWRITE_FONT_FACE_TYPE*, uint*, int>)(lpVtbl[5]))((IDWriteFontFile*)Unsafe.AsPointer(ref this), isSupportedFontType, fontFileType, fontFaceType, numberOfFaces);
        }
    }
}
