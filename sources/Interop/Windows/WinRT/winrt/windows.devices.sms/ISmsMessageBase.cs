// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sms.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISmsMessageBase.xml' path='doc/member[@name="ISmsMessageBase"]/*' />
[Guid("2CF0FE30-FE50-4FC6-AA88-4CCFE27A29EA")]
[NativeTypeName("struct ISmsMessageBase : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmsMessageBase : ISmsMessageBase.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmsMessageBase));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsMessageBase*, Guid*, void**, int>)(lpVtbl[0]))((ISmsMessageBase*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsMessageBase*, uint>)(lpVtbl[1]))((ISmsMessageBase*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsMessageBase*, uint>)(lpVtbl[2]))((ISmsMessageBase*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsMessageBase*, uint*, Guid**, int>)(lpVtbl[3]))((ISmsMessageBase*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsMessageBase*, HSTRING*, int>)(lpVtbl[4]))((ISmsMessageBase*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsMessageBase*, TrustLevel*, int>)(lpVtbl[5]))((ISmsMessageBase*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISmsMessageBase.xml' path='doc/member[@name="ISmsMessageBase.get_MessageType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_MessageType([NativeTypeName("ABI::Windows::Devices::Sms::SmsMessageType *")] SmsMessageType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsMessageBase*, SmsMessageType*, int>)(lpVtbl[6]))((ISmsMessageBase*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsMessageBase.xml' path='doc/member[@name="ISmsMessageBase.get_DeviceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_DeviceId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsMessageBase*, HSTRING*, int>)(lpVtbl[7]))((ISmsMessageBase*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsMessageBase.xml' path='doc/member[@name="ISmsMessageBase.get_CellularClass"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_CellularClass([NativeTypeName("ABI::Windows::Devices::Sms::CellularClass *")] CellularClass* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsMessageBase*, CellularClass*, int>)(lpVtbl[8]))((ISmsMessageBase*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsMessageBase.xml' path='doc/member[@name="ISmsMessageBase.get_MessageClass"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_MessageClass([NativeTypeName("ABI::Windows::Devices::Sms::SmsMessageClass *")] SmsMessageClass* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsMessageBase*, SmsMessageClass*, int>)(lpVtbl[9]))((ISmsMessageBase*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsMessageBase.xml' path='doc/member[@name="ISmsMessageBase.get_SimIccId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_SimIccId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsMessageBase*, HSTRING*, int>)(lpVtbl[10]))((ISmsMessageBase*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_MessageType([NativeTypeName("ABI::Windows::Devices::Sms::SmsMessageType *")] SmsMessageType* value);

        [VtblIndex(7)]
        HRESULT get_DeviceId(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_CellularClass([NativeTypeName("ABI::Windows::Devices::Sms::CellularClass *")] CellularClass* value);

        [VtblIndex(9)]
        HRESULT get_MessageClass([NativeTypeName("ABI::Windows::Devices::Sms::SmsMessageClass *")] SmsMessageClass* value);

        [VtblIndex(10)]
        HRESULT get_SimIccId(HSTRING* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sms::SmsMessageType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmsMessageType*, int> get_MessageType;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DeviceId;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sms::CellularClass *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CellularClass*, int> get_CellularClass;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sms::SmsMessageClass *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmsMessageClass*, int> get_MessageClass;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SimIccId;
    }
}
