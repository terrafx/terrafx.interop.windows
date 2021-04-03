// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C031BEE4-BBCC-48EA-A237-C34045C80A07")]
    [NativeTypeName("struct IAppxManifestDriverConstraint : IUnknown")]
    public unsafe partial struct IAppxManifestDriverConstraint
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxManifestDriverConstraint*, Guid*, void**, int>)(lpVtbl[0]))((IAppxManifestDriverConstraint*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxManifestDriverConstraint*, uint>)(lpVtbl[1]))((IAppxManifestDriverConstraint*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxManifestDriverConstraint*, uint>)(lpVtbl[2]))((IAppxManifestDriverConstraint*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetName([NativeTypeName("LPWSTR *")] ushort** name)
        {
            return ((delegate* unmanaged<IAppxManifestDriverConstraint*, ushort**, int>)(lpVtbl[3]))((IAppxManifestDriverConstraint*)Unsafe.AsPointer(ref this), name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMinVersion([NativeTypeName("UINT64 *")] ulong* minVersion)
        {
            return ((delegate* unmanaged<IAppxManifestDriverConstraint*, ulong*, int>)(lpVtbl[4]))((IAppxManifestDriverConstraint*)Unsafe.AsPointer(ref this), minVersion);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMinDate([NativeTypeName("LPWSTR *")] ushort** minDate)
        {
            return ((delegate* unmanaged<IAppxManifestDriverConstraint*, ushort**, int>)(lpVtbl[5]))((IAppxManifestDriverConstraint*)Unsafe.AsPointer(ref this), minDate);
        }
    }
}
