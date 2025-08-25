// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.printers.extensions.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPrintTaskConfiguration.xml' path='doc/member[@name="IPrintTaskConfiguration"]/*' />
[Guid("E3C22451-3AA4-4885-9240-311F5F8FBE9D")]
[NativeTypeName("struct IPrintTaskConfiguration : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintTaskConfiguration : IPrintTaskConfiguration.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IPrintTaskConfiguration);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskConfiguration*, Guid*, void**, int>)(lpVtbl[0]))((IPrintTaskConfiguration*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskConfiguration*, uint>)(lpVtbl[1]))((IPrintTaskConfiguration*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskConfiguration*, uint>)(lpVtbl[2]))((IPrintTaskConfiguration*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskConfiguration*, uint*, Guid**, int>)(lpVtbl[3]))((IPrintTaskConfiguration*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskConfiguration*, HSTRING*, int>)(lpVtbl[4]))((IPrintTaskConfiguration*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskConfiguration*, TrustLevel*, int>)(lpVtbl[5]))((IPrintTaskConfiguration*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPrintTaskConfiguration.xml' path='doc/member[@name="IPrintTaskConfiguration.get_PrinterExtensionContext"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_PrinterExtensionContext(IInspectable** context)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskConfiguration*, IInspectable**, int>)(lpVtbl[6]))((IPrintTaskConfiguration*)Unsafe.AsPointer(ref this), context);
    }

    /// <include file='IPrintTaskConfiguration.xml' path='doc/member[@name="IPrintTaskConfiguration.add_SaveRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT add_SaveRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CPrinters__CExtensions__CPrintTaskConfiguration_Windows__CDevices__CPrinters__CExtensions__CPrintTaskConfigurationSaveRequestedEventArgs_t *")] ITypedEventHandler<Pointer<IPrintTaskConfiguration>, Pointer<IPrintTaskConfigurationSaveRequestedEventArgs>>* eventHandler, EventRegistrationToken* eventCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskConfiguration*, ITypedEventHandler<Pointer<IPrintTaskConfiguration>, Pointer<IPrintTaskConfigurationSaveRequestedEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[7]))((IPrintTaskConfiguration*)Unsafe.AsPointer(ref this), eventHandler, eventCookie);
    }

    /// <include file='IPrintTaskConfiguration.xml' path='doc/member[@name="IPrintTaskConfiguration.remove_SaveRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT remove_SaveRequested(EventRegistrationToken eventCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskConfiguration*, EventRegistrationToken, int>)(lpVtbl[8]))((IPrintTaskConfiguration*)Unsafe.AsPointer(ref this), eventCookie);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_PrinterExtensionContext(IInspectable** context);

        [VtblIndex(7)]
        HRESULT add_SaveRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CPrinters__CExtensions__CPrintTaskConfiguration_Windows__CDevices__CPrinters__CExtensions__CPrintTaskConfigurationSaveRequestedEventArgs_t *")] ITypedEventHandler<Pointer<IPrintTaskConfiguration>, Pointer<IPrintTaskConfigurationSaveRequestedEventArgs>>* eventHandler, EventRegistrationToken* eventCookie);

        [VtblIndex(8)]
        HRESULT remove_SaveRequested(EventRegistrationToken eventCookie);
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

        [NativeTypeName("HRESULT (IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInspectable**, int> get_PrinterExtensionContext;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CPrinters__CExtensions__CPrintTaskConfiguration_Windows__CDevices__CPrinters__CExtensions__CPrintTaskConfigurationSaveRequestedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IPrintTaskConfiguration>, Pointer<IPrintTaskConfigurationSaveRequestedEventArgs>>*, EventRegistrationToken*, int> add_SaveRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_SaveRequested;
    }
}
