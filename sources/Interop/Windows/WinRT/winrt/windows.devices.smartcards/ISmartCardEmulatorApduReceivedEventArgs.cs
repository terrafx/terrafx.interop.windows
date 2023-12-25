// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISmartCardEmulatorApduReceivedEventArgs.xml' path='doc/member[@name="ISmartCardEmulatorApduReceivedEventArgs"]/*' />
[Guid("D55D1576-69D2-5333-5B5F-F8C0D6E9F09F")]
[NativeTypeName("struct ISmartCardEmulatorApduReceivedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmartCardEmulatorApduReceivedEventArgs : ISmartCardEmulatorApduReceivedEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmartCardEmulatorApduReceivedEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardEmulatorApduReceivedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((ISmartCardEmulatorApduReceivedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardEmulatorApduReceivedEventArgs*, uint>)(lpVtbl[1]))((ISmartCardEmulatorApduReceivedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardEmulatorApduReceivedEventArgs*, uint>)(lpVtbl[2]))((ISmartCardEmulatorApduReceivedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardEmulatorApduReceivedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((ISmartCardEmulatorApduReceivedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardEmulatorApduReceivedEventArgs*, HSTRING*, int>)(lpVtbl[4]))((ISmartCardEmulatorApduReceivedEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardEmulatorApduReceivedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((ISmartCardEmulatorApduReceivedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISmartCardEmulatorApduReceivedEventArgs.xml' path='doc/member[@name="ISmartCardEmulatorApduReceivedEventArgs.get_CommandApdu"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CommandApdu([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardEmulatorApduReceivedEventArgs*, IBuffer**, int>)(lpVtbl[6]))((ISmartCardEmulatorApduReceivedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardEmulatorApduReceivedEventArgs.xml' path='doc/member[@name="ISmartCardEmulatorApduReceivedEventArgs.get_ConnectionProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ConnectionProperties([NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCardEmulatorConnectionProperties **")] ISmartCardEmulatorConnectionProperties** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardEmulatorApduReceivedEventArgs*, ISmartCardEmulatorConnectionProperties**, int>)(lpVtbl[7]))((ISmartCardEmulatorApduReceivedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardEmulatorApduReceivedEventArgs.xml' path='doc/member[@name="ISmartCardEmulatorApduReceivedEventArgs.TryRespondAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT TryRespondAsync([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* responseApdu, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardEmulatorApduReceivedEventArgs*, IBuffer*, IAsyncOperation<bool>**, int>)(lpVtbl[8]))((ISmartCardEmulatorApduReceivedEventArgs*)Unsafe.AsPointer(ref this), responseApdu, result);
    }

    /// <include file='ISmartCardEmulatorApduReceivedEventArgs.xml' path='doc/member[@name="ISmartCardEmulatorApduReceivedEventArgs.get_AutomaticResponseStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_AutomaticResponseStatus([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardAutomaticResponseStatus *")] SmartCardAutomaticResponseStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardEmulatorApduReceivedEventArgs*, SmartCardAutomaticResponseStatus*, int>)(lpVtbl[9]))((ISmartCardEmulatorApduReceivedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_CommandApdu([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value);

        [VtblIndex(7)]
        HRESULT get_ConnectionProperties([NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCardEmulatorConnectionProperties **")] ISmartCardEmulatorConnectionProperties** value);

        [VtblIndex(8)]
        HRESULT TryRespondAsync([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* responseApdu, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result);

        [VtblIndex(9)]
        HRESULT get_AutomaticResponseStatus([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardAutomaticResponseStatus *")] SmartCardAutomaticResponseStatus* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer**, int> get_CommandApdu;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::SmartCards::ISmartCardEmulatorConnectionProperties **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISmartCardEmulatorConnectionProperties**, int> get_ConnectionProperties;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, IAsyncOperation<bool>**, int> TryRespondAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::SmartCards::SmartCardAutomaticResponseStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmartCardAutomaticResponseStatus*, int> get_AutomaticResponseStatus;
    }
}
