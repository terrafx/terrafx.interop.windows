// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.diagnostics.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IProcessDiskUsageReport.xml' path='doc/member[@name="IProcessDiskUsageReport"]/*' />
[Guid("401627FD-535D-4C1F-81B8-DA54E1BE635E")]
[NativeTypeName("struct IProcessDiskUsageReport : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IProcessDiskUsageReport : IProcessDiskUsageReport.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IProcessDiskUsageReport));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessDiskUsageReport*, Guid*, void**, int>)(lpVtbl[0]))((IProcessDiskUsageReport*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessDiskUsageReport*, uint>)(lpVtbl[1]))((IProcessDiskUsageReport*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessDiskUsageReport*, uint>)(lpVtbl[2]))((IProcessDiskUsageReport*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessDiskUsageReport*, uint*, Guid**, int>)(lpVtbl[3]))((IProcessDiskUsageReport*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessDiskUsageReport*, HSTRING*, int>)(lpVtbl[4]))((IProcessDiskUsageReport*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessDiskUsageReport*, TrustLevel*, int>)(lpVtbl[5]))((IProcessDiskUsageReport*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IProcessDiskUsageReport.xml' path='doc/member[@name="IProcessDiskUsageReport.get_ReadOperationCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ReadOperationCount([NativeTypeName("INT64 *")] long* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessDiskUsageReport*, long*, int>)(lpVtbl[6]))((IProcessDiskUsageReport*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IProcessDiskUsageReport.xml' path='doc/member[@name="IProcessDiskUsageReport.get_WriteOperationCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_WriteOperationCount([NativeTypeName("INT64 *")] long* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessDiskUsageReport*, long*, int>)(lpVtbl[7]))((IProcessDiskUsageReport*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IProcessDiskUsageReport.xml' path='doc/member[@name="IProcessDiskUsageReport.get_OtherOperationCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_OtherOperationCount([NativeTypeName("INT64 *")] long* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessDiskUsageReport*, long*, int>)(lpVtbl[8]))((IProcessDiskUsageReport*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IProcessDiskUsageReport.xml' path='doc/member[@name="IProcessDiskUsageReport.get_BytesReadCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_BytesReadCount([NativeTypeName("INT64 *")] long* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessDiskUsageReport*, long*, int>)(lpVtbl[9]))((IProcessDiskUsageReport*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IProcessDiskUsageReport.xml' path='doc/member[@name="IProcessDiskUsageReport.get_BytesWrittenCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_BytesWrittenCount([NativeTypeName("INT64 *")] long* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessDiskUsageReport*, long*, int>)(lpVtbl[10]))((IProcessDiskUsageReport*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IProcessDiskUsageReport.xml' path='doc/member[@name="IProcessDiskUsageReport.get_OtherBytesCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_OtherBytesCount([NativeTypeName("INT64 *")] long* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessDiskUsageReport*, long*, int>)(lpVtbl[11]))((IProcessDiskUsageReport*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ReadOperationCount([NativeTypeName("INT64 *")] long* value);

        [VtblIndex(7)]
        HRESULT get_WriteOperationCount([NativeTypeName("INT64 *")] long* value);

        [VtblIndex(8)]
        HRESULT get_OtherOperationCount([NativeTypeName("INT64 *")] long* value);

        [VtblIndex(9)]
        HRESULT get_BytesReadCount([NativeTypeName("INT64 *")] long* value);

        [VtblIndex(10)]
        HRESULT get_BytesWrittenCount([NativeTypeName("INT64 *")] long* value);

        [VtblIndex(11)]
        HRESULT get_OtherBytesCount([NativeTypeName("INT64 *")] long* value);
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

        [NativeTypeName("HRESULT (INT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, long*, int> get_ReadOperationCount;

        [NativeTypeName("HRESULT (INT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, long*, int> get_WriteOperationCount;

        [NativeTypeName("HRESULT (INT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, long*, int> get_OtherOperationCount;

        [NativeTypeName("HRESULT (INT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, long*, int> get_BytesReadCount;

        [NativeTypeName("HRESULT (INT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, long*, int> get_BytesWrittenCount;

        [NativeTypeName("HRESULT (INT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, long*, int> get_OtherBytesCount;
    }
}
