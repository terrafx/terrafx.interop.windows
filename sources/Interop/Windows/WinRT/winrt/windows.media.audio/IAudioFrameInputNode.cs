// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAudioFrameInputNode.xml' path='doc/member[@name="IAudioFrameInputNode"]/*' />
[Guid("01B266C7-FD96-4FF5-A3C5-D27A9BF44237")]
[NativeTypeName("struct IAudioFrameInputNode : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAudioFrameInputNode : IAudioFrameInputNode.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioFrameInputNode));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioFrameInputNode*, Guid*, void**, int>)(lpVtbl[0]))((IAudioFrameInputNode*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioFrameInputNode*, uint>)(lpVtbl[1]))((IAudioFrameInputNode*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioFrameInputNode*, uint>)(lpVtbl[2]))((IAudioFrameInputNode*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioFrameInputNode*, uint*, Guid**, int>)(lpVtbl[3]))((IAudioFrameInputNode*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioFrameInputNode*, HSTRING*, int>)(lpVtbl[4]))((IAudioFrameInputNode*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioFrameInputNode*, TrustLevel*, int>)(lpVtbl[5]))((IAudioFrameInputNode*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAudioFrameInputNode.xml' path='doc/member[@name="IAudioFrameInputNode.put_PlaybackSpeedFactor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_PlaybackSpeedFactor(double value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioFrameInputNode*, double, int>)(lpVtbl[6]))((IAudioFrameInputNode*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioFrameInputNode.xml' path='doc/member[@name="IAudioFrameInputNode.get_PlaybackSpeedFactor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_PlaybackSpeedFactor(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioFrameInputNode*, double*, int>)(lpVtbl[7]))((IAudioFrameInputNode*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioFrameInputNode.xml' path='doc/member[@name="IAudioFrameInputNode.AddFrame"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT AddFrame([NativeTypeName("ABI::Windows::Media::IAudioFrame *")] IAudioFrame* frame)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioFrameInputNode*, IAudioFrame*, int>)(lpVtbl[8]))((IAudioFrameInputNode*)Unsafe.AsPointer(ref this), frame);
    }

    /// <include file='IAudioFrameInputNode.xml' path='doc/member[@name="IAudioFrameInputNode.DiscardQueuedFrames"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT DiscardQueuedFrames()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioFrameInputNode*, int>)(lpVtbl[9]))((IAudioFrameInputNode*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAudioFrameInputNode.xml' path='doc/member[@name="IAudioFrameInputNode.get_QueuedSampleCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_QueuedSampleCount([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioFrameInputNode*, ulong*, int>)(lpVtbl[10]))((IAudioFrameInputNode*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioFrameInputNode.xml' path='doc/member[@name="IAudioFrameInputNode.add_AudioFrameCompleted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT add_AudioFrameCompleted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CAudio__CAudioFrameInputNode_Windows__CMedia__CAudio__CAudioFrameCompletedEventArgs_t *")] ITypedEventHandler<Pointer<IAudioFrameInputNode>, Pointer<IAudioFrameCompletedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioFrameInputNode*, ITypedEventHandler<Pointer<IAudioFrameInputNode>, Pointer<IAudioFrameCompletedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[11]))((IAudioFrameInputNode*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IAudioFrameInputNode.xml' path='doc/member[@name="IAudioFrameInputNode.remove_AudioFrameCompleted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT remove_AudioFrameCompleted(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioFrameInputNode*, EventRegistrationToken, int>)(lpVtbl[12]))((IAudioFrameInputNode*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IAudioFrameInputNode.xml' path='doc/member[@name="IAudioFrameInputNode.add_QuantumStarted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT add_QuantumStarted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CAudio__CAudioFrameInputNode_Windows__CMedia__CAudio__CFrameInputNodeQuantumStartedEventArgs_t *")] ITypedEventHandler<Pointer<IAudioFrameInputNode>, Pointer<IFrameInputNodeQuantumStartedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioFrameInputNode*, ITypedEventHandler<Pointer<IAudioFrameInputNode>, Pointer<IFrameInputNodeQuantumStartedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[13]))((IAudioFrameInputNode*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IAudioFrameInputNode.xml' path='doc/member[@name="IAudioFrameInputNode.remove_QuantumStarted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT remove_QuantumStarted(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioFrameInputNode*, EventRegistrationToken, int>)(lpVtbl[14]))((IAudioFrameInputNode*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_PlaybackSpeedFactor(double value);

        [VtblIndex(7)]
        HRESULT get_PlaybackSpeedFactor(double* value);

        [VtblIndex(8)]
        HRESULT AddFrame([NativeTypeName("ABI::Windows::Media::IAudioFrame *")] IAudioFrame* frame);

        [VtblIndex(9)]
        HRESULT DiscardQueuedFrames();

        [VtblIndex(10)]
        HRESULT get_QueuedSampleCount([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(11)]
        HRESULT add_AudioFrameCompleted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CAudio__CAudioFrameInputNode_Windows__CMedia__CAudio__CAudioFrameCompletedEventArgs_t *")] ITypedEventHandler<Pointer<IAudioFrameInputNode>, Pointer<IAudioFrameCompletedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(12)]
        HRESULT remove_AudioFrameCompleted(EventRegistrationToken token);

        [VtblIndex(13)]
        HRESULT add_QuantumStarted([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CAudio__CAudioFrameInputNode_Windows__CMedia__CAudio__CFrameInputNodeQuantumStartedEventArgs_t *")] ITypedEventHandler<Pointer<IAudioFrameInputNode>, Pointer<IFrameInputNodeQuantumStartedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(14)]
        HRESULT remove_QuantumStarted(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, int> put_PlaybackSpeedFactor;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_PlaybackSpeedFactor;

        [NativeTypeName("HRESULT (ABI::Windows::Media::IAudioFrame *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAudioFrame*, int> AddFrame;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> DiscardQueuedFrames;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> get_QueuedSampleCount;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CAudio__CAudioFrameInputNode_Windows__CMedia__CAudio__CAudioFrameCompletedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IAudioFrameInputNode>, Pointer<IAudioFrameCompletedEventArgs>>*, EventRegistrationToken*, int> add_AudioFrameCompleted;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_AudioFrameCompleted;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CAudio__CAudioFrameInputNode_Windows__CMedia__CAudio__CFrameInputNodeQuantumStartedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IAudioFrameInputNode>, Pointer<IFrameInputNodeQuantumStartedEventArgs>>*, EventRegistrationToken*, int> add_QuantumStarted;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_QuantumStarted;
    }
}
