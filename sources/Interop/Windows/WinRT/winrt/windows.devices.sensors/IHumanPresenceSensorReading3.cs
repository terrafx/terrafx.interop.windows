// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHumanPresenceSensorReading3.xml' path='doc/member[@name="IHumanPresenceSensorReading3"]/*' />
[Guid("B876D918-F069-586F-90E3-7C6FA5C5D33A")]
[NativeTypeName("struct IHumanPresenceSensorReading3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHumanPresenceSensorReading3 : IHumanPresenceSensorReading3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHumanPresenceSensorReading3));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSensorReading3*, Guid*, void**, int>)(lpVtbl[0]))((IHumanPresenceSensorReading3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSensorReading3*, uint>)(lpVtbl[1]))((IHumanPresenceSensorReading3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSensorReading3*, uint>)(lpVtbl[2]))((IHumanPresenceSensorReading3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSensorReading3*, uint*, Guid**, int>)(lpVtbl[3]))((IHumanPresenceSensorReading3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSensorReading3*, HSTRING*, int>)(lpVtbl[4]))((IHumanPresenceSensorReading3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSensorReading3*, TrustLevel*, int>)(lpVtbl[5]))((IHumanPresenceSensorReading3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHumanPresenceSensorReading3.xml' path='doc/member[@name="IHumanPresenceSensorReading3.get_OnlookerPresence"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_OnlookerPresence([NativeTypeName("ABI::Windows::Devices::Sensors::HumanPresence *")] HumanPresence* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSensorReading3*, HumanPresence*, int>)(lpVtbl[6]))((IHumanPresenceSensorReading3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHumanPresenceSensorReading3.xml' path='doc/member[@name="IHumanPresenceSensorReading3.get_DetectedPersons"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_DetectedPersons([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSensors__CDetectedPerson_t **")] IVectorView<Pointer<DetectedPerson>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSensorReading3*, IVectorView<Pointer<DetectedPerson>>**, int>)(lpVtbl[7]))((IHumanPresenceSensorReading3*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_OnlookerPresence([NativeTypeName("ABI::Windows::Devices::Sensors::HumanPresence *")] HumanPresence* value);

        [VtblIndex(7)]
        HRESULT get_DetectedPersons([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSensors__CDetectedPerson_t **")] IVectorView<Pointer<DetectedPerson>>** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sensors::HumanPresence *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HumanPresence*, int> get_OnlookerPresence;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSensors__CDetectedPerson_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<DetectedPerson>>**, int> get_DetectedPersons;
    }
}
