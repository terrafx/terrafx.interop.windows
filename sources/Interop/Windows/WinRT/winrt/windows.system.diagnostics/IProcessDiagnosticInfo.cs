// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.diagnostics.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IProcessDiagnosticInfo.xml' path='doc/member[@name="IProcessDiagnosticInfo"]/*' />
[Guid("E830B04B-300E-4EE6-A0AB-5B5F5231B434")]
[NativeTypeName("struct IProcessDiagnosticInfo : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IProcessDiagnosticInfo : IProcessDiagnosticInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IProcessDiagnosticInfo);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessDiagnosticInfo*, Guid*, void**, int>)(lpVtbl[0]))((IProcessDiagnosticInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessDiagnosticInfo*, uint>)(lpVtbl[1]))((IProcessDiagnosticInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessDiagnosticInfo*, uint>)(lpVtbl[2]))((IProcessDiagnosticInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessDiagnosticInfo*, uint*, Guid**, int>)(lpVtbl[3]))((IProcessDiagnosticInfo*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessDiagnosticInfo*, HSTRING*, int>)(lpVtbl[4]))((IProcessDiagnosticInfo*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessDiagnosticInfo*, TrustLevel*, int>)(lpVtbl[5]))((IProcessDiagnosticInfo*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IProcessDiagnosticInfo.xml' path='doc/member[@name="IProcessDiagnosticInfo.get_ProcessId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ProcessId([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessDiagnosticInfo*, uint*, int>)(lpVtbl[6]))((IProcessDiagnosticInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IProcessDiagnosticInfo.xml' path='doc/member[@name="IProcessDiagnosticInfo.get_ExecutableFileName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ExecutableFileName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessDiagnosticInfo*, HSTRING*, int>)(lpVtbl[7]))((IProcessDiagnosticInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IProcessDiagnosticInfo.xml' path='doc/member[@name="IProcessDiagnosticInfo.get_Parent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Parent([NativeTypeName("ABI::Windows::System::Diagnostics::IProcessDiagnosticInfo **")] IProcessDiagnosticInfo** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessDiagnosticInfo*, IProcessDiagnosticInfo**, int>)(lpVtbl[8]))((IProcessDiagnosticInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IProcessDiagnosticInfo.xml' path='doc/member[@name="IProcessDiagnosticInfo.get_ProcessStartTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ProcessStartTime([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessDiagnosticInfo*, WinRTDateTime*, int>)(lpVtbl[9]))((IProcessDiagnosticInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IProcessDiagnosticInfo.xml' path='doc/member[@name="IProcessDiagnosticInfo.get_DiskUsage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_DiskUsage([NativeTypeName("ABI::Windows::System::Diagnostics::IProcessDiskUsage **")] IProcessDiskUsage** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessDiagnosticInfo*, IProcessDiskUsage**, int>)(lpVtbl[10]))((IProcessDiagnosticInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IProcessDiagnosticInfo.xml' path='doc/member[@name="IProcessDiagnosticInfo.get_MemoryUsage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_MemoryUsage([NativeTypeName("ABI::Windows::System::Diagnostics::IProcessMemoryUsage **")] IProcessMemoryUsage** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessDiagnosticInfo*, IProcessMemoryUsage**, int>)(lpVtbl[11]))((IProcessDiagnosticInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IProcessDiagnosticInfo.xml' path='doc/member[@name="IProcessDiagnosticInfo.get_CpuUsage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_CpuUsage([NativeTypeName("ABI::Windows::System::Diagnostics::IProcessCpuUsage **")] IProcessCpuUsage** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessDiagnosticInfo*, IProcessCpuUsage**, int>)(lpVtbl[12]))((IProcessDiagnosticInfo*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ProcessId([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(7)]
        HRESULT get_ExecutableFileName(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_Parent([NativeTypeName("ABI::Windows::System::Diagnostics::IProcessDiagnosticInfo **")] IProcessDiagnosticInfo** value);

        [VtblIndex(9)]
        HRESULT get_ProcessStartTime([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value);

        [VtblIndex(10)]
        HRESULT get_DiskUsage([NativeTypeName("ABI::Windows::System::Diagnostics::IProcessDiskUsage **")] IProcessDiskUsage** value);

        [VtblIndex(11)]
        HRESULT get_MemoryUsage([NativeTypeName("ABI::Windows::System::Diagnostics::IProcessMemoryUsage **")] IProcessMemoryUsage** value);

        [VtblIndex(12)]
        HRESULT get_CpuUsage([NativeTypeName("ABI::Windows::System::Diagnostics::IProcessCpuUsage **")] IProcessCpuUsage** value);
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

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_ProcessId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ExecutableFileName;

        [NativeTypeName("HRESULT (ABI::Windows::System::Diagnostics::IProcessDiagnosticInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IProcessDiagnosticInfo**, int> get_Parent;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime*, int> get_ProcessStartTime;

        [NativeTypeName("HRESULT (ABI::Windows::System::Diagnostics::IProcessDiskUsage **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IProcessDiskUsage**, int> get_DiskUsage;

        [NativeTypeName("HRESULT (ABI::Windows::System::Diagnostics::IProcessMemoryUsage **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IProcessMemoryUsage**, int> get_MemoryUsage;

        [NativeTypeName("HRESULT (ABI::Windows::System::Diagnostics::IProcessCpuUsage **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IProcessCpuUsage**, int> get_CpuUsage;
    }
}
