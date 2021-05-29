// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("68648C83-6EDE-46C0-AB46-20083A887FDE")]
    [NativeTypeName("struct IDWriteRemoteFontFileLoader : IDWriteFontFileLoader")]
    public unsafe partial struct IDWriteRemoteFontFileLoader
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDWriteRemoteFontFileLoader*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteRemoteFontFileLoader*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDWriteRemoteFontFileLoader*, uint>)(lpVtbl[1]))((IDWriteRemoteFontFileLoader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDWriteRemoteFontFileLoader*, uint>)(lpVtbl[2]))((IDWriteRemoteFontFileLoader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateStreamFromKey([NativeTypeName("const void *")] void* fontFileReferenceKey, [NativeTypeName("UINT32")] uint fontFileReferenceKeySize, IDWriteFontFileStream** fontFileStream)
        {
            return ((delegate* unmanaged<IDWriteRemoteFontFileLoader*, void*, uint, IDWriteFontFileStream**, int>)(lpVtbl[3]))((IDWriteRemoteFontFileLoader*)Unsafe.AsPointer(ref this), fontFileReferenceKey, fontFileReferenceKeySize, fontFileStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateRemoteStreamFromKey([NativeTypeName("const void *")] void* fontFileReferenceKey, [NativeTypeName("UINT32")] uint fontFileReferenceKeySize, IDWriteRemoteFontFileStream** fontFileStream)
        {
            return ((delegate* unmanaged<IDWriteRemoteFontFileLoader*, void*, uint, IDWriteRemoteFontFileStream**, int>)(lpVtbl[4]))((IDWriteRemoteFontFileLoader*)Unsafe.AsPointer(ref this), fontFileReferenceKey, fontFileReferenceKeySize, fontFileStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLocalityFromKey([NativeTypeName("const void *")] void* fontFileReferenceKey, [NativeTypeName("UINT32")] uint fontFileReferenceKeySize, DWRITE_LOCALITY* locality)
        {
            return ((delegate* unmanaged<IDWriteRemoteFontFileLoader*, void*, uint, DWRITE_LOCALITY*, int>)(lpVtbl[5]))((IDWriteRemoteFontFileLoader*)Unsafe.AsPointer(ref this), fontFileReferenceKey, fontFileReferenceKeySize, locality);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFontFileReferenceFromUrl(IDWriteFactory* factory, [NativeTypeName("const WCHAR *")] ushort* baseUrl, [NativeTypeName("const WCHAR *")] ushort* fontFileUrl, IDWriteFontFile** fontFile)
        {
            return ((delegate* unmanaged<IDWriteRemoteFontFileLoader*, IDWriteFactory*, ushort*, ushort*, IDWriteFontFile**, int>)(lpVtbl[6]))((IDWriteRemoteFontFileLoader*)Unsafe.AsPointer(ref this), factory, baseUrl, fontFileUrl, fontFile);
        }
    }
}
