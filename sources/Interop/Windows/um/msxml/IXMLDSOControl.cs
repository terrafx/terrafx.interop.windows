// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msxml.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("310AFA62-0575-11D2-9CA9-0060B0EC3D39")]
    [NativeTypeName("struct IXMLDSOControl : IDispatch")]
    public unsafe partial struct IXMLDSOControl
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IXMLDSOControl*, Guid*, void**, int>)(lpVtbl[0]))((IXMLDSOControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IXMLDSOControl*, uint>)(lpVtbl[1]))((IXMLDSOControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IXMLDSOControl*, uint>)(lpVtbl[2]))((IXMLDSOControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IXMLDSOControl*, uint*, int>)(lpVtbl[3]))((IXMLDSOControl*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IXMLDSOControl*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IXMLDSOControl*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IXMLDSOControl*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IXMLDSOControl*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IXMLDSOControl*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IXMLDSOControl*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_XMLDocument(IXMLDOMDocument** ppDoc)
        {
            return ((delegate* unmanaged<IXMLDSOControl*, IXMLDOMDocument**, int>)(lpVtbl[7]))((IXMLDSOControl*)Unsafe.AsPointer(ref this), ppDoc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_XMLDocument(IXMLDOMDocument* ppDoc)
        {
            return ((delegate* unmanaged<IXMLDSOControl*, IXMLDOMDocument*, int>)(lpVtbl[8]))((IXMLDSOControl*)Unsafe.AsPointer(ref this), ppDoc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_JavaDSOCompatible([NativeTypeName("BOOL *")] int* fJavaDSOCompatible)
        {
            return ((delegate* unmanaged<IXMLDSOControl*, int*, int>)(lpVtbl[9]))((IXMLDSOControl*)Unsafe.AsPointer(ref this), fJavaDSOCompatible);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_JavaDSOCompatible([NativeTypeName("BOOL")] int fJavaDSOCompatible)
        {
            return ((delegate* unmanaged<IXMLDSOControl*, int, int>)(lpVtbl[10]))((IXMLDSOControl*)Unsafe.AsPointer(ref this), fJavaDSOCompatible);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_readyState([NativeTypeName("long *")] int* state)
        {
            return ((delegate* unmanaged<IXMLDSOControl*, int*, int>)(lpVtbl[11]))((IXMLDSOControl*)Unsafe.AsPointer(ref this), state);
        }
    }
}
