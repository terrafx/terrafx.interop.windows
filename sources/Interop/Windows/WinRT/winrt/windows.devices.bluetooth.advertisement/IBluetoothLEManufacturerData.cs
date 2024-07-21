// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.advertisement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBluetoothLEManufacturerData.xml' path='doc/member[@name="IBluetoothLEManufacturerData"]/*' />
[Guid("912DBA18-6963-4533-B061-4694DAFB34E5")]
[NativeTypeName("struct IBluetoothLEManufacturerData : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBluetoothLEManufacturerData : IBluetoothLEManufacturerData.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBluetoothLEManufacturerData));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEManufacturerData*, Guid*, void**, int>)(lpVtbl[0]))((IBluetoothLEManufacturerData*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEManufacturerData*, uint>)(lpVtbl[1]))((IBluetoothLEManufacturerData*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEManufacturerData*, uint>)(lpVtbl[2]))((IBluetoothLEManufacturerData*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEManufacturerData*, uint*, Guid**, int>)(lpVtbl[3]))((IBluetoothLEManufacturerData*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEManufacturerData*, HSTRING*, int>)(lpVtbl[4]))((IBluetoothLEManufacturerData*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEManufacturerData*, TrustLevel*, int>)(lpVtbl[5]))((IBluetoothLEManufacturerData*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBluetoothLEManufacturerData.xml' path='doc/member[@name="IBluetoothLEManufacturerData.get_CompanyId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CompanyId([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEManufacturerData*, ushort*, int>)(lpVtbl[6]))((IBluetoothLEManufacturerData*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEManufacturerData.xml' path='doc/member[@name="IBluetoothLEManufacturerData.put_CompanyId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_CompanyId([NativeTypeName("UINT16")] ushort value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEManufacturerData*, ushort, int>)(lpVtbl[7]))((IBluetoothLEManufacturerData*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEManufacturerData.xml' path='doc/member[@name="IBluetoothLEManufacturerData.get_Data"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Data([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEManufacturerData*, IBuffer**, int>)(lpVtbl[8]))((IBluetoothLEManufacturerData*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBluetoothLEManufacturerData.xml' path='doc/member[@name="IBluetoothLEManufacturerData.put_Data"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Data([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBluetoothLEManufacturerData*, IBuffer*, int>)(lpVtbl[9]))((IBluetoothLEManufacturerData*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_CompanyId([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(7)]
        HRESULT put_CompanyId([NativeTypeName("UINT16")] ushort value);

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

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort*, int> get_CompanyId;

        [NativeTypeName("HRESULT (UINT16) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort, int> put_CompanyId;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer**, int> get_Data;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, int> put_Data;
    }
}
