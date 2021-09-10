// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000150-0000-0000-C000-000000000046")]
    [NativeTypeName("struct AsyncIAdviseSink : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct AsyncIAdviseSink
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<AsyncIAdviseSink*, Guid*, void**, int>)(lpVtbl[0]))((AsyncIAdviseSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<AsyncIAdviseSink*, uint>)(lpVtbl[1]))((AsyncIAdviseSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<AsyncIAdviseSink*, uint>)(lpVtbl[2]))((AsyncIAdviseSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void Begin_OnDataChange(FORMATETC* pFormatetc, STGMEDIUM* pStgmed)
        {
            ((delegate* unmanaged<AsyncIAdviseSink*, FORMATETC*, STGMEDIUM*, void>)(lpVtbl[3]))((AsyncIAdviseSink*)Unsafe.AsPointer(ref this), pFormatetc, pStgmed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public void Finish_OnDataChange()
        {
            ((delegate* unmanaged<AsyncIAdviseSink*, void>)(lpVtbl[4]))((AsyncIAdviseSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public void Begin_OnViewChange([NativeTypeName("DWORD")] uint dwAspect, [NativeTypeName("LONG")] int lindex)
        {
            ((delegate* unmanaged<AsyncIAdviseSink*, uint, int, void>)(lpVtbl[5]))((AsyncIAdviseSink*)Unsafe.AsPointer(ref this), dwAspect, lindex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public void Finish_OnViewChange()
        {
            ((delegate* unmanaged<AsyncIAdviseSink*, void>)(lpVtbl[6]))((AsyncIAdviseSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public void Begin_OnRename(IMoniker* pmk)
        {
            ((delegate* unmanaged<AsyncIAdviseSink*, IMoniker*, void>)(lpVtbl[7]))((AsyncIAdviseSink*)Unsafe.AsPointer(ref this), pmk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public void Finish_OnRename()
        {
            ((delegate* unmanaged<AsyncIAdviseSink*, void>)(lpVtbl[8]))((AsyncIAdviseSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public void Begin_OnSave()
        {
            ((delegate* unmanaged<AsyncIAdviseSink*, void>)(lpVtbl[9]))((AsyncIAdviseSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public void Finish_OnSave()
        {
            ((delegate* unmanaged<AsyncIAdviseSink*, void>)(lpVtbl[10]))((AsyncIAdviseSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public void Begin_OnClose()
        {
            ((delegate* unmanaged<AsyncIAdviseSink*, void>)(lpVtbl[11]))((AsyncIAdviseSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public void Finish_OnClose()
        {
            ((delegate* unmanaged<AsyncIAdviseSink*, void>)(lpVtbl[12]))((AsyncIAdviseSink*)Unsafe.AsPointer(ref this));
        }
    }
}
