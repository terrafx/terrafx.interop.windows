// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.workflow.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPrintWorkflowPdlModificationRequestedEventArgs.xml' path='doc/member[@name="IPrintWorkflowPdlModificationRequestedEventArgs"]/*' />
[Guid("1A339A61-2E13-5EDD-A707-CEEC61D7333B")]
[NativeTypeName("struct IPrintWorkflowPdlModificationRequestedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintWorkflowPdlModificationRequestedEventArgs : IPrintWorkflowPdlModificationRequestedEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IPrintWorkflowPdlModificationRequestedEventArgs);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPdlModificationRequestedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IPrintWorkflowPdlModificationRequestedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPdlModificationRequestedEventArgs*, uint>)(lpVtbl[1]))((IPrintWorkflowPdlModificationRequestedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPdlModificationRequestedEventArgs*, uint>)(lpVtbl[2]))((IPrintWorkflowPdlModificationRequestedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPdlModificationRequestedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IPrintWorkflowPdlModificationRequestedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPdlModificationRequestedEventArgs*, HSTRING*, int>)(lpVtbl[4]))((IPrintWorkflowPdlModificationRequestedEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPdlModificationRequestedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IPrintWorkflowPdlModificationRequestedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPrintWorkflowPdlModificationRequestedEventArgs.xml' path='doc/member[@name="IPrintWorkflowPdlModificationRequestedEventArgs.get_Configuration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Configuration([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowConfiguration **")] IPrintWorkflowConfiguration** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPdlModificationRequestedEventArgs*, IPrintWorkflowConfiguration**, int>)(lpVtbl[6]))((IPrintWorkflowPdlModificationRequestedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintWorkflowPdlModificationRequestedEventArgs.xml' path='doc/member[@name="IPrintWorkflowPdlModificationRequestedEventArgs.get_PrinterJob"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_PrinterJob([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPrinterJob **")] IPrintWorkflowPrinterJob** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPdlModificationRequestedEventArgs*, IPrintWorkflowPrinterJob**, int>)(lpVtbl[7]))((IPrintWorkflowPdlModificationRequestedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintWorkflowPdlModificationRequestedEventArgs.xml' path='doc/member[@name="IPrintWorkflowPdlModificationRequestedEventArgs.get_SourceContent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SourceContent([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPdlSourceContent **")] IPrintWorkflowPdlSourceContent** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPdlModificationRequestedEventArgs*, IPrintWorkflowPdlSourceContent**, int>)(lpVtbl[8]))((IPrintWorkflowPdlModificationRequestedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintWorkflowPdlModificationRequestedEventArgs.xml' path='doc/member[@name="IPrintWorkflowPdlModificationRequestedEventArgs.get_UILauncher"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_UILauncher([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowUILauncher **")] IPrintWorkflowUILauncher** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPdlModificationRequestedEventArgs*, IPrintWorkflowUILauncher**, int>)(lpVtbl[9]))((IPrintWorkflowPdlModificationRequestedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintWorkflowPdlModificationRequestedEventArgs.xml' path='doc/member[@name="IPrintWorkflowPdlModificationRequestedEventArgs.CreateJobOnPrinter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateJobOnPrinter(HSTRING targetContentType, [NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPdlTargetStream **")] IPrintWorkflowPdlTargetStream** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPdlModificationRequestedEventArgs*, HSTRING, IPrintWorkflowPdlTargetStream**, int>)(lpVtbl[10]))((IPrintWorkflowPdlModificationRequestedEventArgs*)Unsafe.AsPointer(ref this), targetContentType, result);
    }

    /// <include file='IPrintWorkflowPdlModificationRequestedEventArgs.xml' path='doc/member[@name="IPrintWorkflowPdlModificationRequestedEventArgs.CreateJobOnPrinterWithAttributes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateJobOnPrinterWithAttributes([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t *")] IIterable<Pointer<IKeyValuePair<HSTRING, Pointer<IIppAttributeValue>>>>* jobAttributes, HSTRING targetContentType, [NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPdlTargetStream **")] IPrintWorkflowPdlTargetStream** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPdlModificationRequestedEventArgs*, IIterable<Pointer<IKeyValuePair<HSTRING, Pointer<IIppAttributeValue>>>>*, HSTRING, IPrintWorkflowPdlTargetStream**, int>)(lpVtbl[11]))((IPrintWorkflowPdlModificationRequestedEventArgs*)Unsafe.AsPointer(ref this), jobAttributes, targetContentType, result);
    }

    /// <include file='IPrintWorkflowPdlModificationRequestedEventArgs.xml' path='doc/member[@name="IPrintWorkflowPdlModificationRequestedEventArgs.CreateJobOnPrinterWithAttributesBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateJobOnPrinterWithAttributesBuffer([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* jobAttributesBuffer, HSTRING targetContentType, [NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPdlTargetStream **")] IPrintWorkflowPdlTargetStream** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPdlModificationRequestedEventArgs*, IBuffer*, HSTRING, IPrintWorkflowPdlTargetStream**, int>)(lpVtbl[12]))((IPrintWorkflowPdlModificationRequestedEventArgs*)Unsafe.AsPointer(ref this), jobAttributesBuffer, targetContentType, result);
    }

    /// <include file='IPrintWorkflowPdlModificationRequestedEventArgs.xml' path='doc/member[@name="IPrintWorkflowPdlModificationRequestedEventArgs.GetPdlConverter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetPdlConverter([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowPdlConversionType")] PrintWorkflowPdlConversionType conversionType, [NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPdlConverter **")] IPrintWorkflowPdlConverter** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPdlModificationRequestedEventArgs*, PrintWorkflowPdlConversionType, IPrintWorkflowPdlConverter**, int>)(lpVtbl[13]))((IPrintWorkflowPdlModificationRequestedEventArgs*)Unsafe.AsPointer(ref this), conversionType, result);
    }

    /// <include file='IPrintWorkflowPdlModificationRequestedEventArgs.xml' path='doc/member[@name="IPrintWorkflowPdlModificationRequestedEventArgs.GetDeferral"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetDeferral([NativeTypeName("ABI::Windows::Foundation::IDeferral **")] IDeferral** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowPdlModificationRequestedEventArgs*, IDeferral**, int>)(lpVtbl[14]))((IPrintWorkflowPdlModificationRequestedEventArgs*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Configuration([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowConfiguration **")] IPrintWorkflowConfiguration** value);

        [VtblIndex(7)]
        HRESULT get_PrinterJob([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPrinterJob **")] IPrintWorkflowPrinterJob** value);

        [VtblIndex(8)]
        HRESULT get_SourceContent([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPdlSourceContent **")] IPrintWorkflowPdlSourceContent** value);

        [VtblIndex(9)]
        HRESULT get_UILauncher([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowUILauncher **")] IPrintWorkflowUILauncher** value);

        [VtblIndex(10)]
        HRESULT CreateJobOnPrinter(HSTRING targetContentType, [NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPdlTargetStream **")] IPrintWorkflowPdlTargetStream** result);

        [VtblIndex(11)]
        HRESULT CreateJobOnPrinterWithAttributes([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t *")] IIterable<Pointer<IKeyValuePair<HSTRING, Pointer<IIppAttributeValue>>>>* jobAttributes, HSTRING targetContentType, [NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPdlTargetStream **")] IPrintWorkflowPdlTargetStream** result);

        [VtblIndex(12)]
        HRESULT CreateJobOnPrinterWithAttributesBuffer([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* jobAttributesBuffer, HSTRING targetContentType, [NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPdlTargetStream **")] IPrintWorkflowPdlTargetStream** result);

        [VtblIndex(13)]
        HRESULT GetPdlConverter([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowPdlConversionType")] PrintWorkflowPdlConversionType conversionType, [NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPdlConverter **")] IPrintWorkflowPdlConverter** result);

        [VtblIndex(14)]
        HRESULT GetDeferral([NativeTypeName("ABI::Windows::Foundation::IDeferral **")] IDeferral** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowConfiguration **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPrintWorkflowConfiguration**, int> get_Configuration;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPrinterJob **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPrintWorkflowPrinterJob**, int> get_PrinterJob;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPdlSourceContent **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPrintWorkflowPdlSourceContent**, int> get_SourceContent;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowUILauncher **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPrintWorkflowUILauncher**, int> get_UILauncher;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPdlTargetStream **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IPrintWorkflowPdlTargetStream**, int> CreateJobOnPrinter;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t *, HSTRING, ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPdlTargetStream **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<Pointer<IKeyValuePair<HSTRING, Pointer<IIppAttributeValue>>>>*, HSTRING, IPrintWorkflowPdlTargetStream**, int> CreateJobOnPrinterWithAttributes;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *, HSTRING, ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPdlTargetStream **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, HSTRING, IPrintWorkflowPdlTargetStream**, int> CreateJobOnPrinterWithAttributesBuffer;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowPdlConversionType, ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPdlConverter **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PrintWorkflowPdlConversionType, IPrintWorkflowPdlConverter**, int> GetPdlConverter;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IDeferral **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDeferral**, int> GetDeferral;
    }
}
