// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("4D5466B0-A49C-11D1-ABE8-00A0C905F375")]
[NativeTypeName("struct IAMClockAdjust : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAMClockAdjust : IAMClockAdjust.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAMClockAdjust*, Guid*, void**, int>)(lpVtbl[0]))((IAMClockAdjust*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAMClockAdjust*, uint>)(lpVtbl[1]))((IAMClockAdjust*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAMClockAdjust*, uint>)(lpVtbl[2]))((IAMClockAdjust*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetClockDelta([NativeTypeName("REFERENCE_TIME")] long rtDelta)
    {
        return ((delegate* unmanaged<IAMClockAdjust*, long, int>)(lpVtbl[3]))((IAMClockAdjust*)Unsafe.AsPointer(ref this), rtDelta);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetClockDelta([NativeTypeName("REFERENCE_TIME")] long rtDelta);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IAMClockAdjust*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IAMClockAdjust*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IAMClockAdjust*, uint> Release;

        [NativeTypeName("HRESULT (REFERENCE_TIME) __attribute__((stdcall))")]
        public delegate* unmanaged<IAMClockAdjust*, long, int> SetClockDelta;
    }
}
