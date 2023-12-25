// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.genericattributeprofile.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGattClientNotificationResult.xml' path='doc/member[@name="IGattClientNotificationResult"]/*' />
[Guid("506D5599-0112-419A-8E3B-AE21AFABD2C2")]
[NativeTypeName("struct IGattClientNotificationResult : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGattClientNotificationResult : IGattClientNotificationResult.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGattClientNotificationResult));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattClientNotificationResult*, Guid*, void**, int>)(lpVtbl[0]))((IGattClientNotificationResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattClientNotificationResult*, uint>)(lpVtbl[1]))((IGattClientNotificationResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattClientNotificationResult*, uint>)(lpVtbl[2]))((IGattClientNotificationResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattClientNotificationResult*, uint*, Guid**, int>)(lpVtbl[3]))((IGattClientNotificationResult*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattClientNotificationResult*, HSTRING*, int>)(lpVtbl[4]))((IGattClientNotificationResult*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattClientNotificationResult*, TrustLevel*, int>)(lpVtbl[5]))((IGattClientNotificationResult*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGattClientNotificationResult.xml' path='doc/member[@name="IGattClientNotificationResult.get_SubscribedClient"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SubscribedClient([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattSubscribedClient **")] IGattSubscribedClient** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattClientNotificationResult*, IGattSubscribedClient**, int>)(lpVtbl[6]))((IGattClientNotificationResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattClientNotificationResult.xml' path='doc/member[@name="IGattClientNotificationResult.get_Status"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Status([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattCommunicationStatus *")] GattCommunicationStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattClientNotificationResult*, GattCommunicationStatus*, int>)(lpVtbl[7]))((IGattClientNotificationResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattClientNotificationResult.xml' path='doc/member[@name="IGattClientNotificationResult.get_ProtocolError"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ProtocolError([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_byte_t **")] IReference<byte>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattClientNotificationResult*, IReference<byte>**, int>)(lpVtbl[8]))((IGattClientNotificationResult*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SubscribedClient([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattSubscribedClient **")] IGattSubscribedClient** value);

        [VtblIndex(7)]
        HRESULT get_Status([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattCommunicationStatus *")] GattCommunicationStatus* value);

        [VtblIndex(8)]
        HRESULT get_ProtocolError([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_byte_t **")] IReference<byte>** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattSubscribedClient **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IGattSubscribedClient**, int> get_SubscribedClient;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattCommunicationStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, GattCommunicationStatus*, int> get_Status;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_byte_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<byte>**, int> get_ProtocolError;
    }
}
