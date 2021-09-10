// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("739D886A-CEF5-47DC-8769-1A8B41BEBBB0")]
    [NativeTypeName("struct IDWriteFontFile : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDWriteFontFile
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDWriteFontFile*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontFile*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDWriteFontFile*, uint>)(lpVtbl[1]))((IDWriteFontFile*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDWriteFontFile*, uint>)(lpVtbl[2]))((IDWriteFontFile*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetReferenceKey([NativeTypeName("const void **")] void** fontFileReferenceKey, [NativeTypeName("UINT32 *")] uint* fontFileReferenceKeySize)
        {
            return ((delegate* unmanaged<IDWriteFontFile*, void**, uint*, int>)(lpVtbl[3]))((IDWriteFontFile*)Unsafe.AsPointer(ref this), fontFileReferenceKey, fontFileReferenceKeySize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetLoader(IDWriteFontFileLoader** fontFileLoader)
        {
            return ((delegate* unmanaged<IDWriteFontFile*, IDWriteFontFileLoader**, int>)(lpVtbl[4]))((IDWriteFontFile*)Unsafe.AsPointer(ref this), fontFileLoader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int Analyze([NativeTypeName("BOOL *")] int* isSupportedFontType, DWRITE_FONT_FILE_TYPE* fontFileType, DWRITE_FONT_FACE_TYPE* fontFaceType, [NativeTypeName("UINT32 *")] uint* numberOfFaces)
        {
            return ((delegate* unmanaged<IDWriteFontFile*, int*, DWRITE_FONT_FILE_TYPE*, DWRITE_FONT_FACE_TYPE*, uint*, int>)(lpVtbl[5]))((IDWriteFontFile*)Unsafe.AsPointer(ref this), isSupportedFontType, fontFileType, fontFaceType, numberOfFaces);
        }
    }
}
