// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.printers.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IIppPrintDevice2.xml' path='doc/member[@name="IIppPrintDevice2"]/*' />
[Guid("F7C844C9-9D21-5C63-AC20-3676915BE2D7")]
[NativeTypeName("struct IIppPrintDevice2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IIppPrintDevice2 : IIppPrintDevice2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IIppPrintDevice2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppPrintDevice2*, Guid*, void**, int>)(lpVtbl[0]))((IIppPrintDevice2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IIppPrintDevice2*, uint>)(lpVtbl[1]))((IIppPrintDevice2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IIppPrintDevice2*, uint>)(lpVtbl[2]))((IIppPrintDevice2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppPrintDevice2*, uint*, Guid**, int>)(lpVtbl[3]))((IIppPrintDevice2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppPrintDevice2*, HSTRING*, int>)(lpVtbl[4]))((IIppPrintDevice2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppPrintDevice2*, TrustLevel*, int>)(lpVtbl[5]))((IIppPrintDevice2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IIppPrintDevice2.xml' path='doc/member[@name="IIppPrintDevice2.GetMaxSupportedPdfSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetMaxSupportedPdfSize([NativeTypeName("UINT64 *")] ulong* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppPrintDevice2*, ulong*, int>)(lpVtbl[6]))((IIppPrintDevice2*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IIppPrintDevice2.xml' path='doc/member[@name="IIppPrintDevice2.GetMaxSupportedPdfVersion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetMaxSupportedPdfVersion(HSTRING* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppPrintDevice2*, HSTRING*, int>)(lpVtbl[7]))((IIppPrintDevice2*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IIppPrintDevice2.xml' path='doc/member[@name="IIppPrintDevice2.IsPdlPassthroughSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT IsPdlPassthroughSupported(HSTRING pdlContentType, [NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppPrintDevice2*, HSTRING, byte*, int>)(lpVtbl[8]))((IIppPrintDevice2*)Unsafe.AsPointer(ref this), pdlContentType, result);
    }

    /// <include file='IIppPrintDevice2.xml' path='doc/member[@name="IIppPrintDevice2.GetPdlPassthroughProvider"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetPdlPassthroughProvider([NativeTypeName("ABI::Windows::Devices::Printers::IPdlPassthroughProvider **")] IPdlPassthroughProvider** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppPrintDevice2*, IPdlPassthroughProvider**, int>)(lpVtbl[9]))((IIppPrintDevice2*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetMaxSupportedPdfSize([NativeTypeName("UINT64 *")] ulong* result);

        [VtblIndex(7)]
        HRESULT GetMaxSupportedPdfVersion(HSTRING* result);

        [VtblIndex(8)]
        HRESULT IsPdlPassthroughSupported(HSTRING pdlContentType, [NativeTypeName("boolean *")] byte* result);

        [VtblIndex(9)]
        HRESULT GetPdlPassthroughProvider([NativeTypeName("ABI::Windows::Devices::Printers::IPdlPassthroughProvider **")] IPdlPassthroughProvider** result);
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

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> GetMaxSupportedPdfSize;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetMaxSupportedPdfVersion;

        [NativeTypeName("HRESULT (HSTRING, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, byte*, int> IsPdlPassthroughSupported;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Printers::IPdlPassthroughProvider **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPdlPassthroughProvider**, int> GetPdlPassthroughProvider;
    }
}
