// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A879611F-12FD-41FE-85D5-06AE779BBAF5")]
    [NativeTypeName("struct IAppxEncryptionFactory4 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAppxEncryptionFactory4
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxEncryptionFactory4*, Guid*, void**, int>)(lpVtbl[0]))((IAppxEncryptionFactory4*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxEncryptionFactory4*, uint>)(lpVtbl[1]))((IAppxEncryptionFactory4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxEncryptionFactory4*, uint>)(lpVtbl[2]))((IAppxEncryptionFactory4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int EncryptPackage(IStream* inputStream, IStream* outputStream, [NativeTypeName("const APPX_ENCRYPTED_PACKAGE_SETTINGS2 *")] APPX_ENCRYPTED_PACKAGE_SETTINGS2* settings, [NativeTypeName("const APPX_KEY_INFO *")] APPX_KEY_INFO* keyInfo, [NativeTypeName("const APPX_ENCRYPTED_EXEMPTIONS *")] APPX_ENCRYPTED_EXEMPTIONS* exemptedFiles, [NativeTypeName("UINT64")] ulong memoryLimit)
        {
            return ((delegate* unmanaged<IAppxEncryptionFactory4*, IStream*, IStream*, APPX_ENCRYPTED_PACKAGE_SETTINGS2*, APPX_KEY_INFO*, APPX_ENCRYPTED_EXEMPTIONS*, ulong, int>)(lpVtbl[3]))((IAppxEncryptionFactory4*)Unsafe.AsPointer(ref this), inputStream, outputStream, settings, keyInfo, exemptedFiles, memoryLimit);
        }
    }
}
