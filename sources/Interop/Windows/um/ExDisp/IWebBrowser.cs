// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ExDisp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EAB22AC1-30C1-11CF-A7EB-0000C05BAE0B")]
    [NativeTypeName("struct IWebBrowser : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IWebBrowser
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWebBrowser*, Guid*, void**, int>)(lpVtbl[0]))((IWebBrowser*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWebBrowser*, uint>)(lpVtbl[1]))((IWebBrowser*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWebBrowser*, uint>)(lpVtbl[2]))((IWebBrowser*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IWebBrowser*, uint*, int>)(lpVtbl[3]))((IWebBrowser*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IWebBrowser*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IWebBrowser*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IWebBrowser*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IWebBrowser*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IWebBrowser*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IWebBrowser*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GoBack()
        {
            return ((delegate* unmanaged<IWebBrowser*, int>)(lpVtbl[7]))((IWebBrowser*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GoForward()
        {
            return ((delegate* unmanaged<IWebBrowser*, int>)(lpVtbl[8]))((IWebBrowser*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int GoHome()
        {
            return ((delegate* unmanaged<IWebBrowser*, int>)(lpVtbl[9]))((IWebBrowser*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int GoSearch()
        {
            return ((delegate* unmanaged<IWebBrowser*, int>)(lpVtbl[10]))((IWebBrowser*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int Navigate([NativeTypeName("BSTR")] ushort* URL, VARIANT* Flags, VARIANT* TargetFrameName, VARIANT* PostData, VARIANT* Headers)
        {
            return ((delegate* unmanaged<IWebBrowser*, ushort*, VARIANT*, VARIANT*, VARIANT*, VARIANT*, int>)(lpVtbl[11]))((IWebBrowser*)Unsafe.AsPointer(ref this), URL, Flags, TargetFrameName, PostData, Headers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int Refresh()
        {
            return ((delegate* unmanaged<IWebBrowser*, int>)(lpVtbl[12]))((IWebBrowser*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int Refresh2(VARIANT* Level)
        {
            return ((delegate* unmanaged<IWebBrowser*, VARIANT*, int>)(lpVtbl[13]))((IWebBrowser*)Unsafe.AsPointer(ref this), Level);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int Stop()
        {
            return ((delegate* unmanaged<IWebBrowser*, int>)(lpVtbl[14]))((IWebBrowser*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int get_Application(IDispatch** ppDisp)
        {
            return ((delegate* unmanaged<IWebBrowser*, IDispatch**, int>)(lpVtbl[15]))((IWebBrowser*)Unsafe.AsPointer(ref this), ppDisp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int get_Parent(IDispatch** ppDisp)
        {
            return ((delegate* unmanaged<IWebBrowser*, IDispatch**, int>)(lpVtbl[16]))((IWebBrowser*)Unsafe.AsPointer(ref this), ppDisp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int get_Container(IDispatch** ppDisp)
        {
            return ((delegate* unmanaged<IWebBrowser*, IDispatch**, int>)(lpVtbl[17]))((IWebBrowser*)Unsafe.AsPointer(ref this), ppDisp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int get_Document(IDispatch** ppDisp)
        {
            return ((delegate* unmanaged<IWebBrowser*, IDispatch**, int>)(lpVtbl[18]))((IWebBrowser*)Unsafe.AsPointer(ref this), ppDisp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int get_TopLevelContainer([NativeTypeName("VARIANT_BOOL *")] short* pBool)
        {
            return ((delegate* unmanaged<IWebBrowser*, short*, int>)(lpVtbl[19]))((IWebBrowser*)Unsafe.AsPointer(ref this), pBool);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int get_Type([NativeTypeName("BSTR *")] ushort** Type)
        {
            return ((delegate* unmanaged<IWebBrowser*, ushort**, int>)(lpVtbl[20]))((IWebBrowser*)Unsafe.AsPointer(ref this), Type);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int get_Left([NativeTypeName("long *")] int* pl)
        {
            return ((delegate* unmanaged<IWebBrowser*, int*, int>)(lpVtbl[21]))((IWebBrowser*)Unsafe.AsPointer(ref this), pl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int put_Left([NativeTypeName("long")] int Left)
        {
            return ((delegate* unmanaged<IWebBrowser*, int, int>)(lpVtbl[22]))((IWebBrowser*)Unsafe.AsPointer(ref this), Left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int get_Top([NativeTypeName("long *")] int* pl)
        {
            return ((delegate* unmanaged<IWebBrowser*, int*, int>)(lpVtbl[23]))((IWebBrowser*)Unsafe.AsPointer(ref this), pl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int put_Top([NativeTypeName("long")] int Top)
        {
            return ((delegate* unmanaged<IWebBrowser*, int, int>)(lpVtbl[24]))((IWebBrowser*)Unsafe.AsPointer(ref this), Top);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int get_Width([NativeTypeName("long *")] int* pl)
        {
            return ((delegate* unmanaged<IWebBrowser*, int*, int>)(lpVtbl[25]))((IWebBrowser*)Unsafe.AsPointer(ref this), pl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int put_Width([NativeTypeName("long")] int Width)
        {
            return ((delegate* unmanaged<IWebBrowser*, int, int>)(lpVtbl[26]))((IWebBrowser*)Unsafe.AsPointer(ref this), Width);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int get_Height([NativeTypeName("long *")] int* pl)
        {
            return ((delegate* unmanaged<IWebBrowser*, int*, int>)(lpVtbl[27]))((IWebBrowser*)Unsafe.AsPointer(ref this), pl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int put_Height([NativeTypeName("long")] int Height)
        {
            return ((delegate* unmanaged<IWebBrowser*, int, int>)(lpVtbl[28]))((IWebBrowser*)Unsafe.AsPointer(ref this), Height);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int get_LocationName([NativeTypeName("BSTR *")] ushort** LocationName)
        {
            return ((delegate* unmanaged<IWebBrowser*, ushort**, int>)(lpVtbl[29]))((IWebBrowser*)Unsafe.AsPointer(ref this), LocationName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int get_LocationURL([NativeTypeName("BSTR *")] ushort** LocationURL)
        {
            return ((delegate* unmanaged<IWebBrowser*, ushort**, int>)(lpVtbl[30]))((IWebBrowser*)Unsafe.AsPointer(ref this), LocationURL);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int get_Busy([NativeTypeName("VARIANT_BOOL *")] short* pBool)
        {
            return ((delegate* unmanaged<IWebBrowser*, short*, int>)(lpVtbl[31]))((IWebBrowser*)Unsafe.AsPointer(ref this), pBool);
        }
    }
}
