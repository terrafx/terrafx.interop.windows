// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='IDiaStackWalkHelper2.xml' path='doc/member[@name="IDiaStackWalkHelper2"]/*' />
[Guid("8222C490-507B-4BEF-B3BD-41DCA7B5934C")]
[NativeTypeName("struct IDiaStackWalkHelper2 : IDiaStackWalkHelper")]
[NativeInheritance("IDiaStackWalkHelper")]
public unsafe partial struct IDiaStackWalkHelper2 : IDiaStackWalkHelper2.Interface
{
    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDiaStackWalkHelper2*, Guid*, void**, int>)(lpVtbl[0]))((IDiaStackWalkHelper2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDiaStackWalkHelper2*, uint>)(lpVtbl[1]))((IDiaStackWalkHelper2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDiaStackWalkHelper2*, uint>)(lpVtbl[2]))((IDiaStackWalkHelper2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDiaStackWalkHelper.get_registerValue" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_registerValue([NativeTypeName("DWORD")] uint index, [NativeTypeName("ULONGLONG *")] ulong* pRetVal)
    {
        return ((delegate* unmanaged<IDiaStackWalkHelper2*, uint, ulong*, int>)(lpVtbl[3]))((IDiaStackWalkHelper2*)Unsafe.AsPointer(ref this), index, pRetVal);
    }

    /// <inheritdoc cref="IDiaStackWalkHelper.put_registerValue" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT put_registerValue([NativeTypeName("DWORD")] uint index, [NativeTypeName("ULONGLONG")] ulong NewVal)
    {
        return ((delegate* unmanaged<IDiaStackWalkHelper2*, uint, ulong, int>)(lpVtbl[4]))((IDiaStackWalkHelper2*)Unsafe.AsPointer(ref this), index, NewVal);
    }

    /// <inheritdoc cref="IDiaStackWalkHelper.readMemory" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT readMemory([NativeTypeName("enum MemoryTypeEnum")] MemoryTypeEnum type, [NativeTypeName("ULONGLONG")] ulong va, [NativeTypeName("DWORD")] uint cbData, [NativeTypeName("DWORD *")] uint* pcbData, byte* pbData)
    {
        return ((delegate* unmanaged<IDiaStackWalkHelper2*, MemoryTypeEnum, ulong, uint, uint*, byte*, int>)(lpVtbl[5]))((IDiaStackWalkHelper2*)Unsafe.AsPointer(ref this), type, va, cbData, pcbData, pbData);
    }

    /// <inheritdoc cref="IDiaStackWalkHelper.searchForReturnAddress" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT searchForReturnAddress(IDiaFrameData* frame, [NativeTypeName("ULONGLONG *")] ulong* returnAddress)
    {
        return ((delegate* unmanaged<IDiaStackWalkHelper2*, IDiaFrameData*, ulong*, int>)(lpVtbl[6]))((IDiaStackWalkHelper2*)Unsafe.AsPointer(ref this), frame, returnAddress);
    }

    /// <inheritdoc cref="IDiaStackWalkHelper.searchForReturnAddressStart" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT searchForReturnAddressStart(IDiaFrameData* frame, [NativeTypeName("ULONGLONG")] ulong startAddress, [NativeTypeName("ULONGLONG *")] ulong* returnAddress)
    {
        return ((delegate* unmanaged<IDiaStackWalkHelper2*, IDiaFrameData*, ulong, ulong*, int>)(lpVtbl[7]))((IDiaStackWalkHelper2*)Unsafe.AsPointer(ref this), frame, startAddress, returnAddress);
    }

    /// <inheritdoc cref="IDiaStackWalkHelper.frameForVA" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT frameForVA([NativeTypeName("ULONGLONG")] ulong va, IDiaFrameData** ppFrame)
    {
        return ((delegate* unmanaged<IDiaStackWalkHelper2*, ulong, IDiaFrameData**, int>)(lpVtbl[8]))((IDiaStackWalkHelper2*)Unsafe.AsPointer(ref this), va, ppFrame);
    }

    /// <inheritdoc cref="IDiaStackWalkHelper.symbolForVA" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT symbolForVA([NativeTypeName("ULONGLONG")] ulong va, IDiaSymbol** ppSymbol)
    {
        return ((delegate* unmanaged<IDiaStackWalkHelper2*, ulong, IDiaSymbol**, int>)(lpVtbl[9]))((IDiaStackWalkHelper2*)Unsafe.AsPointer(ref this), va, ppSymbol);
    }

    /// <inheritdoc cref="IDiaStackWalkHelper.pdataForVA" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT pdataForVA([NativeTypeName("ULONGLONG")] ulong va, [NativeTypeName("DWORD")] uint cbData, [NativeTypeName("DWORD *")] uint* pcbData, byte* pbData)
    {
        return ((delegate* unmanaged<IDiaStackWalkHelper2*, ulong, uint, uint*, byte*, int>)(lpVtbl[10]))((IDiaStackWalkHelper2*)Unsafe.AsPointer(ref this), va, cbData, pcbData, pbData);
    }

    /// <inheritdoc cref="IDiaStackWalkHelper.imageForVA" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT imageForVA([NativeTypeName("ULONGLONG")] ulong vaContext, [NativeTypeName("ULONGLONG *")] ulong* pvaImageStart)
    {
        return ((delegate* unmanaged<IDiaStackWalkHelper2*, ulong, ulong*, int>)(lpVtbl[11]))((IDiaStackWalkHelper2*)Unsafe.AsPointer(ref this), vaContext, pvaImageStart);
    }

    /// <inheritdoc cref="IDiaStackWalkHelper.addressForVA" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT addressForVA([NativeTypeName("ULONGLONG")] ulong va, [NativeTypeName("DWORD *")] uint* pISect, [NativeTypeName("DWORD *")] uint* pOffset)
    {
        return ((delegate* unmanaged<IDiaStackWalkHelper2*, ulong, uint*, uint*, int>)(lpVtbl[12]))((IDiaStackWalkHelper2*)Unsafe.AsPointer(ref this), va, pISect, pOffset);
    }

    /// <inheritdoc cref="IDiaStackWalkHelper.numberOfFunctionFragmentsForVA" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT numberOfFunctionFragmentsForVA([NativeTypeName("ULONGLONG")] ulong vaFunc, [NativeTypeName("DWORD")] uint cbFunc, [NativeTypeName("DWORD *")] uint* pNumFragments)
    {
        return ((delegate* unmanaged<IDiaStackWalkHelper2*, ulong, uint, uint*, int>)(lpVtbl[13]))((IDiaStackWalkHelper2*)Unsafe.AsPointer(ref this), vaFunc, cbFunc, pNumFragments);
    }

    /// <inheritdoc cref="IDiaStackWalkHelper.functionFragmentsForVA" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT functionFragmentsForVA([NativeTypeName("ULONGLONG")] ulong vaFunc, [NativeTypeName("DWORD")] uint cbFunc, [NativeTypeName("DWORD")] uint cFragments, [NativeTypeName("ULONGLONG *")] ulong* pVaFragment, [NativeTypeName("DWORD *")] uint* pLenFragment)
    {
        return ((delegate* unmanaged<IDiaStackWalkHelper2*, ulong, uint, uint, ulong*, uint*, int>)(lpVtbl[14]))((IDiaStackWalkHelper2*)Unsafe.AsPointer(ref this), vaFunc, cbFunc, cFragments, pVaFragment, pLenFragment);
    }

    public interface Interface : IDiaStackWalkHelper.Interface
    {
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (DWORD, ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ulong*, int> get_registerValue;

        [NativeTypeName("HRESULT (DWORD, ULONGLONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ulong, int> put_registerValue;

        [NativeTypeName("HRESULT (enum MemoryTypeEnum, ULONGLONG, DWORD, DWORD *, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MemoryTypeEnum, ulong, uint, uint*, byte*, int> readMemory;

        [NativeTypeName("HRESULT (IDiaFrameData *, ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDiaFrameData*, ulong*, int> searchForReturnAddress;

        [NativeTypeName("HRESULT (IDiaFrameData *, ULONGLONG, ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDiaFrameData*, ulong, ulong*, int> searchForReturnAddressStart;

        [NativeTypeName("HRESULT (ULONGLONG, IDiaFrameData **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, IDiaFrameData**, int> frameForVA;

        [NativeTypeName("HRESULT (ULONGLONG, IDiaSymbol **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, IDiaSymbol**, int> symbolForVA;

        [NativeTypeName("HRESULT (ULONGLONG, DWORD, DWORD *, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, uint, uint*, byte*, int> pdataForVA;

        [NativeTypeName("HRESULT (ULONGLONG, ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, ulong*, int> imageForVA;

        [NativeTypeName("HRESULT (ULONGLONG, DWORD *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, uint*, uint*, int> addressForVA;

        [NativeTypeName("HRESULT (ULONGLONG, DWORD, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, uint, uint*, int> numberOfFunctionFragmentsForVA;

        [NativeTypeName("HRESULT (ULONGLONG, DWORD, DWORD, ULONGLONG *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, uint, uint, ulong*, uint*, int> functionFragmentsForVA;
    }
}
