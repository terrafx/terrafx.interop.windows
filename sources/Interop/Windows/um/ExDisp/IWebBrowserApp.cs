// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ExDisp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0002DF05-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IWebBrowserApp : IWebBrowser")]
    [NativeInheritance("IWebBrowser")]
    public unsafe partial struct IWebBrowserApp
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWebBrowserApp*, Guid*, void**, int>)(lpVtbl[0]))((IWebBrowserApp*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWebBrowserApp*, uint>)(lpVtbl[1]))((IWebBrowserApp*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWebBrowserApp*, uint>)(lpVtbl[2]))((IWebBrowserApp*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IWebBrowserApp*, uint*, int>)(lpVtbl[3]))((IWebBrowserApp*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IWebBrowserApp*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IWebBrowserApp*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IWebBrowserApp*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IWebBrowserApp*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IWebBrowserApp*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IWebBrowserApp*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GoBack()
        {
            return ((delegate* unmanaged<IWebBrowserApp*, int>)(lpVtbl[7]))((IWebBrowserApp*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GoForward()
        {
            return ((delegate* unmanaged<IWebBrowserApp*, int>)(lpVtbl[8]))((IWebBrowserApp*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GoHome()
        {
            return ((delegate* unmanaged<IWebBrowserApp*, int>)(lpVtbl[9]))((IWebBrowserApp*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GoSearch()
        {
            return ((delegate* unmanaged<IWebBrowserApp*, int>)(lpVtbl[10]))((IWebBrowserApp*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT Navigate([NativeTypeName("BSTR")] ushort* URL, VARIANT* Flags, VARIANT* TargetFrameName, VARIANT* PostData, VARIANT* Headers)
        {
            return ((delegate* unmanaged<IWebBrowserApp*, ushort*, VARIANT*, VARIANT*, VARIANT*, VARIANT*, int>)(lpVtbl[11]))((IWebBrowserApp*)Unsafe.AsPointer(ref this), URL, Flags, TargetFrameName, PostData, Headers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT Refresh()
        {
            return ((delegate* unmanaged<IWebBrowserApp*, int>)(lpVtbl[12]))((IWebBrowserApp*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT Refresh2(VARIANT* Level)
        {
            return ((delegate* unmanaged<IWebBrowserApp*, VARIANT*, int>)(lpVtbl[13]))((IWebBrowserApp*)Unsafe.AsPointer(ref this), Level);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT Stop()
        {
            return ((delegate* unmanaged<IWebBrowserApp*, int>)(lpVtbl[14]))((IWebBrowserApp*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT get_Application(IDispatch** ppDisp)
        {
            return ((delegate* unmanaged<IWebBrowserApp*, IDispatch**, int>)(lpVtbl[15]))((IWebBrowserApp*)Unsafe.AsPointer(ref this), ppDisp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT get_Parent(IDispatch** ppDisp)
        {
            return ((delegate* unmanaged<IWebBrowserApp*, IDispatch**, int>)(lpVtbl[16]))((IWebBrowserApp*)Unsafe.AsPointer(ref this), ppDisp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT get_Container(IDispatch** ppDisp)
        {
            return ((delegate* unmanaged<IWebBrowserApp*, IDispatch**, int>)(lpVtbl[17]))((IWebBrowserApp*)Unsafe.AsPointer(ref this), ppDisp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT get_Document(IDispatch** ppDisp)
        {
            return ((delegate* unmanaged<IWebBrowserApp*, IDispatch**, int>)(lpVtbl[18]))((IWebBrowserApp*)Unsafe.AsPointer(ref this), ppDisp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT get_TopLevelContainer([NativeTypeName("VARIANT_BOOL *")] short* pBool)
        {
            return ((delegate* unmanaged<IWebBrowserApp*, short*, int>)(lpVtbl[19]))((IWebBrowserApp*)Unsafe.AsPointer(ref this), pBool);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT get_Type([NativeTypeName("BSTR *")] ushort** Type)
        {
            return ((delegate* unmanaged<IWebBrowserApp*, ushort**, int>)(lpVtbl[20]))((IWebBrowserApp*)Unsafe.AsPointer(ref this), Type);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT get_Left([NativeTypeName("long *")] int* pl)
        {
            return ((delegate* unmanaged<IWebBrowserApp*, int*, int>)(lpVtbl[21]))((IWebBrowserApp*)Unsafe.AsPointer(ref this), pl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT put_Left([NativeTypeName("long")] int Left)
        {
            return ((delegate* unmanaged<IWebBrowserApp*, int, int>)(lpVtbl[22]))((IWebBrowserApp*)Unsafe.AsPointer(ref this), Left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT get_Top([NativeTypeName("long *")] int* pl)
        {
            return ((delegate* unmanaged<IWebBrowserApp*, int*, int>)(lpVtbl[23]))((IWebBrowserApp*)Unsafe.AsPointer(ref this), pl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT put_Top([NativeTypeName("long")] int Top)
        {
            return ((delegate* unmanaged<IWebBrowserApp*, int, int>)(lpVtbl[24]))((IWebBrowserApp*)Unsafe.AsPointer(ref this), Top);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT get_Width([NativeTypeName("long *")] int* pl)
        {
            return ((delegate* unmanaged<IWebBrowserApp*, int*, int>)(lpVtbl[25]))((IWebBrowserApp*)Unsafe.AsPointer(ref this), pl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT put_Width([NativeTypeName("long")] int Width)
        {
            return ((delegate* unmanaged<IWebBrowserApp*, int, int>)(lpVtbl[26]))((IWebBrowserApp*)Unsafe.AsPointer(ref this), Width);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT get_Height([NativeTypeName("long *")] int* pl)
        {
            return ((delegate* unmanaged<IWebBrowserApp*, int*, int>)(lpVtbl[27]))((IWebBrowserApp*)Unsafe.AsPointer(ref this), pl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT put_Height([NativeTypeName("long")] int Height)
        {
            return ((delegate* unmanaged<IWebBrowserApp*, int, int>)(lpVtbl[28]))((IWebBrowserApp*)Unsafe.AsPointer(ref this), Height);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT get_LocationName([NativeTypeName("BSTR *")] ushort** LocationName)
        {
            return ((delegate* unmanaged<IWebBrowserApp*, ushort**, int>)(lpVtbl[29]))((IWebBrowserApp*)Unsafe.AsPointer(ref this), LocationName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT get_LocationURL([NativeTypeName("BSTR *")] ushort** LocationURL)
        {
            return ((delegate* unmanaged<IWebBrowserApp*, ushort**, int>)(lpVtbl[30]))((IWebBrowserApp*)Unsafe.AsPointer(ref this), LocationURL);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT get_Busy([NativeTypeName("VARIANT_BOOL *")] short* pBool)
        {
            return ((delegate* unmanaged<IWebBrowserApp*, short*, int>)(lpVtbl[31]))((IWebBrowserApp*)Unsafe.AsPointer(ref this), pBool);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT Quit()
        {
            return ((delegate* unmanaged<IWebBrowserApp*, int>)(lpVtbl[32]))((IWebBrowserApp*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT ClientToWindow(int* pcx, int* pcy)
        {
            return ((delegate* unmanaged<IWebBrowserApp*, int*, int*, int>)(lpVtbl[33]))((IWebBrowserApp*)Unsafe.AsPointer(ref this), pcx, pcy);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT PutProperty([NativeTypeName("BSTR")] ushort* Property, VARIANT vtValue)
        {
            return ((delegate* unmanaged<IWebBrowserApp*, ushort*, VARIANT, int>)(lpVtbl[34]))((IWebBrowserApp*)Unsafe.AsPointer(ref this), Property, vtValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT GetProperty([NativeTypeName("BSTR")] ushort* Property, VARIANT* pvtValue)
        {
            return ((delegate* unmanaged<IWebBrowserApp*, ushort*, VARIANT*, int>)(lpVtbl[35]))((IWebBrowserApp*)Unsafe.AsPointer(ref this), Property, pvtValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HRESULT get_Name([NativeTypeName("BSTR *")] ushort** Name)
        {
            return ((delegate* unmanaged<IWebBrowserApp*, ushort**, int>)(lpVtbl[36]))((IWebBrowserApp*)Unsafe.AsPointer(ref this), Name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public HRESULT get_HWND([NativeTypeName("SHANDLE_PTR *")] nint* pHWND)
        {
            return ((delegate* unmanaged<IWebBrowserApp*, nint*, int>)(lpVtbl[37]))((IWebBrowserApp*)Unsafe.AsPointer(ref this), pHWND);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public HRESULT get_FullName([NativeTypeName("BSTR *")] ushort** FullName)
        {
            return ((delegate* unmanaged<IWebBrowserApp*, ushort**, int>)(lpVtbl[38]))((IWebBrowserApp*)Unsafe.AsPointer(ref this), FullName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public HRESULT get_Path([NativeTypeName("BSTR *")] ushort** Path)
        {
            return ((delegate* unmanaged<IWebBrowserApp*, ushort**, int>)(lpVtbl[39]))((IWebBrowserApp*)Unsafe.AsPointer(ref this), Path);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        public HRESULT get_Visible([NativeTypeName("VARIANT_BOOL *")] short* pBool)
        {
            return ((delegate* unmanaged<IWebBrowserApp*, short*, int>)(lpVtbl[40]))((IWebBrowserApp*)Unsafe.AsPointer(ref this), pBool);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        public HRESULT put_Visible([NativeTypeName("VARIANT_BOOL")] short Value)
        {
            return ((delegate* unmanaged<IWebBrowserApp*, short, int>)(lpVtbl[41]))((IWebBrowserApp*)Unsafe.AsPointer(ref this), Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        public HRESULT get_StatusBar([NativeTypeName("VARIANT_BOOL *")] short* pBool)
        {
            return ((delegate* unmanaged<IWebBrowserApp*, short*, int>)(lpVtbl[42]))((IWebBrowserApp*)Unsafe.AsPointer(ref this), pBool);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        public HRESULT put_StatusBar([NativeTypeName("VARIANT_BOOL")] short Value)
        {
            return ((delegate* unmanaged<IWebBrowserApp*, short, int>)(lpVtbl[43]))((IWebBrowserApp*)Unsafe.AsPointer(ref this), Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        public HRESULT get_StatusText([NativeTypeName("BSTR *")] ushort** StatusText)
        {
            return ((delegate* unmanaged<IWebBrowserApp*, ushort**, int>)(lpVtbl[44]))((IWebBrowserApp*)Unsafe.AsPointer(ref this), StatusText);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        public HRESULT put_StatusText([NativeTypeName("BSTR")] ushort* StatusText)
        {
            return ((delegate* unmanaged<IWebBrowserApp*, ushort*, int>)(lpVtbl[45]))((IWebBrowserApp*)Unsafe.AsPointer(ref this), StatusText);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        public HRESULT get_ToolBar(int* Value)
        {
            return ((delegate* unmanaged<IWebBrowserApp*, int*, int>)(lpVtbl[46]))((IWebBrowserApp*)Unsafe.AsPointer(ref this), Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        public HRESULT put_ToolBar(int Value)
        {
            return ((delegate* unmanaged<IWebBrowserApp*, int, int>)(lpVtbl[47]))((IWebBrowserApp*)Unsafe.AsPointer(ref this), Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        public HRESULT get_MenuBar([NativeTypeName("VARIANT_BOOL *")] short* Value)
        {
            return ((delegate* unmanaged<IWebBrowserApp*, short*, int>)(lpVtbl[48]))((IWebBrowserApp*)Unsafe.AsPointer(ref this), Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        public HRESULT put_MenuBar([NativeTypeName("VARIANT_BOOL")] short Value)
        {
            return ((delegate* unmanaged<IWebBrowserApp*, short, int>)(lpVtbl[49]))((IWebBrowserApp*)Unsafe.AsPointer(ref this), Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        public HRESULT get_FullScreen([NativeTypeName("VARIANT_BOOL *")] short* pbFullScreen)
        {
            return ((delegate* unmanaged<IWebBrowserApp*, short*, int>)(lpVtbl[50]))((IWebBrowserApp*)Unsafe.AsPointer(ref this), pbFullScreen);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        public HRESULT put_FullScreen([NativeTypeName("VARIANT_BOOL")] short bFullScreen)
        {
            return ((delegate* unmanaged<IWebBrowserApp*, short, int>)(lpVtbl[51]))((IWebBrowserApp*)Unsafe.AsPointer(ref this), bFullScreen);
        }
    }
}
