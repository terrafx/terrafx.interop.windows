// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.radios.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRadio.xml' path='doc/member[@name="IRadio"]/*' />
[Guid("252118DF-B33E-416A-875F-1CF38AE2D83E")]
[NativeTypeName("struct IRadio : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRadio : IRadio.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRadio));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadio*, Guid*, void**, int>)(lpVtbl[0]))((IRadio*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRadio*, uint>)(lpVtbl[1]))((IRadio*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRadio*, uint>)(lpVtbl[2]))((IRadio*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadio*, uint*, Guid**, int>)(lpVtbl[3]))((IRadio*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadio*, HSTRING*, int>)(lpVtbl[4]))((IRadio*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadio*, TrustLevel*, int>)(lpVtbl[5]))((IRadio*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IRadio.xml' path='doc/member[@name="IRadio.SetStateAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetStateAsync([NativeTypeName("ABI::Windows::Devices::Radios::RadioState")] RadioState value, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CRadios__CRadioAccessStatus_t **")] IAsyncOperation<RadioAccessStatus>** retval)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadio*, RadioState, IAsyncOperation<RadioAccessStatus>**, int>)(lpVtbl[6]))((IRadio*)Unsafe.AsPointer(ref this), value, retval);
    }

    /// <include file='IRadio.xml' path='doc/member[@name="IRadio.add_StateChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT add_StateChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CRadios__CRadio_IInspectable_t *")] ITypedEventHandler<Pointer<IRadio>, Pointer<IInspectable>>* handler, EventRegistrationToken* eventCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadio*, ITypedEventHandler<Pointer<IRadio>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[7]))((IRadio*)Unsafe.AsPointer(ref this), handler, eventCookie);
    }

    /// <include file='IRadio.xml' path='doc/member[@name="IRadio.remove_StateChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT remove_StateChanged(EventRegistrationToken eventCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadio*, EventRegistrationToken, int>)(lpVtbl[8]))((IRadio*)Unsafe.AsPointer(ref this), eventCookie);
    }

    /// <include file='IRadio.xml' path='doc/member[@name="IRadio.get_State"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_State([NativeTypeName("ABI::Windows::Devices::Radios::RadioState *")] RadioState* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadio*, RadioState*, int>)(lpVtbl[9]))((IRadio*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRadio.xml' path='doc/member[@name="IRadio.get_Name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Name(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadio*, HSTRING*, int>)(lpVtbl[10]))((IRadio*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRadio.xml' path='doc/member[@name="IRadio.get_Kind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Kind([NativeTypeName("ABI::Windows::Devices::Radios::RadioKind *")] RadioKind* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadio*, RadioKind*, int>)(lpVtbl[11]))((IRadio*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT SetStateAsync([NativeTypeName("ABI::Windows::Devices::Radios::RadioState")] RadioState value, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CRadios__CRadioAccessStatus_t **")] IAsyncOperation<RadioAccessStatus>** retval);

        [VtblIndex(7)]
        HRESULT add_StateChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CRadios__CRadio_IInspectable_t *")] ITypedEventHandler<Pointer<IRadio>, Pointer<IInspectable>>* handler, EventRegistrationToken* eventCookie);

        [VtblIndex(8)]
        HRESULT remove_StateChanged(EventRegistrationToken eventCookie);

        [VtblIndex(9)]
        HRESULT get_State([NativeTypeName("ABI::Windows::Devices::Radios::RadioState *")] RadioState* value);

        [VtblIndex(10)]
        HRESULT get_Name(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_Kind([NativeTypeName("ABI::Windows::Devices::Radios::RadioKind *")] RadioKind* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Radios::RadioState, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CRadios__CRadioAccessStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, RadioState, IAsyncOperation<RadioAccessStatus>**, int> SetStateAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CRadios__CRadio_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IRadio>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_StateChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_StateChanged;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Radios::RadioState *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, RadioState*, int> get_State;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Name;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Radios::RadioKind *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, RadioKind*, int> get_Kind;
    }
}
