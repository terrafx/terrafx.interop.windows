// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IShutdownManagerStatics2.xml' path='doc/member[@name="IShutdownManagerStatics2"]/*' />
[Guid("0F69A02F-9C34-43C7-A8C3-70B30A7F7504")]
[NativeTypeName("struct IShutdownManagerStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IShutdownManagerStatics2 : IShutdownManagerStatics2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IShutdownManagerStatics2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IShutdownManagerStatics2*, Guid*, void**, int>)(lpVtbl[0]))((IShutdownManagerStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IShutdownManagerStatics2*, uint>)(lpVtbl[1]))((IShutdownManagerStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IShutdownManagerStatics2*, uint>)(lpVtbl[2]))((IShutdownManagerStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IShutdownManagerStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((IShutdownManagerStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IShutdownManagerStatics2*, HSTRING*, int>)(lpVtbl[4]))((IShutdownManagerStatics2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IShutdownManagerStatics2*, TrustLevel*, int>)(lpVtbl[5]))((IShutdownManagerStatics2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IShutdownManagerStatics2.xml' path='doc/member[@name="IShutdownManagerStatics2.IsPowerStateSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT IsPowerStateSupported([NativeTypeName("ABI::Windows::System::PowerState")] PowerState powerState, [NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IShutdownManagerStatics2*, PowerState, byte*, int>)(lpVtbl[6]))((IShutdownManagerStatics2*)Unsafe.AsPointer(ref this), powerState, value);
    }

    /// <include file='IShutdownManagerStatics2.xml' path='doc/member[@name="IShutdownManagerStatics2.EnterPowerState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT EnterPowerState([NativeTypeName("ABI::Windows::System::PowerState")] PowerState powerState)
    {
        return ((delegate* unmanaged[MemberFunction]<IShutdownManagerStatics2*, PowerState, int>)(lpVtbl[7]))((IShutdownManagerStatics2*)Unsafe.AsPointer(ref this), powerState);
    }

    /// <include file='IShutdownManagerStatics2.xml' path='doc/member[@name="IShutdownManagerStatics2.EnterPowerStateWithTimeSpan"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT EnterPowerStateWithTimeSpan([NativeTypeName("ABI::Windows::System::PowerState")] PowerState powerState, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan wakeUpAfter)
    {
        return ((delegate* unmanaged[MemberFunction]<IShutdownManagerStatics2*, PowerState, TimeSpan, int>)(lpVtbl[8]))((IShutdownManagerStatics2*)Unsafe.AsPointer(ref this), powerState, wakeUpAfter);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT IsPowerStateSupported([NativeTypeName("ABI::Windows::System::PowerState")] PowerState powerState, [NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT EnterPowerState([NativeTypeName("ABI::Windows::System::PowerState")] PowerState powerState);

        [VtblIndex(8)]
        HRESULT EnterPowerStateWithTimeSpan([NativeTypeName("ABI::Windows::System::PowerState")] PowerState powerState, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan wakeUpAfter);
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

        [NativeTypeName("HRESULT (ABI::Windows::System::PowerState, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PowerState, byte*, int> IsPowerStateSupported;

        [NativeTypeName("HRESULT (ABI::Windows::System::PowerState) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PowerState, int> EnterPowerState;

        [NativeTypeName("HRESULT (ABI::Windows::System::PowerState, ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PowerState, TimeSpan, int> EnterPowerStateWithTimeSpan;
    }
}
