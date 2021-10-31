// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("34DEACA4-D3C0-4E3E-B312-E42625E3807E")]
    [NativeTypeName("struct IAppxManifestReader6 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAppxManifestReader6
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxManifestReader6*, Guid*, void**, int>)(lpVtbl[0]))((IAppxManifestReader6*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxManifestReader6*, uint>)(lpVtbl[1]))((IAppxManifestReader6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxManifestReader6*, uint>)(lpVtbl[2]))((IAppxManifestReader6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetIsNonQualifiedResourcePackage(BOOL* isNonQualifiedResourcePackage)
        {
            return ((delegate* unmanaged<IAppxManifestReader6*, BOOL*, int>)(lpVtbl[3]))((IAppxManifestReader6*)Unsafe.AsPointer(ref this), isNonQualifiedResourcePackage);
        }
    }
}
