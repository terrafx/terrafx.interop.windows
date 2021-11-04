// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000111-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IOleAdviseHolder : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IOleAdviseHolder
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IOleAdviseHolder*, Guid*, void**, int>)(lpVtbl[0]))((IOleAdviseHolder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IOleAdviseHolder*, uint>)(lpVtbl[1]))((IOleAdviseHolder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IOleAdviseHolder*, uint>)(lpVtbl[2]))((IOleAdviseHolder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Advise(IAdviseSink* pAdvise, [NativeTypeName("DWORD *")] uint* pdwConnection)
        {
            return ((delegate* unmanaged<IOleAdviseHolder*, IAdviseSink*, uint*, int>)(lpVtbl[3]))((IOleAdviseHolder*)Unsafe.AsPointer(ref this), pAdvise, pdwConnection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Unadvise([NativeTypeName("DWORD")] uint dwConnection)
        {
            return ((delegate* unmanaged<IOleAdviseHolder*, uint, int>)(lpVtbl[4]))((IOleAdviseHolder*)Unsafe.AsPointer(ref this), dwConnection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT EnumAdvise(IEnumSTATDATA** ppenumAdvise)
        {
            return ((delegate* unmanaged<IOleAdviseHolder*, IEnumSTATDATA**, int>)(lpVtbl[5]))((IOleAdviseHolder*)Unsafe.AsPointer(ref this), ppenumAdvise);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SendOnRename(IMoniker* pmk)
        {
            return ((delegate* unmanaged<IOleAdviseHolder*, IMoniker*, int>)(lpVtbl[6]))((IOleAdviseHolder*)Unsafe.AsPointer(ref this), pmk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SendOnSave()
        {
            return ((delegate* unmanaged<IOleAdviseHolder*, int>)(lpVtbl[7]))((IOleAdviseHolder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT SendOnClose()
        {
            return ((delegate* unmanaged<IOleAdviseHolder*, int>)(lpVtbl[8]))((IOleAdviseHolder*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleAdviseHolder*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IOleAdviseHolder*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IOleAdviseHolder*, uint> Release;

            [NativeTypeName("HRESULT (IAdviseSink *, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleAdviseHolder*, IAdviseSink*, uint*, int> Advise;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleAdviseHolder*, uint, int> Unadvise;

            [NativeTypeName("HRESULT (IEnumSTATDATA **) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleAdviseHolder*, IEnumSTATDATA**, int> EnumAdvise;

            [NativeTypeName("HRESULT (IMoniker *) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleAdviseHolder*, IMoniker*, int> SendOnRename;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IOleAdviseHolder*, int> SendOnSave;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IOleAdviseHolder*, int> SendOnClose;
        }
    }
}
