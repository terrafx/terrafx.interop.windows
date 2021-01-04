// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D06F67BC-B31D-4EBA-A8AF-638E73E77B4D")]
    [NativeTypeName("struct IAppxManifestReader2 : IAppxManifestReader")]
    public unsafe partial struct IAppxManifestReader2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxManifestReader2*, Guid*, void**, int>)(lpVtbl[0]))((IAppxManifestReader2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxManifestReader2*, uint>)(lpVtbl[1]))((IAppxManifestReader2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxManifestReader2*, uint>)(lpVtbl[2]))((IAppxManifestReader2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPackageId([NativeTypeName("IAppxManifestPackageId **")] IAppxManifestPackageId** packageId)
        {
            return ((delegate* unmanaged<IAppxManifestReader2*, IAppxManifestPackageId**, int>)(lpVtbl[3]))((IAppxManifestReader2*)Unsafe.AsPointer(ref this), packageId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetProperties([NativeTypeName("IAppxManifestProperties **")] IAppxManifestProperties** packageProperties)
        {
            return ((delegate* unmanaged<IAppxManifestReader2*, IAppxManifestProperties**, int>)(lpVtbl[4]))((IAppxManifestReader2*)Unsafe.AsPointer(ref this), packageProperties);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPackageDependencies([NativeTypeName("IAppxManifestPackageDependenciesEnumerator **")] IAppxManifestPackageDependenciesEnumerator** dependencies)
        {
            return ((delegate* unmanaged<IAppxManifestReader2*, IAppxManifestPackageDependenciesEnumerator**, int>)(lpVtbl[5]))((IAppxManifestReader2*)Unsafe.AsPointer(ref this), dependencies);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCapabilities([NativeTypeName("APPX_CAPABILITIES *")] APPX_CAPABILITIES* capabilities)
        {
            return ((delegate* unmanaged<IAppxManifestReader2*, APPX_CAPABILITIES*, int>)(lpVtbl[6]))((IAppxManifestReader2*)Unsafe.AsPointer(ref this), capabilities);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetResources([NativeTypeName("IAppxManifestResourcesEnumerator **")] IAppxManifestResourcesEnumerator** resources)
        {
            return ((delegate* unmanaged<IAppxManifestReader2*, IAppxManifestResourcesEnumerator**, int>)(lpVtbl[7]))((IAppxManifestReader2*)Unsafe.AsPointer(ref this), resources);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDeviceCapabilities([NativeTypeName("IAppxManifestDeviceCapabilitiesEnumerator **")] IAppxManifestDeviceCapabilitiesEnumerator** deviceCapabilities)
        {
            return ((delegate* unmanaged<IAppxManifestReader2*, IAppxManifestDeviceCapabilitiesEnumerator**, int>)(lpVtbl[8]))((IAppxManifestReader2*)Unsafe.AsPointer(ref this), deviceCapabilities);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrerequisite([NativeTypeName("LPCWSTR")] ushort* name, [NativeTypeName("UINT64 *")] ulong* value)
        {
            return ((delegate* unmanaged<IAppxManifestReader2*, ushort*, ulong*, int>)(lpVtbl[9]))((IAppxManifestReader2*)Unsafe.AsPointer(ref this), name, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetApplications([NativeTypeName("IAppxManifestApplicationsEnumerator **")] IAppxManifestApplicationsEnumerator** applications)
        {
            return ((delegate* unmanaged<IAppxManifestReader2*, IAppxManifestApplicationsEnumerator**, int>)(lpVtbl[10]))((IAppxManifestReader2*)Unsafe.AsPointer(ref this), applications);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStream([NativeTypeName("IStream **")] IStream** manifestStream)
        {
            return ((delegate* unmanaged<IAppxManifestReader2*, IStream**, int>)(lpVtbl[11]))((IAppxManifestReader2*)Unsafe.AsPointer(ref this), manifestStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetQualifiedResources([NativeTypeName("IAppxManifestQualifiedResourcesEnumerator **")] IAppxManifestQualifiedResourcesEnumerator** resources)
        {
            return ((delegate* unmanaged<IAppxManifestReader2*, IAppxManifestQualifiedResourcesEnumerator**, int>)(lpVtbl[12]))((IAppxManifestReader2*)Unsafe.AsPointer(ref this), resources);
        }
    }
}
