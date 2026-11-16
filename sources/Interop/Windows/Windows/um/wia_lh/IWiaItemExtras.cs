// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wia_lh.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IWiaItemExtras.xml' path='doc/member[@name="IWiaItemExtras"]/*' />
[Guid("6291EF2C-36EF-4532-876A-8E132593778D")]
[NativeTypeName("struct IWiaItemExtras : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWiaItemExtras : IWiaItemExtras.Interface, INativeGuid
{
    /// <include file='IWiaItemExtras.xml' path='doc/member[@name="IWiaItemExtras.INativeGuid.NativeGuid"]/*' />
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IWiaItemExtras);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaItemExtras*, Guid*, void**, int>)(lpVtbl[0]))((IWiaItemExtras*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaItemExtras*, uint>)(lpVtbl[1]))((IWiaItemExtras*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaItemExtras*, uint>)(lpVtbl[2]))((IWiaItemExtras*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWiaItemExtras.xml' path='doc/member[@name="IWiaItemExtras.GetExtendedErrorInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetExtendedErrorInfo([NativeTypeName("BSTR *")] char** bstrErrorText)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaItemExtras*, char**, int>)(lpVtbl[3]))((IWiaItemExtras*)Unsafe.AsPointer(ref this), bstrErrorText);
    }

    /// <include file='IWiaItemExtras.xml' path='doc/member[@name="IWiaItemExtras.Escape"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Escape([NativeTypeName("DWORD")] uint dwEscapeCode, byte* lpInData, [NativeTypeName("DWORD")] uint cbInDataSize, byte* pOutData, [NativeTypeName("DWORD")] uint dwOutDataSize, [NativeTypeName("DWORD *")] uint* pdwActualDataSize)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaItemExtras*, uint, byte*, uint, byte*, uint, uint*, int>)(lpVtbl[4]))((IWiaItemExtras*)Unsafe.AsPointer(ref this), dwEscapeCode, lpInData, cbInDataSize, pOutData, dwOutDataSize, pdwActualDataSize);
    }

    /// <include file='IWiaItemExtras.xml' path='doc/member[@name="IWiaItemExtras.CancelPendingIO"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CancelPendingIO()
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaItemExtras*, int>)(lpVtbl[5]))((IWiaItemExtras*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetExtendedErrorInfo([NativeTypeName("BSTR *")] char** bstrErrorText);

        [VtblIndex(4)]
        HRESULT Escape([NativeTypeName("DWORD")] uint dwEscapeCode, byte* lpInData, [NativeTypeName("DWORD")] uint cbInDataSize, byte* pOutData, [NativeTypeName("DWORD")] uint dwOutDataSize, [NativeTypeName("DWORD *")] uint* pdwActualDataSize);

        [VtblIndex(5)]
        HRESULT CancelPendingIO();
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

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetExtendedErrorInfo;

        [NativeTypeName("HRESULT (DWORD, BYTE *, DWORD, BYTE *, DWORD, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, uint, byte*, uint, uint*, int> Escape;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> CancelPendingIO;
    }
}
