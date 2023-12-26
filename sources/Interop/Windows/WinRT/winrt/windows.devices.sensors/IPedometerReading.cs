// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPedometerReading.xml' path='doc/member[@name="IPedometerReading"]/*' />
[Guid("2245DCF4-A8E1-432F-896A-BE0DD9B02D24")]
[NativeTypeName("struct IPedometerReading : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPedometerReading : IPedometerReading.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPedometerReading));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPedometerReading*, Guid*, void**, int>)(lpVtbl[0]))((IPedometerReading*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPedometerReading*, uint>)(lpVtbl[1]))((IPedometerReading*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPedometerReading*, uint>)(lpVtbl[2]))((IPedometerReading*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPedometerReading*, uint*, Guid**, int>)(lpVtbl[3]))((IPedometerReading*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPedometerReading*, HSTRING*, int>)(lpVtbl[4]))((IPedometerReading*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPedometerReading*, TrustLevel*, int>)(lpVtbl[5]))((IPedometerReading*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPedometerReading.xml' path='doc/member[@name="IPedometerReading.get_StepKind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_StepKind([NativeTypeName("ABI::Windows::Devices::Sensors::PedometerStepKind *")] PedometerStepKind* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPedometerReading*, PedometerStepKind*, int>)(lpVtbl[6]))((IPedometerReading*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPedometerReading.xml' path='doc/member[@name="IPedometerReading.get_CumulativeSteps"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_CumulativeSteps([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPedometerReading*, int*, int>)(lpVtbl[7]))((IPedometerReading*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPedometerReading.xml' path='doc/member[@name="IPedometerReading.get_Timestamp"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Timestamp([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPedometerReading*, WinRTDateTime*, int>)(lpVtbl[8]))((IPedometerReading*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPedometerReading.xml' path='doc/member[@name="IPedometerReading.get_CumulativeStepsDuration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_CumulativeStepsDuration([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPedometerReading*, TimeSpan*, int>)(lpVtbl[9]))((IPedometerReading*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_StepKind([NativeTypeName("ABI::Windows::Devices::Sensors::PedometerStepKind *")] PedometerStepKind* value);

        [VtblIndex(7)]
        HRESULT get_CumulativeSteps([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(8)]
        HRESULT get_Timestamp([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value);

        [VtblIndex(9)]
        HRESULT get_CumulativeStepsDuration([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sensors::PedometerStepKind *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PedometerStepKind*, int> get_StepKind;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_CumulativeSteps;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime*, int> get_Timestamp;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_CumulativeStepsDuration;
    }
}
