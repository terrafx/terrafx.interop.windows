// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DE4DFBBD-881A-48BB-858C-D6F2BAEAE6ED")]
    [NativeTypeName("struct IAppxManifestResourcesEnumerator : IUnknown")]
    public unsafe partial struct IAppxManifestResourcesEnumerator
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxManifestResourcesEnumerator*, Guid*, void**, int>)(lpVtbl[0]))((IAppxManifestResourcesEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxManifestResourcesEnumerator*, uint>)(lpVtbl[1]))((IAppxManifestResourcesEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxManifestResourcesEnumerator*, uint>)(lpVtbl[2]))((IAppxManifestResourcesEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrent([NativeTypeName("LPWSTR *")] ushort** resource)
        {
            return ((delegate* unmanaged<IAppxManifestResourcesEnumerator*, ushort**, int>)(lpVtbl[3]))((IAppxManifestResourcesEnumerator*)Unsafe.AsPointer(ref this), resource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetHasCurrent([NativeTypeName("BOOL *")] int* hasCurrent)
        {
            return ((delegate* unmanaged<IAppxManifestResourcesEnumerator*, int*, int>)(lpVtbl[4]))((IAppxManifestResourcesEnumerator*)Unsafe.AsPointer(ref this), hasCurrent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MoveNext([NativeTypeName("BOOL *")] int* hasNext)
        {
            return ((delegate* unmanaged<IAppxManifestResourcesEnumerator*, int*, int>)(lpVtbl[5]))((IAppxManifestResourcesEnumerator*)Unsafe.AsPointer(ref this), hasNext);
        }
    }
}
