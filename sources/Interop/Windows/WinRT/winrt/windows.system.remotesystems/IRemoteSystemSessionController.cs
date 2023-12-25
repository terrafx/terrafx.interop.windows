// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.remotesystems.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRemoteSystemSessionController.xml' path='doc/member[@name="IRemoteSystemSessionController"]/*' />
[Guid("E48B2DD2-6820-4867-B425-D89C0A3EF7BA")]
[NativeTypeName("struct IRemoteSystemSessionController : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRemoteSystemSessionController : IRemoteSystemSessionController.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRemoteSystemSessionController));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionController*, Guid*, void**, int>)(lpVtbl[0]))((IRemoteSystemSessionController*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionController*, uint>)(lpVtbl[1]))((IRemoteSystemSessionController*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionController*, uint>)(lpVtbl[2]))((IRemoteSystemSessionController*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionController*, uint*, Guid**, int>)(lpVtbl[3]))((IRemoteSystemSessionController*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionController*, HSTRING*, int>)(lpVtbl[4]))((IRemoteSystemSessionController*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionController*, TrustLevel*, int>)(lpVtbl[5]))((IRemoteSystemSessionController*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IRemoteSystemSessionController.xml' path='doc/member[@name="IRemoteSystemSessionController.add_JoinRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_JoinRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CRemoteSystems__CRemoteSystemSessionController_Windows__CSystem__CRemoteSystems__CRemoteSystemSessionJoinRequestedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionController*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IRemoteSystemSessionController*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IRemoteSystemSessionController.xml' path='doc/member[@name="IRemoteSystemSessionController.remove_JoinRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_JoinRequested(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionController*, EventRegistrationToken, int>)(lpVtbl[7]))((IRemoteSystemSessionController*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IRemoteSystemSessionController.xml' path='doc/member[@name="IRemoteSystemSessionController.RemoveParticipantAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RemoveParticipantAsync([NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemSessionParticipant *")] IRemoteSystemSessionParticipant* pParticipant, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionController*, IRemoteSystemSessionParticipant*, IAsyncOperation<bool>**, int>)(lpVtbl[8]))((IRemoteSystemSessionController*)Unsafe.AsPointer(ref this), pParticipant, operation);
    }

    /// <include file='IRemoteSystemSessionController.xml' path='doc/member[@name="IRemoteSystemSessionController.CreateSessionAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateSessionAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CRemoteSystems__CRemoteSystemSessionCreationResult_t **")] IAsyncOperation<IntPtr>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionController*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[9]))((IRemoteSystemSessionController*)Unsafe.AsPointer(ref this), operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_JoinRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CRemoteSystems__CRemoteSystemSessionController_Windows__CSystem__CRemoteSystems__CRemoteSystemSessionJoinRequestedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_JoinRequested(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT RemoveParticipantAsync([NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemSessionParticipant *")] IRemoteSystemSessionParticipant* pParticipant, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation);

        [VtblIndex(9)]
        HRESULT CreateSessionAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CRemoteSystems__CRemoteSystemSessionCreationResult_t **")] IAsyncOperation<IntPtr>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CRemoteSystems__CRemoteSystemSessionController_Windows__CSystem__CRemoteSystems__CRemoteSystemSessionJoinRequestedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_JoinRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_JoinRequested;

        [NativeTypeName("HRESULT (ABI::Windows::System::RemoteSystems::IRemoteSystemSessionParticipant *, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRemoteSystemSessionParticipant*, IAsyncOperation<bool>**, int> RemoveParticipantAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CRemoteSystems__CRemoteSystemSessionCreationResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<IntPtr>**, int> CreateSessionAsync;
    }
}
