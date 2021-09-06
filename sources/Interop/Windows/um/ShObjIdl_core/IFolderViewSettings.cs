// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AE8C987D-8797-4ED3-BE72-2A47DD938DB0")]
    [NativeTypeName("struct IFolderViewSettings : IUnknown")]
    public unsafe partial struct IFolderViewSettings
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IFolderViewSettings*, Guid*, void**, int>)(lpVtbl[0]))((IFolderViewSettings*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IFolderViewSettings*, uint>)(lpVtbl[1]))((IFolderViewSettings*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IFolderViewSettings*, uint>)(lpVtbl[2]))((IFolderViewSettings*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetColumnPropertyList([NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IFolderViewSettings*, Guid*, void**, int>)(lpVtbl[3]))((IFolderViewSettings*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGroupByProperty(PROPERTYKEY* pkey, [NativeTypeName("BOOL *")] int* pfGroupAscending)
        {
            return ((delegate* unmanaged<IFolderViewSettings*, PROPERTYKEY*, int*, int>)(lpVtbl[4]))((IFolderViewSettings*)Unsafe.AsPointer(ref this), pkey, pfGroupAscending);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetViewMode(FOLDERLOGICALVIEWMODE* plvm)
        {
            return ((delegate* unmanaged<IFolderViewSettings*, FOLDERLOGICALVIEWMODE*, int>)(lpVtbl[5]))((IFolderViewSettings*)Unsafe.AsPointer(ref this), plvm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIconSize([NativeTypeName("UINT *")] uint* puIconSize)
        {
            return ((delegate* unmanaged<IFolderViewSettings*, uint*, int>)(lpVtbl[6]))((IFolderViewSettings*)Unsafe.AsPointer(ref this), puIconSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFolderFlags(FOLDERFLAGS* pfolderMask, FOLDERFLAGS* pfolderFlags)
        {
            return ((delegate* unmanaged<IFolderViewSettings*, FOLDERFLAGS*, FOLDERFLAGS*, int>)(lpVtbl[7]))((IFolderViewSettings*)Unsafe.AsPointer(ref this), pfolderMask, pfolderFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSortColumns(SORTCOLUMN* rgSortColumns, [NativeTypeName("UINT")] uint cColumnsIn, [NativeTypeName("UINT *")] uint* pcColumnsOut)
        {
            return ((delegate* unmanaged<IFolderViewSettings*, SORTCOLUMN*, uint, uint*, int>)(lpVtbl[8]))((IFolderViewSettings*)Unsafe.AsPointer(ref this), rgSortColumns, cColumnsIn, pcColumnsOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGroupSubsetCount([NativeTypeName("UINT *")] uint* pcVisibleRows)
        {
            return ((delegate* unmanaged<IFolderViewSettings*, uint*, int>)(lpVtbl[9]))((IFolderViewSettings*)Unsafe.AsPointer(ref this), pcVisibleRows);
        }
    }
}
