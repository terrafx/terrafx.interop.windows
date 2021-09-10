// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A83AACD3-41C0-4501-B8A3-74164F50B2FD")]
    [NativeTypeName("struct IAppxPackageWriter3 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAppxPackageWriter3
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxPackageWriter3*, Guid*, void**, int>)(lpVtbl[0]))((IAppxPackageWriter3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxPackageWriter3*, uint>)(lpVtbl[1]))((IAppxPackageWriter3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxPackageWriter3*, uint>)(lpVtbl[2]))((IAppxPackageWriter3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int AddPayloadFiles([NativeTypeName("UINT32")] uint fileCount, APPX_PACKAGE_WRITER_PAYLOAD_STREAM* payloadFiles, [NativeTypeName("UINT64")] ulong memoryLimit)
        {
            return ((delegate* unmanaged<IAppxPackageWriter3*, uint, APPX_PACKAGE_WRITER_PAYLOAD_STREAM*, ulong, int>)(lpVtbl[3]))((IAppxPackageWriter3*)Unsafe.AsPointer(ref this), fileCount, payloadFiles, memoryLimit);
        }
    }
}
