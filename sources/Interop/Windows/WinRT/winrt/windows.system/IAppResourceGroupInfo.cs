// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppResourceGroupInfo.xml' path='doc/member[@name="IAppResourceGroupInfo"]/*' />
[Guid("B913F77A-E807-49F4-845E-7B8BDCFE8EE7")]
[NativeTypeName("struct IAppResourceGroupInfo : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppResourceGroupInfo : IAppResourceGroupInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppResourceGroupInfo));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupInfo*, Guid*, void**, int>)(lpVtbl[0]))((IAppResourceGroupInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupInfo*, uint>)(lpVtbl[1]))((IAppResourceGroupInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupInfo*, uint>)(lpVtbl[2]))((IAppResourceGroupInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupInfo*, uint*, Guid**, int>)(lpVtbl[3]))((IAppResourceGroupInfo*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupInfo*, HSTRING*, int>)(lpVtbl[4]))((IAppResourceGroupInfo*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupInfo*, TrustLevel*, int>)(lpVtbl[5]))((IAppResourceGroupInfo*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppResourceGroupInfo.xml' path='doc/member[@name="IAppResourceGroupInfo.get_InstanceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_InstanceId(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupInfo*, Guid*, int>)(lpVtbl[6]))((IAppResourceGroupInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppResourceGroupInfo.xml' path='doc/member[@name="IAppResourceGroupInfo.get_IsShared"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_IsShared([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupInfo*, byte*, int>)(lpVtbl[7]))((IAppResourceGroupInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppResourceGroupInfo.xml' path='doc/member[@name="IAppResourceGroupInfo.GetBackgroundTaskReports"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetBackgroundTaskReports([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CSystem__CAppResourceGroupBackgroundTaskReport_t **")] IVector<Pointer<IAppResourceGroupBackgroundTaskReport>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupInfo*, IVector<Pointer<IAppResourceGroupBackgroundTaskReport>>**, int>)(lpVtbl[8]))((IAppResourceGroupInfo*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IAppResourceGroupInfo.xml' path='doc/member[@name="IAppResourceGroupInfo.GetMemoryReport"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetMemoryReport([NativeTypeName("ABI::Windows::System::IAppResourceGroupMemoryReport **")] IAppResourceGroupMemoryReport** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupInfo*, IAppResourceGroupMemoryReport**, int>)(lpVtbl[9]))((IAppResourceGroupInfo*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IAppResourceGroupInfo.xml' path='doc/member[@name="IAppResourceGroupInfo.GetProcessDiagnosticInfos"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetProcessDiagnosticInfos([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CSystem__CDiagnostics__CProcessDiagnosticInfo_t **")] IVector<Pointer<IProcessDiagnosticInfo>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupInfo*, IVector<Pointer<IProcessDiagnosticInfo>>**, int>)(lpVtbl[10]))((IAppResourceGroupInfo*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IAppResourceGroupInfo.xml' path='doc/member[@name="IAppResourceGroupInfo.GetStateReport"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetStateReport([NativeTypeName("ABI::Windows::System::IAppResourceGroupStateReport **")] IAppResourceGroupStateReport** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppResourceGroupInfo*, IAppResourceGroupStateReport**, int>)(lpVtbl[11]))((IAppResourceGroupInfo*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_InstanceId(Guid* value);

        [VtblIndex(7)]
        HRESULT get_IsShared([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT GetBackgroundTaskReports([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CSystem__CAppResourceGroupBackgroundTaskReport_t **")] IVector<Pointer<IAppResourceGroupBackgroundTaskReport>>** result);

        [VtblIndex(9)]
        HRESULT GetMemoryReport([NativeTypeName("ABI::Windows::System::IAppResourceGroupMemoryReport **")] IAppResourceGroupMemoryReport** result);

        [VtblIndex(10)]
        HRESULT GetProcessDiagnosticInfos([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CSystem__CDiagnostics__CProcessDiagnosticInfo_t **")] IVector<Pointer<IProcessDiagnosticInfo>>** result);

        [VtblIndex(11)]
        HRESULT GetStateReport([NativeTypeName("ABI::Windows::System::IAppResourceGroupStateReport **")] IAppResourceGroupStateReport** result);
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

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_InstanceId;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsShared;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CSystem__CAppResourceGroupBackgroundTaskReport_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<Pointer<IAppResourceGroupBackgroundTaskReport>>**, int> GetBackgroundTaskReports;

        [NativeTypeName("HRESULT (ABI::Windows::System::IAppResourceGroupMemoryReport **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppResourceGroupMemoryReport**, int> GetMemoryReport;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CSystem__CDiagnostics__CProcessDiagnosticInfo_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<Pointer<IProcessDiagnosticInfo>>**, int> GetProcessDiagnosticInfos;

        [NativeTypeName("HRESULT (ABI::Windows::System::IAppResourceGroupStateReport **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppResourceGroupStateReport**, int> GetStateReport;
    }
}
