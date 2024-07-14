// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.diagnostics.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IProcessDiagnosticInfoStatics2.xml' path='doc/member[@name="IProcessDiagnosticInfoStatics2"]/*' />
[Guid("4A869897-9899-4A44-A29B-091663BE09B6")]
[NativeTypeName("struct IProcessDiagnosticInfoStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IProcessDiagnosticInfoStatics2 : IProcessDiagnosticInfoStatics2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IProcessDiagnosticInfoStatics2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessDiagnosticInfoStatics2*, Guid*, void**, int>)(lpVtbl[0]))((IProcessDiagnosticInfoStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessDiagnosticInfoStatics2*, uint>)(lpVtbl[1]))((IProcessDiagnosticInfoStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessDiagnosticInfoStatics2*, uint>)(lpVtbl[2]))((IProcessDiagnosticInfoStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessDiagnosticInfoStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((IProcessDiagnosticInfoStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessDiagnosticInfoStatics2*, HSTRING*, int>)(lpVtbl[4]))((IProcessDiagnosticInfoStatics2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessDiagnosticInfoStatics2*, TrustLevel*, int>)(lpVtbl[5]))((IProcessDiagnosticInfoStatics2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IProcessDiagnosticInfoStatics2.xml' path='doc/member[@name="IProcessDiagnosticInfoStatics2.TryGetForProcessId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT TryGetForProcessId([NativeTypeName("UINT32")] uint processId, [NativeTypeName("ABI::Windows::System::Diagnostics::IProcessDiagnosticInfo **")] IProcessDiagnosticInfo** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessDiagnosticInfoStatics2*, uint, IProcessDiagnosticInfo**, int>)(lpVtbl[6]))((IProcessDiagnosticInfoStatics2*)Unsafe.AsPointer(ref this), processId, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT TryGetForProcessId([NativeTypeName("UINT32")] uint processId, [NativeTypeName("ABI::Windows::System::Diagnostics::IProcessDiagnosticInfo **")] IProcessDiagnosticInfo** result);
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

        [NativeTypeName("HRESULT (UINT32, ABI::Windows::System::Diagnostics::IProcessDiagnosticInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IProcessDiagnosticInfo**, int> TryGetForProcessId;
    }
}
