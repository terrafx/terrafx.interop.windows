// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9D416F9C-E184-45B2-A4F0-CE517F719E9B")]
    [NativeTypeName("struct IDiaPropertyStorage : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDiaPropertyStorage
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDiaPropertyStorage*, Guid*, void**, int>)(lpVtbl[0]))((IDiaPropertyStorage*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDiaPropertyStorage*, uint>)(lpVtbl[1]))((IDiaPropertyStorage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDiaPropertyStorage*, uint>)(lpVtbl[2]))((IDiaPropertyStorage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int ReadMultiple([NativeTypeName("ULONG")] uint cpspec, [NativeTypeName("const PROPSPEC *")] PROPSPEC* rgpspec, PROPVARIANT* rgvar)
        {
            return ((delegate* unmanaged<IDiaPropertyStorage*, uint, PROPSPEC*, PROPVARIANT*, int>)(lpVtbl[3]))((IDiaPropertyStorage*)Unsafe.AsPointer(ref this), cpspec, rgpspec, rgvar);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int ReadPropertyNames([NativeTypeName("ULONG")] uint cpropid, [NativeTypeName("const PROPID *")] uint* rgpropid, [NativeTypeName("BSTR *")] ushort** rglpwstrName)
        {
            return ((delegate* unmanaged<IDiaPropertyStorage*, uint, uint*, ushort**, int>)(lpVtbl[4]))((IDiaPropertyStorage*)Unsafe.AsPointer(ref this), cpropid, rgpropid, rglpwstrName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int Enum(IEnumSTATPROPSTG** ppenum)
        {
            return ((delegate* unmanaged<IDiaPropertyStorage*, IEnumSTATPROPSTG**, int>)(lpVtbl[5]))((IDiaPropertyStorage*)Unsafe.AsPointer(ref this), ppenum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int ReadDWORD([NativeTypeName("PROPID")] uint id, [NativeTypeName("DWORD *")] uint* pValue)
        {
            return ((delegate* unmanaged<IDiaPropertyStorage*, uint, uint*, int>)(lpVtbl[6]))((IDiaPropertyStorage*)Unsafe.AsPointer(ref this), id, pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int ReadLONG([NativeTypeName("PROPID")] uint id, [NativeTypeName("LONG *")] int* pValue)
        {
            return ((delegate* unmanaged<IDiaPropertyStorage*, uint, int*, int>)(lpVtbl[7]))((IDiaPropertyStorage*)Unsafe.AsPointer(ref this), id, pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int ReadBOOL([NativeTypeName("PROPID")] uint id, [NativeTypeName("BOOL *")] int* pValue)
        {
            return ((delegate* unmanaged<IDiaPropertyStorage*, uint, int*, int>)(lpVtbl[8]))((IDiaPropertyStorage*)Unsafe.AsPointer(ref this), id, pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int ReadULONGLONG([NativeTypeName("PROPID")] uint id, [NativeTypeName("ULONGLONG *")] ulong* pValue)
        {
            return ((delegate* unmanaged<IDiaPropertyStorage*, uint, ulong*, int>)(lpVtbl[9]))((IDiaPropertyStorage*)Unsafe.AsPointer(ref this), id, pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int ReadBSTR([NativeTypeName("PROPID")] uint id, [NativeTypeName("BSTR *")] ushort** pValue)
        {
            return ((delegate* unmanaged<IDiaPropertyStorage*, uint, ushort**, int>)(lpVtbl[10]))((IDiaPropertyStorage*)Unsafe.AsPointer(ref this), id, pValue);
        }
    }
}
