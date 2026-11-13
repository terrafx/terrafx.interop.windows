// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/PrintPreview.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.DirectX;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IPrintPreviewDxgiPackageTarget.xml' path='doc/member[@name="IPrintPreviewDxgiPackageTarget"]/*' />
[Guid("1A6DD0AD-1E2A-4E99-A5BA-91F17818290E")]
[NativeTypeName("struct IPrintPreviewDxgiPackageTarget : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IPrintPreviewDxgiPackageTarget : IPrintPreviewDxgiPackageTarget.Interface, INativeGuid
{
    /// <include file='IPrintPreviewDxgiPackageTarget.xml' path='doc/member[@name="IPrintPreviewDxgiPackageTarget.INativeGuid.NativeGuid"]/*' />
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IPrintPreviewDxgiPackageTarget);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintPreviewDxgiPackageTarget*, Guid*, void**, int>)(lpVtbl[0]))((IPrintPreviewDxgiPackageTarget*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintPreviewDxgiPackageTarget*, uint>)(lpVtbl[1]))((IPrintPreviewDxgiPackageTarget*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintPreviewDxgiPackageTarget*, uint>)(lpVtbl[2]))((IPrintPreviewDxgiPackageTarget*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPrintPreviewDxgiPackageTarget.xml' path='doc/member[@name="IPrintPreviewDxgiPackageTarget.SetJobPageCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetJobPageCount(PageCountType countType, [NativeTypeName("UINT32")] uint count)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintPreviewDxgiPackageTarget*, PageCountType, uint, int>)(lpVtbl[3]))((IPrintPreviewDxgiPackageTarget*)Unsafe.AsPointer(ref this), countType, count);
    }

    /// <include file='IPrintPreviewDxgiPackageTarget.xml' path='doc/member[@name="IPrintPreviewDxgiPackageTarget.DrawPage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT DrawPage([NativeTypeName("UINT32")] uint jobPageNumber, IDXGISurface* pageImage, float dpiX, float dpiY)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintPreviewDxgiPackageTarget*, uint, IDXGISurface*, float, float, int>)(lpVtbl[4]))((IPrintPreviewDxgiPackageTarget*)Unsafe.AsPointer(ref this), jobPageNumber, pageImage, dpiX, dpiY);
    }

    /// <include file='IPrintPreviewDxgiPackageTarget.xml' path='doc/member[@name="IPrintPreviewDxgiPackageTarget.InvalidatePreview"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT InvalidatePreview()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintPreviewDxgiPackageTarget*, int>)(lpVtbl[5]))((IPrintPreviewDxgiPackageTarget*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetJobPageCount(PageCountType countType, [NativeTypeName("UINT32")] uint count);

        [VtblIndex(4)]
        HRESULT DrawPage([NativeTypeName("UINT32")] uint jobPageNumber, IDXGISurface* pageImage, float dpiX, float dpiY);

        [VtblIndex(5)]
        HRESULT InvalidatePreview();
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

        [NativeTypeName("HRESULT (PageCountType, UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PageCountType, uint, int> SetJobPageCount;

        [NativeTypeName("HRESULT (UINT32, IDXGISurface *, FLOAT, FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IDXGISurface*, float, float, int> DrawPage;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> InvalidatePreview;
    }
}
