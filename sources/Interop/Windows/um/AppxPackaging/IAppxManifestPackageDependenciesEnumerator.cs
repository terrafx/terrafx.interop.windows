// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B43BBCF9-65A6-42DD-BAC0-8C6741E7F5A4")]
    [NativeTypeName("struct IAppxManifestPackageDependenciesEnumerator : IUnknown")]
    public unsafe partial struct IAppxManifestPackageDependenciesEnumerator
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxManifestPackageDependenciesEnumerator*, Guid*, void**, int>)(lpVtbl[0]))((IAppxManifestPackageDependenciesEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxManifestPackageDependenciesEnumerator*, uint>)(lpVtbl[1]))((IAppxManifestPackageDependenciesEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxManifestPackageDependenciesEnumerator*, uint>)(lpVtbl[2]))((IAppxManifestPackageDependenciesEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrent(IAppxManifestPackageDependency** dependency)
        {
            return ((delegate* unmanaged<IAppxManifestPackageDependenciesEnumerator*, IAppxManifestPackageDependency**, int>)(lpVtbl[3]))((IAppxManifestPackageDependenciesEnumerator*)Unsafe.AsPointer(ref this), dependency);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetHasCurrent([NativeTypeName("BOOL *")] int* hasCurrent)
        {
            return ((delegate* unmanaged<IAppxManifestPackageDependenciesEnumerator*, int*, int>)(lpVtbl[4]))((IAppxManifestPackageDependenciesEnumerator*)Unsafe.AsPointer(ref this), hasCurrent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MoveNext([NativeTypeName("BOOL *")] int* hasNext)
        {
            return ((delegate* unmanaged<IAppxManifestPackageDependenciesEnumerator*, int*, int>)(lpVtbl[5]))((IAppxManifestPackageDependenciesEnumerator*)Unsafe.AsPointer(ref this), hasNext);
        }
    }
}
