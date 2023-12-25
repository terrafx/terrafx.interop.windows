// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISmartCardReader.xml' path='doc/member[@name="ISmartCardReader"]/*' />
[Guid("1074B4E0-54C2-4DF0-817A-14C14378F06C")]
[NativeTypeName("struct ISmartCardReader : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmartCardReader : ISmartCardReader.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmartCardReader));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardReader*, Guid*, void**, int>)(lpVtbl[0]))((ISmartCardReader*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardReader*, uint>)(lpVtbl[1]))((ISmartCardReader*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardReader*, uint>)(lpVtbl[2]))((ISmartCardReader*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardReader*, uint*, Guid**, int>)(lpVtbl[3]))((ISmartCardReader*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardReader*, HSTRING*, int>)(lpVtbl[4]))((ISmartCardReader*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardReader*, TrustLevel*, int>)(lpVtbl[5]))((ISmartCardReader*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISmartCardReader.xml' path='doc/member[@name="ISmartCardReader.get_DeviceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DeviceId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardReader*, HSTRING*, int>)(lpVtbl[6]))((ISmartCardReader*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardReader.xml' path='doc/member[@name="ISmartCardReader.get_Name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Name(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardReader*, HSTRING*, int>)(lpVtbl[7]))((ISmartCardReader*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardReader.xml' path='doc/member[@name="ISmartCardReader.get_Kind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Kind([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardReaderKind *")] SmartCardReaderKind* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardReader*, SmartCardReaderKind*, int>)(lpVtbl[8]))((ISmartCardReader*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardReader.xml' path='doc/member[@name="ISmartCardReader.GetStatusAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetStatusAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardReaderStatus_t **")] IAsyncOperation<SmartCardReaderStatus>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardReader*, IAsyncOperation<SmartCardReaderStatus>**, int>)(lpVtbl[9]))((ISmartCardReader*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ISmartCardReader.xml' path='doc/member[@name="ISmartCardReader.FindAllCardsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT FindAllCardsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCard_t **")] IAsyncOperation<IntPtr>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardReader*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[10]))((ISmartCardReader*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ISmartCardReader.xml' path='doc/member[@name="ISmartCardReader.add_CardAdded"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT add_CardAdded([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CSmartCards__CSmartCardReader_Windows__CDevices__CSmartCards__CCardAddedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardReader*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[11]))((ISmartCardReader*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ISmartCardReader.xml' path='doc/member[@name="ISmartCardReader.remove_CardAdded"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT remove_CardAdded(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardReader*, EventRegistrationToken, int>)(lpVtbl[12]))((ISmartCardReader*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='ISmartCardReader.xml' path='doc/member[@name="ISmartCardReader.add_CardRemoved"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT add_CardRemoved([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CSmartCards__CSmartCardReader_Windows__CDevices__CSmartCards__CCardRemovedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardReader*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[13]))((ISmartCardReader*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='ISmartCardReader.xml' path='doc/member[@name="ISmartCardReader.remove_CardRemoved"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT remove_CardRemoved(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardReader*, EventRegistrationToken, int>)(lpVtbl[14]))((ISmartCardReader*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DeviceId(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_Name(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_Kind([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardReaderKind *")] SmartCardReaderKind* value);

        [VtblIndex(9)]
        HRESULT GetStatusAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardReaderStatus_t **")] IAsyncOperation<SmartCardReaderStatus>** result);

        [VtblIndex(10)]
        HRESULT FindAllCardsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCard_t **")] IAsyncOperation<IntPtr>** result);

        [VtblIndex(11)]
        HRESULT add_CardAdded([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CSmartCards__CSmartCardReader_Windows__CDevices__CSmartCards__CCardAddedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(12)]
        HRESULT remove_CardAdded(EventRegistrationToken token);

        [VtblIndex(13)]
        HRESULT add_CardRemoved([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CSmartCards__CSmartCardReader_Windows__CDevices__CSmartCards__CCardRemovedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, EventRegistrationToken* token);

        [VtblIndex(14)]
        HRESULT remove_CardRemoved(EventRegistrationToken token);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DeviceId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Name;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::SmartCards::SmartCardReaderKind *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmartCardReaderKind*, int> get_Kind;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardReaderStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<SmartCardReaderStatus>**, int> GetStatusAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCard_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<IntPtr>**, int> FindAllCardsAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CSmartCards__CSmartCardReader_Windows__CDevices__CSmartCards__CCardAddedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_CardAdded;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_CardAdded;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CSmartCards__CSmartCardReader_Windows__CDevices__CSmartCards__CCardRemovedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_CardRemoved;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_CardRemoved;
    }
}
