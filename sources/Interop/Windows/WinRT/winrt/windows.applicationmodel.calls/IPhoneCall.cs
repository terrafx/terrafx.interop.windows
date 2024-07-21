// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPhoneCall.xml' path='doc/member[@name="IPhoneCall"]/*' />
[Guid("C14ED0F8-C17D-59D2-9628-66E545B6CD21")]
[NativeTypeName("struct IPhoneCall : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPhoneCall : IPhoneCall.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPhoneCall));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCall*, Guid*, void**, int>)(lpVtbl[0]))((IPhoneCall*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCall*, uint>)(lpVtbl[1]))((IPhoneCall*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCall*, uint>)(lpVtbl[2]))((IPhoneCall*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCall*, uint*, Guid**, int>)(lpVtbl[3]))((IPhoneCall*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCall*, HSTRING*, int>)(lpVtbl[4]))((IPhoneCall*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCall*, TrustLevel*, int>)(lpVtbl[5]))((IPhoneCall*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPhoneCall.xml' path='doc/member[@name="IPhoneCall.add_StatusChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_StatusChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CPhoneCall_IInspectable_t *")] ITypedEventHandler<Pointer<IPhoneCall>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCall*, ITypedEventHandler<Pointer<IPhoneCall>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IPhoneCall*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IPhoneCall.xml' path='doc/member[@name="IPhoneCall.remove_StatusChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_StatusChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCall*, EventRegistrationToken, int>)(lpVtbl[7]))((IPhoneCall*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IPhoneCall.xml' path='doc/member[@name="IPhoneCall.add_AudioDeviceChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_AudioDeviceChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CPhoneCall_IInspectable_t *")] ITypedEventHandler<Pointer<IPhoneCall>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCall*, ITypedEventHandler<Pointer<IPhoneCall>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[8]))((IPhoneCall*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IPhoneCall.xml' path='doc/member[@name="IPhoneCall.remove_AudioDeviceChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_AudioDeviceChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCall*, EventRegistrationToken, int>)(lpVtbl[9]))((IPhoneCall*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IPhoneCall.xml' path='doc/member[@name="IPhoneCall.add_IsMutedChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_IsMutedChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CPhoneCall_IInspectable_t *")] ITypedEventHandler<Pointer<IPhoneCall>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCall*, ITypedEventHandler<Pointer<IPhoneCall>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[10]))((IPhoneCall*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IPhoneCall.xml' path='doc/member[@name="IPhoneCall.remove_IsMutedChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_IsMutedChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCall*, EventRegistrationToken, int>)(lpVtbl[11]))((IPhoneCall*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IPhoneCall.xml' path='doc/member[@name="IPhoneCall.get_CallId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_CallId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCall*, HSTRING*, int>)(lpVtbl[12]))((IPhoneCall*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCall.xml' path='doc/member[@name="IPhoneCall.get_IsMuted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_IsMuted([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCall*, byte*, int>)(lpVtbl[13]))((IPhoneCall*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCall.xml' path='doc/member[@name="IPhoneCall.get_Status"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Status([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallStatus *")] PhoneCallStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCall*, PhoneCallStatus*, int>)(lpVtbl[14]))((IPhoneCall*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCall.xml' path='doc/member[@name="IPhoneCall.get_AudioDevice"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_AudioDevice([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallAudioDevice *")] PhoneCallAudioDevice* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCall*, PhoneCallAudioDevice*, int>)(lpVtbl[15]))((IPhoneCall*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCall.xml' path='doc/member[@name="IPhoneCall.GetPhoneCallInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetPhoneCallInfo([NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneCallInfo **")] IPhoneCallInfo** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCall*, IPhoneCallInfo**, int>)(lpVtbl[16]))((IPhoneCall*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IPhoneCall.xml' path='doc/member[@name="IPhoneCall.GetPhoneCallInfoAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetPhoneCallInfoAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallInfo_t **")] IAsyncOperation<Pointer<IPhoneCallInfo>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCall*, IAsyncOperation<Pointer<IPhoneCallInfo>>**, int>)(lpVtbl[17]))((IPhoneCall*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IPhoneCall.xml' path='doc/member[@name="IPhoneCall.End"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT End([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallOperationStatus *")] PhoneCallOperationStatus* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCall*, PhoneCallOperationStatus*, int>)(lpVtbl[18]))((IPhoneCall*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IPhoneCall.xml' path='doc/member[@name="IPhoneCall.EndAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT EndAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallOperationStatus_t **")] IAsyncOperation<PhoneCallOperationStatus>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCall*, IAsyncOperation<PhoneCallOperationStatus>**, int>)(lpVtbl[19]))((IPhoneCall*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IPhoneCall.xml' path='doc/member[@name="IPhoneCall.SendDtmfKey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT SendDtmfKey([NativeTypeName("ABI::Windows::ApplicationModel::Calls::DtmfKey")] DtmfKey key, [NativeTypeName("ABI::Windows::ApplicationModel::Calls::DtmfToneAudioPlayback")] DtmfToneAudioPlayback dtmfToneAudioPlayback, [NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallOperationStatus *")] PhoneCallOperationStatus* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCall*, DtmfKey, DtmfToneAudioPlayback, PhoneCallOperationStatus*, int>)(lpVtbl[20]))((IPhoneCall*)Unsafe.AsPointer(ref this), key, dtmfToneAudioPlayback, result);
    }

    /// <include file='IPhoneCall.xml' path='doc/member[@name="IPhoneCall.SendDtmfKeyAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT SendDtmfKeyAsync([NativeTypeName("ABI::Windows::ApplicationModel::Calls::DtmfKey")] DtmfKey key, [NativeTypeName("ABI::Windows::ApplicationModel::Calls::DtmfToneAudioPlayback")] DtmfToneAudioPlayback dtmfToneAudioPlayback, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallOperationStatus_t **")] IAsyncOperation<PhoneCallOperationStatus>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCall*, DtmfKey, DtmfToneAudioPlayback, IAsyncOperation<PhoneCallOperationStatus>**, int>)(lpVtbl[21]))((IPhoneCall*)Unsafe.AsPointer(ref this), key, dtmfToneAudioPlayback, operation);
    }

    /// <include file='IPhoneCall.xml' path='doc/member[@name="IPhoneCall.AcceptIncoming"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT AcceptIncoming([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallOperationStatus *")] PhoneCallOperationStatus* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCall*, PhoneCallOperationStatus*, int>)(lpVtbl[22]))((IPhoneCall*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IPhoneCall.xml' path='doc/member[@name="IPhoneCall.AcceptIncomingAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT AcceptIncomingAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallOperationStatus_t **")] IAsyncOperation<PhoneCallOperationStatus>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCall*, IAsyncOperation<PhoneCallOperationStatus>**, int>)(lpVtbl[23]))((IPhoneCall*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IPhoneCall.xml' path='doc/member[@name="IPhoneCall.Hold"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT Hold([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallOperationStatus *")] PhoneCallOperationStatus* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCall*, PhoneCallOperationStatus*, int>)(lpVtbl[24]))((IPhoneCall*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IPhoneCall.xml' path='doc/member[@name="IPhoneCall.HoldAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT HoldAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallOperationStatus_t **")] IAsyncOperation<PhoneCallOperationStatus>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCall*, IAsyncOperation<PhoneCallOperationStatus>**, int>)(lpVtbl[25]))((IPhoneCall*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IPhoneCall.xml' path='doc/member[@name="IPhoneCall.ResumeFromHold"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT ResumeFromHold([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallOperationStatus *")] PhoneCallOperationStatus* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCall*, PhoneCallOperationStatus*, int>)(lpVtbl[26]))((IPhoneCall*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IPhoneCall.xml' path='doc/member[@name="IPhoneCall.ResumeFromHoldAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT ResumeFromHoldAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallOperationStatus_t **")] IAsyncOperation<PhoneCallOperationStatus>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCall*, IAsyncOperation<PhoneCallOperationStatus>**, int>)(lpVtbl[27]))((IPhoneCall*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IPhoneCall.xml' path='doc/member[@name="IPhoneCall.Mute"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT Mute([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallOperationStatus *")] PhoneCallOperationStatus* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCall*, PhoneCallOperationStatus*, int>)(lpVtbl[28]))((IPhoneCall*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IPhoneCall.xml' path='doc/member[@name="IPhoneCall.MuteAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT MuteAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallOperationStatus_t **")] IAsyncOperation<PhoneCallOperationStatus>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCall*, IAsyncOperation<PhoneCallOperationStatus>**, int>)(lpVtbl[29]))((IPhoneCall*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IPhoneCall.xml' path='doc/member[@name="IPhoneCall.Unmute"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT Unmute([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallOperationStatus *")] PhoneCallOperationStatus* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCall*, PhoneCallOperationStatus*, int>)(lpVtbl[30]))((IPhoneCall*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IPhoneCall.xml' path='doc/member[@name="IPhoneCall.UnmuteAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT UnmuteAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallOperationStatus_t **")] IAsyncOperation<PhoneCallOperationStatus>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCall*, IAsyncOperation<PhoneCallOperationStatus>**, int>)(lpVtbl[31]))((IPhoneCall*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IPhoneCall.xml' path='doc/member[@name="IPhoneCall.RejectIncoming"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT RejectIncoming([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallOperationStatus *")] PhoneCallOperationStatus* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCall*, PhoneCallOperationStatus*, int>)(lpVtbl[32]))((IPhoneCall*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IPhoneCall.xml' path='doc/member[@name="IPhoneCall.RejectIncomingAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT RejectIncomingAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallOperationStatus_t **")] IAsyncOperation<PhoneCallOperationStatus>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCall*, IAsyncOperation<PhoneCallOperationStatus>**, int>)(lpVtbl[33]))((IPhoneCall*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IPhoneCall.xml' path='doc/member[@name="IPhoneCall.ChangeAudioDevice"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT ChangeAudioDevice([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallAudioDevice")] PhoneCallAudioDevice endpoint, [NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallOperationStatus *")] PhoneCallOperationStatus* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCall*, PhoneCallAudioDevice, PhoneCallOperationStatus*, int>)(lpVtbl[34]))((IPhoneCall*)Unsafe.AsPointer(ref this), endpoint, result);
    }

    /// <include file='IPhoneCall.xml' path='doc/member[@name="IPhoneCall.ChangeAudioDeviceAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT ChangeAudioDeviceAsync([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallAudioDevice")] PhoneCallAudioDevice endpoint, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallOperationStatus_t **")] IAsyncOperation<PhoneCallOperationStatus>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCall*, PhoneCallAudioDevice, IAsyncOperation<PhoneCallOperationStatus>**, int>)(lpVtbl[35]))((IPhoneCall*)Unsafe.AsPointer(ref this), endpoint, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_StatusChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CPhoneCall_IInspectable_t *")] ITypedEventHandler<Pointer<IPhoneCall>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_StatusChanged(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT add_AudioDeviceChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CPhoneCall_IInspectable_t *")] ITypedEventHandler<Pointer<IPhoneCall>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(9)]
        HRESULT remove_AudioDeviceChanged(EventRegistrationToken token);

        [VtblIndex(10)]
        HRESULT add_IsMutedChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CPhoneCall_IInspectable_t *")] ITypedEventHandler<Pointer<IPhoneCall>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(11)]
        HRESULT remove_IsMutedChanged(EventRegistrationToken token);

        [VtblIndex(12)]
        HRESULT get_CallId(HSTRING* value);

        [VtblIndex(13)]
        HRESULT get_IsMuted([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(14)]
        HRESULT get_Status([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallStatus *")] PhoneCallStatus* value);

        [VtblIndex(15)]
        HRESULT get_AudioDevice([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallAudioDevice *")] PhoneCallAudioDevice* value);

        [VtblIndex(16)]
        HRESULT GetPhoneCallInfo([NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneCallInfo **")] IPhoneCallInfo** result);

        [VtblIndex(17)]
        HRESULT GetPhoneCallInfoAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallInfo_t **")] IAsyncOperation<Pointer<IPhoneCallInfo>>** operation);

        [VtblIndex(18)]
        HRESULT End([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallOperationStatus *")] PhoneCallOperationStatus* result);

        [VtblIndex(19)]
        HRESULT EndAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallOperationStatus_t **")] IAsyncOperation<PhoneCallOperationStatus>** operation);

        [VtblIndex(20)]
        HRESULT SendDtmfKey([NativeTypeName("ABI::Windows::ApplicationModel::Calls::DtmfKey")] DtmfKey key, [NativeTypeName("ABI::Windows::ApplicationModel::Calls::DtmfToneAudioPlayback")] DtmfToneAudioPlayback dtmfToneAudioPlayback, [NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallOperationStatus *")] PhoneCallOperationStatus* result);

        [VtblIndex(21)]
        HRESULT SendDtmfKeyAsync([NativeTypeName("ABI::Windows::ApplicationModel::Calls::DtmfKey")] DtmfKey key, [NativeTypeName("ABI::Windows::ApplicationModel::Calls::DtmfToneAudioPlayback")] DtmfToneAudioPlayback dtmfToneAudioPlayback, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallOperationStatus_t **")] IAsyncOperation<PhoneCallOperationStatus>** operation);

        [VtblIndex(22)]
        HRESULT AcceptIncoming([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallOperationStatus *")] PhoneCallOperationStatus* result);

        [VtblIndex(23)]
        HRESULT AcceptIncomingAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallOperationStatus_t **")] IAsyncOperation<PhoneCallOperationStatus>** operation);

        [VtblIndex(24)]
        HRESULT Hold([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallOperationStatus *")] PhoneCallOperationStatus* result);

        [VtblIndex(25)]
        HRESULT HoldAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallOperationStatus_t **")] IAsyncOperation<PhoneCallOperationStatus>** operation);

        [VtblIndex(26)]
        HRESULT ResumeFromHold([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallOperationStatus *")] PhoneCallOperationStatus* result);

        [VtblIndex(27)]
        HRESULT ResumeFromHoldAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallOperationStatus_t **")] IAsyncOperation<PhoneCallOperationStatus>** operation);

        [VtblIndex(28)]
        HRESULT Mute([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallOperationStatus *")] PhoneCallOperationStatus* result);

        [VtblIndex(29)]
        HRESULT MuteAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallOperationStatus_t **")] IAsyncOperation<PhoneCallOperationStatus>** operation);

        [VtblIndex(30)]
        HRESULT Unmute([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallOperationStatus *")] PhoneCallOperationStatus* result);

        [VtblIndex(31)]
        HRESULT UnmuteAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallOperationStatus_t **")] IAsyncOperation<PhoneCallOperationStatus>** operation);

        [VtblIndex(32)]
        HRESULT RejectIncoming([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallOperationStatus *")] PhoneCallOperationStatus* result);

        [VtblIndex(33)]
        HRESULT RejectIncomingAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallOperationStatus_t **")] IAsyncOperation<PhoneCallOperationStatus>** operation);

        [VtblIndex(34)]
        HRESULT ChangeAudioDevice([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallAudioDevice")] PhoneCallAudioDevice endpoint, [NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallOperationStatus *")] PhoneCallOperationStatus* result);

        [VtblIndex(35)]
        HRESULT ChangeAudioDeviceAsync([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallAudioDevice")] PhoneCallAudioDevice endpoint, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallOperationStatus_t **")] IAsyncOperation<PhoneCallOperationStatus>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CPhoneCall_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IPhoneCall>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_StatusChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_StatusChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CPhoneCall_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IPhoneCall>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_AudioDeviceChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_AudioDeviceChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CPhoneCall_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IPhoneCall>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_IsMutedChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_IsMutedChanged;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_CallId;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsMuted;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneCallStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PhoneCallStatus*, int> get_Status;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneCallAudioDevice *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PhoneCallAudioDevice*, int> get_AudioDevice;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::IPhoneCallInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPhoneCallInfo**, int> GetPhoneCallInfo;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallInfo_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IPhoneCallInfo>>**, int> GetPhoneCallInfoAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneCallOperationStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PhoneCallOperationStatus*, int> End;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallOperationStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<PhoneCallOperationStatus>**, int> EndAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::DtmfKey, ABI::Windows::ApplicationModel::Calls::DtmfToneAudioPlayback, ABI::Windows::ApplicationModel::Calls::PhoneCallOperationStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DtmfKey, DtmfToneAudioPlayback, PhoneCallOperationStatus*, int> SendDtmfKey;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::DtmfKey, ABI::Windows::ApplicationModel::Calls::DtmfToneAudioPlayback, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallOperationStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DtmfKey, DtmfToneAudioPlayback, IAsyncOperation<PhoneCallOperationStatus>**, int> SendDtmfKeyAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneCallOperationStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PhoneCallOperationStatus*, int> AcceptIncoming;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallOperationStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<PhoneCallOperationStatus>**, int> AcceptIncomingAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneCallOperationStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PhoneCallOperationStatus*, int> Hold;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallOperationStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<PhoneCallOperationStatus>**, int> HoldAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneCallOperationStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PhoneCallOperationStatus*, int> ResumeFromHold;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallOperationStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<PhoneCallOperationStatus>**, int> ResumeFromHoldAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneCallOperationStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PhoneCallOperationStatus*, int> Mute;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallOperationStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<PhoneCallOperationStatus>**, int> MuteAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneCallOperationStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PhoneCallOperationStatus*, int> Unmute;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallOperationStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<PhoneCallOperationStatus>**, int> UnmuteAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneCallOperationStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PhoneCallOperationStatus*, int> RejectIncoming;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallOperationStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<PhoneCallOperationStatus>**, int> RejectIncomingAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneCallAudioDevice, ABI::Windows::ApplicationModel::Calls::PhoneCallOperationStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PhoneCallAudioDevice, PhoneCallOperationStatus*, int> ChangeAudioDevice;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneCallAudioDevice, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallOperationStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PhoneCallAudioDevice, IAsyncOperation<PhoneCallOperationStatus>**, int> ChangeAudioDeviceAsync;
    }
}
