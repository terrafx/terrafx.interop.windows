// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("54CD06C1-268F-40BB-8ED2-757A9EBAEC8D")]
    [NativeTypeName("struct IAppxBundleManifestPackageInfo : IUnknown")]
    public unsafe partial struct IAppxBundleManifestPackageInfo
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxBundleManifestPackageInfo*, Guid*, void**, int>)(lpVtbl[0]))((IAppxBundleManifestPackageInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxBundleManifestPackageInfo*, uint>)(lpVtbl[1]))((IAppxBundleManifestPackageInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxBundleManifestPackageInfo*, uint>)(lpVtbl[2]))((IAppxBundleManifestPackageInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPackageType([NativeTypeName("APPX_BUNDLE_PAYLOAD_PACKAGE_TYPE *")] APPX_BUNDLE_PAYLOAD_PACKAGE_TYPE* packageType)
        {
            return ((delegate* unmanaged<IAppxBundleManifestPackageInfo*, APPX_BUNDLE_PAYLOAD_PACKAGE_TYPE*, int>)(lpVtbl[3]))((IAppxBundleManifestPackageInfo*)Unsafe.AsPointer(ref this), packageType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPackageId([NativeTypeName("IAppxManifestPackageId **")] IAppxManifestPackageId** packageId)
        {
            return ((delegate* unmanaged<IAppxBundleManifestPackageInfo*, IAppxManifestPackageId**, int>)(lpVtbl[4]))((IAppxBundleManifestPackageInfo*)Unsafe.AsPointer(ref this), packageId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFileName([NativeTypeName("LPWSTR *")] ushort** fileName)
        {
            return ((delegate* unmanaged<IAppxBundleManifestPackageInfo*, ushort**, int>)(lpVtbl[5]))((IAppxBundleManifestPackageInfo*)Unsafe.AsPointer(ref this), fileName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetOffset([NativeTypeName("UINT64 *")] ulong* offset)
        {
            return ((delegate* unmanaged<IAppxBundleManifestPackageInfo*, ulong*, int>)(lpVtbl[6]))((IAppxBundleManifestPackageInfo*)Unsafe.AsPointer(ref this), offset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSize([NativeTypeName("UINT64 *")] ulong* size)
        {
            return ((delegate* unmanaged<IAppxBundleManifestPackageInfo*, ulong*, int>)(lpVtbl[7]))((IAppxBundleManifestPackageInfo*)Unsafe.AsPointer(ref this), size);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetResources([NativeTypeName("IAppxManifestQualifiedResourcesEnumerator **")] IAppxManifestQualifiedResourcesEnumerator** resources)
        {
            return ((delegate* unmanaged<IAppxBundleManifestPackageInfo*, IAppxManifestQualifiedResourcesEnumerator**, int>)(lpVtbl[8]))((IAppxBundleManifestPackageInfo*)Unsafe.AsPointer(ref this), resources);
        }
    }
}
