// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("11D22258-F470-42C1-B291-8361C5437E41")]
    [NativeTypeName("struct IAppxManifestCapabilitiesEnumerator : IUnknown")]
    public unsafe partial struct IAppxManifestCapabilitiesEnumerator
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxManifestCapabilitiesEnumerator*, Guid*, void**, int>)(lpVtbl[0]))((IAppxManifestCapabilitiesEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxManifestCapabilitiesEnumerator*, uint>)(lpVtbl[1]))((IAppxManifestCapabilitiesEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxManifestCapabilitiesEnumerator*, uint>)(lpVtbl[2]))((IAppxManifestCapabilitiesEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrent([NativeTypeName("LPWSTR *")] ushort** capability)
        {
            return ((delegate* unmanaged<IAppxManifestCapabilitiesEnumerator*, ushort**, int>)(lpVtbl[3]))((IAppxManifestCapabilitiesEnumerator*)Unsafe.AsPointer(ref this), capability);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetHasCurrent([NativeTypeName("BOOL *")] int* hasCurrent)
        {
            return ((delegate* unmanaged<IAppxManifestCapabilitiesEnumerator*, int*, int>)(lpVtbl[4]))((IAppxManifestCapabilitiesEnumerator*)Unsafe.AsPointer(ref this), hasCurrent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MoveNext([NativeTypeName("BOOL *")] int* hasNext)
        {
            return ((delegate* unmanaged<IAppxManifestCapabilitiesEnumerator*, int*, int>)(lpVtbl[5]))((IAppxManifestCapabilitiesEnumerator*)Unsafe.AsPointer(ref this), hasNext);
        }
    }
}
