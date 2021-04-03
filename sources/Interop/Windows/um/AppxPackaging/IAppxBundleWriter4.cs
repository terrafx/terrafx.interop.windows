// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9CD9D523-5009-4C01-9882-DC029FBD47A3")]
    [NativeTypeName("struct IAppxBundleWriter4 : IUnknown")]
    public unsafe partial struct IAppxBundleWriter4
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxBundleWriter4*, Guid*, void**, int>)(lpVtbl[0]))((IAppxBundleWriter4*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxBundleWriter4*, uint>)(lpVtbl[1]))((IAppxBundleWriter4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxBundleWriter4*, uint>)(lpVtbl[2]))((IAppxBundleWriter4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddPayloadPackage([NativeTypeName("LPCWSTR")] ushort* fileName, IStream* packageStream, [NativeTypeName("BOOL")] int isDefaultApplicablePackage)
        {
            return ((delegate* unmanaged<IAppxBundleWriter4*, ushort*, IStream*, int, int>)(lpVtbl[3]))((IAppxBundleWriter4*)Unsafe.AsPointer(ref this), fileName, packageStream, isDefaultApplicablePackage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddPackageReference([NativeTypeName("LPCWSTR")] ushort* fileName, IStream* inputStream, [NativeTypeName("BOOL")] int isDefaultApplicablePackage)
        {
            return ((delegate* unmanaged<IAppxBundleWriter4*, ushort*, IStream*, int, int>)(lpVtbl[4]))((IAppxBundleWriter4*)Unsafe.AsPointer(ref this), fileName, inputStream, isDefaultApplicablePackage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddExternalPackageReference([NativeTypeName("LPCWSTR")] ushort* fileName, IStream* inputStream, [NativeTypeName("BOOL")] int isDefaultApplicablePackage)
        {
            return ((delegate* unmanaged<IAppxBundleWriter4*, ushort*, IStream*, int, int>)(lpVtbl[5]))((IAppxBundleWriter4*)Unsafe.AsPointer(ref this), fileName, inputStream, isDefaultApplicablePackage);
        }
    }
}
