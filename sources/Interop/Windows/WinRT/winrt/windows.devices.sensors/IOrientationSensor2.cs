// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IOrientationSensor2.xml' path='doc/member[@name="IOrientationSensor2"]/*' />
[Guid("0D924CF9-2F1F-49C9-8042-4A1813D67760")]
[NativeTypeName("struct IOrientationSensor2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IOrientationSensor2 : IOrientationSensor2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IOrientationSensor2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IOrientationSensor2*, Guid*, void**, int>)(lpVtbl[0]))((IOrientationSensor2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IOrientationSensor2*, uint>)(lpVtbl[1]))((IOrientationSensor2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IOrientationSensor2*, uint>)(lpVtbl[2]))((IOrientationSensor2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IOrientationSensor2*, uint*, Guid**, int>)(lpVtbl[3]))((IOrientationSensor2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IOrientationSensor2*, HSTRING*, int>)(lpVtbl[4]))((IOrientationSensor2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IOrientationSensor2*, TrustLevel*, int>)(lpVtbl[5]))((IOrientationSensor2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IOrientationSensor2.xml' path='doc/member[@name="IOrientationSensor2.put_ReadingTransform"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_ReadingTransform([NativeTypeName("ABI::Windows::Graphics::Display::DisplayOrientations")] DisplayOrientations value)
    {
        return ((delegate* unmanaged[MemberFunction]<IOrientationSensor2*, DisplayOrientations, int>)(lpVtbl[6]))((IOrientationSensor2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IOrientationSensor2.xml' path='doc/member[@name="IOrientationSensor2.get_ReadingTransform"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ReadingTransform([NativeTypeName("ABI::Windows::Graphics::Display::DisplayOrientations *")] DisplayOrientations* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IOrientationSensor2*, DisplayOrientations*, int>)(lpVtbl[7]))((IOrientationSensor2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IOrientationSensor2.xml' path='doc/member[@name="IOrientationSensor2.get_ReadingType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ReadingType([NativeTypeName("ABI::Windows::Devices::Sensors::SensorReadingType *")] SensorReadingType* type)
    {
        return ((delegate* unmanaged[MemberFunction]<IOrientationSensor2*, SensorReadingType*, int>)(lpVtbl[8]))((IOrientationSensor2*)Unsafe.AsPointer(ref this), type);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_ReadingTransform([NativeTypeName("ABI::Windows::Graphics::Display::DisplayOrientations")] DisplayOrientations value);

        [VtblIndex(7)]
        HRESULT get_ReadingTransform([NativeTypeName("ABI::Windows::Graphics::Display::DisplayOrientations *")] DisplayOrientations* value);

        [VtblIndex(8)]
        HRESULT get_ReadingType([NativeTypeName("ABI::Windows::Devices::Sensors::SensorReadingType *")] SensorReadingType* type);
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

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Display::DisplayOrientations) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DisplayOrientations, int> put_ReadingTransform;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Display::DisplayOrientations *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DisplayOrientations*, int> get_ReadingTransform;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sensors::SensorReadingType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SensorReadingType*, int> get_ReadingType;
    }
}
