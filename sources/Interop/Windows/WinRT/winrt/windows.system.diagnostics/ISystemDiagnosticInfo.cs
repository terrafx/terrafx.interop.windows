// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.diagnostics.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISystemDiagnosticInfo.xml' path='doc/member[@name="ISystemDiagnosticInfo"]/*' />
[Guid("A290FE05-DFF3-407F-9A1B-0B2B317CA800")]
[NativeTypeName("struct ISystemDiagnosticInfo : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISystemDiagnosticInfo : ISystemDiagnosticInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ISystemDiagnosticInfo);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDiagnosticInfo*, Guid*, void**, int>)(lpVtbl[0]))((ISystemDiagnosticInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDiagnosticInfo*, uint>)(lpVtbl[1]))((ISystemDiagnosticInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDiagnosticInfo*, uint>)(lpVtbl[2]))((ISystemDiagnosticInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDiagnosticInfo*, uint*, Guid**, int>)(lpVtbl[3]))((ISystemDiagnosticInfo*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDiagnosticInfo*, HSTRING*, int>)(lpVtbl[4]))((ISystemDiagnosticInfo*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDiagnosticInfo*, TrustLevel*, int>)(lpVtbl[5]))((ISystemDiagnosticInfo*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISystemDiagnosticInfo.xml' path='doc/member[@name="ISystemDiagnosticInfo.get_MemoryUsage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_MemoryUsage([NativeTypeName("ABI::Windows::System::Diagnostics::ISystemMemoryUsage **")] ISystemMemoryUsage** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDiagnosticInfo*, ISystemMemoryUsage**, int>)(lpVtbl[6]))((ISystemDiagnosticInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISystemDiagnosticInfo.xml' path='doc/member[@name="ISystemDiagnosticInfo.get_CpuUsage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_CpuUsage([NativeTypeName("ABI::Windows::System::Diagnostics::ISystemCpuUsage **")] ISystemCpuUsage** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISystemDiagnosticInfo*, ISystemCpuUsage**, int>)(lpVtbl[7]))((ISystemDiagnosticInfo*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_MemoryUsage([NativeTypeName("ABI::Windows::System::Diagnostics::ISystemMemoryUsage **")] ISystemMemoryUsage** value);

        [VtblIndex(7)]
        HRESULT get_CpuUsage([NativeTypeName("ABI::Windows::System::Diagnostics::ISystemCpuUsage **")] ISystemCpuUsage** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::System::Diagnostics::ISystemMemoryUsage **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISystemMemoryUsage**, int> get_MemoryUsage;

        [NativeTypeName("HRESULT (ABI::Windows::System::Diagnostics::ISystemCpuUsage **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISystemCpuUsage**, int> get_CpuUsage;
    }
}
