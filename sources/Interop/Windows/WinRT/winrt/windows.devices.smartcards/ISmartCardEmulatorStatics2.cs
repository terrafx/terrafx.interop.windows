// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISmartCardEmulatorStatics2.xml' path='doc/member[@name="ISmartCardEmulatorStatics2"]/*' />
[Guid("69AE9F8A-B775-488B-8436-6C1E28ED731F")]
[NativeTypeName("struct ISmartCardEmulatorStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmartCardEmulatorStatics2 : ISmartCardEmulatorStatics2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmartCardEmulatorStatics2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardEmulatorStatics2*, Guid*, void**, int>)(lpVtbl[0]))((ISmartCardEmulatorStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardEmulatorStatics2*, uint>)(lpVtbl[1]))((ISmartCardEmulatorStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardEmulatorStatics2*, uint>)(lpVtbl[2]))((ISmartCardEmulatorStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardEmulatorStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((ISmartCardEmulatorStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardEmulatorStatics2*, HSTRING*, int>)(lpVtbl[4]))((ISmartCardEmulatorStatics2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardEmulatorStatics2*, TrustLevel*, int>)(lpVtbl[5]))((ISmartCardEmulatorStatics2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISmartCardEmulatorStatics2.xml' path='doc/member[@name="ISmartCardEmulatorStatics2.GetAppletIdGroupRegistrationsAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetAppletIdGroupRegistrationsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardAppletIdGroupRegistration_t **")] IAsyncOperation<IntPtr>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardEmulatorStatics2*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[6]))((ISmartCardEmulatorStatics2*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='ISmartCardEmulatorStatics2.xml' path='doc/member[@name="ISmartCardEmulatorStatics2.RegisterAppletIdGroupAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RegisterAppletIdGroupAsync([NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCardAppletIdGroup *")] ISmartCardAppletIdGroup* appletIdGroup, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardAppletIdGroupRegistration_t **")] IAsyncOperation<IntPtr>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardEmulatorStatics2*, ISmartCardAppletIdGroup*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[7]))((ISmartCardEmulatorStatics2*)Unsafe.AsPointer(ref this), appletIdGroup, result);
    }

    /// <include file='ISmartCardEmulatorStatics2.xml' path='doc/member[@name="ISmartCardEmulatorStatics2.UnregisterAppletIdGroupAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT UnregisterAppletIdGroupAsync([NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCardAppletIdGroupRegistration *")] ISmartCardAppletIdGroupRegistration* registration, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardEmulatorStatics2*, ISmartCardAppletIdGroupRegistration*, IAsyncAction**, int>)(lpVtbl[8]))((ISmartCardEmulatorStatics2*)Unsafe.AsPointer(ref this), registration, result);
    }

    /// <include file='ISmartCardEmulatorStatics2.xml' path='doc/member[@name="ISmartCardEmulatorStatics2.get_MaxAppletIdGroupRegistrations"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_MaxAppletIdGroupRegistrations([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardEmulatorStatics2*, ushort*, int>)(lpVtbl[9]))((ISmartCardEmulatorStatics2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetAppletIdGroupRegistrationsAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardAppletIdGroupRegistration_t **")] IAsyncOperation<IntPtr>** result);

        [VtblIndex(7)]
        HRESULT RegisterAppletIdGroupAsync([NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCardAppletIdGroup *")] ISmartCardAppletIdGroup* appletIdGroup, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardAppletIdGroupRegistration_t **")] IAsyncOperation<IntPtr>** result);

        [VtblIndex(8)]
        HRESULT UnregisterAppletIdGroupAsync([NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCardAppletIdGroupRegistration *")] ISmartCardAppletIdGroupRegistration* registration, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result);

        [VtblIndex(9)]
        HRESULT get_MaxAppletIdGroupRegistrations([NativeTypeName("UINT16 *")] ushort* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardAppletIdGroupRegistration_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<IntPtr>**, int> GetAppletIdGroupRegistrationsAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::SmartCards::ISmartCardAppletIdGroup *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardAppletIdGroupRegistration_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISmartCardAppletIdGroup*, IAsyncOperation<IntPtr>**, int> RegisterAppletIdGroupAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::SmartCards::ISmartCardAppletIdGroupRegistration *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISmartCardAppletIdGroupRegistration*, IAsyncAction**, int> UnregisterAppletIdGroupAsync;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort*, int> get_MaxAppletIdGroupRegistrations;
    }
}
