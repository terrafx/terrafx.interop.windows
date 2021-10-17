// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A5170870-0CF8-11D1-8B91-0080C744F389")]
    [NativeTypeName("struct IWBScriptControl : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IWBScriptControl
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWBScriptControl*, Guid*, void**, int>)(lpVtbl[0]))((IWBScriptControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWBScriptControl*, uint>)(lpVtbl[1]))((IWBScriptControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWBScriptControl*, uint>)(lpVtbl[2]))((IWBScriptControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IWBScriptControl*, uint*, int>)(lpVtbl[3]))((IWBScriptControl*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IWBScriptControl*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IWBScriptControl*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IWBScriptControl*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IWBScriptControl*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IWBScriptControl*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IWBScriptControl*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int raiseEvent([NativeTypeName("BSTR")] ushort* name, VARIANT eventData)
        {
            return ((delegate* unmanaged<IWBScriptControl*, ushort*, VARIANT, int>)(lpVtbl[7]))((IWBScriptControl*)Unsafe.AsPointer(ref this), name, eventData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int bubbleEvent()
        {
            return ((delegate* unmanaged<IWBScriptControl*, int>)(lpVtbl[8]))((IWBScriptControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int setContextMenu(VARIANT menuItemPairs)
        {
            return ((delegate* unmanaged<IWBScriptControl*, VARIANT, int>)(lpVtbl[9]))((IWBScriptControl*)Unsafe.AsPointer(ref this), menuItemPairs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int put_selectableContent([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IWBScriptControl*, short, int>)(lpVtbl[10]))((IWBScriptControl*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int get_selectableContent([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IWBScriptControl*, short*, int>)(lpVtbl[11]))((IWBScriptControl*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int get_frozen([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IWBScriptControl*, short*, int>)(lpVtbl[12]))((IWBScriptControl*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int put_scrollbar([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IWBScriptControl*, short, int>)(lpVtbl[13]))((IWBScriptControl*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int get_scrollbar([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IWBScriptControl*, short*, int>)(lpVtbl[14]))((IWBScriptControl*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int get_version([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IWBScriptControl*, ushort**, int>)(lpVtbl[15]))((IWBScriptControl*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int get_visibility([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IWBScriptControl*, short*, int>)(lpVtbl[16]))((IWBScriptControl*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int put_onvisibilitychange(VARIANT v)
        {
            return ((delegate* unmanaged<IWBScriptControl*, VARIANT, int>)(lpVtbl[17]))((IWBScriptControl*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int get_onvisibilitychange(VARIANT* p)
        {
            return ((delegate* unmanaged<IWBScriptControl*, VARIANT*, int>)(lpVtbl[18]))((IWBScriptControl*)Unsafe.AsPointer(ref this), p);
        }
    }
}
