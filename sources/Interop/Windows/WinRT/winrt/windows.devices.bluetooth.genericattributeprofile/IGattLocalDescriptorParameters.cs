// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.genericattributeprofile.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGattLocalDescriptorParameters.xml' path='doc/member[@name="IGattLocalDescriptorParameters"]/*' />
[Guid("5FDEDE6A-F3C1-4B66-8C4B-E3D2293B40E9")]
[NativeTypeName("struct IGattLocalDescriptorParameters : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGattLocalDescriptorParameters : IGattLocalDescriptorParameters.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGattLocalDescriptorParameters));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalDescriptorParameters*, Guid*, void**, int>)(lpVtbl[0]))((IGattLocalDescriptorParameters*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalDescriptorParameters*, uint>)(lpVtbl[1]))((IGattLocalDescriptorParameters*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalDescriptorParameters*, uint>)(lpVtbl[2]))((IGattLocalDescriptorParameters*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalDescriptorParameters*, uint*, Guid**, int>)(lpVtbl[3]))((IGattLocalDescriptorParameters*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalDescriptorParameters*, HSTRING*, int>)(lpVtbl[4]))((IGattLocalDescriptorParameters*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalDescriptorParameters*, TrustLevel*, int>)(lpVtbl[5]))((IGattLocalDescriptorParameters*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGattLocalDescriptorParameters.xml' path='doc/member[@name="IGattLocalDescriptorParameters.put_StaticValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_StaticValue([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalDescriptorParameters*, IBuffer*, int>)(lpVtbl[6]))((IGattLocalDescriptorParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattLocalDescriptorParameters.xml' path='doc/member[@name="IGattLocalDescriptorParameters.get_StaticValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_StaticValue([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalDescriptorParameters*, IBuffer**, int>)(lpVtbl[7]))((IGattLocalDescriptorParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattLocalDescriptorParameters.xml' path='doc/member[@name="IGattLocalDescriptorParameters.put_ReadProtectionLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_ReadProtectionLevel([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel")] GattProtectionLevel value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalDescriptorParameters*, GattProtectionLevel, int>)(lpVtbl[8]))((IGattLocalDescriptorParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattLocalDescriptorParameters.xml' path='doc/member[@name="IGattLocalDescriptorParameters.get_ReadProtectionLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ReadProtectionLevel([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel *")] GattProtectionLevel* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalDescriptorParameters*, GattProtectionLevel*, int>)(lpVtbl[9]))((IGattLocalDescriptorParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattLocalDescriptorParameters.xml' path='doc/member[@name="IGattLocalDescriptorParameters.put_WriteProtectionLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_WriteProtectionLevel([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel")] GattProtectionLevel value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalDescriptorParameters*, GattProtectionLevel, int>)(lpVtbl[10]))((IGattLocalDescriptorParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattLocalDescriptorParameters.xml' path='doc/member[@name="IGattLocalDescriptorParameters.get_WriteProtectionLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_WriteProtectionLevel([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel *")] GattProtectionLevel* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalDescriptorParameters*, GattProtectionLevel*, int>)(lpVtbl[11]))((IGattLocalDescriptorParameters*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_StaticValue([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* value);

        [VtblIndex(7)]
        HRESULT get_StaticValue([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value);

        [VtblIndex(8)]
        HRESULT put_ReadProtectionLevel([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel")] GattProtectionLevel value);

        [VtblIndex(9)]
        HRESULT get_ReadProtectionLevel([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel *")] GattProtectionLevel* value);

        [VtblIndex(10)]
        HRESULT put_WriteProtectionLevel([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel")] GattProtectionLevel value);

        [VtblIndex(11)]
        HRESULT get_WriteProtectionLevel([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel *")] GattProtectionLevel* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, GattProtectionLevel, int> put_ReadProtectionLevel;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, GattProtectionLevel*, int> get_ReadProtectionLevel;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, GattProtectionLevel, int> put_WriteProtectionLevel;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, GattProtectionLevel*, int> get_WriteProtectionLevel;
    }
}
