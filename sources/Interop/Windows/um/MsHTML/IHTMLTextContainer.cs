// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F230-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLTextContainer : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLTextContainer
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLTextContainer*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLTextContainer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLTextContainer*, uint>)(lpVtbl[1]))((IHTMLTextContainer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLTextContainer*, uint>)(lpVtbl[2]))((IHTMLTextContainer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLTextContainer*, uint*, int>)(lpVtbl[3]))((IHTMLTextContainer*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLTextContainer*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLTextContainer*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLTextContainer*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLTextContainer*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLTextContainer*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLTextContainer*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int createControlRange(IDispatch** range)
        {
            return ((delegate* unmanaged<IHTMLTextContainer*, IDispatch**, int>)(lpVtbl[7]))((IHTMLTextContainer*)Unsafe.AsPointer(ref this), range);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_scrollHeight([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLTextContainer*, int*, int>)(lpVtbl[8]))((IHTMLTextContainer*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int get_scrollWidth([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLTextContainer*, int*, int>)(lpVtbl[9]))((IHTMLTextContainer*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int put_scrollTop([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLTextContainer*, int, int>)(lpVtbl[10]))((IHTMLTextContainer*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int get_scrollTop([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLTextContainer*, int*, int>)(lpVtbl[11]))((IHTMLTextContainer*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int put_scrollLeft([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLTextContainer*, int, int>)(lpVtbl[12]))((IHTMLTextContainer*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int get_scrollLeft([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLTextContainer*, int*, int>)(lpVtbl[13]))((IHTMLTextContainer*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int put_onscroll(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLTextContainer*, VARIANT, int>)(lpVtbl[14]))((IHTMLTextContainer*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int get_onscroll(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLTextContainer*, VARIANT*, int>)(lpVtbl[15]))((IHTMLTextContainer*)Unsafe.AsPointer(ref this), p);
        }
    }
}
