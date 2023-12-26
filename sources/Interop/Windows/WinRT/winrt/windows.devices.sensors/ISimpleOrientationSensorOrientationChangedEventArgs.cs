// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISimpleOrientationSensorOrientationChangedEventArgs.xml' path='doc/member[@name="ISimpleOrientationSensorOrientationChangedEventArgs"]/*' />
[Guid("BCD5C660-23D4-4B4C-A22E-BA81ADE0C601")]
[NativeTypeName("struct ISimpleOrientationSensorOrientationChangedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISimpleOrientationSensorOrientationChangedEventArgs : ISimpleOrientationSensorOrientationChangedEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISimpleOrientationSensorOrientationChangedEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISimpleOrientationSensorOrientationChangedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((ISimpleOrientationSensorOrientationChangedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISimpleOrientationSensorOrientationChangedEventArgs*, uint>)(lpVtbl[1]))((ISimpleOrientationSensorOrientationChangedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISimpleOrientationSensorOrientationChangedEventArgs*, uint>)(lpVtbl[2]))((ISimpleOrientationSensorOrientationChangedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISimpleOrientationSensorOrientationChangedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((ISimpleOrientationSensorOrientationChangedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISimpleOrientationSensorOrientationChangedEventArgs*, HSTRING*, int>)(lpVtbl[4]))((ISimpleOrientationSensorOrientationChangedEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISimpleOrientationSensorOrientationChangedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((ISimpleOrientationSensorOrientationChangedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISimpleOrientationSensorOrientationChangedEventArgs.xml' path='doc/member[@name="ISimpleOrientationSensorOrientationChangedEventArgs.get_Timestamp"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Timestamp([NativeTypeName("ABI::Windows::Foundation::DateTime *")] DateTime* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISimpleOrientationSensorOrientationChangedEventArgs*, DateTime*, int>)(lpVtbl[6]))((ISimpleOrientationSensorOrientationChangedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISimpleOrientationSensorOrientationChangedEventArgs.xml' path='doc/member[@name="ISimpleOrientationSensorOrientationChangedEventArgs.get_Orientation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Orientation([NativeTypeName("ABI::Windows::Devices::Sensors::SimpleOrientation *")] SimpleOrientation* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISimpleOrientationSensorOrientationChangedEventArgs*, SimpleOrientation*, int>)(lpVtbl[7]))((ISimpleOrientationSensorOrientationChangedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Timestamp([NativeTypeName("ABI::Windows::Foundation::DateTime *")] DateTime* value);

        [VtblIndex(7)]
        HRESULT get_Orientation([NativeTypeName("ABI::Windows::Devices::Sensors::SimpleOrientation *")] SimpleOrientation* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DateTime*, int> get_Timestamp;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sensors::SimpleOrientation *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SimpleOrientation*, int> get_Orientation;
    }
}
