// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1994DEB2-2C82-4B1D-A57F-AFF424D54A68")]
    [NativeTypeName("struct IDiaEnumSectionContribs : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDiaEnumSectionContribs
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDiaEnumSectionContribs*, Guid*, void**, int>)(lpVtbl[0]))((IDiaEnumSectionContribs*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDiaEnumSectionContribs*, uint>)(lpVtbl[1]))((IDiaEnumSectionContribs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDiaEnumSectionContribs*, uint>)(lpVtbl[2]))((IDiaEnumSectionContribs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int get__NewEnum(IUnknown** pRetVal)
        {
            return ((delegate* unmanaged<IDiaEnumSectionContribs*, IUnknown**, int>)(lpVtbl[3]))((IDiaEnumSectionContribs*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int get_Count([NativeTypeName("LONG *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaEnumSectionContribs*, int*, int>)(lpVtbl[4]))((IDiaEnumSectionContribs*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int Item([NativeTypeName("DWORD")] uint index, IDiaSectionContrib** section)
        {
            return ((delegate* unmanaged<IDiaEnumSectionContribs*, uint, IDiaSectionContrib**, int>)(lpVtbl[5]))((IDiaEnumSectionContribs*)Unsafe.AsPointer(ref this), index, section);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint celt, IDiaSectionContrib** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
        {
            return ((delegate* unmanaged<IDiaEnumSectionContribs*, uint, IDiaSectionContrib**, uint*, int>)(lpVtbl[6]))((IDiaEnumSectionContribs*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint celt)
        {
            return ((delegate* unmanaged<IDiaEnumSectionContribs*, uint, int>)(lpVtbl[7]))((IDiaEnumSectionContribs*)Unsafe.AsPointer(ref this), celt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged<IDiaEnumSectionContribs*, int>)(lpVtbl[8]))((IDiaEnumSectionContribs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int Clone(IDiaEnumSectionContribs** ppenum)
        {
            return ((delegate* unmanaged<IDiaEnumSectionContribs*, IDiaEnumSectionContribs**, int>)(lpVtbl[9]))((IDiaEnumSectionContribs*)Unsafe.AsPointer(ref this), ppenum);
        }
    }
}
