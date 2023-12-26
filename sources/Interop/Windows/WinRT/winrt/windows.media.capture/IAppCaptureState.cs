// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppCaptureState.xml' path='doc/member[@name="IAppCaptureState"]/*' />
[Guid("73134372-D4EB-44CE-9538-465F506AC4EA")]
[NativeTypeName("struct IAppCaptureState : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppCaptureState : IAppCaptureState.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppCaptureState));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureState*, Guid*, void**, int>)(lpVtbl[0]))((IAppCaptureState*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureState*, uint>)(lpVtbl[1]))((IAppCaptureState*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureState*, uint>)(lpVtbl[2]))((IAppCaptureState*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureState*, uint*, Guid**, int>)(lpVtbl[3]))((IAppCaptureState*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureState*, HSTRING*, int>)(lpVtbl[4]))((IAppCaptureState*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureState*, TrustLevel*, int>)(lpVtbl[5]))((IAppCaptureState*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppCaptureState.xml' path='doc/member[@name="IAppCaptureState.get_IsTargetRunning"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IsTargetRunning([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureState*, byte*, int>)(lpVtbl[6]))((IAppCaptureState*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppCaptureState.xml' path='doc/member[@name="IAppCaptureState.get_IsHistoricalCaptureEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_IsHistoricalCaptureEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureState*, byte*, int>)(lpVtbl[7]))((IAppCaptureState*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppCaptureState.xml' path='doc/member[@name="IAppCaptureState.get_ShouldCaptureMicrophone"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ShouldCaptureMicrophone([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureState*, byte*, int>)(lpVtbl[8]))((IAppCaptureState*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppCaptureState.xml' path='doc/member[@name="IAppCaptureState.put_ShouldCaptureMicrophone"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_ShouldCaptureMicrophone([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureState*, byte, int>)(lpVtbl[9]))((IAppCaptureState*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppCaptureState.xml' path='doc/member[@name="IAppCaptureState.RestartMicrophoneCapture"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT RestartMicrophoneCapture()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureState*, int>)(lpVtbl[10]))((IAppCaptureState*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppCaptureState.xml' path='doc/member[@name="IAppCaptureState.get_MicrophoneCaptureState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_MicrophoneCaptureState([NativeTypeName("ABI::Windows::Media::Capture::AppCaptureMicrophoneCaptureState *")] AppCaptureMicrophoneCaptureState* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureState*, AppCaptureMicrophoneCaptureState*, int>)(lpVtbl[11]))((IAppCaptureState*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppCaptureState.xml' path='doc/member[@name="IAppCaptureState.get_MicrophoneCaptureError"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_MicrophoneCaptureError([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureState*, uint*, int>)(lpVtbl[12]))((IAppCaptureState*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppCaptureState.xml' path='doc/member[@name="IAppCaptureState.add_MicrophoneCaptureStateChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT add_MicrophoneCaptureStateChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppCaptureState_Windows__CMedia__CCapture__CAppCaptureMicrophoneCaptureStateChangedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* value, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureState*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[13]))((IAppCaptureState*)Unsafe.AsPointer(ref this), value, token);
    }

    /// <include file='IAppCaptureState.xml' path='doc/member[@name="IAppCaptureState.remove_MicrophoneCaptureStateChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT remove_MicrophoneCaptureStateChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureState*, EventRegistrationToken, int>)(lpVtbl[14]))((IAppCaptureState*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IAppCaptureState.xml' path='doc/member[@name="IAppCaptureState.add_CaptureTargetClosed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT add_CaptureTargetClosed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppCaptureState_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* value, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureState*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[15]))((IAppCaptureState*)Unsafe.AsPointer(ref this), value, token);
    }

    /// <include file='IAppCaptureState.xml' path='doc/member[@name="IAppCaptureState.remove_CaptureTargetClosed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT remove_CaptureTargetClosed(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureState*, EventRegistrationToken, int>)(lpVtbl[16]))((IAppCaptureState*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IsTargetRunning([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_IsHistoricalCaptureEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT get_ShouldCaptureMicrophone([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT put_ShouldCaptureMicrophone([NativeTypeName("boolean")] byte value);

        [VtblIndex(10)]
        HRESULT RestartMicrophoneCapture();

        [VtblIndex(11)]
        HRESULT get_MicrophoneCaptureState([NativeTypeName("ABI::Windows::Media::Capture::AppCaptureMicrophoneCaptureState *")] AppCaptureMicrophoneCaptureState* value);

        [VtblIndex(12)]
        HRESULT get_MicrophoneCaptureError([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(13)]
        HRESULT add_MicrophoneCaptureStateChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppCaptureState_Windows__CMedia__CCapture__CAppCaptureMicrophoneCaptureStateChangedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* value, EventRegistrationToken* token);

        [VtblIndex(14)]
        HRESULT remove_MicrophoneCaptureStateChanged(EventRegistrationToken token);

        [VtblIndex(15)]
        HRESULT add_CaptureTargetClosed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppCaptureState_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* value, EventRegistrationToken* token);

        [VtblIndex(16)]
        HRESULT remove_CaptureTargetClosed(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsTargetRunning;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsHistoricalCaptureEnabled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_ShouldCaptureMicrophone;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_ShouldCaptureMicrophone;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> RestartMicrophoneCapture;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::AppCaptureMicrophoneCaptureState *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppCaptureMicrophoneCaptureState*, int> get_MicrophoneCaptureState;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_MicrophoneCaptureError;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppCaptureState_Windows__CMedia__CCapture__CAppCaptureMicrophoneCaptureStateChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_MicrophoneCaptureStateChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_MicrophoneCaptureStateChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppCaptureState_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_CaptureTargetClosed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_CaptureTargetClosed;
    }
}
