// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mediaobj.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2C3CD98A-2BFA-4A53-9C27-5249BA64BA0F")]
    [NativeTypeName("struct IEnumDMO : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IEnumDMO
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IEnumDMO*, Guid*, void**, int>)(lpVtbl[0]))((IEnumDMO*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEnumDMO*, uint>)(lpVtbl[1]))((IEnumDMO*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEnumDMO*, uint>)(lpVtbl[2]))((IEnumDMO*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Next([NativeTypeName("DWORD")] uint cItemsToFetch, [NativeTypeName("CLSID *")] Guid* pCLSID, [NativeTypeName("LPWSTR *")] ushort** Names, [NativeTypeName("DWORD *")] uint* pcItemsFetched)
        {
            return ((delegate* unmanaged<IEnumDMO*, uint, Guid*, ushort**, uint*, int>)(lpVtbl[3]))((IEnumDMO*)Unsafe.AsPointer(ref this), cItemsToFetch, pCLSID, Names, pcItemsFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Skip([NativeTypeName("DWORD")] uint cItemsToSkip)
        {
            return ((delegate* unmanaged<IEnumDMO*, uint, int>)(lpVtbl[4]))((IEnumDMO*)Unsafe.AsPointer(ref this), cItemsToSkip);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Reset()
        {
            return ((delegate* unmanaged<IEnumDMO*, int>)(lpVtbl[5]))((IEnumDMO*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Clone(IEnumDMO** ppEnum)
        {
            return ((delegate* unmanaged<IEnumDMO*, IEnumDMO**, int>)(lpVtbl[6]))((IEnumDMO*)Unsafe.AsPointer(ref this), ppEnum);
        }
    }
}
