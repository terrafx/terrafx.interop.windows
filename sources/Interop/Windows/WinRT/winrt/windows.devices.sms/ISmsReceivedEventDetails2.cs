// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sms.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISmsReceivedEventDetails2.xml' path='doc/member[@name="ISmsReceivedEventDetails2"]/*' />
[Guid("40E05C86-A7B4-4771-9AE7-0B5FFB12C03A")]
[NativeTypeName("struct ISmsReceivedEventDetails2 : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete("SmsReceivedEventDetails may be altered or unavailable for releases after Windows 10. Instead, use SmsMessageReceivedTriggerDetails.")]
public unsafe partial struct ISmsReceivedEventDetails2 : ISmsReceivedEventDetails2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmsReceivedEventDetails2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsReceivedEventDetails2*, Guid*, void**, int>)(lpVtbl[0]))((ISmsReceivedEventDetails2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsReceivedEventDetails2*, uint>)(lpVtbl[1]))((ISmsReceivedEventDetails2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsReceivedEventDetails2*, uint>)(lpVtbl[2]))((ISmsReceivedEventDetails2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsReceivedEventDetails2*, uint*, Guid**, int>)(lpVtbl[3]))((ISmsReceivedEventDetails2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsReceivedEventDetails2*, HSTRING*, int>)(lpVtbl[4]))((ISmsReceivedEventDetails2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsReceivedEventDetails2*, TrustLevel*, int>)(lpVtbl[5]))((ISmsReceivedEventDetails2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISmsReceivedEventDetails2.xml' path='doc/member[@name="ISmsReceivedEventDetails2.get_MessageClass"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("SmsReceivedEventDetails may be altered or unavailable for releases after Windows 10. Instead, use SmsMessageReceivedTriggerDetails.")]
    public HRESULT get_MessageClass([NativeTypeName("ABI::Windows::Devices::Sms::SmsMessageClass *")] SmsMessageClass* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsReceivedEventDetails2*, SmsMessageClass*, int>)(lpVtbl[6]))((ISmsReceivedEventDetails2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsReceivedEventDetails2.xml' path='doc/member[@name="ISmsReceivedEventDetails2.get_BinaryMessage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete("SmsReceivedEventDetails may be altered or unavailable for releases after Windows 10. Instead, use SmsMessageReceivedTriggerDetails.")]
    public HRESULT get_BinaryMessage([NativeTypeName("ABI::Windows::Devices::Sms::ISmsBinaryMessage **")] ISmsBinaryMessage** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsReceivedEventDetails2*, ISmsBinaryMessage**, int>)(lpVtbl[7]))((ISmsReceivedEventDetails2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("SmsReceivedEventDetails may be altered or unavailable for releases after Windows 10. Instead, use SmsMessageReceivedTriggerDetails.")]
        HRESULT get_MessageClass([NativeTypeName("ABI::Windows::Devices::Sms::SmsMessageClass *")] SmsMessageClass* value);

        [VtblIndex(7)]
        [Obsolete("SmsReceivedEventDetails may be altered or unavailable for releases after Windows 10. Instead, use SmsMessageReceivedTriggerDetails.")]
        HRESULT get_BinaryMessage([NativeTypeName("ABI::Windows::Devices::Sms::ISmsBinaryMessage **")] ISmsBinaryMessage** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sms::SmsMessageClass *) __attribute__((stdcall))")]
        [Obsolete("SmsReceivedEventDetails may be altered or unavailable for releases after Windows 10. Instead, use SmsMessageReceivedTriggerDetails.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmsMessageClass*, int> get_MessageClass;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sms::ISmsBinaryMessage **) __attribute__((stdcall))")]
        [Obsolete("SmsReceivedEventDetails may be altered or unavailable for releases after Windows 10. Instead, use SmsMessageReceivedTriggerDetails.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISmsBinaryMessage**, int> get_BinaryMessage;
    }
}
