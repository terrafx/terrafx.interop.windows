// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00020404-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IEnumVARIANT : IUnknown")]
    public unsafe partial struct IEnumVARIANT
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IEnumVARIANT*, Guid*, void**, int>)(lpVtbl[0]))((IEnumVARIANT*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEnumVARIANT*, uint>)(lpVtbl[1]))((IEnumVARIANT*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEnumVARIANT*, uint>)(lpVtbl[2]))((IEnumVARIANT*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint celt, VARIANT* rgVar, [NativeTypeName("ULONG *")] uint* pCeltFetched)
        {
            return ((delegate* unmanaged<IEnumVARIANT*, uint, VARIANT*, uint*, int>)(lpVtbl[3]))((IEnumVARIANT*)Unsafe.AsPointer(ref this), celt, rgVar, pCeltFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint celt)
        {
            return ((delegate* unmanaged<IEnumVARIANT*, uint, int>)(lpVtbl[4]))((IEnumVARIANT*)Unsafe.AsPointer(ref this), celt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged<IEnumVARIANT*, int>)(lpVtbl[5]))((IEnumVARIANT*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Clone(IEnumVARIANT** ppEnum)
        {
            return ((delegate* unmanaged<IEnumVARIANT*, IEnumVARIANT**, int>)(lpVtbl[6]))((IEnumVARIANT*)Unsafe.AsPointer(ref this), ppEnum);
        }
    }
}
