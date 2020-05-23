// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000125-0000-0000-C000-000000000046")]
    public unsafe partial struct IAdviseSink2
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IAdviseSink2* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IAdviseSink2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IAdviseSink2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _OnDataChange(IAdviseSink2* pThis, [NativeTypeName("FORMATETC *")] FORMATETC* pFormatetc, [NativeTypeName("STGMEDIUM *")] STGMEDIUM* pStgmed);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _OnViewChange(IAdviseSink2* pThis, [NativeTypeName("DWORD")] uint dwAspect, [NativeTypeName("LONG")] int lindex);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _OnRename(IAdviseSink2* pThis, [NativeTypeName("IMoniker *")] IMoniker* pmk);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _OnSave(IAdviseSink2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _OnClose(IAdviseSink2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _OnLinkSrcChange(IAdviseSink2* pThis, [NativeTypeName("IMoniker *")] IMoniker* pmk);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IAdviseSink2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IAdviseSink2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IAdviseSink2*)Unsafe.AsPointer(ref this));
        }

        public void OnDataChange([NativeTypeName("FORMATETC *")] FORMATETC* pFormatetc, [NativeTypeName("STGMEDIUM *")] STGMEDIUM* pStgmed)
        {
            Marshal.GetDelegateForFunctionPointer<_OnDataChange>(lpVtbl->OnDataChange)((IAdviseSink2*)Unsafe.AsPointer(ref this), pFormatetc, pStgmed);
        }

        public void OnViewChange([NativeTypeName("DWORD")] uint dwAspect, [NativeTypeName("LONG")] int lindex)
        {
            Marshal.GetDelegateForFunctionPointer<_OnViewChange>(lpVtbl->OnViewChange)((IAdviseSink2*)Unsafe.AsPointer(ref this), dwAspect, lindex);
        }

        public void OnRename([NativeTypeName("IMoniker *")] IMoniker* pmk)
        {
            Marshal.GetDelegateForFunctionPointer<_OnRename>(lpVtbl->OnRename)((IAdviseSink2*)Unsafe.AsPointer(ref this), pmk);
        }

        public void OnSave()
        {
            Marshal.GetDelegateForFunctionPointer<_OnSave>(lpVtbl->OnSave)((IAdviseSink2*)Unsafe.AsPointer(ref this));
        }

        public void OnClose()
        {
            Marshal.GetDelegateForFunctionPointer<_OnClose>(lpVtbl->OnClose)((IAdviseSink2*)Unsafe.AsPointer(ref this));
        }

        public void OnLinkSrcChange([NativeTypeName("IMoniker *")] IMoniker* pmk)
        {
            Marshal.GetDelegateForFunctionPointer<_OnLinkSrcChange>(lpVtbl->OnLinkSrcChange)((IAdviseSink2*)Unsafe.AsPointer(ref this), pmk);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("void (FORMATETC *, STGMEDIUM *) __attribute__((stdcall))")]
            public IntPtr OnDataChange;

            [NativeTypeName("void (DWORD, LONG) __attribute__((stdcall))")]
            public IntPtr OnViewChange;

            [NativeTypeName("void (IMoniker *) __attribute__((stdcall))")]
            public IntPtr OnRename;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public IntPtr OnSave;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public IntPtr OnClose;

            [NativeTypeName("void (IMoniker *) __attribute__((stdcall))")]
            public IntPtr OnLinkSrcChange;
        }
    }
}
