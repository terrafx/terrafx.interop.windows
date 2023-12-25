// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppBroadcastState.xml' path='doc/member[@name="IAppBroadcastState"]/*' />
[Guid("EE08056D-8099-4DDD-922E-C56DAC58ABFB")]
[NativeTypeName("struct IAppBroadcastState : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppBroadcastState : IAppBroadcastState.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppBroadcastState));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastState*, Guid*, void**, int>)(lpVtbl[0]))((IAppBroadcastState*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastState*, uint>)(lpVtbl[1]))((IAppBroadcastState*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastState*, uint>)(lpVtbl[2]))((IAppBroadcastState*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastState*, uint*, Guid**, int>)(lpVtbl[3]))((IAppBroadcastState*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastState*, HSTRING*, int>)(lpVtbl[4]))((IAppBroadcastState*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastState*, TrustLevel*, int>)(lpVtbl[5]))((IAppBroadcastState*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppBroadcastState.xml' path='doc/member[@name="IAppBroadcastState.get_IsCaptureTargetRunning"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IsCaptureTargetRunning([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastState*, byte*, int>)(lpVtbl[6]))((IAppBroadcastState*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastState.xml' path='doc/member[@name="IAppBroadcastState.get_ViewerCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ViewerCount([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastState*, uint*, int>)(lpVtbl[7]))((IAppBroadcastState*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastState.xml' path='doc/member[@name="IAppBroadcastState.get_ShouldCaptureMicrophone"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ShouldCaptureMicrophone([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastState*, byte*, int>)(lpVtbl[8]))((IAppBroadcastState*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastState.xml' path='doc/member[@name="IAppBroadcastState.put_ShouldCaptureMicrophone"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_ShouldCaptureMicrophone([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastState*, byte, int>)(lpVtbl[9]))((IAppBroadcastState*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastState.xml' path='doc/member[@name="IAppBroadcastState.RestartMicrophoneCapture"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT RestartMicrophoneCapture()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastState*, int>)(lpVtbl[10]))((IAppBroadcastState*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppBroadcastState.xml' path='doc/member[@name="IAppBroadcastState.get_ShouldCaptureCamera"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_ShouldCaptureCamera([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastState*, byte*, int>)(lpVtbl[11]))((IAppBroadcastState*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastState.xml' path='doc/member[@name="IAppBroadcastState.put_ShouldCaptureCamera"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_ShouldCaptureCamera([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastState*, byte, int>)(lpVtbl[12]))((IAppBroadcastState*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastState.xml' path='doc/member[@name="IAppBroadcastState.RestartCameraCapture"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT RestartCameraCapture()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastState*, int>)(lpVtbl[13]))((IAppBroadcastState*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppBroadcastState.xml' path='doc/member[@name="IAppBroadcastState.get_EncodedVideoSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_EncodedVideoSize([NativeTypeName("ABI::Windows::Foundation::Size *")] Size* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastState*, Size*, int>)(lpVtbl[14]))((IAppBroadcastState*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastState.xml' path='doc/member[@name="IAppBroadcastState.get_MicrophoneCaptureState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_MicrophoneCaptureState([NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastMicrophoneCaptureState *")] AppBroadcastMicrophoneCaptureState* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastState*, AppBroadcastMicrophoneCaptureState*, int>)(lpVtbl[15]))((IAppBroadcastState*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastState.xml' path='doc/member[@name="IAppBroadcastState.get_MicrophoneCaptureError"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_MicrophoneCaptureError([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastState*, uint*, int>)(lpVtbl[16]))((IAppBroadcastState*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastState.xml' path='doc/member[@name="IAppBroadcastState.get_CameraCaptureState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_CameraCaptureState([NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastCameraCaptureState *")] AppBroadcastCameraCaptureState* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastState*, AppBroadcastCameraCaptureState*, int>)(lpVtbl[17]))((IAppBroadcastState*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastState.xml' path='doc/member[@name="IAppBroadcastState.get_CameraCaptureError"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_CameraCaptureError([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastState*, uint*, int>)(lpVtbl[18]))((IAppBroadcastState*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastState.xml' path='doc/member[@name="IAppBroadcastState.get_StreamState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_StreamState([NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastStreamState *")] AppBroadcastStreamState* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastState*, AppBroadcastStreamState*, int>)(lpVtbl[19]))((IAppBroadcastState*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastState.xml' path='doc/member[@name="IAppBroadcastState.get_PlugInState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_PlugInState([NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastPlugInState *")] AppBroadcastPlugInState* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastState*, AppBroadcastPlugInState*, int>)(lpVtbl[20]))((IAppBroadcastState*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastState.xml' path='doc/member[@name="IAppBroadcastState.get_OAuthRequestUri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_OAuthRequestUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastState*, IUriRuntimeClass**, int>)(lpVtbl[21]))((IAppBroadcastState*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastState.xml' path='doc/member[@name="IAppBroadcastState.get_OAuthCallbackUri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_OAuthCallbackUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastState*, IUriRuntimeClass**, int>)(lpVtbl[22]))((IAppBroadcastState*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastState.xml' path='doc/member[@name="IAppBroadcastState.get_AuthenticationResult"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_AuthenticationResult([NativeTypeName("ABI::Windows::Security::Authentication::Web::IWebAuthenticationResult **")] IWebAuthenticationResult** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastState*, IWebAuthenticationResult**, int>)(lpVtbl[23]))((IAppBroadcastState*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastState.xml' path='doc/member[@name="IAppBroadcastState.put_AuthenticationResult"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT put_AuthenticationResult([NativeTypeName("ABI::Windows::Security::Authentication::Web::IWebAuthenticationResult *")] IWebAuthenticationResult* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastState*, IWebAuthenticationResult*, int>)(lpVtbl[24]))((IAppBroadcastState*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastState.xml' path='doc/member[@name="IAppBroadcastState.put_SignInState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_SignInState([NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastSignInState")] AppBroadcastSignInState value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastState*, AppBroadcastSignInState, int>)(lpVtbl[25]))((IAppBroadcastState*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastState.xml' path='doc/member[@name="IAppBroadcastState.get_SignInState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_SignInState([NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastSignInState *")] AppBroadcastSignInState* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastState*, AppBroadcastSignInState*, int>)(lpVtbl[26]))((IAppBroadcastState*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastState.xml' path='doc/member[@name="IAppBroadcastState.get_TerminationReason"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_TerminationReason([NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastTerminationReason *")] AppBroadcastTerminationReason* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastState*, AppBroadcastTerminationReason*, int>)(lpVtbl[27]))((IAppBroadcastState*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastState.xml' path='doc/member[@name="IAppBroadcastState.get_TerminationReasonPlugInSpecific"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_TerminationReasonPlugInSpecific([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastState*, uint*, int>)(lpVtbl[28]))((IAppBroadcastState*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastState.xml' path='doc/member[@name="IAppBroadcastState.add_ViewerCountChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT add_ViewerCountChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastState_Windows__CMedia__CCapture__CAppBroadcastViewerCountChangedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* value, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastState*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[29]))((IAppBroadcastState*)Unsafe.AsPointer(ref this), value, token);
    }

    /// <include file='IAppBroadcastState.xml' path='doc/member[@name="IAppBroadcastState.remove_ViewerCountChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT remove_ViewerCountChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastState*, EventRegistrationToken, int>)(lpVtbl[30]))((IAppBroadcastState*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IAppBroadcastState.xml' path='doc/member[@name="IAppBroadcastState.add_MicrophoneCaptureStateChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT add_MicrophoneCaptureStateChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastState_Windows__CMedia__CCapture__CAppBroadcastMicrophoneCaptureStateChangedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* value, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastState*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[31]))((IAppBroadcastState*)Unsafe.AsPointer(ref this), value, token);
    }

    /// <include file='IAppBroadcastState.xml' path='doc/member[@name="IAppBroadcastState.remove_MicrophoneCaptureStateChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT remove_MicrophoneCaptureStateChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastState*, EventRegistrationToken, int>)(lpVtbl[32]))((IAppBroadcastState*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IAppBroadcastState.xml' path='doc/member[@name="IAppBroadcastState.add_CameraCaptureStateChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT add_CameraCaptureStateChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastState_Windows__CMedia__CCapture__CAppBroadcastCameraCaptureStateChangedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* value, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastState*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[33]))((IAppBroadcastState*)Unsafe.AsPointer(ref this), value, token);
    }

    /// <include file='IAppBroadcastState.xml' path='doc/member[@name="IAppBroadcastState.remove_CameraCaptureStateChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT remove_CameraCaptureStateChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastState*, EventRegistrationToken, int>)(lpVtbl[34]))((IAppBroadcastState*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IAppBroadcastState.xml' path='doc/member[@name="IAppBroadcastState.add_PlugInStateChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT add_PlugInStateChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastState_Windows__CMedia__CCapture__CAppBroadcastPlugInStateChangedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastState*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[35]))((IAppBroadcastState*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IAppBroadcastState.xml' path='doc/member[@name="IAppBroadcastState.remove_PlugInStateChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT remove_PlugInStateChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastState*, EventRegistrationToken, int>)(lpVtbl[36]))((IAppBroadcastState*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IAppBroadcastState.xml' path='doc/member[@name="IAppBroadcastState.add_StreamStateChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT add_StreamStateChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastState_Windows__CMedia__CCapture__CAppBroadcastStreamStateChangedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastState*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[37]))((IAppBroadcastState*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IAppBroadcastState.xml' path='doc/member[@name="IAppBroadcastState.remove_StreamStateChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT remove_StreamStateChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastState*, EventRegistrationToken, int>)(lpVtbl[38]))((IAppBroadcastState*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IAppBroadcastState.xml' path='doc/member[@name="IAppBroadcastState.add_CaptureTargetClosed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT add_CaptureTargetClosed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastState_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* value, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastState*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[39]))((IAppBroadcastState*)Unsafe.AsPointer(ref this), value, token);
    }

    /// <include file='IAppBroadcastState.xml' path='doc/member[@name="IAppBroadcastState.remove_CaptureTargetClosed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT remove_CaptureTargetClosed(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastState*, EventRegistrationToken, int>)(lpVtbl[40]))((IAppBroadcastState*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IsCaptureTargetRunning([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_ViewerCount([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(8)]
        HRESULT get_ShouldCaptureMicrophone([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT put_ShouldCaptureMicrophone([NativeTypeName("boolean")] byte value);

        [VtblIndex(10)]
        HRESULT RestartMicrophoneCapture();

        [VtblIndex(11)]
        HRESULT get_ShouldCaptureCamera([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(12)]
        HRESULT put_ShouldCaptureCamera([NativeTypeName("boolean")] byte value);

        [VtblIndex(13)]
        HRESULT RestartCameraCapture();

        [VtblIndex(14)]
        HRESULT get_EncodedVideoSize([NativeTypeName("ABI::Windows::Foundation::Size *")] Size* value);

        [VtblIndex(15)]
        HRESULT get_MicrophoneCaptureState([NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastMicrophoneCaptureState *")] AppBroadcastMicrophoneCaptureState* value);

        [VtblIndex(16)]
        HRESULT get_MicrophoneCaptureError([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(17)]
        HRESULT get_CameraCaptureState([NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastCameraCaptureState *")] AppBroadcastCameraCaptureState* value);

        [VtblIndex(18)]
        HRESULT get_CameraCaptureError([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(19)]
        HRESULT get_StreamState([NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastStreamState *")] AppBroadcastStreamState* value);

        [VtblIndex(20)]
        HRESULT get_PlugInState([NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastPlugInState *")] AppBroadcastPlugInState* value);

        [VtblIndex(21)]
        HRESULT get_OAuthRequestUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value);

        [VtblIndex(22)]
        HRESULT get_OAuthCallbackUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value);

        [VtblIndex(23)]
        HRESULT get_AuthenticationResult([NativeTypeName("ABI::Windows::Security::Authentication::Web::IWebAuthenticationResult **")] IWebAuthenticationResult** value);

        [VtblIndex(24)]
        HRESULT put_AuthenticationResult([NativeTypeName("ABI::Windows::Security::Authentication::Web::IWebAuthenticationResult *")] IWebAuthenticationResult* value);

        [VtblIndex(25)]
        HRESULT put_SignInState([NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastSignInState")] AppBroadcastSignInState value);

        [VtblIndex(26)]
        HRESULT get_SignInState([NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastSignInState *")] AppBroadcastSignInState* value);

        [VtblIndex(27)]
        HRESULT get_TerminationReason([NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastTerminationReason *")] AppBroadcastTerminationReason* value);

        [VtblIndex(28)]
        HRESULT get_TerminationReasonPlugInSpecific([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(29)]
        HRESULT add_ViewerCountChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastState_Windows__CMedia__CCapture__CAppBroadcastViewerCountChangedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* value, EventRegistrationToken* token);

        [VtblIndex(30)]
        HRESULT remove_ViewerCountChanged(EventRegistrationToken token);

        [VtblIndex(31)]
        HRESULT add_MicrophoneCaptureStateChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastState_Windows__CMedia__CCapture__CAppBroadcastMicrophoneCaptureStateChangedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* value, EventRegistrationToken* token);

        [VtblIndex(32)]
        HRESULT remove_MicrophoneCaptureStateChanged(EventRegistrationToken token);

        [VtblIndex(33)]
        HRESULT add_CameraCaptureStateChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastState_Windows__CMedia__CCapture__CAppBroadcastCameraCaptureStateChangedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* value, EventRegistrationToken* token);

        [VtblIndex(34)]
        HRESULT remove_CameraCaptureStateChanged(EventRegistrationToken token);

        [VtblIndex(35)]
        HRESULT add_PlugInStateChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastState_Windows__CMedia__CCapture__CAppBroadcastPlugInStateChangedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(36)]
        HRESULT remove_PlugInStateChanged(EventRegistrationToken token);

        [VtblIndex(37)]
        HRESULT add_StreamStateChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastState_Windows__CMedia__CCapture__CAppBroadcastStreamStateChangedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(38)]
        HRESULT remove_StreamStateChanged(EventRegistrationToken token);

        [VtblIndex(39)]
        HRESULT add_CaptureTargetClosed([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastState_IInspectable_t *")] ITypedEventHandler<IntPtr, IntPtr>* value, EventRegistrationToken* token);

        [VtblIndex(40)]
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
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsCaptureTargetRunning;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_ViewerCount;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_ShouldCaptureMicrophone;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_ShouldCaptureMicrophone;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> RestartMicrophoneCapture;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_ShouldCaptureCamera;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_ShouldCaptureCamera;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> RestartCameraCapture;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Size *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Size*, int> get_EncodedVideoSize;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::AppBroadcastMicrophoneCaptureState *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppBroadcastMicrophoneCaptureState*, int> get_MicrophoneCaptureState;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_MicrophoneCaptureError;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::AppBroadcastCameraCaptureState *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppBroadcastCameraCaptureState*, int> get_CameraCaptureState;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_CameraCaptureError;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::AppBroadcastStreamState *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppBroadcastStreamState*, int> get_StreamState;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::AppBroadcastPlugInState *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppBroadcastPlugInState*, int> get_PlugInState;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass**, int> get_OAuthRequestUri;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass**, int> get_OAuthCallbackUri;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Authentication::Web::IWebAuthenticationResult **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWebAuthenticationResult**, int> get_AuthenticationResult;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Authentication::Web::IWebAuthenticationResult *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWebAuthenticationResult*, int> put_AuthenticationResult;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::AppBroadcastSignInState) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppBroadcastSignInState, int> put_SignInState;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::AppBroadcastSignInState *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppBroadcastSignInState*, int> get_SignInState;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::AppBroadcastTerminationReason *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppBroadcastTerminationReason*, int> get_TerminationReason;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_TerminationReasonPlugInSpecific;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastState_Windows__CMedia__CCapture__CAppBroadcastViewerCountChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_ViewerCountChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ViewerCountChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastState_Windows__CMedia__CCapture__CAppBroadcastMicrophoneCaptureStateChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_MicrophoneCaptureStateChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_MicrophoneCaptureStateChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastState_Windows__CMedia__CCapture__CAppBroadcastCameraCaptureStateChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_CameraCaptureStateChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_CameraCaptureStateChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastState_Windows__CMedia__CCapture__CAppBroadcastPlugInStateChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_PlugInStateChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_PlugInStateChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastState_Windows__CMedia__CCapture__CAppBroadcastStreamStateChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_StreamStateChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_StreamStateChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastState_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_CaptureTargetClosed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_CaptureTargetClosed;
    }
}
