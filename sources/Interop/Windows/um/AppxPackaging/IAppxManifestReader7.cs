// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8EFE6F27-0CE0-4988-B32D-738EB63DB3B7")]
    [NativeTypeName("struct IAppxManifestReader7 : IUnknown")]
    public unsafe partial struct IAppxManifestReader7
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxManifestReader7*, Guid*, void**, int>)(lpVtbl[0]))((IAppxManifestReader7*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxManifestReader7*, uint>)(lpVtbl[1]))((IAppxManifestReader7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxManifestReader7*, uint>)(lpVtbl[2]))((IAppxManifestReader7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDriverDependencies(IAppxManifestDriverDependenciesEnumerator** driverDependencies)
        {
            return ((delegate* unmanaged<IAppxManifestReader7*, IAppxManifestDriverDependenciesEnumerator**, int>)(lpVtbl[3]))((IAppxManifestReader7*)Unsafe.AsPointer(ref this), driverDependencies);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetOSPackageDependencies(IAppxManifestOSPackageDependenciesEnumerator** osPackageDependencies)
        {
            return ((delegate* unmanaged<IAppxManifestReader7*, IAppxManifestOSPackageDependenciesEnumerator**, int>)(lpVtbl[4]))((IAppxManifestReader7*)Unsafe.AsPointer(ref this), osPackageDependencies);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetHostRuntimeDependencies(IAppxManifestHostRuntimeDependenciesEnumerator** hostRuntimeDependencies)
        {
            return ((delegate* unmanaged<IAppxManifestReader7*, IAppxManifestHostRuntimeDependenciesEnumerator**, int>)(lpVtbl[5]))((IAppxManifestReader7*)Unsafe.AsPointer(ref this), hostRuntimeDependencies);
        }
    }
}
