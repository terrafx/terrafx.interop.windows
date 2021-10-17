// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F4AE-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLWindow3 : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLWindow3
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLWindow3*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLWindow3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLWindow3*, uint>)(lpVtbl[1]))((IHTMLWindow3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLWindow3*, uint>)(lpVtbl[2]))((IHTMLWindow3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLWindow3*, uint*, int>)(lpVtbl[3]))((IHTMLWindow3*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLWindow3*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLWindow3*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLWindow3*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLWindow3*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLWindow3*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLWindow3*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int get_screenLeft([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLWindow3*, int*, int>)(lpVtbl[7]))((IHTMLWindow3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_screenTop([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLWindow3*, int*, int>)(lpVtbl[8]))((IHTMLWindow3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int attachEvent([NativeTypeName("BSTR")] ushort* @event, IDispatch* pDisp, [NativeTypeName("VARIANT_BOOL *")] short* pfResult)
        {
            return ((delegate* unmanaged<IHTMLWindow3*, ushort*, IDispatch*, short*, int>)(lpVtbl[9]))((IHTMLWindow3*)Unsafe.AsPointer(ref this), @event, pDisp, pfResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int detachEvent([NativeTypeName("BSTR")] ushort* @event, IDispatch* pDisp)
        {
            return ((delegate* unmanaged<IHTMLWindow3*, ushort*, IDispatch*, int>)(lpVtbl[10]))((IHTMLWindow3*)Unsafe.AsPointer(ref this), @event, pDisp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int setTimeout(VARIANT* expression, [NativeTypeName("long")] int msec, VARIANT* language, [NativeTypeName("long *")] int* timerID)
        {
            return ((delegate* unmanaged<IHTMLWindow3*, VARIANT*, int, VARIANT*, int*, int>)(lpVtbl[11]))((IHTMLWindow3*)Unsafe.AsPointer(ref this), expression, msec, language, timerID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int setInterval(VARIANT* expression, [NativeTypeName("long")] int msec, VARIANT* language, [NativeTypeName("long *")] int* timerID)
        {
            return ((delegate* unmanaged<IHTMLWindow3*, VARIANT*, int, VARIANT*, int*, int>)(lpVtbl[12]))((IHTMLWindow3*)Unsafe.AsPointer(ref this), expression, msec, language, timerID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int print()
        {
            return ((delegate* unmanaged<IHTMLWindow3*, int>)(lpVtbl[13]))((IHTMLWindow3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int put_onbeforeprint(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow3*, VARIANT, int>)(lpVtbl[14]))((IHTMLWindow3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int get_onbeforeprint(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow3*, VARIANT*, int>)(lpVtbl[15]))((IHTMLWindow3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int put_onafterprint(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLWindow3*, VARIANT, int>)(lpVtbl[16]))((IHTMLWindow3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int get_onafterprint(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLWindow3*, VARIANT*, int>)(lpVtbl[17]))((IHTMLWindow3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int get_clipboardData(IHTMLDataTransfer** p)
        {
            return ((delegate* unmanaged<IHTMLWindow3*, IHTMLDataTransfer**, int>)(lpVtbl[18]))((IHTMLWindow3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int showModelessDialog([NativeTypeName("BSTR")] ushort* url, VARIANT* varArgIn, VARIANT* options, IHTMLWindow2** pDialog)
        {
            return ((delegate* unmanaged<IHTMLWindow3*, ushort*, VARIANT*, VARIANT*, IHTMLWindow2**, int>)(lpVtbl[19]))((IHTMLWindow3*)Unsafe.AsPointer(ref this), url, varArgIn, options, pDialog);
        }
    }
}
