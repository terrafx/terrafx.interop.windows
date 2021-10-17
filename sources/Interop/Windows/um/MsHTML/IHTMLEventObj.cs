// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F32D-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLEventObj : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLEventObj
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLEventObj*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLEventObj*, uint>)(lpVtbl[1]))((IHTMLEventObj*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLEventObj*, uint>)(lpVtbl[2]))((IHTMLEventObj*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLEventObj*, uint*, int>)(lpVtbl[3]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLEventObj*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLEventObj*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLEventObj*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int get_srcElement(IHTMLElement** p)
        {
            return ((delegate* unmanaged<IHTMLEventObj*, IHTMLElement**, int>)(lpVtbl[7]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_altKey([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLEventObj*, short*, int>)(lpVtbl[8]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int get_ctrlKey([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLEventObj*, short*, int>)(lpVtbl[9]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int get_shiftKey([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLEventObj*, short*, int>)(lpVtbl[10]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int put_returnValue(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLEventObj*, VARIANT, int>)(lpVtbl[11]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int get_returnValue(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLEventObj*, VARIANT*, int>)(lpVtbl[12]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int put_cancelBubble([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLEventObj*, short, int>)(lpVtbl[13]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int get_cancelBubble([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLEventObj*, short*, int>)(lpVtbl[14]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int get_fromElement(IHTMLElement** p)
        {
            return ((delegate* unmanaged<IHTMLEventObj*, IHTMLElement**, int>)(lpVtbl[15]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int get_toElement(IHTMLElement** p)
        {
            return ((delegate* unmanaged<IHTMLEventObj*, IHTMLElement**, int>)(lpVtbl[16]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int put_keyCode([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLEventObj*, int, int>)(lpVtbl[17]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int get_keyCode([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLEventObj*, int*, int>)(lpVtbl[18]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int get_button([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLEventObj*, int*, int>)(lpVtbl[19]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int get_type([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLEventObj*, ushort**, int>)(lpVtbl[20]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int get_qualifier([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLEventObj*, ushort**, int>)(lpVtbl[21]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int get_reason([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLEventObj*, int*, int>)(lpVtbl[22]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int get_x([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLEventObj*, int*, int>)(lpVtbl[23]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int get_y([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLEventObj*, int*, int>)(lpVtbl[24]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int get_clientX([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLEventObj*, int*, int>)(lpVtbl[25]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int get_clientY([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLEventObj*, int*, int>)(lpVtbl[26]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int get_offsetX([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLEventObj*, int*, int>)(lpVtbl[27]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int get_offsetY([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLEventObj*, int*, int>)(lpVtbl[28]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int get_screenX([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLEventObj*, int*, int>)(lpVtbl[29]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int get_screenY([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLEventObj*, int*, int>)(lpVtbl[30]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int get_srcFilter(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLEventObj*, IDispatch**, int>)(lpVtbl[31]))((IHTMLEventObj*)Unsafe.AsPointer(ref this), p);
        }
    }
}
