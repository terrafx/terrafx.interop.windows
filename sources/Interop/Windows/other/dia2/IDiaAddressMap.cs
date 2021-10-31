// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B62A2E7A-067A-4EA3-B598-04C09717502C")]
    [NativeTypeName("struct IDiaAddressMap : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDiaAddressMap
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDiaAddressMap*, Guid*, void**, int>)(lpVtbl[0]))((IDiaAddressMap*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDiaAddressMap*, uint>)(lpVtbl[1]))((IDiaAddressMap*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDiaAddressMap*, uint>)(lpVtbl[2]))((IDiaAddressMap*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT get_addressMapEnabled(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaAddressMap*, BOOL*, int>)(lpVtbl[3]))((IDiaAddressMap*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT put_addressMapEnabled(BOOL NewVal)
        {
            return ((delegate* unmanaged<IDiaAddressMap*, BOOL, int>)(lpVtbl[4]))((IDiaAddressMap*)Unsafe.AsPointer(ref this), NewVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT get_relativeVirtualAddressEnabled(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaAddressMap*, BOOL*, int>)(lpVtbl[5]))((IDiaAddressMap*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT put_relativeVirtualAddressEnabled(BOOL NewVal)
        {
            return ((delegate* unmanaged<IDiaAddressMap*, BOOL, int>)(lpVtbl[6]))((IDiaAddressMap*)Unsafe.AsPointer(ref this), NewVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_imageAlign([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaAddressMap*, uint*, int>)(lpVtbl[7]))((IDiaAddressMap*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT put_imageAlign([NativeTypeName("DWORD")] uint NewVal)
        {
            return ((delegate* unmanaged<IDiaAddressMap*, uint, int>)(lpVtbl[8]))((IDiaAddressMap*)Unsafe.AsPointer(ref this), NewVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT set_imageHeaders([NativeTypeName("DWORD")] uint cbData, [NativeTypeName("BYTE *")] byte* pbData, BOOL originalHeaders)
        {
            return ((delegate* unmanaged<IDiaAddressMap*, uint, byte*, BOOL, int>)(lpVtbl[9]))((IDiaAddressMap*)Unsafe.AsPointer(ref this), cbData, pbData, originalHeaders);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT set_addressMap([NativeTypeName("DWORD")] uint cData, [NativeTypeName("struct DiaAddressMapEntry *")] DiaAddressMapEntry* pData, BOOL imageToSymbols)
        {
            return ((delegate* unmanaged<IDiaAddressMap*, uint, DiaAddressMapEntry*, BOOL, int>)(lpVtbl[10]))((IDiaAddressMap*)Unsafe.AsPointer(ref this), cData, pData, imageToSymbols);
        }
    }
}
