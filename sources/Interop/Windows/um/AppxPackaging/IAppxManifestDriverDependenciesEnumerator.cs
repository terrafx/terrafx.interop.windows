// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FE039DB2-467F-4755-8404-8F5EB6865B33")]
    [NativeTypeName("struct IAppxManifestDriverDependenciesEnumerator : IUnknown")]
    public unsafe partial struct IAppxManifestDriverDependenciesEnumerator
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxManifestDriverDependenciesEnumerator*, Guid*, void**, int>)(lpVtbl[0]))((IAppxManifestDriverDependenciesEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxManifestDriverDependenciesEnumerator*, uint>)(lpVtbl[1]))((IAppxManifestDriverDependenciesEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxManifestDriverDependenciesEnumerator*, uint>)(lpVtbl[2]))((IAppxManifestDriverDependenciesEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrent([NativeTypeName("IAppxManifestDriverDependency **")] IAppxManifestDriverDependency** driverDependency)
        {
            return ((delegate* unmanaged<IAppxManifestDriverDependenciesEnumerator*, IAppxManifestDriverDependency**, int>)(lpVtbl[3]))((IAppxManifestDriverDependenciesEnumerator*)Unsafe.AsPointer(ref this), driverDependency);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetHasCurrent([NativeTypeName("BOOL *")] int* hasCurrent)
        {
            return ((delegate* unmanaged<IAppxManifestDriverDependenciesEnumerator*, int*, int>)(lpVtbl[4]))((IAppxManifestDriverDependenciesEnumerator*)Unsafe.AsPointer(ref this), hasCurrent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MoveNext([NativeTypeName("BOOL *")] int* hasNext)
        {
            return ((delegate* unmanaged<IAppxManifestDriverDependenciesEnumerator*, int*, int>)(lpVtbl[5]))((IAppxManifestDriverDependenciesEnumerator*)Unsafe.AsPointer(ref this), hasNext);
        }
    }
}
