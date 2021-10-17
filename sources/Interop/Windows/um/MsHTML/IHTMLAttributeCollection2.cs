// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F80A-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLAttributeCollection2 : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLAttributeCollection2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLAttributeCollection2*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLAttributeCollection2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLAttributeCollection2*, uint>)(lpVtbl[1]))((IHTMLAttributeCollection2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLAttributeCollection2*, uint>)(lpVtbl[2]))((IHTMLAttributeCollection2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLAttributeCollection2*, uint*, int>)(lpVtbl[3]))((IHTMLAttributeCollection2*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLAttributeCollection2*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLAttributeCollection2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLAttributeCollection2*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLAttributeCollection2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLAttributeCollection2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLAttributeCollection2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int getNamedItem([NativeTypeName("BSTR")] ushort* bstrName, IHTMLDOMAttribute** newretNode)
        {
            return ((delegate* unmanaged<IHTMLAttributeCollection2*, ushort*, IHTMLDOMAttribute**, int>)(lpVtbl[7]))((IHTMLAttributeCollection2*)Unsafe.AsPointer(ref this), bstrName, newretNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int setNamedItem(IHTMLDOMAttribute* ppNode, IHTMLDOMAttribute** newretNode)
        {
            return ((delegate* unmanaged<IHTMLAttributeCollection2*, IHTMLDOMAttribute*, IHTMLDOMAttribute**, int>)(lpVtbl[8]))((IHTMLAttributeCollection2*)Unsafe.AsPointer(ref this), ppNode, newretNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int removeNamedItem([NativeTypeName("BSTR")] ushort* bstrName, IHTMLDOMAttribute** newretNode)
        {
            return ((delegate* unmanaged<IHTMLAttributeCollection2*, ushort*, IHTMLDOMAttribute**, int>)(lpVtbl[9]))((IHTMLAttributeCollection2*)Unsafe.AsPointer(ref this), bstrName, newretNode);
        }
    }
}
