// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISmartCardAppletIdGroupRegistration.xml' path='doc/member[@name="ISmartCardAppletIdGroupRegistration"]/*' />
[Guid("DF1208D1-31BB-5596-43B1-6D69A0257B3A")]
[NativeTypeName("struct ISmartCardAppletIdGroupRegistration : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmartCardAppletIdGroupRegistration : ISmartCardAppletIdGroupRegistration.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmartCardAppletIdGroupRegistration));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAppletIdGroupRegistration*, Guid*, void**, int>)(lpVtbl[0]))((ISmartCardAppletIdGroupRegistration*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAppletIdGroupRegistration*, uint>)(lpVtbl[1]))((ISmartCardAppletIdGroupRegistration*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAppletIdGroupRegistration*, uint>)(lpVtbl[2]))((ISmartCardAppletIdGroupRegistration*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAppletIdGroupRegistration*, uint*, Guid**, int>)(lpVtbl[3]))((ISmartCardAppletIdGroupRegistration*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAppletIdGroupRegistration*, HSTRING*, int>)(lpVtbl[4]))((ISmartCardAppletIdGroupRegistration*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAppletIdGroupRegistration*, TrustLevel*, int>)(lpVtbl[5]))((ISmartCardAppletIdGroupRegistration*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISmartCardAppletIdGroupRegistration.xml' path='doc/member[@name="ISmartCardAppletIdGroupRegistration.get_ActivationPolicy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ActivationPolicy([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardAppletIdGroupActivationPolicy *")] SmartCardAppletIdGroupActivationPolicy* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAppletIdGroupRegistration*, SmartCardAppletIdGroupActivationPolicy*, int>)(lpVtbl[6]))((ISmartCardAppletIdGroupRegistration*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardAppletIdGroupRegistration.xml' path='doc/member[@name="ISmartCardAppletIdGroupRegistration.get_AppletIdGroup"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_AppletIdGroup([NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCardAppletIdGroup **")] ISmartCardAppletIdGroup** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAppletIdGroupRegistration*, ISmartCardAppletIdGroup**, int>)(lpVtbl[7]))((ISmartCardAppletIdGroupRegistration*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardAppletIdGroupRegistration.xml' path='doc/member[@name="ISmartCardAppletIdGroupRegistration.RequestActivationPolicyChangeAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RequestActivationPolicyChangeAsync([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardAppletIdGroupActivationPolicy")] SmartCardAppletIdGroupActivationPolicy policy, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardActivationPolicyChangeResult_t **")] IAsyncOperation<SmartCardActivationPolicyChangeResult>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAppletIdGroupRegistration*, SmartCardAppletIdGroupActivationPolicy, IAsyncOperation<SmartCardActivationPolicyChangeResult>**, int>)(lpVtbl[8]))((ISmartCardAppletIdGroupRegistration*)Unsafe.AsPointer(ref this), policy, result);
    }

    /// <include file='ISmartCardAppletIdGroupRegistration.xml' path='doc/member[@name="ISmartCardAppletIdGroupRegistration.get_Id"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Id(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAppletIdGroupRegistration*, Guid*, int>)(lpVtbl[9]))((ISmartCardAppletIdGroupRegistration*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardAppletIdGroupRegistration.xml' path='doc/member[@name="ISmartCardAppletIdGroupRegistration.SetAutomaticResponseApdusAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetAutomaticResponseApdusAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CSmartCards__CSmartCardAutomaticResponseApdu_t *")] IIterable<IntPtr>* apdus, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAppletIdGroupRegistration*, IIterable<IntPtr>*, IAsyncAction**, int>)(lpVtbl[10]))((ISmartCardAppletIdGroupRegistration*)Unsafe.AsPointer(ref this), apdus, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ActivationPolicy([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardAppletIdGroupActivationPolicy *")] SmartCardAppletIdGroupActivationPolicy* value);

        [VtblIndex(7)]
        HRESULT get_AppletIdGroup([NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCardAppletIdGroup **")] ISmartCardAppletIdGroup** value);

        [VtblIndex(8)]
        HRESULT RequestActivationPolicyChangeAsync([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardAppletIdGroupActivationPolicy")] SmartCardAppletIdGroupActivationPolicy policy, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardActivationPolicyChangeResult_t **")] IAsyncOperation<SmartCardActivationPolicyChangeResult>** result);

        [VtblIndex(9)]
        HRESULT get_Id(Guid* value);

        [VtblIndex(10)]
        HRESULT SetAutomaticResponseApdusAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CSmartCards__CSmartCardAutomaticResponseApdu_t *")] IIterable<IntPtr>* apdus, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::SmartCards::SmartCardAppletIdGroupActivationPolicy *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmartCardAppletIdGroupActivationPolicy*, int> get_ActivationPolicy;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::SmartCards::ISmartCardAppletIdGroup **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISmartCardAppletIdGroup**, int> get_AppletIdGroup;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::SmartCards::SmartCardAppletIdGroupActivationPolicy, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardActivationPolicyChangeResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmartCardAppletIdGroupActivationPolicy, IAsyncOperation<SmartCardActivationPolicyChangeResult>**, int> RequestActivationPolicyChangeAsync;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_Id;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CSmartCards__CSmartCardAutomaticResponseApdu_t *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<IntPtr>*, IAsyncAction**, int> SetAutomaticResponseApdusAsync;
    }
}
