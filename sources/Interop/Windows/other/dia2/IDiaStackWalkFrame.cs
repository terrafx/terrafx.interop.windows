// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("07C590C1-438D-4F47-BDCD-4397BC81AD75")]
    [NativeTypeName("struct IDiaStackWalkFrame : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDiaStackWalkFrame
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDiaStackWalkFrame*, Guid*, void**, int>)(lpVtbl[0]))((IDiaStackWalkFrame*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDiaStackWalkFrame*, uint>)(lpVtbl[1]))((IDiaStackWalkFrame*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDiaStackWalkFrame*, uint>)(lpVtbl[2]))((IDiaStackWalkFrame*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT get_registerValue([NativeTypeName("DWORD")] uint index, [NativeTypeName("ULONGLONG *")] ulong* pRetVal)
        {
            return ((delegate* unmanaged<IDiaStackWalkFrame*, uint, ulong*, int>)(lpVtbl[3]))((IDiaStackWalkFrame*)Unsafe.AsPointer(ref this), index, pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT put_registerValue([NativeTypeName("DWORD")] uint index, [NativeTypeName("ULONGLONG")] ulong NewVal)
        {
            return ((delegate* unmanaged<IDiaStackWalkFrame*, uint, ulong, int>)(lpVtbl[4]))((IDiaStackWalkFrame*)Unsafe.AsPointer(ref this), index, NewVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT readMemory([NativeTypeName("enum MemoryTypeEnum")] MemoryTypeEnum type, [NativeTypeName("ULONGLONG")] ulong va, [NativeTypeName("DWORD")] uint cbData, [NativeTypeName("DWORD *")] uint* pcbData, byte* pbData)
        {
            return ((delegate* unmanaged<IDiaStackWalkFrame*, MemoryTypeEnum, ulong, uint, uint*, byte*, int>)(lpVtbl[5]))((IDiaStackWalkFrame*)Unsafe.AsPointer(ref this), type, va, cbData, pcbData, pbData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT searchForReturnAddress(IDiaFrameData* frame, [NativeTypeName("ULONGLONG *")] ulong* returnAddress)
        {
            return ((delegate* unmanaged<IDiaStackWalkFrame*, IDiaFrameData*, ulong*, int>)(lpVtbl[6]))((IDiaStackWalkFrame*)Unsafe.AsPointer(ref this), frame, returnAddress);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT searchForReturnAddressStart(IDiaFrameData* frame, [NativeTypeName("ULONGLONG")] ulong startAddress, [NativeTypeName("ULONGLONG *")] ulong* returnAddress)
        {
            return ((delegate* unmanaged<IDiaStackWalkFrame*, IDiaFrameData*, ulong, ulong*, int>)(lpVtbl[7]))((IDiaStackWalkFrame*)Unsafe.AsPointer(ref this), frame, startAddress, returnAddress);
        }
    }
}
