// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPhoneIncomingCallDismissedTriggerDetails.xml' path='doc/member[@name="IPhoneIncomingCallDismissedTriggerDetails"]/*' />
[Guid("BAD30276-83B6-5732-9C38-0C206546196A")]
[NativeTypeName("struct IPhoneIncomingCallDismissedTriggerDetails : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete("PhoneIncomingCallDismissedTriggerDetails is deprecated and might not work for all platforms. For more info, see MSDN.")]
public unsafe partial struct IPhoneIncomingCallDismissedTriggerDetails : IPhoneIncomingCallDismissedTriggerDetails.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IPhoneIncomingCallDismissedTriggerDetails);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneIncomingCallDismissedTriggerDetails*, Guid*, void**, int>)(lpVtbl[0]))((IPhoneIncomingCallDismissedTriggerDetails*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneIncomingCallDismissedTriggerDetails*, uint>)(lpVtbl[1]))((IPhoneIncomingCallDismissedTriggerDetails*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneIncomingCallDismissedTriggerDetails*, uint>)(lpVtbl[2]))((IPhoneIncomingCallDismissedTriggerDetails*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneIncomingCallDismissedTriggerDetails*, uint*, Guid**, int>)(lpVtbl[3]))((IPhoneIncomingCallDismissedTriggerDetails*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneIncomingCallDismissedTriggerDetails*, HSTRING*, int>)(lpVtbl[4]))((IPhoneIncomingCallDismissedTriggerDetails*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneIncomingCallDismissedTriggerDetails*, TrustLevel*, int>)(lpVtbl[5]))((IPhoneIncomingCallDismissedTriggerDetails*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPhoneIncomingCallDismissedTriggerDetails.xml' path='doc/member[@name="IPhoneIncomingCallDismissedTriggerDetails.get_LineId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("PhoneIncomingCallDismissedTriggerDetails is deprecated and might not work for all platforms. For more info, see MSDN.")]
    public HRESULT get_LineId(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneIncomingCallDismissedTriggerDetails*, Guid*, int>)(lpVtbl[6]))((IPhoneIncomingCallDismissedTriggerDetails*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneIncomingCallDismissedTriggerDetails.xml' path='doc/member[@name="IPhoneIncomingCallDismissedTriggerDetails.get_PhoneNumber"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete("PhoneIncomingCallDismissedTriggerDetails is deprecated and might not work for all platforms. For more info, see MSDN.")]
    public HRESULT get_PhoneNumber(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneIncomingCallDismissedTriggerDetails*, HSTRING*, int>)(lpVtbl[7]))((IPhoneIncomingCallDismissedTriggerDetails*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneIncomingCallDismissedTriggerDetails.xml' path='doc/member[@name="IPhoneIncomingCallDismissedTriggerDetails.get_DisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete("PhoneIncomingCallDismissedTriggerDetails is deprecated and might not work for all platforms. For more info, see MSDN.")]
    public HRESULT get_DisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneIncomingCallDismissedTriggerDetails*, HSTRING*, int>)(lpVtbl[8]))((IPhoneIncomingCallDismissedTriggerDetails*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneIncomingCallDismissedTriggerDetails.xml' path='doc/member[@name="IPhoneIncomingCallDismissedTriggerDetails.get_DismissalTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [Obsolete("PhoneIncomingCallDismissedTriggerDetails is deprecated and might not work for all platforms. For more info, see MSDN.")]
    public HRESULT get_DismissalTime([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneIncomingCallDismissedTriggerDetails*, WinRTDateTime*, int>)(lpVtbl[9]))((IPhoneIncomingCallDismissedTriggerDetails*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneIncomingCallDismissedTriggerDetails.xml' path='doc/member[@name="IPhoneIncomingCallDismissedTriggerDetails.get_TextReplyMessage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [Obsolete("PhoneIncomingCallDismissedTriggerDetails is deprecated and might not work for all platforms. For more info, see MSDN.")]
    public HRESULT get_TextReplyMessage(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneIncomingCallDismissedTriggerDetails*, HSTRING*, int>)(lpVtbl[10]))((IPhoneIncomingCallDismissedTriggerDetails*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneIncomingCallDismissedTriggerDetails.xml' path='doc/member[@name="IPhoneIncomingCallDismissedTriggerDetails.get_Reason"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [Obsolete("PhoneIncomingCallDismissedTriggerDetails is deprecated and might not work for all platforms. For more info, see MSDN.")]
    public HRESULT get_Reason([NativeTypeName("ABI::Windows::ApplicationModel::Calls::Background::PhoneIncomingCallDismissedReason *")] PhoneIncomingCallDismissedReason* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneIncomingCallDismissedTriggerDetails*, PhoneIncomingCallDismissedReason*, int>)(lpVtbl[11]))((IPhoneIncomingCallDismissedTriggerDetails*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("PhoneIncomingCallDismissedTriggerDetails is deprecated and might not work for all platforms. For more info, see MSDN.")]
        HRESULT get_LineId(Guid* value);

        [VtblIndex(7)]
        [Obsolete("PhoneIncomingCallDismissedTriggerDetails is deprecated and might not work for all platforms. For more info, see MSDN.")]
        HRESULT get_PhoneNumber(HSTRING* value);

        [VtblIndex(8)]
        [Obsolete("PhoneIncomingCallDismissedTriggerDetails is deprecated and might not work for all platforms. For more info, see MSDN.")]
        HRESULT get_DisplayName(HSTRING* value);

        [VtblIndex(9)]
        [Obsolete("PhoneIncomingCallDismissedTriggerDetails is deprecated and might not work for all platforms. For more info, see MSDN.")]
        HRESULT get_DismissalTime([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value);

        [VtblIndex(10)]
        [Obsolete("PhoneIncomingCallDismissedTriggerDetails is deprecated and might not work for all platforms. For more info, see MSDN.")]
        HRESULT get_TextReplyMessage(HSTRING* value);

        [VtblIndex(11)]
        [Obsolete("PhoneIncomingCallDismissedTriggerDetails is deprecated and might not work for all platforms. For more info, see MSDN.")]
        HRESULT get_Reason([NativeTypeName("ABI::Windows::ApplicationModel::Calls::Background::PhoneIncomingCallDismissedReason *")] PhoneIncomingCallDismissedReason* value);
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

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        [Obsolete("PhoneIncomingCallDismissedTriggerDetails is deprecated and might not work for all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_LineId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete("PhoneIncomingCallDismissedTriggerDetails is deprecated and might not work for all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_PhoneNumber;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete("PhoneIncomingCallDismissedTriggerDetails is deprecated and might not work for all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DisplayName;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        [Obsolete("PhoneIncomingCallDismissedTriggerDetails is deprecated and might not work for all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime*, int> get_DismissalTime;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete("PhoneIncomingCallDismissedTriggerDetails is deprecated and might not work for all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_TextReplyMessage;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::Background::PhoneIncomingCallDismissedReason *) __attribute__((stdcall))")]
        [Obsolete("PhoneIncomingCallDismissedTriggerDetails is deprecated and might not work for all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PhoneIncomingCallDismissedReason*, int> get_Reason;
    }
}
