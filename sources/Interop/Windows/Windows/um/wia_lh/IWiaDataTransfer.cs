// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wia_lh.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IWiaDataTransfer.xml' path='doc/member[@name="IWiaDataTransfer"]/*' />
[Guid("A6CEF998-A5B0-11D2-A08F-00C04F72DC3C")]
[NativeTypeName("struct IWiaDataTransfer : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWiaDataTransfer : IWiaDataTransfer.Interface, INativeGuid
{
    /// <include file='IWiaDataTransfer.xml' path='doc/member[@name="IWiaDataTransfer.INativeGuid.NativeGuid"]/*' />
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IWiaDataTransfer);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaDataTransfer*, Guid*, void**, int>)(lpVtbl[0]))((IWiaDataTransfer*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaDataTransfer*, uint>)(lpVtbl[1]))((IWiaDataTransfer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaDataTransfer*, uint>)(lpVtbl[2]))((IWiaDataTransfer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWiaDataTransfer.xml' path='doc/member[@name="IWiaDataTransfer.idtGetData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT idtGetData([NativeTypeName("LPSTGMEDIUM")] STGMEDIUM* pMedium, IWiaDataCallback* pIWiaDataCallback)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaDataTransfer*, STGMEDIUM*, IWiaDataCallback*, int>)(lpVtbl[3]))((IWiaDataTransfer*)Unsafe.AsPointer(ref this), pMedium, pIWiaDataCallback);
    }

    /// <include file='IWiaDataTransfer.xml' path='doc/member[@name="IWiaDataTransfer.idtGetBandedData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT idtGetBandedData([NativeTypeName("PWIA_DATA_TRANSFER_INFO")] WIA_DATA_TRANSFER_INFO* pWiaDataTransInfo, IWiaDataCallback* pIWiaDataCallback)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaDataTransfer*, WIA_DATA_TRANSFER_INFO*, IWiaDataCallback*, int>)(lpVtbl[4]))((IWiaDataTransfer*)Unsafe.AsPointer(ref this), pWiaDataTransInfo, pIWiaDataCallback);
    }

    /// <include file='IWiaDataTransfer.xml' path='doc/member[@name="IWiaDataTransfer.idtQueryGetData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT idtQueryGetData(WIA_FORMAT_INFO* pfe)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaDataTransfer*, WIA_FORMAT_INFO*, int>)(lpVtbl[5]))((IWiaDataTransfer*)Unsafe.AsPointer(ref this), pfe);
    }

    /// <include file='IWiaDataTransfer.xml' path='doc/member[@name="IWiaDataTransfer.idtEnumWIA_FORMAT_INFO"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT idtEnumWIA_FORMAT_INFO(IEnumWIA_FORMAT_INFO** ppEnum)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaDataTransfer*, IEnumWIA_FORMAT_INFO**, int>)(lpVtbl[6]))((IWiaDataTransfer*)Unsafe.AsPointer(ref this), ppEnum);
    }

    /// <include file='IWiaDataTransfer.xml' path='doc/member[@name="IWiaDataTransfer.idtGetExtendedTransferInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT idtGetExtendedTransferInfo([NativeTypeName("PWIA_EXTENDED_TRANSFER_INFO")] WIA_EXTENDED_TRANSFER_INFO* pExtendedTransferInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaDataTransfer*, WIA_EXTENDED_TRANSFER_INFO*, int>)(lpVtbl[7]))((IWiaDataTransfer*)Unsafe.AsPointer(ref this), pExtendedTransferInfo);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT idtGetData([NativeTypeName("LPSTGMEDIUM")] STGMEDIUM* pMedium, IWiaDataCallback* pIWiaDataCallback);

        [VtblIndex(4)]
        HRESULT idtGetBandedData([NativeTypeName("PWIA_DATA_TRANSFER_INFO")] WIA_DATA_TRANSFER_INFO* pWiaDataTransInfo, IWiaDataCallback* pIWiaDataCallback);

        [VtblIndex(5)]
        HRESULT idtQueryGetData(WIA_FORMAT_INFO* pfe);

        [VtblIndex(6)]
        HRESULT idtEnumWIA_FORMAT_INFO(IEnumWIA_FORMAT_INFO** ppEnum);

        [VtblIndex(7)]
        HRESULT idtGetExtendedTransferInfo([NativeTypeName("PWIA_EXTENDED_TRANSFER_INFO")] WIA_EXTENDED_TRANSFER_INFO* pExtendedTransferInfo);
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

        [NativeTypeName("HRESULT (LPSTGMEDIUM, IWiaDataCallback *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, STGMEDIUM*, IWiaDataCallback*, int> idtGetData;

        [NativeTypeName("HRESULT (PWIA_DATA_TRANSFER_INFO, IWiaDataCallback *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WIA_DATA_TRANSFER_INFO*, IWiaDataCallback*, int> idtGetBandedData;

        [NativeTypeName("HRESULT (WIA_FORMAT_INFO *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WIA_FORMAT_INFO*, int> idtQueryGetData;

        [NativeTypeName("HRESULT (IEnumWIA_FORMAT_INFO **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEnumWIA_FORMAT_INFO**, int> idtEnumWIA_FORMAT_INFO;

        [NativeTypeName("HRESULT (PWIA_EXTENDED_TRANSFER_INFO) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WIA_EXTENDED_TRANSFER_INFO*, int> idtGetExtendedTransferInfo;
    }
}
