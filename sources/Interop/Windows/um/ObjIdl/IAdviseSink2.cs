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

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IAdviseSink2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IAdviseSink2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IAdviseSink2*)Unsafe.AsPointer(ref this));
        }

        public void OnDataChange([NativeTypeName("FORMATETC *")] FORMATETC* pFormatetc, [NativeTypeName("STGMEDIUM *")] STGMEDIUM* pStgmed)
        {
            lpVtbl->OnDataChange((IAdviseSink2*)Unsafe.AsPointer(ref this), pFormatetc, pStgmed);
        }

        public void OnViewChange([NativeTypeName("DWORD")] uint dwAspect, [NativeTypeName("LONG")] int lindex)
        {
            lpVtbl->OnViewChange((IAdviseSink2*)Unsafe.AsPointer(ref this), dwAspect, lindex);
        }

        public void OnRename([NativeTypeName("IMoniker *")] IMoniker* pmk)
        {
            lpVtbl->OnRename((IAdviseSink2*)Unsafe.AsPointer(ref this), pmk);
        }

        public void OnSave()
        {
            lpVtbl->OnSave((IAdviseSink2*)Unsafe.AsPointer(ref this));
        }

        public void OnClose()
        {
            lpVtbl->OnClose((IAdviseSink2*)Unsafe.AsPointer(ref this));
        }

        public void OnLinkSrcChange([NativeTypeName("IMoniker *")] IMoniker* pmk)
        {
            lpVtbl->OnLinkSrcChange((IAdviseSink2*)Unsafe.AsPointer(ref this), pmk);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IAdviseSink2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IAdviseSink2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IAdviseSink2*, uint> Release;

            [NativeTypeName("void (FORMATETC *, STGMEDIUM *) __attribute__((stdcall))")]
            public delegate* stdcall<IAdviseSink2*, FORMATETC*, STGMEDIUM*, void> OnDataChange;

            [NativeTypeName("void (DWORD, LONG) __attribute__((stdcall))")]
            public delegate* stdcall<IAdviseSink2*, uint, int, void> OnViewChange;

            [NativeTypeName("void (IMoniker *) __attribute__((stdcall))")]
            public delegate* stdcall<IAdviseSink2*, IMoniker*, void> OnRename;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* stdcall<IAdviseSink2*, void> OnSave;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* stdcall<IAdviseSink2*, void> OnClose;

            [NativeTypeName("void (IMoniker *) __attribute__((stdcall))")]
            public delegate* stdcall<IAdviseSink2*, IMoniker*, void> OnLinkSrcChange;
        }
    }
}
