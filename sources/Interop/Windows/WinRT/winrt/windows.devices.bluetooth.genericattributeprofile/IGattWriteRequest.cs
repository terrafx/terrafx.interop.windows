// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.genericattributeprofile.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGattWriteRequest.xml' path='doc/member[@name="IGattWriteRequest"]/*' />
[Guid("AEB6A9ED-DE2F-4FC2-A9A8-94EA7844F13D")]
[NativeTypeName("struct IGattWriteRequest : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGattWriteRequest : IGattWriteRequest.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGattWriteRequest));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattWriteRequest*, Guid*, void**, int>)(lpVtbl[0]))((IGattWriteRequest*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattWriteRequest*, uint>)(lpVtbl[1]))((IGattWriteRequest*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattWriteRequest*, uint>)(lpVtbl[2]))((IGattWriteRequest*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattWriteRequest*, uint*, Guid**, int>)(lpVtbl[3]))((IGattWriteRequest*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattWriteRequest*, HSTRING*, int>)(lpVtbl[4]))((IGattWriteRequest*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattWriteRequest*, TrustLevel*, int>)(lpVtbl[5]))((IGattWriteRequest*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGattWriteRequest.xml' path='doc/member[@name="IGattWriteRequest.get_Value"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Value([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattWriteRequest*, IBuffer**, int>)(lpVtbl[6]))((IGattWriteRequest*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattWriteRequest.xml' path='doc/member[@name="IGattWriteRequest.get_Offset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Offset([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattWriteRequest*, uint*, int>)(lpVtbl[7]))((IGattWriteRequest*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattWriteRequest.xml' path='doc/member[@name="IGattWriteRequest.get_Option"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Option([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattWriteOption *")] GattWriteOption* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattWriteRequest*, GattWriteOption*, int>)(lpVtbl[8]))((IGattWriteRequest*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattWriteRequest.xml' path='doc/member[@name="IGattWriteRequest.get_State"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_State([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattRequestState *")] GattRequestState* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattWriteRequest*, GattRequestState*, int>)(lpVtbl[9]))((IGattWriteRequest*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattWriteRequest.xml' path='doc/member[@name="IGattWriteRequest.add_StateChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_StateChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattWriteRequest_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattRequestStateChangedEventArgs_t *")] ITypedEventHandler<Pointer<IGattWriteRequest>, Pointer<IGattRequestStateChangedEventArgs>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattWriteRequest*, ITypedEventHandler<Pointer<IGattWriteRequest>, Pointer<IGattRequestStateChangedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[10]))((IGattWriteRequest*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IGattWriteRequest.xml' path='doc/member[@name="IGattWriteRequest.remove_StateChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_StateChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattWriteRequest*, EventRegistrationToken, int>)(lpVtbl[11]))((IGattWriteRequest*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IGattWriteRequest.xml' path='doc/member[@name="IGattWriteRequest.Respond"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Respond()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattWriteRequest*, int>)(lpVtbl[12]))((IGattWriteRequest*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IGattWriteRequest.xml' path='doc/member[@name="IGattWriteRequest.RespondWithProtocolError"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT RespondWithProtocolError(byte protocolError)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattWriteRequest*, byte, int>)(lpVtbl[13]))((IGattWriteRequest*)Unsafe.AsPointer(ref this), protocolError);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Value([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value);

        [VtblIndex(7)]
        HRESULT get_Offset([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(8)]
        HRESULT get_Option([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattWriteOption *")] GattWriteOption* value);

        [VtblIndex(9)]
        HRESULT get_State([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattRequestState *")] GattRequestState* value);

        [VtblIndex(10)]
        HRESULT add_StateChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattWriteRequest_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattRequestStateChangedEventArgs_t *")] ITypedEventHandler<Pointer<IGattWriteRequest>, Pointer<IGattRequestStateChangedEventArgs>>* handler, EventRegistrationToken* token);

        [VtblIndex(11)]
        HRESULT remove_StateChanged(EventRegistrationToken token);

        [VtblIndex(12)]
        HRESULT Respond();

        [VtblIndex(13)]
        HRESULT RespondWithProtocolError(byte protocolError);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer**, int> get_Value;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_Offset;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattWriteOption *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, GattWriteOption*, int> get_Option;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattRequestState *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, GattRequestState*, int> get_State;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattWriteRequest_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattRequestStateChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IGattWriteRequest>, Pointer<IGattRequestStateChangedEventArgs>>*, EventRegistrationToken*, int> add_StateChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_StateChanged;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Respond;

        [NativeTypeName("HRESULT (BYTE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> RespondWithProtocolError;
    }
}
