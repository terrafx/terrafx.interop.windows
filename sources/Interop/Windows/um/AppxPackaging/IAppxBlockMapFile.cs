// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("277672AC-4F63-42C1-8ABC-BEAE3600EB59")]
    [NativeTypeName("struct IAppxBlockMapFile : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAppxBlockMapFile : IAppxBlockMapFile.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxBlockMapFile*, Guid*, void**, int>)(lpVtbl[0]))((IAppxBlockMapFile*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxBlockMapFile*, uint>)(lpVtbl[1]))((IAppxBlockMapFile*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxBlockMapFile*, uint>)(lpVtbl[2]))((IAppxBlockMapFile*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetBlocks(IAppxBlockMapBlocksEnumerator** blocks)
        {
            return ((delegate* unmanaged<IAppxBlockMapFile*, IAppxBlockMapBlocksEnumerator**, int>)(lpVtbl[3]))((IAppxBlockMapFile*)Unsafe.AsPointer(ref this), blocks);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetLocalFileHeaderSize([NativeTypeName("UINT32 *")] uint* lfhSize)
        {
            return ((delegate* unmanaged<IAppxBlockMapFile*, uint*, int>)(lpVtbl[4]))((IAppxBlockMapFile*)Unsafe.AsPointer(ref this), lfhSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetName([NativeTypeName("LPWSTR *")] ushort** name)
        {
            return ((delegate* unmanaged<IAppxBlockMapFile*, ushort**, int>)(lpVtbl[5]))((IAppxBlockMapFile*)Unsafe.AsPointer(ref this), name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetUncompressedSize([NativeTypeName("UINT64 *")] ulong* size)
        {
            return ((delegate* unmanaged<IAppxBlockMapFile*, ulong*, int>)(lpVtbl[6]))((IAppxBlockMapFile*)Unsafe.AsPointer(ref this), size);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT ValidateFileHash(IStream* fileStream, BOOL* isValid)
        {
            return ((delegate* unmanaged<IAppxBlockMapFile*, IStream*, BOOL*, int>)(lpVtbl[7]))((IAppxBlockMapFile*)Unsafe.AsPointer(ref this), fileStream, isValid);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetBlocks(IAppxBlockMapBlocksEnumerator** blocks);

            [VtblIndex(4)]
            HRESULT GetLocalFileHeaderSize([NativeTypeName("UINT32 *")] uint* lfhSize);

            [VtblIndex(5)]
            HRESULT GetName([NativeTypeName("LPWSTR *")] ushort** name);

            [VtblIndex(6)]
            HRESULT GetUncompressedSize([NativeTypeName("UINT64 *")] ulong* size);

            [VtblIndex(7)]
            HRESULT ValidateFileHash(IStream* fileStream, BOOL* isValid);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxBlockMapFile*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxBlockMapFile*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxBlockMapFile*, uint> Release;

            [NativeTypeName("HRESULT (IAppxBlockMapBlocksEnumerator **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxBlockMapFile*, IAppxBlockMapBlocksEnumerator**, int> GetBlocks;

            [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxBlockMapFile*, uint*, int> GetLocalFileHeaderSize;

            [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxBlockMapFile*, ushort**, int> GetName;

            [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxBlockMapFile*, ulong*, int> GetUncompressedSize;

            [NativeTypeName("HRESULT (IStream *, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxBlockMapFile*, IStream*, BOOL*, int> ValidateFileHash;
        }
    }
}
