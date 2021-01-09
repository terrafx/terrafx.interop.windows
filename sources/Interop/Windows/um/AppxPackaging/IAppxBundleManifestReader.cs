// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CF0EBBC1-CC99-4106-91EB-E67462E04FB0")]
    [NativeTypeName("struct IAppxBundleManifestReader : IUnknown")]
    public unsafe partial struct IAppxBundleManifestReader
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxBundleManifestReader*, Guid*, void**, int>)(lpVtbl[0]))((IAppxBundleManifestReader*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxBundleManifestReader*, uint>)(lpVtbl[1]))((IAppxBundleManifestReader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxBundleManifestReader*, uint>)(lpVtbl[2]))((IAppxBundleManifestReader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPackageId([NativeTypeName("IAppxManifestPackageId **")] IAppxManifestPackageId** packageId)
        {
            return ((delegate* unmanaged<IAppxBundleManifestReader*, IAppxManifestPackageId**, int>)(lpVtbl[3]))((IAppxBundleManifestReader*)Unsafe.AsPointer(ref this), packageId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPackageInfoItems([NativeTypeName("IAppxBundleManifestPackageInfoEnumerator **")] IAppxBundleManifestPackageInfoEnumerator** packageInfoItems)
        {
            return ((delegate* unmanaged<IAppxBundleManifestReader*, IAppxBundleManifestPackageInfoEnumerator**, int>)(lpVtbl[4]))((IAppxBundleManifestReader*)Unsafe.AsPointer(ref this), packageInfoItems);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStream([NativeTypeName("IStream **")] IStream** manifestStream)
        {
            return ((delegate* unmanaged<IAppxBundleManifestReader*, IStream**, int>)(lpVtbl[5]))((IAppxBundleManifestReader*)Unsafe.AsPointer(ref this), manifestStream);
        }
    }
}
