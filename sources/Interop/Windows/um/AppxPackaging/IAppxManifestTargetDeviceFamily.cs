// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9091B09B-C8D5-4F31-8687-A338259FAEFB")]
    [NativeTypeName("struct IAppxManifestTargetDeviceFamily : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAppxManifestTargetDeviceFamily
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxManifestTargetDeviceFamily*, Guid*, void**, int>)(lpVtbl[0]))((IAppxManifestTargetDeviceFamily*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxManifestTargetDeviceFamily*, uint>)(lpVtbl[1]))((IAppxManifestTargetDeviceFamily*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxManifestTargetDeviceFamily*, uint>)(lpVtbl[2]))((IAppxManifestTargetDeviceFamily*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetName([NativeTypeName("LPWSTR *")] ushort** name)
        {
            return ((delegate* unmanaged<IAppxManifestTargetDeviceFamily*, ushort**, int>)(lpVtbl[3]))((IAppxManifestTargetDeviceFamily*)Unsafe.AsPointer(ref this), name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetMinVersion([NativeTypeName("UINT64 *")] ulong* minVersion)
        {
            return ((delegate* unmanaged<IAppxManifestTargetDeviceFamily*, ulong*, int>)(lpVtbl[4]))((IAppxManifestTargetDeviceFamily*)Unsafe.AsPointer(ref this), minVersion);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetMaxVersionTested([NativeTypeName("UINT64 *")] ulong* maxVersionTested)
        {
            return ((delegate* unmanaged<IAppxManifestTargetDeviceFamily*, ulong*, int>)(lpVtbl[5]))((IAppxManifestTargetDeviceFamily*)Unsafe.AsPointer(ref this), maxVersionTested);
        }
    }
}
