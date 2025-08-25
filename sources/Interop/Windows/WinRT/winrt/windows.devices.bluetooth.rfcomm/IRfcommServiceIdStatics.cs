// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.rfcomm.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRfcommServiceIdStatics.xml' path='doc/member[@name="IRfcommServiceIdStatics"]/*' />
[Guid("2A179EBA-A975-46E3-B56B-08FFD783A5FE")]
[NativeTypeName("struct IRfcommServiceIdStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRfcommServiceIdStatics : IRfcommServiceIdStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IRfcommServiceIdStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommServiceIdStatics*, Guid*, void**, int>)(lpVtbl[0]))((IRfcommServiceIdStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommServiceIdStatics*, uint>)(lpVtbl[1]))((IRfcommServiceIdStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommServiceIdStatics*, uint>)(lpVtbl[2]))((IRfcommServiceIdStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommServiceIdStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IRfcommServiceIdStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommServiceIdStatics*, HSTRING*, int>)(lpVtbl[4]))((IRfcommServiceIdStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommServiceIdStatics*, TrustLevel*, int>)(lpVtbl[5]))((IRfcommServiceIdStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IRfcommServiceIdStatics.xml' path='doc/member[@name="IRfcommServiceIdStatics.FromUuid"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FromUuid(Guid uuid, [NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **")] IRfcommServiceId** serviceId)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommServiceIdStatics*, Guid, IRfcommServiceId**, int>)(lpVtbl[6]))((IRfcommServiceIdStatics*)Unsafe.AsPointer(ref this), uuid, serviceId);
    }

    /// <include file='IRfcommServiceIdStatics.xml' path='doc/member[@name="IRfcommServiceIdStatics.FromShortId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT FromShortId([NativeTypeName("UINT32")] uint shortId, [NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **")] IRfcommServiceId** serviceId)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommServiceIdStatics*, uint, IRfcommServiceId**, int>)(lpVtbl[7]))((IRfcommServiceIdStatics*)Unsafe.AsPointer(ref this), shortId, serviceId);
    }

    /// <include file='IRfcommServiceIdStatics.xml' path='doc/member[@name="IRfcommServiceIdStatics.get_SerialPort"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SerialPort([NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **")] IRfcommServiceId** serviceId)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommServiceIdStatics*, IRfcommServiceId**, int>)(lpVtbl[8]))((IRfcommServiceIdStatics*)Unsafe.AsPointer(ref this), serviceId);
    }

    /// <include file='IRfcommServiceIdStatics.xml' path='doc/member[@name="IRfcommServiceIdStatics.get_ObexObjectPush"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ObexObjectPush([NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **")] IRfcommServiceId** serviceId)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommServiceIdStatics*, IRfcommServiceId**, int>)(lpVtbl[9]))((IRfcommServiceIdStatics*)Unsafe.AsPointer(ref this), serviceId);
    }

    /// <include file='IRfcommServiceIdStatics.xml' path='doc/member[@name="IRfcommServiceIdStatics.get_ObexFileTransfer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ObexFileTransfer([NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **")] IRfcommServiceId** serviceId)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommServiceIdStatics*, IRfcommServiceId**, int>)(lpVtbl[10]))((IRfcommServiceIdStatics*)Unsafe.AsPointer(ref this), serviceId);
    }

    /// <include file='IRfcommServiceIdStatics.xml' path='doc/member[@name="IRfcommServiceIdStatics.get_PhoneBookAccessPce"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_PhoneBookAccessPce([NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **")] IRfcommServiceId** serviceId)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommServiceIdStatics*, IRfcommServiceId**, int>)(lpVtbl[11]))((IRfcommServiceIdStatics*)Unsafe.AsPointer(ref this), serviceId);
    }

    /// <include file='IRfcommServiceIdStatics.xml' path='doc/member[@name="IRfcommServiceIdStatics.get_PhoneBookAccessPse"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_PhoneBookAccessPse([NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **")] IRfcommServiceId** serviceId)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommServiceIdStatics*, IRfcommServiceId**, int>)(lpVtbl[12]))((IRfcommServiceIdStatics*)Unsafe.AsPointer(ref this), serviceId);
    }

    /// <include file='IRfcommServiceIdStatics.xml' path='doc/member[@name="IRfcommServiceIdStatics.get_GenericFileTransfer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_GenericFileTransfer([NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **")] IRfcommServiceId** serviceId)
    {
        return ((delegate* unmanaged[MemberFunction]<IRfcommServiceIdStatics*, IRfcommServiceId**, int>)(lpVtbl[13]))((IRfcommServiceIdStatics*)Unsafe.AsPointer(ref this), serviceId);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT FromUuid(Guid uuid, [NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **")] IRfcommServiceId** serviceId);

        [VtblIndex(7)]
        HRESULT FromShortId([NativeTypeName("UINT32")] uint shortId, [NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **")] IRfcommServiceId** serviceId);

        [VtblIndex(8)]
        HRESULT get_SerialPort([NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **")] IRfcommServiceId** serviceId);

        [VtblIndex(9)]
        HRESULT get_ObexObjectPush([NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **")] IRfcommServiceId** serviceId);

        [VtblIndex(10)]
        HRESULT get_ObexFileTransfer([NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **")] IRfcommServiceId** serviceId);

        [VtblIndex(11)]
        HRESULT get_PhoneBookAccessPce([NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **")] IRfcommServiceId** serviceId);

        [VtblIndex(12)]
        HRESULT get_PhoneBookAccessPse([NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **")] IRfcommServiceId** serviceId);

        [VtblIndex(13)]
        HRESULT get_GenericFileTransfer([NativeTypeName("ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **")] IRfcommServiceId** serviceId);
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

        [NativeTypeName("HRESULT (GUID, ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid, IRfcommServiceId**, int> FromUuid;

        [NativeTypeName("HRESULT (UINT32, ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IRfcommServiceId**, int> FromShortId;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRfcommServiceId**, int> get_SerialPort;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRfcommServiceId**, int> get_ObexObjectPush;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRfcommServiceId**, int> get_ObexFileTransfer;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRfcommServiceId**, int> get_PhoneBookAccessPce;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRfcommServiceId**, int> get_PhoneBookAccessPse;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::Rfcomm::IRfcommServiceId **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRfcommServiceId**, int> get_GenericFileTransfer;
    }
}
