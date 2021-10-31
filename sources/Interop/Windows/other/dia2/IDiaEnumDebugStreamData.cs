// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("486943E8-D187-4A6B-A3C4-291259FFF60D")]
    [NativeTypeName("struct IDiaEnumDebugStreamData : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDiaEnumDebugStreamData
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDiaEnumDebugStreamData*, Guid*, void**, int>)(lpVtbl[0]))((IDiaEnumDebugStreamData*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDiaEnumDebugStreamData*, uint>)(lpVtbl[1]))((IDiaEnumDebugStreamData*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDiaEnumDebugStreamData*, uint>)(lpVtbl[2]))((IDiaEnumDebugStreamData*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT get__NewEnum(IUnknown** pRetVal)
        {
            return ((delegate* unmanaged<IDiaEnumDebugStreamData*, IUnknown**, int>)(lpVtbl[3]))((IDiaEnumDebugStreamData*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT get_Count([NativeTypeName("LONG *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaEnumDebugStreamData*, int*, int>)(lpVtbl[4]))((IDiaEnumDebugStreamData*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT get_name([NativeTypeName("BSTR *")] ushort** pRetVal)
        {
            return ((delegate* unmanaged<IDiaEnumDebugStreamData*, ushort**, int>)(lpVtbl[5]))((IDiaEnumDebugStreamData*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Item([NativeTypeName("DWORD")] uint index, [NativeTypeName("DWORD")] uint cbData, [NativeTypeName("DWORD *")] uint* pcbData, byte* pbData)
        {
            return ((delegate* unmanaged<IDiaEnumDebugStreamData*, uint, uint, uint*, byte*, int>)(lpVtbl[6]))((IDiaEnumDebugStreamData*)Unsafe.AsPointer(ref this), index, cbData, pcbData, pbData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT Next([NativeTypeName("ULONG")] uint celt, [NativeTypeName("DWORD")] uint cbData, [NativeTypeName("DWORD *")] uint* pcbData, byte* pbData, [NativeTypeName("ULONG *")] uint* pceltFetched)
        {
            return ((delegate* unmanaged<IDiaEnumDebugStreamData*, uint, uint, uint*, byte*, uint*, int>)(lpVtbl[7]))((IDiaEnumDebugStreamData*)Unsafe.AsPointer(ref this), celt, cbData, pcbData, pbData, pceltFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT Skip([NativeTypeName("ULONG")] uint celt)
        {
            return ((delegate* unmanaged<IDiaEnumDebugStreamData*, uint, int>)(lpVtbl[8]))((IDiaEnumDebugStreamData*)Unsafe.AsPointer(ref this), celt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT Reset()
        {
            return ((delegate* unmanaged<IDiaEnumDebugStreamData*, int>)(lpVtbl[9]))((IDiaEnumDebugStreamData*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT Clone(IDiaEnumDebugStreamData** ppenum)
        {
            return ((delegate* unmanaged<IDiaEnumDebugStreamData*, IDiaEnumDebugStreamData**, int>)(lpVtbl[10]))((IDiaEnumDebugStreamData*)Unsafe.AsPointer(ref this), ppenum);
        }
    }
}
