// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.genericattributeprofile.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGattReadRequest.xml' path='doc/member[@name="IGattReadRequest"]/*' />
[Guid("F1DD6535-6ACD-42A6-A4BB-D789DAE0043E")]
[NativeTypeName("struct IGattReadRequest : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGattReadRequest : IGattReadRequest.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGattReadRequest));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattReadRequest*, Guid*, void**, int>)(lpVtbl[0]))((IGattReadRequest*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattReadRequest*, uint>)(lpVtbl[1]))((IGattReadRequest*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattReadRequest*, uint>)(lpVtbl[2]))((IGattReadRequest*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattReadRequest*, uint*, Guid**, int>)(lpVtbl[3]))((IGattReadRequest*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattReadRequest*, HSTRING*, int>)(lpVtbl[4]))((IGattReadRequest*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattReadRequest*, TrustLevel*, int>)(lpVtbl[5]))((IGattReadRequest*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGattReadRequest.xml' path='doc/member[@name="IGattReadRequest.get_Offset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Offset([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattReadRequest*, uint*, int>)(lpVtbl[6]))((IGattReadRequest*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattReadRequest.xml' path='doc/member[@name="IGattReadRequest.get_Length"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Length([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattReadRequest*, uint*, int>)(lpVtbl[7]))((IGattReadRequest*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattReadRequest.xml' path='doc/member[@name="IGattReadRequest.get_State"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_State([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattRequestState *")] GattRequestState* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattReadRequest*, GattRequestState*, int>)(lpVtbl[8]))((IGattReadRequest*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattReadRequest.xml' path='doc/member[@name="IGattReadRequest.add_StateChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT add_StateChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattReadRequest_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattRequestStateChangedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattReadRequest*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[9]))((IGattReadRequest*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IGattReadRequest.xml' path='doc/member[@name="IGattReadRequest.remove_StateChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT remove_StateChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattReadRequest*, EventRegistrationToken, int>)(lpVtbl[10]))((IGattReadRequest*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IGattReadRequest.xml' path='doc/member[@name="IGattReadRequest.RespondWithValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT RespondWithValue([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattReadRequest*, IBuffer*, int>)(lpVtbl[11]))((IGattReadRequest*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattReadRequest.xml' path='doc/member[@name="IGattReadRequest.RespondWithProtocolError"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT RespondWithProtocolError(byte protocolError)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattReadRequest*, byte, int>)(lpVtbl[12]))((IGattReadRequest*)Unsafe.AsPointer(ref this), protocolError);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Offset([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(7)]
        HRESULT get_Length([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(8)]
        HRESULT get_State([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattRequestState *")] GattRequestState* value);

        [VtblIndex(9)]
        HRESULT add_StateChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattReadRequest_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattRequestStateChangedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(10)]
        HRESULT remove_StateChanged(EventRegistrationToken token);

        [VtblIndex(11)]
        HRESULT RespondWithValue([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* value);

        [VtblIndex(12)]
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

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_Offset;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_Length;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattRequestState *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, GattRequestState*, int> get_State;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattReadRequest_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattRequestStateChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_StateChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_StateChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, int> RespondWithValue;

        [NativeTypeName("HRESULT (BYTE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> RespondWithProtocolError;
    }
}
