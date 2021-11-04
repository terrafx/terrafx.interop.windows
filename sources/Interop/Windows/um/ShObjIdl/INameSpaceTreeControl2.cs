// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7CC7AED8-290E-49BC-8945-C1401CC9306C")]
    [NativeTypeName("struct INameSpaceTreeControl2 : INameSpaceTreeControl")]
    [NativeInheritance("INameSpaceTreeControl")]
    public unsafe partial struct INameSpaceTreeControl2 : INameSpaceTreeControl2.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl2*, Guid*, void**, int>)(lpVtbl[0]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<INameSpaceTreeControl2*, uint>)(lpVtbl[1]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<INameSpaceTreeControl2*, uint>)(lpVtbl[2]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Initialize(HWND hwndParent, RECT* prc, [NativeTypeName("NSTCSTYLE")] uint nsctsFlags)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl2*, HWND, RECT*, uint, int>)(lpVtbl[3]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), hwndParent, prc, nsctsFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT TreeAdvise(IUnknown* punk, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl2*, IUnknown*, uint*, int>)(lpVtbl[4]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), punk, pdwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT TreeUnadvise([NativeTypeName("DWORD")] uint dwCookie)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl2*, uint, int>)(lpVtbl[5]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), dwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT AppendRoot(IShellItem* psiRoot, [NativeTypeName("SHCONTF")] uint grfEnumFlags, [NativeTypeName("NSTCROOTSTYLE")] uint grfRootStyle, IShellItemFilter* pif)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl2*, IShellItem*, uint, uint, IShellItemFilter*, int>)(lpVtbl[6]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), psiRoot, grfEnumFlags, grfRootStyle, pif);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT InsertRoot(int iIndex, IShellItem* psiRoot, [NativeTypeName("SHCONTF")] uint grfEnumFlags, [NativeTypeName("NSTCROOTSTYLE")] uint grfRootStyle, IShellItemFilter* pif)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl2*, int, IShellItem*, uint, uint, IShellItemFilter*, int>)(lpVtbl[7]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), iIndex, psiRoot, grfEnumFlags, grfRootStyle, pif);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT RemoveRoot(IShellItem* psiRoot)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl2*, IShellItem*, int>)(lpVtbl[8]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), psiRoot);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT RemoveAllRoots()
        {
            return ((delegate* unmanaged<INameSpaceTreeControl2*, int>)(lpVtbl[9]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetRootItems(IShellItemArray** ppsiaRootItems)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl2*, IShellItemArray**, int>)(lpVtbl[10]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), ppsiaRootItems);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT SetItemState(IShellItem* psi, [NativeTypeName("NSTCITEMSTATE")] uint nstcisMask, [NativeTypeName("NSTCITEMSTATE")] uint nstcisFlags)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl2*, IShellItem*, uint, uint, int>)(lpVtbl[11]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), psi, nstcisMask, nstcisFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetItemState(IShellItem* psi, [NativeTypeName("NSTCITEMSTATE")] uint nstcisMask, [NativeTypeName("NSTCITEMSTATE *")] uint* pnstcisFlags)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl2*, IShellItem*, uint, uint*, int>)(lpVtbl[12]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), psi, nstcisMask, pnstcisFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetSelectedItems(IShellItemArray** psiaItems)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl2*, IShellItemArray**, int>)(lpVtbl[13]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), psiaItems);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT GetItemCustomState(IShellItem* psi, int* piStateNumber)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl2*, IShellItem*, int*, int>)(lpVtbl[14]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), psi, piStateNumber);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT SetItemCustomState(IShellItem* psi, int iStateNumber)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl2*, IShellItem*, int, int>)(lpVtbl[15]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), psi, iStateNumber);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT EnsureItemVisible(IShellItem* psi)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl2*, IShellItem*, int>)(lpVtbl[16]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), psi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT SetTheme([NativeTypeName("LPCWSTR")] ushort* pszTheme)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl2*, ushort*, int>)(lpVtbl[17]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), pszTheme);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT GetNextItem(IShellItem* psi, NSTCGNI nstcgi, IShellItem** ppsiNext)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl2*, IShellItem*, NSTCGNI, IShellItem**, int>)(lpVtbl[18]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), psi, nstcgi, ppsiNext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT HitTest(POINT* ppt, IShellItem** ppsiOut)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl2*, POINT*, IShellItem**, int>)(lpVtbl[19]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), ppt, ppsiOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT GetItemRect(IShellItem* psi, RECT* prect)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl2*, IShellItem*, RECT*, int>)(lpVtbl[20]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), psi, prect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT CollapseAll()
        {
            return ((delegate* unmanaged<INameSpaceTreeControl2*, int>)(lpVtbl[21]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT SetControlStyle([NativeTypeName("NSTCSTYLE")] uint nstcsMask, [NativeTypeName("NSTCSTYLE")] uint nstcsStyle)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl2*, uint, uint, int>)(lpVtbl[22]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), nstcsMask, nstcsStyle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT GetControlStyle([NativeTypeName("NSTCSTYLE")] uint nstcsMask, [NativeTypeName("NSTCSTYLE *")] uint* pnstcsStyle)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl2*, uint, uint*, int>)(lpVtbl[23]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), nstcsMask, pnstcsStyle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT SetControlStyle2(NSTCSTYLE2 nstcsMask, NSTCSTYLE2 nstcsStyle)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl2*, NSTCSTYLE2, NSTCSTYLE2, int>)(lpVtbl[24]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), nstcsMask, nstcsStyle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT GetControlStyle2(NSTCSTYLE2 nstcsMask, NSTCSTYLE2* pnstcsStyle)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl2*, NSTCSTYLE2, NSTCSTYLE2*, int>)(lpVtbl[25]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), nstcsMask, pnstcsStyle);
        }

        public interface Interface : INameSpaceTreeControl.Interface
        {
            [VtblIndex(22)]
            HRESULT SetControlStyle([NativeTypeName("NSTCSTYLE")] uint nstcsMask, [NativeTypeName("NSTCSTYLE")] uint nstcsStyle);

            [VtblIndex(23)]
            HRESULT GetControlStyle([NativeTypeName("NSTCSTYLE")] uint nstcsMask, [NativeTypeName("NSTCSTYLE *")] uint* pnstcsStyle);

            [VtblIndex(24)]
            HRESULT SetControlStyle2(NSTCSTYLE2 nstcsMask, NSTCSTYLE2 nstcsStyle);

            [VtblIndex(25)]
            HRESULT GetControlStyle2(NSTCSTYLE2 nstcsMask, NSTCSTYLE2* pnstcsStyle);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeControl2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeControl2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeControl2*, uint> Release;

            [NativeTypeName("HRESULT (HWND, RECT *, NSTCSTYLE) __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeControl2*, HWND, RECT*, uint, int> Initialize;

            [NativeTypeName("HRESULT (IUnknown *, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeControl2*, IUnknown*, uint*, int> TreeAdvise;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeControl2*, uint, int> TreeUnadvise;

            [NativeTypeName("HRESULT (IShellItem *, SHCONTF, NSTCROOTSTYLE, IShellItemFilter *) __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeControl2*, IShellItem*, uint, uint, IShellItemFilter*, int> AppendRoot;

            [NativeTypeName("HRESULT (int, IShellItem *, SHCONTF, NSTCROOTSTYLE, IShellItemFilter *) __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeControl2*, int, IShellItem*, uint, uint, IShellItemFilter*, int> InsertRoot;

            [NativeTypeName("HRESULT (IShellItem *) __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeControl2*, IShellItem*, int> RemoveRoot;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeControl2*, int> RemoveAllRoots;

            [NativeTypeName("HRESULT (IShellItemArray **) __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeControl2*, IShellItemArray**, int> GetRootItems;

            [NativeTypeName("HRESULT (IShellItem *, NSTCITEMSTATE, NSTCITEMSTATE) __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeControl2*, IShellItem*, uint, uint, int> SetItemState;

            [NativeTypeName("HRESULT (IShellItem *, NSTCITEMSTATE, NSTCITEMSTATE *) __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeControl2*, IShellItem*, uint, uint*, int> GetItemState;

            [NativeTypeName("HRESULT (IShellItemArray **) __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeControl2*, IShellItemArray**, int> GetSelectedItems;

            [NativeTypeName("HRESULT (IShellItem *, int *) __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeControl2*, IShellItem*, int*, int> GetItemCustomState;

            [NativeTypeName("HRESULT (IShellItem *, int) __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeControl2*, IShellItem*, int, int> SetItemCustomState;

            [NativeTypeName("HRESULT (IShellItem *) __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeControl2*, IShellItem*, int> EnsureItemVisible;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeControl2*, ushort*, int> SetTheme;

            [NativeTypeName("HRESULT (IShellItem *, NSTCGNI, IShellItem **) __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeControl2*, IShellItem*, NSTCGNI, IShellItem**, int> GetNextItem;

            [NativeTypeName("HRESULT (POINT *, IShellItem **) __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeControl2*, POINT*, IShellItem**, int> HitTest;

            [NativeTypeName("HRESULT (IShellItem *, RECT *) __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeControl2*, IShellItem*, RECT*, int> GetItemRect;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeControl2*, int> CollapseAll;

            [NativeTypeName("HRESULT (NSTCSTYLE, NSTCSTYLE) __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeControl2*, uint, uint, int> SetControlStyle;

            [NativeTypeName("HRESULT (NSTCSTYLE, NSTCSTYLE *) __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeControl2*, uint, uint*, int> GetControlStyle;

            [NativeTypeName("HRESULT (NSTCSTYLE2, NSTCSTYLE2) __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeControl2*, NSTCSTYLE2, NSTCSTYLE2, int> SetControlStyle2;

            [NativeTypeName("HRESULT (NSTCSTYLE2, NSTCSTYLE2 *) __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeControl2*, NSTCSTYLE2, NSTCSTYLE2*, int> GetControlStyle2;
        }
    }
}
