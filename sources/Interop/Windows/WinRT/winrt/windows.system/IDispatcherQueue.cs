// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDispatcherQueue.xml' path='doc/member[@name="IDispatcherQueue"]/*' />
[Guid("603E88E4-A338-4FFE-A457-A5CFB9CEB899")]
[NativeTypeName("struct IDispatcherQueue : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDispatcherQueue : IDispatcherQueue.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IDispatcherQueue);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDispatcherQueue*, Guid*, void**, int>)(lpVtbl[0]))((IDispatcherQueue*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDispatcherQueue*, uint>)(lpVtbl[1]))((IDispatcherQueue*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDispatcherQueue*, uint>)(lpVtbl[2]))((IDispatcherQueue*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDispatcherQueue*, uint*, Guid**, int>)(lpVtbl[3]))((IDispatcherQueue*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDispatcherQueue*, HSTRING*, int>)(lpVtbl[4]))((IDispatcherQueue*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDispatcherQueue*, TrustLevel*, int>)(lpVtbl[5]))((IDispatcherQueue*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDispatcherQueue.xml' path='doc/member[@name="IDispatcherQueue.CreateTimer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateTimer([NativeTypeName("ABI::Windows::System::IDispatcherQueueTimer **")] IDispatcherQueueTimer** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IDispatcherQueue*, IDispatcherQueueTimer**, int>)(lpVtbl[6]))((IDispatcherQueue*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IDispatcherQueue.xml' path='doc/member[@name="IDispatcherQueue.TryEnqueue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT TryEnqueue([NativeTypeName("ABI::Windows::System::IDispatcherQueueHandler *")] IDispatcherQueueHandler* callback, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IDispatcherQueue*, IDispatcherQueueHandler*, byte*, int>)(lpVtbl[7]))((IDispatcherQueue*)Unsafe.AsPointer(ref this), callback, result);
    }

    /// <include file='IDispatcherQueue.xml' path='doc/member[@name="IDispatcherQueue.TryEnqueueWithPriority"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT TryEnqueueWithPriority([NativeTypeName("ABI::Windows::System::DispatcherQueuePriority")] DispatcherQueuePriority priority, [NativeTypeName("ABI::Windows::System::IDispatcherQueueHandler *")] IDispatcherQueueHandler* callback, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IDispatcherQueue*, DispatcherQueuePriority, IDispatcherQueueHandler*, byte*, int>)(lpVtbl[8]))((IDispatcherQueue*)Unsafe.AsPointer(ref this), priority, callback, result);
    }

    /// <include file='IDispatcherQueue.xml' path='doc/member[@name="IDispatcherQueue.add_ShutdownStarting"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT add_ShutdownStarting([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CDispatcherQueue_Windows__CSystem__CDispatcherQueueShutdownStartingEventArgs_t *")] ITypedEventHandler<Pointer<IDispatcherQueue>, Pointer<IDispatcherQueueShutdownStartingEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IDispatcherQueue*, ITypedEventHandler<Pointer<IDispatcherQueue>, Pointer<IDispatcherQueueShutdownStartingEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[9]))((IDispatcherQueue*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IDispatcherQueue.xml' path='doc/member[@name="IDispatcherQueue.remove_ShutdownStarting"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT remove_ShutdownStarting(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IDispatcherQueue*, EventRegistrationToken, int>)(lpVtbl[10]))((IDispatcherQueue*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IDispatcherQueue.xml' path='doc/member[@name="IDispatcherQueue.add_ShutdownCompleted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT add_ShutdownCompleted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CDispatcherQueue_IInspectable_t *")] ITypedEventHandler<Pointer<IDispatcherQueue>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IDispatcherQueue*, ITypedEventHandler<Pointer<IDispatcherQueue>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[11]))((IDispatcherQueue*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IDispatcherQueue.xml' path='doc/member[@name="IDispatcherQueue.remove_ShutdownCompleted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT remove_ShutdownCompleted(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IDispatcherQueue*, EventRegistrationToken, int>)(lpVtbl[12]))((IDispatcherQueue*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateTimer([NativeTypeName("ABI::Windows::System::IDispatcherQueueTimer **")] IDispatcherQueueTimer** result);

        [VtblIndex(7)]
        HRESULT TryEnqueue([NativeTypeName("ABI::Windows::System::IDispatcherQueueHandler *")] IDispatcherQueueHandler* callback, [NativeTypeName("boolean *")] byte* result);

        [VtblIndex(8)]
        HRESULT TryEnqueueWithPriority([NativeTypeName("ABI::Windows::System::DispatcherQueuePriority")] DispatcherQueuePriority priority, [NativeTypeName("ABI::Windows::System::IDispatcherQueueHandler *")] IDispatcherQueueHandler* callback, [NativeTypeName("boolean *")] byte* result);

        [VtblIndex(9)]
        HRESULT add_ShutdownStarting([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CDispatcherQueue_Windows__CSystem__CDispatcherQueueShutdownStartingEventArgs_t *")] ITypedEventHandler<Pointer<IDispatcherQueue>, Pointer<IDispatcherQueueShutdownStartingEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(10)]
        HRESULT remove_ShutdownStarting(EventRegistrationToken token);

        [VtblIndex(11)]
        HRESULT add_ShutdownCompleted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CDispatcherQueue_IInspectable_t *")] ITypedEventHandler<Pointer<IDispatcherQueue>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(12)]
        HRESULT remove_ShutdownCompleted(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::System::IDispatcherQueueTimer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDispatcherQueueTimer**, int> CreateTimer;

        [NativeTypeName("HRESULT (ABI::Windows::System::IDispatcherQueueHandler *, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDispatcherQueueHandler*, byte*, int> TryEnqueue;

        [NativeTypeName("HRESULT (ABI::Windows::System::DispatcherQueuePriority, ABI::Windows::System::IDispatcherQueueHandler *, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DispatcherQueuePriority, IDispatcherQueueHandler*, byte*, int> TryEnqueueWithPriority;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CDispatcherQueue_Windows__CSystem__CDispatcherQueueShutdownStartingEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IDispatcherQueue>, Pointer<IDispatcherQueueShutdownStartingEventArgs>>*, EventRegistrationToken*, int> add_ShutdownStarting;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ShutdownStarting;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CDispatcherQueue_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IDispatcherQueue>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_ShutdownCompleted;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ShutdownCompleted;
    }
}
