// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E2ADB6DC-5E71-4416-86B6-86E5F5291A6B")]
    [NativeTypeName("struct IAppxPackageEditor : IUnknown")]
    public unsafe partial struct IAppxPackageEditor
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxPackageEditor*, Guid*, void**, int>)(lpVtbl[0]))((IAppxPackageEditor*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxPackageEditor*, uint>)(lpVtbl[1]))((IAppxPackageEditor*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxPackageEditor*, uint>)(lpVtbl[2]))((IAppxPackageEditor*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetWorkingDirectory([NativeTypeName("LPCWSTR")] ushort* workingDirectory)
        {
            return ((delegate* unmanaged<IAppxPackageEditor*, ushort*, int>)(lpVtbl[3]))((IAppxPackageEditor*)Unsafe.AsPointer(ref this), workingDirectory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDeltaPackage(IStream* updatedPackageStream, IStream* baselinePackageStream, IStream* deltaPackageStream)
        {
            return ((delegate* unmanaged<IAppxPackageEditor*, IStream*, IStream*, IStream*, int>)(lpVtbl[4]))((IAppxPackageEditor*)Unsafe.AsPointer(ref this), updatedPackageStream, baselinePackageStream, deltaPackageStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDeltaPackageUsingBaselineBlockMap(IStream* updatedPackageStream, IStream* baselineBlockMapStream, [NativeTypeName("LPCWSTR")] ushort* baselinePackageFullName, IStream* deltaPackageStream)
        {
            return ((delegate* unmanaged<IAppxPackageEditor*, IStream*, IStream*, ushort*, IStream*, int>)(lpVtbl[5]))((IAppxPackageEditor*)Unsafe.AsPointer(ref this), updatedPackageStream, baselineBlockMapStream, baselinePackageFullName, deltaPackageStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UpdatePackage(IStream* baselinePackageStream, IStream* deltaPackageStream, APPX_PACKAGE_EDITOR_UPDATE_PACKAGE_OPTION updateOption)
        {
            return ((delegate* unmanaged<IAppxPackageEditor*, IStream*, IStream*, APPX_PACKAGE_EDITOR_UPDATE_PACKAGE_OPTION, int>)(lpVtbl[6]))((IAppxPackageEditor*)Unsafe.AsPointer(ref this), baselinePackageStream, deltaPackageStream, updateOption);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateEncryptedPackage(IStream* baselineEncryptedPackageStream, IStream* deltaPackageStream, APPX_PACKAGE_EDITOR_UPDATE_PACKAGE_OPTION updateOption, [NativeTypeName("const APPX_ENCRYPTED_PACKAGE_SETTINGS2 *")] APPX_ENCRYPTED_PACKAGE_SETTINGS2* settings, [NativeTypeName("const APPX_KEY_INFO *")] APPX_KEY_INFO* keyInfo)
        {
            return ((delegate* unmanaged<IAppxPackageEditor*, IStream*, IStream*, APPX_PACKAGE_EDITOR_UPDATE_PACKAGE_OPTION, APPX_ENCRYPTED_PACKAGE_SETTINGS2*, APPX_KEY_INFO*, int>)(lpVtbl[7]))((IAppxPackageEditor*)Unsafe.AsPointer(ref this), baselineEncryptedPackageStream, deltaPackageStream, updateOption, settings, keyInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UpdatePackageManifest(IStream* packageStream, IStream* updatedManifestStream, [NativeTypeName("BOOL")] int isPackageEncrypted, APPX_PACKAGE_EDITOR_UPDATE_PACKAGE_MANIFEST_OPTIONS options)
        {
            return ((delegate* unmanaged<IAppxPackageEditor*, IStream*, IStream*, int, APPX_PACKAGE_EDITOR_UPDATE_PACKAGE_MANIFEST_OPTIONS, int>)(lpVtbl[8]))((IAppxPackageEditor*)Unsafe.AsPointer(ref this), packageStream, updatedManifestStream, isPackageEncrypted, options);
        }
    }
}
