// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/tlogstg.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7EBFDD80-AD18-11D3-A4C5-00C04F72D6B8")]
    [NativeTypeName("struct ITravelLogStg : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ITravelLogStg
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITravelLogStg*, Guid*, void**, int>)(lpVtbl[0]))((ITravelLogStg*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITravelLogStg*, uint>)(lpVtbl[1]))((ITravelLogStg*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITravelLogStg*, uint>)(lpVtbl[2]))((ITravelLogStg*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int CreateEntry([NativeTypeName("LPCWSTR")] ushort* pszUrl, [NativeTypeName("LPCWSTR")] ushort* pszTitle, ITravelLogEntry* ptleRelativeTo, BOOL fPrepend, ITravelLogEntry** pptle)
        {
            return ((delegate* unmanaged<ITravelLogStg*, ushort*, ushort*, ITravelLogEntry*, BOOL, ITravelLogEntry**, int>)(lpVtbl[3]))((ITravelLogStg*)Unsafe.AsPointer(ref this), pszUrl, pszTitle, ptleRelativeTo, fPrepend, pptle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int TravelTo(ITravelLogEntry* ptle)
        {
            return ((delegate* unmanaged<ITravelLogStg*, ITravelLogEntry*, int>)(lpVtbl[4]))((ITravelLogStg*)Unsafe.AsPointer(ref this), ptle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int EnumEntries([NativeTypeName("TLENUMF")] uint flags, IEnumTravelLogEntry** ppenum)
        {
            return ((delegate* unmanaged<ITravelLogStg*, uint, IEnumTravelLogEntry**, int>)(lpVtbl[5]))((ITravelLogStg*)Unsafe.AsPointer(ref this), flags, ppenum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int FindEntries([NativeTypeName("TLENUMF")] uint flags, [NativeTypeName("LPCWSTR")] ushort* pszUrl, IEnumTravelLogEntry** ppenum)
        {
            return ((delegate* unmanaged<ITravelLogStg*, uint, ushort*, IEnumTravelLogEntry**, int>)(lpVtbl[6]))((ITravelLogStg*)Unsafe.AsPointer(ref this), flags, pszUrl, ppenum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetCount([NativeTypeName("TLENUMF")] uint flags, [NativeTypeName("DWORD *")] uint* pcEntries)
        {
            return ((delegate* unmanaged<ITravelLogStg*, uint, uint*, int>)(lpVtbl[7]))((ITravelLogStg*)Unsafe.AsPointer(ref this), flags, pcEntries);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveEntry(ITravelLogEntry* ptle)
        {
            return ((delegate* unmanaged<ITravelLogStg*, ITravelLogEntry*, int>)(lpVtbl[8]))((ITravelLogStg*)Unsafe.AsPointer(ref this), ptle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int GetRelativeEntry(int iOffset, ITravelLogEntry** ptle)
        {
            return ((delegate* unmanaged<ITravelLogStg*, int, ITravelLogEntry**, int>)(lpVtbl[9]))((ITravelLogStg*)Unsafe.AsPointer(ref this), iOffset, ptle);
        }
    }
}
