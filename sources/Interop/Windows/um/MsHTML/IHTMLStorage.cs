// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("30510474-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLStorage : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLStorage
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLStorage*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLStorage*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLStorage*, uint>)(lpVtbl[1]))((IHTMLStorage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLStorage*, uint>)(lpVtbl[2]))((IHTMLStorage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLStorage*, uint*, int>)(lpVtbl[3]))((IHTMLStorage*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLStorage*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLStorage*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLStorage*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLStorage*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLStorage*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLStorage*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_length([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLStorage*, int*, int>)(lpVtbl[7]))((IHTMLStorage*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_remainingSpace([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLStorage*, int*, int>)(lpVtbl[8]))((IHTMLStorage*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT key([NativeTypeName("long")] int lIndex, [NativeTypeName("BSTR *")] ushort** __MIDL__IHTMLStorage0000)
        {
            return ((delegate* unmanaged<IHTMLStorage*, int, ushort**, int>)(lpVtbl[9]))((IHTMLStorage*)Unsafe.AsPointer(ref this), lIndex, __MIDL__IHTMLStorage0000);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT getItem([NativeTypeName("BSTR")] ushort* bstrKey, VARIANT* __MIDL__IHTMLStorage0001)
        {
            return ((delegate* unmanaged<IHTMLStorage*, ushort*, VARIANT*, int>)(lpVtbl[10]))((IHTMLStorage*)Unsafe.AsPointer(ref this), bstrKey, __MIDL__IHTMLStorage0001);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT setItem([NativeTypeName("BSTR")] ushort* bstrKey, [NativeTypeName("BSTR")] ushort* bstrValue)
        {
            return ((delegate* unmanaged<IHTMLStorage*, ushort*, ushort*, int>)(lpVtbl[11]))((IHTMLStorage*)Unsafe.AsPointer(ref this), bstrKey, bstrValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT removeItem([NativeTypeName("BSTR")] ushort* bstrKey)
        {
            return ((delegate* unmanaged<IHTMLStorage*, ushort*, int>)(lpVtbl[12]))((IHTMLStorage*)Unsafe.AsPointer(ref this), bstrKey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT clear()
        {
            return ((delegate* unmanaged<IHTMLStorage*, int>)(lpVtbl[13]))((IHTMLStorage*)Unsafe.AsPointer(ref this));
        }
    }
}
