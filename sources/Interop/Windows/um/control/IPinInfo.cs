// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/control.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("56A868BD-0AD4-11CE-B03A-0020AF0BA770")]
    [NativeTypeName("struct IPinInfo : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IPinInfo
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPinInfo*, Guid*, void**, int>)(lpVtbl[0]))((IPinInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPinInfo*, uint>)(lpVtbl[1]))((IPinInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPinInfo*, uint>)(lpVtbl[2]))((IPinInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IPinInfo*, uint*, int>)(lpVtbl[3]))((IPinInfo*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IPinInfo*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IPinInfo*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IPinInfo*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IPinInfo*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IPinInfo*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IPinInfo*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_Pin(IUnknown** ppUnk)
        {
            return ((delegate* unmanaged<IPinInfo*, IUnknown**, int>)(lpVtbl[7]))((IPinInfo*)Unsafe.AsPointer(ref this), ppUnk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_ConnectedTo(IDispatch** ppUnk)
        {
            return ((delegate* unmanaged<IPinInfo*, IDispatch**, int>)(lpVtbl[8]))((IPinInfo*)Unsafe.AsPointer(ref this), ppUnk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_ConnectionMediaType(IDispatch** ppUnk)
        {
            return ((delegate* unmanaged<IPinInfo*, IDispatch**, int>)(lpVtbl[9]))((IPinInfo*)Unsafe.AsPointer(ref this), ppUnk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_FilterInfo(IDispatch** ppUnk)
        {
            return ((delegate* unmanaged<IPinInfo*, IDispatch**, int>)(lpVtbl[10]))((IPinInfo*)Unsafe.AsPointer(ref this), ppUnk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT get_Name([NativeTypeName("BSTR *")] ushort** ppUnk)
        {
            return ((delegate* unmanaged<IPinInfo*, ushort**, int>)(lpVtbl[11]))((IPinInfo*)Unsafe.AsPointer(ref this), ppUnk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_Direction([NativeTypeName("LONG *")] int* ppDirection)
        {
            return ((delegate* unmanaged<IPinInfo*, int*, int>)(lpVtbl[12]))((IPinInfo*)Unsafe.AsPointer(ref this), ppDirection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT get_PinID([NativeTypeName("BSTR *")] ushort** strPinID)
        {
            return ((delegate* unmanaged<IPinInfo*, ushort**, int>)(lpVtbl[13]))((IPinInfo*)Unsafe.AsPointer(ref this), strPinID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT get_MediaTypes(IDispatch** ppUnk)
        {
            return ((delegate* unmanaged<IPinInfo*, IDispatch**, int>)(lpVtbl[14]))((IPinInfo*)Unsafe.AsPointer(ref this), ppUnk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT Connect(IUnknown* pPin)
        {
            return ((delegate* unmanaged<IPinInfo*, IUnknown*, int>)(lpVtbl[15]))((IPinInfo*)Unsafe.AsPointer(ref this), pPin);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT ConnectDirect(IUnknown* pPin)
        {
            return ((delegate* unmanaged<IPinInfo*, IUnknown*, int>)(lpVtbl[16]))((IPinInfo*)Unsafe.AsPointer(ref this), pPin);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT ConnectWithType(IUnknown* pPin, IDispatch* pMediaType)
        {
            return ((delegate* unmanaged<IPinInfo*, IUnknown*, IDispatch*, int>)(lpVtbl[17]))((IPinInfo*)Unsafe.AsPointer(ref this), pPin, pMediaType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT Disconnect()
        {
            return ((delegate* unmanaged<IPinInfo*, int>)(lpVtbl[18]))((IPinInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT Render()
        {
            return ((delegate* unmanaged<IPinInfo*, int>)(lpVtbl[19]))((IPinInfo*)Unsafe.AsPointer(ref this));
        }
    }
}
