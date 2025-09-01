// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.workflow.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPrintWorkflowPdlTargetStream.xml' path='doc/member[@name="IPrintWorkflowPdlTargetStream"]/*' />
[Guid("A742DFE5-1EE3-52A9-9F9F-2E2043180FD1")]
[NativeTypeName("struct IPrintWorkflowPdlTargetStream : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintWorkflowPdlTargetStream : IPrintWorkflowPdlTargetStream.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IPrintWorkflowPdlTargetStream);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPdlTargetStream*, Guid*, void**, int>)(lpVtbl[0]))((IPrintWorkflowPdlTargetStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPdlTargetStream*, uint>)(lpVtbl[1]))((IPrintWorkflowPdlTargetStream*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPdlTargetStream*, uint>)(lpVtbl[2]))((IPrintWorkflowPdlTargetStream*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPdlTargetStream*, uint*, Guid**, int>)(lpVtbl[3]))((IPrintWorkflowPdlTargetStream*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPdlTargetStream*, HSTRING*, int>)(lpVtbl[4]))((IPrintWorkflowPdlTargetStream*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPdlTargetStream*, TrustLevel*, int>)(lpVtbl[5]))((IPrintWorkflowPdlTargetStream*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPrintWorkflowPdlTargetStream.xml' path='doc/member[@name="IPrintWorkflowPdlTargetStream.GetOutputStream"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetOutputStream([NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream **")] IOutputStream** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPdlTargetStream*, IOutputStream**, int>)(lpVtbl[6]))((IPrintWorkflowPdlTargetStream*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IPrintWorkflowPdlTargetStream.xml' path='doc/member[@name="IPrintWorkflowPdlTargetStream.CompleteStreamSubmission"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CompleteStreamSubmission([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowSubmittedStatus")] PrintWorkflowSubmittedStatus status)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPdlTargetStream*, PrintWorkflowSubmittedStatus, int>)(lpVtbl[7]))((IPrintWorkflowPdlTargetStream*)Unsafe.AsPointer(ref this), status);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetOutputStream([NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream **")] IOutputStream** result);

        [VtblIndex(7)]
        HRESULT CompleteStreamSubmission([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowSubmittedStatus")] PrintWorkflowSubmittedStatus status);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IOutputStream **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IOutputStream**, int> GetOutputStream;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowSubmittedStatus) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PrintWorkflowSubmittedStatus, int> CompleteStreamSubmission;
    }
}
