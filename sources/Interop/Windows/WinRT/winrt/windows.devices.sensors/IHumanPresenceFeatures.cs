// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHumanPresenceFeatures.xml' path='doc/member[@name="IHumanPresenceFeatures"]/*' />
[Guid("BDB09FDA-3244-557A-BD29-8B004F59F2CC")]
[NativeTypeName("struct IHumanPresenceFeatures : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHumanPresenceFeatures : IHumanPresenceFeatures.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHumanPresenceFeatures));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceFeatures*, Guid*, void**, int>)(lpVtbl[0]))((IHumanPresenceFeatures*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceFeatures*, uint>)(lpVtbl[1]))((IHumanPresenceFeatures*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceFeatures*, uint>)(lpVtbl[2]))((IHumanPresenceFeatures*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceFeatures*, uint*, Guid**, int>)(lpVtbl[3]))((IHumanPresenceFeatures*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceFeatures*, HSTRING*, int>)(lpVtbl[4]))((IHumanPresenceFeatures*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceFeatures*, TrustLevel*, int>)(lpVtbl[5]))((IHumanPresenceFeatures*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHumanPresenceFeatures.xml' path='doc/member[@name="IHumanPresenceFeatures.get_SensorId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SensorId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceFeatures*, HSTRING*, int>)(lpVtbl[6]))((IHumanPresenceFeatures*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHumanPresenceFeatures.xml' path='doc/member[@name="IHumanPresenceFeatures.get_SupportedWakeOrLockDistancesInMillimeters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_SupportedWakeOrLockDistancesInMillimeters([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_UINT32_t **")] IVectorView<uint>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceFeatures*, IVectorView<uint>**, int>)(lpVtbl[7]))((IHumanPresenceFeatures*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHumanPresenceFeatures.xml' path='doc/member[@name="IHumanPresenceFeatures.get_IsWakeOnApproachSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IsWakeOnApproachSupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceFeatures*, byte*, int>)(lpVtbl[8]))((IHumanPresenceFeatures*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHumanPresenceFeatures.xml' path='doc/member[@name="IHumanPresenceFeatures.get_IsLockOnLeaveSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_IsLockOnLeaveSupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceFeatures*, byte*, int>)(lpVtbl[9]))((IHumanPresenceFeatures*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHumanPresenceFeatures.xml' path='doc/member[@name="IHumanPresenceFeatures.get_IsAttentionAwareDimmingSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [Obsolete("Use IsAdaptiveDimmingSupported instead of IsAttentionAwareDimmingSupported.")]
    public HRESULT get_IsAttentionAwareDimmingSupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceFeatures*, byte*, int>)(lpVtbl[10]))((IHumanPresenceFeatures*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SensorId(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_SupportedWakeOrLockDistancesInMillimeters([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_UINT32_t **")] IVectorView<uint>** value);

        [VtblIndex(8)]
        HRESULT get_IsWakeOnApproachSupported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT get_IsLockOnLeaveSupported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        [Obsolete("Use IsAdaptiveDimmingSupported instead of IsAttentionAwareDimmingSupported.")]
        HRESULT get_IsAttentionAwareDimmingSupported([NativeTypeName("boolean *")] byte* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_UINT32_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<uint>**, int> get_SupportedWakeOrLockDistancesInMillimeters;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsWakeOnApproachSupported;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsLockOnLeaveSupported;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        [Obsolete("Use IsAdaptiveDimmingSupported instead of IsAttentionAwareDimmingSupported.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsAttentionAwareDimmingSupported;
    }
}
