// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wia_lh.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IWiaImageFilter.xml' path='doc/member[@name="IWiaImageFilter"]/*' />
[Guid("A8A79FFA-450B-41F1-8F87-849CCD94EBF6")]
[NativeTypeName("struct IWiaImageFilter : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWiaImageFilter : IWiaImageFilter.Interface, INativeGuid
{
    /// <include file='IWiaImageFilter.xml' path='doc/member[@name="IWiaImageFilter.INativeGuid.NativeGuid"]/*' />
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IWiaImageFilter);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaImageFilter*, Guid*, void**, int>)(lpVtbl[0]))((IWiaImageFilter*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaImageFilter*, uint>)(lpVtbl[1]))((IWiaImageFilter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaImageFilter*, uint>)(lpVtbl[2]))((IWiaImageFilter*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWiaImageFilter.xml' path='doc/member[@name="IWiaImageFilter.InitializeFilter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT InitializeFilter(IWiaItem2* pWiaItem2, IWiaTransferCallback* pWiaTransferCallback)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaImageFilter*, IWiaItem2*, IWiaTransferCallback*, int>)(lpVtbl[3]))((IWiaImageFilter*)Unsafe.AsPointer(ref this), pWiaItem2, pWiaTransferCallback);
    }

    /// <include file='IWiaImageFilter.xml' path='doc/member[@name="IWiaImageFilter.SetNewCallback"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetNewCallback(IWiaTransferCallback* pWiaTransferCallback)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaImageFilter*, IWiaTransferCallback*, int>)(lpVtbl[4]))((IWiaImageFilter*)Unsafe.AsPointer(ref this), pWiaTransferCallback);
    }

    /// <include file='IWiaImageFilter.xml' path='doc/member[@name="IWiaImageFilter.FilterPreviewImage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT FilterPreviewImage([NativeTypeName("LONG")] int lFlags, IWiaItem2* pWiaChildItem2, RECT InputImageExtents, IStream* pInputStream)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaImageFilter*, int, IWiaItem2*, RECT, IStream*, int>)(lpVtbl[5]))((IWiaImageFilter*)Unsafe.AsPointer(ref this), lFlags, pWiaChildItem2, InputImageExtents, pInputStream);
    }

    /// <include file='IWiaImageFilter.xml' path='doc/member[@name="IWiaImageFilter.ApplyProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ApplyProperties(IWiaPropertyStorage* pWiaPropertyStorage)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaImageFilter*, IWiaPropertyStorage*, int>)(lpVtbl[6]))((IWiaImageFilter*)Unsafe.AsPointer(ref this), pWiaPropertyStorage);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT InitializeFilter(IWiaItem2* pWiaItem2, IWiaTransferCallback* pWiaTransferCallback);

        [VtblIndex(4)]
        HRESULT SetNewCallback(IWiaTransferCallback* pWiaTransferCallback);

        [VtblIndex(5)]
        HRESULT FilterPreviewImage([NativeTypeName("LONG")] int lFlags, IWiaItem2* pWiaChildItem2, RECT InputImageExtents, IStream* pInputStream);

        [VtblIndex(6)]
        HRESULT ApplyProperties(IWiaPropertyStorage* pWiaPropertyStorage);
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

        [NativeTypeName("HRESULT (IWiaItem2 *, IWiaTransferCallback *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWiaItem2*, IWiaTransferCallback*, int> InitializeFilter;

        [NativeTypeName("HRESULT (IWiaTransferCallback *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWiaTransferCallback*, int> SetNewCallback;

        [NativeTypeName("HRESULT (LONG, IWiaItem2 *, RECT, IStream *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, IWiaItem2*, RECT, IStream*, int> FilterPreviewImage;

        [NativeTypeName("HRESULT (IWiaPropertyStorage *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWiaPropertyStorage*, int> ApplyProperties;
    }
}
