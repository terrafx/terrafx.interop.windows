// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISmartCardEmulator2.xml' path='doc/member[@name="ISmartCardEmulator2"]/*' />
[Guid("FE3FC0B8-8529-411A-807B-48EDC2A0AB44")]
[NativeTypeName("struct ISmartCardEmulator2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmartCardEmulator2 : ISmartCardEmulator2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmartCardEmulator2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardEmulator2*, Guid*, void**, int>)(lpVtbl[0]))((ISmartCardEmulator2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardEmulator2*, uint>)(lpVtbl[1]))((ISmartCardEmulator2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardEmulator2*, uint>)(lpVtbl[2]))((ISmartCardEmulator2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardEmulator2*, uint*, Guid**, int>)(lpVtbl[3]))((ISmartCardEmulator2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardEmulator2*, HSTRING*, int>)(lpVtbl[4]))((ISmartCardEmulator2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardEmulator2*, TrustLevel*, int>)(lpVtbl[5]))((ISmartCardEmulator2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISmartCardEmulator2.xml' path='doc/member[@name="ISmartCardEmulator2.add_ApduReceived"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_ApduReceived([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CSmartCards__CSmartCardEmulator_Windows__CDevices__CSmartCards__CSmartCardEmulatorApduReceivedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* value, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardEmulator2*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[6]))((ISmartCardEmulator2*)Unsafe.AsPointer(ref this), value, token);
    }

    /// <include file='ISmartCardEmulator2.xml' path='doc/member[@name="ISmartCardEmulator2.remove_ApduReceived"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_ApduReceived(EventRegistrationToken value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardEmulator2*, EventRegistrationToken, int>)(lpVtbl[7]))((ISmartCardEmulator2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardEmulator2.xml' path='doc/member[@name="ISmartCardEmulator2.add_ConnectionDeactivated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_ConnectionDeactivated([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CSmartCards__CSmartCardEmulator_Windows__CDevices__CSmartCards__CSmartCardEmulatorConnectionDeactivatedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* value, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardEmulator2*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[8]))((ISmartCardEmulator2*)Unsafe.AsPointer(ref this), value, token);
    }

    /// <include file='ISmartCardEmulator2.xml' path='doc/member[@name="ISmartCardEmulator2.remove_ConnectionDeactivated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_ConnectionDeactivated(EventRegistrationToken value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardEmulator2*, EventRegistrationToken, int>)(lpVtbl[9]))((ISmartCardEmulator2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardEmulator2.xml' path='doc/member[@name="ISmartCardEmulator2.Start"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Start()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardEmulator2*, int>)(lpVtbl[10]))((ISmartCardEmulator2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISmartCardEmulator2.xml' path='doc/member[@name="ISmartCardEmulator2.IsHostCardEmulationSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT IsHostCardEmulationSupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardEmulator2*, byte*, int>)(lpVtbl[11]))((ISmartCardEmulator2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_ApduReceived([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CSmartCards__CSmartCardEmulator_Windows__CDevices__CSmartCards__CSmartCardEmulatorApduReceivedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* value, EventRegistrationToken* token);

        [VtblIndex(7)]
        HRESULT remove_ApduReceived(EventRegistrationToken value);

        [VtblIndex(8)]
        HRESULT add_ConnectionDeactivated([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CSmartCards__CSmartCardEmulator_Windows__CDevices__CSmartCards__CSmartCardEmulatorConnectionDeactivatedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* value, EventRegistrationToken* token);

        [VtblIndex(9)]
        HRESULT remove_ConnectionDeactivated(EventRegistrationToken value);

        [VtblIndex(10)]
        HRESULT Start();

        [VtblIndex(11)]
        HRESULT IsHostCardEmulationSupported([NativeTypeName("boolean *")] byte* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CSmartCards__CSmartCardEmulator_Windows__CDevices__CSmartCards__CSmartCardEmulatorApduReceivedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_ApduReceived;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ApduReceived;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CSmartCards__CSmartCardEmulator_Windows__CDevices__CSmartCards__CSmartCardEmulatorConnectionDeactivatedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_ConnectionDeactivated;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ConnectionDeactivated;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Start;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> IsHostCardEmulationSupported;
    }
}
