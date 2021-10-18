// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("30510828-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLApplicationCache : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLApplicationCache
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLApplicationCache*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLApplicationCache*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLApplicationCache*, uint>)(lpVtbl[1]))((IHTMLApplicationCache*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLApplicationCache*, uint>)(lpVtbl[2]))((IHTMLApplicationCache*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLApplicationCache*, uint*, int>)(lpVtbl[3]))((IHTMLApplicationCache*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLApplicationCache*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLApplicationCache*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLApplicationCache*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLApplicationCache*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLApplicationCache*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLApplicationCache*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int get_status([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLApplicationCache*, int*, int>)(lpVtbl[7]))((IHTMLApplicationCache*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int put_onchecking(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLApplicationCache*, VARIANT, int>)(lpVtbl[8]))((IHTMLApplicationCache*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int get_onchecking(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLApplicationCache*, VARIANT*, int>)(lpVtbl[9]))((IHTMLApplicationCache*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int put_onerror(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLApplicationCache*, VARIANT, int>)(lpVtbl[10]))((IHTMLApplicationCache*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int get_onerror(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLApplicationCache*, VARIANT*, int>)(lpVtbl[11]))((IHTMLApplicationCache*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int put_onnoupdate(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLApplicationCache*, VARIANT, int>)(lpVtbl[12]))((IHTMLApplicationCache*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int get_onnoupdate(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLApplicationCache*, VARIANT*, int>)(lpVtbl[13]))((IHTMLApplicationCache*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int put_ondownloading(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLApplicationCache*, VARIANT, int>)(lpVtbl[14]))((IHTMLApplicationCache*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int get_ondownloading(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLApplicationCache*, VARIANT*, int>)(lpVtbl[15]))((IHTMLApplicationCache*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int put_onprogress(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLApplicationCache*, VARIANT, int>)(lpVtbl[16]))((IHTMLApplicationCache*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int get_onprogress(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLApplicationCache*, VARIANT*, int>)(lpVtbl[17]))((IHTMLApplicationCache*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int put_onupdateready(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLApplicationCache*, VARIANT, int>)(lpVtbl[18]))((IHTMLApplicationCache*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int get_onupdateready(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLApplicationCache*, VARIANT*, int>)(lpVtbl[19]))((IHTMLApplicationCache*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int put_oncached(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLApplicationCache*, VARIANT, int>)(lpVtbl[20]))((IHTMLApplicationCache*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int get_oncached(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLApplicationCache*, VARIANT*, int>)(lpVtbl[21]))((IHTMLApplicationCache*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int put_onobsolete(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLApplicationCache*, VARIANT, int>)(lpVtbl[22]))((IHTMLApplicationCache*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int get_onobsolete(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLApplicationCache*, VARIANT*, int>)(lpVtbl[23]))((IHTMLApplicationCache*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int update()
        {
            return ((delegate* unmanaged<IHTMLApplicationCache*, int>)(lpVtbl[24]))((IHTMLApplicationCache*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int swapCache()
        {
            return ((delegate* unmanaged<IHTMLApplicationCache*, int>)(lpVtbl[25]))((IHTMLApplicationCache*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int abort()
        {
            return ((delegate* unmanaged<IHTMLApplicationCache*, int>)(lpVtbl[26]))((IHTMLApplicationCache*)Unsafe.AsPointer(ref this));
        }
    }
}
