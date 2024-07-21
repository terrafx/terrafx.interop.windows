// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHumanPresenceSettings.xml' path='doc/member[@name="IHumanPresenceSettings"]/*' />
[Guid("EF4DAF5B-07B7-5EB6-86BB-B7FF49CE44FB")]
[NativeTypeName("struct IHumanPresenceSettings : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHumanPresenceSettings : IHumanPresenceSettings.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHumanPresenceSettings));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSettings*, Guid*, void**, int>)(lpVtbl[0]))((IHumanPresenceSettings*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSettings*, uint>)(lpVtbl[1]))((IHumanPresenceSettings*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSettings*, uint>)(lpVtbl[2]))((IHumanPresenceSettings*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSettings*, uint*, Guid**, int>)(lpVtbl[3]))((IHumanPresenceSettings*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSettings*, HSTRING*, int>)(lpVtbl[4]))((IHumanPresenceSettings*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSettings*, TrustLevel*, int>)(lpVtbl[5]))((IHumanPresenceSettings*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHumanPresenceSettings.xml' path='doc/member[@name="IHumanPresenceSettings.get_SensorId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SensorId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSettings*, HSTRING*, int>)(lpVtbl[6]))((IHumanPresenceSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHumanPresenceSettings.xml' path='doc/member[@name="IHumanPresenceSettings.put_SensorId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_SensorId(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSettings*, HSTRING, int>)(lpVtbl[7]))((IHumanPresenceSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHumanPresenceSettings.xml' path='doc/member[@name="IHumanPresenceSettings.get_IsWakeOnApproachEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IsWakeOnApproachEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSettings*, byte*, int>)(lpVtbl[8]))((IHumanPresenceSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHumanPresenceSettings.xml' path='doc/member[@name="IHumanPresenceSettings.put_IsWakeOnApproachEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_IsWakeOnApproachEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSettings*, byte, int>)(lpVtbl[9]))((IHumanPresenceSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHumanPresenceSettings.xml' path='doc/member[@name="IHumanPresenceSettings.get_WakeOnApproachDistanceInMillimeters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_WakeOnApproachDistanceInMillimeters([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")] IReference<uint>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSettings*, IReference<uint>**, int>)(lpVtbl[10]))((IHumanPresenceSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHumanPresenceSettings.xml' path='doc/member[@name="IHumanPresenceSettings.put_WakeOnApproachDistanceInMillimeters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_WakeOnApproachDistanceInMillimeters([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t *")] IReference<uint>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSettings*, IReference<uint>*, int>)(lpVtbl[11]))((IHumanPresenceSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHumanPresenceSettings.xml' path='doc/member[@name="IHumanPresenceSettings.get_IsLockOnLeaveEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_IsLockOnLeaveEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSettings*, byte*, int>)(lpVtbl[12]))((IHumanPresenceSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHumanPresenceSettings.xml' path='doc/member[@name="IHumanPresenceSettings.put_IsLockOnLeaveEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_IsLockOnLeaveEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSettings*, byte, int>)(lpVtbl[13]))((IHumanPresenceSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHumanPresenceSettings.xml' path='doc/member[@name="IHumanPresenceSettings.get_LockOnLeaveDistanceInMillimeters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_LockOnLeaveDistanceInMillimeters([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")] IReference<uint>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSettings*, IReference<uint>**, int>)(lpVtbl[14]))((IHumanPresenceSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHumanPresenceSettings.xml' path='doc/member[@name="IHumanPresenceSettings.put_LockOnLeaveDistanceInMillimeters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_LockOnLeaveDistanceInMillimeters([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t *")] IReference<uint>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSettings*, IReference<uint>*, int>)(lpVtbl[15]))((IHumanPresenceSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHumanPresenceSettings.xml' path='doc/member[@name="IHumanPresenceSettings.get_LockOnLeaveTimeout"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_LockOnLeaveTimeout([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSettings*, TimeSpan*, int>)(lpVtbl[16]))((IHumanPresenceSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHumanPresenceSettings.xml' path='doc/member[@name="IHumanPresenceSettings.put_LockOnLeaveTimeout"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_LockOnLeaveTimeout([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSettings*, TimeSpan, int>)(lpVtbl[17]))((IHumanPresenceSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHumanPresenceSettings.xml' path='doc/member[@name="IHumanPresenceSettings.get_IsAttentionAwareDimmingEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    [Obsolete("Use IsAdaptiveDimmingEnabled instead of IsAttentionAwareDimmingEnabled.")]
    public HRESULT get_IsAttentionAwareDimmingEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSettings*, byte*, int>)(lpVtbl[18]))((IHumanPresenceSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHumanPresenceSettings.xml' path='doc/member[@name="IHumanPresenceSettings.put_IsAttentionAwareDimmingEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    [Obsolete("Use IsAdaptiveDimmingEnabled instead of IsAttentionAwareDimmingEnabled.")]
    public HRESULT put_IsAttentionAwareDimmingEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSettings*, byte, int>)(lpVtbl[19]))((IHumanPresenceSettings*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SensorId(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_SensorId(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_IsWakeOnApproachEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT put_IsWakeOnApproachEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(10)]
        HRESULT get_WakeOnApproachDistanceInMillimeters([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")] IReference<uint>** value);

        [VtblIndex(11)]
        HRESULT put_WakeOnApproachDistanceInMillimeters([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t *")] IReference<uint>* value);

        [VtblIndex(12)]
        HRESULT get_IsLockOnLeaveEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(13)]
        HRESULT put_IsLockOnLeaveEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(14)]
        HRESULT get_LockOnLeaveDistanceInMillimeters([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")] IReference<uint>** value);

        [VtblIndex(15)]
        HRESULT put_LockOnLeaveDistanceInMillimeters([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t *")] IReference<uint>* value);

        [VtblIndex(16)]
        HRESULT get_LockOnLeaveTimeout([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(17)]
        HRESULT put_LockOnLeaveTimeout([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value);

        [VtblIndex(18)]
        [Obsolete("Use IsAdaptiveDimmingEnabled instead of IsAttentionAwareDimmingEnabled.")]
        HRESULT get_IsAttentionAwareDimmingEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(19)]
        [Obsolete("Use IsAdaptiveDimmingEnabled instead of IsAttentionAwareDimmingEnabled.")]
        HRESULT put_IsAttentionAwareDimmingEnabled([NativeTypeName("boolean")] byte value);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SensorId;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_SensorId;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsWakeOnApproachEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsWakeOnApproachEnabled;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<uint>**, int> get_WakeOnApproachDistanceInMillimeters;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<uint>*, int> put_WakeOnApproachDistanceInMillimeters;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsLockOnLeaveEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsLockOnLeaveEnabled;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<uint>**, int> get_LockOnLeaveDistanceInMillimeters;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<uint>*, int> put_LockOnLeaveDistanceInMillimeters;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_LockOnLeaveTimeout;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan, int> put_LockOnLeaveTimeout;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        [Obsolete("Use IsAdaptiveDimmingEnabled instead of IsAttentionAwareDimmingEnabled.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsAttentionAwareDimmingEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        [Obsolete("Use IsAdaptiveDimmingEnabled instead of IsAttentionAwareDimmingEnabled.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsAttentionAwareDimmingEnabled;
    }
}
