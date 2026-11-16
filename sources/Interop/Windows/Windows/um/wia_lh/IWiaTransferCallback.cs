// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wia_lh.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IWiaTransferCallback.xml' path='doc/member[@name="IWiaTransferCallback"]/*' />
[Guid("27D4EAAF-28A6-4CA5-9AAB-E678168B9527")]
[NativeTypeName("struct IWiaTransferCallback : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWiaTransferCallback : IWiaTransferCallback.Interface, INativeGuid
{
    /// <include file='IWiaTransferCallback.xml' path='doc/member[@name="IWiaTransferCallback.INativeGuid.NativeGuid"]/*' />
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IWiaTransferCallback);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaTransferCallback*, Guid*, void**, int>)(lpVtbl[0]))((IWiaTransferCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaTransferCallback*, uint>)(lpVtbl[1]))((IWiaTransferCallback*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaTransferCallback*, uint>)(lpVtbl[2]))((IWiaTransferCallback*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWiaTransferCallback.xml' path='doc/member[@name="IWiaTransferCallback.TransferCallback"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT TransferCallback([NativeTypeName("LONG")] int lFlags, WiaTransferParams* pWiaTransferParams)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaTransferCallback*, int, WiaTransferParams*, int>)(lpVtbl[3]))((IWiaTransferCallback*)Unsafe.AsPointer(ref this), lFlags, pWiaTransferParams);
    }

    /// <include file='IWiaTransferCallback.xml' path='doc/member[@name="IWiaTransferCallback.GetNextStream"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetNextStream([NativeTypeName("LONG")] int lFlags, [NativeTypeName("BSTR")] char* bstrItemName, [NativeTypeName("BSTR")] char* bstrFullItemName, IStream** ppDestination)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaTransferCallback*, int, char*, char*, IStream**, int>)(lpVtbl[4]))((IWiaTransferCallback*)Unsafe.AsPointer(ref this), lFlags, bstrItemName, bstrFullItemName, ppDestination);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT TransferCallback([NativeTypeName("LONG")] int lFlags, WiaTransferParams* pWiaTransferParams);

        [VtblIndex(4)]
        HRESULT GetNextStream([NativeTypeName("LONG")] int lFlags, [NativeTypeName("BSTR")] char* bstrItemName, [NativeTypeName("BSTR")] char* bstrFullItemName, IStream** ppDestination);
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

        [NativeTypeName("HRESULT (LONG, WiaTransferParams *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, WiaTransferParams*, int> TransferCallback;

        [NativeTypeName("HRESULT (LONG, BSTR, BSTR, IStream **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, char*, char*, IStream**, int> GetNextStream;
    }
}
