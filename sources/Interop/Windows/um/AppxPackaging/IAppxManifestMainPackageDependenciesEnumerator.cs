// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A99C4F00-51D2-4F0F-BA46-7ED5255EBDFF")]
    [NativeTypeName("struct IAppxManifestMainPackageDependenciesEnumerator : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAppxManifestMainPackageDependenciesEnumerator
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxManifestMainPackageDependenciesEnumerator*, Guid*, void**, int>)(lpVtbl[0]))((IAppxManifestMainPackageDependenciesEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxManifestMainPackageDependenciesEnumerator*, uint>)(lpVtbl[1]))((IAppxManifestMainPackageDependenciesEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxManifestMainPackageDependenciesEnumerator*, uint>)(lpVtbl[2]))((IAppxManifestMainPackageDependenciesEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrent(IAppxManifestMainPackageDependency** mainPackageDependency)
        {
            return ((delegate* unmanaged<IAppxManifestMainPackageDependenciesEnumerator*, IAppxManifestMainPackageDependency**, int>)(lpVtbl[3]))((IAppxManifestMainPackageDependenciesEnumerator*)Unsafe.AsPointer(ref this), mainPackageDependency);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetHasCurrent([NativeTypeName("BOOL *")] int* hasCurrent)
        {
            return ((delegate* unmanaged<IAppxManifestMainPackageDependenciesEnumerator*, int*, int>)(lpVtbl[4]))((IAppxManifestMainPackageDependenciesEnumerator*)Unsafe.AsPointer(ref this), hasCurrent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int MoveNext([NativeTypeName("BOOL *")] int* hasNext)
        {
            return ((delegate* unmanaged<IAppxManifestMainPackageDependenciesEnumerator*, int*, int>)(lpVtbl[5]))((IAppxManifestMainPackageDependenciesEnumerator*)Unsafe.AsPointer(ref this), hasNext);
        }
    }
}
