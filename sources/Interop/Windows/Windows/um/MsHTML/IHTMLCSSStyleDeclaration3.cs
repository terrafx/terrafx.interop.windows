// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IHTMLCSSStyleDeclaration3.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration3"]/*' />
[Guid("3051085C-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLCSSStyleDeclaration3 : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLCSSStyleDeclaration3 : IHTMLCSSStyleDeclaration3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IHTMLCSSStyleDeclaration3);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLCSSStyleDeclaration3*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLCSSStyleDeclaration3*, uint>)(lpVtbl[1]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLCSSStyleDeclaration3*, uint>)(lpVtbl[2]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLCSSStyleDeclaration3*, uint*, int>)(lpVtbl[3]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLCSSStyleDeclaration3*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] char** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLCSSStyleDeclaration3*, Guid*, char**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLCSSStyleDeclaration3*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLCSSStyleDeclaration3.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration3.put_flex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_flex([NativeTypeName("BSTR")] char* v)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLCSSStyleDeclaration3*, char*, int>)(lpVtbl[7]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration3.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration3.get_flex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_flex([NativeTypeName("BSTR *")] char** p)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLCSSStyleDeclaration3*, char**, int>)(lpVtbl[8]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration3.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration3.put_flexDirection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_flexDirection([NativeTypeName("BSTR")] char* v)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLCSSStyleDeclaration3*, char*, int>)(lpVtbl[9]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration3.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration3.get_flexDirection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_flexDirection([NativeTypeName("BSTR *")] char** p)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLCSSStyleDeclaration3*, char**, int>)(lpVtbl[10]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration3.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration3.put_flexWrap"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_flexWrap([NativeTypeName("BSTR")] char* v)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLCSSStyleDeclaration3*, char*, int>)(lpVtbl[11]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration3.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration3.get_flexWrap"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_flexWrap([NativeTypeName("BSTR *")] char** p)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLCSSStyleDeclaration3*, char**, int>)(lpVtbl[12]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration3.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration3.put_flexFlow"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_flexFlow([NativeTypeName("BSTR")] char* v)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLCSSStyleDeclaration3*, char*, int>)(lpVtbl[13]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration3.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration3.get_flexFlow"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_flexFlow([NativeTypeName("BSTR *")] char** p)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLCSSStyleDeclaration3*, char**, int>)(lpVtbl[14]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration3.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration3.put_flexGrow"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_flexGrow(VARIANT v)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLCSSStyleDeclaration3*, VARIANT, int>)(lpVtbl[15]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration3.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration3.get_flexGrow"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_flexGrow(VARIANT* p)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLCSSStyleDeclaration3*, VARIANT*, int>)(lpVtbl[16]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration3.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration3.put_flexShrink"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_flexShrink(VARIANT v)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLCSSStyleDeclaration3*, VARIANT, int>)(lpVtbl[17]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration3.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration3.get_flexShrink"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_flexShrink(VARIANT* p)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLCSSStyleDeclaration3*, VARIANT*, int>)(lpVtbl[18]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration3.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration3.put_flexBasis"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_flexBasis(VARIANT v)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLCSSStyleDeclaration3*, VARIANT, int>)(lpVtbl[19]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration3.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration3.get_flexBasis"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_flexBasis(VARIANT* p)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLCSSStyleDeclaration3*, VARIANT*, int>)(lpVtbl[20]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration3.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration3.put_justifyContent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_justifyContent([NativeTypeName("BSTR")] char* v)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLCSSStyleDeclaration3*, char*, int>)(lpVtbl[21]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration3.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration3.get_justifyContent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_justifyContent([NativeTypeName("BSTR *")] char** p)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLCSSStyleDeclaration3*, char**, int>)(lpVtbl[22]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration3.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration3.put_alignItems"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_alignItems([NativeTypeName("BSTR")] char* v)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLCSSStyleDeclaration3*, char*, int>)(lpVtbl[23]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration3.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration3.get_alignItems"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_alignItems([NativeTypeName("BSTR *")] char** p)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLCSSStyleDeclaration3*, char**, int>)(lpVtbl[24]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration3.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration3.put_alignSelf"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_alignSelf([NativeTypeName("BSTR")] char* v)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLCSSStyleDeclaration3*, char*, int>)(lpVtbl[25]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration3.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration3.get_alignSelf"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_alignSelf([NativeTypeName("BSTR *")] char** p)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLCSSStyleDeclaration3*, char**, int>)(lpVtbl[26]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration3.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration3.put_alignContent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT put_alignContent([NativeTypeName("BSTR")] char* v)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLCSSStyleDeclaration3*, char*, int>)(lpVtbl[27]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration3.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration3.get_alignContent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_alignContent([NativeTypeName("BSTR *")] char** p)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLCSSStyleDeclaration3*, char**, int>)(lpVtbl[28]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration3.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration3.put_borderImage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT put_borderImage([NativeTypeName("BSTR")] char* v)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLCSSStyleDeclaration3*, char*, int>)(lpVtbl[29]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration3.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration3.get_borderImage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_borderImage([NativeTypeName("BSTR *")] char** p)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLCSSStyleDeclaration3*, char**, int>)(lpVtbl[30]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration3.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration3.put_borderImageSource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT put_borderImageSource([NativeTypeName("BSTR")] char* v)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLCSSStyleDeclaration3*, char*, int>)(lpVtbl[31]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration3.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration3.get_borderImageSource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_borderImageSource([NativeTypeName("BSTR *")] char** p)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLCSSStyleDeclaration3*, char**, int>)(lpVtbl[32]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration3.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration3.put_borderImageSlice"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT put_borderImageSlice([NativeTypeName("BSTR")] char* v)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLCSSStyleDeclaration3*, char*, int>)(lpVtbl[33]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration3.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration3.get_borderImageSlice"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT get_borderImageSlice([NativeTypeName("BSTR *")] char** p)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLCSSStyleDeclaration3*, char**, int>)(lpVtbl[34]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration3.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration3.put_borderImageWidth"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT put_borderImageWidth([NativeTypeName("BSTR")] char* v)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLCSSStyleDeclaration3*, char*, int>)(lpVtbl[35]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration3.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration3.get_borderImageWidth"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT get_borderImageWidth([NativeTypeName("BSTR *")] char** p)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLCSSStyleDeclaration3*, char**, int>)(lpVtbl[36]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration3.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration3.put_borderImageOutset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT put_borderImageOutset([NativeTypeName("BSTR")] char* v)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLCSSStyleDeclaration3*, char*, int>)(lpVtbl[37]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration3.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration3.get_borderImageOutset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT get_borderImageOutset([NativeTypeName("BSTR *")] char** p)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLCSSStyleDeclaration3*, char**, int>)(lpVtbl[38]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration3.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration3.put_borderImageRepeat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT put_borderImageRepeat([NativeTypeName("BSTR")] char* v)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLCSSStyleDeclaration3*, char*, int>)(lpVtbl[39]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration3.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration3.get_borderImageRepeat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT get_borderImageRepeat([NativeTypeName("BSTR *")] char** p)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLCSSStyleDeclaration3*, char**, int>)(lpVtbl[40]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration3.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration3.put_msImeAlign"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT put_msImeAlign([NativeTypeName("BSTR")] char* v)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLCSSStyleDeclaration3*, char*, int>)(lpVtbl[41]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration3.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration3.get_msImeAlign"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT get_msImeAlign([NativeTypeName("BSTR *")] char** p)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLCSSStyleDeclaration3*, char**, int>)(lpVtbl[42]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration3.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration3.put_msTextCombineHorizontal"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT put_msTextCombineHorizontal([NativeTypeName("BSTR")] char* v)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLCSSStyleDeclaration3*, char*, int>)(lpVtbl[43]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration3.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration3.get_msTextCombineHorizontal"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT get_msTextCombineHorizontal([NativeTypeName("BSTR *")] char** p)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLCSSStyleDeclaration3*, char**, int>)(lpVtbl[44]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration3.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration3.put_touchAction"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT put_touchAction([NativeTypeName("BSTR")] char* v)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLCSSStyleDeclaration3*, char*, int>)(lpVtbl[45]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration3.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration3.get_touchAction"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT get_touchAction([NativeTypeName("BSTR *")] char** p)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLCSSStyleDeclaration3*, char**, int>)(lpVtbl[46]))((IHTMLCSSStyleDeclaration3*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_flex([NativeTypeName("BSTR")] char* v);

        [VtblIndex(8)]
        HRESULT get_flex([NativeTypeName("BSTR *")] char** p);

        [VtblIndex(9)]
        HRESULT put_flexDirection([NativeTypeName("BSTR")] char* v);

        [VtblIndex(10)]
        HRESULT get_flexDirection([NativeTypeName("BSTR *")] char** p);

        [VtblIndex(11)]
        HRESULT put_flexWrap([NativeTypeName("BSTR")] char* v);

        [VtblIndex(12)]
        HRESULT get_flexWrap([NativeTypeName("BSTR *")] char** p);

        [VtblIndex(13)]
        HRESULT put_flexFlow([NativeTypeName("BSTR")] char* v);

        [VtblIndex(14)]
        HRESULT get_flexFlow([NativeTypeName("BSTR *")] char** p);

        [VtblIndex(15)]
        HRESULT put_flexGrow(VARIANT v);

        [VtblIndex(16)]
        HRESULT get_flexGrow(VARIANT* p);

        [VtblIndex(17)]
        HRESULT put_flexShrink(VARIANT v);

        [VtblIndex(18)]
        HRESULT get_flexShrink(VARIANT* p);

        [VtblIndex(19)]
        HRESULT put_flexBasis(VARIANT v);

        [VtblIndex(20)]
        HRESULT get_flexBasis(VARIANT* p);

        [VtblIndex(21)]
        HRESULT put_justifyContent([NativeTypeName("BSTR")] char* v);

        [VtblIndex(22)]
        HRESULT get_justifyContent([NativeTypeName("BSTR *")] char** p);

        [VtblIndex(23)]
        HRESULT put_alignItems([NativeTypeName("BSTR")] char* v);

        [VtblIndex(24)]
        HRESULT get_alignItems([NativeTypeName("BSTR *")] char** p);

        [VtblIndex(25)]
        HRESULT put_alignSelf([NativeTypeName("BSTR")] char* v);

        [VtblIndex(26)]
        HRESULT get_alignSelf([NativeTypeName("BSTR *")] char** p);

        [VtblIndex(27)]
        HRESULT put_alignContent([NativeTypeName("BSTR")] char* v);

        [VtblIndex(28)]
        HRESULT get_alignContent([NativeTypeName("BSTR *")] char** p);

        [VtblIndex(29)]
        HRESULT put_borderImage([NativeTypeName("BSTR")] char* v);

        [VtblIndex(30)]
        HRESULT get_borderImage([NativeTypeName("BSTR *")] char** p);

        [VtblIndex(31)]
        HRESULT put_borderImageSource([NativeTypeName("BSTR")] char* v);

        [VtblIndex(32)]
        HRESULT get_borderImageSource([NativeTypeName("BSTR *")] char** p);

        [VtblIndex(33)]
        HRESULT put_borderImageSlice([NativeTypeName("BSTR")] char* v);

        [VtblIndex(34)]
        HRESULT get_borderImageSlice([NativeTypeName("BSTR *")] char** p);

        [VtblIndex(35)]
        HRESULT put_borderImageWidth([NativeTypeName("BSTR")] char* v);

        [VtblIndex(36)]
        HRESULT get_borderImageWidth([NativeTypeName("BSTR *")] char** p);

        [VtblIndex(37)]
        HRESULT put_borderImageOutset([NativeTypeName("BSTR")] char* v);

        [VtblIndex(38)]
        HRESULT get_borderImageOutset([NativeTypeName("BSTR *")] char** p);

        [VtblIndex(39)]
        HRESULT put_borderImageRepeat([NativeTypeName("BSTR")] char* v);

        [VtblIndex(40)]
        HRESULT get_borderImageRepeat([NativeTypeName("BSTR *")] char** p);

        [VtblIndex(41)]
        HRESULT put_msImeAlign([NativeTypeName("BSTR")] char* v);

        [VtblIndex(42)]
        HRESULT get_msImeAlign([NativeTypeName("BSTR *")] char** p);

        [VtblIndex(43)]
        HRESULT put_msTextCombineHorizontal([NativeTypeName("BSTR")] char* v);

        [VtblIndex(44)]
        HRESULT get_msTextCombineHorizontal([NativeTypeName("BSTR *")] char** p);

        [VtblIndex(45)]
        HRESULT put_touchAction([NativeTypeName("BSTR")] char* v);

        [VtblIndex(46)]
        HRESULT get_touchAction([NativeTypeName("BSTR *")] char** p);
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

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetTypeInfoCount;

        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;

        [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, char**, uint, uint, int*, int> GetIDsOfNames;

        [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_flex;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_flex;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_flexDirection;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_flexDirection;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_flexWrap;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_flexWrap;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_flexFlow;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_flexFlow;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, int> put_flexGrow;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_flexGrow;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, int> put_flexShrink;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_flexShrink;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT, int> put_flexBasis;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_flexBasis;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_justifyContent;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_justifyContent;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_alignItems;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_alignItems;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_alignSelf;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_alignSelf;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_alignContent;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_alignContent;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_borderImage;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_borderImage;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_borderImageSource;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_borderImageSource;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_borderImageSlice;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_borderImageSlice;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_borderImageWidth;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_borderImageWidth;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_borderImageOutset;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_borderImageOutset;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_borderImageRepeat;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_borderImageRepeat;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_msImeAlign;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_msImeAlign;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_msTextCombineHorizontal;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_msTextCombineHorizontal;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> put_touchAction;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_touchAction;
    }
}
