// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.advertisement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBluetoothLEAdvertisementDataSection.xml' path='doc/member[@name="IBluetoothLEAdvertisementDataSection"]/*' />
[Guid("D7213314-3A43-40F9-B6F0-92BFEFC34AE3")]
[NativeTypeName("struct IBluetoothLEAdvertisementDataSection : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBluetoothLEAdvertisementDataSection : IBluetoothLEAdvertisementDataSection.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBluetoothLEAdvertisementDataSection));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementDataSection*, Guid*, void**, int>)(lpVtbl[0]))((IBluetoothLEAdvertisementDataSection*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementDataSection*, uint>)(lpVtbl[1]))((IBluetoothLEAdvertisementDataSection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementDataSection*, uint>)(lpVtbl[2]))((IBluetoothLEAdvertisementDataSection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementDataSection*, uint*, Guid**, int>)(lpVtbl[3]))((IBluetoothLEAdvertisementDataSection*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementDataSection*, HSTRING*, int>)(lpVtbl[4]))((IBluetoothLEAdvertisementDataSection*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementDataSection*, TrustLevel*, int>)(lpVtbl[5]))((IBluetoothLEAdvertisementDataSection*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBluetoothLEAdvertisementDataSection.xml' path='doc/member[@name="IBluetoothLEAdvertisementDataSection.get_DataType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DataType(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementDataSection*, byte*, int>)(lpVtbl[6]))((IBluetoothLEAdvertisementDataSection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementDataSection.xml' path='doc/member[@name="IBluetoothLEAdvertisementDataSection.put_DataType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_DataType(byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementDataSection*, byte, int>)(lpVtbl[7]))((IBluetoothLEAdvertisementDataSection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementDataSection.xml' path='doc/member[@name="IBluetoothLEAdvertisementDataSection.get_Data"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Data([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementDataSection*, IBuffer**, int>)(lpVtbl[8]))((IBluetoothLEAdvertisementDataSection*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEAdvertisementDataSection.xml' path='doc/member[@name="IBluetoothLEAdvertisementDataSection.put_Data"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Data([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEAdvertisementDataSection*, IBuffer*, int>)(lpVtbl[9]))((IBluetoothLEAdvertisementDataSection*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DataType(byte* value);

        [VtblIndex(7)]
        HRESULT put_DataType(byte value);

        [VtblIndex(8)]
        HRESULT get_Data([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value);

        [VtblIndex(9)]
        HRESULT put_Data([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* value);
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

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_DataType;

        [NativeTypeName("HRESULT (BYTE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_DataType;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer**, int> get_Data;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, int> put_Data;
    }
}
