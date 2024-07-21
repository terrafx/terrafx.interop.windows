// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.i2c.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='II2cDeviceStatics.xml' path='doc/member[@name="II2cDeviceStatics"]/*' />
[Guid("91A33BE3-7334-4512-96BC-FBAE9459F5F6")]
[NativeTypeName("struct II2cDeviceStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct II2cDeviceStatics : II2cDeviceStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_II2cDeviceStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<II2cDeviceStatics*, Guid*, void**, int>)(lpVtbl[0]))((II2cDeviceStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<II2cDeviceStatics*, uint>)(lpVtbl[1]))((II2cDeviceStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<II2cDeviceStatics*, uint>)(lpVtbl[2]))((II2cDeviceStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<II2cDeviceStatics*, uint*, Guid**, int>)(lpVtbl[3]))((II2cDeviceStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<II2cDeviceStatics*, HSTRING*, int>)(lpVtbl[4]))((II2cDeviceStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<II2cDeviceStatics*, TrustLevel*, int>)(lpVtbl[5]))((II2cDeviceStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='II2cDeviceStatics.xml' path='doc/member[@name="II2cDeviceStatics.GetDeviceSelector"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDeviceSelector(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<II2cDeviceStatics*, HSTRING*, int>)(lpVtbl[6]))((II2cDeviceStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='II2cDeviceStatics.xml' path='doc/member[@name="II2cDeviceStatics.GetDeviceSelectorFromFriendlyName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDeviceSelectorFromFriendlyName(HSTRING friendlyName, HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<II2cDeviceStatics*, HSTRING, HSTRING*, int>)(lpVtbl[7]))((II2cDeviceStatics*)Unsafe.AsPointer(ref this), friendlyName, value);
    }

    /// <include file='II2cDeviceStatics.xml' path='doc/member[@name="II2cDeviceStatics.FromIdAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT FromIdAsync(HSTRING deviceId, [NativeTypeName("ABI::Windows::Devices::I2c::II2cConnectionSettings *")] II2cConnectionSettings* settings, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CI2c__CI2cDevice_t **")] IAsyncOperation<Pointer<II2cDevice>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<II2cDeviceStatics*, HSTRING, II2cConnectionSettings*, IAsyncOperation<Pointer<II2cDevice>>**, int>)(lpVtbl[8]))((II2cDeviceStatics*)Unsafe.AsPointer(ref this), deviceId, settings, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetDeviceSelector(HSTRING* value);

        [VtblIndex(7)]
        HRESULT GetDeviceSelectorFromFriendlyName(HSTRING friendlyName, HSTRING* value);

        [VtblIndex(8)]
        HRESULT FromIdAsync(HSTRING deviceId, [NativeTypeName("ABI::Windows::Devices::I2c::II2cConnectionSettings *")] II2cConnectionSettings* settings, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CI2c__CI2cDevice_t **")] IAsyncOperation<Pointer<II2cDevice>>** operation);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetDeviceSelector;

        [NativeTypeName("HRESULT (HSTRING, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING*, int> GetDeviceSelectorFromFriendlyName;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Devices::I2c::II2cConnectionSettings *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CI2c__CI2cDevice_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, II2cConnectionSettings*, IAsyncOperation<Pointer<II2cDevice>>**, int> FromIdAsync;
    }
}
