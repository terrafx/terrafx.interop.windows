// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wia_lh.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IWiaErrorHandler.xml' path='doc/member[@name="IWiaErrorHandler"]/*' />
[Guid("0E4A51B1-BC1F-443D-A835-72E890759EF3")]
[NativeTypeName("struct IWiaErrorHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWiaErrorHandler : IWiaErrorHandler.Interface, INativeGuid
{
    /// <include file='IWiaErrorHandler.xml' path='doc/member[@name="IWiaErrorHandler.INativeGuid.NativeGuid"]/*' />
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IWiaErrorHandler);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaErrorHandler*, Guid*, void**, int>)(lpVtbl[0]))((IWiaErrorHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaErrorHandler*, uint>)(lpVtbl[1]))((IWiaErrorHandler*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaErrorHandler*, uint>)(lpVtbl[2]))((IWiaErrorHandler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWiaErrorHandler.xml' path='doc/member[@name="IWiaErrorHandler.ReportStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ReportStatus([NativeTypeName("LONG")] int lFlags, HWND hwndParent, IWiaItem2* pWiaItem2, HRESULT hrStatus, [NativeTypeName("LONG")] int lPercentComplete)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaErrorHandler*, int, HWND, IWiaItem2*, HRESULT, int, int>)(lpVtbl[3]))((IWiaErrorHandler*)Unsafe.AsPointer(ref this), lFlags, hwndParent, pWiaItem2, hrStatus, lPercentComplete);
    }

    /// <include file='IWiaErrorHandler.xml' path='doc/member[@name="IWiaErrorHandler.GetStatusDescription"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetStatusDescription([NativeTypeName("LONG")] int lFlags, IWiaItem2* pWiaItem2, HRESULT hrStatus, [NativeTypeName("BSTR *")] char** pbstrDescription)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaErrorHandler*, int, IWiaItem2*, HRESULT, char**, int>)(lpVtbl[4]))((IWiaErrorHandler*)Unsafe.AsPointer(ref this), lFlags, pWiaItem2, hrStatus, pbstrDescription);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ReportStatus([NativeTypeName("LONG")] int lFlags, HWND hwndParent, IWiaItem2* pWiaItem2, HRESULT hrStatus, [NativeTypeName("LONG")] int lPercentComplete);

        [VtblIndex(4)]
        HRESULT GetStatusDescription([NativeTypeName("LONG")] int lFlags, IWiaItem2* pWiaItem2, HRESULT hrStatus, [NativeTypeName("BSTR *")] char** pbstrDescription);
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

        [NativeTypeName("HRESULT (LONG, HWND, IWiaItem2 *, HRESULT, LONG) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, HWND, IWiaItem2*, HRESULT, int, int> ReportStatus;

        [NativeTypeName("HRESULT (LONG, IWiaItem2 *, HRESULT, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, IWiaItem2*, HRESULT, char**, int> GetStatusDescription;
    }
}
