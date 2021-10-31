// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("30510417-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLDocument6 : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLDocument6
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLDocument6*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLDocument6*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLDocument6*, uint>)(lpVtbl[1]))((IHTMLDocument6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLDocument6*, uint>)(lpVtbl[2]))((IHTMLDocument6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLDocument6*, uint*, int>)(lpVtbl[3]))((IHTMLDocument6*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLDocument6*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLDocument6*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLDocument6*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLDocument6*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLDocument6*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLDocument6*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_compatible(IHTMLDocumentCompatibleInfoCollection** p)
        {
            return ((delegate* unmanaged<IHTMLDocument6*, IHTMLDocumentCompatibleInfoCollection**, int>)(lpVtbl[7]))((IHTMLDocument6*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_documentMode(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument6*, VARIANT*, int>)(lpVtbl[8]))((IHTMLDocument6*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT put_onstorage(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument6*, VARIANT, int>)(lpVtbl[9]))((IHTMLDocument6*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_onstorage(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument6*, VARIANT*, int>)(lpVtbl[10]))((IHTMLDocument6*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT put_onstoragecommit(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument6*, VARIANT, int>)(lpVtbl[11]))((IHTMLDocument6*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_onstoragecommit(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument6*, VARIANT*, int>)(lpVtbl[12]))((IHTMLDocument6*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT getElementById([NativeTypeName("BSTR")] ushort* bstrId, IHTMLElement2** ppRetElement)
        {
            return ((delegate* unmanaged<IHTMLDocument6*, ushort*, IHTMLElement2**, int>)(lpVtbl[13]))((IHTMLDocument6*)Unsafe.AsPointer(ref this), bstrId, ppRetElement);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT updateSettings()
        {
            return ((delegate* unmanaged<IHTMLDocument6*, int>)(lpVtbl[14]))((IHTMLDocument6*)Unsafe.AsPointer(ref this));
        }
    }
}
