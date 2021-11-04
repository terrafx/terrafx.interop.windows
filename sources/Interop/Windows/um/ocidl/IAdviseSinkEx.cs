// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3AF24290-0C96-11CE-A0CF-00AA00600AB8")]
    [NativeTypeName("struct IAdviseSinkEx : IAdviseSink")]
    [NativeInheritance("IAdviseSink")]
    public unsafe partial struct IAdviseSinkEx
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAdviseSinkEx*, Guid*, void**, int>)(lpVtbl[0]))((IAdviseSinkEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAdviseSinkEx*, uint>)(lpVtbl[1]))((IAdviseSinkEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAdviseSinkEx*, uint>)(lpVtbl[2]))((IAdviseSinkEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void OnDataChange(FORMATETC* pFormatetc, STGMEDIUM* pStgmed)
        {
            ((delegate* unmanaged<IAdviseSinkEx*, FORMATETC*, STGMEDIUM*, void>)(lpVtbl[3]))((IAdviseSinkEx*)Unsafe.AsPointer(ref this), pFormatetc, pStgmed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public void OnViewChange([NativeTypeName("DWORD")] uint dwAspect, [NativeTypeName("LONG")] int lindex)
        {
            ((delegate* unmanaged<IAdviseSinkEx*, uint, int, void>)(lpVtbl[4]))((IAdviseSinkEx*)Unsafe.AsPointer(ref this), dwAspect, lindex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public void OnRename(IMoniker* pmk)
        {
            ((delegate* unmanaged<IAdviseSinkEx*, IMoniker*, void>)(lpVtbl[5]))((IAdviseSinkEx*)Unsafe.AsPointer(ref this), pmk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public void OnSave()
        {
            ((delegate* unmanaged<IAdviseSinkEx*, void>)(lpVtbl[6]))((IAdviseSinkEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public void OnClose()
        {
            ((delegate* unmanaged<IAdviseSinkEx*, void>)(lpVtbl[7]))((IAdviseSinkEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public void OnViewStatusChange([NativeTypeName("DWORD")] uint dwViewStatus)
        {
            ((delegate* unmanaged<IAdviseSinkEx*, uint, void>)(lpVtbl[8]))((IAdviseSinkEx*)Unsafe.AsPointer(ref this), dwViewStatus);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAdviseSinkEx*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAdviseSinkEx*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAdviseSinkEx*, uint> Release;

            [NativeTypeName("void (FORMATETC *, STGMEDIUM *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAdviseSinkEx*, FORMATETC*, STGMEDIUM*, void> OnDataChange;

            [NativeTypeName("void (DWORD, LONG) __attribute__((stdcall))")]
            public delegate* unmanaged<IAdviseSinkEx*, uint, int, void> OnViewChange;

            [NativeTypeName("void (IMoniker *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAdviseSinkEx*, IMoniker*, void> OnRename;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* unmanaged<IAdviseSinkEx*, void> OnSave;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* unmanaged<IAdviseSinkEx*, void> OnClose;

            [NativeTypeName("void (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IAdviseSinkEx*, uint, void> OnViewStatusChange;
        }
    }
}
