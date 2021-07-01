// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3E475447-3A25-40B5-8AD2-F953AE50C92D")]
    [NativeTypeName("struct IAppxEncryptedPackageWriter2 : IUnknown")]
    public unsafe partial struct IAppxEncryptedPackageWriter2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxEncryptedPackageWriter2*, Guid*, void**, int>)(lpVtbl[0]))((IAppxEncryptedPackageWriter2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxEncryptedPackageWriter2*, uint>)(lpVtbl[1]))((IAppxEncryptedPackageWriter2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxEncryptedPackageWriter2*, uint>)(lpVtbl[2]))((IAppxEncryptedPackageWriter2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddPayloadFilesEncrypted([NativeTypeName("UINT32")] uint fileCount, APPX_PACKAGE_WRITER_PAYLOAD_STREAM* payloadFiles, [NativeTypeName("UINT64")] ulong memoryLimit)
        {
            return ((delegate* unmanaged<IAppxEncryptedPackageWriter2*, uint, APPX_PACKAGE_WRITER_PAYLOAD_STREAM*, ulong, int>)(lpVtbl[3]))((IAppxEncryptedPackageWriter2*)Unsafe.AsPointer(ref this), fileCount, payloadFiles, memoryLimit);
        }
    }
}
