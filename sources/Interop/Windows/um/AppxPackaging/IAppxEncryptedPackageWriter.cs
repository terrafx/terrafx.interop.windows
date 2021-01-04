// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F43D0B0B-1379-40E2-9B29-682EA2BF42AF")]
    [NativeTypeName("struct IAppxEncryptedPackageWriter : IUnknown")]
    public unsafe partial struct IAppxEncryptedPackageWriter
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxEncryptedPackageWriter*, Guid*, void**, int>)(lpVtbl[0]))((IAppxEncryptedPackageWriter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxEncryptedPackageWriter*, uint>)(lpVtbl[1]))((IAppxEncryptedPackageWriter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxEncryptedPackageWriter*, uint>)(lpVtbl[2]))((IAppxEncryptedPackageWriter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddPayloadFileEncrypted([NativeTypeName("LPCWSTR")] ushort* fileName, APPX_COMPRESSION_OPTION compressionOption, [NativeTypeName("IStream *")] IStream* inputStream)
        {
            return ((delegate* unmanaged<IAppxEncryptedPackageWriter*, ushort*, APPX_COMPRESSION_OPTION, IStream*, int>)(lpVtbl[3]))((IAppxEncryptedPackageWriter*)Unsafe.AsPointer(ref this), fileName, compressionOption, inputStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Close()
        {
            return ((delegate* unmanaged<IAppxEncryptedPackageWriter*, int>)(lpVtbl[4]))((IAppxEncryptedPackageWriter*)Unsafe.AsPointer(ref this));
        }
    }
}
