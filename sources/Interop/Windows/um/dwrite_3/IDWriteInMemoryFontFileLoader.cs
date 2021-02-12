// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DC102F47-A12D-4B1C-822D-9E117E33043F")]
    [NativeTypeName("struct IDWriteInMemoryFontFileLoader : IDWriteFontFileLoader")]
    public unsafe partial struct IDWriteInMemoryFontFileLoader
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IDWriteInMemoryFontFileLoader*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteInMemoryFontFileLoader*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDWriteInMemoryFontFileLoader*, uint>)(lpVtbl[1]))((IDWriteInMemoryFontFileLoader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDWriteInMemoryFontFileLoader*, uint>)(lpVtbl[2]))((IDWriteInMemoryFontFileLoader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateStreamFromKey([NativeTypeName("const void *")] void* fontFileReferenceKey, [NativeTypeName("UINT32")] uint fontFileReferenceKeySize, [NativeTypeName("IDWriteFontFileStream **")] IDWriteFontFileStream** fontFileStream)
        {
            return ((delegate* unmanaged<IDWriteInMemoryFontFileLoader*, void*, uint, IDWriteFontFileStream**, int>)(lpVtbl[3]))((IDWriteInMemoryFontFileLoader*)Unsafe.AsPointer(ref this), fontFileReferenceKey, fontFileReferenceKeySize, fontFileStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateInMemoryFontFileReference([NativeTypeName("IDWriteFactory *")] IDWriteFactory* factory, [NativeTypeName("const void *")] void* fontData, [NativeTypeName("UINT32")] uint fontDataSize, [NativeTypeName("IUnknown *")] IUnknown* ownerObject, [NativeTypeName("IDWriteFontFile **")] IDWriteFontFile** fontFile)
        {
            return ((delegate* unmanaged<IDWriteInMemoryFontFileLoader*, IDWriteFactory*, void*, uint, IUnknown*, IDWriteFontFile**, int>)(lpVtbl[4]))((IDWriteInMemoryFontFileLoader*)Unsafe.AsPointer(ref this), factory, fontData, fontDataSize, ownerObject, fontFile);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT32")]
        public uint GetFileCount()
        {
            return ((delegate* unmanaged<IDWriteInMemoryFontFileLoader*, uint>)(lpVtbl[5]))((IDWriteInMemoryFontFileLoader*)Unsafe.AsPointer(ref this));
        }
    }
}
