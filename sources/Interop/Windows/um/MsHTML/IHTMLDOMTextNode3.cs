// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3051073E-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLDOMTextNode3 : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLDOMTextNode3
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLDOMTextNode3*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLDOMTextNode3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLDOMTextNode3*, uint>)(lpVtbl[1]))((IHTMLDOMTextNode3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLDOMTextNode3*, uint>)(lpVtbl[2]))((IHTMLDOMTextNode3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLDOMTextNode3*, uint*, int>)(lpVtbl[3]))((IHTMLDOMTextNode3*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLDOMTextNode3*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLDOMTextNode3*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLDOMTextNode3*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLDOMTextNode3*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLDOMTextNode3*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLDOMTextNode3*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int substringData([NativeTypeName("long")] int offset, [NativeTypeName("long")] int Count, [NativeTypeName("BSTR *")] ushort** pbstrsubString)
        {
            return ((delegate* unmanaged<IHTMLDOMTextNode3*, int, int, ushort**, int>)(lpVtbl[7]))((IHTMLDOMTextNode3*)Unsafe.AsPointer(ref this), offset, Count, pbstrsubString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int insertData([NativeTypeName("long")] int offset, [NativeTypeName("BSTR")] ushort* bstrstring)
        {
            return ((delegate* unmanaged<IHTMLDOMTextNode3*, int, ushort*, int>)(lpVtbl[8]))((IHTMLDOMTextNode3*)Unsafe.AsPointer(ref this), offset, bstrstring);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int deleteData([NativeTypeName("long")] int offset, [NativeTypeName("long")] int Count)
        {
            return ((delegate* unmanaged<IHTMLDOMTextNode3*, int, int, int>)(lpVtbl[9]))((IHTMLDOMTextNode3*)Unsafe.AsPointer(ref this), offset, Count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int replaceData([NativeTypeName("long")] int offset, [NativeTypeName("long")] int Count, [NativeTypeName("BSTR")] ushort* bstrstring)
        {
            return ((delegate* unmanaged<IHTMLDOMTextNode3*, int, int, ushort*, int>)(lpVtbl[10]))((IHTMLDOMTextNode3*)Unsafe.AsPointer(ref this), offset, Count, bstrstring);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int splitText([NativeTypeName("long")] int offset, IHTMLDOMNode** pRetNode)
        {
            return ((delegate* unmanaged<IHTMLDOMTextNode3*, int, IHTMLDOMNode**, int>)(lpVtbl[11]))((IHTMLDOMTextNode3*)Unsafe.AsPointer(ref this), offset, pRetNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int get_wholeText([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLDOMTextNode3*, ushort**, int>)(lpVtbl[12]))((IHTMLDOMTextNode3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int replaceWholeText([NativeTypeName("BSTR")] ushort* bstrText, IHTMLDOMNode** ppRetNode)
        {
            return ((delegate* unmanaged<IHTMLDOMTextNode3*, ushort*, IHTMLDOMNode**, int>)(lpVtbl[13]))((IHTMLDOMTextNode3*)Unsafe.AsPointer(ref this), bstrText, ppRetNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int hasAttributes([NativeTypeName("VARIANT_BOOL *")] short* pfHasAttributes)
        {
            return ((delegate* unmanaged<IHTMLDOMTextNode3*, short*, int>)(lpVtbl[14]))((IHTMLDOMTextNode3*)Unsafe.AsPointer(ref this), pfHasAttributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int normalize()
        {
            return ((delegate* unmanaged<IHTMLDOMTextNode3*, int>)(lpVtbl[15]))((IHTMLDOMTextNode3*)Unsafe.AsPointer(ref this));
        }
    }
}
