// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.diagnostics.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDiagnosticInvoker.xml' path='doc/member[@name="IDiagnosticInvoker"]/*' />
[Guid("187B270A-02E3-4F86-84FC-FDD892B5940F")]
[NativeTypeName("struct IDiagnosticInvoker : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDiagnosticInvoker : IDiagnosticInvoker.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDiagnosticInvoker));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiagnosticInvoker*, Guid*, void**, int>)(lpVtbl[0]))((IDiagnosticInvoker*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDiagnosticInvoker*, uint>)(lpVtbl[1]))((IDiagnosticInvoker*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDiagnosticInvoker*, uint>)(lpVtbl[2]))((IDiagnosticInvoker*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiagnosticInvoker*, uint*, Guid**, int>)(lpVtbl[3]))((IDiagnosticInvoker*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiagnosticInvoker*, HSTRING*, int>)(lpVtbl[4]))((IDiagnosticInvoker*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiagnosticInvoker*, TrustLevel*, int>)(lpVtbl[5]))((IDiagnosticInvoker*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDiagnosticInvoker.xml' path='doc/member[@name="IDiagnosticInvoker.RunDiagnosticActionAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RunDiagnosticActionAsync([NativeTypeName("ABI::Windows::Data::Json::IJsonObject *")] IJsonObject* context, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CSystem__CDiagnostics__CDiagnosticActionResult_Windows__CSystem__CDiagnostics__CDiagnosticActionState_t **")] IAsyncOperationWithProgress<Pointer<IDiagnosticActionResult>, DiagnosticActionState>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiagnosticInvoker*, IJsonObject*, IAsyncOperationWithProgress<Pointer<IDiagnosticActionResult>, DiagnosticActionState>**, int>)(lpVtbl[6]))((IDiagnosticInvoker*)Unsafe.AsPointer(ref this), context, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT RunDiagnosticActionAsync([NativeTypeName("ABI::Windows::Data::Json::IJsonObject *")] IJsonObject* context, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CSystem__CDiagnostics__CDiagnosticActionResult_Windows__CSystem__CDiagnostics__CDiagnosticActionState_t **")] IAsyncOperationWithProgress<Pointer<IDiagnosticActionResult>, DiagnosticActionState>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Data::Json::IJsonObject *, ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CSystem__CDiagnostics__CDiagnosticActionResult_Windows__CSystem__CDiagnostics__CDiagnosticActionState_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IJsonObject*, IAsyncOperationWithProgress<Pointer<IDiagnosticActionResult>, DiagnosticActionState>**, int> RunDiagnosticActionAsync;
    }
}
