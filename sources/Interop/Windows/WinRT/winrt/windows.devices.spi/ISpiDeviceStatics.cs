// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.spi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISpiDeviceStatics.xml' path='doc/member[@name="ISpiDeviceStatics"]/*' />
[Guid("A278E559-5720-4D3F-BD93-56F5FF5A5879")]
[NativeTypeName("struct ISpiDeviceStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpiDeviceStatics : ISpiDeviceStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ISpiDeviceStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiDeviceStatics*, Guid*, void**, int>)(lpVtbl[0]))((ISpiDeviceStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiDeviceStatics*, uint>)(lpVtbl[1]))((ISpiDeviceStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiDeviceStatics*, uint>)(lpVtbl[2]))((ISpiDeviceStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiDeviceStatics*, uint*, Guid**, int>)(lpVtbl[3]))((ISpiDeviceStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiDeviceStatics*, HSTRING*, int>)(lpVtbl[4]))((ISpiDeviceStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiDeviceStatics*, TrustLevel*, int>)(lpVtbl[5]))((ISpiDeviceStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISpiDeviceStatics.xml' path='doc/member[@name="ISpiDeviceStatics.GetDeviceSelector"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDeviceSelector(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiDeviceStatics*, HSTRING*, int>)(lpVtbl[6]))((ISpiDeviceStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpiDeviceStatics.xml' path='doc/member[@name="ISpiDeviceStatics.GetDeviceSelectorFromFriendlyName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDeviceSelectorFromFriendlyName(HSTRING friendlyName, HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiDeviceStatics*, HSTRING, HSTRING*, int>)(lpVtbl[7]))((ISpiDeviceStatics*)Unsafe.AsPointer(ref this), friendlyName, value);
    }

    /// <include file='ISpiDeviceStatics.xml' path='doc/member[@name="ISpiDeviceStatics.GetBusInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetBusInfo(HSTRING busId, [NativeTypeName("ABI::Windows::Devices::Spi::ISpiBusInfo **")] ISpiBusInfo** busInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiDeviceStatics*, HSTRING, ISpiBusInfo**, int>)(lpVtbl[8]))((ISpiDeviceStatics*)Unsafe.AsPointer(ref this), busId, busInfo);
    }

    /// <include file='ISpiDeviceStatics.xml' path='doc/member[@name="ISpiDeviceStatics.FromIdAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT FromIdAsync(HSTRING busId, [NativeTypeName("ABI::Windows::Devices::Spi::ISpiConnectionSettings *")] ISpiConnectionSettings* settings, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSpi__CSpiDevice_t **")] IAsyncOperation<Pointer<ISpiDevice>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiDeviceStatics*, HSTRING, ISpiConnectionSettings*, IAsyncOperation<Pointer<ISpiDevice>>**, int>)(lpVtbl[9]))((ISpiDeviceStatics*)Unsafe.AsPointer(ref this), busId, settings, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetDeviceSelector(HSTRING* value);

        [VtblIndex(7)]
        HRESULT GetDeviceSelectorFromFriendlyName(HSTRING friendlyName, HSTRING* value);

        [VtblIndex(8)]
        HRESULT GetBusInfo(HSTRING busId, [NativeTypeName("ABI::Windows::Devices::Spi::ISpiBusInfo **")] ISpiBusInfo** busInfo);

        [VtblIndex(9)]
        HRESULT FromIdAsync(HSTRING busId, [NativeTypeName("ABI::Windows::Devices::Spi::ISpiConnectionSettings *")] ISpiConnectionSettings* settings, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSpi__CSpiDevice_t **")] IAsyncOperation<Pointer<ISpiDevice>>** operation);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Devices::Spi::ISpiBusInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, ISpiBusInfo**, int> GetBusInfo;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Devices::Spi::ISpiConnectionSettings *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSpi__CSpiDevice_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, ISpiConnectionSettings*, IAsyncOperation<Pointer<ISpiDevice>>**, int> FromIdAsync;
    }
}
