// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.workflow.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPrintWorkflowSourceContent.xml' path='doc/member[@name="IPrintWorkflowSourceContent"]/*' />
[Guid("1A28C641-CEB1-4533-BB73-FBE63EEFDB18")]
[NativeTypeName("struct IPrintWorkflowSourceContent : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintWorkflowSourceContent : IPrintWorkflowSourceContent.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IPrintWorkflowSourceContent);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowSourceContent*, Guid*, void**, int>)(lpVtbl[0]))((IPrintWorkflowSourceContent*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowSourceContent*, uint>)(lpVtbl[1]))((IPrintWorkflowSourceContent*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowSourceContent*, uint>)(lpVtbl[2]))((IPrintWorkflowSourceContent*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowSourceContent*, uint*, Guid**, int>)(lpVtbl[3]))((IPrintWorkflowSourceContent*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowSourceContent*, HSTRING*, int>)(lpVtbl[4]))((IPrintWorkflowSourceContent*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowSourceContent*, TrustLevel*, int>)(lpVtbl[5]))((IPrintWorkflowSourceContent*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPrintWorkflowSourceContent.xml' path='doc/member[@name="IPrintWorkflowSourceContent.GetJobPrintTicketAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetJobPrintTicketAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CPrinting__CPrintTicket__CWorkflowPrintTicket_t **")] IAsyncOperation<Pointer<IWorkflowPrintTicket>>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowSourceContent*, IAsyncOperation<Pointer<IWorkflowPrintTicket>>**, int>)(lpVtbl[6]))((IPrintWorkflowSourceContent*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IPrintWorkflowSourceContent.xml' path='doc/member[@name="IPrintWorkflowSourceContent.GetSourceSpoolDataAsStreamContent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetSourceSpoolDataAsStreamContent([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowSpoolStreamContent **")] IPrintWorkflowSpoolStreamContent** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowSourceContent*, IPrintWorkflowSpoolStreamContent**, int>)(lpVtbl[7]))((IPrintWorkflowSourceContent*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IPrintWorkflowSourceContent.xml' path='doc/member[@name="IPrintWorkflowSourceContent.GetSourceSpoolDataAsXpsObjectModel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetSourceSpoolDataAsXpsObjectModel([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowObjectModelSourceFileContent **")] IPrintWorkflowObjectModelSourceFileContent** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowSourceContent*, IPrintWorkflowObjectModelSourceFileContent**, int>)(lpVtbl[8]))((IPrintWorkflowSourceContent*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetJobPrintTicketAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CPrinting__CPrintTicket__CWorkflowPrintTicket_t **")] IAsyncOperation<Pointer<IWorkflowPrintTicket>>** operation);

        [VtblIndex(7)]
        HRESULT GetSourceSpoolDataAsStreamContent([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowSpoolStreamContent **")] IPrintWorkflowSpoolStreamContent** result);

        [VtblIndex(8)]
        HRESULT GetSourceSpoolDataAsXpsObjectModel([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowObjectModelSourceFileContent **")] IPrintWorkflowObjectModelSourceFileContent** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CPrinting__CPrintTicket__CWorkflowPrintTicket_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IWorkflowPrintTicket>>**, int> GetJobPrintTicketAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowSpoolStreamContent **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPrintWorkflowSpoolStreamContent**, int> GetSourceSpoolDataAsStreamContent;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowObjectModelSourceFileContent **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPrintWorkflowObjectModelSourceFileContent**, int> GetSourceSpoolDataAsXpsObjectModel;
    }
}
