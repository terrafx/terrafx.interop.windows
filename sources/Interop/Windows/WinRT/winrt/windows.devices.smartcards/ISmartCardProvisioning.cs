// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISmartCardProvisioning.xml' path='doc/member[@name="ISmartCardProvisioning"]/*' />
[Guid("19EEEDBD-1FAB-477C-B712-1A2C5AF1FD6E")]
[NativeTypeName("struct ISmartCardProvisioning : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmartCardProvisioning : ISmartCardProvisioning.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ISmartCardProvisioning);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardProvisioning*, Guid*, void**, int>)(lpVtbl[0]))((ISmartCardProvisioning*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardProvisioning*, uint>)(lpVtbl[1]))((ISmartCardProvisioning*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardProvisioning*, uint>)(lpVtbl[2]))((ISmartCardProvisioning*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardProvisioning*, uint*, Guid**, int>)(lpVtbl[3]))((ISmartCardProvisioning*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardProvisioning*, HSTRING*, int>)(lpVtbl[4]))((ISmartCardProvisioning*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardProvisioning*, TrustLevel*, int>)(lpVtbl[5]))((ISmartCardProvisioning*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISmartCardProvisioning.xml' path='doc/member[@name="ISmartCardProvisioning.get_SmartCard"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SmartCard([NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCard **")] ISmartCard** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardProvisioning*, ISmartCard**, int>)(lpVtbl[6]))((ISmartCardProvisioning*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardProvisioning.xml' path='doc/member[@name="ISmartCardProvisioning.GetIdAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetIdAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_GUID_t **")] IAsyncOperation<Guid>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardProvisioning*, IAsyncOperation<Guid>**, int>)(lpVtbl[7]))((ISmartCardProvisioning*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ISmartCardProvisioning.xml' path='doc/member[@name="ISmartCardProvisioning.GetNameAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetNameAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardProvisioning*, IAsyncOperation<HSTRING>**, int>)(lpVtbl[8]))((ISmartCardProvisioning*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ISmartCardProvisioning.xml' path='doc/member[@name="ISmartCardProvisioning.GetChallengeContextAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetChallengeContextAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardChallengeContext_t **")] IAsyncOperation<Pointer<ISmartCardChallengeContext>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardProvisioning*, IAsyncOperation<Pointer<ISmartCardChallengeContext>>**, int>)(lpVtbl[9]))((ISmartCardProvisioning*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ISmartCardProvisioning.xml' path='doc/member[@name="ISmartCardProvisioning.RequestPinChangeAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT RequestPinChangeAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardProvisioning*, IAsyncOperation<bool>**, int>)(lpVtbl[10]))((ISmartCardProvisioning*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ISmartCardProvisioning.xml' path='doc/member[@name="ISmartCardProvisioning.RequestPinResetAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT RequestPinResetAsync([NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCardPinResetHandler *")] ISmartCardPinResetHandler* handler, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardProvisioning*, ISmartCardPinResetHandler*, IAsyncOperation<bool>**, int>)(lpVtbl[11]))((ISmartCardProvisioning*)Unsafe.AsPointer(ref this), handler, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SmartCard([NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCard **")] ISmartCard** value);

        [VtblIndex(7)]
        HRESULT GetIdAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_GUID_t **")] IAsyncOperation<Guid>** result);

        [VtblIndex(8)]
        HRESULT GetNameAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")] IAsyncOperation<HSTRING>** result);

        [VtblIndex(9)]
        HRESULT GetChallengeContextAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardChallengeContext_t **")] IAsyncOperation<Pointer<ISmartCardChallengeContext>>** result);

        [VtblIndex(10)]
        HRESULT RequestPinChangeAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result);

        [VtblIndex(11)]
        HRESULT RequestPinResetAsync([NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCardPinResetHandler *")] ISmartCardPinResetHandler* handler, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::SmartCards::ISmartCard **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISmartCard**, int> get_SmartCard;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_GUID_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Guid>**, int> GetIdAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<HSTRING>**, int> GetNameAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardChallengeContext_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<ISmartCardChallengeContext>>**, int> GetChallengeContextAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<bool>**, int> RequestPinChangeAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::SmartCards::ISmartCardPinResetHandler *, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISmartCardPinResetHandler*, IAsyncOperation<bool>**, int> RequestPinResetAsync;
    }
}
