// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.remotesystems.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRemoteSystemWatcher.xml' path='doc/member[@name="IRemoteSystemWatcher"]/*' />
[Guid("5D600C7E-2C07-48C5-889C-455D2B099771")]
[NativeTypeName("struct IRemoteSystemWatcher : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRemoteSystemWatcher : IRemoteSystemWatcher.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IRemoteSystemWatcher);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemWatcher*, Guid*, void**, int>)(lpVtbl[0]))((IRemoteSystemWatcher*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemWatcher*, uint>)(lpVtbl[1]))((IRemoteSystemWatcher*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemWatcher*, uint>)(lpVtbl[2]))((IRemoteSystemWatcher*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemWatcher*, uint*, Guid**, int>)(lpVtbl[3]))((IRemoteSystemWatcher*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemWatcher*, HSTRING*, int>)(lpVtbl[4]))((IRemoteSystemWatcher*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemWatcher*, TrustLevel*, int>)(lpVtbl[5]))((IRemoteSystemWatcher*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IRemoteSystemWatcher.xml' path='doc/member[@name="IRemoteSystemWatcher.Start"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Start()
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemWatcher*, int>)(lpVtbl[6]))((IRemoteSystemWatcher*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IRemoteSystemWatcher.xml' path='doc/member[@name="IRemoteSystemWatcher.Stop"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemWatcher*, int>)(lpVtbl[7]))((IRemoteSystemWatcher*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IRemoteSystemWatcher.xml' path='doc/member[@name="IRemoteSystemWatcher.add_RemoteSystemAdded"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_RemoteSystemAdded([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CRemoteSystems__CRemoteSystemWatcher_Windows__CSystem__CRemoteSystems__CRemoteSystemAddedEventArgs_t *")] ITypedEventHandler<Pointer<IRemoteSystemWatcher>, Pointer<IRemoteSystemAddedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemWatcher*, ITypedEventHandler<Pointer<IRemoteSystemWatcher>, Pointer<IRemoteSystemAddedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[8]))((IRemoteSystemWatcher*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IRemoteSystemWatcher.xml' path='doc/member[@name="IRemoteSystemWatcher.remove_RemoteSystemAdded"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_RemoteSystemAdded(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemWatcher*, EventRegistrationToken, int>)(lpVtbl[9]))((IRemoteSystemWatcher*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IRemoteSystemWatcher.xml' path='doc/member[@name="IRemoteSystemWatcher.add_RemoteSystemUpdated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_RemoteSystemUpdated([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CRemoteSystems__CRemoteSystemWatcher_Windows__CSystem__CRemoteSystems__CRemoteSystemUpdatedEventArgs_t *")] ITypedEventHandler<Pointer<IRemoteSystemWatcher>, Pointer<IRemoteSystemUpdatedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemWatcher*, ITypedEventHandler<Pointer<IRemoteSystemWatcher>, Pointer<IRemoteSystemUpdatedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[10]))((IRemoteSystemWatcher*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IRemoteSystemWatcher.xml' path='doc/member[@name="IRemoteSystemWatcher.remove_RemoteSystemUpdated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_RemoteSystemUpdated(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemWatcher*, EventRegistrationToken, int>)(lpVtbl[11]))((IRemoteSystemWatcher*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IRemoteSystemWatcher.xml' path='doc/member[@name="IRemoteSystemWatcher.add_RemoteSystemRemoved"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT add_RemoteSystemRemoved([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CRemoteSystems__CRemoteSystemWatcher_Windows__CSystem__CRemoteSystems__CRemoteSystemRemovedEventArgs_t *")] ITypedEventHandler<Pointer<IRemoteSystemWatcher>, Pointer<IRemoteSystemRemovedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemWatcher*, ITypedEventHandler<Pointer<IRemoteSystemWatcher>, Pointer<IRemoteSystemRemovedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[12]))((IRemoteSystemWatcher*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IRemoteSystemWatcher.xml' path='doc/member[@name="IRemoteSystemWatcher.remove_RemoteSystemRemoved"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT remove_RemoteSystemRemoved(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemWatcher*, EventRegistrationToken, int>)(lpVtbl[13]))((IRemoteSystemWatcher*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Start();

        [VtblIndex(7)]
        HRESULT Stop();

        [VtblIndex(8)]
        HRESULT add_RemoteSystemAdded([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CRemoteSystems__CRemoteSystemWatcher_Windows__CSystem__CRemoteSystems__CRemoteSystemAddedEventArgs_t *")] ITypedEventHandler<Pointer<IRemoteSystemWatcher>, Pointer<IRemoteSystemAddedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(9)]
        HRESULT remove_RemoteSystemAdded(EventRegistrationToken token);

        [VtblIndex(10)]
        HRESULT add_RemoteSystemUpdated([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CRemoteSystems__CRemoteSystemWatcher_Windows__CSystem__CRemoteSystems__CRemoteSystemUpdatedEventArgs_t *")] ITypedEventHandler<Pointer<IRemoteSystemWatcher>, Pointer<IRemoteSystemUpdatedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(11)]
        HRESULT remove_RemoteSystemUpdated(EventRegistrationToken token);

        [VtblIndex(12)]
        HRESULT add_RemoteSystemRemoved([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CRemoteSystems__CRemoteSystemWatcher_Windows__CSystem__CRemoteSystems__CRemoteSystemRemovedEventArgs_t *")] ITypedEventHandler<Pointer<IRemoteSystemWatcher>, Pointer<IRemoteSystemRemovedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(13)]
        HRESULT remove_RemoteSystemRemoved(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CRemoteSystems__CRemoteSystemWatcher_Windows__CSystem__CRemoteSystems__CRemoteSystemAddedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IRemoteSystemWatcher>, Pointer<IRemoteSystemAddedEventArgs>>*, EventRegistrationToken*, int> add_RemoteSystemAdded;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_RemoteSystemAdded;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CRemoteSystems__CRemoteSystemWatcher_Windows__CSystem__CRemoteSystems__CRemoteSystemUpdatedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IRemoteSystemWatcher>, Pointer<IRemoteSystemUpdatedEventArgs>>*, EventRegistrationToken*, int> add_RemoteSystemUpdated;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_RemoteSystemUpdated;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CRemoteSystems__CRemoteSystemWatcher_Windows__CSystem__CRemoteSystems__CRemoteSystemRemovedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IRemoteSystemWatcher>, Pointer<IRemoteSystemRemovedEventArgs>>*, EventRegistrationToken*, int> add_RemoteSystemRemoved;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_RemoteSystemRemoved;
    }
}
