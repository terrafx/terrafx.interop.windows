// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISmartCardTriggerDetails2.xml' path='doc/member[@name="ISmartCardTriggerDetails2"]/*' />
[Guid("2945C569-8975-4A51-9E1A-5F8A76EE51AF")]
[NativeTypeName("struct ISmartCardTriggerDetails2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmartCardTriggerDetails2 : ISmartCardTriggerDetails2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ISmartCardTriggerDetails2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardTriggerDetails2*, Guid*, void**, int>)(lpVtbl[0]))((ISmartCardTriggerDetails2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardTriggerDetails2*, uint>)(lpVtbl[1]))((ISmartCardTriggerDetails2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardTriggerDetails2*, uint>)(lpVtbl[2]))((ISmartCardTriggerDetails2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardTriggerDetails2*, uint*, Guid**, int>)(lpVtbl[3]))((ISmartCardTriggerDetails2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardTriggerDetails2*, HSTRING*, int>)(lpVtbl[4]))((ISmartCardTriggerDetails2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardTriggerDetails2*, TrustLevel*, int>)(lpVtbl[5]))((ISmartCardTriggerDetails2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISmartCardTriggerDetails2.xml' path='doc/member[@name="ISmartCardTriggerDetails2.get_Emulator"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Emulator([NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCardEmulator **")] ISmartCardEmulator** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardTriggerDetails2*, ISmartCardEmulator**, int>)(lpVtbl[6]))((ISmartCardTriggerDetails2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardTriggerDetails2.xml' path='doc/member[@name="ISmartCardTriggerDetails2.TryLaunchCurrentAppAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT TryLaunchCurrentAppAsync(HSTRING arguments, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardTriggerDetails2*, HSTRING, IAsyncOperation<bool>**, int>)(lpVtbl[7]))((ISmartCardTriggerDetails2*)Unsafe.AsPointer(ref this), arguments, result);
    }

    /// <include file='ISmartCardTriggerDetails2.xml' path='doc/member[@name="ISmartCardTriggerDetails2.TryLaunchCurrentAppWithBehaviorAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT TryLaunchCurrentAppWithBehaviorAsync(HSTRING arguments, [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardLaunchBehavior")] SmartCardLaunchBehavior behavior, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardTriggerDetails2*, HSTRING, SmartCardLaunchBehavior, IAsyncOperation<bool>**, int>)(lpVtbl[8]))((ISmartCardTriggerDetails2*)Unsafe.AsPointer(ref this), arguments, behavior, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Emulator([NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCardEmulator **")] ISmartCardEmulator** value);

        [VtblIndex(7)]
        HRESULT TryLaunchCurrentAppAsync(HSTRING arguments, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result);

        [VtblIndex(8)]
        HRESULT TryLaunchCurrentAppWithBehaviorAsync(HSTRING arguments, [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardLaunchBehavior")] SmartCardLaunchBehavior behavior, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::SmartCards::ISmartCardEmulator **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISmartCardEmulator**, int> get_Emulator;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<bool>**, int> TryLaunchCurrentAppAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Devices::SmartCards::SmartCardLaunchBehavior, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, SmartCardLaunchBehavior, IAsyncOperation<bool>**, int> TryLaunchCurrentAppWithBehaviorAsync;
    }
}
