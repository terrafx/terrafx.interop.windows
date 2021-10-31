// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D0191542-7954-4908-BC06-B2360BBE45BA")]
    [NativeTypeName("struct IEnumFullIDList : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IEnumFullIDList
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IEnumFullIDList*, Guid*, void**, int>)(lpVtbl[0]))((IEnumFullIDList*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEnumFullIDList*, uint>)(lpVtbl[1]))((IEnumFullIDList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEnumFullIDList*, uint>)(lpVtbl[2]))((IEnumFullIDList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Next([NativeTypeName("ULONG")] uint celt, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
        {
            return ((delegate* unmanaged<IEnumFullIDList*, uint, ITEMIDLIST**, uint*, int>)(lpVtbl[3]))((IEnumFullIDList*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Skip([NativeTypeName("ULONG")] uint celt)
        {
            return ((delegate* unmanaged<IEnumFullIDList*, uint, int>)(lpVtbl[4]))((IEnumFullIDList*)Unsafe.AsPointer(ref this), celt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Reset()
        {
            return ((delegate* unmanaged<IEnumFullIDList*, int>)(lpVtbl[5]))((IEnumFullIDList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Clone(IEnumFullIDList** ppenum)
        {
            return ((delegate* unmanaged<IEnumFullIDList*, IEnumFullIDList**, int>)(lpVtbl[6]))((IEnumFullIDList*)Unsafe.AsPointer(ref this), ppenum);
        }
    }
}
