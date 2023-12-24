// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.power.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPowerManagerStatics.xml' path='doc/member[@name="IPowerManagerStatics"]/*' />
[Guid("1394825D-62CE-4364-98D5-AA28C7FBD15B")]
[NativeTypeName("struct IPowerManagerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPowerManagerStatics : IPowerManagerStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPowerManagerStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPowerManagerStatics*, Guid*, void**, int>)(lpVtbl[0]))((IPowerManagerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPowerManagerStatics*, uint>)(lpVtbl[1]))((IPowerManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPowerManagerStatics*, uint>)(lpVtbl[2]))((IPowerManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPowerManagerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IPowerManagerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPowerManagerStatics*, HSTRING*, int>)(lpVtbl[4]))((IPowerManagerStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPowerManagerStatics*, TrustLevel*, int>)(lpVtbl[5]))((IPowerManagerStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPowerManagerStatics.xml' path='doc/member[@name="IPowerManagerStatics.get_EnergySaverStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_EnergySaverStatus([NativeTypeName("ABI::Windows::System::Power::EnergySaverStatus *")] EnergySaverStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPowerManagerStatics*, EnergySaverStatus*, int>)(lpVtbl[6]))((IPowerManagerStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPowerManagerStatics.xml' path='doc/member[@name="IPowerManagerStatics.add_EnergySaverStatusChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT add_EnergySaverStatusChanged([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPowerManagerStatics*, IEventHandler<IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[7]))((IPowerManagerStatics*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IPowerManagerStatics.xml' path='doc/member[@name="IPowerManagerStatics.remove_EnergySaverStatusChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT remove_EnergySaverStatusChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPowerManagerStatics*, EventRegistrationToken, int>)(lpVtbl[8]))((IPowerManagerStatics*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IPowerManagerStatics.xml' path='doc/member[@name="IPowerManagerStatics.get_BatteryStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_BatteryStatus([NativeTypeName("ABI::Windows::System::Power::BatteryStatus *")] BatteryStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPowerManagerStatics*, BatteryStatus*, int>)(lpVtbl[9]))((IPowerManagerStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPowerManagerStatics.xml' path='doc/member[@name="IPowerManagerStatics.add_BatteryStatusChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_BatteryStatusChanged([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPowerManagerStatics*, IEventHandler<IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[10]))((IPowerManagerStatics*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IPowerManagerStatics.xml' path='doc/member[@name="IPowerManagerStatics.remove_BatteryStatusChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_BatteryStatusChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPowerManagerStatics*, EventRegistrationToken, int>)(lpVtbl[11]))((IPowerManagerStatics*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IPowerManagerStatics.xml' path='doc/member[@name="IPowerManagerStatics.get_PowerSupplyStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_PowerSupplyStatus([NativeTypeName("ABI::Windows::System::Power::PowerSupplyStatus *")] PowerSupplyStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPowerManagerStatics*, PowerSupplyStatus*, int>)(lpVtbl[12]))((IPowerManagerStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPowerManagerStatics.xml' path='doc/member[@name="IPowerManagerStatics.add_PowerSupplyStatusChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT add_PowerSupplyStatusChanged([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPowerManagerStatics*, IEventHandler<IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[13]))((IPowerManagerStatics*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IPowerManagerStatics.xml' path='doc/member[@name="IPowerManagerStatics.remove_PowerSupplyStatusChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT remove_PowerSupplyStatusChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPowerManagerStatics*, EventRegistrationToken, int>)(lpVtbl[14]))((IPowerManagerStatics*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IPowerManagerStatics.xml' path='doc/member[@name="IPowerManagerStatics.get_RemainingChargePercent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_RemainingChargePercent([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPowerManagerStatics*, int*, int>)(lpVtbl[15]))((IPowerManagerStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPowerManagerStatics.xml' path='doc/member[@name="IPowerManagerStatics.add_RemainingChargePercentChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT add_RemainingChargePercentChanged([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPowerManagerStatics*, IEventHandler<IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[16]))((IPowerManagerStatics*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IPowerManagerStatics.xml' path='doc/member[@name="IPowerManagerStatics.remove_RemainingChargePercentChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT remove_RemainingChargePercentChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPowerManagerStatics*, EventRegistrationToken, int>)(lpVtbl[17]))((IPowerManagerStatics*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IPowerManagerStatics.xml' path='doc/member[@name="IPowerManagerStatics.get_RemainingDischargeTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_RemainingDischargeTime([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPowerManagerStatics*, TimeSpan*, int>)(lpVtbl[18]))((IPowerManagerStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPowerManagerStatics.xml' path='doc/member[@name="IPowerManagerStatics.add_RemainingDischargeTimeChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT add_RemainingDischargeTimeChanged([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPowerManagerStatics*, IEventHandler<IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[19]))((IPowerManagerStatics*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IPowerManagerStatics.xml' path='doc/member[@name="IPowerManagerStatics.remove_RemainingDischargeTimeChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT remove_RemainingDischargeTimeChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPowerManagerStatics*, EventRegistrationToken, int>)(lpVtbl[20]))((IPowerManagerStatics*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_EnergySaverStatus([NativeTypeName("ABI::Windows::System::Power::EnergySaverStatus *")] EnergySaverStatus* value);

        [VtblIndex(7)]
        HRESULT add_EnergySaverStatusChanged([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(8)]
        HRESULT remove_EnergySaverStatusChanged(EventRegistrationToken token);

        [VtblIndex(9)]
        HRESULT get_BatteryStatus([NativeTypeName("ABI::Windows::System::Power::BatteryStatus *")] BatteryStatus* value);

        [VtblIndex(10)]
        HRESULT add_BatteryStatusChanged([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(11)]
        HRESULT remove_BatteryStatusChanged(EventRegistrationToken token);

        [VtblIndex(12)]
        HRESULT get_PowerSupplyStatus([NativeTypeName("ABI::Windows::System::Power::PowerSupplyStatus *")] PowerSupplyStatus* value);

        [VtblIndex(13)]
        HRESULT add_PowerSupplyStatusChanged([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(14)]
        HRESULT remove_PowerSupplyStatusChanged(EventRegistrationToken token);

        [VtblIndex(15)]
        HRESULT get_RemainingChargePercent([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(16)]
        HRESULT add_RemainingChargePercentChanged([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(17)]
        HRESULT remove_RemainingChargePercentChanged(EventRegistrationToken token);

        [VtblIndex(18)]
        HRESULT get_RemainingDischargeTime([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(19)]
        HRESULT add_RemainingDischargeTimeChanged([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(20)]
        HRESULT remove_RemainingDischargeTimeChanged(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::System::Power::EnergySaverStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EnergySaverStatus*, int> get_EnergySaverStatus;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEventHandler<IntPtr>*, EventRegistrationToken*, int> add_EnergySaverStatusChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_EnergySaverStatusChanged;

        [NativeTypeName("HRESULT (ABI::Windows::System::Power::BatteryStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BatteryStatus*, int> get_BatteryStatus;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEventHandler<IntPtr>*, EventRegistrationToken*, int> add_BatteryStatusChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_BatteryStatusChanged;

        [NativeTypeName("HRESULT (ABI::Windows::System::Power::PowerSupplyStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PowerSupplyStatus*, int> get_PowerSupplyStatus;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEventHandler<IntPtr>*, EventRegistrationToken*, int> add_PowerSupplyStatusChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_PowerSupplyStatusChanged;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_RemainingChargePercent;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEventHandler<IntPtr>*, EventRegistrationToken*, int> add_RemainingChargePercentChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_RemainingChargePercentChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_RemainingDischargeTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEventHandler<IntPtr>*, EventRegistrationToken*, int> add_RemainingDischargeTimeChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_RemainingDischargeTimeChanged;
    }
}
