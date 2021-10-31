// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6427A646-7F49-433E-B1A6-0DA309F6885A")]
    [NativeTypeName("struct IAppxManifestHostRuntimeDependenciesEnumerator : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAppxManifestHostRuntimeDependenciesEnumerator
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxManifestHostRuntimeDependenciesEnumerator*, Guid*, void**, int>)(lpVtbl[0]))((IAppxManifestHostRuntimeDependenciesEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxManifestHostRuntimeDependenciesEnumerator*, uint>)(lpVtbl[1]))((IAppxManifestHostRuntimeDependenciesEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxManifestHostRuntimeDependenciesEnumerator*, uint>)(lpVtbl[2]))((IAppxManifestHostRuntimeDependenciesEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrent(IAppxManifestHostRuntimeDependency** hostRuntimeDependency)
        {
            return ((delegate* unmanaged<IAppxManifestHostRuntimeDependenciesEnumerator*, IAppxManifestHostRuntimeDependency**, int>)(lpVtbl[3]))((IAppxManifestHostRuntimeDependenciesEnumerator*)Unsafe.AsPointer(ref this), hostRuntimeDependency);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetHasCurrent(BOOL* hasCurrent)
        {
            return ((delegate* unmanaged<IAppxManifestHostRuntimeDependenciesEnumerator*, BOOL*, int>)(lpVtbl[4]))((IAppxManifestHostRuntimeDependenciesEnumerator*)Unsafe.AsPointer(ref this), hasCurrent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int MoveNext(BOOL* hasNext)
        {
            return ((delegate* unmanaged<IAppxManifestHostRuntimeDependenciesEnumerator*, BOOL*, int>)(lpVtbl[5]))((IAppxManifestHostRuntimeDependenciesEnumerator*)Unsafe.AsPointer(ref this), hasNext);
        }
    }
}
