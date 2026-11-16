// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wia_lh.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IWiaLog.xml' path='doc/member[@name="IWiaLog"]/*' />
[Guid("A00C10B6-82A1-452F-8B6C-86062AAD6890")]
[NativeTypeName("struct IWiaLog : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWiaLog : IWiaLog.Interface, INativeGuid
{
    /// <include file='IWiaLog.xml' path='doc/member[@name="IWiaLog.INativeGuid.NativeGuid"]/*' />
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IWiaLog);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaLog*, Guid*, void**, int>)(lpVtbl[0]))((IWiaLog*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaLog*, uint>)(lpVtbl[1]))((IWiaLog*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaLog*, uint>)(lpVtbl[2]))((IWiaLog*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWiaLog.xml' path='doc/member[@name="IWiaLog.InitializeLog"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT InitializeLog([NativeTypeName("LONG")] int hInstance)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaLog*, int, int>)(lpVtbl[3]))((IWiaLog*)Unsafe.AsPointer(ref this), hInstance);
    }

    /// <include file='IWiaLog.xml' path='doc/member[@name="IWiaLog.hResult"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT hResult(HRESULT hResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaLog*, HRESULT, int>)(lpVtbl[4]))((IWiaLog*)Unsafe.AsPointer(ref this), hResult);
    }

    /// <include file='IWiaLog.xml' path='doc/member[@name="IWiaLog.Log"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Log([NativeTypeName("LONG")] int lFlags, [NativeTypeName("LONG")] int lResID, [NativeTypeName("LONG")] int lDetail, [NativeTypeName("BSTR")] char* bstrText)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaLog*, int, int, int, char*, int>)(lpVtbl[5]))((IWiaLog*)Unsafe.AsPointer(ref this), lFlags, lResID, lDetail, bstrText);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT InitializeLog([NativeTypeName("LONG")] int hInstance);

        [VtblIndex(4)]
        HRESULT hResult(HRESULT hResult);

        [VtblIndex(5)]
        HRESULT Log([NativeTypeName("LONG")] int lFlags, [NativeTypeName("LONG")] int lResID, [NativeTypeName("LONG")] int lDetail, [NativeTypeName("BSTR")] char* bstrText);
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

        [NativeTypeName("HRESULT (LONG) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int> InitializeLog;

        [NativeTypeName("HRESULT (HRESULT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HRESULT, int> hResult;

        [NativeTypeName("HRESULT (LONG, LONG, LONG, BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int, int, char*, int> Log;
    }
}
