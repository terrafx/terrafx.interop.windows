// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3AF24290-0C96-11CE-A0CF-00AA00600AB8")]
    [NativeTypeName("struct IAdviseSinkEx : IAdviseSink")]
    public unsafe partial struct IAdviseSinkEx
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IAdviseSinkEx*, Guid*, void**, int>)(lpVtbl[0]))((IAdviseSinkEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IAdviseSinkEx*, uint>)(lpVtbl[1]))((IAdviseSinkEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IAdviseSinkEx*, uint>)(lpVtbl[2]))((IAdviseSinkEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void OnDataChange([NativeTypeName("FORMATETC *")] FORMATETC* pFormatetc, [NativeTypeName("STGMEDIUM *")] STGMEDIUM* pStgmed)
        {
            ((delegate* stdcall<IAdviseSinkEx*, FORMATETC*, STGMEDIUM*, void>)(lpVtbl[3]))((IAdviseSinkEx*)Unsafe.AsPointer(ref this), pFormatetc, pStgmed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void OnViewChange([NativeTypeName("DWORD")] uint dwAspect, [NativeTypeName("LONG")] int lindex)
        {
            ((delegate* stdcall<IAdviseSinkEx*, uint, int, void>)(lpVtbl[4]))((IAdviseSinkEx*)Unsafe.AsPointer(ref this), dwAspect, lindex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void OnRename([NativeTypeName("IMoniker *")] IMoniker* pmk)
        {
            ((delegate* stdcall<IAdviseSinkEx*, IMoniker*, void>)(lpVtbl[5]))((IAdviseSinkEx*)Unsafe.AsPointer(ref this), pmk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void OnSave()
        {
            ((delegate* stdcall<IAdviseSinkEx*, void>)(lpVtbl[6]))((IAdviseSinkEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void OnClose()
        {
            ((delegate* stdcall<IAdviseSinkEx*, void>)(lpVtbl[7]))((IAdviseSinkEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void OnViewStatusChange([NativeTypeName("DWORD")] uint dwViewStatus)
        {
            ((delegate* stdcall<IAdviseSinkEx*, uint, void>)(lpVtbl[8]))((IAdviseSinkEx*)Unsafe.AsPointer(ref this), dwViewStatus);
        }
    }
}
