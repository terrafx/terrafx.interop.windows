// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("AE8C987D-8797-4ED3-BE72-2A47DD938DB0")]
    [NativeTypeName("struct IFolderViewSettings : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IFolderViewSettings : IFolderViewSettings.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IFolderViewSettings*, Guid*, void**, int>)(lpVtbl[0]))((IFolderViewSettings*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IFolderViewSettings*, uint>)(lpVtbl[1]))((IFolderViewSettings*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IFolderViewSettings*, uint>)(lpVtbl[2]))((IFolderViewSettings*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetColumnPropertyList([NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IFolderViewSettings*, Guid*, void**, int>)(lpVtbl[3]))((IFolderViewSettings*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetGroupByProperty(PROPERTYKEY* pkey, BOOL* pfGroupAscending)
        {
            return ((delegate* unmanaged<IFolderViewSettings*, PROPERTYKEY*, BOOL*, int>)(lpVtbl[4]))((IFolderViewSettings*)Unsafe.AsPointer(ref this), pkey, pfGroupAscending);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetViewMode(FOLDERLOGICALVIEWMODE* plvm)
        {
            return ((delegate* unmanaged<IFolderViewSettings*, FOLDERLOGICALVIEWMODE*, int>)(lpVtbl[5]))((IFolderViewSettings*)Unsafe.AsPointer(ref this), plvm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetIconSize(uint* puIconSize)
        {
            return ((delegate* unmanaged<IFolderViewSettings*, uint*, int>)(lpVtbl[6]))((IFolderViewSettings*)Unsafe.AsPointer(ref this), puIconSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetFolderFlags(FOLDERFLAGS* pfolderMask, FOLDERFLAGS* pfolderFlags)
        {
            return ((delegate* unmanaged<IFolderViewSettings*, FOLDERFLAGS*, FOLDERFLAGS*, int>)(lpVtbl[7]))((IFolderViewSettings*)Unsafe.AsPointer(ref this), pfolderMask, pfolderFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetSortColumns(SORTCOLUMN* rgSortColumns, uint cColumnsIn, uint* pcColumnsOut)
        {
            return ((delegate* unmanaged<IFolderViewSettings*, SORTCOLUMN*, uint, uint*, int>)(lpVtbl[8]))((IFolderViewSettings*)Unsafe.AsPointer(ref this), rgSortColumns, cColumnsIn, pcColumnsOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetGroupSubsetCount(uint* pcVisibleRows)
        {
            return ((delegate* unmanaged<IFolderViewSettings*, uint*, int>)(lpVtbl[9]))((IFolderViewSettings*)Unsafe.AsPointer(ref this), pcVisibleRows);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetColumnPropertyList([NativeTypeName("const IID &")] Guid* riid, void** ppv);

            [VtblIndex(4)]
            HRESULT GetGroupByProperty(PROPERTYKEY* pkey, BOOL* pfGroupAscending);

            [VtblIndex(5)]
            HRESULT GetViewMode(FOLDERLOGICALVIEWMODE* plvm);

            [VtblIndex(6)]
            HRESULT GetIconSize(uint* puIconSize);

            [VtblIndex(7)]
            HRESULT GetFolderFlags(FOLDERFLAGS* pfolderMask, FOLDERFLAGS* pfolderFlags);

            [VtblIndex(8)]
            HRESULT GetSortColumns(SORTCOLUMN* rgSortColumns, uint cColumnsIn, uint* pcColumnsOut);

            [VtblIndex(9)]
            HRESULT GetGroupSubsetCount(uint* pcVisibleRows);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IFolderViewSettings*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IFolderViewSettings*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IFolderViewSettings*, uint> Release;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IFolderViewSettings*, Guid*, void**, int> GetColumnPropertyList;

            [NativeTypeName("HRESULT (PROPERTYKEY *, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFolderViewSettings*, PROPERTYKEY*, BOOL*, int> GetGroupByProperty;

            [NativeTypeName("HRESULT (FOLDERLOGICALVIEWMODE *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFolderViewSettings*, FOLDERLOGICALVIEWMODE*, int> GetViewMode;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFolderViewSettings*, uint*, int> GetIconSize;

            [NativeTypeName("HRESULT (FOLDERFLAGS *, FOLDERFLAGS *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFolderViewSettings*, FOLDERFLAGS*, FOLDERFLAGS*, int> GetFolderFlags;

            [NativeTypeName("HRESULT (SORTCOLUMN *, UINT, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFolderViewSettings*, SORTCOLUMN*, uint, uint*, int> GetSortColumns;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFolderViewSettings*, uint*, int> GetGroupSubsetCount;
        }
    }
}
