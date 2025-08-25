// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.workflow.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPrintWorkflowPdlConverter2.xml' path='doc/member[@name="IPrintWorkflowPdlConverter2"]/*' />
[Guid("854CEEC1-7837-5B93-B7AF-57A6998C2F71")]
[NativeTypeName("struct IPrintWorkflowPdlConverter2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintWorkflowPdlConverter2 : IPrintWorkflowPdlConverter2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IPrintWorkflowPdlConverter2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPdlConverter2*, Guid*, void**, int>)(lpVtbl[0]))((IPrintWorkflowPdlConverter2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPdlConverter2*, uint>)(lpVtbl[1]))((IPrintWorkflowPdlConverter2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPdlConverter2*, uint>)(lpVtbl[2]))((IPrintWorkflowPdlConverter2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPdlConverter2*, uint*, Guid**, int>)(lpVtbl[3]))((IPrintWorkflowPdlConverter2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPdlConverter2*, HSTRING*, int>)(lpVtbl[4]))((IPrintWorkflowPdlConverter2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPdlConverter2*, TrustLevel*, int>)(lpVtbl[5]))((IPrintWorkflowPdlConverter2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPrintWorkflowPdlConverter2.xml' path='doc/member[@name="IPrintWorkflowPdlConverter2.ConvertPdlAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ConvertPdlAsync([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IWorkflowPrintTicket *")] IWorkflowPrintTicket* printTicket, [NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")] IInputStream* inputStream, [NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream *")] IOutputStream* outputStream, [NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::PdlConversionHostBasedProcessingOperations")] PdlConversionHostBasedProcessingOperations hostBasedProcessingOperations, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPdlConverter2*, IWorkflowPrintTicket*, IInputStream*, IOutputStream*, PdlConversionHostBasedProcessingOperations, IAsyncAction**, int>)(lpVtbl[6]))((IPrintWorkflowPdlConverter2*)Unsafe.AsPointer(ref this), printTicket, inputStream, outputStream, hostBasedProcessingOperations, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT ConvertPdlAsync([NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IWorkflowPrintTicket *")] IWorkflowPrintTicket* printTicket, [NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")] IInputStream* inputStream, [NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream *")] IOutputStream* outputStream, [NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::PdlConversionHostBasedProcessingOperations")] PdlConversionHostBasedProcessingOperations hostBasedProcessingOperations, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::PrintTicket::IWorkflowPrintTicket *, ABI::Windows::Storage::Streams::IInputStream *, ABI::Windows::Storage::Streams::IOutputStream *, ABI::Windows::Graphics::Printing::Workflow::PdlConversionHostBasedProcessingOperations, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWorkflowPrintTicket*, IInputStream*, IOutputStream*, PdlConversionHostBasedProcessingOperations, IAsyncAction**, int> ConvertPdlAsync;
    }
}
