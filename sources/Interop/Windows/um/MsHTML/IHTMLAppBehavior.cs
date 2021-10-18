// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F5CA-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLAppBehavior : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLAppBehavior
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLAppBehavior*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLAppBehavior*, uint>)(lpVtbl[1]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLAppBehavior*, uint>)(lpVtbl[2]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLAppBehavior*, uint*, int>)(lpVtbl[3]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLAppBehavior*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLAppBehavior*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLAppBehavior*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int put_applicationName([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLAppBehavior*, ushort*, int>)(lpVtbl[7]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_applicationName([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLAppBehavior*, ushort**, int>)(lpVtbl[8]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int put_version([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLAppBehavior*, ushort*, int>)(lpVtbl[9]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int get_version([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLAppBehavior*, ushort**, int>)(lpVtbl[10]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int put_icon([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLAppBehavior*, ushort*, int>)(lpVtbl[11]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int get_icon([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLAppBehavior*, ushort**, int>)(lpVtbl[12]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int put_singleInstance([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLAppBehavior*, ushort*, int>)(lpVtbl[13]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int get_singleInstance([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLAppBehavior*, ushort**, int>)(lpVtbl[14]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int put_minimizeButton([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLAppBehavior*, ushort*, int>)(lpVtbl[15]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int get_minimizeButton([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLAppBehavior*, ushort**, int>)(lpVtbl[16]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int put_maximizeButton([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLAppBehavior*, ushort*, int>)(lpVtbl[17]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int get_maximizeButton([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLAppBehavior*, ushort**, int>)(lpVtbl[18]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int put_border([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLAppBehavior*, ushort*, int>)(lpVtbl[19]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int get_border([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLAppBehavior*, ushort**, int>)(lpVtbl[20]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int put_borderStyle([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLAppBehavior*, ushort*, int>)(lpVtbl[21]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderStyle([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLAppBehavior*, ushort**, int>)(lpVtbl[22]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int put_sysMenu([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLAppBehavior*, ushort*, int>)(lpVtbl[23]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int get_sysMenu([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLAppBehavior*, ushort**, int>)(lpVtbl[24]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int put_caption([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLAppBehavior*, ushort*, int>)(lpVtbl[25]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int get_caption([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLAppBehavior*, ushort**, int>)(lpVtbl[26]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int put_windowState([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLAppBehavior*, ushort*, int>)(lpVtbl[27]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int get_windowState([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLAppBehavior*, ushort**, int>)(lpVtbl[28]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int put_showInTaskBar([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLAppBehavior*, ushort*, int>)(lpVtbl[29]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int get_showInTaskBar([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLAppBehavior*, ushort**, int>)(lpVtbl[30]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int get_commandLine([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLAppBehavior*, ushort**, int>)(lpVtbl[31]))((IHTMLAppBehavior*)Unsafe.AsPointer(ref this), p);
        }
    }
}
