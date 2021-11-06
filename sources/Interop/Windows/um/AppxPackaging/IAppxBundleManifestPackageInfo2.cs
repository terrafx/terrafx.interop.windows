// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("44C2ACBC-B2CF-4CCB-BBDB-9C6DA8C3BC9E")]
    [NativeTypeName("struct IAppxBundleManifestPackageInfo2 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAppxBundleManifestPackageInfo2 : IAppxBundleManifestPackageInfo2.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxBundleManifestPackageInfo2*, Guid*, void**, int>)(lpVtbl[0]))((IAppxBundleManifestPackageInfo2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxBundleManifestPackageInfo2*, uint>)(lpVtbl[1]))((IAppxBundleManifestPackageInfo2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxBundleManifestPackageInfo2*, uint>)(lpVtbl[2]))((IAppxBundleManifestPackageInfo2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetIsPackageReference(BOOL* isPackageReference)
        {
            return ((delegate* unmanaged<IAppxBundleManifestPackageInfo2*, BOOL*, int>)(lpVtbl[3]))((IAppxBundleManifestPackageInfo2*)Unsafe.AsPointer(ref this), isPackageReference);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetIsNonQualifiedResourcePackage(BOOL* isNonQualifiedResourcePackage)
        {
            return ((delegate* unmanaged<IAppxBundleManifestPackageInfo2*, BOOL*, int>)(lpVtbl[4]))((IAppxBundleManifestPackageInfo2*)Unsafe.AsPointer(ref this), isNonQualifiedResourcePackage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIsDefaultApplicablePackage(BOOL* isDefaultApplicablePackage)
        {
            return ((delegate* unmanaged<IAppxBundleManifestPackageInfo2*, BOOL*, int>)(lpVtbl[5]))((IAppxBundleManifestPackageInfo2*)Unsafe.AsPointer(ref this), isDefaultApplicablePackage);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetIsPackageReference(BOOL* isPackageReference);

            [VtblIndex(4)]
            HRESULT GetIsNonQualifiedResourcePackage(BOOL* isNonQualifiedResourcePackage);

            [VtblIndex(5)]
            HRESULT GetIsDefaultApplicablePackage(BOOL* isDefaultApplicablePackage);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxBundleManifestPackageInfo2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxBundleManifestPackageInfo2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxBundleManifestPackageInfo2*, uint> Release;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxBundleManifestPackageInfo2*, BOOL*, int> GetIsPackageReference;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxBundleManifestPackageInfo2*, BOOL*, int> GetIsNonQualifiedResourcePackage;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAppxBundleManifestPackageInfo2*, BOOL*, int> GetIsDefaultApplicablePackage;
        }
    }
}
