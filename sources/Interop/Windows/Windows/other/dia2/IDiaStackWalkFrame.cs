// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IDiaStackWalkFrame.xml' path='doc/member[@name="IDiaStackWalkFrame"]/*' />
[Guid("07C590C1-438D-4F47-BDCD-4397BC81AD75")]
[NativeTypeName("struct IDiaStackWalkFrame : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDiaStackWalkFrame : IDiaStackWalkFrame.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IDiaStackWalkFrame);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaStackWalkFrame*, Guid*, void**, int>)(lpVtbl[0]))((IDiaStackWalkFrame*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaStackWalkFrame*, uint>)(lpVtbl[1]))((IDiaStackWalkFrame*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaStackWalkFrame*, uint>)(lpVtbl[2]))((IDiaStackWalkFrame*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDiaStackWalkFrame.xml' path='doc/member[@name="IDiaStackWalkFrame.get_registerValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_registerValue([NativeTypeName("DWORD")] uint index, [NativeTypeName("ULONGLONG *")] ulong* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaStackWalkFrame*, uint, ulong*, int>)(lpVtbl[3]))((IDiaStackWalkFrame*)Unsafe.AsPointer(ref this), index, pRetVal);
    }

    /// <include file='IDiaStackWalkFrame.xml' path='doc/member[@name="IDiaStackWalkFrame.put_registerValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT put_registerValue([NativeTypeName("DWORD")] uint index, [NativeTypeName("ULONGLONG")] ulong NewVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaStackWalkFrame*, uint, ulong, int>)(lpVtbl[4]))((IDiaStackWalkFrame*)Unsafe.AsPointer(ref this), index, NewVal);
    }

    /// <include file='IDiaStackWalkFrame.xml' path='doc/member[@name="IDiaStackWalkFrame.readMemory"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT readMemory([NativeTypeName("enum MemoryTypeEnum")] MemoryTypeEnum type, [NativeTypeName("ULONGLONG")] ulong va, [NativeTypeName("DWORD")] uint cbData, [NativeTypeName("DWORD *")] uint* pcbData, byte* pbData)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaStackWalkFrame*, MemoryTypeEnum, ulong, uint, uint*, byte*, int>)(lpVtbl[5]))((IDiaStackWalkFrame*)Unsafe.AsPointer(ref this), type, va, cbData, pcbData, pbData);
    }

    /// <include file='IDiaStackWalkFrame.xml' path='doc/member[@name="IDiaStackWalkFrame.searchForReturnAddress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT searchForReturnAddress(IDiaFrameData* frame, [NativeTypeName("ULONGLONG *")] ulong* returnAddress)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaStackWalkFrame*, IDiaFrameData*, ulong*, int>)(lpVtbl[6]))((IDiaStackWalkFrame*)Unsafe.AsPointer(ref this), frame, returnAddress);
    }

    /// <include file='IDiaStackWalkFrame.xml' path='doc/member[@name="IDiaStackWalkFrame.searchForReturnAddressStart"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT searchForReturnAddressStart(IDiaFrameData* frame, [NativeTypeName("ULONGLONG")] ulong startAddress, [NativeTypeName("ULONGLONG *")] ulong* returnAddress)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaStackWalkFrame*, IDiaFrameData*, ulong, ulong*, int>)(lpVtbl[7]))((IDiaStackWalkFrame*)Unsafe.AsPointer(ref this), frame, startAddress, returnAddress);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_registerValue([NativeTypeName("DWORD")] uint index, [NativeTypeName("ULONGLONG *")] ulong* pRetVal);

        [VtblIndex(4)]
        HRESULT put_registerValue([NativeTypeName("DWORD")] uint index, [NativeTypeName("ULONGLONG")] ulong NewVal);

        [VtblIndex(5)]
        HRESULT readMemory([NativeTypeName("enum MemoryTypeEnum")] MemoryTypeEnum type, [NativeTypeName("ULONGLONG")] ulong va, [NativeTypeName("DWORD")] uint cbData, [NativeTypeName("DWORD *")] uint* pcbData, byte* pbData);

        [VtblIndex(6)]
        HRESULT searchForReturnAddress(IDiaFrameData* frame, [NativeTypeName("ULONGLONG *")] ulong* returnAddress);

        [VtblIndex(7)]
        HRESULT searchForReturnAddressStart(IDiaFrameData* frame, [NativeTypeName("ULONGLONG")] ulong startAddress, [NativeTypeName("ULONGLONG *")] ulong* returnAddress);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (DWORD, ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, ulong*, int> get_registerValue;

        [NativeTypeName("HRESULT (DWORD, ULONGLONG) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, ulong, int> put_registerValue;

        [NativeTypeName("HRESULT (enum MemoryTypeEnum, ULONGLONG, DWORD, DWORD *, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MemoryTypeEnum, ulong, uint, uint*, byte*, int> readMemory;

        [NativeTypeName("HRESULT (IDiaFrameData *, ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDiaFrameData*, ulong*, int> searchForReturnAddress;

        [NativeTypeName("HRESULT (IDiaFrameData *, ULONGLONG, ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDiaFrameData*, ulong, ulong*, int> searchForReturnAddressStart;
    }
}
