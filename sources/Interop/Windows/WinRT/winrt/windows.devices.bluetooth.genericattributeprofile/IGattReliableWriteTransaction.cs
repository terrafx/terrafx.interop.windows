// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.genericattributeprofile.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGattReliableWriteTransaction.xml' path='doc/member[@name="IGattReliableWriteTransaction"]/*' />
[Guid("63A66F07-1AEA-4C4C-A50F-97BAE474B348")]
[NativeTypeName("struct IGattReliableWriteTransaction : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGattReliableWriteTransaction : IGattReliableWriteTransaction.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IGattReliableWriteTransaction);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattReliableWriteTransaction*, Guid*, void**, int>)(lpVtbl[0]))((IGattReliableWriteTransaction*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattReliableWriteTransaction*, uint>)(lpVtbl[1]))((IGattReliableWriteTransaction*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattReliableWriteTransaction*, uint>)(lpVtbl[2]))((IGattReliableWriteTransaction*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattReliableWriteTransaction*, uint*, Guid**, int>)(lpVtbl[3]))((IGattReliableWriteTransaction*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattReliableWriteTransaction*, HSTRING*, int>)(lpVtbl[4]))((IGattReliableWriteTransaction*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattReliableWriteTransaction*, TrustLevel*, int>)(lpVtbl[5]))((IGattReliableWriteTransaction*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGattReliableWriteTransaction.xml' path='doc/member[@name="IGattReliableWriteTransaction.WriteValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT WriteValue([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattCharacteristic *")] IGattCharacteristic* characteristic, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattReliableWriteTransaction*, IGattCharacteristic*, IBuffer*, int>)(lpVtbl[6]))((IGattReliableWriteTransaction*)Unsafe.AsPointer(ref this), characteristic, value);
    }

    /// <include file='IGattReliableWriteTransaction.xml' path='doc/member[@name="IGattReliableWriteTransaction.CommitAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CommitAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCommunicationStatus_t **")] IAsyncOperation<GattCommunicationStatus>** asyncOp)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattReliableWriteTransaction*, IAsyncOperation<GattCommunicationStatus>**, int>)(lpVtbl[7]))((IGattReliableWriteTransaction*)Unsafe.AsPointer(ref this), asyncOp);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT WriteValue([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattCharacteristic *")] IGattCharacteristic* characteristic, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* value);

        [VtblIndex(7)]
        HRESULT CommitAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCommunicationStatus_t **")] IAsyncOperation<GattCommunicationStatus>** asyncOp);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattCharacteristic *, ABI::Windows::Storage::Streams::IBuffer *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IGattCharacteristic*, IBuffer*, int> WriteValue;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCommunicationStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<GattCommunicationStatus>**, int> CommitAsync;
    }
}
