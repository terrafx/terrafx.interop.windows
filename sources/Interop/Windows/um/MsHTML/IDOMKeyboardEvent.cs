// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("305106D6-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IDOMKeyboardEvent : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IDOMKeyboardEvent
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDOMKeyboardEvent*, Guid*, void**, int>)(lpVtbl[0]))((IDOMKeyboardEvent*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDOMKeyboardEvent*, uint>)(lpVtbl[1]))((IDOMKeyboardEvent*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDOMKeyboardEvent*, uint>)(lpVtbl[2]))((IDOMKeyboardEvent*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IDOMKeyboardEvent*, uint*, int>)(lpVtbl[3]))((IDOMKeyboardEvent*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IDOMKeyboardEvent*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IDOMKeyboardEvent*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IDOMKeyboardEvent*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IDOMKeyboardEvent*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IDOMKeyboardEvent*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IDOMKeyboardEvent*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int get_key([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IDOMKeyboardEvent*, ushort**, int>)(lpVtbl[7]))((IDOMKeyboardEvent*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_location([NativeTypeName("ULONG *")] uint* p)
        {
            return ((delegate* unmanaged<IDOMKeyboardEvent*, uint*, int>)(lpVtbl[8]))((IDOMKeyboardEvent*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int get_ctrlKey([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IDOMKeyboardEvent*, short*, int>)(lpVtbl[9]))((IDOMKeyboardEvent*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int get_shiftKey([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IDOMKeyboardEvent*, short*, int>)(lpVtbl[10]))((IDOMKeyboardEvent*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int get_altKey([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IDOMKeyboardEvent*, short*, int>)(lpVtbl[11]))((IDOMKeyboardEvent*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int get_metaKey([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IDOMKeyboardEvent*, short*, int>)(lpVtbl[12]))((IDOMKeyboardEvent*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int get_repeat([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IDOMKeyboardEvent*, short*, int>)(lpVtbl[13]))((IDOMKeyboardEvent*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int getModifierState([NativeTypeName("BSTR")] ushort* keyArg, [NativeTypeName("VARIANT_BOOL *")] short* state)
        {
            return ((delegate* unmanaged<IDOMKeyboardEvent*, ushort*, short*, int>)(lpVtbl[14]))((IDOMKeyboardEvent*)Unsafe.AsPointer(ref this), keyArg, state);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int initKeyboardEvent([NativeTypeName("BSTR")] ushort* eventType, [NativeTypeName("VARIANT_BOOL")] short canBubble, [NativeTypeName("VARIANT_BOOL")] short cancelable, IHTMLWindow2* viewArg, [NativeTypeName("BSTR")] ushort* keyArg, [NativeTypeName("ULONG")] uint locationArg, [NativeTypeName("BSTR")] ushort* modifiersListArg, [NativeTypeName("VARIANT_BOOL")] short repeat, [NativeTypeName("BSTR")] ushort* locale)
        {
            return ((delegate* unmanaged<IDOMKeyboardEvent*, ushort*, short, short, IHTMLWindow2*, ushort*, uint, ushort*, short, ushort*, int>)(lpVtbl[15]))((IDOMKeyboardEvent*)Unsafe.AsPointer(ref this), eventType, canBubble, cancelable, viewArg, keyArg, locationArg, modifiersListArg, repeat, locale);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int get_keyCode([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IDOMKeyboardEvent*, int*, int>)(lpVtbl[16]))((IDOMKeyboardEvent*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int get_charCode([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IDOMKeyboardEvent*, int*, int>)(lpVtbl[17]))((IDOMKeyboardEvent*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int get_which([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IDOMKeyboardEvent*, int*, int>)(lpVtbl[18]))((IDOMKeyboardEvent*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int get_ie9_char(VARIANT* p)
        {
            return ((delegate* unmanaged<IDOMKeyboardEvent*, VARIANT*, int>)(lpVtbl[19]))((IDOMKeyboardEvent*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int get_locale([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IDOMKeyboardEvent*, ushort**, int>)(lpVtbl[20]))((IDOMKeyboardEvent*)Unsafe.AsPointer(ref this), p);
        }
    }
}
