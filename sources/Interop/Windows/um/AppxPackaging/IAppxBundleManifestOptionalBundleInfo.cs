// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("515BF2E8-BCB0-4D69-8C48-E383147B6E12")]
    [NativeTypeName("struct IAppxBundleManifestOptionalBundleInfo : IUnknown")]
    public unsafe partial struct IAppxBundleManifestOptionalBundleInfo
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxBundleManifestOptionalBundleInfo*, Guid*, void**, int>)(lpVtbl[0]))((IAppxBundleManifestOptionalBundleInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxBundleManifestOptionalBundleInfo*, uint>)(lpVtbl[1]))((IAppxBundleManifestOptionalBundleInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxBundleManifestOptionalBundleInfo*, uint>)(lpVtbl[2]))((IAppxBundleManifestOptionalBundleInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPackageId(IAppxManifestPackageId** packageId)
        {
            return ((delegate* unmanaged<IAppxBundleManifestOptionalBundleInfo*, IAppxManifestPackageId**, int>)(lpVtbl[3]))((IAppxBundleManifestOptionalBundleInfo*)Unsafe.AsPointer(ref this), packageId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFileName([NativeTypeName("LPWSTR *")] ushort** fileName)
        {
            return ((delegate* unmanaged<IAppxBundleManifestOptionalBundleInfo*, ushort**, int>)(lpVtbl[4]))((IAppxBundleManifestOptionalBundleInfo*)Unsafe.AsPointer(ref this), fileName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPackageInfoItems(IAppxBundleManifestPackageInfoEnumerator** packageInfoItems)
        {
            return ((delegate* unmanaged<IAppxBundleManifestOptionalBundleInfo*, IAppxBundleManifestPackageInfoEnumerator**, int>)(lpVtbl[5]))((IAppxBundleManifestOptionalBundleInfo*)Unsafe.AsPointer(ref this), packageInfoItems);
        }
    }
}
