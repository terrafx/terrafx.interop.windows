// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3AF24290-0C96-11CE-A0CF-00AA00600AB8")]
    public unsafe partial struct IAdviseSinkEx
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IAdviseSinkEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IAdviseSinkEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IAdviseSinkEx*)Unsafe.AsPointer(ref this));
        }

        public void OnDataChange([NativeTypeName("FORMATETC *")] FORMATETC* pFormatetc, [NativeTypeName("STGMEDIUM *")] STGMEDIUM* pStgmed)
        {
            lpVtbl->OnDataChange((IAdviseSinkEx*)Unsafe.AsPointer(ref this), pFormatetc, pStgmed);
        }

        public void OnViewChange([NativeTypeName("DWORD")] uint dwAspect, [NativeTypeName("LONG")] int lindex)
        {
            lpVtbl->OnViewChange((IAdviseSinkEx*)Unsafe.AsPointer(ref this), dwAspect, lindex);
        }

        public void OnRename([NativeTypeName("IMoniker *")] IMoniker* pmk)
        {
            lpVtbl->OnRename((IAdviseSinkEx*)Unsafe.AsPointer(ref this), pmk);
        }

        public void OnSave()
        {
            lpVtbl->OnSave((IAdviseSinkEx*)Unsafe.AsPointer(ref this));
        }

        public void OnClose()
        {
            lpVtbl->OnClose((IAdviseSinkEx*)Unsafe.AsPointer(ref this));
        }

        public void OnViewStatusChange([NativeTypeName("DWORD")] uint dwViewStatus)
        {
            lpVtbl->OnViewStatusChange((IAdviseSinkEx*)Unsafe.AsPointer(ref this), dwViewStatus);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IAdviseSinkEx*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IAdviseSinkEx*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IAdviseSinkEx*, uint> Release;

            [NativeTypeName("void (FORMATETC *, STGMEDIUM *) __attribute__((stdcall))")]
            public delegate* stdcall<IAdviseSinkEx*, FORMATETC*, STGMEDIUM*, void> OnDataChange;

            [NativeTypeName("void (DWORD, LONG) __attribute__((stdcall))")]
            public delegate* stdcall<IAdviseSinkEx*, uint, int, void> OnViewChange;

            [NativeTypeName("void (IMoniker *) __attribute__((stdcall))")]
            public delegate* stdcall<IAdviseSinkEx*, IMoniker*, void> OnRename;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* stdcall<IAdviseSinkEx*, void> OnSave;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* stdcall<IAdviseSinkEx*, void> OnClose;

            [NativeTypeName("void (DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IAdviseSinkEx*, uint, void> OnViewStatusChange;
        }
    }
}
