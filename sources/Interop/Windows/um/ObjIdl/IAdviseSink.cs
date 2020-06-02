// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000010F-0000-0000-C000-000000000046")]
    public unsafe partial struct IAdviseSink
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IAdviseSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IAdviseSink*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IAdviseSink*)Unsafe.AsPointer(ref this));
        }

        public void OnDataChange([NativeTypeName("FORMATETC *")] FORMATETC* pFormatetc, [NativeTypeName("STGMEDIUM *")] STGMEDIUM* pStgmed)
        {
            lpVtbl->OnDataChange((IAdviseSink*)Unsafe.AsPointer(ref this), pFormatetc, pStgmed);
        }

        public void OnViewChange([NativeTypeName("DWORD")] uint dwAspect, [NativeTypeName("LONG")] int lindex)
        {
            lpVtbl->OnViewChange((IAdviseSink*)Unsafe.AsPointer(ref this), dwAspect, lindex);
        }

        public void OnRename([NativeTypeName("IMoniker *")] IMoniker* pmk)
        {
            lpVtbl->OnRename((IAdviseSink*)Unsafe.AsPointer(ref this), pmk);
        }

        public void OnSave()
        {
            lpVtbl->OnSave((IAdviseSink*)Unsafe.AsPointer(ref this));
        }

        public void OnClose()
        {
            lpVtbl->OnClose((IAdviseSink*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IAdviseSink*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IAdviseSink*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IAdviseSink*, uint> Release;

            [NativeTypeName("void (FORMATETC *, STGMEDIUM *) __attribute__((stdcall))")]
            public delegate* stdcall<IAdviseSink*, FORMATETC*, STGMEDIUM*, void> OnDataChange;

            [NativeTypeName("void (DWORD, LONG) __attribute__((stdcall))")]
            public delegate* stdcall<IAdviseSink*, uint, int, void> OnViewChange;

            [NativeTypeName("void (IMoniker *) __attribute__((stdcall))")]
            public delegate* stdcall<IAdviseSink*, IMoniker*, void> OnRename;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* stdcall<IAdviseSink*, void> OnSave;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* stdcall<IAdviseSink*, void> OnClose;
        }
    }
}
