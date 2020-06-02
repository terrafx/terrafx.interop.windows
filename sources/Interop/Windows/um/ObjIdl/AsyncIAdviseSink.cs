// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000150-0000-0000-C000-000000000046")]
    public unsafe partial struct AsyncIAdviseSink
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((AsyncIAdviseSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((AsyncIAdviseSink*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((AsyncIAdviseSink*)Unsafe.AsPointer(ref this));
        }

        public void Begin_OnDataChange([NativeTypeName("FORMATETC *")] FORMATETC* pFormatetc, [NativeTypeName("STGMEDIUM *")] STGMEDIUM* pStgmed)
        {
            lpVtbl->Begin_OnDataChange((AsyncIAdviseSink*)Unsafe.AsPointer(ref this), pFormatetc, pStgmed);
        }

        public void Finish_OnDataChange()
        {
            lpVtbl->Finish_OnDataChange((AsyncIAdviseSink*)Unsafe.AsPointer(ref this));
        }

        public void Begin_OnViewChange([NativeTypeName("DWORD")] uint dwAspect, [NativeTypeName("LONG")] int lindex)
        {
            lpVtbl->Begin_OnViewChange((AsyncIAdviseSink*)Unsafe.AsPointer(ref this), dwAspect, lindex);
        }

        public void Finish_OnViewChange()
        {
            lpVtbl->Finish_OnViewChange((AsyncIAdviseSink*)Unsafe.AsPointer(ref this));
        }

        public void Begin_OnRename([NativeTypeName("IMoniker *")] IMoniker* pmk)
        {
            lpVtbl->Begin_OnRename((AsyncIAdviseSink*)Unsafe.AsPointer(ref this), pmk);
        }

        public void Finish_OnRename()
        {
            lpVtbl->Finish_OnRename((AsyncIAdviseSink*)Unsafe.AsPointer(ref this));
        }

        public void Begin_OnSave()
        {
            lpVtbl->Begin_OnSave((AsyncIAdviseSink*)Unsafe.AsPointer(ref this));
        }

        public void Finish_OnSave()
        {
            lpVtbl->Finish_OnSave((AsyncIAdviseSink*)Unsafe.AsPointer(ref this));
        }

        public void Begin_OnClose()
        {
            lpVtbl->Begin_OnClose((AsyncIAdviseSink*)Unsafe.AsPointer(ref this));
        }

        public void Finish_OnClose()
        {
            lpVtbl->Finish_OnClose((AsyncIAdviseSink*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<AsyncIAdviseSink*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<AsyncIAdviseSink*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<AsyncIAdviseSink*, uint> Release;

            [NativeTypeName("void (FORMATETC *, STGMEDIUM *) __attribute__((stdcall))")]
            public delegate* stdcall<AsyncIAdviseSink*, FORMATETC*, STGMEDIUM*, void> Begin_OnDataChange;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* stdcall<AsyncIAdviseSink*, void> Finish_OnDataChange;

            [NativeTypeName("void (DWORD, LONG) __attribute__((stdcall))")]
            public delegate* stdcall<AsyncIAdviseSink*, uint, int, void> Begin_OnViewChange;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* stdcall<AsyncIAdviseSink*, void> Finish_OnViewChange;

            [NativeTypeName("void (IMoniker *) __attribute__((stdcall))")]
            public delegate* stdcall<AsyncIAdviseSink*, IMoniker*, void> Begin_OnRename;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* stdcall<AsyncIAdviseSink*, void> Finish_OnRename;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* stdcall<AsyncIAdviseSink*, void> Begin_OnSave;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* stdcall<AsyncIAdviseSink*, void> Finish_OnSave;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* stdcall<AsyncIAdviseSink*, void> Begin_OnClose;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* stdcall<AsyncIAdviseSink*, void> Finish_OnClose;
        }
    }
}
