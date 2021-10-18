// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F216-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLDialog : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLDialog
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLDialog*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLDialog*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLDialog*, uint>)(lpVtbl[1]))((IHTMLDialog*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLDialog*, uint>)(lpVtbl[2]))((IHTMLDialog*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLDialog*, uint*, int>)(lpVtbl[3]))((IHTMLDialog*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLDialog*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLDialog*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLDialog*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLDialog*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLDialog*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLDialog*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int put_dialogTop(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDialog*, VARIANT, int>)(lpVtbl[7]))((IHTMLDialog*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_dialogTop(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDialog*, VARIANT*, int>)(lpVtbl[8]))((IHTMLDialog*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int put_dialogLeft(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDialog*, VARIANT, int>)(lpVtbl[9]))((IHTMLDialog*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int get_dialogLeft(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDialog*, VARIANT*, int>)(lpVtbl[10]))((IHTMLDialog*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int put_dialogWidth(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDialog*, VARIANT, int>)(lpVtbl[11]))((IHTMLDialog*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int get_dialogWidth(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDialog*, VARIANT*, int>)(lpVtbl[12]))((IHTMLDialog*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int put_dialogHeight(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDialog*, VARIANT, int>)(lpVtbl[13]))((IHTMLDialog*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int get_dialogHeight(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDialog*, VARIANT*, int>)(lpVtbl[14]))((IHTMLDialog*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int get_dialogArguments(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDialog*, VARIANT*, int>)(lpVtbl[15]))((IHTMLDialog*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int get_menuArguments(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDialog*, VARIANT*, int>)(lpVtbl[16]))((IHTMLDialog*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int put_returnValue(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDialog*, VARIANT, int>)(lpVtbl[17]))((IHTMLDialog*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int get_returnValue(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDialog*, VARIANT*, int>)(lpVtbl[18]))((IHTMLDialog*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int close()
        {
            return ((delegate* unmanaged<IHTMLDialog*, int>)(lpVtbl[19]))((IHTMLDialog*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int toString([NativeTypeName("BSTR *")] ushort** String)
        {
            return ((delegate* unmanaged<IHTMLDialog*, ushort**, int>)(lpVtbl[20]))((IHTMLDialog*)Unsafe.AsPointer(ref this), String);
        }
    }
}
