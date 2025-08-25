// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMagnetometerReading.xml' path='doc/member[@name="IMagnetometerReading"]/*' />
[Guid("0C2CC40D-EBFD-4E5C-BB11-AFC29B3CAE61")]
[NativeTypeName("struct IMagnetometerReading : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMagnetometerReading : IMagnetometerReading.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IMagnetometerReading);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMagnetometerReading*, Guid*, void**, int>)(lpVtbl[0]))((IMagnetometerReading*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMagnetometerReading*, uint>)(lpVtbl[1]))((IMagnetometerReading*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMagnetometerReading*, uint>)(lpVtbl[2]))((IMagnetometerReading*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMagnetometerReading*, uint*, Guid**, int>)(lpVtbl[3]))((IMagnetometerReading*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMagnetometerReading*, HSTRING*, int>)(lpVtbl[4]))((IMagnetometerReading*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMagnetometerReading*, TrustLevel*, int>)(lpVtbl[5]))((IMagnetometerReading*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMagnetometerReading.xml' path='doc/member[@name="IMagnetometerReading.get_Timestamp"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Timestamp([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMagnetometerReading*, WinRTDateTime*, int>)(lpVtbl[6]))((IMagnetometerReading*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMagnetometerReading.xml' path='doc/member[@name="IMagnetometerReading.get_MagneticFieldX"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_MagneticFieldX(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMagnetometerReading*, float*, int>)(lpVtbl[7]))((IMagnetometerReading*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMagnetometerReading.xml' path='doc/member[@name="IMagnetometerReading.get_MagneticFieldY"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_MagneticFieldY(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMagnetometerReading*, float*, int>)(lpVtbl[8]))((IMagnetometerReading*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMagnetometerReading.xml' path='doc/member[@name="IMagnetometerReading.get_MagneticFieldZ"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_MagneticFieldZ(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMagnetometerReading*, float*, int>)(lpVtbl[9]))((IMagnetometerReading*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMagnetometerReading.xml' path='doc/member[@name="IMagnetometerReading.get_DirectionalAccuracy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_DirectionalAccuracy([NativeTypeName("ABI::Windows::Devices::Sensors::MagnetometerAccuracy *")] MagnetometerAccuracy* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMagnetometerReading*, MagnetometerAccuracy*, int>)(lpVtbl[10]))((IMagnetometerReading*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Timestamp([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value);

        [VtblIndex(7)]
        HRESULT get_MagneticFieldX(float* value);

        [VtblIndex(8)]
        HRESULT get_MagneticFieldY(float* value);

        [VtblIndex(9)]
        HRESULT get_MagneticFieldZ(float* value);

        [VtblIndex(10)]
        HRESULT get_DirectionalAccuracy([NativeTypeName("ABI::Windows::Devices::Sensors::MagnetometerAccuracy *")] MagnetometerAccuracy* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime*, int> get_Timestamp;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_MagneticFieldX;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_MagneticFieldY;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_MagneticFieldZ;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sensors::MagnetometerAccuracy *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MagnetometerAccuracy*, int> get_DirectionalAccuracy;
    }
}
