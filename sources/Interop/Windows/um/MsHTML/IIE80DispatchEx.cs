// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3051046C-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IIE80DispatchEx : IDispatchEx")]
    [NativeInheritance("IDispatchEx")]
    public unsafe partial struct IIE80DispatchEx
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IIE80DispatchEx*, Guid*, void**, int>)(lpVtbl[0]))((IIE80DispatchEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IIE80DispatchEx*, uint>)(lpVtbl[1]))((IIE80DispatchEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IIE80DispatchEx*, uint>)(lpVtbl[2]))((IIE80DispatchEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IIE80DispatchEx*, uint*, int>)(lpVtbl[3]))((IIE80DispatchEx*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IIE80DispatchEx*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IIE80DispatchEx*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IIE80DispatchEx*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IIE80DispatchEx*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IIE80DispatchEx*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IIE80DispatchEx*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetDispID([NativeTypeName("BSTR")] ushort* bstrName, [NativeTypeName("DWORD")] uint grfdex, [NativeTypeName("DISPID *")] int* pid)
        {
            return ((delegate* unmanaged<IIE80DispatchEx*, ushort*, uint, int*, int>)(lpVtbl[7]))((IIE80DispatchEx*)Unsafe.AsPointer(ref this), bstrName, grfdex, pid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int InvokeEx([NativeTypeName("DISPID")] int id, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pdp, VARIANT* pvarRes, EXCEPINFO* pei, IServiceProvider* pspCaller)
        {
            return ((delegate* unmanaged<IIE80DispatchEx*, int, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, IServiceProvider*, int>)(lpVtbl[8]))((IIE80DispatchEx*)Unsafe.AsPointer(ref this), id, lcid, wFlags, pdp, pvarRes, pei, pspCaller);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int DeleteMemberByName([NativeTypeName("BSTR")] ushort* bstrName, [NativeTypeName("DWORD")] uint grfdex)
        {
            return ((delegate* unmanaged<IIE80DispatchEx*, ushort*, uint, int>)(lpVtbl[9]))((IIE80DispatchEx*)Unsafe.AsPointer(ref this), bstrName, grfdex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int DeleteMemberByDispID([NativeTypeName("DISPID")] int id)
        {
            return ((delegate* unmanaged<IIE80DispatchEx*, int, int>)(lpVtbl[10]))((IIE80DispatchEx*)Unsafe.AsPointer(ref this), id);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int GetMemberProperties([NativeTypeName("DISPID")] int id, [NativeTypeName("DWORD")] uint grfdexFetch, [NativeTypeName("DWORD *")] uint* pgrfdex)
        {
            return ((delegate* unmanaged<IIE80DispatchEx*, int, uint, uint*, int>)(lpVtbl[11]))((IIE80DispatchEx*)Unsafe.AsPointer(ref this), id, grfdexFetch, pgrfdex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int GetMemberName([NativeTypeName("DISPID")] int id, [NativeTypeName("BSTR *")] ushort** pbstrName)
        {
            return ((delegate* unmanaged<IIE80DispatchEx*, int, ushort**, int>)(lpVtbl[12]))((IIE80DispatchEx*)Unsafe.AsPointer(ref this), id, pbstrName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int GetNextDispID([NativeTypeName("DWORD")] uint grfdex, [NativeTypeName("DISPID")] int id, [NativeTypeName("DISPID *")] int* pid)
        {
            return ((delegate* unmanaged<IIE80DispatchEx*, uint, int, int*, int>)(lpVtbl[13]))((IIE80DispatchEx*)Unsafe.AsPointer(ref this), grfdex, id, pid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int GetNameSpaceParent(IUnknown** ppunk)
        {
            return ((delegate* unmanaged<IIE80DispatchEx*, IUnknown**, int>)(lpVtbl[14]))((IIE80DispatchEx*)Unsafe.AsPointer(ref this), ppunk);
        }
    }
}
