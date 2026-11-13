// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wia_lh.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IWiaTransfer.xml' path='doc/member[@name="IWiaTransfer"]/*' />
[Guid("C39D6942-2F4E-4D04-92FE-4EF4D3A1DE5A")]
[NativeTypeName("struct IWiaTransfer : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWiaTransfer : IWiaTransfer.Interface, INativeGuid
{
    /// <include file='IWiaTransfer.xml' path='doc/member[@name="IWiaTransfer.INativeGuid.NativeGuid"]/*' />
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IWiaTransfer);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaTransfer*, Guid*, void**, int>)(lpVtbl[0]))((IWiaTransfer*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaTransfer*, uint>)(lpVtbl[1]))((IWiaTransfer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaTransfer*, uint>)(lpVtbl[2]))((IWiaTransfer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWiaTransfer.xml' path='doc/member[@name="IWiaTransfer.Download"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Download([NativeTypeName("LONG")] int lFlags, IWiaTransferCallback* pIWiaTransferCallback)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaTransfer*, int, IWiaTransferCallback*, int>)(lpVtbl[3]))((IWiaTransfer*)Unsafe.AsPointer(ref this), lFlags, pIWiaTransferCallback);
    }

    /// <include file='IWiaTransfer.xml' path='doc/member[@name="IWiaTransfer.Upload"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Upload([NativeTypeName("LONG")] int lFlags, IStream* pSource, IWiaTransferCallback* pIWiaTransferCallback)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaTransfer*, int, IStream*, IWiaTransferCallback*, int>)(lpVtbl[4]))((IWiaTransfer*)Unsafe.AsPointer(ref this), lFlags, pSource, pIWiaTransferCallback);
    }

    /// <include file='IWiaTransfer.xml' path='doc/member[@name="IWiaTransfer.Cancel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Cancel()
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaTransfer*, int>)(lpVtbl[5]))((IWiaTransfer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWiaTransfer.xml' path='doc/member[@name="IWiaTransfer.EnumWIA_FORMAT_INFO"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT EnumWIA_FORMAT_INFO(IEnumWIA_FORMAT_INFO** ppEnum)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaTransfer*, IEnumWIA_FORMAT_INFO**, int>)(lpVtbl[6]))((IWiaTransfer*)Unsafe.AsPointer(ref this), ppEnum);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Download([NativeTypeName("LONG")] int lFlags, IWiaTransferCallback* pIWiaTransferCallback);

        [VtblIndex(4)]
        HRESULT Upload([NativeTypeName("LONG")] int lFlags, IStream* pSource, IWiaTransferCallback* pIWiaTransferCallback);

        [VtblIndex(5)]
        HRESULT Cancel();

        [VtblIndex(6)]
        HRESULT EnumWIA_FORMAT_INFO(IEnumWIA_FORMAT_INFO** ppEnum);
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

        [NativeTypeName("HRESULT (LONG, IWiaTransferCallback *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, IWiaTransferCallback*, int> Download;

        [NativeTypeName("HRESULT (LONG, IStream *, IWiaTransferCallback *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, IStream*, IWiaTransferCallback*, int> Upload;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Cancel;

        [NativeTypeName("HRESULT (IEnumWIA_FORMAT_INFO **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEnumWIA_FORMAT_INFO**, int> EnumWIA_FORMAT_INFO;
    }
}
