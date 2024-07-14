// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.remotesystems.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRemoteSystemWatcher2.xml' path='doc/member[@name="IRemoteSystemWatcher2"]/*' />
[Guid("73436700-19CA-48F9-A4CD-780F7AD58C71")]
[NativeTypeName("struct IRemoteSystemWatcher2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRemoteSystemWatcher2 : IRemoteSystemWatcher2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRemoteSystemWatcher2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemWatcher2*, Guid*, void**, int>)(lpVtbl[0]))((IRemoteSystemWatcher2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemWatcher2*, uint>)(lpVtbl[1]))((IRemoteSystemWatcher2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemWatcher2*, uint>)(lpVtbl[2]))((IRemoteSystemWatcher2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemWatcher2*, uint*, Guid**, int>)(lpVtbl[3]))((IRemoteSystemWatcher2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemWatcher2*, HSTRING*, int>)(lpVtbl[4]))((IRemoteSystemWatcher2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemWatcher2*, TrustLevel*, int>)(lpVtbl[5]))((IRemoteSystemWatcher2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IRemoteSystemWatcher2.xml' path='doc/member[@name="IRemoteSystemWatcher2.add_EnumerationCompleted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_EnumerationCompleted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CRemoteSystems__CRemoteSystemWatcher_Windows__CSystem__CRemoteSystems__CRemoteSystemEnumerationCompletedEventArgs_t *")] ITypedEventHandler<Pointer<IRemoteSystemWatcher>, Pointer<IRemoteSystemEnumerationCompletedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemWatcher2*, ITypedEventHandler<Pointer<IRemoteSystemWatcher>, Pointer<IRemoteSystemEnumerationCompletedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IRemoteSystemWatcher2*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IRemoteSystemWatcher2.xml' path='doc/member[@name="IRemoteSystemWatcher2.remove_EnumerationCompleted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_EnumerationCompleted(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemWatcher2*, EventRegistrationToken, int>)(lpVtbl[7]))((IRemoteSystemWatcher2*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IRemoteSystemWatcher2.xml' path='doc/member[@name="IRemoteSystemWatcher2.add_ErrorOccurred"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_ErrorOccurred([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CRemoteSystems__CRemoteSystemWatcher_Windows__CSystem__CRemoteSystems__CRemoteSystemWatcherErrorOccurredEventArgs_t *")] ITypedEventHandler<Pointer<IRemoteSystemWatcher>, Pointer<IRemoteSystemWatcherErrorOccurredEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemWatcher2*, ITypedEventHandler<Pointer<IRemoteSystemWatcher>, Pointer<IRemoteSystemWatcherErrorOccurredEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[8]))((IRemoteSystemWatcher2*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IRemoteSystemWatcher2.xml' path='doc/member[@name="IRemoteSystemWatcher2.remove_ErrorOccurred"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_ErrorOccurred(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemWatcher2*, EventRegistrationToken, int>)(lpVtbl[9]))((IRemoteSystemWatcher2*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_EnumerationCompleted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CRemoteSystems__CRemoteSystemWatcher_Windows__CSystem__CRemoteSystems__CRemoteSystemEnumerationCompletedEventArgs_t *")] ITypedEventHandler<Pointer<IRemoteSystemWatcher>, Pointer<IRemoteSystemEnumerationCompletedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_EnumerationCompleted(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT add_ErrorOccurred([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CRemoteSystems__CRemoteSystemWatcher_Windows__CSystem__CRemoteSystems__CRemoteSystemWatcherErrorOccurredEventArgs_t *")] ITypedEventHandler<Pointer<IRemoteSystemWatcher>, Pointer<IRemoteSystemWatcherErrorOccurredEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(9)]
        HRESULT remove_ErrorOccurred(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CRemoteSystems__CRemoteSystemWatcher_Windows__CSystem__CRemoteSystems__CRemoteSystemEnumerationCompletedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IRemoteSystemWatcher>, Pointer<IRemoteSystemEnumerationCompletedEventArgs>>*, EventRegistrationToken*, int> add_EnumerationCompleted;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_EnumerationCompleted;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CRemoteSystems__CRemoteSystemWatcher_Windows__CSystem__CRemoteSystems__CRemoteSystemWatcherErrorOccurredEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IRemoteSystemWatcher>, Pointer<IRemoteSystemWatcherErrorOccurredEventArgs>>*, EventRegistrationToken*, int> add_ErrorOccurred;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ErrorOccurred;
    }
}
