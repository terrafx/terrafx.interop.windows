// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C43825AB-69B7-400A-9709-CC37F5A72D24")]
    [NativeTypeName("struct IAppxManifestReader3 : IAppxManifestReader2")]
    [NativeInheritance("IAppxManifestReader2")]
    public unsafe partial struct IAppxManifestReader3
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxManifestReader3*, Guid*, void**, int>)(lpVtbl[0]))((IAppxManifestReader3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxManifestReader3*, uint>)(lpVtbl[1]))((IAppxManifestReader3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxManifestReader3*, uint>)(lpVtbl[2]))((IAppxManifestReader3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetPackageId(IAppxManifestPackageId** packageId)
        {
            return ((delegate* unmanaged<IAppxManifestReader3*, IAppxManifestPackageId**, int>)(lpVtbl[3]))((IAppxManifestReader3*)Unsafe.AsPointer(ref this), packageId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetProperties(IAppxManifestProperties** packageProperties)
        {
            return ((delegate* unmanaged<IAppxManifestReader3*, IAppxManifestProperties**, int>)(lpVtbl[4]))((IAppxManifestReader3*)Unsafe.AsPointer(ref this), packageProperties);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetPackageDependencies(IAppxManifestPackageDependenciesEnumerator** dependencies)
        {
            return ((delegate* unmanaged<IAppxManifestReader3*, IAppxManifestPackageDependenciesEnumerator**, int>)(lpVtbl[5]))((IAppxManifestReader3*)Unsafe.AsPointer(ref this), dependencies);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetCapabilities(APPX_CAPABILITIES* capabilities)
        {
            return ((delegate* unmanaged<IAppxManifestReader3*, APPX_CAPABILITIES*, int>)(lpVtbl[6]))((IAppxManifestReader3*)Unsafe.AsPointer(ref this), capabilities);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetResources(IAppxManifestResourcesEnumerator** resources)
        {
            return ((delegate* unmanaged<IAppxManifestReader3*, IAppxManifestResourcesEnumerator**, int>)(lpVtbl[7]))((IAppxManifestReader3*)Unsafe.AsPointer(ref this), resources);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetDeviceCapabilities(IAppxManifestDeviceCapabilitiesEnumerator** deviceCapabilities)
        {
            return ((delegate* unmanaged<IAppxManifestReader3*, IAppxManifestDeviceCapabilitiesEnumerator**, int>)(lpVtbl[8]))((IAppxManifestReader3*)Unsafe.AsPointer(ref this), deviceCapabilities);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrerequisite([NativeTypeName("LPCWSTR")] ushort* name, [NativeTypeName("UINT64 *")] ulong* value)
        {
            return ((delegate* unmanaged<IAppxManifestReader3*, ushort*, ulong*, int>)(lpVtbl[9]))((IAppxManifestReader3*)Unsafe.AsPointer(ref this), name, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int GetApplications(IAppxManifestApplicationsEnumerator** applications)
        {
            return ((delegate* unmanaged<IAppxManifestReader3*, IAppxManifestApplicationsEnumerator**, int>)(lpVtbl[10]))((IAppxManifestReader3*)Unsafe.AsPointer(ref this), applications);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int GetStream(IStream** manifestStream)
        {
            return ((delegate* unmanaged<IAppxManifestReader3*, IStream**, int>)(lpVtbl[11]))((IAppxManifestReader3*)Unsafe.AsPointer(ref this), manifestStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int GetQualifiedResources(IAppxManifestQualifiedResourcesEnumerator** resources)
        {
            return ((delegate* unmanaged<IAppxManifestReader3*, IAppxManifestQualifiedResourcesEnumerator**, int>)(lpVtbl[12]))((IAppxManifestReader3*)Unsafe.AsPointer(ref this), resources);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int GetCapabilitiesByCapabilityClass(APPX_CAPABILITY_CLASS_TYPE capabilityClass, IAppxManifestCapabilitiesEnumerator** capabilities)
        {
            return ((delegate* unmanaged<IAppxManifestReader3*, APPX_CAPABILITY_CLASS_TYPE, IAppxManifestCapabilitiesEnumerator**, int>)(lpVtbl[13]))((IAppxManifestReader3*)Unsafe.AsPointer(ref this), capabilityClass, capabilities);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int GetTargetDeviceFamilies(IAppxManifestTargetDeviceFamiliesEnumerator** targetDeviceFamilies)
        {
            return ((delegate* unmanaged<IAppxManifestReader3*, IAppxManifestTargetDeviceFamiliesEnumerator**, int>)(lpVtbl[14]))((IAppxManifestReader3*)Unsafe.AsPointer(ref this), targetDeviceFamilies);
        }
    }
}
