// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.diagnostics.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IProcessMemoryUsageReport.xml' path='doc/member[@name="IProcessMemoryUsageReport"]/*' />
[Guid("C2C77CBA-1951-4685-8532-7E749ECF8EEB")]
[NativeTypeName("struct IProcessMemoryUsageReport : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IProcessMemoryUsageReport : IProcessMemoryUsageReport.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IProcessMemoryUsageReport);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessMemoryUsageReport*, Guid*, void**, int>)(lpVtbl[0]))((IProcessMemoryUsageReport*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessMemoryUsageReport*, uint>)(lpVtbl[1]))((IProcessMemoryUsageReport*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessMemoryUsageReport*, uint>)(lpVtbl[2]))((IProcessMemoryUsageReport*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessMemoryUsageReport*, uint*, Guid**, int>)(lpVtbl[3]))((IProcessMemoryUsageReport*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessMemoryUsageReport*, HSTRING*, int>)(lpVtbl[4]))((IProcessMemoryUsageReport*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessMemoryUsageReport*, TrustLevel*, int>)(lpVtbl[5]))((IProcessMemoryUsageReport*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IProcessMemoryUsageReport.xml' path='doc/member[@name="IProcessMemoryUsageReport.get_NonPagedPoolSizeInBytes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_NonPagedPoolSizeInBytes([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessMemoryUsageReport*, ulong*, int>)(lpVtbl[6]))((IProcessMemoryUsageReport*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IProcessMemoryUsageReport.xml' path='doc/member[@name="IProcessMemoryUsageReport.get_PageFaultCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_PageFaultCount([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessMemoryUsageReport*, uint*, int>)(lpVtbl[7]))((IProcessMemoryUsageReport*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IProcessMemoryUsageReport.xml' path='doc/member[@name="IProcessMemoryUsageReport.get_PageFileSizeInBytes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_PageFileSizeInBytes([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessMemoryUsageReport*, ulong*, int>)(lpVtbl[8]))((IProcessMemoryUsageReport*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IProcessMemoryUsageReport.xml' path='doc/member[@name="IProcessMemoryUsageReport.get_PagedPoolSizeInBytes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_PagedPoolSizeInBytes([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessMemoryUsageReport*, ulong*, int>)(lpVtbl[9]))((IProcessMemoryUsageReport*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IProcessMemoryUsageReport.xml' path='doc/member[@name="IProcessMemoryUsageReport.get_PeakNonPagedPoolSizeInBytes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_PeakNonPagedPoolSizeInBytes([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessMemoryUsageReport*, ulong*, int>)(lpVtbl[10]))((IProcessMemoryUsageReport*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IProcessMemoryUsageReport.xml' path='doc/member[@name="IProcessMemoryUsageReport.get_PeakPageFileSizeInBytes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_PeakPageFileSizeInBytes([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessMemoryUsageReport*, ulong*, int>)(lpVtbl[11]))((IProcessMemoryUsageReport*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IProcessMemoryUsageReport.xml' path='doc/member[@name="IProcessMemoryUsageReport.get_PeakPagedPoolSizeInBytes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_PeakPagedPoolSizeInBytes([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessMemoryUsageReport*, ulong*, int>)(lpVtbl[12]))((IProcessMemoryUsageReport*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IProcessMemoryUsageReport.xml' path='doc/member[@name="IProcessMemoryUsageReport.get_PeakVirtualMemorySizeInBytes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_PeakVirtualMemorySizeInBytes([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessMemoryUsageReport*, ulong*, int>)(lpVtbl[13]))((IProcessMemoryUsageReport*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IProcessMemoryUsageReport.xml' path='doc/member[@name="IProcessMemoryUsageReport.get_PeakWorkingSetSizeInBytes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_PeakWorkingSetSizeInBytes([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessMemoryUsageReport*, ulong*, int>)(lpVtbl[14]))((IProcessMemoryUsageReport*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IProcessMemoryUsageReport.xml' path='doc/member[@name="IProcessMemoryUsageReport.get_PrivatePageCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_PrivatePageCount([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessMemoryUsageReport*, ulong*, int>)(lpVtbl[15]))((IProcessMemoryUsageReport*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IProcessMemoryUsageReport.xml' path='doc/member[@name="IProcessMemoryUsageReport.get_VirtualMemorySizeInBytes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_VirtualMemorySizeInBytes([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessMemoryUsageReport*, ulong*, int>)(lpVtbl[16]))((IProcessMemoryUsageReport*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IProcessMemoryUsageReport.xml' path='doc/member[@name="IProcessMemoryUsageReport.get_WorkingSetSizeInBytes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_WorkingSetSizeInBytes([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessMemoryUsageReport*, ulong*, int>)(lpVtbl[17]))((IProcessMemoryUsageReport*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_NonPagedPoolSizeInBytes([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(7)]
        HRESULT get_PageFaultCount([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(8)]
        HRESULT get_PageFileSizeInBytes([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(9)]
        HRESULT get_PagedPoolSizeInBytes([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(10)]
        HRESULT get_PeakNonPagedPoolSizeInBytes([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(11)]
        HRESULT get_PeakPageFileSizeInBytes([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(12)]
        HRESULT get_PeakPagedPoolSizeInBytes([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(13)]
        HRESULT get_PeakVirtualMemorySizeInBytes([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(14)]
        HRESULT get_PeakWorkingSetSizeInBytes([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(15)]
        HRESULT get_PrivatePageCount([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(16)]
        HRESULT get_VirtualMemorySizeInBytes([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(17)]
        HRESULT get_WorkingSetSizeInBytes([NativeTypeName("UINT64 *")] ulong* value);
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

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> get_NonPagedPoolSizeInBytes;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_PageFaultCount;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> get_PageFileSizeInBytes;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> get_PagedPoolSizeInBytes;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> get_PeakNonPagedPoolSizeInBytes;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> get_PeakPageFileSizeInBytes;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> get_PeakPagedPoolSizeInBytes;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> get_PeakVirtualMemorySizeInBytes;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> get_PeakWorkingSetSizeInBytes;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> get_PrivatePageCount;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> get_VirtualMemorySizeInBytes;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> get_WorkingSetSizeInBytes;
    }
}
