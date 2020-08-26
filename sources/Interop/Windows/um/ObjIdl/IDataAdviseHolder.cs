// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000110-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IDataAdviseHolder : IUnknown")]
    public unsafe partial struct IDataAdviseHolder
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDataAdviseHolder*, Guid*, void**, int>)(lpVtbl[0]))((IDataAdviseHolder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDataAdviseHolder*, uint>)(lpVtbl[1]))((IDataAdviseHolder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDataAdviseHolder*, uint>)(lpVtbl[2]))((IDataAdviseHolder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Advise([NativeTypeName("IDataObject *")] IDataObject* pDataObject, [NativeTypeName("FORMATETC *")] FORMATETC* pFetc, [NativeTypeName("DWORD")] uint advf, [NativeTypeName("IAdviseSink *")] IAdviseSink* pAdvise, [NativeTypeName("DWORD *")] uint* pdwConnection)
        {
            return ((delegate* stdcall<IDataAdviseHolder*, IDataObject*, FORMATETC*, uint, IAdviseSink*, uint*, int>)(lpVtbl[3]))((IDataAdviseHolder*)Unsafe.AsPointer(ref this), pDataObject, pFetc, advf, pAdvise, pdwConnection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Unadvise([NativeTypeName("DWORD")] uint dwConnection)
        {
            return ((delegate* stdcall<IDataAdviseHolder*, uint, int>)(lpVtbl[4]))((IDataAdviseHolder*)Unsafe.AsPointer(ref this), dwConnection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumAdvise([NativeTypeName("IEnumSTATDATA **")] IEnumSTATDATA** ppenumAdvise)
        {
            return ((delegate* stdcall<IDataAdviseHolder*, IEnumSTATDATA**, int>)(lpVtbl[5]))((IDataAdviseHolder*)Unsafe.AsPointer(ref this), ppenumAdvise);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SendOnDataChange([NativeTypeName("IDataObject *")] IDataObject* pDataObject, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("DWORD")] uint advf)
        {
            return ((delegate* stdcall<IDataAdviseHolder*, IDataObject*, uint, uint, int>)(lpVtbl[6]))((IDataAdviseHolder*)Unsafe.AsPointer(ref this), pDataObject, dwReserved, advf);
        }
    }
}
