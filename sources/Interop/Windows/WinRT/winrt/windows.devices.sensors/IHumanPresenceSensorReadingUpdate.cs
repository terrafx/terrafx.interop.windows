// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHumanPresenceSensorReadingUpdate.xml' path='doc/member[@name="IHumanPresenceSensorReadingUpdate"]/*' />
[Guid("42419C77-6D2F-55A0-9E01-C9CBE7B2D6DF")]
[NativeTypeName("struct IHumanPresenceSensorReadingUpdate : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHumanPresenceSensorReadingUpdate : IHumanPresenceSensorReadingUpdate.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IHumanPresenceSensorReadingUpdate);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSensorReadingUpdate*, Guid*, void**, int>)(lpVtbl[0]))((IHumanPresenceSensorReadingUpdate*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSensorReadingUpdate*, uint>)(lpVtbl[1]))((IHumanPresenceSensorReadingUpdate*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSensorReadingUpdate*, uint>)(lpVtbl[2]))((IHumanPresenceSensorReadingUpdate*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSensorReadingUpdate*, uint*, Guid**, int>)(lpVtbl[3]))((IHumanPresenceSensorReadingUpdate*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSensorReadingUpdate*, HSTRING*, int>)(lpVtbl[4]))((IHumanPresenceSensorReadingUpdate*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSensorReadingUpdate*, TrustLevel*, int>)(lpVtbl[5]))((IHumanPresenceSensorReadingUpdate*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHumanPresenceSensorReadingUpdate.xml' path='doc/member[@name="IHumanPresenceSensorReadingUpdate.get_Timestamp"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Timestamp([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSensorReadingUpdate*, IReference<DateTime>**, int>)(lpVtbl[6]))((IHumanPresenceSensorReadingUpdate*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHumanPresenceSensorReadingUpdate.xml' path='doc/member[@name="IHumanPresenceSensorReadingUpdate.put_Timestamp"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Timestamp([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *")] IReference<DateTime>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSensorReadingUpdate*, IReference<DateTime>*, int>)(lpVtbl[7]))((IHumanPresenceSensorReadingUpdate*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHumanPresenceSensorReadingUpdate.xml' path='doc/member[@name="IHumanPresenceSensorReadingUpdate.get_Presence"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Presence([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CDevices__CSensors__CHumanPresence_t **")] IReference<HumanPresence>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSensorReadingUpdate*, IReference<HumanPresence>**, int>)(lpVtbl[8]))((IHumanPresenceSensorReadingUpdate*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHumanPresenceSensorReadingUpdate.xml' path='doc/member[@name="IHumanPresenceSensorReadingUpdate.put_Presence"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Presence([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CDevices__CSensors__CHumanPresence_t *")] IReference<HumanPresence>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSensorReadingUpdate*, IReference<HumanPresence>*, int>)(lpVtbl[9]))((IHumanPresenceSensorReadingUpdate*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHumanPresenceSensorReadingUpdate.xml' path='doc/member[@name="IHumanPresenceSensorReadingUpdate.get_Engagement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Engagement([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CDevices__CSensors__CHumanEngagement_t **")] IReference<HumanEngagement>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSensorReadingUpdate*, IReference<HumanEngagement>**, int>)(lpVtbl[10]))((IHumanPresenceSensorReadingUpdate*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHumanPresenceSensorReadingUpdate.xml' path='doc/member[@name="IHumanPresenceSensorReadingUpdate.put_Engagement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_Engagement([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CDevices__CSensors__CHumanEngagement_t *")] IReference<HumanEngagement>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSensorReadingUpdate*, IReference<HumanEngagement>*, int>)(lpVtbl[11]))((IHumanPresenceSensorReadingUpdate*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHumanPresenceSensorReadingUpdate.xml' path='doc/member[@name="IHumanPresenceSensorReadingUpdate.get_DistanceInMillimeters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_DistanceInMillimeters([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")] IReference<uint>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSensorReadingUpdate*, IReference<uint>**, int>)(lpVtbl[12]))((IHumanPresenceSensorReadingUpdate*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHumanPresenceSensorReadingUpdate.xml' path='doc/member[@name="IHumanPresenceSensorReadingUpdate.put_DistanceInMillimeters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_DistanceInMillimeters([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t *")] IReference<uint>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSensorReadingUpdate*, IReference<uint>*, int>)(lpVtbl[13]))((IHumanPresenceSensorReadingUpdate*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Timestamp([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value);

        [VtblIndex(7)]
        HRESULT put_Timestamp([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *")] IReference<DateTime>* value);

        [VtblIndex(8)]
        HRESULT get_Presence([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CDevices__CSensors__CHumanPresence_t **")] IReference<HumanPresence>** value);

        [VtblIndex(9)]
        HRESULT put_Presence([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CDevices__CSensors__CHumanPresence_t *")] IReference<HumanPresence>* value);

        [VtblIndex(10)]
        HRESULT get_Engagement([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CDevices__CSensors__CHumanEngagement_t **")] IReference<HumanEngagement>** value);

        [VtblIndex(11)]
        HRESULT put_Engagement([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CDevices__CSensors__CHumanEngagement_t *")] IReference<HumanEngagement>* value);

        [VtblIndex(12)]
        HRESULT get_DistanceInMillimeters([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")] IReference<uint>** value);

        [VtblIndex(13)]
        HRESULT put_DistanceInMillimeters([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t *")] IReference<uint>* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<DateTime>**, int> get_Timestamp;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<DateTime>*, int> put_Timestamp;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CDevices__CSensors__CHumanPresence_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<HumanPresence>**, int> get_Presence;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CDevices__CSensors__CHumanPresence_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<HumanPresence>*, int> put_Presence;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CDevices__CSensors__CHumanEngagement_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<HumanEngagement>**, int> get_Engagement;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CDevices__CSensors__CHumanEngagement_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<HumanEngagement>*, int> put_Engagement;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<uint>**, int> get_DistanceInMillimeters;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<uint>*, int> put_DistanceInMillimeters;
    }
}
