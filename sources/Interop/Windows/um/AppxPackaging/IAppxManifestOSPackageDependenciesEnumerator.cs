// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B84E2FC3-F8EC-4BC1-8AE2-156346F5FFEA")]
    [NativeTypeName("struct IAppxManifestOSPackageDependenciesEnumerator : IUnknown")]
    public unsafe partial struct IAppxManifestOSPackageDependenciesEnumerator
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxManifestOSPackageDependenciesEnumerator*, Guid*, void**, int>)(lpVtbl[0]))((IAppxManifestOSPackageDependenciesEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxManifestOSPackageDependenciesEnumerator*, uint>)(lpVtbl[1]))((IAppxManifestOSPackageDependenciesEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxManifestOSPackageDependenciesEnumerator*, uint>)(lpVtbl[2]))((IAppxManifestOSPackageDependenciesEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrent(IAppxManifestOSPackageDependency** osPackageDependency)
        {
            return ((delegate* unmanaged<IAppxManifestOSPackageDependenciesEnumerator*, IAppxManifestOSPackageDependency**, int>)(lpVtbl[3]))((IAppxManifestOSPackageDependenciesEnumerator*)Unsafe.AsPointer(ref this), osPackageDependency);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetHasCurrent([NativeTypeName("BOOL *")] int* hasCurrent)
        {
            return ((delegate* unmanaged<IAppxManifestOSPackageDependenciesEnumerator*, int*, int>)(lpVtbl[4]))((IAppxManifestOSPackageDependenciesEnumerator*)Unsafe.AsPointer(ref this), hasCurrent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MoveNext([NativeTypeName("BOOL *")] int* hasNext)
        {
            return ((delegate* unmanaged<IAppxManifestOSPackageDependenciesEnumerator*, int*, int>)(lpVtbl[5]))((IAppxManifestOSPackageDependenciesEnumerator*)Unsafe.AsPointer(ref this), hasNext);
        }
    }
}
