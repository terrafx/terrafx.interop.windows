// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPhoneLine.xml' path='doc/member[@name="IPhoneLine"]/*' />
[Guid("27C66F30-6A69-34CA-A2BA-65302530C311")]
[NativeTypeName("struct IPhoneLine : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPhoneLine : IPhoneLine.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPhoneLine));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLine*, Guid*, void**, int>)(lpVtbl[0]))((IPhoneLine*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLine*, uint>)(lpVtbl[1]))((IPhoneLine*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLine*, uint>)(lpVtbl[2]))((IPhoneLine*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLine*, uint*, Guid**, int>)(lpVtbl[3]))((IPhoneLine*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLine*, HSTRING*, int>)(lpVtbl[4]))((IPhoneLine*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLine*, TrustLevel*, int>)(lpVtbl[5]))((IPhoneLine*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPhoneLine.xml' path='doc/member[@name="IPhoneLine.add_LineChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_LineChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CPhoneLine_IInspectable_t *")] ITypedEventHandler<Pointer<IPhoneLine>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLine*, ITypedEventHandler<Pointer<IPhoneLine>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((IPhoneLine*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IPhoneLine.xml' path='doc/member[@name="IPhoneLine.remove_LineChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_LineChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLine*, EventRegistrationToken, int>)(lpVtbl[7]))((IPhoneLine*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IPhoneLine.xml' path='doc/member[@name="IPhoneLine.get_Id"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Id(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLine*, Guid*, int>)(lpVtbl[8]))((IPhoneLine*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneLine.xml' path='doc/member[@name="IPhoneLine.get_DisplayColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_DisplayColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLine*, Color*, int>)(lpVtbl[9]))((IPhoneLine*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneLine.xml' path='doc/member[@name="IPhoneLine.get_NetworkState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_NetworkState([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneNetworkState *")] PhoneNetworkState* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLine*, PhoneNetworkState*, int>)(lpVtbl[10]))((IPhoneLine*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneLine.xml' path='doc/member[@name="IPhoneLine.get_DisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_DisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLine*, HSTRING*, int>)(lpVtbl[11]))((IPhoneLine*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneLine.xml' path='doc/member[@name="IPhoneLine.get_Voicemail"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Voicemail([NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneVoicemail **")] IPhoneVoicemail** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLine*, IPhoneVoicemail**, int>)(lpVtbl[12]))((IPhoneLine*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneLine.xml' path='doc/member[@name="IPhoneLine.get_NetworkName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_NetworkName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLine*, HSTRING*, int>)(lpVtbl[13]))((IPhoneLine*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneLine.xml' path='doc/member[@name="IPhoneLine.get_CellularDetails"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_CellularDetails([NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneLineCellularDetails **")] IPhoneLineCellularDetails** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLine*, IPhoneLineCellularDetails**, int>)(lpVtbl[14]))((IPhoneLine*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneLine.xml' path='doc/member[@name="IPhoneLine.get_Transport"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_Transport([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneLineTransport *")] PhoneLineTransport* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLine*, PhoneLineTransport*, int>)(lpVtbl[15]))((IPhoneLine*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneLine.xml' path='doc/member[@name="IPhoneLine.get_CanDial"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_CanDial([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLine*, byte*, int>)(lpVtbl[16]))((IPhoneLine*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneLine.xml' path='doc/member[@name="IPhoneLine.get_SupportsTile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_SupportsTile([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLine*, byte*, int>)(lpVtbl[17]))((IPhoneLine*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneLine.xml' path='doc/member[@name="IPhoneLine.get_VideoCallingCapabilities"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_VideoCallingCapabilities([NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneCallVideoCapabilities **")] IPhoneCallVideoCapabilities** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLine*, IPhoneCallVideoCapabilities**, int>)(lpVtbl[18]))((IPhoneLine*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneLine.xml' path='doc/member[@name="IPhoneLine.get_LineConfiguration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_LineConfiguration([NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneLineConfiguration **")] IPhoneLineConfiguration** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLine*, IPhoneLineConfiguration**, int>)(lpVtbl[19]))((IPhoneLine*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneLine.xml' path='doc/member[@name="IPhoneLine.IsImmediateDialNumberAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT IsImmediateDialNumberAsync(HSTRING number, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLine*, HSTRING, IAsyncOperation<bool>**, int>)(lpVtbl[20]))((IPhoneLine*)Unsafe.AsPointer(ref this), number, result);
    }

    /// <include file='IPhoneLine.xml' path='doc/member[@name="IPhoneLine.Dial"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT Dial(HSTRING number, HSTRING displayName)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLine*, HSTRING, HSTRING, int>)(lpVtbl[21]))((IPhoneLine*)Unsafe.AsPointer(ref this), number, displayName);
    }

    /// <include file='IPhoneLine.xml' path='doc/member[@name="IPhoneLine.DialWithOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT DialWithOptions([NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneDialOptions *")] IPhoneDialOptions* options)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneLine*, IPhoneDialOptions*, int>)(lpVtbl[22]))((IPhoneLine*)Unsafe.AsPointer(ref this), options);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_LineChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CPhoneLine_IInspectable_t *")] ITypedEventHandler<Pointer<IPhoneLine>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_LineChanged(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT get_Id(Guid* value);

        [VtblIndex(9)]
        HRESULT get_DisplayColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(10)]
        HRESULT get_NetworkState([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneNetworkState *")] PhoneNetworkState* value);

        [VtblIndex(11)]
        HRESULT get_DisplayName(HSTRING* value);

        [VtblIndex(12)]
        HRESULT get_Voicemail([NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneVoicemail **")] IPhoneVoicemail** value);

        [VtblIndex(13)]
        HRESULT get_NetworkName(HSTRING* value);

        [VtblIndex(14)]
        HRESULT get_CellularDetails([NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneLineCellularDetails **")] IPhoneLineCellularDetails** value);

        [VtblIndex(15)]
        HRESULT get_Transport([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneLineTransport *")] PhoneLineTransport* value);

        [VtblIndex(16)]
        HRESULT get_CanDial([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(17)]
        HRESULT get_SupportsTile([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(18)]
        HRESULT get_VideoCallingCapabilities([NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneCallVideoCapabilities **")] IPhoneCallVideoCapabilities** value);

        [VtblIndex(19)]
        HRESULT get_LineConfiguration([NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneLineConfiguration **")] IPhoneLineConfiguration** value);

        [VtblIndex(20)]
        HRESULT IsImmediateDialNumberAsync(HSTRING number, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result);

        [VtblIndex(21)]
        HRESULT Dial(HSTRING number, HSTRING displayName);

        [VtblIndex(22)]
        HRESULT DialWithOptions([NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneDialOptions *")] IPhoneDialOptions* options);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CPhoneLine_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IPhoneLine>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_LineChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_LineChanged;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_Id;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Color*, int> get_DisplayColor;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneNetworkState *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PhoneNetworkState*, int> get_NetworkState;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DisplayName;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::IPhoneVoicemail **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPhoneVoicemail**, int> get_Voicemail;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_NetworkName;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::IPhoneLineCellularDetails **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPhoneLineCellularDetails**, int> get_CellularDetails;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneLineTransport *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PhoneLineTransport*, int> get_Transport;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CanDial;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_SupportsTile;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::IPhoneCallVideoCapabilities **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPhoneCallVideoCapabilities**, int> get_VideoCallingCapabilities;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::IPhoneLineConfiguration **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPhoneLineConfiguration**, int> get_LineConfiguration;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<bool>**, int> IsImmediateDialNumberAsync;

        [NativeTypeName("HRESULT (HSTRING, HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, int> Dial;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::IPhoneDialOptions *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPhoneDialOptions*, int> DialWithOptions;
    }
}
