// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHumanPresenceSensorStatics2.xml' path='doc/member[@name="IHumanPresenceSensorStatics2"]/*' />
[Guid("5DE35843-D260-5A87-995E-ACE91326E1C4")]
[NativeTypeName("struct IHumanPresenceSensorStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHumanPresenceSensorStatics2 : IHumanPresenceSensorStatics2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHumanPresenceSensorStatics2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSensorStatics2*, Guid*, void**, int>)(lpVtbl[0]))((IHumanPresenceSensorStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSensorStatics2*, uint>)(lpVtbl[1]))((IHumanPresenceSensorStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSensorStatics2*, uint>)(lpVtbl[2]))((IHumanPresenceSensorStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSensorStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((IHumanPresenceSensorStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSensorStatics2*, HSTRING*, int>)(lpVtbl[4]))((IHumanPresenceSensorStatics2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSensorStatics2*, TrustLevel*, int>)(lpVtbl[5]))((IHumanPresenceSensorStatics2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHumanPresenceSensorStatics2.xml' path='doc/member[@name="IHumanPresenceSensorStatics2.FromId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FromId(HSTRING sensorId, [NativeTypeName("ABI::Windows::Devices::Sensors::IHumanPresenceSensor **")] IHumanPresenceSensor** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSensorStatics2*, HSTRING, IHumanPresenceSensor**, int>)(lpVtbl[6]))((IHumanPresenceSensorStatics2*)Unsafe.AsPointer(ref this), sensorId, result);
    }

    /// <include file='IHumanPresenceSensorStatics2.xml' path='doc/member[@name="IHumanPresenceSensorStatics2.GetDefault"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDefault([NativeTypeName("ABI::Windows::Devices::Sensors::IHumanPresenceSensor **")] IHumanPresenceSensor** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSensorStatics2*, IHumanPresenceSensor**, int>)(lpVtbl[7]))((IHumanPresenceSensorStatics2*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT FromId(HSTRING sensorId, [NativeTypeName("ABI::Windows::Devices::Sensors::IHumanPresenceSensor **")] IHumanPresenceSensor** result);

        [VtblIndex(7)]
        HRESULT GetDefault([NativeTypeName("ABI::Windows::Devices::Sensors::IHumanPresenceSensor **")] IHumanPresenceSensor** result);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Devices::Sensors::IHumanPresenceSensor **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IHumanPresenceSensor**, int> FromId;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sensors::IHumanPresenceSensor **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHumanPresenceSensor**, int> GetDefault;
    }
}
