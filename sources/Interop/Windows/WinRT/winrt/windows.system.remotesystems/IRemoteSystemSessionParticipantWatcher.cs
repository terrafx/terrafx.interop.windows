// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.remotesystems.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRemoteSystemSessionParticipantWatcher.xml' path='doc/member[@name="IRemoteSystemSessionParticipantWatcher"]/*' />
[Guid("DCDD02CC-AA87-4D79-B6CC-4459B3E92075")]
[NativeTypeName("struct IRemoteSystemSessionParticipantWatcher : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRemoteSystemSessionParticipantWatcher : IRemoteSystemSessionParticipantWatcher.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IRemoteSystemSessionParticipantWatcher);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionParticipantWatcher*, Guid*, void**, int>)(lpVtbl[0]))((IRemoteSystemSessionParticipantWatcher*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionParticipantWatcher*, uint>)(lpVtbl[1]))((IRemoteSystemSessionParticipantWatcher*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionParticipantWatcher*, uint>)(lpVtbl[2]))((IRemoteSystemSessionParticipantWatcher*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionParticipantWatcher*, uint*, Guid**, int>)(lpVtbl[3]))((IRemoteSystemSessionParticipantWatcher*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionParticipantWatcher*, HSTRING*, int>)(lpVtbl[4]))((IRemoteSystemSessionParticipantWatcher*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionParticipantWatcher*, TrustLevel*, int>)(lpVtbl[5]))((IRemoteSystemSessionParticipantWatcher*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IRemoteSystemSessionParticipantWatcher.xml' path='doc/member[@name="IRemoteSystemSessionParticipantWatcher.Start"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Start()
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionParticipantWatcher*, int>)(lpVtbl[6]))((IRemoteSystemSessionParticipantWatcher*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IRemoteSystemSessionParticipantWatcher.xml' path='doc/member[@name="IRemoteSystemSessionParticipantWatcher.Stop"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionParticipantWatcher*, int>)(lpVtbl[7]))((IRemoteSystemSessionParticipantWatcher*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IRemoteSystemSessionParticipantWatcher.xml' path='doc/member[@name="IRemoteSystemSessionParticipantWatcher.get_Status"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Status([NativeTypeName("ABI::Windows::System::RemoteSystems::RemoteSystemSessionParticipantWatcherStatus *")] RemoteSystemSessionParticipantWatcherStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionParticipantWatcher*, RemoteSystemSessionParticipantWatcherStatus*, int>)(lpVtbl[8]))((IRemoteSystemSessionParticipantWatcher*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRemoteSystemSessionParticipantWatcher.xml' path='doc/member[@name="IRemoteSystemSessionParticipantWatcher.add_Added"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT add_Added([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CRemoteSystems__CRemoteSystemSessionParticipantWatcher_Windows__CSystem__CRemoteSystems__CRemoteSystemSessionParticipantAddedEventArgs_t *")] ITypedEventHandler<Pointer<IRemoteSystemSessionParticipantWatcher>, Pointer<IRemoteSystemSessionParticipantAddedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionParticipantWatcher*, ITypedEventHandler<Pointer<IRemoteSystemSessionParticipantWatcher>, Pointer<IRemoteSystemSessionParticipantAddedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[9]))((IRemoteSystemSessionParticipantWatcher*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IRemoteSystemSessionParticipantWatcher.xml' path='doc/member[@name="IRemoteSystemSessionParticipantWatcher.remove_Added"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT remove_Added(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionParticipantWatcher*, EventRegistrationToken, int>)(lpVtbl[10]))((IRemoteSystemSessionParticipantWatcher*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IRemoteSystemSessionParticipantWatcher.xml' path='doc/member[@name="IRemoteSystemSessionParticipantWatcher.add_Removed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT add_Removed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CRemoteSystems__CRemoteSystemSessionParticipantWatcher_Windows__CSystem__CRemoteSystems__CRemoteSystemSessionParticipantRemovedEventArgs_t *")] ITypedEventHandler<Pointer<IRemoteSystemSessionParticipantWatcher>, Pointer<IRemoteSystemSessionParticipantRemovedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionParticipantWatcher*, ITypedEventHandler<Pointer<IRemoteSystemSessionParticipantWatcher>, Pointer<IRemoteSystemSessionParticipantRemovedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[11]))((IRemoteSystemSessionParticipantWatcher*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IRemoteSystemSessionParticipantWatcher.xml' path='doc/member[@name="IRemoteSystemSessionParticipantWatcher.remove_Removed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT remove_Removed(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionParticipantWatcher*, EventRegistrationToken, int>)(lpVtbl[12]))((IRemoteSystemSessionParticipantWatcher*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IRemoteSystemSessionParticipantWatcher.xml' path='doc/member[@name="IRemoteSystemSessionParticipantWatcher.add_EnumerationCompleted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT add_EnumerationCompleted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CRemoteSystems__CRemoteSystemSessionParticipantWatcher_IInspectable_t *")] ITypedEventHandler<Pointer<IRemoteSystemSessionParticipantWatcher>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionParticipantWatcher*, ITypedEventHandler<Pointer<IRemoteSystemSessionParticipantWatcher>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[13]))((IRemoteSystemSessionParticipantWatcher*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IRemoteSystemSessionParticipantWatcher.xml' path='doc/member[@name="IRemoteSystemSessionParticipantWatcher.remove_EnumerationCompleted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT remove_EnumerationCompleted(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionParticipantWatcher*, EventRegistrationToken, int>)(lpVtbl[14]))((IRemoteSystemSessionParticipantWatcher*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Start();

        [VtblIndex(7)]
        HRESULT Stop();

        [VtblIndex(8)]
        HRESULT get_Status([NativeTypeName("ABI::Windows::System::RemoteSystems::RemoteSystemSessionParticipantWatcherStatus *")] RemoteSystemSessionParticipantWatcherStatus* value);

        [VtblIndex(9)]
        HRESULT add_Added([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CRemoteSystems__CRemoteSystemSessionParticipantWatcher_Windows__CSystem__CRemoteSystems__CRemoteSystemSessionParticipantAddedEventArgs_t *")] ITypedEventHandler<Pointer<IRemoteSystemSessionParticipantWatcher>, Pointer<IRemoteSystemSessionParticipantAddedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(10)]
        HRESULT remove_Added(EventRegistrationToken token);

        [VtblIndex(11)]
        HRESULT add_Removed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CRemoteSystems__CRemoteSystemSessionParticipantWatcher_Windows__CSystem__CRemoteSystems__CRemoteSystemSessionParticipantRemovedEventArgs_t *")] ITypedEventHandler<Pointer<IRemoteSystemSessionParticipantWatcher>, Pointer<IRemoteSystemSessionParticipantRemovedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(12)]
        HRESULT remove_Removed(EventRegistrationToken token);

        [VtblIndex(13)]
        HRESULT add_EnumerationCompleted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CRemoteSystems__CRemoteSystemSessionParticipantWatcher_IInspectable_t *")] ITypedEventHandler<Pointer<IRemoteSystemSessionParticipantWatcher>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(14)]
        HRESULT remove_EnumerationCompleted(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Start;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Stop;

        [NativeTypeName("HRESULT (ABI::Windows::System::RemoteSystems::RemoteSystemSessionParticipantWatcherStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, RemoteSystemSessionParticipantWatcherStatus*, int> get_Status;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CRemoteSystems__CRemoteSystemSessionParticipantWatcher_Windows__CSystem__CRemoteSystems__CRemoteSystemSessionParticipantAddedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IRemoteSystemSessionParticipantWatcher>, Pointer<IRemoteSystemSessionParticipantAddedEventArgs>>*, EventRegistrationToken*, int> add_Added;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Added;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CRemoteSystems__CRemoteSystemSessionParticipantWatcher_Windows__CSystem__CRemoteSystems__CRemoteSystemSessionParticipantRemovedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IRemoteSystemSessionParticipantWatcher>, Pointer<IRemoteSystemSessionParticipantRemovedEventArgs>>*, EventRegistrationToken*, int> add_Removed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Removed;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CRemoteSystems__CRemoteSystemSessionParticipantWatcher_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IRemoteSystemSessionParticipantWatcher>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_EnumerationCompleted;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_EnumerationCompleted;
    }
}
