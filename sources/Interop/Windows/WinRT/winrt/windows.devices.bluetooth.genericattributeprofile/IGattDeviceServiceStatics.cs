// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.genericattributeprofile.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGattDeviceServiceStatics.xml' path='doc/member[@name="IGattDeviceServiceStatics"]/*' />
[Guid("196D0022-FAAD-45DC-AE5B-2AC3184E84DB")]
[NativeTypeName("struct IGattDeviceServiceStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGattDeviceServiceStatics : IGattDeviceServiceStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGattDeviceServiceStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceServiceStatics*, Guid*, void**, int>)(lpVtbl[0]))((IGattDeviceServiceStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceServiceStatics*, uint>)(lpVtbl[1]))((IGattDeviceServiceStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceServiceStatics*, uint>)(lpVtbl[2]))((IGattDeviceServiceStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceServiceStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IGattDeviceServiceStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceServiceStatics*, HSTRING*, int>)(lpVtbl[4]))((IGattDeviceServiceStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceServiceStatics*, TrustLevel*, int>)(lpVtbl[5]))((IGattDeviceServiceStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGattDeviceServiceStatics.xml' path='doc/member[@name="IGattDeviceServiceStatics.FromIdAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FromIdAsync(HSTRING deviceId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceService_t **")] IAsyncOperation<Pointer<IGattDeviceService>>** asyncOp)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceServiceStatics*, HSTRING, IAsyncOperation<Pointer<IGattDeviceService>>**, int>)(lpVtbl[6]))((IGattDeviceServiceStatics*)Unsafe.AsPointer(ref this), deviceId, asyncOp);
    }

    /// <include file='IGattDeviceServiceStatics.xml' path='doc/member[@name="IGattDeviceServiceStatics.GetDeviceSelectorFromUuid"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDeviceSelectorFromUuid(Guid serviceUuid, HSTRING* selector)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceServiceStatics*, Guid, HSTRING*, int>)(lpVtbl[7]))((IGattDeviceServiceStatics*)Unsafe.AsPointer(ref this), serviceUuid, selector);
    }

    /// <include file='IGattDeviceServiceStatics.xml' path='doc/member[@name="IGattDeviceServiceStatics.GetDeviceSelectorFromShortId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete("Use GetDeviceSelectorFromUuid instead of GetDeviceSelectorFromShortId.  For more information, see MSDN.")]
    public HRESULT GetDeviceSelectorFromShortId([NativeTypeName("UINT16")] ushort serviceShortId, HSTRING* selector)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceServiceStatics*, ushort, HSTRING*, int>)(lpVtbl[8]))((IGattDeviceServiceStatics*)Unsafe.AsPointer(ref this), serviceShortId, selector);
    }

    /// <include file='IGattDeviceServiceStatics.xml' path='doc/member[@name="IGattDeviceServiceStatics.ConvertShortIdToUuid"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [Obsolete("Use BluetoothUuidHelper instead of ConvertShortIdToUuid.  For more information, see MSDN.")]
    public HRESULT ConvertShortIdToUuid([NativeTypeName("UINT16")] ushort shortId, Guid* serviceUuid)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDeviceServiceStatics*, ushort, Guid*, int>)(lpVtbl[9]))((IGattDeviceServiceStatics*)Unsafe.AsPointer(ref this), shortId, serviceUuid);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT FromIdAsync(HSTRING deviceId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceService_t **")] IAsyncOperation<Pointer<IGattDeviceService>>** asyncOp);

        [VtblIndex(7)]
        HRESULT GetDeviceSelectorFromUuid(Guid serviceUuid, HSTRING* selector);

        [VtblIndex(8)]
        [Obsolete("Use GetDeviceSelectorFromUuid instead of GetDeviceSelectorFromShortId.  For more information, see MSDN.")]
        HRESULT GetDeviceSelectorFromShortId([NativeTypeName("UINT16")] ushort serviceShortId, HSTRING* selector);

        [VtblIndex(9)]
        [Obsolete("Use BluetoothUuidHelper instead of ConvertShortIdToUuid.  For more information, see MSDN.")]
        HRESULT ConvertShortIdToUuid([NativeTypeName("UINT16")] ushort shortId, Guid* serviceUuid);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattDeviceService_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<Pointer<IGattDeviceService>>**, int> FromIdAsync;

        [NativeTypeName("HRESULT (GUID, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid, HSTRING*, int> GetDeviceSelectorFromUuid;

        [NativeTypeName("HRESULT (UINT16, HSTRING *) __attribute__((stdcall))")]
        [Obsolete("Use GetDeviceSelectorFromUuid instead of GetDeviceSelectorFromShortId.  For more information, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort, HSTRING*, int> GetDeviceSelectorFromShortId;

        [NativeTypeName("HRESULT (UINT16, GUID *) __attribute__((stdcall))")]
        [Obsolete("Use BluetoothUuidHelper instead of ConvertShortIdToUuid.  For more information, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort, Guid*, int> ConvertShortIdToUuid;
    }
}
