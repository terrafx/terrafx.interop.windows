// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHumanPresenceSettings2.xml' path='doc/member[@name="IHumanPresenceSettings2"]/*' />
[Guid("A26F705E-8696-5EB4-B9E1-26A508DE1CD4")]
[NativeTypeName("struct IHumanPresenceSettings2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHumanPresenceSettings2 : IHumanPresenceSettings2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHumanPresenceSettings2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSettings2*, Guid*, void**, int>)(lpVtbl[0]))((IHumanPresenceSettings2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSettings2*, uint>)(lpVtbl[1]))((IHumanPresenceSettings2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSettings2*, uint>)(lpVtbl[2]))((IHumanPresenceSettings2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSettings2*, uint*, Guid**, int>)(lpVtbl[3]))((IHumanPresenceSettings2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSettings2*, HSTRING*, int>)(lpVtbl[4]))((IHumanPresenceSettings2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSettings2*, TrustLevel*, int>)(lpVtbl[5]))((IHumanPresenceSettings2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHumanPresenceSettings2.xml' path='doc/member[@name="IHumanPresenceSettings2.get_IsAdaptiveDimmingEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IsAdaptiveDimmingEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSettings2*, byte*, int>)(lpVtbl[6]))((IHumanPresenceSettings2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHumanPresenceSettings2.xml' path='doc/member[@name="IHumanPresenceSettings2.put_IsAdaptiveDimmingEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_IsAdaptiveDimmingEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSettings2*, byte, int>)(lpVtbl[7]))((IHumanPresenceSettings2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHumanPresenceSettings2.xml' path='doc/member[@name="IHumanPresenceSettings2.get_WakeOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_WakeOptions([NativeTypeName("ABI::Windows::Devices::Sensors::IWakeOnApproachOptions **")] IWakeOnApproachOptions** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSettings2*, IWakeOnApproachOptions**, int>)(lpVtbl[8]))((IHumanPresenceSettings2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHumanPresenceSettings2.xml' path='doc/member[@name="IHumanPresenceSettings2.get_DimmingOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_DimmingOptions([NativeTypeName("ABI::Windows::Devices::Sensors::IAdaptiveDimmingOptions **")] IAdaptiveDimmingOptions** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSettings2*, IAdaptiveDimmingOptions**, int>)(lpVtbl[9]))((IHumanPresenceSettings2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHumanPresenceSettings2.xml' path='doc/member[@name="IHumanPresenceSettings2.get_LockOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_LockOptions([NativeTypeName("ABI::Windows::Devices::Sensors::ILockOnLeaveOptions **")] ILockOnLeaveOptions** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSettings2*, ILockOnLeaveOptions**, int>)(lpVtbl[10]))((IHumanPresenceSettings2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IsAdaptiveDimmingEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT put_IsAdaptiveDimmingEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(8)]
        HRESULT get_WakeOptions([NativeTypeName("ABI::Windows::Devices::Sensors::IWakeOnApproachOptions **")] IWakeOnApproachOptions** value);

        [VtblIndex(9)]
        HRESULT get_DimmingOptions([NativeTypeName("ABI::Windows::Devices::Sensors::IAdaptiveDimmingOptions **")] IAdaptiveDimmingOptions** value);

        [VtblIndex(10)]
        HRESULT get_LockOptions([NativeTypeName("ABI::Windows::Devices::Sensors::ILockOnLeaveOptions **")] ILockOnLeaveOptions** value);
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsAdaptiveDimmingEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsAdaptiveDimmingEnabled;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sensors::IWakeOnApproachOptions **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWakeOnApproachOptions**, int> get_WakeOptions;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sensors::IAdaptiveDimmingOptions **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAdaptiveDimmingOptions**, int> get_DimmingOptions;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sensors::ILockOnLeaveOptions **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ILockOnLeaveOptions**, int> get_LockOptions;
    }
}
