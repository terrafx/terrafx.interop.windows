// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("305106CE-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IDOMMouseEvent : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IDOMMouseEvent
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDOMMouseEvent*, Guid*, void**, int>)(lpVtbl[0]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDOMMouseEvent*, uint>)(lpVtbl[1]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDOMMouseEvent*, uint>)(lpVtbl[2]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IDOMMouseEvent*, uint*, int>)(lpVtbl[3]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IDOMMouseEvent*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IDOMMouseEvent*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IDOMMouseEvent*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int get_screenX([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IDOMMouseEvent*, int*, int>)(lpVtbl[7]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_screenY([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IDOMMouseEvent*, int*, int>)(lpVtbl[8]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int get_clientX([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IDOMMouseEvent*, int*, int>)(lpVtbl[9]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int get_clientY([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IDOMMouseEvent*, int*, int>)(lpVtbl[10]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int get_ctrlKey([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IDOMMouseEvent*, short*, int>)(lpVtbl[11]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int get_shiftKey([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IDOMMouseEvent*, short*, int>)(lpVtbl[12]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int get_altKey([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IDOMMouseEvent*, short*, int>)(lpVtbl[13]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int get_metaKey([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IDOMMouseEvent*, short*, int>)(lpVtbl[14]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int get_button([NativeTypeName("USHORT *")] ushort* p)
        {
            return ((delegate* unmanaged<IDOMMouseEvent*, ushort*, int>)(lpVtbl[15]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int get_relatedTarget(IEventTarget** p)
        {
            return ((delegate* unmanaged<IDOMMouseEvent*, IEventTarget**, int>)(lpVtbl[16]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int initMouseEvent([NativeTypeName("BSTR")] ushort* eventType, [NativeTypeName("VARIANT_BOOL")] short canBubble, [NativeTypeName("VARIANT_BOOL")] short cancelable, IHTMLWindow2* viewArg, [NativeTypeName("long")] int detailArg, [NativeTypeName("long")] int screenXArg, [NativeTypeName("long")] int screenYArg, [NativeTypeName("long")] int clientXArg, [NativeTypeName("long")] int clientYArg, [NativeTypeName("VARIANT_BOOL")] short ctrlKeyArg, [NativeTypeName("VARIANT_BOOL")] short altKeyArg, [NativeTypeName("VARIANT_BOOL")] short shiftKeyArg, [NativeTypeName("VARIANT_BOOL")] short metaKeyArg, [NativeTypeName("USHORT")] ushort buttonArg, IEventTarget* relatedTargetArg)
        {
            return ((delegate* unmanaged<IDOMMouseEvent*, ushort*, short, short, IHTMLWindow2*, int, int, int, int, int, short, short, short, short, ushort, IEventTarget*, int>)(lpVtbl[17]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), eventType, canBubble, cancelable, viewArg, detailArg, screenXArg, screenYArg, clientXArg, clientYArg, ctrlKeyArg, altKeyArg, shiftKeyArg, metaKeyArg, buttonArg, relatedTargetArg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int getModifierState([NativeTypeName("BSTR")] ushort* keyArg, [NativeTypeName("VARIANT_BOOL *")] short* activated)
        {
            return ((delegate* unmanaged<IDOMMouseEvent*, ushort*, short*, int>)(lpVtbl[18]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), keyArg, activated);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int get_buttons([NativeTypeName("USHORT *")] ushort* p)
        {
            return ((delegate* unmanaged<IDOMMouseEvent*, ushort*, int>)(lpVtbl[19]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int get_fromElement(IHTMLElement** p)
        {
            return ((delegate* unmanaged<IDOMMouseEvent*, IHTMLElement**, int>)(lpVtbl[20]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int get_toElement(IHTMLElement** p)
        {
            return ((delegate* unmanaged<IDOMMouseEvent*, IHTMLElement**, int>)(lpVtbl[21]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int get_x([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IDOMMouseEvent*, int*, int>)(lpVtbl[22]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int get_y([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IDOMMouseEvent*, int*, int>)(lpVtbl[23]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int get_offsetX([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IDOMMouseEvent*, int*, int>)(lpVtbl[24]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int get_offsetY([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IDOMMouseEvent*, int*, int>)(lpVtbl[25]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int get_pageX([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IDOMMouseEvent*, int*, int>)(lpVtbl[26]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int get_pageY([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IDOMMouseEvent*, int*, int>)(lpVtbl[27]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int get_layerX([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IDOMMouseEvent*, int*, int>)(lpVtbl[28]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int get_layerY([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IDOMMouseEvent*, int*, int>)(lpVtbl[29]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int get_which([NativeTypeName("USHORT *")] ushort* p)
        {
            return ((delegate* unmanaged<IDOMMouseEvent*, ushort*, int>)(lpVtbl[30]))((IDOMMouseEvent*)Unsafe.AsPointer(ref this), p);
        }
    }
}
