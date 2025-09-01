// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.workflow.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPrintWorkflowJobIssueDetectedEventArgs.xml' path='doc/member[@name="IPrintWorkflowJobIssueDetectedEventArgs"]/*' />
[Guid("DE58A46E-E41E-550A-A9FB-4B1F93FB9D98")]
[NativeTypeName("struct IPrintWorkflowJobIssueDetectedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintWorkflowJobIssueDetectedEventArgs : IPrintWorkflowJobIssueDetectedEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IPrintWorkflowJobIssueDetectedEventArgs);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobIssueDetectedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IPrintWorkflowJobIssueDetectedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobIssueDetectedEventArgs*, uint>)(lpVtbl[1]))((IPrintWorkflowJobIssueDetectedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobIssueDetectedEventArgs*, uint>)(lpVtbl[2]))((IPrintWorkflowJobIssueDetectedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobIssueDetectedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IPrintWorkflowJobIssueDetectedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobIssueDetectedEventArgs*, HSTRING*, int>)(lpVtbl[4]))((IPrintWorkflowJobIssueDetectedEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobIssueDetectedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IPrintWorkflowJobIssueDetectedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPrintWorkflowJobIssueDetectedEventArgs.xml' path='doc/member[@name="IPrintWorkflowJobIssueDetectedEventArgs.get_JobIssueKind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_JobIssueKind([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowJobIssueKind *")] PrintWorkflowJobIssueKind* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobIssueDetectedEventArgs*, PrintWorkflowJobIssueKind*, int>)(lpVtbl[6]))((IPrintWorkflowJobIssueDetectedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintWorkflowJobIssueDetectedEventArgs.xml' path='doc/member[@name="IPrintWorkflowJobIssueDetectedEventArgs.get_ExtendedError"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ExtendedError(HRESULT* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobIssueDetectedEventArgs*, HRESULT*, int>)(lpVtbl[7]))((IPrintWorkflowJobIssueDetectedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintWorkflowJobIssueDetectedEventArgs.xml' path='doc/member[@name="IPrintWorkflowJobIssueDetectedEventArgs.get_SkipSystemErrorToast"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SkipSystemErrorToast([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobIssueDetectedEventArgs*, byte*, int>)(lpVtbl[8]))((IPrintWorkflowJobIssueDetectedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintWorkflowJobIssueDetectedEventArgs.xml' path='doc/member[@name="IPrintWorkflowJobIssueDetectedEventArgs.put_SkipSystemErrorToast"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_SkipSystemErrorToast([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobIssueDetectedEventArgs*, byte, int>)(lpVtbl[9]))((IPrintWorkflowJobIssueDetectedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintWorkflowJobIssueDetectedEventArgs.xml' path='doc/member[@name="IPrintWorkflowJobIssueDetectedEventArgs.get_PrinterJob"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_PrinterJob([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPrinterJob **")] IPrintWorkflowPrinterJob** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobIssueDetectedEventArgs*, IPrintWorkflowPrinterJob**, int>)(lpVtbl[10]))((IPrintWorkflowJobIssueDetectedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintWorkflowJobIssueDetectedEventArgs.xml' path='doc/member[@name="IPrintWorkflowJobIssueDetectedEventArgs.get_Configuration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Configuration([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowConfiguration **")] IPrintWorkflowConfiguration** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobIssueDetectedEventArgs*, IPrintWorkflowConfiguration**, int>)(lpVtbl[11]))((IPrintWorkflowJobIssueDetectedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintWorkflowJobIssueDetectedEventArgs.xml' path='doc/member[@name="IPrintWorkflowJobIssueDetectedEventArgs.get_UILauncher"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_UILauncher([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowUILauncher **")] IPrintWorkflowUILauncher** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobIssueDetectedEventArgs*, IPrintWorkflowUILauncher**, int>)(lpVtbl[12]))((IPrintWorkflowJobIssueDetectedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintWorkflowJobIssueDetectedEventArgs.xml' path='doc/member[@name="IPrintWorkflowJobIssueDetectedEventArgs.GetDeferral"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetDeferral([NativeTypeName("ABI::Windows::Foundation::IDeferral **")] IDeferral** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobIssueDetectedEventArgs*, IDeferral**, int>)(lpVtbl[13]))((IPrintWorkflowJobIssueDetectedEventArgs*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_JobIssueKind([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowJobIssueKind *")] PrintWorkflowJobIssueKind* value);

        [VtblIndex(7)]
        HRESULT get_ExtendedError(HRESULT* value);

        [VtblIndex(8)]
        HRESULT get_SkipSystemErrorToast([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT put_SkipSystemErrorToast([NativeTypeName("boolean")] byte value);

        [VtblIndex(10)]
        HRESULT get_PrinterJob([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPrinterJob **")] IPrintWorkflowPrinterJob** value);

        [VtblIndex(11)]
        HRESULT get_Configuration([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowConfiguration **")] IPrintWorkflowConfiguration** value);

        [VtblIndex(12)]
        HRESULT get_UILauncher([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowUILauncher **")] IPrintWorkflowUILauncher** value);

        [VtblIndex(13)]
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

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowJobIssueKind *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PrintWorkflowJobIssueKind*, int> get_JobIssueKind;

        [NativeTypeName("HRESULT (HRESULT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HRESULT*, int> get_ExtendedError;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_SkipSystemErrorToast;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_SkipSystemErrorToast;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPrinterJob **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPrintWorkflowPrinterJob**, int> get_PrinterJob;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowConfiguration **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPrintWorkflowConfiguration**, int> get_Configuration;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowUILauncher **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPrintWorkflowUILauncher**, int> get_UILauncher;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IDeferral **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDeferral**, int> GetDeferral;
    }
}
