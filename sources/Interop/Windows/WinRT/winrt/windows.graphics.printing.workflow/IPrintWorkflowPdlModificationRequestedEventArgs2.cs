// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.workflow.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPrintWorkflowPdlModificationRequestedEventArgs2.xml' path='doc/member[@name="IPrintWorkflowPdlModificationRequestedEventArgs2"]/*' />
[Guid("8D692147-6C62-5E31-A0E7-D49F92C111C0")]
[NativeTypeName("struct IPrintWorkflowPdlModificationRequestedEventArgs2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintWorkflowPdlModificationRequestedEventArgs2 : IPrintWorkflowPdlModificationRequestedEventArgs2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IPrintWorkflowPdlModificationRequestedEventArgs2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPdlModificationRequestedEventArgs2*, Guid*, void**, int>)(lpVtbl[0]))((IPrintWorkflowPdlModificationRequestedEventArgs2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPdlModificationRequestedEventArgs2*, uint>)(lpVtbl[1]))((IPrintWorkflowPdlModificationRequestedEventArgs2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPdlModificationRequestedEventArgs2*, uint>)(lpVtbl[2]))((IPrintWorkflowPdlModificationRequestedEventArgs2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPdlModificationRequestedEventArgs2*, uint*, Guid**, int>)(lpVtbl[3]))((IPrintWorkflowPdlModificationRequestedEventArgs2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPdlModificationRequestedEventArgs2*, HSTRING*, int>)(lpVtbl[4]))((IPrintWorkflowPdlModificationRequestedEventArgs2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPdlModificationRequestedEventArgs2*, TrustLevel*, int>)(lpVtbl[5]))((IPrintWorkflowPdlModificationRequestedEventArgs2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPrintWorkflowPdlModificationRequestedEventArgs2.xml' path='doc/member[@name="IPrintWorkflowPdlModificationRequestedEventArgs2.CreateJobOnPrinterWithAttributes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateJobOnPrinterWithAttributes([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t *")] IIterable<Pointer<IKeyValuePair<HSTRING, Pointer<IIppAttributeValue>>>>* jobAttributes, HSTRING targetContentType, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t *")] IIterable<Pointer<IKeyValuePair<HSTRING, Pointer<IIppAttributeValue>>>>* operationAttributes, [NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowAttributesMergePolicy")] PrintWorkflowAttributesMergePolicy jobAttributesMergePolicy, [NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowAttributesMergePolicy")] PrintWorkflowAttributesMergePolicy operationAttributesMergePolicy, [NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPdlTargetStream **")] IPrintWorkflowPdlTargetStream** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPdlModificationRequestedEventArgs2*, IIterable<Pointer<IKeyValuePair<HSTRING, Pointer<IIppAttributeValue>>>>*, HSTRING, IIterable<Pointer<IKeyValuePair<HSTRING, Pointer<IIppAttributeValue>>>>*, PrintWorkflowAttributesMergePolicy, PrintWorkflowAttributesMergePolicy, IPrintWorkflowPdlTargetStream**, int>)(lpVtbl[6]))((IPrintWorkflowPdlModificationRequestedEventArgs2*)Unsafe.AsPointer(ref this), jobAttributes, targetContentType, operationAttributes, jobAttributesMergePolicy, operationAttributesMergePolicy, result);
    }

    /// <include file='IPrintWorkflowPdlModificationRequestedEventArgs2.xml' path='doc/member[@name="IPrintWorkflowPdlModificationRequestedEventArgs2.CreateJobOnPrinterWithAttributesBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateJobOnPrinterWithAttributesBuffer([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* jobAttributesBuffer, HSTRING targetContentType, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* operationAttributesBuffer, [NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowAttributesMergePolicy")] PrintWorkflowAttributesMergePolicy jobAttributesMergePolicy, [NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowAttributesMergePolicy")] PrintWorkflowAttributesMergePolicy operationAttributesMergePolicy, [NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPdlTargetStream **")] IPrintWorkflowPdlTargetStream** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPdlModificationRequestedEventArgs2*, IBuffer*, HSTRING, IBuffer*, PrintWorkflowAttributesMergePolicy, PrintWorkflowAttributesMergePolicy, IPrintWorkflowPdlTargetStream**, int>)(lpVtbl[7]))((IPrintWorkflowPdlModificationRequestedEventArgs2*)Unsafe.AsPointer(ref this), jobAttributesBuffer, targetContentType, operationAttributesBuffer, jobAttributesMergePolicy, operationAttributesMergePolicy, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateJobOnPrinterWithAttributes([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t *")] IIterable<Pointer<IKeyValuePair<HSTRING, Pointer<IIppAttributeValue>>>>* jobAttributes, HSTRING targetContentType, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t *")] IIterable<Pointer<IKeyValuePair<HSTRING, Pointer<IIppAttributeValue>>>>* operationAttributes, [NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowAttributesMergePolicy")] PrintWorkflowAttributesMergePolicy jobAttributesMergePolicy, [NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowAttributesMergePolicy")] PrintWorkflowAttributesMergePolicy operationAttributesMergePolicy, [NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPdlTargetStream **")] IPrintWorkflowPdlTargetStream** result);

        [VtblIndex(7)]
        HRESULT CreateJobOnPrinterWithAttributesBuffer([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* jobAttributesBuffer, HSTRING targetContentType, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* operationAttributesBuffer, [NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowAttributesMergePolicy")] PrintWorkflowAttributesMergePolicy jobAttributesMergePolicy, [NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowAttributesMergePolicy")] PrintWorkflowAttributesMergePolicy operationAttributesMergePolicy, [NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPdlTargetStream **")] IPrintWorkflowPdlTargetStream** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t *, HSTRING, ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t *, ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowAttributesMergePolicy, ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowAttributesMergePolicy, ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPdlTargetStream **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<Pointer<IKeyValuePair<HSTRING, Pointer<IIppAttributeValue>>>>*, HSTRING, IIterable<Pointer<IKeyValuePair<HSTRING, Pointer<IIppAttributeValue>>>>*, PrintWorkflowAttributesMergePolicy, PrintWorkflowAttributesMergePolicy, IPrintWorkflowPdlTargetStream**, int> CreateJobOnPrinterWithAttributes;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *, HSTRING, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowAttributesMergePolicy, ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowAttributesMergePolicy, ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPdlTargetStream **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, HSTRING, IBuffer*, PrintWorkflowAttributesMergePolicy, PrintWorkflowAttributesMergePolicy, IPrintWorkflowPdlTargetStream**, int> CreateJobOnPrinterWithAttributesBuffer;
    }
}
