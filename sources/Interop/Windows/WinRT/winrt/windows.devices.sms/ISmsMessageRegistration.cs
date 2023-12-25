// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sms.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISmsMessageRegistration.xml' path='doc/member[@name="ISmsMessageRegistration"]/*' />
[Guid("1720503E-F34F-446B-83B3-0FF19923B409")]
[NativeTypeName("struct ISmsMessageRegistration : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmsMessageRegistration : ISmsMessageRegistration.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmsMessageRegistration));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsMessageRegistration*, Guid*, void**, int>)(lpVtbl[0]))((ISmsMessageRegistration*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsMessageRegistration*, uint>)(lpVtbl[1]))((ISmsMessageRegistration*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsMessageRegistration*, uint>)(lpVtbl[2]))((ISmsMessageRegistration*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsMessageRegistration*, uint*, Guid**, int>)(lpVtbl[3]))((ISmsMessageRegistration*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsMessageRegistration*, HSTRING*, int>)(lpVtbl[4]))((ISmsMessageRegistration*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsMessageRegistration*, TrustLevel*, int>)(lpVtbl[5]))((ISmsMessageRegistration*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISmsMessageRegistration.xml' path='doc/member[@name="ISmsMessageRegistration.get_Id"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Id(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsMessageRegistration*, HSTRING*, int>)(lpVtbl[6]))((ISmsMessageRegistration*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmsMessageRegistration.xml' path='doc/member[@name="ISmsMessageRegistration.Unregister"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Unregister()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsMessageRegistration*, int>)(lpVtbl[7]))((ISmsMessageRegistration*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISmsMessageRegistration.xml' path='doc/member[@name="ISmsMessageRegistration.add_MessageReceived"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_MessageReceived([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CSms__CSmsMessageRegistration_Windows__CDevices__CSms__CSmsMessageReceivedTriggerDetails_t *")] ITypedEventHandler<IntPtr, IntPtr>* eventHandler, EventRegistrationToken* eventCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsMessageRegistration*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[8]))((ISmsMessageRegistration*)Unsafe.AsPointer(ref this), eventHandler, eventCookie);
    }

    /// <include file='ISmsMessageRegistration.xml' path='doc/member[@name="ISmsMessageRegistration.remove_MessageReceived"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_MessageReceived(EventRegistrationToken eventCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmsMessageRegistration*, EventRegistrationToken, int>)(lpVtbl[9]))((ISmsMessageRegistration*)Unsafe.AsPointer(ref this), eventCookie);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Id(HSTRING* value);

        [VtblIndex(7)]
        HRESULT Unregister();

        [VtblIndex(8)]
        HRESULT add_MessageReceived([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CSms__CSmsMessageRegistration_Windows__CDevices__CSms__CSmsMessageReceivedTriggerDetails_t *")] ITypedEventHandler<IntPtr, IntPtr>* eventHandler, EventRegistrationToken* eventCookie);

        [VtblIndex(9)]
        HRESULT remove_MessageReceived(EventRegistrationToken eventCookie);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Id;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Unregister;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CSms__CSmsMessageRegistration_Windows__CDevices__CSms__CSmsMessageReceivedTriggerDetails_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_MessageReceived;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_MessageReceived;
    }
}
