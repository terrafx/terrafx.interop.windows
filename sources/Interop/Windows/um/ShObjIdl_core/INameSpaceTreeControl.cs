// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("028212A3-B627-47E9-8856-C14265554E4F")]
    [NativeTypeName("struct INameSpaceTreeControl : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct INameSpaceTreeControl
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl*, Guid*, void**, int>)(lpVtbl[0]))((INameSpaceTreeControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<INameSpaceTreeControl*, uint>)(lpVtbl[1]))((INameSpaceTreeControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<INameSpaceTreeControl*, uint>)(lpVtbl[2]))((INameSpaceTreeControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Initialize(HWND hwndParent, RECT* prc, [NativeTypeName("NSTCSTYLE")] uint nsctsFlags)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl*, HWND, RECT*, uint, int>)(lpVtbl[3]))((INameSpaceTreeControl*)Unsafe.AsPointer(ref this), hwndParent, prc, nsctsFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT TreeAdvise(IUnknown* punk, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl*, IUnknown*, uint*, int>)(lpVtbl[4]))((INameSpaceTreeControl*)Unsafe.AsPointer(ref this), punk, pdwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT TreeUnadvise([NativeTypeName("DWORD")] uint dwCookie)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl*, uint, int>)(lpVtbl[5]))((INameSpaceTreeControl*)Unsafe.AsPointer(ref this), dwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT AppendRoot(IShellItem* psiRoot, [NativeTypeName("SHCONTF")] uint grfEnumFlags, [NativeTypeName("NSTCROOTSTYLE")] uint grfRootStyle, IShellItemFilter* pif)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl*, IShellItem*, uint, uint, IShellItemFilter*, int>)(lpVtbl[6]))((INameSpaceTreeControl*)Unsafe.AsPointer(ref this), psiRoot, grfEnumFlags, grfRootStyle, pif);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT InsertRoot(int iIndex, IShellItem* psiRoot, [NativeTypeName("SHCONTF")] uint grfEnumFlags, [NativeTypeName("NSTCROOTSTYLE")] uint grfRootStyle, IShellItemFilter* pif)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl*, int, IShellItem*, uint, uint, IShellItemFilter*, int>)(lpVtbl[7]))((INameSpaceTreeControl*)Unsafe.AsPointer(ref this), iIndex, psiRoot, grfEnumFlags, grfRootStyle, pif);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT RemoveRoot(IShellItem* psiRoot)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl*, IShellItem*, int>)(lpVtbl[8]))((INameSpaceTreeControl*)Unsafe.AsPointer(ref this), psiRoot);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT RemoveAllRoots()
        {
            return ((delegate* unmanaged<INameSpaceTreeControl*, int>)(lpVtbl[9]))((INameSpaceTreeControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetRootItems(IShellItemArray** ppsiaRootItems)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl*, IShellItemArray**, int>)(lpVtbl[10]))((INameSpaceTreeControl*)Unsafe.AsPointer(ref this), ppsiaRootItems);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT SetItemState(IShellItem* psi, [NativeTypeName("NSTCITEMSTATE")] uint nstcisMask, [NativeTypeName("NSTCITEMSTATE")] uint nstcisFlags)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl*, IShellItem*, uint, uint, int>)(lpVtbl[11]))((INameSpaceTreeControl*)Unsafe.AsPointer(ref this), psi, nstcisMask, nstcisFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetItemState(IShellItem* psi, [NativeTypeName("NSTCITEMSTATE")] uint nstcisMask, [NativeTypeName("NSTCITEMSTATE *")] uint* pnstcisFlags)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl*, IShellItem*, uint, uint*, int>)(lpVtbl[12]))((INameSpaceTreeControl*)Unsafe.AsPointer(ref this), psi, nstcisMask, pnstcisFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetSelectedItems(IShellItemArray** psiaItems)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl*, IShellItemArray**, int>)(lpVtbl[13]))((INameSpaceTreeControl*)Unsafe.AsPointer(ref this), psiaItems);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT GetItemCustomState(IShellItem* psi, int* piStateNumber)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl*, IShellItem*, int*, int>)(lpVtbl[14]))((INameSpaceTreeControl*)Unsafe.AsPointer(ref this), psi, piStateNumber);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT SetItemCustomState(IShellItem* psi, int iStateNumber)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl*, IShellItem*, int, int>)(lpVtbl[15]))((INameSpaceTreeControl*)Unsafe.AsPointer(ref this), psi, iStateNumber);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT EnsureItemVisible(IShellItem* psi)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl*, IShellItem*, int>)(lpVtbl[16]))((INameSpaceTreeControl*)Unsafe.AsPointer(ref this), psi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT SetTheme([NativeTypeName("LPCWSTR")] ushort* pszTheme)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl*, ushort*, int>)(lpVtbl[17]))((INameSpaceTreeControl*)Unsafe.AsPointer(ref this), pszTheme);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT GetNextItem(IShellItem* psi, NSTCGNI nstcgi, IShellItem** ppsiNext)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl*, IShellItem*, NSTCGNI, IShellItem**, int>)(lpVtbl[18]))((INameSpaceTreeControl*)Unsafe.AsPointer(ref this), psi, nstcgi, ppsiNext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT HitTest(POINT* ppt, IShellItem** ppsiOut)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl*, POINT*, IShellItem**, int>)(lpVtbl[19]))((INameSpaceTreeControl*)Unsafe.AsPointer(ref this), ppt, ppsiOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT GetItemRect(IShellItem* psi, RECT* prect)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl*, IShellItem*, RECT*, int>)(lpVtbl[20]))((INameSpaceTreeControl*)Unsafe.AsPointer(ref this), psi, prect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT CollapseAll()
        {
            return ((delegate* unmanaged<INameSpaceTreeControl*, int>)(lpVtbl[21]))((INameSpaceTreeControl*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeControl*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeControl*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeControl*, uint> Release;

            [NativeTypeName("HRESULT (HWND, RECT *, NSTCSTYLE) __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeControl*, HWND, RECT*, uint, int> Initialize;

            [NativeTypeName("HRESULT (IUnknown *, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeControl*, IUnknown*, uint*, int> TreeAdvise;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeControl*, uint, int> TreeUnadvise;

            [NativeTypeName("HRESULT (IShellItem *, SHCONTF, NSTCROOTSTYLE, IShellItemFilter *) __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeControl*, IShellItem*, uint, uint, IShellItemFilter*, int> AppendRoot;

            [NativeTypeName("HRESULT (int, IShellItem *, SHCONTF, NSTCROOTSTYLE, IShellItemFilter *) __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeControl*, int, IShellItem*, uint, uint, IShellItemFilter*, int> InsertRoot;

            [NativeTypeName("HRESULT (IShellItem *) __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeControl*, IShellItem*, int> RemoveRoot;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeControl*, int> RemoveAllRoots;

            [NativeTypeName("HRESULT (IShellItemArray **) __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeControl*, IShellItemArray**, int> GetRootItems;

            [NativeTypeName("HRESULT (IShellItem *, NSTCITEMSTATE, NSTCITEMSTATE) __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeControl*, IShellItem*, uint, uint, int> SetItemState;

            [NativeTypeName("HRESULT (IShellItem *, NSTCITEMSTATE, NSTCITEMSTATE *) __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeControl*, IShellItem*, uint, uint*, int> GetItemState;

            [NativeTypeName("HRESULT (IShellItemArray **) __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeControl*, IShellItemArray**, int> GetSelectedItems;

            [NativeTypeName("HRESULT (IShellItem *, int *) __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeControl*, IShellItem*, int*, int> GetItemCustomState;

            [NativeTypeName("HRESULT (IShellItem *, int) __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeControl*, IShellItem*, int, int> SetItemCustomState;

            [NativeTypeName("HRESULT (IShellItem *) __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeControl*, IShellItem*, int> EnsureItemVisible;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeControl*, ushort*, int> SetTheme;

            [NativeTypeName("HRESULT (IShellItem *, NSTCGNI, IShellItem **) __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeControl*, IShellItem*, NSTCGNI, IShellItem**, int> GetNextItem;

            [NativeTypeName("HRESULT (POINT *, IShellItem **) __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeControl*, POINT*, IShellItem**, int> HitTest;

            [NativeTypeName("HRESULT (IShellItem *, RECT *) __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeControl*, IShellItem*, RECT*, int> GetItemRect;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeControl*, int> CollapseAll;
        }
    }
}
