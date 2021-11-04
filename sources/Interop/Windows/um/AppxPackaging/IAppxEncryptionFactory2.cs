// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C1B11EEE-C4BA-4AB2-A55D-D015FE8FF64F")]
    [NativeTypeName("struct IAppxEncryptionFactory2 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAppxEncryptionFactory2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxEncryptionFactory2*, Guid*, void**, int>)(lpVtbl[0]))((IAppxEncryptionFactory2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxEncryptionFactory2*, uint>)(lpVtbl[1]))((IAppxEncryptionFactory2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxEncryptionFactory2*, uint>)(lpVtbl[2]))((IAppxEncryptionFactory2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT CreateEncryptedPackageWriter(IStream* outputStream, IStream* manifestStream, IStream* contentGroupMapStream, [NativeTypeName("const APPX_ENCRYPTED_PACKAGE_SETTINGS *")] APPX_ENCRYPTED_PACKAGE_SETTINGS* settings, [NativeTypeName("const APPX_KEY_INFO *")] APPX_KEY_INFO* keyInfo, [NativeTypeName("const APPX_ENCRYPTED_EXEMPTIONS *")] APPX_ENCRYPTED_EXEMPTIONS* exemptedFiles, IAppxEncryptedPackageWriter** packageWriter)
        {
            return ((delegate* unmanaged<IAppxEncryptionFactory2*, IStream*, IStream*, IStream*, APPX_ENCRYPTED_PACKAGE_SETTINGS*, APPX_KEY_INFO*, APPX_ENCRYPTED_EXEMPTIONS*, IAppxEncryptedPackageWriter**, int>)(lpVtbl[3]))((IAppxEncryptionFactory2*)Unsafe.AsPointer(ref this), outputStream, manifestStream, contentGroupMapStream, settings, keyInfo, exemptedFiles, packageWriter);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxEncryptionFactory2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxEncryptionFactory2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxEncryptionFactory2*, uint> Release;

            [NativeTypeName("HRESULT (IStream *, IStream *, IStream *, const APPX_ENCRYPTED_PACKAGE_SETTINGS *, const APPX_KEY_INFO *, const APPX_ENCRYPTED_EXEMPTIONS *, IAppxEncryptedPackageWriter **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxEncryptionFactory2*, IStream*, IStream*, IStream*, APPX_ENCRYPTED_PACKAGE_SETTINGS*, APPX_KEY_INFO*, APPX_ENCRYPTED_EXEMPTIONS*, IAppxEncryptedPackageWriter**, int> CreateEncryptedPackageWriter;
        }
    }
}
