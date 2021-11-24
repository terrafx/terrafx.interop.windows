// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("EBEC459C-2ECA-4D42-A8AF-30DF557614B8")]
[NativeTypeName("struct IReferenceClockTimerControl : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IReferenceClockTimerControl : IReferenceClockTimerControl.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IReferenceClockTimerControl*, Guid*, void**, int>)(lpVtbl[0]))((IReferenceClockTimerControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IReferenceClockTimerControl*, uint>)(lpVtbl[1]))((IReferenceClockTimerControl*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IReferenceClockTimerControl*, uint>)(lpVtbl[2]))((IReferenceClockTimerControl*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetDefaultTimerResolution([NativeTypeName("REFERENCE_TIME")] long timerResolution)
    {
        return ((delegate* unmanaged<IReferenceClockTimerControl*, long, int>)(lpVtbl[3]))((IReferenceClockTimerControl*)Unsafe.AsPointer(ref this), timerResolution);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetDefaultTimerResolution([NativeTypeName("REFERENCE_TIME *")] long* pTimerResolution)
    {
        return ((delegate* unmanaged<IReferenceClockTimerControl*, long*, int>)(lpVtbl[4]))((IReferenceClockTimerControl*)Unsafe.AsPointer(ref this), pTimerResolution);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetDefaultTimerResolution([NativeTypeName("REFERENCE_TIME")] long timerResolution);

        [VtblIndex(4)]
        HRESULT GetDefaultTimerResolution([NativeTypeName("REFERENCE_TIME *")] long* pTimerResolution);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IReferenceClockTimerControl*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IReferenceClockTimerControl*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IReferenceClockTimerControl*, uint> Release;

        [NativeTypeName("HRESULT (REFERENCE_TIME) __attribute__((stdcall))")]
        public delegate* unmanaged<IReferenceClockTimerControl*, long, int> SetDefaultTimerResolution;

        [NativeTypeName("HRESULT (REFERENCE_TIME *) __attribute__((stdcall))")]
        public delegate* unmanaged<IReferenceClockTimerControl*, long*, int> GetDefaultTimerResolution;
    }
}
