// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sms.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISmsFilterRuleFactory.xml' path='doc/member[@name="ISmsFilterRuleFactory"]/*' />
[Guid("00C36508-6296-4F29-9AAD-8920CEBA3CE8")]
[NativeTypeName("struct ISmsFilterRuleFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmsFilterRuleFactory : ISmsFilterRuleFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmsFilterRuleFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsFilterRuleFactory*, Guid*, void**, int>)(lpVtbl[0]))((ISmsFilterRuleFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsFilterRuleFactory*, uint>)(lpVtbl[1]))((ISmsFilterRuleFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsFilterRuleFactory*, uint>)(lpVtbl[2]))((ISmsFilterRuleFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsFilterRuleFactory*, uint*, Guid**, int>)(lpVtbl[3]))((ISmsFilterRuleFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsFilterRuleFactory*, HSTRING*, int>)(lpVtbl[4]))((ISmsFilterRuleFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsFilterRuleFactory*, TrustLevel*, int>)(lpVtbl[5]))((ISmsFilterRuleFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISmsFilterRuleFactory.xml' path='doc/member[@name="ISmsFilterRuleFactory.CreateFilterRule"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFilterRule([NativeTypeName("ABI::Windows::Devices::Sms::SmsMessageType")] SmsMessageType messageType, [NativeTypeName("ABI::Windows::Devices::Sms::ISmsFilterRule **")] ISmsFilterRule** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsFilterRuleFactory*, SmsMessageType, ISmsFilterRule**, int>)(lpVtbl[6]))((ISmsFilterRuleFactory*)Unsafe.AsPointer(ref this), messageType, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFilterRule([NativeTypeName("ABI::Windows::Devices::Sms::SmsMessageType")] SmsMessageType messageType, [NativeTypeName("ABI::Windows::Devices::Sms::ISmsFilterRule **")] ISmsFilterRule** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sms::SmsMessageType, ABI::Windows::Devices::Sms::ISmsFilterRule **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmsMessageType, ISmsFilterRule**, int> CreateFilterRule;
    }
}
