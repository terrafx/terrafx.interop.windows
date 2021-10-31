// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("305106DA-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IDOMMutationEvent : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IDOMMutationEvent
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDOMMutationEvent*, Guid*, void**, int>)(lpVtbl[0]))((IDOMMutationEvent*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDOMMutationEvent*, uint>)(lpVtbl[1]))((IDOMMutationEvent*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDOMMutationEvent*, uint>)(lpVtbl[2]))((IDOMMutationEvent*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IDOMMutationEvent*, uint*, int>)(lpVtbl[3]))((IDOMMutationEvent*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IDOMMutationEvent*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IDOMMutationEvent*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IDOMMutationEvent*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IDOMMutationEvent*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IDOMMutationEvent*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IDOMMutationEvent*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_relatedNode(IDispatch** p)
        {
            return ((delegate* unmanaged<IDOMMutationEvent*, IDispatch**, int>)(lpVtbl[7]))((IDOMMutationEvent*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_prevValue([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IDOMMutationEvent*, ushort**, int>)(lpVtbl[8]))((IDOMMutationEvent*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_newValue([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IDOMMutationEvent*, ushort**, int>)(lpVtbl[9]))((IDOMMutationEvent*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_attrName([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IDOMMutationEvent*, ushort**, int>)(lpVtbl[10]))((IDOMMutationEvent*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT get_attrChange([NativeTypeName("USHORT *")] ushort* p)
        {
            return ((delegate* unmanaged<IDOMMutationEvent*, ushort*, int>)(lpVtbl[11]))((IDOMMutationEvent*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT initMutationEvent([NativeTypeName("BSTR")] ushort* eventType, [NativeTypeName("VARIANT_BOOL")] short canBubble, [NativeTypeName("VARIANT_BOOL")] short cancelable, IDispatch* relatedNodeArg, [NativeTypeName("BSTR")] ushort* prevValueArg, [NativeTypeName("BSTR")] ushort* newValueArg, [NativeTypeName("BSTR")] ushort* attrNameArg, [NativeTypeName("USHORT")] ushort attrChangeArg)
        {
            return ((delegate* unmanaged<IDOMMutationEvent*, ushort*, short, short, IDispatch*, ushort*, ushort*, ushort*, ushort, int>)(lpVtbl[12]))((IDOMMutationEvent*)Unsafe.AsPointer(ref this), eventType, canBubble, cancelable, relatedNodeArg, prevValueArg, newValueArg, attrNameArg, attrChangeArg);
        }
    }
}
