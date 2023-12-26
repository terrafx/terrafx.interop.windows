// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.rfcomm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRfcommServiceProvider.xml' path='doc/member[@name="IRfcommServiceProvider"]/*' />
[Guid("EADBFDC4-B1F6-44FF-9F7C-E7A82AB86821")]
[NativeTypeName("struct IRfcommServiceProvider : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRfcommServiceProvider : IRfcommServiceProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRfcommServiceProvider));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommServiceProvider*, Guid*, void**, int>)(lpVtbl[0]))((IRfcommServiceProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommServiceProvider*, uint>)(lpVtbl[1]))((IRfcommServiceProvider*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommServiceProvider*, uint>)(lpVtbl[2]))((IRfcommServiceProvider*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommServiceProvider*, uint*, Guid**, int>)(lpVtbl[3]))((IRfcommServiceProvider*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommServiceProvider*, HSTRING*, int>)(lpVtbl[4]))((IRfcommServiceProvider*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommServiceProvider*, TrustLevel*, int>)(lpVtbl[5]))((IRfcommServiceProvider*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IRfcommServiceProvider.xml' path='doc/member[@name="IRfcommServiceProvider.get_ServiceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ServiceId([NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **")] IRfcommServiceId** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommServiceProvider*, IRfcommServiceId**, int>)(lpVtbl[6]))((IRfcommServiceProvider*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRfcommServiceProvider.xml' path='doc/member[@name="IRfcommServiceProvider.get_SdpRawAttributes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_SdpRawAttributes([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_UINT32_Windows__CStorage__CStreams__CIBuffer_t **")] IMap<uint, IntPtr>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommServiceProvider*, IMap<uint, IntPtr>**, int>)(lpVtbl[7]))((IRfcommServiceProvider*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRfcommServiceProvider.xml' path='doc/member[@name="IRfcommServiceProvider.StartAdvertising"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT StartAdvertising([NativeTypeName("ABI::Windows::Networking::Sockets::IStreamSocketListener *")] IStreamSocketListener* listener)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommServiceProvider*, IStreamSocketListener*, int>)(lpVtbl[8]))((IRfcommServiceProvider*)Unsafe.AsPointer(ref this), listener);
    }

    /// <include file='IRfcommServiceProvider.xml' path='doc/member[@name="IRfcommServiceProvider.StopAdvertising"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT StopAdvertising()
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommServiceProvider*, int>)(lpVtbl[9]))((IRfcommServiceProvider*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ServiceId([NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **")] IRfcommServiceId** value);

        [VtblIndex(7)]
        HRESULT get_SdpRawAttributes([NativeTypeName("ABI::Windows::Foundation::Collections::__FIMap_2_UINT32_Windows__CStorage__CStreams__CIBuffer_t **")] IMap<uint, IntPtr>** value);

        [VtblIndex(8)]
        HRESULT StartAdvertising([NativeTypeName("ABI::Windows::Networking::Sockets::IStreamSocketListener *")] IStreamSocketListener* listener);

        [VtblIndex(9)]
        HRESULT StopAdvertising();
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRfcommServiceId**, int> get_ServiceId;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIMap_2_UINT32_Windows__CStorage__CStreams__CIBuffer_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMap<uint, IntPtr>**, int> get_SdpRawAttributes;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Sockets::IStreamSocketListener *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStreamSocketListener*, int> StartAdvertising;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> StopAdvertising;
    }
}
