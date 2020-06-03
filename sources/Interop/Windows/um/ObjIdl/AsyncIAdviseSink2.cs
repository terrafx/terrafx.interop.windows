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
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<AsyncIAdviseSink2*, Guid*, void**, int>)(lpVtbl[0]))((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<AsyncIAdviseSink2*, uint>)(lpVtbl[1]))((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<AsyncIAdviseSink2*, uint>)(lpVtbl[2]))((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this));
        }

        public void Begin_OnDataChange([NativeTypeName("FORMATETC *")] FORMATETC* pFormatetc, [NativeTypeName("STGMEDIUM *")] STGMEDIUM* pStgmed)
        {
            ((delegate* stdcall<AsyncIAdviseSink2*, FORMATETC*, STGMEDIUM*, void>)(lpVtbl[3]))((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this), pFormatetc, pStgmed);
        }

        public void Finish_OnDataChange()
        {
            ((delegate* stdcall<AsyncIAdviseSink2*, void>)(lpVtbl[4]))((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this));
        }

        public void Begin_OnViewChange([NativeTypeName("DWORD")] uint dwAspect, [NativeTypeName("LONG")] int lindex)
        {
            ((delegate* stdcall<AsyncIAdviseSink2*, uint, int, void>)(lpVtbl[5]))((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this), dwAspect, lindex);
        }

        public void Finish_OnViewChange()
        {
            ((delegate* stdcall<AsyncIAdviseSink2*, void>)(lpVtbl[6]))((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this));
        }

        public void Begin_OnRename([NativeTypeName("IMoniker *")] IMoniker* pmk)
        {
            ((delegate* stdcall<AsyncIAdviseSink2*, IMoniker*, void>)(lpVtbl[7]))((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this), pmk);
        }

        public void Finish_OnRename()
        {
            ((delegate* stdcall<AsyncIAdviseSink2*, void>)(lpVtbl[8]))((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this));
        }

        public void Begin_OnSave()
        {
            ((delegate* stdcall<AsyncIAdviseSink2*, void>)(lpVtbl[9]))((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this));
        }

        public void Finish_OnSave()
        {
            ((delegate* stdcall<AsyncIAdviseSink2*, void>)(lpVtbl[10]))((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this));
        }

        public void Begin_OnClose()
        {
            ((delegate* stdcall<AsyncIAdviseSink2*, void>)(lpVtbl[11]))((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this));
        }

        public void Finish_OnClose()
        {
            ((delegate* stdcall<AsyncIAdviseSink2*, void>)(lpVtbl[12]))((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this));
        }

        public void Begin_OnLinkSrcChange([NativeTypeName("IMoniker *")] IMoniker* pmk)
        {
            ((delegate* stdcall<AsyncIAdviseSink2*, IMoniker*, void>)(lpVtbl[13]))((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this), pmk);
        }

        public void Finish_OnLinkSrcChange()
        {
            ((delegate* stdcall<AsyncIAdviseSink2*, void>)(lpVtbl[14]))((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this));
        }
    }
}
