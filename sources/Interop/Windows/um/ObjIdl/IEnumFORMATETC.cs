// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000103-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IEnumFORMATETC : IUnknown")]
    public unsafe partial struct IEnumFORMATETC
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IEnumFORMATETC*, Guid*, void**, int>)(lpVtbl[0]))((IEnumFORMATETC*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IEnumFORMATETC*, uint>)(lpVtbl[1]))((IEnumFORMATETC*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IEnumFORMATETC*, uint>)(lpVtbl[2]))((IEnumFORMATETC*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint celt, [NativeTypeName("FORMATETC *")] FORMATETC* rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
        {
            return ((delegate* stdcall<IEnumFORMATETC*, uint, FORMATETC*, uint*, int>)(lpVtbl[3]))((IEnumFORMATETC*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint celt)
        {
            return ((delegate* stdcall<IEnumFORMATETC*, uint, int>)(lpVtbl[4]))((IEnumFORMATETC*)Unsafe.AsPointer(ref this), celt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* stdcall<IEnumFORMATETC*, int>)(lpVtbl[5]))((IEnumFORMATETC*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("IEnumFORMATETC **")] IEnumFORMATETC** ppenum)
        {
            return ((delegate* stdcall<IEnumFORMATETC*, IEnumFORMATETC**, int>)(lpVtbl[6]))((IEnumFORMATETC*)Unsafe.AsPointer(ref this), ppenum);
        }
    }
}
