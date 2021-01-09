// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("283CE2D7-7153-4A91-9649-7A0F7240945F")]
    [NativeTypeName("struct IAppxManifestPackageId : IUnknown")]
    public unsafe partial struct IAppxManifestPackageId
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxManifestPackageId*, Guid*, void**, int>)(lpVtbl[0]))((IAppxManifestPackageId*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxManifestPackageId*, uint>)(lpVtbl[1]))((IAppxManifestPackageId*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxManifestPackageId*, uint>)(lpVtbl[2]))((IAppxManifestPackageId*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetName([NativeTypeName("LPWSTR *")] ushort** name)
        {
            return ((delegate* unmanaged<IAppxManifestPackageId*, ushort**, int>)(lpVtbl[3]))((IAppxManifestPackageId*)Unsafe.AsPointer(ref this), name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetArchitecture([NativeTypeName("APPX_PACKAGE_ARCHITECTURE *")] APPX_PACKAGE_ARCHITECTURE* architecture)
        {
            return ((delegate* unmanaged<IAppxManifestPackageId*, APPX_PACKAGE_ARCHITECTURE*, int>)(lpVtbl[4]))((IAppxManifestPackageId*)Unsafe.AsPointer(ref this), architecture);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPublisher([NativeTypeName("LPWSTR *")] ushort** publisher)
        {
            return ((delegate* unmanaged<IAppxManifestPackageId*, ushort**, int>)(lpVtbl[5]))((IAppxManifestPackageId*)Unsafe.AsPointer(ref this), publisher);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVersion([NativeTypeName("UINT64 *")] ulong* packageVersion)
        {
            return ((delegate* unmanaged<IAppxManifestPackageId*, ulong*, int>)(lpVtbl[6]))((IAppxManifestPackageId*)Unsafe.AsPointer(ref this), packageVersion);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetResourceId([NativeTypeName("LPWSTR *")] ushort** resourceId)
        {
            return ((delegate* unmanaged<IAppxManifestPackageId*, ushort**, int>)(lpVtbl[7]))((IAppxManifestPackageId*)Unsafe.AsPointer(ref this), resourceId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ComparePublisher([NativeTypeName("LPCWSTR")] ushort* other, [NativeTypeName("BOOL *")] int* isSame)
        {
            return ((delegate* unmanaged<IAppxManifestPackageId*, ushort*, int*, int>)(lpVtbl[8]))((IAppxManifestPackageId*)Unsafe.AsPointer(ref this), other, isSame);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPackageFullName([NativeTypeName("LPWSTR *")] ushort** packageFullName)
        {
            return ((delegate* unmanaged<IAppxManifestPackageId*, ushort**, int>)(lpVtbl[9]))((IAppxManifestPackageId*)Unsafe.AsPointer(ref this), packageFullName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPackageFamilyName([NativeTypeName("LPWSTR *")] ushort** packageFamilyName)
        {
            return ((delegate* unmanaged<IAppxManifestPackageId*, ushort**, int>)(lpVtbl[10]))((IAppxManifestPackageId*)Unsafe.AsPointer(ref this), packageFamilyName);
        }
    }
}
