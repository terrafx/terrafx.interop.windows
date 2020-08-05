// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000111-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IOleAdviseHolder : IUnknown")]
    public unsafe partial struct IOleAdviseHolder
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IOleAdviseHolder*, Guid*, void**, int>)(lpVtbl[0]))((IOleAdviseHolder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IOleAdviseHolder*, uint>)(lpVtbl[1]))((IOleAdviseHolder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IOleAdviseHolder*, uint>)(lpVtbl[2]))((IOleAdviseHolder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Advise([NativeTypeName("IAdviseSink *")] IAdviseSink* pAdvise, [NativeTypeName("DWORD *")] uint* pdwConnection)
        {
            return ((delegate* stdcall<IOleAdviseHolder*, IAdviseSink*, uint*, int>)(lpVtbl[3]))((IOleAdviseHolder*)Unsafe.AsPointer(ref this), pAdvise, pdwConnection);
        }

        [return: NativeTypeName("HRESULT")]
        public int Unadvise([NativeTypeName("DWORD")] uint dwConnection)
        {
            return ((delegate* stdcall<IOleAdviseHolder*, uint, int>)(lpVtbl[4]))((IOleAdviseHolder*)Unsafe.AsPointer(ref this), dwConnection);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumAdvise([NativeTypeName("IEnumSTATDATA **")] IEnumSTATDATA** ppenumAdvise)
        {
            return ((delegate* stdcall<IOleAdviseHolder*, IEnumSTATDATA**, int>)(lpVtbl[5]))((IOleAdviseHolder*)Unsafe.AsPointer(ref this), ppenumAdvise);
        }

        [return: NativeTypeName("HRESULT")]
        public int SendOnRename([NativeTypeName("IMoniker *")] IMoniker* pmk)
        {
            return ((delegate* stdcall<IOleAdviseHolder*, IMoniker*, int>)(lpVtbl[6]))((IOleAdviseHolder*)Unsafe.AsPointer(ref this), pmk);
        }

        [return: NativeTypeName("HRESULT")]
        public int SendOnSave()
        {
            return ((delegate* stdcall<IOleAdviseHolder*, int>)(lpVtbl[7]))((IOleAdviseHolder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SendOnClose()
        {
            return ((delegate* stdcall<IOleAdviseHolder*, int>)(lpVtbl[8]))((IOleAdviseHolder*)Unsafe.AsPointer(ref this));
        }
    }
}
