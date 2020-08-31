// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000003-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IMarshal : IUnknown")]
    public unsafe partial struct IMarshal
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMarshal*, Guid*, void**, int>)(lpVtbl[0]))((IMarshal*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMarshal*, uint>)(lpVtbl[1]))((IMarshal*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMarshal*, uint>)(lpVtbl[2]))((IMarshal*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetUnmarshalClass([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void *")] void* pv, [NativeTypeName("DWORD")] uint dwDestContext, [NativeTypeName("void *")] void* pvDestContext, [NativeTypeName("DWORD")] uint mshlflags, [NativeTypeName("CLSID *")] Guid* pCid)
        {
            return ((delegate* stdcall<IMarshal*, Guid*, void*, uint, void*, uint, Guid*, int>)(lpVtbl[3]))((IMarshal*)Unsafe.AsPointer(ref this), riid, pv, dwDestContext, pvDestContext, mshlflags, pCid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMarshalSizeMax([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void *")] void* pv, [NativeTypeName("DWORD")] uint dwDestContext, [NativeTypeName("void *")] void* pvDestContext, [NativeTypeName("DWORD")] uint mshlflags, [NativeTypeName("DWORD *")] uint* pSize)
        {
            return ((delegate* stdcall<IMarshal*, Guid*, void*, uint, void*, uint, uint*, int>)(lpVtbl[4]))((IMarshal*)Unsafe.AsPointer(ref this), riid, pv, dwDestContext, pvDestContext, mshlflags, pSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MarshalInterface([NativeTypeName("IStream *")] IStream* pStm, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void *")] void* pv, [NativeTypeName("DWORD")] uint dwDestContext, [NativeTypeName("void *")] void* pvDestContext, [NativeTypeName("DWORD")] uint mshlflags)
        {
            return ((delegate* stdcall<IMarshal*, IStream*, Guid*, void*, uint, void*, uint, int>)(lpVtbl[5]))((IMarshal*)Unsafe.AsPointer(ref this), pStm, riid, pv, dwDestContext, pvDestContext, mshlflags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnmarshalInterface([NativeTypeName("IStream *")] IStream* pStm, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return ((delegate* stdcall<IMarshal*, IStream*, Guid*, void**, int>)(lpVtbl[6]))((IMarshal*)Unsafe.AsPointer(ref this), pStm, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReleaseMarshalData([NativeTypeName("IStream *")] IStream* pStm)
        {
            return ((delegate* stdcall<IMarshal*, IStream*, int>)(lpVtbl[7]))((IMarshal*)Unsafe.AsPointer(ref this), pStm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DisconnectObject([NativeTypeName("DWORD")] uint dwReserved)
        {
            return ((delegate* stdcall<IMarshal*, uint, int>)(lpVtbl[8]))((IMarshal*)Unsafe.AsPointer(ref this), dwReserved);
        }
    }
}
