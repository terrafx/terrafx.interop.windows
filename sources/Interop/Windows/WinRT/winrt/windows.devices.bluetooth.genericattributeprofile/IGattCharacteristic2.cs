// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.genericattributeprofile.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGattCharacteristic2.xml' path='doc/member[@name="IGattCharacteristic2"]/*' />
[Guid("AE1AB578-EC06-4764-B780-9835A1D35D6E")]
[NativeTypeName("struct IGattCharacteristic2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGattCharacteristic2 : IGattCharacteristic2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGattCharacteristic2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristic2*, Guid*, void**, int>)(lpVtbl[0]))((IGattCharacteristic2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristic2*, uint>)(lpVtbl[1]))((IGattCharacteristic2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristic2*, uint>)(lpVtbl[2]))((IGattCharacteristic2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristic2*, uint*, Guid**, int>)(lpVtbl[3]))((IGattCharacteristic2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristic2*, HSTRING*, int>)(lpVtbl[4]))((IGattCharacteristic2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristic2*, TrustLevel*, int>)(lpVtbl[5]))((IGattCharacteristic2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGattCharacteristic2.xml' path='doc/member[@name="IGattCharacteristic2.get_Service"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Service([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattDeviceService **")] IGattDeviceService** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristic2*, IGattDeviceService**, int>)(lpVtbl[6]))((IGattCharacteristic2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattCharacteristic2.xml' path='doc/member[@name="IGattCharacteristic2.GetAllDescriptors"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete("Use GetDescriptorsAsync instead of GetAllDescriptors.  For more information, see MSDN.")]
    public HRESULT GetAllDescriptors([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDescriptor_t **")] IVectorView<Pointer<IGattDescriptor>>** descriptors)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattCharacteristic2*, IVectorView<Pointer<IGattDescriptor>>**, int>)(lpVtbl[7]))((IGattCharacteristic2*)Unsafe.AsPointer(ref this), descriptors);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Service([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattDeviceService **")] IGattDeviceService** value);

        [VtblIndex(7)]
        [Obsolete("Use GetDescriptorsAsync instead of GetAllDescriptors.  For more information, see MSDN.")]
        HRESULT GetAllDescriptors([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDescriptor_t **")] IVectorView<Pointer<IGattDescriptor>>** descriptors);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattDeviceService **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IGattDeviceService**, int> get_Service;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDescriptor_t **) __attribute__((stdcall))")]
        [Obsolete("Use GetDescriptorsAsync instead of GetAllDescriptors.  For more information, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IGattDescriptor>>**, int> GetAllDescriptors;
    }
}
