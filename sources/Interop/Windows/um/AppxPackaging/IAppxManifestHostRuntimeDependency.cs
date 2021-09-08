// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3455D234-8414-410D-95C7-7B35255B8391")]
    [NativeTypeName("struct IAppxManifestHostRuntimeDependency : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAppxManifestHostRuntimeDependency
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxManifestHostRuntimeDependency*, Guid*, void**, int>)(lpVtbl[0]))((IAppxManifestHostRuntimeDependency*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxManifestHostRuntimeDependency*, uint>)(lpVtbl[1]))((IAppxManifestHostRuntimeDependency*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxManifestHostRuntimeDependency*, uint>)(lpVtbl[2]))((IAppxManifestHostRuntimeDependency*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetName([NativeTypeName("LPWSTR *")] ushort** name)
        {
            return ((delegate* unmanaged<IAppxManifestHostRuntimeDependency*, ushort**, int>)(lpVtbl[3]))((IAppxManifestHostRuntimeDependency*)Unsafe.AsPointer(ref this), name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetPublisher([NativeTypeName("LPWSTR *")] ushort** publisher)
        {
            return ((delegate* unmanaged<IAppxManifestHostRuntimeDependency*, ushort**, int>)(lpVtbl[4]))((IAppxManifestHostRuntimeDependency*)Unsafe.AsPointer(ref this), publisher);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetMinVersion([NativeTypeName("UINT64 *")] ulong* minVersion)
        {
            return ((delegate* unmanaged<IAppxManifestHostRuntimeDependency*, ulong*, int>)(lpVtbl[5]))((IAppxManifestHostRuntimeDependency*)Unsafe.AsPointer(ref this), minVersion);
        }
    }
}
