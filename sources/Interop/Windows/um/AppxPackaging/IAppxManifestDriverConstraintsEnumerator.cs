// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D402B2D1-F600-49E0-95E6-975D8DA13D89")]
    [NativeTypeName("struct IAppxManifestDriverConstraintsEnumerator : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAppxManifestDriverConstraintsEnumerator
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxManifestDriverConstraintsEnumerator*, Guid*, void**, int>)(lpVtbl[0]))((IAppxManifestDriverConstraintsEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxManifestDriverConstraintsEnumerator*, uint>)(lpVtbl[1]))((IAppxManifestDriverConstraintsEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxManifestDriverConstraintsEnumerator*, uint>)(lpVtbl[2]))((IAppxManifestDriverConstraintsEnumerator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrent(IAppxManifestDriverConstraint** driverConstraint)
        {
            return ((delegate* unmanaged<IAppxManifestDriverConstraintsEnumerator*, IAppxManifestDriverConstraint**, int>)(lpVtbl[3]))((IAppxManifestDriverConstraintsEnumerator*)Unsafe.AsPointer(ref this), driverConstraint);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetHasCurrent(BOOL* hasCurrent)
        {
            return ((delegate* unmanaged<IAppxManifestDriverConstraintsEnumerator*, BOOL*, int>)(lpVtbl[4]))((IAppxManifestDriverConstraintsEnumerator*)Unsafe.AsPointer(ref this), hasCurrent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int MoveNext(BOOL* hasNext)
        {
            return ((delegate* unmanaged<IAppxManifestDriverConstraintsEnumerator*, BOOL*, int>)(lpVtbl[5]))((IAppxManifestDriverConstraintsEnumerator*)Unsafe.AsPointer(ref this), hasNext);
        }
    }
}
