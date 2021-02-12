// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BEB94909-E451-438B-B5A7-D79E767B75D8")]
    [NativeTypeName("struct IAppxFactory : IUnknown")]
    public unsafe partial struct IAppxFactory
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxFactory*, Guid*, void**, int>)(lpVtbl[0]))((IAppxFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxFactory*, uint>)(lpVtbl[1]))((IAppxFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxFactory*, uint>)(lpVtbl[2]))((IAppxFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreatePackageWriter([NativeTypeName("IStream *")] IStream* outputStream, [NativeTypeName("APPX_PACKAGE_SETTINGS *")] APPX_PACKAGE_SETTINGS* settings, [NativeTypeName("IAppxPackageWriter **")] IAppxPackageWriter** packageWriter)
        {
            return ((delegate* unmanaged<IAppxFactory*, IStream*, APPX_PACKAGE_SETTINGS*, IAppxPackageWriter**, int>)(lpVtbl[3]))((IAppxFactory*)Unsafe.AsPointer(ref this), outputStream, settings, packageWriter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreatePackageReader([NativeTypeName("IStream *")] IStream* inputStream, [NativeTypeName("IAppxPackageReader **")] IAppxPackageReader** packageReader)
        {
            return ((delegate* unmanaged<IAppxFactory*, IStream*, IAppxPackageReader**, int>)(lpVtbl[4]))((IAppxFactory*)Unsafe.AsPointer(ref this), inputStream, packageReader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateManifestReader([NativeTypeName("IStream *")] IStream* inputStream, [NativeTypeName("IAppxManifestReader **")] IAppxManifestReader** manifestReader)
        {
            return ((delegate* unmanaged<IAppxFactory*, IStream*, IAppxManifestReader**, int>)(lpVtbl[5]))((IAppxFactory*)Unsafe.AsPointer(ref this), inputStream, manifestReader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateBlockMapReader([NativeTypeName("IStream *")] IStream* inputStream, [NativeTypeName("IAppxBlockMapReader **")] IAppxBlockMapReader** blockMapReader)
        {
            return ((delegate* unmanaged<IAppxFactory*, IStream*, IAppxBlockMapReader**, int>)(lpVtbl[6]))((IAppxFactory*)Unsafe.AsPointer(ref this), inputStream, blockMapReader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateValidatedBlockMapReader([NativeTypeName("IStream *")] IStream* blockMapStream, [NativeTypeName("LPCWSTR")] ushort* signatureFileName, [NativeTypeName("IAppxBlockMapReader **")] IAppxBlockMapReader** blockMapReader)
        {
            return ((delegate* unmanaged<IAppxFactory*, IStream*, ushort*, IAppxBlockMapReader**, int>)(lpVtbl[7]))((IAppxFactory*)Unsafe.AsPointer(ref this), blockMapStream, signatureFileName, blockMapReader);
        }
    }
}
