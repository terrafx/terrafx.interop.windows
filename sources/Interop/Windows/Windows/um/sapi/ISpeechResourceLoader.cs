// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='ISpeechResourceLoader.xml' path='doc/member[@name="ISpeechResourceLoader"]/*' />
[Guid("B9AC5783-FCD0-4B21-B119-B4F8DA8FD2C3")]
[NativeTypeName("struct ISpeechResourceLoader : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISpeechResourceLoader : ISpeechResourceLoader.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpeechResourceLoader));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechResourceLoader*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechResourceLoader*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechResourceLoader*, uint>)(lpVtbl[1]))((ISpeechResourceLoader*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechResourceLoader*, uint>)(lpVtbl[2]))((ISpeechResourceLoader*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechResourceLoader*, uint*, int>)(lpVtbl[3]))((ISpeechResourceLoader*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechResourceLoader*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechResourceLoader*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] char** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechResourceLoader*, Guid*, char**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechResourceLoader*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechResourceLoader*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechResourceLoader*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='ISpeechResourceLoader.xml' path='doc/member[@name="ISpeechResourceLoader.LoadResource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT LoadResource([NativeTypeName("BSTR")] char* bstrResourceUri, [NativeTypeName("VARIANT_BOOL")] short fAlwaysReload, IUnknown** pStream, [NativeTypeName("BSTR *")] char** pbstrMIMEType, [NativeTypeName("VARIANT_BOOL *")] short* pfModified, [NativeTypeName("BSTR *")] char** pbstrRedirectUrl)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechResourceLoader*, char*, short, IUnknown**, char**, short*, char**, int>)(lpVtbl[7]))((ISpeechResourceLoader*)Unsafe.AsPointer(ref this), bstrResourceUri, fAlwaysReload, pStream, pbstrMIMEType, pfModified, pbstrRedirectUrl);
    }

    /// <include file='ISpeechResourceLoader.xml' path='doc/member[@name="ISpeechResourceLoader.GetLocalCopy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetLocalCopy([NativeTypeName("BSTR")] char* bstrResourceUri, [NativeTypeName("BSTR *")] char** pbstrLocalPath, [NativeTypeName("BSTR *")] char** pbstrMIMEType, [NativeTypeName("BSTR *")] char** pbstrRedirectUrl)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechResourceLoader*, char*, char**, char**, char**, int>)(lpVtbl[8]))((ISpeechResourceLoader*)Unsafe.AsPointer(ref this), bstrResourceUri, pbstrLocalPath, pbstrMIMEType, pbstrRedirectUrl);
    }

    /// <include file='ISpeechResourceLoader.xml' path='doc/member[@name="ISpeechResourceLoader.ReleaseLocalCopy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ReleaseLocalCopy([NativeTypeName("BSTR")] char* pbstrLocalPath)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechResourceLoader*, char*, int>)(lpVtbl[9]))((ISpeechResourceLoader*)Unsafe.AsPointer(ref this), pbstrLocalPath);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT LoadResource([NativeTypeName("BSTR")] char* bstrResourceUri, [NativeTypeName("VARIANT_BOOL")] short fAlwaysReload, IUnknown** pStream, [NativeTypeName("BSTR *")] char** pbstrMIMEType, [NativeTypeName("VARIANT_BOOL *")] short* pfModified, [NativeTypeName("BSTR *")] char** pbstrRedirectUrl);

        [VtblIndex(8)]
        HRESULT GetLocalCopy([NativeTypeName("BSTR")] char* bstrResourceUri, [NativeTypeName("BSTR *")] char** pbstrLocalPath, [NativeTypeName("BSTR *")] char** pbstrMIMEType, [NativeTypeName("BSTR *")] char** pbstrRedirectUrl);

        [VtblIndex(9)]
        HRESULT ReleaseLocalCopy([NativeTypeName("BSTR")] char* pbstrLocalPath);
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

        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL, IUnknown **, BSTR *, VARIANT_BOOL *, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, short, IUnknown**, char**, short*, char**, int> LoadResource;

        [NativeTypeName("HRESULT (BSTR, BSTR *, BSTR *, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char**, char**, char**, int> GetLocalCopy;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> ReleaseLocalCopy;
    }
}
