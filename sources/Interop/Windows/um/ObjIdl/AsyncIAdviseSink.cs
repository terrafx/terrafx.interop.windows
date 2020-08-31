// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000150-0000-0000-C000-000000000046")]
    [NativeTypeName("struct AsyncIAdviseSink : IUnknown")]
    public unsafe partial struct AsyncIAdviseSink
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<AsyncIAdviseSink*, Guid*, void**, int>)(lpVtbl[0]))((AsyncIAdviseSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<AsyncIAdviseSink*, uint>)(lpVtbl[1]))((AsyncIAdviseSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<AsyncIAdviseSink*, uint>)(lpVtbl[2]))((AsyncIAdviseSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Begin_OnDataChange([NativeTypeName("FORMATETC *")] FORMATETC* pFormatetc, [NativeTypeName("STGMEDIUM *")] STGMEDIUM* pStgmed)
        {
            ((delegate* stdcall<AsyncIAdviseSink*, FORMATETC*, STGMEDIUM*, void>)(lpVtbl[3]))((AsyncIAdviseSink*)Unsafe.AsPointer(ref this), pFormatetc, pStgmed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Finish_OnDataChange()
        {
            ((delegate* stdcall<AsyncIAdviseSink*, void>)(lpVtbl[4]))((AsyncIAdviseSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Begin_OnViewChange([NativeTypeName("DWORD")] uint dwAspect, [NativeTypeName("LONG")] int lindex)
        {
            ((delegate* stdcall<AsyncIAdviseSink*, uint, int, void>)(lpVtbl[5]))((AsyncIAdviseSink*)Unsafe.AsPointer(ref this), dwAspect, lindex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Finish_OnViewChange()
        {
            ((delegate* stdcall<AsyncIAdviseSink*, void>)(lpVtbl[6]))((AsyncIAdviseSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Begin_OnRename([NativeTypeName("IMoniker *")] IMoniker* pmk)
        {
            ((delegate* stdcall<AsyncIAdviseSink*, IMoniker*, void>)(lpVtbl[7]))((AsyncIAdviseSink*)Unsafe.AsPointer(ref this), pmk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Finish_OnRename()
        {
            ((delegate* stdcall<AsyncIAdviseSink*, void>)(lpVtbl[8]))((AsyncIAdviseSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Begin_OnSave()
        {
            ((delegate* stdcall<AsyncIAdviseSink*, void>)(lpVtbl[9]))((AsyncIAdviseSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Finish_OnSave()
        {
            ((delegate* stdcall<AsyncIAdviseSink*, void>)(lpVtbl[10]))((AsyncIAdviseSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Begin_OnClose()
        {
            ((delegate* stdcall<AsyncIAdviseSink*, void>)(lpVtbl[11]))((AsyncIAdviseSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Finish_OnClose()
        {
            ((delegate* stdcall<AsyncIAdviseSink*, void>)(lpVtbl[12]))((AsyncIAdviseSink*)Unsafe.AsPointer(ref this));
        }
    }
}
