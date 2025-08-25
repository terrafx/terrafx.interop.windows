// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.sockets.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IControlChannelTriggerResetEventDetails.xml' path='doc/member[@name="IControlChannelTriggerResetEventDetails"]/*' />
[Guid("6851038E-8EC4-42FE-9BB2-21E91B7BFCB1")]
[NativeTypeName("struct IControlChannelTriggerResetEventDetails : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IControlChannelTriggerResetEventDetails : IControlChannelTriggerResetEventDetails.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IControlChannelTriggerResetEventDetails);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IControlChannelTriggerResetEventDetails*, Guid*, void**, int>)(lpVtbl[0]))((IControlChannelTriggerResetEventDetails*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IControlChannelTriggerResetEventDetails*, uint>)(lpVtbl[1]))((IControlChannelTriggerResetEventDetails*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IControlChannelTriggerResetEventDetails*, uint>)(lpVtbl[2]))((IControlChannelTriggerResetEventDetails*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IControlChannelTriggerResetEventDetails*, uint*, Guid**, int>)(lpVtbl[3]))((IControlChannelTriggerResetEventDetails*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IControlChannelTriggerResetEventDetails*, HSTRING*, int>)(lpVtbl[4]))((IControlChannelTriggerResetEventDetails*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IControlChannelTriggerResetEventDetails*, TrustLevel*, int>)(lpVtbl[5]))((IControlChannelTriggerResetEventDetails*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IControlChannelTriggerResetEventDetails.xml' path='doc/member[@name="IControlChannelTriggerResetEventDetails.get_ResetReason"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ResetReason([NativeTypeName("ABI::Windows::Networking::Sockets::ControlChannelTriggerResetReason *")] ControlChannelTriggerResetReason* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IControlChannelTriggerResetEventDetails*, ControlChannelTriggerResetReason*, int>)(lpVtbl[6]))((IControlChannelTriggerResetEventDetails*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IControlChannelTriggerResetEventDetails.xml' path='doc/member[@name="IControlChannelTriggerResetEventDetails.get_HardwareSlotReset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_HardwareSlotReset([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IControlChannelTriggerResetEventDetails*, byte*, int>)(lpVtbl[7]))((IControlChannelTriggerResetEventDetails*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IControlChannelTriggerResetEventDetails.xml' path='doc/member[@name="IControlChannelTriggerResetEventDetails.get_SoftwareSlotReset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SoftwareSlotReset([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IControlChannelTriggerResetEventDetails*, byte*, int>)(lpVtbl[8]))((IControlChannelTriggerResetEventDetails*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ResetReason([NativeTypeName("ABI::Windows::Networking::Sockets::ControlChannelTriggerResetReason *")] ControlChannelTriggerResetReason* value);

        [VtblIndex(7)]
        HRESULT get_HardwareSlotReset([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT get_SoftwareSlotReset([NativeTypeName("boolean *")] byte* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Networking::Sockets::ControlChannelTriggerResetReason *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ControlChannelTriggerResetReason*, int> get_ResetReason;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_HardwareSlotReset;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_SoftwareSlotReset;
    }
}
