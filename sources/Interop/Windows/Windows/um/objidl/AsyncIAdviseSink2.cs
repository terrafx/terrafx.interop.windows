// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("00000151-0000-0000-C000-000000000046")]
[NativeTypeName("struct AsyncIAdviseSink2 : AsyncIAdviseSink")]
[NativeInheritance("AsyncIAdviseSink")]
public unsafe partial struct AsyncIAdviseSink2 : AsyncIAdviseSink2.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<AsyncIAdviseSink2*, Guid*, void**, int>)(lpVtbl[0]))((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<AsyncIAdviseSink2*, uint>)(lpVtbl[1]))((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<AsyncIAdviseSink2*, uint>)(lpVtbl[2]))((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void Begin_OnDataChange(FORMATETC* pFormatetc, STGMEDIUM* pStgmed)
    {
        ((delegate* unmanaged<AsyncIAdviseSink2*, FORMATETC*, STGMEDIUM*, void>)(lpVtbl[3]))((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this), pFormatetc, pStgmed);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void Finish_OnDataChange()
    {
        ((delegate* unmanaged<AsyncIAdviseSink2*, void>)(lpVtbl[4]))((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void Begin_OnViewChange([NativeTypeName("DWORD")] uint dwAspect, [NativeTypeName("LONG")] int lindex)
    {
        ((delegate* unmanaged<AsyncIAdviseSink2*, uint, int, void>)(lpVtbl[5]))((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this), dwAspect, lindex);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public void Finish_OnViewChange()
    {
        ((delegate* unmanaged<AsyncIAdviseSink2*, void>)(lpVtbl[6]))((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void Begin_OnRename(IMoniker* pmk)
    {
        ((delegate* unmanaged<AsyncIAdviseSink2*, IMoniker*, void>)(lpVtbl[7]))((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this), pmk);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void Finish_OnRename()
    {
        ((delegate* unmanaged<AsyncIAdviseSink2*, void>)(lpVtbl[8]))((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public void Begin_OnSave()
    {
        ((delegate* unmanaged<AsyncIAdviseSink2*, void>)(lpVtbl[9]))((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public void Finish_OnSave()
    {
        ((delegate* unmanaged<AsyncIAdviseSink2*, void>)(lpVtbl[10]))((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public void Begin_OnClose()
    {
        ((delegate* unmanaged<AsyncIAdviseSink2*, void>)(lpVtbl[11]))((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public void Finish_OnClose()
    {
        ((delegate* unmanaged<AsyncIAdviseSink2*, void>)(lpVtbl[12]))((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public void Begin_OnLinkSrcChange(IMoniker* pmk)
    {
        ((delegate* unmanaged<AsyncIAdviseSink2*, IMoniker*, void>)(lpVtbl[13]))((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this), pmk);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public void Finish_OnLinkSrcChange()
    {
        ((delegate* unmanaged<AsyncIAdviseSink2*, void>)(lpVtbl[14]))((AsyncIAdviseSink2*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : AsyncIAdviseSink.Interface
    {
        [VtblIndex(13)]
        void Begin_OnLinkSrcChange(IMoniker* pmk);

        [VtblIndex(14)]
        void Finish_OnLinkSrcChange();
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<AsyncIAdviseSink2*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<AsyncIAdviseSink2*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<AsyncIAdviseSink2*, uint> Release;

        [NativeTypeName("void (FORMATETC *, STGMEDIUM *) __attribute__((stdcall))")]
        public delegate* unmanaged<AsyncIAdviseSink2*, FORMATETC*, STGMEDIUM*, void> Begin_OnDataChange;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<AsyncIAdviseSink2*, void> Finish_OnDataChange;

        [NativeTypeName("void (DWORD, LONG) __attribute__((stdcall))")]
        public delegate* unmanaged<AsyncIAdviseSink2*, uint, int, void> Begin_OnViewChange;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<AsyncIAdviseSink2*, void> Finish_OnViewChange;

        [NativeTypeName("void (IMoniker *) __attribute__((stdcall))")]
        public delegate* unmanaged<AsyncIAdviseSink2*, IMoniker*, void> Begin_OnRename;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<AsyncIAdviseSink2*, void> Finish_OnRename;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<AsyncIAdviseSink2*, void> Begin_OnSave;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<AsyncIAdviseSink2*, void> Finish_OnSave;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<AsyncIAdviseSink2*, void> Begin_OnClose;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<AsyncIAdviseSink2*, void> Finish_OnClose;

        [NativeTypeName("void (IMoniker *) __attribute__((stdcall))")]
        public delegate* unmanaged<AsyncIAdviseSink2*, IMoniker*, void> Begin_OnLinkSrcChange;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<AsyncIAdviseSink2*, void> Finish_OnLinkSrcChange;
    }
}
