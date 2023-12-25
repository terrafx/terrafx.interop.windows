// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAccelerometerStatics2.xml' path='doc/member[@name="IAccelerometerStatics2"]/*' />
[Guid("C4C4842F-D86B-4685-B2D7-3396F798D57B")]
[NativeTypeName("struct IAccelerometerStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAccelerometerStatics2 : IAccelerometerStatics2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAccelerometerStatics2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAccelerometerStatics2*, Guid*, void**, int>)(lpVtbl[0]))((IAccelerometerStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAccelerometerStatics2*, uint>)(lpVtbl[1]))((IAccelerometerStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAccelerometerStatics2*, uint>)(lpVtbl[2]))((IAccelerometerStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAccelerometerStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((IAccelerometerStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAccelerometerStatics2*, HSTRING*, int>)(lpVtbl[4]))((IAccelerometerStatics2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAccelerometerStatics2*, TrustLevel*, int>)(lpVtbl[5]))((IAccelerometerStatics2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAccelerometerStatics2.xml' path='doc/member[@name="IAccelerometerStatics2.GetDefaultWithAccelerometerReadingType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDefaultWithAccelerometerReadingType([NativeTypeName("ABI::Windows::Devices::Sensors::AccelerometerReadingType")] AccelerometerReadingType readingType, [NativeTypeName("ABI::Windows::Devices::Sensors::IAccelerometer **")] IAccelerometer** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAccelerometerStatics2*, AccelerometerReadingType, IAccelerometer**, int>)(lpVtbl[6]))((IAccelerometerStatics2*)Unsafe.AsPointer(ref this), readingType, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetDefaultWithAccelerometerReadingType([NativeTypeName("ABI::Windows::Devices::Sensors::AccelerometerReadingType")] AccelerometerReadingType readingType, [NativeTypeName("ABI::Windows::Devices::Sensors::IAccelerometer **")] IAccelerometer** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sensors::AccelerometerReadingType, ABI::Windows::Devices::Sensors::IAccelerometer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AccelerometerReadingType, IAccelerometer**, int> GetDefaultWithAccelerometerReadingType;
    }
}
