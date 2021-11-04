// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9CD9D523-5009-4C01-9882-DC029FBD47A3")]
    [NativeTypeName("struct IAppxBundleWriter4 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAppxBundleWriter4
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxBundleWriter4*, Guid*, void**, int>)(lpVtbl[0]))((IAppxBundleWriter4*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxBundleWriter4*, uint>)(lpVtbl[1]))((IAppxBundleWriter4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxBundleWriter4*, uint>)(lpVtbl[2]))((IAppxBundleWriter4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT AddPayloadPackage([NativeTypeName("LPCWSTR")] ushort* fileName, IStream* packageStream, BOOL isDefaultApplicablePackage)
        {
            return ((delegate* unmanaged<IAppxBundleWriter4*, ushort*, IStream*, BOOL, int>)(lpVtbl[3]))((IAppxBundleWriter4*)Unsafe.AsPointer(ref this), fileName, packageStream, isDefaultApplicablePackage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT AddPackageReference([NativeTypeName("LPCWSTR")] ushort* fileName, IStream* inputStream, BOOL isDefaultApplicablePackage)
        {
            return ((delegate* unmanaged<IAppxBundleWriter4*, ushort*, IStream*, BOOL, int>)(lpVtbl[4]))((IAppxBundleWriter4*)Unsafe.AsPointer(ref this), fileName, inputStream, isDefaultApplicablePackage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT AddExternalPackageReference([NativeTypeName("LPCWSTR")] ushort* fileName, IStream* inputStream, BOOL isDefaultApplicablePackage)
        {
            return ((delegate* unmanaged<IAppxBundleWriter4*, ushort*, IStream*, BOOL, int>)(lpVtbl[5]))((IAppxBundleWriter4*)Unsafe.AsPointer(ref this), fileName, inputStream, isDefaultApplicablePackage);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxBundleWriter4*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxBundleWriter4*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxBundleWriter4*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR, IStream *, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxBundleWriter4*, ushort*, IStream*, BOOL, int> AddPayloadPackage;

            [NativeTypeName("HRESULT (LPCWSTR, IStream *, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxBundleWriter4*, ushort*, IStream*, BOOL, int> AddPackageReference;

            [NativeTypeName("HRESULT (LPCWSTR, IStream *, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxBundleWriter4*, ushort*, IStream*, BOOL, int> AddExternalPackageReference;
        }
    }
}
