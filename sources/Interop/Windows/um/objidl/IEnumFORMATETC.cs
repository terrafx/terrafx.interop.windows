// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidl.h in the Windows SDK for Windows 10.0.20348.0
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
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IEnumFORMATETC*, Guid*, void**, int>)(lpVtbl[0]))((IEnumFORMATETC*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEnumFORMATETC*, uint>)(lpVtbl[1]))((IEnumFORMATETC*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEnumFORMATETC*, uint>)(lpVtbl[2]))((IEnumFORMATETC*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint celt, FORMATETC* rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
        {
            return ((delegate* unmanaged<IEnumFORMATETC*, uint, FORMATETC*, uint*, int>)(lpVtbl[3]))((IEnumFORMATETC*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint celt)
        {
            return ((delegate* unmanaged<IEnumFORMATETC*, uint, int>)(lpVtbl[4]))((IEnumFORMATETC*)Unsafe.AsPointer(ref this), celt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged<IEnumFORMATETC*, int>)(lpVtbl[5]))((IEnumFORMATETC*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Clone(IEnumFORMATETC** ppenum)
        {
            return ((delegate* unmanaged<IEnumFORMATETC*, IEnumFORMATETC**, int>)(lpVtbl[6]))((IEnumFORMATETC*)Unsafe.AsPointer(ref this), ppenum);
        }
    }
}
