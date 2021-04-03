// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("80E8E04D-8C88-44AE-A011-7CADF6FB2E72")]
    [NativeTypeName("struct IAppxEncryptionFactory : IUnknown")]
    public unsafe partial struct IAppxEncryptionFactory
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxEncryptionFactory*, Guid*, void**, int>)(lpVtbl[0]))((IAppxEncryptionFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxEncryptionFactory*, uint>)(lpVtbl[1]))((IAppxEncryptionFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxEncryptionFactory*, uint>)(lpVtbl[2]))((IAppxEncryptionFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EncryptPackage(IStream* inputStream, IStream* outputStream, [NativeTypeName("const APPX_ENCRYPTED_PACKAGE_SETTINGS *")] APPX_ENCRYPTED_PACKAGE_SETTINGS* settings, [NativeTypeName("const APPX_KEY_INFO *")] APPX_KEY_INFO* keyInfo, [NativeTypeName("const APPX_ENCRYPTED_EXEMPTIONS *")] APPX_ENCRYPTED_EXEMPTIONS* exemptedFiles)
        {
            return ((delegate* unmanaged<IAppxEncryptionFactory*, IStream*, IStream*, APPX_ENCRYPTED_PACKAGE_SETTINGS*, APPX_KEY_INFO*, APPX_ENCRYPTED_EXEMPTIONS*, int>)(lpVtbl[3]))((IAppxEncryptionFactory*)Unsafe.AsPointer(ref this), inputStream, outputStream, settings, keyInfo, exemptedFiles);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DecryptPackage(IStream* inputStream, IStream* outputStream, [NativeTypeName("const APPX_KEY_INFO *")] APPX_KEY_INFO* keyInfo)
        {
            return ((delegate* unmanaged<IAppxEncryptionFactory*, IStream*, IStream*, APPX_KEY_INFO*, int>)(lpVtbl[4]))((IAppxEncryptionFactory*)Unsafe.AsPointer(ref this), inputStream, outputStream, keyInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateEncryptedPackageWriter(IStream* outputStream, IStream* manifestStream, [NativeTypeName("const APPX_ENCRYPTED_PACKAGE_SETTINGS *")] APPX_ENCRYPTED_PACKAGE_SETTINGS* settings, [NativeTypeName("const APPX_KEY_INFO *")] APPX_KEY_INFO* keyInfo, [NativeTypeName("const APPX_ENCRYPTED_EXEMPTIONS *")] APPX_ENCRYPTED_EXEMPTIONS* exemptedFiles, IAppxEncryptedPackageWriter** packageWriter)
        {
            return ((delegate* unmanaged<IAppxEncryptionFactory*, IStream*, IStream*, APPX_ENCRYPTED_PACKAGE_SETTINGS*, APPX_KEY_INFO*, APPX_ENCRYPTED_EXEMPTIONS*, IAppxEncryptedPackageWriter**, int>)(lpVtbl[5]))((IAppxEncryptionFactory*)Unsafe.AsPointer(ref this), outputStream, manifestStream, settings, keyInfo, exemptedFiles, packageWriter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateEncryptedPackageReader(IStream* inputStream, [NativeTypeName("const APPX_KEY_INFO *")] APPX_KEY_INFO* keyInfo, IAppxPackageReader** packageReader)
        {
            return ((delegate* unmanaged<IAppxEncryptionFactory*, IStream*, APPX_KEY_INFO*, IAppxPackageReader**, int>)(lpVtbl[6]))((IAppxEncryptionFactory*)Unsafe.AsPointer(ref this), inputStream, keyInfo, packageReader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EncryptBundle(IStream* inputStream, IStream* outputStream, [NativeTypeName("const APPX_ENCRYPTED_PACKAGE_SETTINGS *")] APPX_ENCRYPTED_PACKAGE_SETTINGS* settings, [NativeTypeName("const APPX_KEY_INFO *")] APPX_KEY_INFO* keyInfo, [NativeTypeName("const APPX_ENCRYPTED_EXEMPTIONS *")] APPX_ENCRYPTED_EXEMPTIONS* exemptedFiles)
        {
            return ((delegate* unmanaged<IAppxEncryptionFactory*, IStream*, IStream*, APPX_ENCRYPTED_PACKAGE_SETTINGS*, APPX_KEY_INFO*, APPX_ENCRYPTED_EXEMPTIONS*, int>)(lpVtbl[7]))((IAppxEncryptionFactory*)Unsafe.AsPointer(ref this), inputStream, outputStream, settings, keyInfo, exemptedFiles);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DecryptBundle(IStream* inputStream, IStream* outputStream, [NativeTypeName("const APPX_KEY_INFO *")] APPX_KEY_INFO* keyInfo)
        {
            return ((delegate* unmanaged<IAppxEncryptionFactory*, IStream*, IStream*, APPX_KEY_INFO*, int>)(lpVtbl[8]))((IAppxEncryptionFactory*)Unsafe.AsPointer(ref this), inputStream, outputStream, keyInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateEncryptedBundleWriter(IStream* outputStream, [NativeTypeName("UINT64")] ulong bundleVersion, [NativeTypeName("const APPX_ENCRYPTED_PACKAGE_SETTINGS *")] APPX_ENCRYPTED_PACKAGE_SETTINGS* settings, [NativeTypeName("const APPX_KEY_INFO *")] APPX_KEY_INFO* keyInfo, [NativeTypeName("const APPX_ENCRYPTED_EXEMPTIONS *")] APPX_ENCRYPTED_EXEMPTIONS* exemptedFiles, IAppxEncryptedBundleWriter** bundleWriter)
        {
            return ((delegate* unmanaged<IAppxEncryptionFactory*, IStream*, ulong, APPX_ENCRYPTED_PACKAGE_SETTINGS*, APPX_KEY_INFO*, APPX_ENCRYPTED_EXEMPTIONS*, IAppxEncryptedBundleWriter**, int>)(lpVtbl[9]))((IAppxEncryptionFactory*)Unsafe.AsPointer(ref this), outputStream, bundleVersion, settings, keyInfo, exemptedFiles, bundleWriter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateEncryptedBundleReader(IStream* inputStream, [NativeTypeName("const APPX_KEY_INFO *")] APPX_KEY_INFO* keyInfo, IAppxBundleReader** bundleReader)
        {
            return ((delegate* unmanaged<IAppxEncryptionFactory*, IStream*, APPX_KEY_INFO*, IAppxBundleReader**, int>)(lpVtbl[10]))((IAppxEncryptionFactory*)Unsafe.AsPointer(ref this), inputStream, keyInfo, bundleReader);
        }
    }
}
