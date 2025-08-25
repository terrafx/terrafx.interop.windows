// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IVoipCallCoordinator5.xml' path='doc/member[@name="IVoipCallCoordinator5"]/*' />
[Guid("D4F79017-D1C1-5820-955E-7A1676355D00")]
[NativeTypeName("struct IVoipCallCoordinator5 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IVoipCallCoordinator5 : IVoipCallCoordinator5.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IVoipCallCoordinator5);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipCallCoordinator5*, Guid*, void**, int>)(lpVtbl[0]))((IVoipCallCoordinator5*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipCallCoordinator5*, uint>)(lpVtbl[1]))((IVoipCallCoordinator5*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipCallCoordinator5*, uint>)(lpVtbl[2]))((IVoipCallCoordinator5*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipCallCoordinator5*, uint*, Guid**, int>)(lpVtbl[3]))((IVoipCallCoordinator5*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipCallCoordinator5*, HSTRING*, int>)(lpVtbl[4]))((IVoipCallCoordinator5*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipCallCoordinator5*, TrustLevel*, int>)(lpVtbl[5]))((IVoipCallCoordinator5*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IVoipCallCoordinator5.xml' path='doc/member[@name="IVoipCallCoordinator5.RequestNewIncomingCallWithOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RequestNewIncomingCallWithOptions([NativeTypeName("ABI::Windows::ApplicationModel::Calls::IIncomingVoipPhoneCallOptions *")] IIncomingVoipPhoneCallOptions* callOptions, [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IVoipPhoneCall **")] IVoipPhoneCall** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipCallCoordinator5*, IIncomingVoipPhoneCallOptions*, IVoipPhoneCall**, int>)(lpVtbl[6]))((IVoipCallCoordinator5*)Unsafe.AsPointer(ref this), callOptions, result);
    }

    /// <include file='IVoipCallCoordinator5.xml' path='doc/member[@name="IVoipCallCoordinator5.RequestNewOutgoingCallWithOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RequestNewOutgoingCallWithOptions([NativeTypeName("ABI::Windows::ApplicationModel::Calls::IOutgoingVoipPhoneCallOptions *")] IOutgoingVoipPhoneCallOptions* callOptions, [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IVoipPhoneCall **")] IVoipPhoneCall** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipCallCoordinator5*, IOutgoingVoipPhoneCallOptions*, IVoipPhoneCall**, int>)(lpVtbl[7]))((IVoipCallCoordinator5*)Unsafe.AsPointer(ref this), callOptions, result);
    }

    /// <include file='IVoipCallCoordinator5.xml' path='doc/member[@name="IVoipCallCoordinator5.SetupNewAcceptedCallWithOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetupNewAcceptedCallWithOptions([NativeTypeName("ABI::Windows::ApplicationModel::Calls::IAcceptedVoipPhoneCallOptions *")] IAcceptedVoipPhoneCallOptions* callOptions, [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IVoipPhoneCall **")] IVoipPhoneCall** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipCallCoordinator5*, IAcceptedVoipPhoneCallOptions*, IVoipPhoneCall**, int>)(lpVtbl[8]))((IVoipCallCoordinator5*)Unsafe.AsPointer(ref this), callOptions, result);
    }

    /// <include file='IVoipCallCoordinator5.xml' path='doc/member[@name="IVoipCallCoordinator5.RequestNewAppInitiatedCallWithOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RequestNewAppInitiatedCallWithOptions([NativeTypeName("ABI::Windows::ApplicationModel::Calls::IAppInitiatedVoipPhoneCallOptions *")] IAppInitiatedVoipPhoneCallOptions* callOptions, [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IVoipPhoneCall **")] IVoipPhoneCall** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IVoipCallCoordinator5*, IAppInitiatedVoipPhoneCallOptions*, IVoipPhoneCall**, int>)(lpVtbl[9]))((IVoipCallCoordinator5*)Unsafe.AsPointer(ref this), callOptions, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT RequestNewIncomingCallWithOptions([NativeTypeName("ABI::Windows::ApplicationModel::Calls::IIncomingVoipPhoneCallOptions *")] IIncomingVoipPhoneCallOptions* callOptions, [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IVoipPhoneCall **")] IVoipPhoneCall** result);

        [VtblIndex(7)]
        HRESULT RequestNewOutgoingCallWithOptions([NativeTypeName("ABI::Windows::ApplicationModel::Calls::IOutgoingVoipPhoneCallOptions *")] IOutgoingVoipPhoneCallOptions* callOptions, [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IVoipPhoneCall **")] IVoipPhoneCall** result);

        [VtblIndex(8)]
        HRESULT SetupNewAcceptedCallWithOptions([NativeTypeName("ABI::Windows::ApplicationModel::Calls::IAcceptedVoipPhoneCallOptions *")] IAcceptedVoipPhoneCallOptions* callOptions, [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IVoipPhoneCall **")] IVoipPhoneCall** result);

        [VtblIndex(9)]
        HRESULT RequestNewAppInitiatedCallWithOptions([NativeTypeName("ABI::Windows::ApplicationModel::Calls::IAppInitiatedVoipPhoneCallOptions *")] IAppInitiatedVoipPhoneCallOptions* callOptions, [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IVoipPhoneCall **")] IVoipPhoneCall** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::IIncomingVoipPhoneCallOptions *, ABI::Windows::ApplicationModel::Calls::IVoipPhoneCall **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIncomingVoipPhoneCallOptions*, IVoipPhoneCall**, int> RequestNewIncomingCallWithOptions;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::IOutgoingVoipPhoneCallOptions *, ABI::Windows::ApplicationModel::Calls::IVoipPhoneCall **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IOutgoingVoipPhoneCallOptions*, IVoipPhoneCall**, int> RequestNewOutgoingCallWithOptions;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::IAcceptedVoipPhoneCallOptions *, ABI::Windows::ApplicationModel::Calls::IVoipPhoneCall **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAcceptedVoipPhoneCallOptions*, IVoipPhoneCall**, int> SetupNewAcceptedCallWithOptions;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::IAppInitiatedVoipPhoneCallOptions *, ABI::Windows::ApplicationModel::Calls::IVoipPhoneCall **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppInitiatedVoipPhoneCallOptions*, IVoipPhoneCall**, int> RequestNewAppInitiatedCallWithOptions;
    }
}
