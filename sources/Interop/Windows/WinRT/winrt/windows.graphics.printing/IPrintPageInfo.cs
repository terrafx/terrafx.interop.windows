// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPrintPageInfo.xml' path='doc/member[@name="IPrintPageInfo"]/*' />
[Guid("DD4BE9C9-A6A1-4ADA-930E-DA872A4F23D3")]
[NativeTypeName("struct IPrintPageInfo : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintPageInfo : IPrintPageInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IPrintPageInfo);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintPageInfo*, Guid*, void**, int>)(lpVtbl[0]))((IPrintPageInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintPageInfo*, uint>)(lpVtbl[1]))((IPrintPageInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintPageInfo*, uint>)(lpVtbl[2]))((IPrintPageInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintPageInfo*, uint*, Guid**, int>)(lpVtbl[3]))((IPrintPageInfo*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintPageInfo*, HSTRING*, int>)(lpVtbl[4]))((IPrintPageInfo*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintPageInfo*, TrustLevel*, int>)(lpVtbl[5]))((IPrintPageInfo*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPrintPageInfo.xml' path='doc/member[@name="IPrintPageInfo.put_MediaSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_MediaSize([NativeTypeName("ABI::Windows::Graphics::Printing::PrintMediaSize")] PrintMediaSize value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintPageInfo*, PrintMediaSize, int>)(lpVtbl[6]))((IPrintPageInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintPageInfo.xml' path='doc/member[@name="IPrintPageInfo.get_MediaSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_MediaSize([NativeTypeName("ABI::Windows::Graphics::Printing::PrintMediaSize *")] PrintMediaSize* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintPageInfo*, PrintMediaSize*, int>)(lpVtbl[7]))((IPrintPageInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintPageInfo.xml' path='doc/member[@name="IPrintPageInfo.put_PageSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_PageSize([NativeTypeName("ABI::Windows::Foundation::Size")] Size value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintPageInfo*, Size, int>)(lpVtbl[8]))((IPrintPageInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintPageInfo.xml' path='doc/member[@name="IPrintPageInfo.get_PageSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_PageSize([NativeTypeName("ABI::Windows::Foundation::Size *")] Size* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintPageInfo*, Size*, int>)(lpVtbl[9]))((IPrintPageInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintPageInfo.xml' path='doc/member[@name="IPrintPageInfo.put_DpiX"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_DpiX([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintPageInfo*, uint, int>)(lpVtbl[10]))((IPrintPageInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintPageInfo.xml' path='doc/member[@name="IPrintPageInfo.get_DpiX"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_DpiX([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintPageInfo*, uint*, int>)(lpVtbl[11]))((IPrintPageInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintPageInfo.xml' path='doc/member[@name="IPrintPageInfo.put_DpiY"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_DpiY([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintPageInfo*, uint, int>)(lpVtbl[12]))((IPrintPageInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintPageInfo.xml' path='doc/member[@name="IPrintPageInfo.get_DpiY"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_DpiY([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintPageInfo*, uint*, int>)(lpVtbl[13]))((IPrintPageInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintPageInfo.xml' path='doc/member[@name="IPrintPageInfo.put_Orientation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_Orientation([NativeTypeName("ABI::Windows::Graphics::Printing::PrintOrientation")] PrintOrientation value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintPageInfo*, PrintOrientation, int>)(lpVtbl[14]))((IPrintPageInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintPageInfo.xml' path='doc/member[@name="IPrintPageInfo.get_Orientation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_Orientation([NativeTypeName("ABI::Windows::Graphics::Printing::PrintOrientation *")] PrintOrientation* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintPageInfo*, PrintOrientation*, int>)(lpVtbl[15]))((IPrintPageInfo*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_MediaSize([NativeTypeName("ABI::Windows::Graphics::Printing::PrintMediaSize")] PrintMediaSize value);

        [VtblIndex(7)]
        HRESULT get_MediaSize([NativeTypeName("ABI::Windows::Graphics::Printing::PrintMediaSize *")] PrintMediaSize* value);

        [VtblIndex(8)]
        HRESULT put_PageSize([NativeTypeName("ABI::Windows::Foundation::Size")] Size value);

        [VtblIndex(9)]
        HRESULT get_PageSize([NativeTypeName("ABI::Windows::Foundation::Size *")] Size* value);

        [VtblIndex(10)]
        HRESULT put_DpiX([NativeTypeName("UINT32")] uint value);

        [VtblIndex(11)]
        HRESULT get_DpiX([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(12)]
        HRESULT put_DpiY([NativeTypeName("UINT32")] uint value);

        [VtblIndex(13)]
        HRESULT get_DpiY([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(14)]
        HRESULT put_Orientation([NativeTypeName("ABI::Windows::Graphics::Printing::PrintOrientation")] PrintOrientation value);

        [VtblIndex(15)]
        HRESULT get_Orientation([NativeTypeName("ABI::Windows::Graphics::Printing::PrintOrientation *")] PrintOrientation* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::PrintMediaSize) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PrintMediaSize, int> put_MediaSize;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::PrintMediaSize *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PrintMediaSize*, int> get_MediaSize;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Size) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Size, int> put_PageSize;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Size *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Size*, int> get_PageSize;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_DpiX;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_DpiX;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_DpiY;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_DpiY;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::PrintOrientation) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PrintOrientation, int> put_Orientation;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Printing::PrintOrientation *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PrintOrientation*, int> get_Orientation;
    }
}
