// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8EFE6F27-0CE0-4988-B32D-738EB63DB3B7")]
    [NativeTypeName("struct IAppxManifestReader7 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAppxManifestReader7
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxManifestReader7*, Guid*, void**, int>)(lpVtbl[0]))((IAppxManifestReader7*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxManifestReader7*, uint>)(lpVtbl[1]))((IAppxManifestReader7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxManifestReader7*, uint>)(lpVtbl[2]))((IAppxManifestReader7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetDriverDependencies(IAppxManifestDriverDependenciesEnumerator** driverDependencies)
        {
            return ((delegate* unmanaged<IAppxManifestReader7*, IAppxManifestDriverDependenciesEnumerator**, int>)(lpVtbl[3]))((IAppxManifestReader7*)Unsafe.AsPointer(ref this), driverDependencies);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetOSPackageDependencies(IAppxManifestOSPackageDependenciesEnumerator** osPackageDependencies)
        {
            return ((delegate* unmanaged<IAppxManifestReader7*, IAppxManifestOSPackageDependenciesEnumerator**, int>)(lpVtbl[4]))((IAppxManifestReader7*)Unsafe.AsPointer(ref this), osPackageDependencies);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetHostRuntimeDependencies(IAppxManifestHostRuntimeDependenciesEnumerator** hostRuntimeDependencies)
        {
            return ((delegate* unmanaged<IAppxManifestReader7*, IAppxManifestHostRuntimeDependenciesEnumerator**, int>)(lpVtbl[5]))((IAppxManifestReader7*)Unsafe.AsPointer(ref this), hostRuntimeDependencies);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxManifestReader7*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxManifestReader7*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxManifestReader7*, uint> Release;

            [NativeTypeName("HRESULT (IAppxManifestDriverDependenciesEnumerator **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxManifestReader7*, IAppxManifestDriverDependenciesEnumerator**, int> GetDriverDependencies;

            [NativeTypeName("HRESULT (IAppxManifestOSPackageDependenciesEnumerator **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxManifestReader7*, IAppxManifestOSPackageDependenciesEnumerator**, int> GetOSPackageDependencies;

            [NativeTypeName("HRESULT (IAppxManifestHostRuntimeDependenciesEnumerator **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxManifestReader7*, IAppxManifestHostRuntimeDependenciesEnumerator**, int> GetHostRuntimeDependencies;
        }
    }
}
