// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.power.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPowerGridForecastStatics.xml' path='doc/member[@name="IPowerGridForecastStatics"]/*' />
[Guid("5B78C806-2E4E-5BCC-BB34-CB81C60F9E12")]
[NativeTypeName("struct IPowerGridForecastStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPowerGridForecastStatics : IPowerGridForecastStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPowerGridForecastStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPowerGridForecastStatics*, Guid*, void**, int>)(lpVtbl[0]))((IPowerGridForecastStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPowerGridForecastStatics*, uint>)(lpVtbl[1]))((IPowerGridForecastStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPowerGridForecastStatics*, uint>)(lpVtbl[2]))((IPowerGridForecastStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPowerGridForecastStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IPowerGridForecastStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPowerGridForecastStatics*, HSTRING*, int>)(lpVtbl[4]))((IPowerGridForecastStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPowerGridForecastStatics*, TrustLevel*, int>)(lpVtbl[5]))((IPowerGridForecastStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPowerGridForecastStatics.xml' path='doc/member[@name="IPowerGridForecastStatics.GetForecast"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetForecast([NativeTypeName("ABI::Windows::Devices::Power::IPowerGridForecast **")] IPowerGridForecast** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPowerGridForecastStatics*, IPowerGridForecast**, int>)(lpVtbl[6]))((IPowerGridForecastStatics*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IPowerGridForecastStatics.xml' path='doc/member[@name="IPowerGridForecastStatics.add_ForecastUpdated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT add_ForecastUpdated([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPowerGridForecastStatics*, IEventHandler<Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[7]))((IPowerGridForecastStatics*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IPowerGridForecastStatics.xml' path='doc/member[@name="IPowerGridForecastStatics.remove_ForecastUpdated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT remove_ForecastUpdated(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IPowerGridForecastStatics*, EventRegistrationToken, int>)(lpVtbl[8]))((IPowerGridForecastStatics*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetForecast([NativeTypeName("ABI::Windows::Devices::Power::IPowerGridForecast **")] IPowerGridForecast** result);

        [VtblIndex(7)]
        HRESULT add_ForecastUpdated([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(8)]
        HRESULT remove_ForecastUpdated(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Power::IPowerGridForecast **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPowerGridForecast**, int> GetForecast;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEventHandler<Pointer<IInspectable>>*, EventRegistrationToken*, int> add_ForecastUpdated;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_ForecastUpdated;
    }
}
