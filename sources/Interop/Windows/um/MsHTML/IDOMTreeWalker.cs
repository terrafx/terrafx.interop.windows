// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("30510748-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IDOMTreeWalker : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IDOMTreeWalker
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDOMTreeWalker*, Guid*, void**, int>)(lpVtbl[0]))((IDOMTreeWalker*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDOMTreeWalker*, uint>)(lpVtbl[1]))((IDOMTreeWalker*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDOMTreeWalker*, uint>)(lpVtbl[2]))((IDOMTreeWalker*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IDOMTreeWalker*, uint*, int>)(lpVtbl[3]))((IDOMTreeWalker*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IDOMTreeWalker*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IDOMTreeWalker*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IDOMTreeWalker*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IDOMTreeWalker*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IDOMTreeWalker*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IDOMTreeWalker*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_root(IDispatch** p)
        {
            return ((delegate* unmanaged<IDOMTreeWalker*, IDispatch**, int>)(lpVtbl[7]))((IDOMTreeWalker*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_whatToShow([NativeTypeName("ULONG *")] uint* p)
        {
            return ((delegate* unmanaged<IDOMTreeWalker*, uint*, int>)(lpVtbl[8]))((IDOMTreeWalker*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_filter(IDispatch** p)
        {
            return ((delegate* unmanaged<IDOMTreeWalker*, IDispatch**, int>)(lpVtbl[9]))((IDOMTreeWalker*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_expandEntityReferences([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IDOMTreeWalker*, short*, int>)(lpVtbl[10]))((IDOMTreeWalker*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT putref_currentNode(IDispatch* v)
        {
            return ((delegate* unmanaged<IDOMTreeWalker*, IDispatch*, int>)(lpVtbl[11]))((IDOMTreeWalker*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_currentNode(IDispatch** p)
        {
            return ((delegate* unmanaged<IDOMTreeWalker*, IDispatch**, int>)(lpVtbl[12]))((IDOMTreeWalker*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT parentNode(IDispatch** ppRetNode)
        {
            return ((delegate* unmanaged<IDOMTreeWalker*, IDispatch**, int>)(lpVtbl[13]))((IDOMTreeWalker*)Unsafe.AsPointer(ref this), ppRetNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT firstChild(IDispatch** ppRetNode)
        {
            return ((delegate* unmanaged<IDOMTreeWalker*, IDispatch**, int>)(lpVtbl[14]))((IDOMTreeWalker*)Unsafe.AsPointer(ref this), ppRetNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT lastChild(IDispatch** ppRetNode)
        {
            return ((delegate* unmanaged<IDOMTreeWalker*, IDispatch**, int>)(lpVtbl[15]))((IDOMTreeWalker*)Unsafe.AsPointer(ref this), ppRetNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT previousSibling(IDispatch** ppRetNode)
        {
            return ((delegate* unmanaged<IDOMTreeWalker*, IDispatch**, int>)(lpVtbl[16]))((IDOMTreeWalker*)Unsafe.AsPointer(ref this), ppRetNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT nextSibling(IDispatch** ppRetNode)
        {
            return ((delegate* unmanaged<IDOMTreeWalker*, IDispatch**, int>)(lpVtbl[17]))((IDOMTreeWalker*)Unsafe.AsPointer(ref this), ppRetNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT previousNode(IDispatch** ppRetNode)
        {
            return ((delegate* unmanaged<IDOMTreeWalker*, IDispatch**, int>)(lpVtbl[18]))((IDOMTreeWalker*)Unsafe.AsPointer(ref this), ppRetNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT nextNode(IDispatch** ppRetNode)
        {
            return ((delegate* unmanaged<IDOMTreeWalker*, IDispatch**, int>)(lpVtbl[19]))((IDOMTreeWalker*)Unsafe.AsPointer(ref this), ppRetNode);
        }
    }
}
