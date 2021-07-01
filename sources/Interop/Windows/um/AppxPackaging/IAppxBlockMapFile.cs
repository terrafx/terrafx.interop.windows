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
    public unsafe partial struct IAppxBlockMapFile
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxBlockMapFile*, Guid*, void**, int>)(lpVtbl[0]))((IAppxBlockMapFile*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxBlockMapFile*, uint>)(lpVtbl[1]))((IAppxBlockMapFile*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxBlockMapFile*, uint>)(lpVtbl[2]))((IAppxBlockMapFile*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBlocks(IAppxBlockMapBlocksEnumerator** blocks)
        {
            return ((delegate* unmanaged<IAppxBlockMapFile*, IAppxBlockMapBlocksEnumerator**, int>)(lpVtbl[3]))((IAppxBlockMapFile*)Unsafe.AsPointer(ref this), blocks);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLocalFileHeaderSize([NativeTypeName("UINT32 *")] uint* lfhSize)
        {
            return ((delegate* unmanaged<IAppxBlockMapFile*, uint*, int>)(lpVtbl[4]))((IAppxBlockMapFile*)Unsafe.AsPointer(ref this), lfhSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetName([NativeTypeName("LPWSTR *")] ushort** name)
        {
            return ((delegate* unmanaged<IAppxBlockMapFile*, ushort**, int>)(lpVtbl[5]))((IAppxBlockMapFile*)Unsafe.AsPointer(ref this), name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetUncompressedSize([NativeTypeName("UINT64 *")] ulong* size)
        {
            return ((delegate* unmanaged<IAppxBlockMapFile*, ulong*, int>)(lpVtbl[6]))((IAppxBlockMapFile*)Unsafe.AsPointer(ref this), size);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ValidateFileHash(IStream* fileStream, [NativeTypeName("BOOL *")] int* isValid)
        {
            return ((delegate* unmanaged<IAppxBlockMapFile*, IStream*, int*, int>)(lpVtbl[7]))((IAppxBlockMapFile*)Unsafe.AsPointer(ref this), fileStream, isValid);
        }
    }
}
