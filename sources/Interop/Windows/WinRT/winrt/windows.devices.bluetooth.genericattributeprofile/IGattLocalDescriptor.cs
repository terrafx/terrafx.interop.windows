// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.genericattributeprofile.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGattLocalDescriptor.xml' path='doc/member[@name="IGattLocalDescriptor"]/*' />
[Guid("F48EBE06-789D-4A4B-8652-BD017B5D2FC6")]
[NativeTypeName("struct IGattLocalDescriptor : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGattLocalDescriptor : IGattLocalDescriptor.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGattLocalDescriptor));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalDescriptor*, Guid*, void**, int>)(lpVtbl[0]))((IGattLocalDescriptor*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalDescriptor*, uint>)(lpVtbl[1]))((IGattLocalDescriptor*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalDescriptor*, uint>)(lpVtbl[2]))((IGattLocalDescriptor*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalDescriptor*, uint*, Guid**, int>)(lpVtbl[3]))((IGattLocalDescriptor*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalDescriptor*, HSTRING*, int>)(lpVtbl[4]))((IGattLocalDescriptor*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalDescriptor*, TrustLevel*, int>)(lpVtbl[5]))((IGattLocalDescriptor*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGattLocalDescriptor.xml' path='doc/member[@name="IGattLocalDescriptor.get_Uuid"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Uuid(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalDescriptor*, Guid*, int>)(lpVtbl[6]))((IGattLocalDescriptor*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattLocalDescriptor.xml' path='doc/member[@name="IGattLocalDescriptor.get_StaticValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_StaticValue([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalDescriptor*, IBuffer**, int>)(lpVtbl[7]))((IGattLocalDescriptor*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattLocalDescriptor.xml' path='doc/member[@name="IGattLocalDescriptor.get_ReadProtectionLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ReadProtectionLevel([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel *")] GattProtectionLevel* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalDescriptor*, GattProtectionLevel*, int>)(lpVtbl[8]))((IGattLocalDescriptor*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattLocalDescriptor.xml' path='doc/member[@name="IGattLocalDescriptor.get_WriteProtectionLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_WriteProtectionLevel([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel *")] GattProtectionLevel* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalDescriptor*, GattProtectionLevel*, int>)(lpVtbl[9]))((IGattLocalDescriptor*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattLocalDescriptor.xml' path='doc/member[@name="IGattLocalDescriptor.add_ReadRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_ReadRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattLocalDescriptor_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattReadRequestedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalDescriptor*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[10]))((IGattLocalDescriptor*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IGattLocalDescriptor.xml' path='doc/member[@name="IGattLocalDescriptor.remove_ReadRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_ReadRequested(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalDescriptor*, EventRegistrationToken, int>)(lpVtbl[11]))((IGattLocalDescriptor*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IGattLocalDescriptor.xml' path='doc/member[@name="IGattLocalDescriptor.add_WriteRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT add_WriteRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattLocalDescriptor_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattWriteRequestedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalDescriptor*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[12]))((IGattLocalDescriptor*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IGattLocalDescriptor.xml' path='doc/member[@name="IGattLocalDescriptor.remove_WriteRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT remove_WriteRequested(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattLocalDescriptor*, EventRegistrationToken, int>)(lpVtbl[13]))((IGattLocalDescriptor*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Uuid(Guid* value);

        [VtblIndex(7)]
        HRESULT get_StaticValue([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value);

        [VtblIndex(8)]
        HRESULT get_ReadProtectionLevel([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel *")] GattProtectionLevel* value);

        [VtblIndex(9)]
        HRESULT get_WriteProtectionLevel([NativeTypeName("ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel *")] GattProtectionLevel* value);

        [VtblIndex(10)]
        HRESULT add_ReadRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattLocalDescriptor_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattReadRequestedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(11)]
        HRESULT remove_ReadRequested(EventRegistrationToken token);

        [VtblIndex(12)]
        HRESULT add_WriteRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattLocalDescriptor_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattWriteRequestedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(13)]
        HRESULT remove_WriteRequested(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_Uuid;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer**, int> get_StaticValue;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, GattProtectionLevel*, int> get_ReadProtectionLevel;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, GattProtectionLevel*, int> get_WriteProtectionLevel;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattLocalDescriptor_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattReadRequestedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_ReadRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ReadRequested;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattLocalDescriptor_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattWriteRequestedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_WriteRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_WriteRequested;
    }
}
