// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6BA74B98-BB74-4296-80D0-5F4256A99675")]
    [NativeTypeName("struct IAppxBundleManifestPackageInfo3 : IUnknown")]
    public unsafe partial struct IAppxBundleManifestPackageInfo3
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxBundleManifestPackageInfo3*, Guid*, void**, int>)(lpVtbl[0]))((IAppxBundleManifestPackageInfo3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxBundleManifestPackageInfo3*, uint>)(lpVtbl[1]))((IAppxBundleManifestPackageInfo3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxBundleManifestPackageInfo3*, uint>)(lpVtbl[2]))((IAppxBundleManifestPackageInfo3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTargetDeviceFamilies(IAppxManifestTargetDeviceFamiliesEnumerator** targetDeviceFamilies)
        {
            return ((delegate* unmanaged<IAppxBundleManifestPackageInfo3*, IAppxManifestTargetDeviceFamiliesEnumerator**, int>)(lpVtbl[3]))((IAppxBundleManifestPackageInfo3*)Unsafe.AsPointer(ref this), targetDeviceFamilies);
        }
    }
}
