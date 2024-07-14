// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.genericattributeprofile.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGattServiceUuidsStatics.xml' path='doc/member[@name="IGattServiceUuidsStatics"]/*' />
[Guid("6DC57058-9ABA-4417-B8F2-DCE016D34EE2")]
[NativeTypeName("struct IGattServiceUuidsStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGattServiceUuidsStatics : IGattServiceUuidsStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGattServiceUuidsStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceUuidsStatics*, Guid*, void**, int>)(lpVtbl[0]))((IGattServiceUuidsStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceUuidsStatics*, uint>)(lpVtbl[1]))((IGattServiceUuidsStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceUuidsStatics*, uint>)(lpVtbl[2]))((IGattServiceUuidsStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceUuidsStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IGattServiceUuidsStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceUuidsStatics*, HSTRING*, int>)(lpVtbl[4]))((IGattServiceUuidsStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceUuidsStatics*, TrustLevel*, int>)(lpVtbl[5]))((IGattServiceUuidsStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGattServiceUuidsStatics.xml' path='doc/member[@name="IGattServiceUuidsStatics.get_Battery"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Battery(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceUuidsStatics*, Guid*, int>)(lpVtbl[6]))((IGattServiceUuidsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattServiceUuidsStatics.xml' path='doc/member[@name="IGattServiceUuidsStatics.get_BloodPressure"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_BloodPressure(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceUuidsStatics*, Guid*, int>)(lpVtbl[7]))((IGattServiceUuidsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattServiceUuidsStatics.xml' path='doc/member[@name="IGattServiceUuidsStatics.get_CyclingSpeedAndCadence"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_CyclingSpeedAndCadence(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceUuidsStatics*, Guid*, int>)(lpVtbl[8]))((IGattServiceUuidsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattServiceUuidsStatics.xml' path='doc/member[@name="IGattServiceUuidsStatics.get_GenericAccess"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_GenericAccess(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceUuidsStatics*, Guid*, int>)(lpVtbl[9]))((IGattServiceUuidsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattServiceUuidsStatics.xml' path='doc/member[@name="IGattServiceUuidsStatics.get_GenericAttribute"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_GenericAttribute(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceUuidsStatics*, Guid*, int>)(lpVtbl[10]))((IGattServiceUuidsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattServiceUuidsStatics.xml' path='doc/member[@name="IGattServiceUuidsStatics.get_Glucose"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Glucose(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceUuidsStatics*, Guid*, int>)(lpVtbl[11]))((IGattServiceUuidsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattServiceUuidsStatics.xml' path='doc/member[@name="IGattServiceUuidsStatics.get_HealthThermometer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_HealthThermometer(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceUuidsStatics*, Guid*, int>)(lpVtbl[12]))((IGattServiceUuidsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattServiceUuidsStatics.xml' path='doc/member[@name="IGattServiceUuidsStatics.get_HeartRate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_HeartRate(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceUuidsStatics*, Guid*, int>)(lpVtbl[13]))((IGattServiceUuidsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattServiceUuidsStatics.xml' path='doc/member[@name="IGattServiceUuidsStatics.get_RunningSpeedAndCadence"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_RunningSpeedAndCadence(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattServiceUuidsStatics*, Guid*, int>)(lpVtbl[14]))((IGattServiceUuidsStatics*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Battery(Guid* value);

        [VtblIndex(7)]
        HRESULT get_BloodPressure(Guid* value);

        [VtblIndex(8)]
        HRESULT get_CyclingSpeedAndCadence(Guid* value);

        [VtblIndex(9)]
        HRESULT get_GenericAccess(Guid* value);

        [VtblIndex(10)]
        HRESULT get_GenericAttribute(Guid* value);

        [VtblIndex(11)]
        HRESULT get_Glucose(Guid* value);

        [VtblIndex(12)]
        HRESULT get_HealthThermometer(Guid* value);

        [VtblIndex(13)]
        HRESULT get_HeartRate(Guid* value);

        [VtblIndex(14)]
        HRESULT get_RunningSpeedAndCadence(Guid* value);
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

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_Battery;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_BloodPressure;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_CyclingSpeedAndCadence;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_GenericAccess;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_GenericAttribute;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_Glucose;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_HealthThermometer;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_HeartRate;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_RunningSpeedAndCadence;
    }
}
