// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.workflow.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPrintWorkflowJobNotificationEventArgs.xml' path='doc/member[@name="IPrintWorkflowJobNotificationEventArgs"]/*' />
[Guid("0AE16FBA-5398-5EBA-B472-978650186A9A")]
[NativeTypeName("struct IPrintWorkflowJobNotificationEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintWorkflowJobNotificationEventArgs : IPrintWorkflowJobNotificationEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IPrintWorkflowJobNotificationEventArgs);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobNotificationEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IPrintWorkflowJobNotificationEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobNotificationEventArgs*, uint>)(lpVtbl[1]))((IPrintWorkflowJobNotificationEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobNotificationEventArgs*, uint>)(lpVtbl[2]))((IPrintWorkflowJobNotificationEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobNotificationEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IPrintWorkflowJobNotificationEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobNotificationEventArgs*, HSTRING*, int>)(lpVtbl[4]))((IPrintWorkflowJobNotificationEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobNotificationEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IPrintWorkflowJobNotificationEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPrintWorkflowJobNotificationEventArgs.xml' path='doc/member[@name="IPrintWorkflowJobNotificationEventArgs.get_Configuration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Configuration([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowConfiguration **")] IPrintWorkflowConfiguration** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobNotificationEventArgs*, IPrintWorkflowConfiguration**, int>)(lpVtbl[6]))((IPrintWorkflowJobNotificationEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintWorkflowJobNotificationEventArgs.xml' path='doc/member[@name="IPrintWorkflowJobNotificationEventArgs.get_PrinterJob"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_PrinterJob([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPrinterJob **")] IPrintWorkflowPrinterJob** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobNotificationEventArgs*, IPrintWorkflowPrinterJob**, int>)(lpVtbl[7]))((IPrintWorkflowJobNotificationEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintWorkflowJobNotificationEventArgs.xml' path='doc/member[@name="IPrintWorkflowJobNotificationEventArgs.GetDeferral"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDeferral([NativeTypeName("ABI::Windows::Foundation::IDeferral **")] IDeferral** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintWorkflowJobNotificationEventArgs*, IDeferral**, int>)(lpVtbl[8]))((IPrintWorkflowJobNotificationEventArgs*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Configuration([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowConfiguration **")] IPrintWorkflowConfiguration** value);

        [VtblIndex(7)]
        HRESULT get_PrinterJob([NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::IPrintWorkflowPrinterJob **")] IPrintWorkflowPrinterJob** value);

        [VtblIndex(8)]
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IDeferral **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDeferral**, int> GetDeferral;
    }
}
