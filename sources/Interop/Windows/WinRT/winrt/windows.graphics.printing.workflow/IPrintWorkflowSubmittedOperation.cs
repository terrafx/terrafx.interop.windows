// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.workflow.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPrintWorkflowSubmittedOperation.xml' path='doc/member[@name="IPrintWorkflowSubmittedOperation"]/*' />
[Guid("2E4E6216-3BE1-5F0F-5C81-A5A2BD4EAB0E")]
[NativeTypeName("struct IPrintWorkflowSubmittedOperation : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintWorkflowSubmittedOperation : IPrintWorkflowSubmittedOperation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IPrintWorkflowSubmittedOperation);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowSubmittedOperation*, Guid*, void**, int>)(lpVtbl[0]))((IPrintWorkflowSubmittedOperation*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowSubmittedOperation*, uint>)(lpVtbl[1]))((IPrintWorkflowSubmittedOperation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowSubmittedOperation*, uint>)(lpVtbl[2]))((IPrintWorkflowSubmittedOperation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowSubmittedOperation*, uint*, Guid**, int>)(lpVtbl[3]))((IPrintWorkflowSubmittedOperation*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowSubmittedOperation*, HSTRING*, int>)(lpVtbl[4]))((IPrintWorkflowSubmittedOperation*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowSubmittedOperation*, TrustLevel*, int>)(lpVtbl[5]))((IPrintWorkflowSubmittedOperation*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPrintWorkflowSubmittedOperation.xml' path='doc/member[@name="IPrintWorkflowSubmittedOperation.Complete"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Complete([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowSubmittedStatus")] PrintWorkflowSubmittedStatus status)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowSubmittedOperation*, PrintWorkflowSubmittedStatus, int>)(lpVtbl[6]))((IPrintWorkflowSubmittedOperation*)Unsafe.AsPointer(ref this), status);
    }

    /// <include file='IPrintWorkflowSubmittedOperation.xml' path='doc/member[@name="IPrintWorkflowSubmittedOperation.get_Configuration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Configuration([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowConfiguration **")] IPrintWorkflowConfiguration** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowSubmittedOperation*, IPrintWorkflowConfiguration**, int>)(lpVtbl[7]))((IPrintWorkflowSubmittedOperation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintWorkflowSubmittedOperation.xml' path='doc/member[@name="IPrintWorkflowSubmittedOperation.get_XpsContent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_XpsContent([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowSourceContent **")] IPrintWorkflowSourceContent** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowSubmittedOperation*, IPrintWorkflowSourceContent**, int>)(lpVtbl[8]))((IPrintWorkflowSubmittedOperation*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Complete([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowSubmittedStatus")] PrintWorkflowSubmittedStatus status);

        [VtblIndex(7)]
        HRESULT get_Configuration([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowConfiguration **")] IPrintWorkflowConfiguration** value);

        [VtblIndex(8)]
        HRESULT get_XpsContent([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowSourceContent **")] IPrintWorkflowSourceContent** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowSubmittedStatus) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PrintWorkflowSubmittedStatus, int> Complete;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowConfiguration **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPrintWorkflowConfiguration**, int> get_Configuration;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowSourceContent **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPrintWorkflowSourceContent**, int> get_XpsContent;
    }
}
