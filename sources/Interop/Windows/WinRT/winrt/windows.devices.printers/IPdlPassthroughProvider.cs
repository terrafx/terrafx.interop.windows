// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.printers.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPdlPassthroughProvider.xml' path='doc/member[@name="IPdlPassthroughProvider"]/*' />
[Guid("23C71DD2-6117-553F-9378-180AF5849A49")]
[NativeTypeName("struct IPdlPassthroughProvider : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPdlPassthroughProvider : IPdlPassthroughProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPdlPassthroughProvider));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPdlPassthroughProvider*, Guid*, void**, int>)(lpVtbl[0]))((IPdlPassthroughProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPdlPassthroughProvider*, uint>)(lpVtbl[1]))((IPdlPassthroughProvider*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPdlPassthroughProvider*, uint>)(lpVtbl[2]))((IPdlPassthroughProvider*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPdlPassthroughProvider*, uint*, Guid**, int>)(lpVtbl[3]))((IPdlPassthroughProvider*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPdlPassthroughProvider*, HSTRING*, int>)(lpVtbl[4]))((IPdlPassthroughProvider*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPdlPassthroughProvider*, TrustLevel*, int>)(lpVtbl[5]))((IPdlPassthroughProvider*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPdlPassthroughProvider.xml' path='doc/member[@name="IPdlPassthroughProvider.get_SupportedPdlContentTypes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SupportedPdlContentTypes([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **")] IVectorView<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPdlPassthroughProvider*, IVectorView<HSTRING>**, int>)(lpVtbl[6]))((IPdlPassthroughProvider*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPdlPassthroughProvider.xml' path='doc/member[@name="IPdlPassthroughProvider.StartPrintJobWithTaskOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT StartPrintJobWithTaskOptions(HSTRING jobName, HSTRING pdlContentType, [NativeTypeName("ABI::Windows::Graphics::Printing::IPrintTaskOptionsCore *")] IPrintTaskOptionsCore* taskOptions, [NativeTypeName("ABI::Windows::Devices::Printers::IPageConfigurationSettings *")] IPageConfigurationSettings* pageConfigurationSettings, [NativeTypeName("ABI::Windows::Devices::Printers::IPdlPassthroughTarget **")] IPdlPassthroughTarget** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPdlPassthroughProvider*, HSTRING, HSTRING, IPrintTaskOptionsCore*, IPageConfigurationSettings*, IPdlPassthroughTarget**, int>)(lpVtbl[7]))((IPdlPassthroughProvider*)Unsafe.AsPointer(ref this), jobName, pdlContentType, taskOptions, pageConfigurationSettings, result);
    }

    /// <include file='IPdlPassthroughProvider.xml' path='doc/member[@name="IPdlPassthroughProvider.StartPrintJobWithPrintTicket"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT StartPrintJobWithPrintTicket(HSTRING jobName, HSTRING pdlContentType, [NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")] IInputStream* printTicket, [NativeTypeName("ABI::Windows::Devices::Printers::IPageConfigurationSettings *")] IPageConfigurationSettings* pageConfigurationSettings, [NativeTypeName("ABI::Windows::Devices::Printers::IPdlPassthroughTarget **")] IPdlPassthroughTarget** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPdlPassthroughProvider*, HSTRING, HSTRING, IInputStream*, IPageConfigurationSettings*, IPdlPassthroughTarget**, int>)(lpVtbl[8]))((IPdlPassthroughProvider*)Unsafe.AsPointer(ref this), jobName, pdlContentType, printTicket, pageConfigurationSettings, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SupportedPdlContentTypes([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **")] IVectorView<HSTRING>** value);

        [VtblIndex(7)]
        HRESULT StartPrintJobWithTaskOptions(HSTRING jobName, HSTRING pdlContentType, [NativeTypeName("ABI::Windows::Graphics::Printing::IPrintTaskOptionsCore *")] IPrintTaskOptionsCore* taskOptions, [NativeTypeName("ABI::Windows::Devices::Printers::IPageConfigurationSettings *")] IPageConfigurationSettings* pageConfigurationSettings, [NativeTypeName("ABI::Windows::Devices::Printers::IPdlPassthroughTarget **")] IPdlPassthroughTarget** result);

        [VtblIndex(8)]
        HRESULT StartPrintJobWithPrintTicket(HSTRING jobName, HSTRING pdlContentType, [NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")] IInputStream* printTicket, [NativeTypeName("ABI::Windows::Devices::Printers::IPageConfigurationSettings *")] IPageConfigurationSettings* pageConfigurationSettings, [NativeTypeName("ABI::Windows::Devices::Printers::IPdlPassthroughTarget **")] IPdlPassthroughTarget** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<HSTRING>**, int> get_SupportedPdlContentTypes;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Graphics::Printing::IPrintTaskOptionsCore *, ABI::Windows::Devices::Printers::IPageConfigurationSettings *, ABI::Windows::Devices::Printers::IPdlPassthroughTarget **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IPrintTaskOptionsCore*, IPageConfigurationSettings*, IPdlPassthroughTarget**, int> StartPrintJobWithTaskOptions;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::Storage::Streams::IInputStream *, ABI::Windows::Devices::Printers::IPageConfigurationSettings *, ABI::Windows::Devices::Printers::IPdlPassthroughTarget **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IInputStream*, IPageConfigurationSettings*, IPdlPassthroughTarget**, int> StartPrintJobWithPrintTicket;
    }
}
