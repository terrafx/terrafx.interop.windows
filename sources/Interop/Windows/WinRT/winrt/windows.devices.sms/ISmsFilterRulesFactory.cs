// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sms.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISmsFilterRulesFactory.xml' path='doc/member[@name="ISmsFilterRulesFactory"]/*' />
[Guid("A09924ED-6E2E-4530-9FDE-465D02EED00E")]
[NativeTypeName("struct ISmsFilterRulesFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmsFilterRulesFactory : ISmsFilterRulesFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmsFilterRulesFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsFilterRulesFactory*, Guid*, void**, int>)(lpVtbl[0]))((ISmsFilterRulesFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsFilterRulesFactory*, uint>)(lpVtbl[1]))((ISmsFilterRulesFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsFilterRulesFactory*, uint>)(lpVtbl[2]))((ISmsFilterRulesFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsFilterRulesFactory*, uint*, Guid**, int>)(lpVtbl[3]))((ISmsFilterRulesFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsFilterRulesFactory*, HSTRING*, int>)(lpVtbl[4]))((ISmsFilterRulesFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsFilterRulesFactory*, TrustLevel*, int>)(lpVtbl[5]))((ISmsFilterRulesFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISmsFilterRulesFactory.xml' path='doc/member[@name="ISmsFilterRulesFactory.CreateFilterRules"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFilterRules([NativeTypeName("ABI::Windows::Devices::Sms::SmsFilterActionType")] SmsFilterActionType actionType, [NativeTypeName("ABI::Windows::Devices::Sms::ISmsFilterRules **")] ISmsFilterRules** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsFilterRulesFactory*, SmsFilterActionType, ISmsFilterRules**, int>)(lpVtbl[6]))((ISmsFilterRulesFactory*)Unsafe.AsPointer(ref this), actionType, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFilterRules([NativeTypeName("ABI::Windows::Devices::Sms::SmsFilterActionType")] SmsFilterActionType actionType, [NativeTypeName("ABI::Windows::Devices::Sms::ISmsFilterRules **")] ISmsFilterRules** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sms::SmsFilterActionType, ABI::Windows::Devices::Sms::ISmsFilterRules **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmsFilterActionType, ISmsFilterRules**, int> CreateFilterRules;
    }
}
