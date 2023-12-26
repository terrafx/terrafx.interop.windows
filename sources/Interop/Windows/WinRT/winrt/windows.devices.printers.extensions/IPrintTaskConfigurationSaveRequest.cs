// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.printers.extensions.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPrintTaskConfigurationSaveRequest.xml' path='doc/member[@name="IPrintTaskConfigurationSaveRequest"]/*' />
[Guid("EEAF2FCB-621E-4B62-AC77-B281CCE08D60")]
[NativeTypeName("struct IPrintTaskConfigurationSaveRequest : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintTaskConfigurationSaveRequest : IPrintTaskConfigurationSaveRequest.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPrintTaskConfigurationSaveRequest));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskConfigurationSaveRequest*, Guid*, void**, int>)(lpVtbl[0]))((IPrintTaskConfigurationSaveRequest*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskConfigurationSaveRequest*, uint>)(lpVtbl[1]))((IPrintTaskConfigurationSaveRequest*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskConfigurationSaveRequest*, uint>)(lpVtbl[2]))((IPrintTaskConfigurationSaveRequest*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskConfigurationSaveRequest*, uint*, Guid**, int>)(lpVtbl[3]))((IPrintTaskConfigurationSaveRequest*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskConfigurationSaveRequest*, HSTRING*, int>)(lpVtbl[4]))((IPrintTaskConfigurationSaveRequest*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskConfigurationSaveRequest*, TrustLevel*, int>)(lpVtbl[5]))((IPrintTaskConfigurationSaveRequest*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPrintTaskConfigurationSaveRequest.xml' path='doc/member[@name="IPrintTaskConfigurationSaveRequest.Cancel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Cancel()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskConfigurationSaveRequest*, int>)(lpVtbl[6]))((IPrintTaskConfigurationSaveRequest*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPrintTaskConfigurationSaveRequest.xml' path='doc/member[@name="IPrintTaskConfigurationSaveRequest.Save"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Save(IInspectable* printerExtensionContext)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskConfigurationSaveRequest*, IInspectable*, int>)(lpVtbl[7]))((IPrintTaskConfigurationSaveRequest*)Unsafe.AsPointer(ref this), printerExtensionContext);
    }

    /// <include file='IPrintTaskConfigurationSaveRequest.xml' path='doc/member[@name="IPrintTaskConfigurationSaveRequest.GetDeferral"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDeferral([NativeTypeName("ABI::Windows::Devices::Printers::Extensions::IPrintTaskConfigurationSaveRequestedDeferral **")] IPrintTaskConfigurationSaveRequestedDeferral** deferral)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskConfigurationSaveRequest*, IPrintTaskConfigurationSaveRequestedDeferral**, int>)(lpVtbl[8]))((IPrintTaskConfigurationSaveRequest*)Unsafe.AsPointer(ref this), deferral);
    }

    /// <include file='IPrintTaskConfigurationSaveRequest.xml' path='doc/member[@name="IPrintTaskConfigurationSaveRequest.get_Deadline"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Deadline([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskConfigurationSaveRequest*, WinRTDateTime*, int>)(lpVtbl[9]))((IPrintTaskConfigurationSaveRequest*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Cancel();

        [VtblIndex(7)]
        HRESULT Save(IInspectable* printerExtensionContext);

        [VtblIndex(8)]
        HRESULT GetDeferral([NativeTypeName("ABI::Windows::Devices::Printers::Extensions::IPrintTaskConfigurationSaveRequestedDeferral **")] IPrintTaskConfigurationSaveRequestedDeferral** deferral);

        [VtblIndex(9)]
        HRESULT get_Deadline([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value);
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

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Cancel;

        [NativeTypeName("HRESULT (IInspectable *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInspectable*, int> Save;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Printers::Extensions::IPrintTaskConfigurationSaveRequestedDeferral **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPrintTaskConfigurationSaveRequestedDeferral**, int> GetDeferral;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime*, int> get_Deadline;
    }
}
