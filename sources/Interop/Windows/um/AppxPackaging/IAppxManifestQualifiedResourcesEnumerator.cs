// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8EF6ADFE-3762-4A8F-9373-2FC5D444C8D2")]
    [NativeTypeName("struct IAppxManifestQualifiedResourcesEnumerator : IUnknown")]
    public unsafe partial struct IAppxManifestQualifiedResourcesEnumerator
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxManifestQualifiedResourcesEnumerator*, Guid*, void**, int>)(lpVtbl[0]))((IAppxManifestQualifiedResourcesEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxManifestQualifiedResourcesEnumerator*, uint>)(lpVtbl[1]))((IAppxManifestQualifiedResourcesEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxManifestQualifiedResourcesEnumerator*, uint>)(lpVtbl[2]))((IAppxManifestQualifiedResourcesEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrent(IAppxManifestQualifiedResource** resource)
        {
            return ((delegate* unmanaged<IAppxManifestQualifiedResourcesEnumerator*, IAppxManifestQualifiedResource**, int>)(lpVtbl[3]))((IAppxManifestQualifiedResourcesEnumerator*)Unsafe.AsPointer(ref this), resource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetHasCurrent([NativeTypeName("BOOL *")] int* hasCurrent)
        {
            return ((delegate* unmanaged<IAppxManifestQualifiedResourcesEnumerator*, int*, int>)(lpVtbl[4]))((IAppxManifestQualifiedResourcesEnumerator*)Unsafe.AsPointer(ref this), hasCurrent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MoveNext([NativeTypeName("BOOL *")] int* hasNext)
        {
            return ((delegate* unmanaged<IAppxManifestQualifiedResourcesEnumerator*, int*, int>)(lpVtbl[5]))((IAppxManifestQualifiedResourcesEnumerator*)Unsafe.AsPointer(ref this), hasNext);
        }
    }
}
