// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("44C2ACBC-B2CF-4CCB-BBDB-9C6DA8C3BC9E")]
    [NativeTypeName("struct IAppxBundleManifestPackageInfo2 : IUnknown")]
    public unsafe partial struct IAppxBundleManifestPackageInfo2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxBundleManifestPackageInfo2*, Guid*, void**, int>)(lpVtbl[0]))((IAppxBundleManifestPackageInfo2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxBundleManifestPackageInfo2*, uint>)(lpVtbl[1]))((IAppxBundleManifestPackageInfo2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxBundleManifestPackageInfo2*, uint>)(lpVtbl[2]))((IAppxBundleManifestPackageInfo2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIsPackageReference([NativeTypeName("BOOL *")] int* isPackageReference)
        {
            return ((delegate* unmanaged<IAppxBundleManifestPackageInfo2*, int*, int>)(lpVtbl[3]))((IAppxBundleManifestPackageInfo2*)Unsafe.AsPointer(ref this), isPackageReference);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIsNonQualifiedResourcePackage([NativeTypeName("BOOL *")] int* isNonQualifiedResourcePackage)
        {
            return ((delegate* unmanaged<IAppxBundleManifestPackageInfo2*, int*, int>)(lpVtbl[4]))((IAppxBundleManifestPackageInfo2*)Unsafe.AsPointer(ref this), isNonQualifiedResourcePackage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIsDefaultApplicablePackage([NativeTypeName("BOOL *")] int* isDefaultApplicablePackage)
        {
            return ((delegate* unmanaged<IAppxBundleManifestPackageInfo2*, int*, int>)(lpVtbl[5]))((IAppxBundleManifestPackageInfo2*)Unsafe.AsPointer(ref this), isDefaultApplicablePackage);
        }
    }
}
