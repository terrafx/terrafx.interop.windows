// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B2D9F3EC-C9FE-4A11-A2EC-D86208F7C0A2")]
    public unsafe partial struct IDWriteLocalFontFileLoader
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDWriteLocalFontFileLoader*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDWriteLocalFontFileLoader*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDWriteLocalFontFileLoader*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateStreamFromKey([NativeTypeName("const void *")] void* fontFileReferenceKey, [NativeTypeName("UINT32")] uint fontFileReferenceKeySize, [NativeTypeName("IDWriteFontFileStream **")] IDWriteFontFileStream** fontFileStream)
        {
            return lpVtbl->CreateStreamFromKey((IDWriteLocalFontFileLoader*)Unsafe.AsPointer(ref this), fontFileReferenceKey, fontFileReferenceKeySize, fontFileStream);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFilePathLengthFromKey([NativeTypeName("const void *")] void* fontFileReferenceKey, [NativeTypeName("UINT32")] uint fontFileReferenceKeySize, [NativeTypeName("UINT32 *")] uint* filePathLength)
        {
            return lpVtbl->GetFilePathLengthFromKey((IDWriteLocalFontFileLoader*)Unsafe.AsPointer(ref this), fontFileReferenceKey, fontFileReferenceKeySize, filePathLength);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFilePathFromKey([NativeTypeName("const void *")] void* fontFileReferenceKey, [NativeTypeName("UINT32")] uint fontFileReferenceKeySize, [NativeTypeName("WCHAR *")] ushort* filePath, [NativeTypeName("UINT32")] uint filePathSize)
        {
            return lpVtbl->GetFilePathFromKey((IDWriteLocalFontFileLoader*)Unsafe.AsPointer(ref this), fontFileReferenceKey, fontFileReferenceKeySize, filePath, filePathSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLastWriteTimeFromKey([NativeTypeName("const void *")] void* fontFileReferenceKey, [NativeTypeName("UINT32")] uint fontFileReferenceKeySize, [NativeTypeName("FILETIME *")] FILETIME* lastWriteTime)
        {
            return lpVtbl->GetLastWriteTimeFromKey((IDWriteLocalFontFileLoader*)Unsafe.AsPointer(ref this), fontFileReferenceKey, fontFileReferenceKeySize, lastWriteTime);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteLocalFontFileLoader*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteLocalFontFileLoader*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteLocalFontFileLoader*, uint> Release;

            [NativeTypeName("HRESULT (const void *, UINT32, IDWriteFontFileStream **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteLocalFontFileLoader*, void*, uint, IDWriteFontFileStream**, int> CreateStreamFromKey;

            [NativeTypeName("HRESULT (const void *, UINT32, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteLocalFontFileLoader*, void*, uint, uint*, int> GetFilePathLengthFromKey;

            [NativeTypeName("HRESULT (const void *, UINT32, WCHAR *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteLocalFontFileLoader*, void*, uint, ushort*, uint, int> GetFilePathFromKey;

            [NativeTypeName("HRESULT (const void *, UINT32, FILETIME *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteLocalFontFileLoader*, void*, uint, FILETIME*, int> GetLastWriteTimeFromKey;
        }
    }
}
