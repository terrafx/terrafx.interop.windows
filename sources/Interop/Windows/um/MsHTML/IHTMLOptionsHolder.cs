// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F378-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLOptionsHolder : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLOptionsHolder
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLOptionsHolder*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLOptionsHolder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLOptionsHolder*, uint>)(lpVtbl[1]))((IHTMLOptionsHolder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLOptionsHolder*, uint>)(lpVtbl[2]))((IHTMLOptionsHolder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLOptionsHolder*, uint*, int>)(lpVtbl[3]))((IHTMLOptionsHolder*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLOptionsHolder*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLOptionsHolder*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLOptionsHolder*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLOptionsHolder*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLOptionsHolder*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLOptionsHolder*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_document(IHTMLDocument2** p)
        {
            return ((delegate* unmanaged<IHTMLOptionsHolder*, IHTMLDocument2**, int>)(lpVtbl[7]))((IHTMLOptionsHolder*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_fonts(IHTMLFontNamesCollection** p)
        {
            return ((delegate* unmanaged<IHTMLOptionsHolder*, IHTMLFontNamesCollection**, int>)(lpVtbl[8]))((IHTMLOptionsHolder*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT put_execArg(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLOptionsHolder*, VARIANT, int>)(lpVtbl[9]))((IHTMLOptionsHolder*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_execArg(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLOptionsHolder*, VARIANT*, int>)(lpVtbl[10]))((IHTMLOptionsHolder*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT put_errorLine([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLOptionsHolder*, int, int>)(lpVtbl[11]))((IHTMLOptionsHolder*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_errorLine([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLOptionsHolder*, int*, int>)(lpVtbl[12]))((IHTMLOptionsHolder*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT put_errorCharacter([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLOptionsHolder*, int, int>)(lpVtbl[13]))((IHTMLOptionsHolder*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT get_errorCharacter([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLOptionsHolder*, int*, int>)(lpVtbl[14]))((IHTMLOptionsHolder*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT put_errorCode([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLOptionsHolder*, int, int>)(lpVtbl[15]))((IHTMLOptionsHolder*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT get_errorCode([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLOptionsHolder*, int*, int>)(lpVtbl[16]))((IHTMLOptionsHolder*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT put_errorMessage([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLOptionsHolder*, ushort*, int>)(lpVtbl[17]))((IHTMLOptionsHolder*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT get_errorMessage([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLOptionsHolder*, ushort**, int>)(lpVtbl[18]))((IHTMLOptionsHolder*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT put_errorDebug([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLOptionsHolder*, short, int>)(lpVtbl[19]))((IHTMLOptionsHolder*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT get_errorDebug([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLOptionsHolder*, short*, int>)(lpVtbl[20]))((IHTMLOptionsHolder*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT get_unsecuredWindowOfDocument(IHTMLWindow2** p)
        {
            return ((delegate* unmanaged<IHTMLOptionsHolder*, IHTMLWindow2**, int>)(lpVtbl[21]))((IHTMLOptionsHolder*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT put_findText([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLOptionsHolder*, ushort*, int>)(lpVtbl[22]))((IHTMLOptionsHolder*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT get_findText([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLOptionsHolder*, ushort**, int>)(lpVtbl[23]))((IHTMLOptionsHolder*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT put_anythingAfterFrameset([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLOptionsHolder*, short, int>)(lpVtbl[24]))((IHTMLOptionsHolder*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT get_anythingAfterFrameset([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLOptionsHolder*, short*, int>)(lpVtbl[25]))((IHTMLOptionsHolder*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT sizes([NativeTypeName("BSTR")] ushort* fontName, IHTMLFontSizesCollection** pSizesCollection)
        {
            return ((delegate* unmanaged<IHTMLOptionsHolder*, ushort*, IHTMLFontSizesCollection**, int>)(lpVtbl[26]))((IHTMLOptionsHolder*)Unsafe.AsPointer(ref this), fontName, pSizesCollection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT openfiledlg(VARIANT initFile, VARIANT initDir, VARIANT filter, VARIANT title, [NativeTypeName("BSTR *")] ushort** pathName)
        {
            return ((delegate* unmanaged<IHTMLOptionsHolder*, VARIANT, VARIANT, VARIANT, VARIANT, ushort**, int>)(lpVtbl[27]))((IHTMLOptionsHolder*)Unsafe.AsPointer(ref this), initFile, initDir, filter, title, pathName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT savefiledlg(VARIANT initFile, VARIANT initDir, VARIANT filter, VARIANT title, [NativeTypeName("BSTR *")] ushort** pathName)
        {
            return ((delegate* unmanaged<IHTMLOptionsHolder*, VARIANT, VARIANT, VARIANT, VARIANT, ushort**, int>)(lpVtbl[28]))((IHTMLOptionsHolder*)Unsafe.AsPointer(ref this), initFile, initDir, filter, title, pathName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT choosecolordlg(VARIANT initColor, [NativeTypeName("long *")] int* rgbColor)
        {
            return ((delegate* unmanaged<IHTMLOptionsHolder*, VARIANT, int*, int>)(lpVtbl[29]))((IHTMLOptionsHolder*)Unsafe.AsPointer(ref this), initColor, rgbColor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT showSecurityInfo()
        {
            return ((delegate* unmanaged<IHTMLOptionsHolder*, int>)(lpVtbl[30]))((IHTMLOptionsHolder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT isApartmentModel(IHTMLObjectElement* @object, [NativeTypeName("VARIANT_BOOL *")] short* fApartment)
        {
            return ((delegate* unmanaged<IHTMLOptionsHolder*, IHTMLObjectElement*, short*, int>)(lpVtbl[31]))((IHTMLOptionsHolder*)Unsafe.AsPointer(ref this), @object, fApartment);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT getCharset([NativeTypeName("BSTR")] ushort* fontName, [NativeTypeName("long *")] int* charset)
        {
            return ((delegate* unmanaged<IHTMLOptionsHolder*, ushort*, int*, int>)(lpVtbl[32]))((IHTMLOptionsHolder*)Unsafe.AsPointer(ref this), fontName, charset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT get_secureConnectionInfo([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLOptionsHolder*, ushort**, int>)(lpVtbl[33]))((IHTMLOptionsHolder*)Unsafe.AsPointer(ref this), p);
        }
    }
}
