// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.printers.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IVirtualPrinterSupportedFormat.xml' path='doc/member[@name="IVirtualPrinterSupportedFormat"]/*' />
[Guid("3801FA17-22B5-5DAB-AD38-39E47D6071AF")]
[NativeTypeName("struct IVirtualPrinterSupportedFormat : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IVirtualPrinterSupportedFormat : IVirtualPrinterSupportedFormat.Interface, INativeGuid
{
    /// <include file='IVirtualPrinterSupportedFormat.xml' path='doc/member[@name="IVirtualPrinterSupportedFormat.INativeGuid.NativeGuid"]/*' />
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IVirtualPrinterSupportedFormat);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IVirtualPrinterSupportedFormat*, Guid*, void**, int>)(lpVtbl[0]))((IVirtualPrinterSupportedFormat*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IVirtualPrinterSupportedFormat*, uint>)(lpVtbl[1]))((IVirtualPrinterSupportedFormat*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IVirtualPrinterSupportedFormat*, uint>)(lpVtbl[2]))((IVirtualPrinterSupportedFormat*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IVirtualPrinterSupportedFormat*, uint*, Guid**, int>)(lpVtbl[3]))((IVirtualPrinterSupportedFormat*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IVirtualPrinterSupportedFormat*, HSTRING*, int>)(lpVtbl[4]))((IVirtualPrinterSupportedFormat*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IVirtualPrinterSupportedFormat*, TrustLevel*, int>)(lpVtbl[5]))((IVirtualPrinterSupportedFormat*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IVirtualPrinterSupportedFormat.xml' path='doc/member[@name="IVirtualPrinterSupportedFormat.get_ContentType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ContentType(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVirtualPrinterSupportedFormat*, HSTRING*, int>)(lpVtbl[6]))((IVirtualPrinterSupportedFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVirtualPrinterSupportedFormat.xml' path='doc/member[@name="IVirtualPrinterSupportedFormat.put_ContentType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_ContentType(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVirtualPrinterSupportedFormat*, HSTRING, int>)(lpVtbl[7]))((IVirtualPrinterSupportedFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVirtualPrinterSupportedFormat.xml' path='doc/member[@name="IVirtualPrinterSupportedFormat.get_MaxSupportedVersion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_MaxSupportedVersion(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVirtualPrinterSupportedFormat*, HSTRING*, int>)(lpVtbl[8]))((IVirtualPrinterSupportedFormat*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVirtualPrinterSupportedFormat.xml' path='doc/member[@name="IVirtualPrinterSupportedFormat.put_MaxSupportedVersion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_MaxSupportedVersion(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVirtualPrinterSupportedFormat*, HSTRING, int>)(lpVtbl[9]))((IVirtualPrinterSupportedFormat*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ContentType(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_ContentType(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_MaxSupportedVersion(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_MaxSupportedVersion(HSTRING value);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ContentType;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_ContentType;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_MaxSupportedVersion;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_MaxSupportedVersion;
    }
}
