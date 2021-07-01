// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msxml.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3EFAA426-272F-11D2-836F-0000F87A7782")]
    [NativeTypeName("struct IXMLDOMParseError : IDispatch")]
    public unsafe partial struct IXMLDOMParseError
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IXMLDOMParseError*, Guid*, void**, int>)(lpVtbl[0]))((IXMLDOMParseError*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IXMLDOMParseError*, uint>)(lpVtbl[1]))((IXMLDOMParseError*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IXMLDOMParseError*, uint>)(lpVtbl[2]))((IXMLDOMParseError*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IXMLDOMParseError*, uint*, int>)(lpVtbl[3]))((IXMLDOMParseError*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IXMLDOMParseError*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IXMLDOMParseError*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IXMLDOMParseError*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IXMLDOMParseError*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IXMLDOMParseError*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IXMLDOMParseError*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_errorCode([NativeTypeName("long *")] int* errorCode)
        {
            return ((delegate* unmanaged<IXMLDOMParseError*, int*, int>)(lpVtbl[7]))((IXMLDOMParseError*)Unsafe.AsPointer(ref this), errorCode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_url([NativeTypeName("BSTR *")] ushort** urlString)
        {
            return ((delegate* unmanaged<IXMLDOMParseError*, ushort**, int>)(lpVtbl[8]))((IXMLDOMParseError*)Unsafe.AsPointer(ref this), urlString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_reason([NativeTypeName("BSTR *")] ushort** reasonString)
        {
            return ((delegate* unmanaged<IXMLDOMParseError*, ushort**, int>)(lpVtbl[9]))((IXMLDOMParseError*)Unsafe.AsPointer(ref this), reasonString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_srcText([NativeTypeName("BSTR *")] ushort** sourceString)
        {
            return ((delegate* unmanaged<IXMLDOMParseError*, ushort**, int>)(lpVtbl[10]))((IXMLDOMParseError*)Unsafe.AsPointer(ref this), sourceString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_line([NativeTypeName("long *")] int* lineNumber)
        {
            return ((delegate* unmanaged<IXMLDOMParseError*, int*, int>)(lpVtbl[11]))((IXMLDOMParseError*)Unsafe.AsPointer(ref this), lineNumber);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_linepos([NativeTypeName("long *")] int* linePosition)
        {
            return ((delegate* unmanaged<IXMLDOMParseError*, int*, int>)(lpVtbl[12]))((IXMLDOMParseError*)Unsafe.AsPointer(ref this), linePosition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_filepos([NativeTypeName("long *")] int* filePosition)
        {
            return ((delegate* unmanaged<IXMLDOMParseError*, int*, int>)(lpVtbl[13]))((IXMLDOMParseError*)Unsafe.AsPointer(ref this), filePosition);
        }
    }
}
