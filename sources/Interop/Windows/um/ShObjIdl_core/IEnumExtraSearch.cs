// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0E700BE1-9DB6-11D1-A1CE-00C04FD75D13")]
    [NativeTypeName("struct IEnumExtraSearch : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IEnumExtraSearch
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IEnumExtraSearch*, Guid*, void**, int>)(lpVtbl[0]))((IEnumExtraSearch*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEnumExtraSearch*, uint>)(lpVtbl[1]))((IEnumExtraSearch*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEnumExtraSearch*, uint>)(lpVtbl[2]))((IEnumExtraSearch*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Next([NativeTypeName("ULONG")] uint celt, EXTRASEARCH* rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
        {
            return ((delegate* unmanaged<IEnumExtraSearch*, uint, EXTRASEARCH*, uint*, int>)(lpVtbl[3]))((IEnumExtraSearch*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Skip([NativeTypeName("ULONG")] uint celt)
        {
            return ((delegate* unmanaged<IEnumExtraSearch*, uint, int>)(lpVtbl[4]))((IEnumExtraSearch*)Unsafe.AsPointer(ref this), celt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Reset()
        {
            return ((delegate* unmanaged<IEnumExtraSearch*, int>)(lpVtbl[5]))((IEnumExtraSearch*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Clone(IEnumExtraSearch** ppenum)
        {
            return ((delegate* unmanaged<IEnumExtraSearch*, IEnumExtraSearch**, int>)(lpVtbl[6]))((IEnumExtraSearch*)Unsafe.AsPointer(ref this), ppenum);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumExtraSearch*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumExtraSearch*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumExtraSearch*, uint> Release;

            [NativeTypeName("HRESULT (ULONG, EXTRASEARCH *, ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumExtraSearch*, uint, EXTRASEARCH*, uint*, int> Next;

            [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumExtraSearch*, uint, int> Skip;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumExtraSearch*, int> Reset;

            [NativeTypeName("HRESULT (IEnumExtraSearch **) __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumExtraSearch*, IEnumExtraSearch**, int> Clone;
        }
    }
}
