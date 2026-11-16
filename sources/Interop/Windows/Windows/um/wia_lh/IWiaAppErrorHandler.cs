// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wia_lh.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IWiaAppErrorHandler.xml' path='doc/member[@name="IWiaAppErrorHandler"]/*' />
[Guid("6C16186C-D0A6-400C-80F4-D26986A0E734")]
[NativeTypeName("struct IWiaAppErrorHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWiaAppErrorHandler : IWiaAppErrorHandler.Interface, INativeGuid
{
    /// <include file='IWiaAppErrorHandler.xml' path='doc/member[@name="IWiaAppErrorHandler.INativeGuid.NativeGuid"]/*' />
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IWiaAppErrorHandler);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaAppErrorHandler*, Guid*, void**, int>)(lpVtbl[0]))((IWiaAppErrorHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaAppErrorHandler*, uint>)(lpVtbl[1]))((IWiaAppErrorHandler*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaAppErrorHandler*, uint>)(lpVtbl[2]))((IWiaAppErrorHandler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWiaAppErrorHandler.xml' path='doc/member[@name="IWiaAppErrorHandler.GetWindow"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetWindow(HWND* phwnd)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaAppErrorHandler*, HWND*, int>)(lpVtbl[3]))((IWiaAppErrorHandler*)Unsafe.AsPointer(ref this), phwnd);
    }

    /// <include file='IWiaAppErrorHandler.xml' path='doc/member[@name="IWiaAppErrorHandler.ReportStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ReportStatus([NativeTypeName("LONG")] int lFlags, IWiaItem2* pWiaItem2, HRESULT hrStatus, [NativeTypeName("LONG")] int lPercentComplete)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaAppErrorHandler*, int, IWiaItem2*, HRESULT, int, int>)(lpVtbl[4]))((IWiaAppErrorHandler*)Unsafe.AsPointer(ref this), lFlags, pWiaItem2, hrStatus, lPercentComplete);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetWindow(HWND* phwnd);

        [VtblIndex(4)]
        HRESULT ReportStatus([NativeTypeName("LONG")] int lFlags, IWiaItem2* pWiaItem2, HRESULT hrStatus, [NativeTypeName("LONG")] int lPercentComplete);
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

        [NativeTypeName("HRESULT (HWND *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HWND*, int> GetWindow;

        [NativeTypeName("HRESULT (LONG, IWiaItem2 *, HRESULT, LONG) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, IWiaItem2*, HRESULT, int, int> ReportStatus;
    }
}
