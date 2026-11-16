// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wia_lh.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IWiaLogEx.xml' path='doc/member[@name="IWiaLogEx"]/*' />
[Guid("AF1F22AC-7A40-4787-B421-AEB47A1FBD0B")]
[NativeTypeName("struct IWiaLogEx : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWiaLogEx : IWiaLogEx.Interface, INativeGuid
{
    /// <include file='IWiaLogEx.xml' path='doc/member[@name="IWiaLogEx.INativeGuid.NativeGuid"]/*' />
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IWiaLogEx);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaLogEx*, Guid*, void**, int>)(lpVtbl[0]))((IWiaLogEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaLogEx*, uint>)(lpVtbl[1]))((IWiaLogEx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaLogEx*, uint>)(lpVtbl[2]))((IWiaLogEx*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWiaLogEx.xml' path='doc/member[@name="IWiaLogEx.InitializeLogEx"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT InitializeLogEx(byte* hInstance)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaLogEx*, byte*, int>)(lpVtbl[3]))((IWiaLogEx*)Unsafe.AsPointer(ref this), hInstance);
    }

    /// <include file='IWiaLogEx.xml' path='doc/member[@name="IWiaLogEx.hResult"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT hResult(HRESULT hResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaLogEx*, HRESULT, int>)(lpVtbl[4]))((IWiaLogEx*)Unsafe.AsPointer(ref this), hResult);
    }

    /// <include file='IWiaLogEx.xml' path='doc/member[@name="IWiaLogEx.Log"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Log([NativeTypeName("LONG")] int lFlags, [NativeTypeName("LONG")] int lResID, [NativeTypeName("LONG")] int lDetail, [NativeTypeName("BSTR")] char* bstrText)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaLogEx*, int, int, int, char*, int>)(lpVtbl[5]))((IWiaLogEx*)Unsafe.AsPointer(ref this), lFlags, lResID, lDetail, bstrText);
    }

    /// <include file='IWiaLogEx.xml' path='doc/member[@name="IWiaLogEx.hResultEx"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT hResultEx([NativeTypeName("LONG")] int lMethodId, HRESULT hResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaLogEx*, int, HRESULT, int>)(lpVtbl[6]))((IWiaLogEx*)Unsafe.AsPointer(ref this), lMethodId, hResult);
    }

    /// <include file='IWiaLogEx.xml' path='doc/member[@name="IWiaLogEx.LogEx"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT LogEx([NativeTypeName("LONG")] int lMethodId, [NativeTypeName("LONG")] int lFlags, [NativeTypeName("LONG")] int lResID, [NativeTypeName("LONG")] int lDetail, [NativeTypeName("BSTR")] char* bstrText)
    {
        return ((delegate* unmanaged[MemberFunction]<IWiaLogEx*, int, int, int, int, char*, int>)(lpVtbl[7]))((IWiaLogEx*)Unsafe.AsPointer(ref this), lMethodId, lFlags, lResID, lDetail, bstrText);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT InitializeLogEx(byte* hInstance);

        [VtblIndex(4)]
        HRESULT hResult(HRESULT hResult);

        [VtblIndex(5)]
        HRESULT Log([NativeTypeName("LONG")] int lFlags, [NativeTypeName("LONG")] int lResID, [NativeTypeName("LONG")] int lDetail, [NativeTypeName("BSTR")] char* bstrText);

        [VtblIndex(6)]
        HRESULT hResultEx([NativeTypeName("LONG")] int lMethodId, HRESULT hResult);

        [VtblIndex(7)]
        HRESULT LogEx([NativeTypeName("LONG")] int lMethodId, [NativeTypeName("LONG")] int lFlags, [NativeTypeName("LONG")] int lResID, [NativeTypeName("LONG")] int lDetail, [NativeTypeName("BSTR")] char* bstrText);
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

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> InitializeLogEx;

        [NativeTypeName("HRESULT (HRESULT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HRESULT, int> hResult;

        [NativeTypeName("HRESULT (LONG, LONG, LONG, BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int, int, char*, int> Log;

        [NativeTypeName("HRESULT (LONG, HRESULT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, HRESULT, int> hResultEx;

        [NativeTypeName("HRESULT (LONG, LONG, LONG, LONG, BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int, int, int, char*, int> LogEx;
    }
}
