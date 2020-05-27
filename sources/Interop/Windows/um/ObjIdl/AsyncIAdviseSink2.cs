// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000151-0000-0000-C000-000000000046")]
    public unsafe partial struct AsyncIAdviseSink2
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(AsyncIAdviseSink2* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(AsyncIAdviseSink2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(AsyncIAdviseSink2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _Begin_OnDataChange(AsyncIAdviseSink2* pThis, [NativeTypeName("FORMATETC *")] FORMATETC* pFormatetc, [NativeTypeName("STGMEDIUM *")] STGMEDIUM* pStgmed);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _Finish_OnDataChange(AsyncIAdviseSink2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _Begin_OnViewChange(AsyncIAdviseSink2* pThis, [NativeTypeName("DWORD")] uint dwAspect, [NativeTypeName("LONG")] int lindex);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _Finish_OnViewChange(AsyncIAdviseSink2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _Begin_OnRename(AsyncIAdviseSink2* pThis, [NativeTypeName("IMoniker *")] IMoniker* pmk);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _Finish_OnRename(AsyncIAdviseSink2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _Begin_OnSave(AsyncIAdviseSink2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _Finish_OnSave(AsyncIAdviseSink2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _Begin_OnClose(AsyncIAdviseSink2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _Finish_OnClose(AsyncIAdviseSink2* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _Begin_OnLinkSrcChange(AsyncIAdviseSink2* pThis, [NativeTypeName("IMoniker *")] IMoniker* pmk);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _Finish_OnLinkSrcChange(AsyncIAdviseSink2* pThis);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this));
        }

        public void Begin_OnDataChange([NativeTypeName("FORMATETC *")] FORMATETC* pFormatetc, [NativeTypeName("STGMEDIUM *")] STGMEDIUM* pStgmed)
        {
            Marshal.GetDelegateForFunctionPointer<_Begin_OnDataChange>(lpVtbl->Begin_OnDataChange)((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this), pFormatetc, pStgmed);
        }

        public void Finish_OnDataChange()
        {
            Marshal.GetDelegateForFunctionPointer<_Finish_OnDataChange>(lpVtbl->Finish_OnDataChange)((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this));
        }

        public void Begin_OnViewChange([NativeTypeName("DWORD")] uint dwAspect, [NativeTypeName("LONG")] int lindex)
        {
            Marshal.GetDelegateForFunctionPointer<_Begin_OnViewChange>(lpVtbl->Begin_OnViewChange)((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this), dwAspect, lindex);
        }

        public void Finish_OnViewChange()
        {
            Marshal.GetDelegateForFunctionPointer<_Finish_OnViewChange>(lpVtbl->Finish_OnViewChange)((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this));
        }

        public void Begin_OnRename([NativeTypeName("IMoniker *")] IMoniker* pmk)
        {
            Marshal.GetDelegateForFunctionPointer<_Begin_OnRename>(lpVtbl->Begin_OnRename)((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this), pmk);
        }

        public void Finish_OnRename()
        {
            Marshal.GetDelegateForFunctionPointer<_Finish_OnRename>(lpVtbl->Finish_OnRename)((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this));
        }

        public void Begin_OnSave()
        {
            Marshal.GetDelegateForFunctionPointer<_Begin_OnSave>(lpVtbl->Begin_OnSave)((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this));
        }

        public void Finish_OnSave()
        {
            Marshal.GetDelegateForFunctionPointer<_Finish_OnSave>(lpVtbl->Finish_OnSave)((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this));
        }

        public void Begin_OnClose()
        {
            Marshal.GetDelegateForFunctionPointer<_Begin_OnClose>(lpVtbl->Begin_OnClose)((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this));
        }

        public void Finish_OnClose()
        {
            Marshal.GetDelegateForFunctionPointer<_Finish_OnClose>(lpVtbl->Finish_OnClose)((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this));
        }

        public void Begin_OnLinkSrcChange([NativeTypeName("IMoniker *")] IMoniker* pmk)
        {
            Marshal.GetDelegateForFunctionPointer<_Begin_OnLinkSrcChange>(lpVtbl->Begin_OnLinkSrcChange)((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this), pmk);
        }

        public void Finish_OnLinkSrcChange()
        {
            Marshal.GetDelegateForFunctionPointer<_Finish_OnLinkSrcChange>(lpVtbl->Finish_OnLinkSrcChange)((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this));
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
            public IntPtr Begin_OnDataChange;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public IntPtr Finish_OnDataChange;

            [NativeTypeName("void (DWORD, LONG) __attribute__((stdcall))")]
            public IntPtr Begin_OnViewChange;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public IntPtr Finish_OnViewChange;

            [NativeTypeName("void (IMoniker *) __attribute__((stdcall))")]
            public IntPtr Begin_OnRename;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public IntPtr Finish_OnRename;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public IntPtr Begin_OnSave;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public IntPtr Finish_OnSave;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public IntPtr Begin_OnClose;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public IntPtr Finish_OnClose;

            [NativeTypeName("void (IMoniker *) __attribute__((stdcall))")]
            public IntPtr Begin_OnLinkSrcChange;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public IntPtr Finish_OnLinkSrcChange;
        }
    }
}
