// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F9B856EE-49A6-4E19-B2B0-6A2406D63A32")]
    [NativeTypeName("struct IAppxBundleManifestPackageInfoEnumerator : IUnknown")]
    public unsafe partial struct IAppxBundleManifestPackageInfoEnumerator
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxBundleManifestPackageInfoEnumerator*, Guid*, void**, int>)(lpVtbl[0]))((IAppxBundleManifestPackageInfoEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxBundleManifestPackageInfoEnumerator*, uint>)(lpVtbl[1]))((IAppxBundleManifestPackageInfoEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxBundleManifestPackageInfoEnumerator*, uint>)(lpVtbl[2]))((IAppxBundleManifestPackageInfoEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrent([NativeTypeName("IAppxBundleManifestPackageInfo **")] IAppxBundleManifestPackageInfo** packageInfo)
        {
            return ((delegate* unmanaged<IAppxBundleManifestPackageInfoEnumerator*, IAppxBundleManifestPackageInfo**, int>)(lpVtbl[3]))((IAppxBundleManifestPackageInfoEnumerator*)Unsafe.AsPointer(ref this), packageInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetHasCurrent([NativeTypeName("BOOL *")] int* hasCurrent)
        {
            return ((delegate* unmanaged<IAppxBundleManifestPackageInfoEnumerator*, int*, int>)(lpVtbl[4]))((IAppxBundleManifestPackageInfoEnumerator*)Unsafe.AsPointer(ref this), hasCurrent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MoveNext([NativeTypeName("BOOL *")] int* hasNext)
        {
            return ((delegate* unmanaged<IAppxBundleManifestPackageInfoEnumerator*, int*, int>)(lpVtbl[5]))((IAppxBundleManifestPackageInfoEnumerator*)Unsafe.AsPointer(ref this), hasNext);
        }
    }
}
