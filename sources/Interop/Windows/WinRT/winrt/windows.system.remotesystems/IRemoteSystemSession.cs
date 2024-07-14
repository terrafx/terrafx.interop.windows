// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.remotesystems.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRemoteSystemSession.xml' path='doc/member[@name="IRemoteSystemSession"]/*' />
[Guid("69476A01-9ADA-490F-9549-D31CB14C9E95")]
[NativeTypeName("struct IRemoteSystemSession : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRemoteSystemSession : IRemoteSystemSession.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRemoteSystemSession));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSession*, Guid*, void**, int>)(lpVtbl[0]))((IRemoteSystemSession*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSession*, uint>)(lpVtbl[1]))((IRemoteSystemSession*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSession*, uint>)(lpVtbl[2]))((IRemoteSystemSession*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSession*, uint*, Guid**, int>)(lpVtbl[3]))((IRemoteSystemSession*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSession*, HSTRING*, int>)(lpVtbl[4]))((IRemoteSystemSession*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSession*, TrustLevel*, int>)(lpVtbl[5]))((IRemoteSystemSession*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IRemoteSystemSession.xml' path='doc/member[@name="IRemoteSystemSession.get_Id"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Id(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSession*, HSTRING*, int>)(lpVtbl[6]))((IRemoteSystemSession*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRemoteSystemSession.xml' path='doc/member[@name="IRemoteSystemSession.get_DisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_DisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSession*, HSTRING*, int>)(lpVtbl[7]))((IRemoteSystemSession*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRemoteSystemSession.xml' path='doc/member[@name="IRemoteSystemSession.get_ControllerDisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ControllerDisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSession*, HSTRING*, int>)(lpVtbl[8]))((IRemoteSystemSession*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRemoteSystemSession.xml' path='doc/member[@name="IRemoteSystemSession.add_Disconnected"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT add_Disconnected([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CRemoteSystems__CRemoteSystemSession_Windows__CSystem__CRemoteSystems__CRemoteSystemSessionDisconnectedEventArgs_t *")] ITypedEventHandler<Pointer<IRemoteSystemSession>, Pointer<IRemoteSystemSessionDisconnectedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSession*, ITypedEventHandler<Pointer<IRemoteSystemSession>, Pointer<IRemoteSystemSessionDisconnectedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[9]))((IRemoteSystemSession*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IRemoteSystemSession.xml' path='doc/member[@name="IRemoteSystemSession.remove_Disconnected"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT remove_Disconnected(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSession*, EventRegistrationToken, int>)(lpVtbl[10]))((IRemoteSystemSession*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IRemoteSystemSession.xml' path='doc/member[@name="IRemoteSystemSession.CreateParticipantWatcher"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateParticipantWatcher([NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemSessionParticipantWatcher **")] IRemoteSystemSessionParticipantWatcher** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSession*, IRemoteSystemSessionParticipantWatcher**, int>)(lpVtbl[11]))((IRemoteSystemSession*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IRemoteSystemSession.xml' path='doc/member[@name="IRemoteSystemSession.SendInvitationAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SendInvitationAsync([NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystem *")] IRemoteSystem* invitee, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSession*, IRemoteSystem*, IAsyncOperation<bool>**, int>)(lpVtbl[12]))((IRemoteSystemSession*)Unsafe.AsPointer(ref this), invitee, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Id(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_DisplayName(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_ControllerDisplayName(HSTRING* value);

        [VtblIndex(9)]
        HRESULT add_Disconnected([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CRemoteSystems__CRemoteSystemSession_Windows__CSystem__CRemoteSystems__CRemoteSystemSessionDisconnectedEventArgs_t *")] ITypedEventHandler<Pointer<IRemoteSystemSession>, Pointer<IRemoteSystemSessionDisconnectedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(10)]
        HRESULT remove_Disconnected(EventRegistrationToken token);

        [VtblIndex(11)]
        HRESULT CreateParticipantWatcher([NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemSessionParticipantWatcher **")] IRemoteSystemSessionParticipantWatcher** result);

        [VtblIndex(12)]
        HRESULT SendInvitationAsync([NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystem *")] IRemoteSystem* invitee, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Id;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DisplayName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ControllerDisplayName;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CRemoteSystems__CRemoteSystemSession_Windows__CSystem__CRemoteSystems__CRemoteSystemSessionDisconnectedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IRemoteSystemSession>, Pointer<IRemoteSystemSessionDisconnectedEventArgs>>*, EventRegistrationToken*, int> add_Disconnected;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Disconnected;

        [NativeTypeName("HRESULT (ABI::Windows::System::RemoteSystems::IRemoteSystemSessionParticipantWatcher **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRemoteSystemSessionParticipantWatcher**, int> CreateParticipantWatcher;

        [NativeTypeName("HRESULT (ABI::Windows::System::RemoteSystems::IRemoteSystem *, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRemoteSystem*, IAsyncOperation<bool>**, int> SendInvitationAsync;
    }
}
