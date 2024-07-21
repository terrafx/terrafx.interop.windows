// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.diagnostics.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IProcessDiagnosticInfoStatics.xml' path='doc/member[@name="IProcessDiagnosticInfoStatics"]/*' />
[Guid("2F41B260-B49F-428C-AA0E-84744F49CA95")]
[NativeTypeName("struct IProcessDiagnosticInfoStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IProcessDiagnosticInfoStatics : IProcessDiagnosticInfoStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IProcessDiagnosticInfoStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessDiagnosticInfoStatics*, Guid*, void**, int>)(lpVtbl[0]))((IProcessDiagnosticInfoStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessDiagnosticInfoStatics*, uint>)(lpVtbl[1]))((IProcessDiagnosticInfoStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessDiagnosticInfoStatics*, uint>)(lpVtbl[2]))((IProcessDiagnosticInfoStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessDiagnosticInfoStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IProcessDiagnosticInfoStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessDiagnosticInfoStatics*, HSTRING*, int>)(lpVtbl[4]))((IProcessDiagnosticInfoStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessDiagnosticInfoStatics*, TrustLevel*, int>)(lpVtbl[5]))((IProcessDiagnosticInfoStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IProcessDiagnosticInfoStatics.xml' path='doc/member[@name="IProcessDiagnosticInfoStatics.GetForProcesses"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetForProcesses([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSystem__CDiagnostics__CProcessDiagnosticInfo_t **")] IVectorView<Pointer<IProcessDiagnosticInfo>>** processes)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessDiagnosticInfoStatics*, IVectorView<Pointer<IProcessDiagnosticInfo>>**, int>)(lpVtbl[6]))((IProcessDiagnosticInfoStatics*)Unsafe.AsPointer(ref this), processes);
    }

    /// <include file='IProcessDiagnosticInfoStatics.xml' path='doc/member[@name="IProcessDiagnosticInfoStatics.GetForCurrentProcess"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetForCurrentProcess([NativeTypeName("ABI::Windows::System::Diagnostics::IProcessDiagnosticInfo **")] IProcessDiagnosticInfo** processes)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessDiagnosticInfoStatics*, IProcessDiagnosticInfo**, int>)(lpVtbl[7]))((IProcessDiagnosticInfoStatics*)Unsafe.AsPointer(ref this), processes);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetForProcesses([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSystem__CDiagnostics__CProcessDiagnosticInfo_t **")] IVectorView<Pointer<IProcessDiagnosticInfo>>** processes);

        [VtblIndex(7)]
        HRESULT GetForCurrentProcess([NativeTypeName("ABI::Windows::System::Diagnostics::IProcessDiagnosticInfo **")] IProcessDiagnosticInfo** processes);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSystem__CDiagnostics__CProcessDiagnosticInfo_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IProcessDiagnosticInfo>>**, int> GetForProcesses;

        [NativeTypeName("HRESULT (ABI::Windows::System::Diagnostics::IProcessDiagnosticInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IProcessDiagnosticInfo**, int> GetForCurrentProcess;
    }
}
