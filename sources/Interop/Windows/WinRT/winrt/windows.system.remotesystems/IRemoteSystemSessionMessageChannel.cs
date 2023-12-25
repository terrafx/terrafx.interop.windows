// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.remotesystems.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRemoteSystemSessionMessageChannel.xml' path='doc/member[@name="IRemoteSystemSessionMessageChannel"]/*' />
[Guid("9524D12A-73D9-4C10-B751-C26784437127")]
[NativeTypeName("struct IRemoteSystemSessionMessageChannel : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRemoteSystemSessionMessageChannel : IRemoteSystemSessionMessageChannel.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRemoteSystemSessionMessageChannel));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionMessageChannel*, Guid*, void**, int>)(lpVtbl[0]))((IRemoteSystemSessionMessageChannel*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionMessageChannel*, uint>)(lpVtbl[1]))((IRemoteSystemSessionMessageChannel*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionMessageChannel*, uint>)(lpVtbl[2]))((IRemoteSystemSessionMessageChannel*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionMessageChannel*, uint*, Guid**, int>)(lpVtbl[3]))((IRemoteSystemSessionMessageChannel*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionMessageChannel*, HSTRING*, int>)(lpVtbl[4]))((IRemoteSystemSessionMessageChannel*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionMessageChannel*, TrustLevel*, int>)(lpVtbl[5]))((IRemoteSystemSessionMessageChannel*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IRemoteSystemSessionMessageChannel.xml' path='doc/member[@name="IRemoteSystemSessionMessageChannel.get_Session"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Session([NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemSession **")] IRemoteSystemSession** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionMessageChannel*, IRemoteSystemSession**, int>)(lpVtbl[6]))((IRemoteSystemSessionMessageChannel*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRemoteSystemSessionMessageChannel.xml' path='doc/member[@name="IRemoteSystemSessionMessageChannel.BroadcastValueSetAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT BroadcastValueSetAsync([NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* messageData, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionMessageChannel*, IPropertySet*, IAsyncOperation<bool>**, int>)(lpVtbl[7]))((IRemoteSystemSessionMessageChannel*)Unsafe.AsPointer(ref this), messageData, operation);
    }

    /// <include file='IRemoteSystemSessionMessageChannel.xml' path='doc/member[@name="IRemoteSystemSessionMessageChannel.SendValueSetAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SendValueSetAsync([NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* messageData, [NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemSessionParticipant *")] IRemoteSystemSessionParticipant* participant, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionMessageChannel*, IPropertySet*, IRemoteSystemSessionParticipant*, IAsyncOperation<bool>**, int>)(lpVtbl[8]))((IRemoteSystemSessionMessageChannel*)Unsafe.AsPointer(ref this), messageData, participant, operation);
    }

    /// <include file='IRemoteSystemSessionMessageChannel.xml' path='doc/member[@name="IRemoteSystemSessionMessageChannel.SendValueSetToParticipantsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SendValueSetToParticipantsAsync([NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* messageData, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CSystem__CRemoteSystems__CRemoteSystemSessionParticipant_t *")] IIterable<IntPtr>* participants, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionMessageChannel*, IPropertySet*, IIterable<IntPtr>*, IAsyncOperation<bool>**, int>)(lpVtbl[9]))((IRemoteSystemSessionMessageChannel*)Unsafe.AsPointer(ref this), messageData, participants, operation);
    }

    /// <include file='IRemoteSystemSessionMessageChannel.xml' path='doc/member[@name="IRemoteSystemSessionMessageChannel.add_ValueSetReceived"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_ValueSetReceived([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CRemoteSystems__CRemoteSystemSessionMessageChannel_Windows__CSystem__CRemoteSystems__CRemoteSystemSessionValueSetReceivedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionMessageChannel*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[10]))((IRemoteSystemSessionMessageChannel*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IRemoteSystemSessionMessageChannel.xml' path='doc/member[@name="IRemoteSystemSessionMessageChannel.remove_ValueSetReceived"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_ValueSetReceived(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IRemoteSystemSessionMessageChannel*, EventRegistrationToken, int>)(lpVtbl[11]))((IRemoteSystemSessionMessageChannel*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Session([NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemSession **")] IRemoteSystemSession** value);

        [VtblIndex(7)]
        HRESULT BroadcastValueSetAsync([NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* messageData, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation);

        [VtblIndex(8)]
        HRESULT SendValueSetAsync([NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* messageData, [NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemSessionParticipant *")] IRemoteSystemSessionParticipant* participant, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation);

        [VtblIndex(9)]
        HRESULT SendValueSetToParticipantsAsync([NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* messageData, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CSystem__CRemoteSystems__CRemoteSystemSessionParticipant_t *")] IIterable<IntPtr>* participants, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation);

        [VtblIndex(10)]
        HRESULT add_ValueSetReceived([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CRemoteSystems__CRemoteSystemSessionMessageChannel_Windows__CSystem__CRemoteSystems__CRemoteSystemSessionValueSetReceivedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(11)]
        HRESULT remove_ValueSetReceived(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::System::RemoteSystems::IRemoteSystemSession **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRemoteSystemSession**, int> get_Session;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::IPropertySet *, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPropertySet*, IAsyncOperation<bool>**, int> BroadcastValueSetAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::IPropertySet *, ABI::Windows::System::RemoteSystems::IRemoteSystemSessionParticipant *, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPropertySet*, IRemoteSystemSessionParticipant*, IAsyncOperation<bool>**, int> SendValueSetAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::IPropertySet *, ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CSystem__CRemoteSystems__CRemoteSystemSessionParticipant_t *, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPropertySet*, IIterable<IntPtr>*, IAsyncOperation<bool>**, int> SendValueSetToParticipantsAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CRemoteSystems__CRemoteSystemSessionMessageChannel_Windows__CSystem__CRemoteSystems__CRemoteSystemSessionValueSetReceivedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_ValueSetReceived;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ValueSetReceived;
    }
}
