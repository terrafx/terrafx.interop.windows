// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.genericattributeprofile.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGattLocalCharacteristicParameters.xml' path='doc/member[@name="IGattLocalCharacteristicParameters"]/*' />
[Guid("FAF73DB4-4CFF-44C7-8445-040E6EAD0063")]
[NativeTypeName("struct IGattLocalCharacteristicParameters : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGattLocalCharacteristicParameters : IGattLocalCharacteristicParameters.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGattLocalCharacteristicParameters));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalCharacteristicParameters*, Guid*, void**, int>)(lpVtbl[0]))((IGattLocalCharacteristicParameters*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalCharacteristicParameters*, uint>)(lpVtbl[1]))((IGattLocalCharacteristicParameters*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalCharacteristicParameters*, uint>)(lpVtbl[2]))((IGattLocalCharacteristicParameters*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalCharacteristicParameters*, uint*, Guid**, int>)(lpVtbl[3]))((IGattLocalCharacteristicParameters*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalCharacteristicParameters*, HSTRING*, int>)(lpVtbl[4]))((IGattLocalCharacteristicParameters*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalCharacteristicParameters*, TrustLevel*, int>)(lpVtbl[5]))((IGattLocalCharacteristicParameters*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGattLocalCharacteristicParameters.xml' path='doc/member[@name="IGattLocalCharacteristicParameters.put_StaticValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_StaticValue([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalCharacteristicParameters*, IBuffer*, int>)(lpVtbl[6]))((IGattLocalCharacteristicParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattLocalCharacteristicParameters.xml' path='doc/member[@name="IGattLocalCharacteristicParameters.get_StaticValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_StaticValue([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalCharacteristicParameters*, IBuffer**, int>)(lpVtbl[7]))((IGattLocalCharacteristicParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattLocalCharacteristicParameters.xml' path='doc/member[@name="IGattLocalCharacteristicParameters.put_CharacteristicProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_CharacteristicProperties([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattCharacteristicProperties")] GattCharacteristicProperties value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalCharacteristicParameters*, GattCharacteristicProperties, int>)(lpVtbl[8]))((IGattLocalCharacteristicParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattLocalCharacteristicParameters.xml' path='doc/member[@name="IGattLocalCharacteristicParameters.get_CharacteristicProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_CharacteristicProperties([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattCharacteristicProperties *")] GattCharacteristicProperties* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalCharacteristicParameters*, GattCharacteristicProperties*, int>)(lpVtbl[9]))((IGattLocalCharacteristicParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattLocalCharacteristicParameters.xml' path='doc/member[@name="IGattLocalCharacteristicParameters.put_ReadProtectionLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_ReadProtectionLevel([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel")] GattProtectionLevel value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalCharacteristicParameters*, GattProtectionLevel, int>)(lpVtbl[10]))((IGattLocalCharacteristicParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattLocalCharacteristicParameters.xml' path='doc/member[@name="IGattLocalCharacteristicParameters.get_ReadProtectionLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_ReadProtectionLevel([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel *")] GattProtectionLevel* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalCharacteristicParameters*, GattProtectionLevel*, int>)(lpVtbl[11]))((IGattLocalCharacteristicParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattLocalCharacteristicParameters.xml' path='doc/member[@name="IGattLocalCharacteristicParameters.put_WriteProtectionLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_WriteProtectionLevel([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel")] GattProtectionLevel value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalCharacteristicParameters*, GattProtectionLevel, int>)(lpVtbl[12]))((IGattLocalCharacteristicParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattLocalCharacteristicParameters.xml' path='doc/member[@name="IGattLocalCharacteristicParameters.get_WriteProtectionLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_WriteProtectionLevel([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel *")] GattProtectionLevel* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalCharacteristicParameters*, GattProtectionLevel*, int>)(lpVtbl[13]))((IGattLocalCharacteristicParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattLocalCharacteristicParameters.xml' path='doc/member[@name="IGattLocalCharacteristicParameters.put_UserDescription"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_UserDescription(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalCharacteristicParameters*, HSTRING, int>)(lpVtbl[14]))((IGattLocalCharacteristicParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattLocalCharacteristicParameters.xml' path='doc/member[@name="IGattLocalCharacteristicParameters.get_UserDescription"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_UserDescription(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalCharacteristicParameters*, HSTRING*, int>)(lpVtbl[15]))((IGattLocalCharacteristicParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattLocalCharacteristicParameters.xml' path='doc/member[@name="IGattLocalCharacteristicParameters.get_PresentationFormats"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_PresentationFormats([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattPresentationFormat_t **")] IVector<Pointer<IGattPresentationFormat>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalCharacteristicParameters*, IVector<Pointer<IGattPresentationFormat>>**, int>)(lpVtbl[16]))((IGattLocalCharacteristicParameters*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_StaticValue([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* value);

        [VtblIndex(7)]
        HRESULT get_StaticValue([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value);

        [VtblIndex(8)]
        HRESULT put_CharacteristicProperties([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattCharacteristicProperties")] GattCharacteristicProperties value);

        [VtblIndex(9)]
        HRESULT get_CharacteristicProperties([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattCharacteristicProperties *")] GattCharacteristicProperties* value);

        [VtblIndex(10)]
        HRESULT put_ReadProtectionLevel([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel")] GattProtectionLevel value);

        [VtblIndex(11)]
        HRESULT get_ReadProtectionLevel([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel *")] GattProtectionLevel* value);

        [VtblIndex(12)]
        HRESULT put_WriteProtectionLevel([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel")] GattProtectionLevel value);

        [VtblIndex(13)]
        HRESULT get_WriteProtectionLevel([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel *")] GattProtectionLevel* value);

        [VtblIndex(14)]
        HRESULT put_UserDescription(HSTRING value);

        [VtblIndex(15)]
        HRESULT get_UserDescription(HSTRING* value);

        [VtblIndex(16)]
        HRESULT get_PresentationFormats([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattPresentationFormat_t **")] IVector<Pointer<IGattPresentationFormat>>** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, int> put_StaticValue;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer**, int> get_StaticValue;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattCharacteristicProperties) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, GattCharacteristicProperties, int> put_CharacteristicProperties;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattCharacteristicProperties *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, GattCharacteristicProperties*, int> get_CharacteristicProperties;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, GattProtectionLevel, int> put_ReadProtectionLevel;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, GattProtectionLevel*, int> get_ReadProtectionLevel;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, GattProtectionLevel, int> put_WriteProtectionLevel;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, GattProtectionLevel*, int> get_WriteProtectionLevel;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_UserDescription;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_UserDescription;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattPresentationFormat_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<Pointer<IGattPresentationFormat>>**, int> get_PresentationFormats;
    }
}
