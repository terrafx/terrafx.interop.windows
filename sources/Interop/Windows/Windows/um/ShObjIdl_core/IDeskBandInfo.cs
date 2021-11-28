// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("77E425FC-CBF9-4307-BA6A-BB5727745661")]
[NativeTypeName("struct IDeskBandInfo : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDeskBandInfo : IDeskBandInfo.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDeskBandInfo*, Guid*, void**, int>)(lpVtbl[0]))((IDeskBandInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDeskBandInfo*, uint>)(lpVtbl[1]))((IDeskBandInfo*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDeskBandInfo*, uint>)(lpVtbl[2]))((IDeskBandInfo*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDefaultBandWidth([NativeTypeName("DWORD")] uint dwBandID, [NativeTypeName("DWORD")] uint dwViewMode, int* pnWidth)
    {
        return ((delegate* unmanaged<IDeskBandInfo*, uint, uint, int*, int>)(lpVtbl[3]))((IDeskBandInfo*)Unsafe.AsPointer(ref this), dwBandID, dwViewMode, pnWidth);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetDefaultBandWidth([NativeTypeName("DWORD")] uint dwBandID, [NativeTypeName("DWORD")] uint dwViewMode, int* pnWidth);
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

        [NativeTypeName("HRESULT (DWORD, DWORD, int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, int*, int> GetDefaultBandWidth;
    }
}
