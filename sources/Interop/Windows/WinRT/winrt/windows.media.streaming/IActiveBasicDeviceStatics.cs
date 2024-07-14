// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.streaming.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IActiveBasicDeviceStatics.xml' path='doc/member[@name="IActiveBasicDeviceStatics"]/*' />
[Guid("6D33255D-3642-4618-9DB6-43524F4DEADC")]
[NativeTypeName("struct IActiveBasicDeviceStatics : IInspectable")]
[NativeInheritance("IInspectable")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IActiveBasicDeviceStatics : IActiveBasicDeviceStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IActiveBasicDeviceStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IActiveBasicDeviceStatics*, Guid*, void**, int>)(lpVtbl[0]))((IActiveBasicDeviceStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IActiveBasicDeviceStatics*, uint>)(lpVtbl[1]))((IActiveBasicDeviceStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IActiveBasicDeviceStatics*, uint>)(lpVtbl[2]))((IActiveBasicDeviceStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IActiveBasicDeviceStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IActiveBasicDeviceStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IActiveBasicDeviceStatics*, HSTRING*, int>)(lpVtbl[4]))((IActiveBasicDeviceStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IActiveBasicDeviceStatics*, TrustLevel*, int>)(lpVtbl[5]))((IActiveBasicDeviceStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IActiveBasicDeviceStatics.xml' path='doc/member[@name="IActiveBasicDeviceStatics.CreateBasicDeviceAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateBasicDeviceAsync(HSTRING deviceIdentifier, [NativeTypeName("ABI::Windows::Media::Streaming::DeviceTypes")] DeviceTypes type, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CActiveBasicDevice_t **")] IAsyncOperation<Pointer<IActiveBasicDevice>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IActiveBasicDeviceStatics*, HSTRING, DeviceTypes, IAsyncOperation<Pointer<IActiveBasicDevice>>**, int>)(lpVtbl[6]))((IActiveBasicDeviceStatics*)Unsafe.AsPointer(ref this), deviceIdentifier, type, value);
    }

    /// <include file='IActiveBasicDeviceStatics.xml' path='doc/member[@name="IActiveBasicDeviceStatics.CloneBasicDeviceAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CloneBasicDeviceAsync([NativeTypeName("ABI::Windows::Media::Streaming::IBasicDevice *")] IBasicDevice* basicDevice, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CActiveBasicDevice_t **")] IAsyncOperation<Pointer<IActiveBasicDevice>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IActiveBasicDeviceStatics*, IBasicDevice*, IAsyncOperation<Pointer<IActiveBasicDevice>>**, int>)(lpVtbl[7]))((IActiveBasicDeviceStatics*)Unsafe.AsPointer(ref this), basicDevice, value);
    }

    /// <include file='IActiveBasicDeviceStatics.xml' path='doc/member[@name="IActiveBasicDeviceStatics.GetDevicesOnMatchingNetworkAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDevicesOnMatchingNetworkAsync([NativeTypeName("ABI::Windows::Media::Streaming::IActiveBasicDevice *")] IActiveBasicDevice* server, [NativeTypeName("ABI::Windows::Media::Streaming::IActiveBasicDevice *")] IActiveBasicDevice* renderer, [NativeTypeName("boolean")] byte optimizeForProxying, [NativeTypeName("boolean")] byte allowChangeRendererNetwork, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CDevicePair_t **")] IAsyncOperation<Pointer<IDevicePair>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IActiveBasicDeviceStatics*, IActiveBasicDevice*, IActiveBasicDevice*, byte, byte, IAsyncOperation<Pointer<IDevicePair>>**, int>)(lpVtbl[8]))((IActiveBasicDeviceStatics*)Unsafe.AsPointer(ref this), server, renderer, optimizeForProxying, allowChangeRendererNetwork, operation);
    }

    /// <include file='IActiveBasicDeviceStatics.xml' path='doc/member[@name="IActiveBasicDeviceStatics.CreateDevicesOnMatchingNetworkAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateDevicesOnMatchingNetworkAsync(HSTRING serverUDN, [NativeTypeName("ABI::Windows::Media::Streaming::IActiveBasicDevice *")] IActiveBasicDevice* renderer, [NativeTypeName("boolean")] byte optimizeForProxying, [NativeTypeName("boolean")] byte allowChangeRendererNetwork, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CDevicePair_t **")] IAsyncOperation<Pointer<IDevicePair>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IActiveBasicDeviceStatics*, HSTRING, IActiveBasicDevice*, byte, byte, IAsyncOperation<Pointer<IDevicePair>>**, int>)(lpVtbl[9]))((IActiveBasicDeviceStatics*)Unsafe.AsPointer(ref this), serverUDN, renderer, optimizeForProxying, allowChangeRendererNetwork, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateBasicDeviceAsync(HSTRING deviceIdentifier, [NativeTypeName("ABI::Windows::Media::Streaming::DeviceTypes")] DeviceTypes type, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CActiveBasicDevice_t **")] IAsyncOperation<Pointer<IActiveBasicDevice>>** value);

        [VtblIndex(7)]
        HRESULT CloneBasicDeviceAsync([NativeTypeName("ABI::Windows::Media::Streaming::IBasicDevice *")] IBasicDevice* basicDevice, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CActiveBasicDevice_t **")] IAsyncOperation<Pointer<IActiveBasicDevice>>** value);

        [VtblIndex(8)]
        HRESULT GetDevicesOnMatchingNetworkAsync([NativeTypeName("ABI::Windows::Media::Streaming::IActiveBasicDevice *")] IActiveBasicDevice* server, [NativeTypeName("ABI::Windows::Media::Streaming::IActiveBasicDevice *")] IActiveBasicDevice* renderer, [NativeTypeName("boolean")] byte optimizeForProxying, [NativeTypeName("boolean")] byte allowChangeRendererNetwork, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CDevicePair_t **")] IAsyncOperation<Pointer<IDevicePair>>** operation);

        [VtblIndex(9)]
        HRESULT CreateDevicesOnMatchingNetworkAsync(HSTRING serverUDN, [NativeTypeName("ABI::Windows::Media::Streaming::IActiveBasicDevice *")] IActiveBasicDevice* renderer, [NativeTypeName("boolean")] byte optimizeForProxying, [NativeTypeName("boolean")] byte allowChangeRendererNetwork, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CDevicePair_t **")] IAsyncOperation<Pointer<IDevicePair>>** operation);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Media::Streaming::DeviceTypes, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CActiveBasicDevice_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, DeviceTypes, IAsyncOperation<Pointer<IActiveBasicDevice>>**, int> CreateBasicDeviceAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Streaming::IBasicDevice *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CActiveBasicDevice_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBasicDevice*, IAsyncOperation<Pointer<IActiveBasicDevice>>**, int> CloneBasicDeviceAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Streaming::IActiveBasicDevice *, ABI::Windows::Media::Streaming::IActiveBasicDevice *, ::boolean, ::boolean, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CDevicePair_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IActiveBasicDevice*, IActiveBasicDevice*, byte, byte, IAsyncOperation<Pointer<IDevicePair>>**, int> GetDevicesOnMatchingNetworkAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Media::Streaming::IActiveBasicDevice *, ::boolean, ::boolean, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CDevicePair_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IActiveBasicDevice*, byte, byte, IAsyncOperation<Pointer<IDevicePair>>**, int> CreateDevicesOnMatchingNetworkAsync;
    }
}
