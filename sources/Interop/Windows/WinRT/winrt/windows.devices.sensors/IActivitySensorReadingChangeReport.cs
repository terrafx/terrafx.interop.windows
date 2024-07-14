// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IActivitySensorReadingChangeReport.xml' path='doc/member[@name="IActivitySensorReadingChangeReport"]/*' />
[Guid("4F3C2915-D93B-47BD-960A-F20FB2F322B9")]
[NativeTypeName("struct IActivitySensorReadingChangeReport : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IActivitySensorReadingChangeReport : IActivitySensorReadingChangeReport.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IActivitySensorReadingChangeReport));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IActivitySensorReadingChangeReport*, Guid*, void**, int>)(lpVtbl[0]))((IActivitySensorReadingChangeReport*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IActivitySensorReadingChangeReport*, uint>)(lpVtbl[1]))((IActivitySensorReadingChangeReport*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IActivitySensorReadingChangeReport*, uint>)(lpVtbl[2]))((IActivitySensorReadingChangeReport*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IActivitySensorReadingChangeReport*, uint*, Guid**, int>)(lpVtbl[3]))((IActivitySensorReadingChangeReport*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IActivitySensorReadingChangeReport*, HSTRING*, int>)(lpVtbl[4]))((IActivitySensorReadingChangeReport*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IActivitySensorReadingChangeReport*, TrustLevel*, int>)(lpVtbl[5]))((IActivitySensorReadingChangeReport*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IActivitySensorReadingChangeReport.xml' path='doc/member[@name="IActivitySensorReadingChangeReport.get_Reading"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Reading([NativeTypeName("ABI::Windows::Devices::Sensors::IActivitySensorReading **")] IActivitySensorReading** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IActivitySensorReadingChangeReport*, IActivitySensorReading**, int>)(lpVtbl[6]))((IActivitySensorReadingChangeReport*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Reading([NativeTypeName("ABI::Windows::Devices::Sensors::IActivitySensorReading **")] IActivitySensorReading** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sensors::IActivitySensorReading **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IActivitySensorReading**, int> get_Reading;
    }
}
