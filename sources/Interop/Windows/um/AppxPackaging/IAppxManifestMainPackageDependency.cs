// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("05D0611C-BC29-46D5-97E2-84B9C79BD8AE")]
    [NativeTypeName("struct IAppxManifestMainPackageDependency : IUnknown")]
    public unsafe partial struct IAppxManifestMainPackageDependency
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxManifestMainPackageDependency*, Guid*, void**, int>)(lpVtbl[0]))((IAppxManifestMainPackageDependency*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxManifestMainPackageDependency*, uint>)(lpVtbl[1]))((IAppxManifestMainPackageDependency*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxManifestMainPackageDependency*, uint>)(lpVtbl[2]))((IAppxManifestMainPackageDependency*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetName([NativeTypeName("LPWSTR *")] ushort** name)
        {
            return ((delegate* unmanaged<IAppxManifestMainPackageDependency*, ushort**, int>)(lpVtbl[3]))((IAppxManifestMainPackageDependency*)Unsafe.AsPointer(ref this), name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPublisher([NativeTypeName("LPWSTR *")] ushort** publisher)
        {
            return ((delegate* unmanaged<IAppxManifestMainPackageDependency*, ushort**, int>)(lpVtbl[4]))((IAppxManifestMainPackageDependency*)Unsafe.AsPointer(ref this), publisher);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPackageFamilyName([NativeTypeName("LPWSTR *")] ushort** packageFamilyName)
        {
            return ((delegate* unmanaged<IAppxManifestMainPackageDependency*, ushort**, int>)(lpVtbl[5]))((IAppxManifestMainPackageDependency*)Unsafe.AsPointer(ref this), packageFamilyName);
        }
    }
}
