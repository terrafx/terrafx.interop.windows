// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("305107D0-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLDocument8 : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLDocument8
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLDocument8*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLDocument8*, uint>)(lpVtbl[1]))((IHTMLDocument8*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLDocument8*, uint>)(lpVtbl[2]))((IHTMLDocument8*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLDocument8*, uint*, int>)(lpVtbl[3]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLDocument8*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLDocument8*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLDocument8*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int put_onmscontentzoom(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument8*, VARIANT, int>)(lpVtbl[7]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_onmscontentzoom(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument8*, VARIANT*, int>)(lpVtbl[8]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int put_onmspointerdown(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument8*, VARIANT, int>)(lpVtbl[9]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int get_onmspointerdown(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument8*, VARIANT*, int>)(lpVtbl[10]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int put_onmspointermove(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument8*, VARIANT, int>)(lpVtbl[11]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int get_onmspointermove(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument8*, VARIANT*, int>)(lpVtbl[12]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int put_onmspointerup(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument8*, VARIANT, int>)(lpVtbl[13]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int get_onmspointerup(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument8*, VARIANT*, int>)(lpVtbl[14]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int put_onmspointerover(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument8*, VARIANT, int>)(lpVtbl[15]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int get_onmspointerover(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument8*, VARIANT*, int>)(lpVtbl[16]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int put_onmspointerout(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument8*, VARIANT, int>)(lpVtbl[17]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int get_onmspointerout(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument8*, VARIANT*, int>)(lpVtbl[18]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int put_onmspointercancel(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument8*, VARIANT, int>)(lpVtbl[19]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int get_onmspointercancel(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument8*, VARIANT*, int>)(lpVtbl[20]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int put_onmspointerhover(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument8*, VARIANT, int>)(lpVtbl[21]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int get_onmspointerhover(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument8*, VARIANT*, int>)(lpVtbl[22]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int put_onmsgesturestart(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument8*, VARIANT, int>)(lpVtbl[23]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int get_onmsgesturestart(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument8*, VARIANT*, int>)(lpVtbl[24]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int put_onmsgesturechange(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument8*, VARIANT, int>)(lpVtbl[25]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int get_onmsgesturechange(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument8*, VARIANT*, int>)(lpVtbl[26]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int put_onmsgestureend(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument8*, VARIANT, int>)(lpVtbl[27]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int get_onmsgestureend(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument8*, VARIANT*, int>)(lpVtbl[28]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int put_onmsgesturehold(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument8*, VARIANT, int>)(lpVtbl[29]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int get_onmsgesturehold(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument8*, VARIANT*, int>)(lpVtbl[30]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int put_onmsgesturetap(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument8*, VARIANT, int>)(lpVtbl[31]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        public int get_onmsgesturetap(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument8*, VARIANT*, int>)(lpVtbl[32]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        [return: NativeTypeName("HRESULT")]
        public int put_onmsgesturedoubletap(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument8*, VARIANT, int>)(lpVtbl[33]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        [return: NativeTypeName("HRESULT")]
        public int get_onmsgesturedoubletap(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument8*, VARIANT*, int>)(lpVtbl[34]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        [return: NativeTypeName("HRESULT")]
        public int put_onmsinertiastart(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument8*, VARIANT, int>)(lpVtbl[35]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        [return: NativeTypeName("HRESULT")]
        public int get_onmsinertiastart(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument8*, VARIANT*, int>)(lpVtbl[36]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        [return: NativeTypeName("HRESULT")]
        public int elementsFromPoint(float x, float y, IHTMLDOMChildrenCollection** elementsHit)
        {
            return ((delegate* unmanaged<IHTMLDocument8*, float, float, IHTMLDOMChildrenCollection**, int>)(lpVtbl[37]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), x, y, elementsHit);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        [return: NativeTypeName("HRESULT")]
        public int elementsFromRect(float left, float top, float width, float height, IHTMLDOMChildrenCollection** elementsHit)
        {
            return ((delegate* unmanaged<IHTMLDocument8*, float, float, float, float, IHTMLDOMChildrenCollection**, int>)(lpVtbl[38]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), left, top, width, height, elementsHit);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        [return: NativeTypeName("HRESULT")]
        public int put_onmsmanipulationstatechanged(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDocument8*, VARIANT, int>)(lpVtbl[39]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        [return: NativeTypeName("HRESULT")]
        public int get_onmsmanipulationstatechanged(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDocument8*, VARIANT*, int>)(lpVtbl[40]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        [return: NativeTypeName("HRESULT")]
        public int put_msCapsLockWarningOff([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLDocument8*, short, int>)(lpVtbl[41]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        [return: NativeTypeName("HRESULT")]
        public int get_msCapsLockWarningOff([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLDocument8*, short*, int>)(lpVtbl[42]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), p);
        }
    }
}
