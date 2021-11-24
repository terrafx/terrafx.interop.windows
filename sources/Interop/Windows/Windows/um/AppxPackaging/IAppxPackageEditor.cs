// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

[Guid("E2ADB6DC-5E71-4416-86B6-86E5F5291A6B")]
[NativeTypeName("struct IAppxPackageEditor : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IAppxPackageEditor : IAppxPackageEditor.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxPackageEditor*, Guid*, void**, int>)(lpVtbl[0]))((IAppxPackageEditor*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxPackageEditor*, uint>)(lpVtbl[1]))((IAppxPackageEditor*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxPackageEditor*, uint>)(lpVtbl[2]))((IAppxPackageEditor*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetWorkingDirectory([NativeTypeName("LPCWSTR")] ushort* workingDirectory)
    {
        return ((delegate* unmanaged<IAppxPackageEditor*, ushort*, int>)(lpVtbl[3]))((IAppxPackageEditor*)Unsafe.AsPointer(ref this), workingDirectory);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateDeltaPackage(IStream* updatedPackageStream, IStream* baselinePackageStream, IStream* deltaPackageStream)
    {
        return ((delegate* unmanaged<IAppxPackageEditor*, IStream*, IStream*, IStream*, int>)(lpVtbl[4]))((IAppxPackageEditor*)Unsafe.AsPointer(ref this), updatedPackageStream, baselinePackageStream, deltaPackageStream);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreateDeltaPackageUsingBaselineBlockMap(IStream* updatedPackageStream, IStream* baselineBlockMapStream, [NativeTypeName("LPCWSTR")] ushort* baselinePackageFullName, IStream* deltaPackageStream)
    {
        return ((delegate* unmanaged<IAppxPackageEditor*, IStream*, IStream*, ushort*, IStream*, int>)(lpVtbl[5]))((IAppxPackageEditor*)Unsafe.AsPointer(ref this), updatedPackageStream, baselineBlockMapStream, baselinePackageFullName, deltaPackageStream);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT UpdatePackage(IStream* baselinePackageStream, IStream* deltaPackageStream, APPX_PACKAGE_EDITOR_UPDATE_PACKAGE_OPTION updateOption)
    {
        return ((delegate* unmanaged<IAppxPackageEditor*, IStream*, IStream*, APPX_PACKAGE_EDITOR_UPDATE_PACKAGE_OPTION, int>)(lpVtbl[6]))((IAppxPackageEditor*)Unsafe.AsPointer(ref this), baselinePackageStream, deltaPackageStream, updateOption);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT UpdateEncryptedPackage(IStream* baselineEncryptedPackageStream, IStream* deltaPackageStream, APPX_PACKAGE_EDITOR_UPDATE_PACKAGE_OPTION updateOption, [NativeTypeName("const APPX_ENCRYPTED_PACKAGE_SETTINGS2 *")] APPX_ENCRYPTED_PACKAGE_SETTINGS2* settings, [NativeTypeName("const APPX_KEY_INFO *")] APPX_KEY_INFO* keyInfo)
    {
        return ((delegate* unmanaged<IAppxPackageEditor*, IStream*, IStream*, APPX_PACKAGE_EDITOR_UPDATE_PACKAGE_OPTION, APPX_ENCRYPTED_PACKAGE_SETTINGS2*, APPX_KEY_INFO*, int>)(lpVtbl[7]))((IAppxPackageEditor*)Unsafe.AsPointer(ref this), baselineEncryptedPackageStream, deltaPackageStream, updateOption, settings, keyInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT UpdatePackageManifest(IStream* packageStream, IStream* updatedManifestStream, BOOL isPackageEncrypted, APPX_PACKAGE_EDITOR_UPDATE_PACKAGE_MANIFEST_OPTIONS options)
    {
        return ((delegate* unmanaged<IAppxPackageEditor*, IStream*, IStream*, BOOL, APPX_PACKAGE_EDITOR_UPDATE_PACKAGE_MANIFEST_OPTIONS, int>)(lpVtbl[8]))((IAppxPackageEditor*)Unsafe.AsPointer(ref this), packageStream, updatedManifestStream, isPackageEncrypted, options);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetWorkingDirectory([NativeTypeName("LPCWSTR")] ushort* workingDirectory);

        [VtblIndex(4)]
        HRESULT CreateDeltaPackage(IStream* updatedPackageStream, IStream* baselinePackageStream, IStream* deltaPackageStream);

        [VtblIndex(5)]
        HRESULT CreateDeltaPackageUsingBaselineBlockMap(IStream* updatedPackageStream, IStream* baselineBlockMapStream, [NativeTypeName("LPCWSTR")] ushort* baselinePackageFullName, IStream* deltaPackageStream);

        [VtblIndex(6)]
        HRESULT UpdatePackage(IStream* baselinePackageStream, IStream* deltaPackageStream, APPX_PACKAGE_EDITOR_UPDATE_PACKAGE_OPTION updateOption);

        [VtblIndex(7)]
        HRESULT UpdateEncryptedPackage(IStream* baselineEncryptedPackageStream, IStream* deltaPackageStream, APPX_PACKAGE_EDITOR_UPDATE_PACKAGE_OPTION updateOption, [NativeTypeName("const APPX_ENCRYPTED_PACKAGE_SETTINGS2 *")] APPX_ENCRYPTED_PACKAGE_SETTINGS2* settings, [NativeTypeName("const APPX_KEY_INFO *")] APPX_KEY_INFO* keyInfo);

        [VtblIndex(8)]
        HRESULT UpdatePackageManifest(IStream* packageStream, IStream* updatedManifestStream, BOOL isPackageEncrypted, APPX_PACKAGE_EDITOR_UPDATE_PACKAGE_MANIFEST_OPTIONS options);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IAppxPackageEditor*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IAppxPackageEditor*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IAppxPackageEditor*, uint> Release;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<IAppxPackageEditor*, ushort*, int> SetWorkingDirectory;

        [NativeTypeName("HRESULT (IStream *, IStream *, IStream *) __attribute__((stdcall))")]
        public delegate* unmanaged<IAppxPackageEditor*, IStream*, IStream*, IStream*, int> CreateDeltaPackage;

        [NativeTypeName("HRESULT (IStream *, IStream *, LPCWSTR, IStream *) __attribute__((stdcall))")]
        public delegate* unmanaged<IAppxPackageEditor*, IStream*, IStream*, ushort*, IStream*, int> CreateDeltaPackageUsingBaselineBlockMap;

        [NativeTypeName("HRESULT (IStream *, IStream *, APPX_PACKAGE_EDITOR_UPDATE_PACKAGE_OPTION) __attribute__((stdcall))")]
        public delegate* unmanaged<IAppxPackageEditor*, IStream*, IStream*, APPX_PACKAGE_EDITOR_UPDATE_PACKAGE_OPTION, int> UpdatePackage;

        [NativeTypeName("HRESULT (IStream *, IStream *, APPX_PACKAGE_EDITOR_UPDATE_PACKAGE_OPTION, const APPX_ENCRYPTED_PACKAGE_SETTINGS2 *, const APPX_KEY_INFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<IAppxPackageEditor*, IStream*, IStream*, APPX_PACKAGE_EDITOR_UPDATE_PACKAGE_OPTION, APPX_ENCRYPTED_PACKAGE_SETTINGS2*, APPX_KEY_INFO*, int> UpdateEncryptedPackage;

        [NativeTypeName("HRESULT (IStream *, IStream *, BOOL, APPX_PACKAGE_EDITOR_UPDATE_PACKAGE_MANIFEST_OPTIONS) __attribute__((stdcall))")]
        public delegate* unmanaged<IAppxPackageEditor*, IStream*, IStream*, BOOL, APPX_PACKAGE_EDITOR_UPDATE_PACKAGE_MANIFEST_OPTIONS, int> UpdatePackageManifest;
    }
}
