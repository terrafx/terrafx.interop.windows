// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000105-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IEnumSTATDATA : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IEnumSTATDATA
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IEnumSTATDATA*, Guid*, void**, int>)(lpVtbl[0]))((IEnumSTATDATA*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEnumSTATDATA*, uint>)(lpVtbl[1]))((IEnumSTATDATA*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEnumSTATDATA*, uint>)(lpVtbl[2]))((IEnumSTATDATA*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint celt, STATDATA* rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
        {
            return ((delegate* unmanaged<IEnumSTATDATA*, uint, STATDATA*, uint*, int>)(lpVtbl[3]))((IEnumSTATDATA*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint celt)
        {
            return ((delegate* unmanaged<IEnumSTATDATA*, uint, int>)(lpVtbl[4]))((IEnumSTATDATA*)Unsafe.AsPointer(ref this), celt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged<IEnumSTATDATA*, int>)(lpVtbl[5]))((IEnumSTATDATA*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Clone(IEnumSTATDATA** ppenum)
        {
            return ((delegate* unmanaged<IEnumSTATDATA*, IEnumSTATDATA**, int>)(lpVtbl[6]))((IEnumSTATDATA*)Unsafe.AsPointer(ref this), ppenum);
        }
    }
}
