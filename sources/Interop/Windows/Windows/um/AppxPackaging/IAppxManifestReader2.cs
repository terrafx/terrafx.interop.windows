// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

[SupportedOSPlatform("windows8.1")]
[Guid("D06F67BC-B31D-4EBA-A8AF-638E73E77B4D")]
[NativeTypeName("struct IAppxManifestReader2 : IAppxManifestReader")]
[NativeInheritance("IAppxManifestReader")]
public unsafe partial struct IAppxManifestReader2 : IAppxManifestReader2.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxManifestReader2*, Guid*, void**, int>)(lpVtbl[0]))((IAppxManifestReader2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxManifestReader2*, uint>)(lpVtbl[1]))((IAppxManifestReader2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxManifestReader2*, uint>)(lpVtbl[2]))((IAppxManifestReader2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPackageId(IAppxManifestPackageId** packageId)
    {
        return ((delegate* unmanaged<IAppxManifestReader2*, IAppxManifestPackageId**, int>)(lpVtbl[3]))((IAppxManifestReader2*)Unsafe.AsPointer(ref this), packageId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetProperties(IAppxManifestProperties** packageProperties)
    {
        return ((delegate* unmanaged<IAppxManifestReader2*, IAppxManifestProperties**, int>)(lpVtbl[4]))((IAppxManifestReader2*)Unsafe.AsPointer(ref this), packageProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetPackageDependencies(IAppxManifestPackageDependenciesEnumerator** dependencies)
    {
        return ((delegate* unmanaged<IAppxManifestReader2*, IAppxManifestPackageDependenciesEnumerator**, int>)(lpVtbl[5]))((IAppxManifestReader2*)Unsafe.AsPointer(ref this), dependencies);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetCapabilities(APPX_CAPABILITIES* capabilities)
    {
        return ((delegate* unmanaged<IAppxManifestReader2*, APPX_CAPABILITIES*, int>)(lpVtbl[6]))((IAppxManifestReader2*)Unsafe.AsPointer(ref this), capabilities);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetResources(IAppxManifestResourcesEnumerator** resources)
    {
        return ((delegate* unmanaged<IAppxManifestReader2*, IAppxManifestResourcesEnumerator**, int>)(lpVtbl[7]))((IAppxManifestReader2*)Unsafe.AsPointer(ref this), resources);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDeviceCapabilities(IAppxManifestDeviceCapabilitiesEnumerator** deviceCapabilities)
    {
        return ((delegate* unmanaged<IAppxManifestReader2*, IAppxManifestDeviceCapabilitiesEnumerator**, int>)(lpVtbl[8]))((IAppxManifestReader2*)Unsafe.AsPointer(ref this), deviceCapabilities);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetPrerequisite([NativeTypeName("LPCWSTR")] ushort* name, [NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged<IAppxManifestReader2*, ushort*, ulong*, int>)(lpVtbl[9]))((IAppxManifestReader2*)Unsafe.AsPointer(ref this), name, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetApplications(IAppxManifestApplicationsEnumerator** applications)
    {
        return ((delegate* unmanaged<IAppxManifestReader2*, IAppxManifestApplicationsEnumerator**, int>)(lpVtbl[10]))((IAppxManifestReader2*)Unsafe.AsPointer(ref this), applications);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetStream(IStream** manifestStream)
    {
        return ((delegate* unmanaged<IAppxManifestReader2*, IStream**, int>)(lpVtbl[11]))((IAppxManifestReader2*)Unsafe.AsPointer(ref this), manifestStream);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetQualifiedResources(IAppxManifestQualifiedResourcesEnumerator** resources)
    {
        return ((delegate* unmanaged<IAppxManifestReader2*, IAppxManifestQualifiedResourcesEnumerator**, int>)(lpVtbl[12]))((IAppxManifestReader2*)Unsafe.AsPointer(ref this), resources);
    }

    public interface Interface : IAppxManifestReader.Interface
    {
        [VtblIndex(12)]
        HRESULT GetQualifiedResources(IAppxManifestQualifiedResourcesEnumerator** resources);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IAppxManifestReader2*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IAppxManifestReader2*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IAppxManifestReader2*, uint> Release;

        [NativeTypeName("HRESULT (IAppxManifestPackageId **) __attribute__((stdcall))")]
        public delegate* unmanaged<IAppxManifestReader2*, IAppxManifestPackageId**, int> GetPackageId;

        [NativeTypeName("HRESULT (IAppxManifestProperties **) __attribute__((stdcall))")]
        public delegate* unmanaged<IAppxManifestReader2*, IAppxManifestProperties**, int> GetProperties;

        [NativeTypeName("HRESULT (IAppxManifestPackageDependenciesEnumerator **) __attribute__((stdcall))")]
        public delegate* unmanaged<IAppxManifestReader2*, IAppxManifestPackageDependenciesEnumerator**, int> GetPackageDependencies;

        [NativeTypeName("HRESULT (APPX_CAPABILITIES *) __attribute__((stdcall))")]
        public delegate* unmanaged<IAppxManifestReader2*, APPX_CAPABILITIES*, int> GetCapabilities;

        [NativeTypeName("HRESULT (IAppxManifestResourcesEnumerator **) __attribute__((stdcall))")]
        public delegate* unmanaged<IAppxManifestReader2*, IAppxManifestResourcesEnumerator**, int> GetResources;

        [NativeTypeName("HRESULT (IAppxManifestDeviceCapabilitiesEnumerator **) __attribute__((stdcall))")]
        public delegate* unmanaged<IAppxManifestReader2*, IAppxManifestDeviceCapabilitiesEnumerator**, int> GetDeviceCapabilities;

        [NativeTypeName("HRESULT (LPCWSTR, UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<IAppxManifestReader2*, ushort*, ulong*, int> GetPrerequisite;

        [NativeTypeName("HRESULT (IAppxManifestApplicationsEnumerator **) __attribute__((stdcall))")]
        public delegate* unmanaged<IAppxManifestReader2*, IAppxManifestApplicationsEnumerator**, int> GetApplications;

        [NativeTypeName("HRESULT (IStream **) __attribute__((stdcall))")]
        public delegate* unmanaged<IAppxManifestReader2*, IStream**, int> GetStream;

        [NativeTypeName("HRESULT (IAppxManifestQualifiedResourcesEnumerator **) __attribute__((stdcall))")]
        public delegate* unmanaged<IAppxManifestReader2*, IAppxManifestQualifiedResourcesEnumerator**, int> GetQualifiedResources;
    }
}
