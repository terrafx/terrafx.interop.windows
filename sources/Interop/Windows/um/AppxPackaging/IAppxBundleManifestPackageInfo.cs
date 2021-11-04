// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("54CD06C1-268F-40BB-8ED2-757A9EBAEC8D")]
    [NativeTypeName("struct IAppxBundleManifestPackageInfo : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAppxBundleManifestPackageInfo : IAppxBundleManifestPackageInfo.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxBundleManifestPackageInfo*, Guid*, void**, int>)(lpVtbl[0]))((IAppxBundleManifestPackageInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxBundleManifestPackageInfo*, uint>)(lpVtbl[1]))((IAppxBundleManifestPackageInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxBundleManifestPackageInfo*, uint>)(lpVtbl[2]))((IAppxBundleManifestPackageInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetPackageType(APPX_BUNDLE_PAYLOAD_PACKAGE_TYPE* packageType)
        {
            return ((delegate* unmanaged<IAppxBundleManifestPackageInfo*, APPX_BUNDLE_PAYLOAD_PACKAGE_TYPE*, int>)(lpVtbl[3]))((IAppxBundleManifestPackageInfo*)Unsafe.AsPointer(ref this), packageType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetPackageId(IAppxManifestPackageId** packageId)
        {
            return ((delegate* unmanaged<IAppxBundleManifestPackageInfo*, IAppxManifestPackageId**, int>)(lpVtbl[4]))((IAppxBundleManifestPackageInfo*)Unsafe.AsPointer(ref this), packageId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetFileName([NativeTypeName("LPWSTR *")] ushort** fileName)
        {
            return ((delegate* unmanaged<IAppxBundleManifestPackageInfo*, ushort**, int>)(lpVtbl[5]))((IAppxBundleManifestPackageInfo*)Unsafe.AsPointer(ref this), fileName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetOffset([NativeTypeName("UINT64 *")] ulong* offset)
        {
            return ((delegate* unmanaged<IAppxBundleManifestPackageInfo*, ulong*, int>)(lpVtbl[6]))((IAppxBundleManifestPackageInfo*)Unsafe.AsPointer(ref this), offset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetSize([NativeTypeName("UINT64 *")] ulong* size)
        {
            return ((delegate* unmanaged<IAppxBundleManifestPackageInfo*, ulong*, int>)(lpVtbl[7]))((IAppxBundleManifestPackageInfo*)Unsafe.AsPointer(ref this), size);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetResources(IAppxManifestQualifiedResourcesEnumerator** resources)
        {
            return ((delegate* unmanaged<IAppxBundleManifestPackageInfo*, IAppxManifestQualifiedResourcesEnumerator**, int>)(lpVtbl[8]))((IAppxBundleManifestPackageInfo*)Unsafe.AsPointer(ref this), resources);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetPackageType(APPX_BUNDLE_PAYLOAD_PACKAGE_TYPE* packageType);

            [VtblIndex(4)]
            HRESULT GetPackageId(IAppxManifestPackageId** packageId);

            [VtblIndex(5)]
            HRESULT GetFileName([NativeTypeName("LPWSTR *")] ushort** fileName);

            [VtblIndex(6)]
            HRESULT GetOffset([NativeTypeName("UINT64 *")] ulong* offset);

            [VtblIndex(7)]
            HRESULT GetSize([NativeTypeName("UINT64 *")] ulong* size);

            [VtblIndex(8)]
            HRESULT GetResources(IAppxManifestQualifiedResourcesEnumerator** resources);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxBundleManifestPackageInfo*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxBundleManifestPackageInfo*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxBundleManifestPackageInfo*, uint> Release;

            [NativeTypeName("HRESULT (APPX_BUNDLE_PAYLOAD_PACKAGE_TYPE *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxBundleManifestPackageInfo*, APPX_BUNDLE_PAYLOAD_PACKAGE_TYPE*, int> GetPackageType;

            [NativeTypeName("HRESULT (IAppxManifestPackageId **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxBundleManifestPackageInfo*, IAppxManifestPackageId**, int> GetPackageId;

            [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxBundleManifestPackageInfo*, ushort**, int> GetFileName;

            [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxBundleManifestPackageInfo*, ulong*, int> GetOffset;

            [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxBundleManifestPackageInfo*, ulong*, int> GetSize;

            [NativeTypeName("HRESULT (IAppxManifestQualifiedResourcesEnumerator **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxBundleManifestPackageInfo*, IAppxManifestQualifiedResourcesEnumerator**, int> GetResources;
        }
    }
}
