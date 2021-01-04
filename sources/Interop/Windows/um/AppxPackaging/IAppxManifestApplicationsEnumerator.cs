// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9EB8A55A-F04B-4D0D-808D-686185D4847A")]
    [NativeTypeName("struct IAppxManifestApplicationsEnumerator : IUnknown")]
    public unsafe partial struct IAppxManifestApplicationsEnumerator
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxManifestApplicationsEnumerator*, Guid*, void**, int>)(lpVtbl[0]))((IAppxManifestApplicationsEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxManifestApplicationsEnumerator*, uint>)(lpVtbl[1]))((IAppxManifestApplicationsEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxManifestApplicationsEnumerator*, uint>)(lpVtbl[2]))((IAppxManifestApplicationsEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrent([NativeTypeName("IAppxManifestApplication **")] IAppxManifestApplication** application)
        {
            return ((delegate* unmanaged<IAppxManifestApplicationsEnumerator*, IAppxManifestApplication**, int>)(lpVtbl[3]))((IAppxManifestApplicationsEnumerator*)Unsafe.AsPointer(ref this), application);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetHasCurrent([NativeTypeName("BOOL *")] int* hasCurrent)
        {
            return ((delegate* unmanaged<IAppxManifestApplicationsEnumerator*, int*, int>)(lpVtbl[4]))((IAppxManifestApplicationsEnumerator*)Unsafe.AsPointer(ref this), hasCurrent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MoveNext([NativeTypeName("BOOL *")] int* hasNext)
        {
            return ((delegate* unmanaged<IAppxManifestApplicationsEnumerator*, int*, int>)(lpVtbl[5]))((IAppxManifestApplicationsEnumerator*)Unsafe.AsPointer(ref this), hasNext);
        }
    }
}
