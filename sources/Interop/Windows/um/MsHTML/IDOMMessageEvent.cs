// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("30510720-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IDOMMessageEvent : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IDOMMessageEvent
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDOMMessageEvent*, Guid*, void**, int>)(lpVtbl[0]))((IDOMMessageEvent*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDOMMessageEvent*, uint>)(lpVtbl[1]))((IDOMMessageEvent*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDOMMessageEvent*, uint>)(lpVtbl[2]))((IDOMMessageEvent*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IDOMMessageEvent*, uint*, int>)(lpVtbl[3]))((IDOMMessageEvent*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IDOMMessageEvent*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IDOMMessageEvent*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IDOMMessageEvent*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IDOMMessageEvent*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IDOMMessageEvent*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IDOMMessageEvent*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_data([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IDOMMessageEvent*, ushort**, int>)(lpVtbl[7]))((IDOMMessageEvent*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_origin([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IDOMMessageEvent*, ushort**, int>)(lpVtbl[8]))((IDOMMessageEvent*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_source(IHTMLWindow2** p)
        {
            return ((delegate* unmanaged<IDOMMessageEvent*, IHTMLWindow2**, int>)(lpVtbl[9]))((IDOMMessageEvent*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT initMessageEvent([NativeTypeName("BSTR")] ushort* eventType, [NativeTypeName("VARIANT_BOOL")] short canBubble, [NativeTypeName("VARIANT_BOOL")] short cancelable, [NativeTypeName("BSTR")] ushort* data, [NativeTypeName("BSTR")] ushort* origin, [NativeTypeName("BSTR")] ushort* lastEventId, IHTMLWindow2* source)
        {
            return ((delegate* unmanaged<IDOMMessageEvent*, ushort*, short, short, ushort*, ushort*, ushort*, IHTMLWindow2*, int>)(lpVtbl[10]))((IDOMMessageEvent*)Unsafe.AsPointer(ref this), eventType, canBubble, cancelable, data, origin, lastEventId, source);
        }
    }
}
