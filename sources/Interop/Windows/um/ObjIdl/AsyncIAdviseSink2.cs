// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000151-0000-0000-C000-000000000046")]
    [NativeTypeName("struct AsyncIAdviseSink2 : AsyncIAdviseSink")]
    public unsafe partial struct AsyncIAdviseSink2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<AsyncIAdviseSink2*, Guid*, void**, int>)(lpVtbl[0]))((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<AsyncIAdviseSink2*, uint>)(lpVtbl[1]))((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<AsyncIAdviseSink2*, uint>)(lpVtbl[2]))((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Begin_OnDataChange(FORMATETC* pFormatetc, STGMEDIUM* pStgmed)
        {
            ((delegate* unmanaged<AsyncIAdviseSink2*, FORMATETC*, STGMEDIUM*, void>)(lpVtbl[3]))((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this), pFormatetc, pStgmed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Finish_OnDataChange()
        {
            ((delegate* unmanaged<AsyncIAdviseSink2*, void>)(lpVtbl[4]))((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Begin_OnViewChange([NativeTypeName("DWORD")] uint dwAspect, [NativeTypeName("LONG")] int lindex)
        {
            ((delegate* unmanaged<AsyncIAdviseSink2*, uint, int, void>)(lpVtbl[5]))((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this), dwAspect, lindex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Finish_OnViewChange()
        {
            ((delegate* unmanaged<AsyncIAdviseSink2*, void>)(lpVtbl[6]))((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Begin_OnRename(IMoniker* pmk)
        {
            ((delegate* unmanaged<AsyncIAdviseSink2*, IMoniker*, void>)(lpVtbl[7]))((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this), pmk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Finish_OnRename()
        {
            ((delegate* unmanaged<AsyncIAdviseSink2*, void>)(lpVtbl[8]))((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Begin_OnSave()
        {
            ((delegate* unmanaged<AsyncIAdviseSink2*, void>)(lpVtbl[9]))((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Finish_OnSave()
        {
            ((delegate* unmanaged<AsyncIAdviseSink2*, void>)(lpVtbl[10]))((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Begin_OnClose()
        {
            ((delegate* unmanaged<AsyncIAdviseSink2*, void>)(lpVtbl[11]))((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Finish_OnClose()
        {
            ((delegate* unmanaged<AsyncIAdviseSink2*, void>)(lpVtbl[12]))((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Begin_OnLinkSrcChange(IMoniker* pmk)
        {
            ((delegate* unmanaged<AsyncIAdviseSink2*, IMoniker*, void>)(lpVtbl[13]))((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this), pmk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Finish_OnLinkSrcChange()
        {
            ((delegate* unmanaged<AsyncIAdviseSink2*, void>)(lpVtbl[14]))((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this));
        }
    }
}
