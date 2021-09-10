// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FF5693BE-2CE0-4D48-B5C5-40817D1ACDB9")]
    [NativeTypeName("struct IShellItemResources : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IShellItemResources
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IShellItemResources*, Guid*, void**, int>)(lpVtbl[0]))((IShellItemResources*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IShellItemResources*, uint>)(lpVtbl[1]))((IShellItemResources*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IShellItemResources*, uint>)(lpVtbl[2]))((IShellItemResources*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetAttributes([NativeTypeName("DWORD *")] uint* pdwAttributes)
        {
            return ((delegate* unmanaged<IShellItemResources*, uint*, int>)(lpVtbl[3]))((IShellItemResources*)Unsafe.AsPointer(ref this), pdwAttributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetSize([NativeTypeName("ULONGLONG *")] ulong* pullSize)
        {
            return ((delegate* unmanaged<IShellItemResources*, ulong*, int>)(lpVtbl[4]))((IShellItemResources*)Unsafe.AsPointer(ref this), pullSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetTimes(FILETIME* pftCreation, FILETIME* pftWrite, FILETIME* pftAccess)
        {
            return ((delegate* unmanaged<IShellItemResources*, FILETIME*, FILETIME*, FILETIME*, int>)(lpVtbl[5]))((IShellItemResources*)Unsafe.AsPointer(ref this), pftCreation, pftWrite, pftAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int SetTimes([NativeTypeName("const FILETIME *")] FILETIME* pftCreation, [NativeTypeName("const FILETIME *")] FILETIME* pftWrite, [NativeTypeName("const FILETIME *")] FILETIME* pftAccess)
        {
            return ((delegate* unmanaged<IShellItemResources*, FILETIME*, FILETIME*, FILETIME*, int>)(lpVtbl[6]))((IShellItemResources*)Unsafe.AsPointer(ref this), pftCreation, pftWrite, pftAccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetResourceDescription([NativeTypeName("const SHELL_ITEM_RESOURCE *")] SHELL_ITEM_RESOURCE* pcsir, [NativeTypeName("LPWSTR *")] ushort** ppszDescription)
        {
            return ((delegate* unmanaged<IShellItemResources*, SHELL_ITEM_RESOURCE*, ushort**, int>)(lpVtbl[7]))((IShellItemResources*)Unsafe.AsPointer(ref this), pcsir, ppszDescription);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int EnumResources(IEnumResources** ppenumr)
        {
            return ((delegate* unmanaged<IShellItemResources*, IEnumResources**, int>)(lpVtbl[8]))((IShellItemResources*)Unsafe.AsPointer(ref this), ppenumr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int SupportsResource([NativeTypeName("const SHELL_ITEM_RESOURCE *")] SHELL_ITEM_RESOURCE* pcsir)
        {
            return ((delegate* unmanaged<IShellItemResources*, SHELL_ITEM_RESOURCE*, int>)(lpVtbl[9]))((IShellItemResources*)Unsafe.AsPointer(ref this), pcsir);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int OpenResource([NativeTypeName("const SHELL_ITEM_RESOURCE *")] SHELL_ITEM_RESOURCE* pcsir, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IShellItemResources*, SHELL_ITEM_RESOURCE*, Guid*, void**, int>)(lpVtbl[10]))((IShellItemResources*)Unsafe.AsPointer(ref this), pcsir, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int CreateResource([NativeTypeName("const SHELL_ITEM_RESOURCE *")] SHELL_ITEM_RESOURCE* pcsir, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IShellItemResources*, SHELL_ITEM_RESOURCE*, Guid*, void**, int>)(lpVtbl[11]))((IShellItemResources*)Unsafe.AsPointer(ref this), pcsir, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int MarkForDelete()
        {
            return ((delegate* unmanaged<IShellItemResources*, int>)(lpVtbl[12]))((IShellItemResources*)Unsafe.AsPointer(ref this));
        }
    }
}
