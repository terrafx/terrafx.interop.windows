// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F401-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLOpsProfile : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLOpsProfile
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLOpsProfile*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLOpsProfile*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLOpsProfile*, uint>)(lpVtbl[1]))((IHTMLOpsProfile*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLOpsProfile*, uint>)(lpVtbl[2]))((IHTMLOpsProfile*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLOpsProfile*, uint*, int>)(lpVtbl[3]))((IHTMLOpsProfile*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLOpsProfile*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLOpsProfile*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLOpsProfile*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLOpsProfile*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLOpsProfile*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLOpsProfile*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT addRequest([NativeTypeName("BSTR")] ushort* name, VARIANT reserved, [NativeTypeName("VARIANT_BOOL *")] short* success)
        {
            return ((delegate* unmanaged<IHTMLOpsProfile*, ushort*, VARIANT, short*, int>)(lpVtbl[7]))((IHTMLOpsProfile*)Unsafe.AsPointer(ref this), name, reserved, success);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT clearRequest()
        {
            return ((delegate* unmanaged<IHTMLOpsProfile*, int>)(lpVtbl[8]))((IHTMLOpsProfile*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT doRequest(VARIANT usage, VARIANT fname, VARIANT domain, VARIANT path, VARIANT expire, VARIANT reserved)
        {
            return ((delegate* unmanaged<IHTMLOpsProfile*, VARIANT, VARIANT, VARIANT, VARIANT, VARIANT, VARIANT, int>)(lpVtbl[9]))((IHTMLOpsProfile*)Unsafe.AsPointer(ref this), usage, fname, domain, path, expire, reserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT getAttribute([NativeTypeName("BSTR")] ushort* name, [NativeTypeName("BSTR *")] ushort** value)
        {
            return ((delegate* unmanaged<IHTMLOpsProfile*, ushort*, ushort**, int>)(lpVtbl[10]))((IHTMLOpsProfile*)Unsafe.AsPointer(ref this), name, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT setAttribute([NativeTypeName("BSTR")] ushort* name, [NativeTypeName("BSTR")] ushort* value, VARIANT prefs, [NativeTypeName("VARIANT_BOOL *")] short* success)
        {
            return ((delegate* unmanaged<IHTMLOpsProfile*, ushort*, ushort*, VARIANT, short*, int>)(lpVtbl[11]))((IHTMLOpsProfile*)Unsafe.AsPointer(ref this), name, value, prefs, success);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT commitChanges([NativeTypeName("VARIANT_BOOL *")] short* success)
        {
            return ((delegate* unmanaged<IHTMLOpsProfile*, short*, int>)(lpVtbl[12]))((IHTMLOpsProfile*)Unsafe.AsPointer(ref this), success);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT addReadRequest([NativeTypeName("BSTR")] ushort* name, VARIANT reserved, [NativeTypeName("VARIANT_BOOL *")] short* success)
        {
            return ((delegate* unmanaged<IHTMLOpsProfile*, ushort*, VARIANT, short*, int>)(lpVtbl[13]))((IHTMLOpsProfile*)Unsafe.AsPointer(ref this), name, reserved, success);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT doReadRequest(VARIANT usage, VARIANT fname, VARIANT domain, VARIANT path, VARIANT expire, VARIANT reserved)
        {
            return ((delegate* unmanaged<IHTMLOpsProfile*, VARIANT, VARIANT, VARIANT, VARIANT, VARIANT, VARIANT, int>)(lpVtbl[14]))((IHTMLOpsProfile*)Unsafe.AsPointer(ref this), usage, fname, domain, path, expire, reserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT doWriteRequest([NativeTypeName("VARIANT_BOOL *")] short* success)
        {
            return ((delegate* unmanaged<IHTMLOpsProfile*, short*, int>)(lpVtbl[15]))((IHTMLOpsProfile*)Unsafe.AsPointer(ref this), success);
        }
    }
}
