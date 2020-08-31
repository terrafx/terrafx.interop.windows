// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B2D9F3EC-C9FE-4A11-A2EC-D86208F7C0A2")]
    [NativeTypeName("struct IDWriteLocalFontFileLoader : IDWriteFontFileLoader")]
    public unsafe partial struct IDWriteLocalFontFileLoader
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDWriteLocalFontFileLoader*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteLocalFontFileLoader*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDWriteLocalFontFileLoader*, uint>)(lpVtbl[1]))((IDWriteLocalFontFileLoader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDWriteLocalFontFileLoader*, uint>)(lpVtbl[2]))((IDWriteLocalFontFileLoader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateStreamFromKey([NativeTypeName("const void *")] void* fontFileReferenceKey, [NativeTypeName("UINT32")] uint fontFileReferenceKeySize, [NativeTypeName("IDWriteFontFileStream **")] IDWriteFontFileStream** fontFileStream)
        {
            return ((delegate* stdcall<IDWriteLocalFontFileLoader*, void*, uint, IDWriteFontFileStream**, int>)(lpVtbl[3]))((IDWriteLocalFontFileLoader*)Unsafe.AsPointer(ref this), fontFileReferenceKey, fontFileReferenceKeySize, fontFileStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFilePathLengthFromKey([NativeTypeName("const void *")] void* fontFileReferenceKey, [NativeTypeName("UINT32")] uint fontFileReferenceKeySize, [NativeTypeName("UINT32 *")] uint* filePathLength)
        {
            return ((delegate* stdcall<IDWriteLocalFontFileLoader*, void*, uint, uint*, int>)(lpVtbl[4]))((IDWriteLocalFontFileLoader*)Unsafe.AsPointer(ref this), fontFileReferenceKey, fontFileReferenceKeySize, filePathLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFilePathFromKey([NativeTypeName("const void *")] void* fontFileReferenceKey, [NativeTypeName("UINT32")] uint fontFileReferenceKeySize, [NativeTypeName("WCHAR *")] ushort* filePath, [NativeTypeName("UINT32")] uint filePathSize)
        {
            return ((delegate* stdcall<IDWriteLocalFontFileLoader*, void*, uint, ushort*, uint, int>)(lpVtbl[5]))((IDWriteLocalFontFileLoader*)Unsafe.AsPointer(ref this), fontFileReferenceKey, fontFileReferenceKeySize, filePath, filePathSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLastWriteTimeFromKey([NativeTypeName("const void *")] void* fontFileReferenceKey, [NativeTypeName("UINT32")] uint fontFileReferenceKeySize, [NativeTypeName("FILETIME *")] FILETIME* lastWriteTime)
        {
            return ((delegate* stdcall<IDWriteLocalFontFileLoader*, void*, uint, FILETIME*, int>)(lpVtbl[6]))((IDWriteLocalFontFileLoader*)Unsafe.AsPointer(ref this), fontFileReferenceKey, fontFileReferenceKeySize, lastWriteTime);
        }
    }
}
