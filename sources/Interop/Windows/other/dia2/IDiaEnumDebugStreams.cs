// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("08CBB41E-47A6-4F87-92F1-1C9C87CED044")]
    [NativeTypeName("struct IDiaEnumDebugStreams : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDiaEnumDebugStreams
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDiaEnumDebugStreams*, Guid*, void**, int>)(lpVtbl[0]))((IDiaEnumDebugStreams*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDiaEnumDebugStreams*, uint>)(lpVtbl[1]))((IDiaEnumDebugStreams*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDiaEnumDebugStreams*, uint>)(lpVtbl[2]))((IDiaEnumDebugStreams*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int get__NewEnum(IUnknown** pRetVal)
        {
            return ((delegate* unmanaged<IDiaEnumDebugStreams*, IUnknown**, int>)(lpVtbl[3]))((IDiaEnumDebugStreams*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int get_Count([NativeTypeName("LONG *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaEnumDebugStreams*, int*, int>)(lpVtbl[4]))((IDiaEnumDebugStreams*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int Item(VARIANT index, IDiaEnumDebugStreamData** stream)
        {
            return ((delegate* unmanaged<IDiaEnumDebugStreams*, VARIANT, IDiaEnumDebugStreamData**, int>)(lpVtbl[5]))((IDiaEnumDebugStreams*)Unsafe.AsPointer(ref this), index, stream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint celt, IDiaEnumDebugStreamData** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
        {
            return ((delegate* unmanaged<IDiaEnumDebugStreams*, uint, IDiaEnumDebugStreamData**, uint*, int>)(lpVtbl[6]))((IDiaEnumDebugStreams*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint celt)
        {
            return ((delegate* unmanaged<IDiaEnumDebugStreams*, uint, int>)(lpVtbl[7]))((IDiaEnumDebugStreams*)Unsafe.AsPointer(ref this), celt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged<IDiaEnumDebugStreams*, int>)(lpVtbl[8]))((IDiaEnumDebugStreams*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int Clone(IDiaEnumDebugStreams** ppenum)
        {
            return ((delegate* unmanaged<IDiaEnumDebugStreams*, IDiaEnumDebugStreams**, int>)(lpVtbl[9]))((IDiaEnumDebugStreams*)Unsafe.AsPointer(ref this), ppenum);
        }
    }
}
