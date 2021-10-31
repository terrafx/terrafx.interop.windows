// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("154995EE-54A6-4F14-AC97-D8CF0519644B")]
    [NativeTypeName("struct IAppxManifestOSPackageDependency : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAppxManifestOSPackageDependency
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxManifestOSPackageDependency*, Guid*, void**, int>)(lpVtbl[0]))((IAppxManifestOSPackageDependency*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxManifestOSPackageDependency*, uint>)(lpVtbl[1]))((IAppxManifestOSPackageDependency*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxManifestOSPackageDependency*, uint>)(lpVtbl[2]))((IAppxManifestOSPackageDependency*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetName([NativeTypeName("LPWSTR *")] ushort** name)
        {
            return ((delegate* unmanaged<IAppxManifestOSPackageDependency*, ushort**, int>)(lpVtbl[3]))((IAppxManifestOSPackageDependency*)Unsafe.AsPointer(ref this), name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetVersion([NativeTypeName("UINT64 *")] ulong* version)
        {
            return ((delegate* unmanaged<IAppxManifestOSPackageDependency*, ulong*, int>)(lpVtbl[4]))((IAppxManifestOSPackageDependency*)Unsafe.AsPointer(ref this), version);
        }
    }
}
