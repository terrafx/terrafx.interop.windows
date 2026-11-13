// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wia_lh.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IWiaPreview.xml' path='doc/member[@name="IWiaPreview"]/*' />
[Guid("95C2B4FD-33F2-4D86-AD40-9431F0DF08F7")]
[NativeTypeName("struct IWiaPreview : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWiaPreview : IWiaPreview.Interface, INativeGuid
{
    /// <include file='IWiaPreview.xml' path='doc/member[@name="IWiaPreview.INativeGuid.NativeGuid"]/*' />
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IWiaPreview);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaPreview*, Guid*, void**, int>)(lpVtbl[0]))((IWiaPreview*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaPreview*, uint>)(lpVtbl[1]))((IWiaPreview*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaPreview*, uint>)(lpVtbl[2]))((IWiaPreview*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWiaPreview.xml' path='doc/member[@name="IWiaPreview.GetNewPreview"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetNewPreview([NativeTypeName("LONG")] int lFlags, IWiaItem2* pWiaItem2, IWiaTransferCallback* pWiaTransferCallback)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaPreview*, int, IWiaItem2*, IWiaTransferCallback*, int>)(lpVtbl[3]))((IWiaPreview*)Unsafe.AsPointer(ref this), lFlags, pWiaItem2, pWiaTransferCallback);
    }

    /// <include file='IWiaPreview.xml' path='doc/member[@name="IWiaPreview.UpdatePreview"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT UpdatePreview([NativeTypeName("LONG")] int lFlags, IWiaItem2* pChildWiaItem2, IWiaTransferCallback* pWiaTransferCallback)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaPreview*, int, IWiaItem2*, IWiaTransferCallback*, int>)(lpVtbl[4]))((IWiaPreview*)Unsafe.AsPointer(ref this), lFlags, pChildWiaItem2, pWiaTransferCallback);
    }

    /// <include file='IWiaPreview.xml' path='doc/member[@name="IWiaPreview.DetectRegions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT DetectRegions([NativeTypeName("LONG")] int lFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaPreview*, int, int>)(lpVtbl[5]))((IWiaPreview*)Unsafe.AsPointer(ref this), lFlags);
    }

    /// <include file='IWiaPreview.xml' path='doc/member[@name="IWiaPreview.Clear"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Clear()
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaPreview*, int>)(lpVtbl[6]))((IWiaPreview*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetNewPreview([NativeTypeName("LONG")] int lFlags, IWiaItem2* pWiaItem2, IWiaTransferCallback* pWiaTransferCallback);

        [VtblIndex(4)]
        HRESULT UpdatePreview([NativeTypeName("LONG")] int lFlags, IWiaItem2* pChildWiaItem2, IWiaTransferCallback* pWiaTransferCallback);

        [VtblIndex(5)]
        HRESULT DetectRegions([NativeTypeName("LONG")] int lFlags);

        [VtblIndex(6)]
        HRESULT Clear();
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

        [NativeTypeName("HRESULT (LONG, IWiaItem2 *, IWiaTransferCallback *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, IWiaItem2*, IWiaTransferCallback*, int> GetNewPreview;

        [NativeTypeName("HRESULT (LONG, IWiaItem2 *, IWiaTransferCallback *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, IWiaItem2*, IWiaTransferCallback*, int> UpdatePreview;

        [NativeTypeName("HRESULT (LONG) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int> DetectRegions;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Clear;
    }
}
