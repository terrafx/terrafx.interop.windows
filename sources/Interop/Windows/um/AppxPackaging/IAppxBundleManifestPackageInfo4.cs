// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5DA6F13D-A8A7-4532-857C-1393D659371D")]
    [NativeTypeName("struct IAppxBundleManifestPackageInfo4 : IUnknown")]
    public unsafe partial struct IAppxBundleManifestPackageInfo4
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxBundleManifestPackageInfo4*, Guid*, void**, int>)(lpVtbl[0]))((IAppxBundleManifestPackageInfo4*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxBundleManifestPackageInfo4*, uint>)(lpVtbl[1]))((IAppxBundleManifestPackageInfo4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxBundleManifestPackageInfo4*, uint>)(lpVtbl[2]))((IAppxBundleManifestPackageInfo4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIsStub([NativeTypeName("BOOL *")] int* isStub)
        {
            return ((delegate* unmanaged<IAppxBundleManifestPackageInfo4*, int*, int>)(lpVtbl[3]))((IAppxBundleManifestPackageInfo4*)Unsafe.AsPointer(ref this), isStub);
        }
    }
}
