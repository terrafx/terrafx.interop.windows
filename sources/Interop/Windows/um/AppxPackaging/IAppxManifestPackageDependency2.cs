// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DDA0B713-F3FF-49D3-898A-2786780C5D98")]
    [NativeTypeName("struct IAppxManifestPackageDependency2 : IAppxManifestPackageDependency")]
    [NativeInheritance("IAppxManifestPackageDependency")]
    public unsafe partial struct IAppxManifestPackageDependency2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxManifestPackageDependency2*, Guid*, void**, int>)(lpVtbl[0]))((IAppxManifestPackageDependency2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxManifestPackageDependency2*, uint>)(lpVtbl[1]))((IAppxManifestPackageDependency2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxManifestPackageDependency2*, uint>)(lpVtbl[2]))((IAppxManifestPackageDependency2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetName([NativeTypeName("LPWSTR *")] ushort** name)
        {
            return ((delegate* unmanaged<IAppxManifestPackageDependency2*, ushort**, int>)(lpVtbl[3]))((IAppxManifestPackageDependency2*)Unsafe.AsPointer(ref this), name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetPublisher([NativeTypeName("LPWSTR *")] ushort** publisher)
        {
            return ((delegate* unmanaged<IAppxManifestPackageDependency2*, ushort**, int>)(lpVtbl[4]))((IAppxManifestPackageDependency2*)Unsafe.AsPointer(ref this), publisher);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetMinVersion([NativeTypeName("UINT64 *")] ulong* minVersion)
        {
            return ((delegate* unmanaged<IAppxManifestPackageDependency2*, ulong*, int>)(lpVtbl[5]))((IAppxManifestPackageDependency2*)Unsafe.AsPointer(ref this), minVersion);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetMaxMajorVersionTested([NativeTypeName("UINT16 *")] ushort* maxMajorVersionTested)
        {
            return ((delegate* unmanaged<IAppxManifestPackageDependency2*, ushort*, int>)(lpVtbl[6]))((IAppxManifestPackageDependency2*)Unsafe.AsPointer(ref this), maxMajorVersionTested);
        }
    }
}
