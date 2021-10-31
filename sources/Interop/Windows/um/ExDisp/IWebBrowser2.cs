// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ExDisp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D30C1661-CDAF-11D0-8A3E-00C04FC9E26E")]
    [NativeTypeName("struct IWebBrowser2 : IWebBrowserApp")]
    [NativeInheritance("IWebBrowserApp")]
    public unsafe partial struct IWebBrowser2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWebBrowser2*, Guid*, void**, int>)(lpVtbl[0]))((IWebBrowser2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWebBrowser2*, uint>)(lpVtbl[1]))((IWebBrowser2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWebBrowser2*, uint>)(lpVtbl[2]))((IWebBrowser2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IWebBrowser2*, uint*, int>)(lpVtbl[3]))((IWebBrowser2*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IWebBrowser2*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IWebBrowser2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IWebBrowser2*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IWebBrowser2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IWebBrowser2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IWebBrowser2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GoBack()
        {
            return ((delegate* unmanaged<IWebBrowser2*, int>)(lpVtbl[7]))((IWebBrowser2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GoForward()
        {
            return ((delegate* unmanaged<IWebBrowser2*, int>)(lpVtbl[8]))((IWebBrowser2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GoHome()
        {
            return ((delegate* unmanaged<IWebBrowser2*, int>)(lpVtbl[9]))((IWebBrowser2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GoSearch()
        {
            return ((delegate* unmanaged<IWebBrowser2*, int>)(lpVtbl[10]))((IWebBrowser2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT Navigate([NativeTypeName("BSTR")] ushort* URL, VARIANT* Flags, VARIANT* TargetFrameName, VARIANT* PostData, VARIANT* Headers)
        {
            return ((delegate* unmanaged<IWebBrowser2*, ushort*, VARIANT*, VARIANT*, VARIANT*, VARIANT*, int>)(lpVtbl[11]))((IWebBrowser2*)Unsafe.AsPointer(ref this), URL, Flags, TargetFrameName, PostData, Headers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT Refresh()
        {
            return ((delegate* unmanaged<IWebBrowser2*, int>)(lpVtbl[12]))((IWebBrowser2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT Refresh2(VARIANT* Level)
        {
            return ((delegate* unmanaged<IWebBrowser2*, VARIANT*, int>)(lpVtbl[13]))((IWebBrowser2*)Unsafe.AsPointer(ref this), Level);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT Stop()
        {
            return ((delegate* unmanaged<IWebBrowser2*, int>)(lpVtbl[14]))((IWebBrowser2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT get_Application(IDispatch** ppDisp)
        {
            return ((delegate* unmanaged<IWebBrowser2*, IDispatch**, int>)(lpVtbl[15]))((IWebBrowser2*)Unsafe.AsPointer(ref this), ppDisp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT get_Parent(IDispatch** ppDisp)
        {
            return ((delegate* unmanaged<IWebBrowser2*, IDispatch**, int>)(lpVtbl[16]))((IWebBrowser2*)Unsafe.AsPointer(ref this), ppDisp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT get_Container(IDispatch** ppDisp)
        {
            return ((delegate* unmanaged<IWebBrowser2*, IDispatch**, int>)(lpVtbl[17]))((IWebBrowser2*)Unsafe.AsPointer(ref this), ppDisp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT get_Document(IDispatch** ppDisp)
        {
            return ((delegate* unmanaged<IWebBrowser2*, IDispatch**, int>)(lpVtbl[18]))((IWebBrowser2*)Unsafe.AsPointer(ref this), ppDisp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT get_TopLevelContainer([NativeTypeName("VARIANT_BOOL *")] short* pBool)
        {
            return ((delegate* unmanaged<IWebBrowser2*, short*, int>)(lpVtbl[19]))((IWebBrowser2*)Unsafe.AsPointer(ref this), pBool);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT get_Type([NativeTypeName("BSTR *")] ushort** Type)
        {
            return ((delegate* unmanaged<IWebBrowser2*, ushort**, int>)(lpVtbl[20]))((IWebBrowser2*)Unsafe.AsPointer(ref this), Type);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT get_Left([NativeTypeName("long *")] int* pl)
        {
            return ((delegate* unmanaged<IWebBrowser2*, int*, int>)(lpVtbl[21]))((IWebBrowser2*)Unsafe.AsPointer(ref this), pl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT put_Left([NativeTypeName("long")] int Left)
        {
            return ((delegate* unmanaged<IWebBrowser2*, int, int>)(lpVtbl[22]))((IWebBrowser2*)Unsafe.AsPointer(ref this), Left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT get_Top([NativeTypeName("long *")] int* pl)
        {
            return ((delegate* unmanaged<IWebBrowser2*, int*, int>)(lpVtbl[23]))((IWebBrowser2*)Unsafe.AsPointer(ref this), pl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT put_Top([NativeTypeName("long")] int Top)
        {
            return ((delegate* unmanaged<IWebBrowser2*, int, int>)(lpVtbl[24]))((IWebBrowser2*)Unsafe.AsPointer(ref this), Top);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT get_Width([NativeTypeName("long *")] int* pl)
        {
            return ((delegate* unmanaged<IWebBrowser2*, int*, int>)(lpVtbl[25]))((IWebBrowser2*)Unsafe.AsPointer(ref this), pl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT put_Width([NativeTypeName("long")] int Width)
        {
            return ((delegate* unmanaged<IWebBrowser2*, int, int>)(lpVtbl[26]))((IWebBrowser2*)Unsafe.AsPointer(ref this), Width);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT get_Height([NativeTypeName("long *")] int* pl)
        {
            return ((delegate* unmanaged<IWebBrowser2*, int*, int>)(lpVtbl[27]))((IWebBrowser2*)Unsafe.AsPointer(ref this), pl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT put_Height([NativeTypeName("long")] int Height)
        {
            return ((delegate* unmanaged<IWebBrowser2*, int, int>)(lpVtbl[28]))((IWebBrowser2*)Unsafe.AsPointer(ref this), Height);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT get_LocationName([NativeTypeName("BSTR *")] ushort** LocationName)
        {
            return ((delegate* unmanaged<IWebBrowser2*, ushort**, int>)(lpVtbl[29]))((IWebBrowser2*)Unsafe.AsPointer(ref this), LocationName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT get_LocationURL([NativeTypeName("BSTR *")] ushort** LocationURL)
        {
            return ((delegate* unmanaged<IWebBrowser2*, ushort**, int>)(lpVtbl[30]))((IWebBrowser2*)Unsafe.AsPointer(ref this), LocationURL);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT get_Busy([NativeTypeName("VARIANT_BOOL *")] short* pBool)
        {
            return ((delegate* unmanaged<IWebBrowser2*, short*, int>)(lpVtbl[31]))((IWebBrowser2*)Unsafe.AsPointer(ref this), pBool);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT Quit()
        {
            return ((delegate* unmanaged<IWebBrowser2*, int>)(lpVtbl[32]))((IWebBrowser2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT ClientToWindow(int* pcx, int* pcy)
        {
            return ((delegate* unmanaged<IWebBrowser2*, int*, int*, int>)(lpVtbl[33]))((IWebBrowser2*)Unsafe.AsPointer(ref this), pcx, pcy);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT PutProperty([NativeTypeName("BSTR")] ushort* Property, VARIANT vtValue)
        {
            return ((delegate* unmanaged<IWebBrowser2*, ushort*, VARIANT, int>)(lpVtbl[34]))((IWebBrowser2*)Unsafe.AsPointer(ref this), Property, vtValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT GetProperty([NativeTypeName("BSTR")] ushort* Property, VARIANT* pvtValue)
        {
            return ((delegate* unmanaged<IWebBrowser2*, ushort*, VARIANT*, int>)(lpVtbl[35]))((IWebBrowser2*)Unsafe.AsPointer(ref this), Property, pvtValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HRESULT get_Name([NativeTypeName("BSTR *")] ushort** Name)
        {
            return ((delegate* unmanaged<IWebBrowser2*, ushort**, int>)(lpVtbl[36]))((IWebBrowser2*)Unsafe.AsPointer(ref this), Name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public HRESULT get_HWND([NativeTypeName("SHANDLE_PTR *")] nint* pHWND)
        {
            return ((delegate* unmanaged<IWebBrowser2*, nint*, int>)(lpVtbl[37]))((IWebBrowser2*)Unsafe.AsPointer(ref this), pHWND);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public HRESULT get_FullName([NativeTypeName("BSTR *")] ushort** FullName)
        {
            return ((delegate* unmanaged<IWebBrowser2*, ushort**, int>)(lpVtbl[38]))((IWebBrowser2*)Unsafe.AsPointer(ref this), FullName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public HRESULT get_Path([NativeTypeName("BSTR *")] ushort** Path)
        {
            return ((delegate* unmanaged<IWebBrowser2*, ushort**, int>)(lpVtbl[39]))((IWebBrowser2*)Unsafe.AsPointer(ref this), Path);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        public HRESULT get_Visible([NativeTypeName("VARIANT_BOOL *")] short* pBool)
        {
            return ((delegate* unmanaged<IWebBrowser2*, short*, int>)(lpVtbl[40]))((IWebBrowser2*)Unsafe.AsPointer(ref this), pBool);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        public HRESULT put_Visible([NativeTypeName("VARIANT_BOOL")] short Value)
        {
            return ((delegate* unmanaged<IWebBrowser2*, short, int>)(lpVtbl[41]))((IWebBrowser2*)Unsafe.AsPointer(ref this), Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        public HRESULT get_StatusBar([NativeTypeName("VARIANT_BOOL *")] short* pBool)
        {
            return ((delegate* unmanaged<IWebBrowser2*, short*, int>)(lpVtbl[42]))((IWebBrowser2*)Unsafe.AsPointer(ref this), pBool);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        public HRESULT put_StatusBar([NativeTypeName("VARIANT_BOOL")] short Value)
        {
            return ((delegate* unmanaged<IWebBrowser2*, short, int>)(lpVtbl[43]))((IWebBrowser2*)Unsafe.AsPointer(ref this), Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        public HRESULT get_StatusText([NativeTypeName("BSTR *")] ushort** StatusText)
        {
            return ((delegate* unmanaged<IWebBrowser2*, ushort**, int>)(lpVtbl[44]))((IWebBrowser2*)Unsafe.AsPointer(ref this), StatusText);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        public HRESULT put_StatusText([NativeTypeName("BSTR")] ushort* StatusText)
        {
            return ((delegate* unmanaged<IWebBrowser2*, ushort*, int>)(lpVtbl[45]))((IWebBrowser2*)Unsafe.AsPointer(ref this), StatusText);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        public HRESULT get_ToolBar(int* Value)
        {
            return ((delegate* unmanaged<IWebBrowser2*, int*, int>)(lpVtbl[46]))((IWebBrowser2*)Unsafe.AsPointer(ref this), Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        public HRESULT put_ToolBar(int Value)
        {
            return ((delegate* unmanaged<IWebBrowser2*, int, int>)(lpVtbl[47]))((IWebBrowser2*)Unsafe.AsPointer(ref this), Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        public HRESULT get_MenuBar([NativeTypeName("VARIANT_BOOL *")] short* Value)
        {
            return ((delegate* unmanaged<IWebBrowser2*, short*, int>)(lpVtbl[48]))((IWebBrowser2*)Unsafe.AsPointer(ref this), Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        public HRESULT put_MenuBar([NativeTypeName("VARIANT_BOOL")] short Value)
        {
            return ((delegate* unmanaged<IWebBrowser2*, short, int>)(lpVtbl[49]))((IWebBrowser2*)Unsafe.AsPointer(ref this), Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        public HRESULT get_FullScreen([NativeTypeName("VARIANT_BOOL *")] short* pbFullScreen)
        {
            return ((delegate* unmanaged<IWebBrowser2*, short*, int>)(lpVtbl[50]))((IWebBrowser2*)Unsafe.AsPointer(ref this), pbFullScreen);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        public HRESULT put_FullScreen([NativeTypeName("VARIANT_BOOL")] short bFullScreen)
        {
            return ((delegate* unmanaged<IWebBrowser2*, short, int>)(lpVtbl[51]))((IWebBrowser2*)Unsafe.AsPointer(ref this), bFullScreen);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        public HRESULT Navigate2(VARIANT* URL, VARIANT* Flags, VARIANT* TargetFrameName, VARIANT* PostData, VARIANT* Headers)
        {
            return ((delegate* unmanaged<IWebBrowser2*, VARIANT*, VARIANT*, VARIANT*, VARIANT*, VARIANT*, int>)(lpVtbl[52]))((IWebBrowser2*)Unsafe.AsPointer(ref this), URL, Flags, TargetFrameName, PostData, Headers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        public HRESULT QueryStatusWB(OLECMDID cmdID, OLECMDF* pcmdf)
        {
            return ((delegate* unmanaged<IWebBrowser2*, OLECMDID, OLECMDF*, int>)(lpVtbl[53]))((IWebBrowser2*)Unsafe.AsPointer(ref this), cmdID, pcmdf);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        public HRESULT ExecWB(OLECMDID cmdID, OLECMDEXECOPT cmdexecopt, VARIANT* pvaIn, VARIANT* pvaOut)
        {
            return ((delegate* unmanaged<IWebBrowser2*, OLECMDID, OLECMDEXECOPT, VARIANT*, VARIANT*, int>)(lpVtbl[54]))((IWebBrowser2*)Unsafe.AsPointer(ref this), cmdID, cmdexecopt, pvaIn, pvaOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        public HRESULT ShowBrowserBar(VARIANT* pvaClsid, VARIANT* pvarShow, VARIANT* pvarSize)
        {
            return ((delegate* unmanaged<IWebBrowser2*, VARIANT*, VARIANT*, VARIANT*, int>)(lpVtbl[55]))((IWebBrowser2*)Unsafe.AsPointer(ref this), pvaClsid, pvarShow, pvarSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        public HRESULT get_ReadyState(READYSTATE* plReadyState)
        {
            return ((delegate* unmanaged<IWebBrowser2*, READYSTATE*, int>)(lpVtbl[56]))((IWebBrowser2*)Unsafe.AsPointer(ref this), plReadyState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        public HRESULT get_Offline([NativeTypeName("VARIANT_BOOL *")] short* pbOffline)
        {
            return ((delegate* unmanaged<IWebBrowser2*, short*, int>)(lpVtbl[57]))((IWebBrowser2*)Unsafe.AsPointer(ref this), pbOffline);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        public HRESULT put_Offline([NativeTypeName("VARIANT_BOOL")] short bOffline)
        {
            return ((delegate* unmanaged<IWebBrowser2*, short, int>)(lpVtbl[58]))((IWebBrowser2*)Unsafe.AsPointer(ref this), bOffline);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        public HRESULT get_Silent([NativeTypeName("VARIANT_BOOL *")] short* pbSilent)
        {
            return ((delegate* unmanaged<IWebBrowser2*, short*, int>)(lpVtbl[59]))((IWebBrowser2*)Unsafe.AsPointer(ref this), pbSilent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(60)]
        public HRESULT put_Silent([NativeTypeName("VARIANT_BOOL")] short bSilent)
        {
            return ((delegate* unmanaged<IWebBrowser2*, short, int>)(lpVtbl[60]))((IWebBrowser2*)Unsafe.AsPointer(ref this), bSilent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(61)]
        public HRESULT get_RegisterAsBrowser([NativeTypeName("VARIANT_BOOL *")] short* pbRegister)
        {
            return ((delegate* unmanaged<IWebBrowser2*, short*, int>)(lpVtbl[61]))((IWebBrowser2*)Unsafe.AsPointer(ref this), pbRegister);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(62)]
        public HRESULT put_RegisterAsBrowser([NativeTypeName("VARIANT_BOOL")] short bRegister)
        {
            return ((delegate* unmanaged<IWebBrowser2*, short, int>)(lpVtbl[62]))((IWebBrowser2*)Unsafe.AsPointer(ref this), bRegister);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(63)]
        public HRESULT get_RegisterAsDropTarget([NativeTypeName("VARIANT_BOOL *")] short* pbRegister)
        {
            return ((delegate* unmanaged<IWebBrowser2*, short*, int>)(lpVtbl[63]))((IWebBrowser2*)Unsafe.AsPointer(ref this), pbRegister);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(64)]
        public HRESULT put_RegisterAsDropTarget([NativeTypeName("VARIANT_BOOL")] short bRegister)
        {
            return ((delegate* unmanaged<IWebBrowser2*, short, int>)(lpVtbl[64]))((IWebBrowser2*)Unsafe.AsPointer(ref this), bRegister);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(65)]
        public HRESULT get_TheaterMode([NativeTypeName("VARIANT_BOOL *")] short* pbRegister)
        {
            return ((delegate* unmanaged<IWebBrowser2*, short*, int>)(lpVtbl[65]))((IWebBrowser2*)Unsafe.AsPointer(ref this), pbRegister);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(66)]
        public HRESULT put_TheaterMode([NativeTypeName("VARIANT_BOOL")] short bRegister)
        {
            return ((delegate* unmanaged<IWebBrowser2*, short, int>)(lpVtbl[66]))((IWebBrowser2*)Unsafe.AsPointer(ref this), bRegister);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(67)]
        public HRESULT get_AddressBar([NativeTypeName("VARIANT_BOOL *")] short* Value)
        {
            return ((delegate* unmanaged<IWebBrowser2*, short*, int>)(lpVtbl[67]))((IWebBrowser2*)Unsafe.AsPointer(ref this), Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(68)]
        public HRESULT put_AddressBar([NativeTypeName("VARIANT_BOOL")] short Value)
        {
            return ((delegate* unmanaged<IWebBrowser2*, short, int>)(lpVtbl[68]))((IWebBrowser2*)Unsafe.AsPointer(ref this), Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(69)]
        public HRESULT get_Resizable([NativeTypeName("VARIANT_BOOL *")] short* Value)
        {
            return ((delegate* unmanaged<IWebBrowser2*, short*, int>)(lpVtbl[69]))((IWebBrowser2*)Unsafe.AsPointer(ref this), Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(70)]
        public HRESULT put_Resizable([NativeTypeName("VARIANT_BOOL")] short Value)
        {
            return ((delegate* unmanaged<IWebBrowser2*, short, int>)(lpVtbl[70]))((IWebBrowser2*)Unsafe.AsPointer(ref this), Value);
        }
    }
}
