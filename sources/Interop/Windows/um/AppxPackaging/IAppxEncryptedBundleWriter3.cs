// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0D34DEB3-5CAE-4DD3-977C-504932A51D31")]
    [NativeTypeName("struct IAppxEncryptedBundleWriter3 : IUnknown")]
    public unsafe partial struct IAppxEncryptedBundleWriter3
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxEncryptedBundleWriter3*, Guid*, void**, int>)(lpVtbl[0]))((IAppxEncryptedBundleWriter3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxEncryptedBundleWriter3*, uint>)(lpVtbl[1]))((IAppxEncryptedBundleWriter3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxEncryptedBundleWriter3*, uint>)(lpVtbl[2]))((IAppxEncryptedBundleWriter3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddPayloadPackageEncrypted([NativeTypeName("LPCWSTR")] ushort* fileName, [NativeTypeName("IStream *")] IStream* packageStream, [NativeTypeName("BOOL")] int isDefaultApplicablePackage)
        {
            return ((delegate* unmanaged<IAppxEncryptedBundleWriter3*, ushort*, IStream*, int, int>)(lpVtbl[3]))((IAppxEncryptedBundleWriter3*)Unsafe.AsPointer(ref this), fileName, packageStream, isDefaultApplicablePackage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddExternalPackageReference([NativeTypeName("LPCWSTR")] ushort* fileName, [NativeTypeName("IStream *")] IStream* inputStream, [NativeTypeName("BOOL")] int isDefaultApplicablePackage)
        {
            return ((delegate* unmanaged<IAppxEncryptedBundleWriter3*, ushort*, IStream*, int, int>)(lpVtbl[4]))((IAppxEncryptedBundleWriter3*)Unsafe.AsPointer(ref this), fileName, inputStream, isDefaultApplicablePackage);
        }
    }
}
