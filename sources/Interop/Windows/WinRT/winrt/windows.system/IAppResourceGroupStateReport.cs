// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppResourceGroupStateReport.xml' path='doc/member[@name="IAppResourceGroupStateReport"]/*' />
[Guid("52849F18-2F70-4236-AB40-D04DB0C7B931")]
[NativeTypeName("struct IAppResourceGroupStateReport : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppResourceGroupStateReport : IAppResourceGroupStateReport.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppResourceGroupStateReport));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupStateReport*, Guid*, void**, int>)(lpVtbl[0]))((IAppResourceGroupStateReport*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupStateReport*, uint>)(lpVtbl[1]))((IAppResourceGroupStateReport*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupStateReport*, uint>)(lpVtbl[2]))((IAppResourceGroupStateReport*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupStateReport*, uint*, Guid**, int>)(lpVtbl[3]))((IAppResourceGroupStateReport*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupStateReport*, HSTRING*, int>)(lpVtbl[4]))((IAppResourceGroupStateReport*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupStateReport*, TrustLevel*, int>)(lpVtbl[5]))((IAppResourceGroupStateReport*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppResourceGroupStateReport.xml' path='doc/member[@name="IAppResourceGroupStateReport.get_ExecutionState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ExecutionState([NativeTypeName("ABI::Windows::System::AppResourceGroupExecutionState *")] AppResourceGroupExecutionState* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupStateReport*, AppResourceGroupExecutionState*, int>)(lpVtbl[6]))((IAppResourceGroupStateReport*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppResourceGroupStateReport.xml' path='doc/member[@name="IAppResourceGroupStateReport.get_EnergyQuotaState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_EnergyQuotaState([NativeTypeName("ABI::Windows::System::AppResourceGroupEnergyQuotaState *")] AppResourceGroupEnergyQuotaState* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupStateReport*, AppResourceGroupEnergyQuotaState*, int>)(lpVtbl[7]))((IAppResourceGroupStateReport*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ExecutionState([NativeTypeName("ABI::Windows::System::AppResourceGroupExecutionState *")] AppResourceGroupExecutionState* value);

        [VtblIndex(7)]
        HRESULT get_EnergyQuotaState([NativeTypeName("ABI::Windows::System::AppResourceGroupEnergyQuotaState *")] AppResourceGroupEnergyQuotaState* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::System::AppResourceGroupExecutionState *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppResourceGroupExecutionState*, int> get_ExecutionState;

        [NativeTypeName("HRESULT (ABI::Windows::System::AppResourceGroupEnergyQuotaState *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AppResourceGroupEnergyQuotaState*, int> get_EnergyQuotaState;
    }
}
