// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shdeprecated.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("66A9CB08-4802-11D2-A561-00A0C92DBFE8")]
    [NativeTypeName("struct ITravelLog : IUnknown")]
    public unsafe partial struct ITravelLog
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITravelLog*, Guid*, void**, int>)(lpVtbl[0]))((ITravelLog*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITravelLog*, uint>)(lpVtbl[1]))((ITravelLog*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITravelLog*, uint>)(lpVtbl[2]))((ITravelLog*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddEntry(IUnknown* punk, [NativeTypeName("BOOL")] int fIsLocalAnchor)
        {
            return ((delegate* unmanaged<ITravelLog*, IUnknown*, int, int>)(lpVtbl[3]))((ITravelLog*)Unsafe.AsPointer(ref this), punk, fIsLocalAnchor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateEntry(IUnknown* punk, [NativeTypeName("BOOL")] int fIsLocalAnchor)
        {
            return ((delegate* unmanaged<ITravelLog*, IUnknown*, int, int>)(lpVtbl[4]))((ITravelLog*)Unsafe.AsPointer(ref this), punk, fIsLocalAnchor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateExternal(IUnknown* punk, IUnknown* punkHLBrowseContext)
        {
            return ((delegate* unmanaged<ITravelLog*, IUnknown*, IUnknown*, int>)(lpVtbl[5]))((ITravelLog*)Unsafe.AsPointer(ref this), punk, punkHLBrowseContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Travel(IUnknown* punk, int iOffset)
        {
            return ((delegate* unmanaged<ITravelLog*, IUnknown*, int, int>)(lpVtbl[6]))((ITravelLog*)Unsafe.AsPointer(ref this), punk, iOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTravelEntry(IUnknown* punk, int iOffset, ITravelEntry** ppte)
        {
            return ((delegate* unmanaged<ITravelLog*, IUnknown*, int, ITravelEntry**, int>)(lpVtbl[7]))((ITravelLog*)Unsafe.AsPointer(ref this), punk, iOffset, ppte);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FindTravelEntry(IUnknown* punk, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, ITravelEntry** ppte)
        {
            return ((delegate* unmanaged<ITravelLog*, IUnknown*, ITEMIDLIST*, ITravelEntry**, int>)(lpVtbl[8]))((ITravelLog*)Unsafe.AsPointer(ref this), punk, pidl, ppte);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetToolTipText(IUnknown* punk, int iOffset, int idsTemplate, [NativeTypeName("LPWSTR")] ushort* pwzText, [NativeTypeName("DWORD")] uint cchText)
        {
            return ((delegate* unmanaged<ITravelLog*, IUnknown*, int, int, ushort*, uint, int>)(lpVtbl[9]))((ITravelLog*)Unsafe.AsPointer(ref this), punk, iOffset, idsTemplate, pwzText, cchText);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InsertMenuEntries(IUnknown* punk, [NativeTypeName("HMENU")] IntPtr hmenu, int nPos, int idFirst, int idLast, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<ITravelLog*, IUnknown*, IntPtr, int, int, int, uint, int>)(lpVtbl[10]))((ITravelLog*)Unsafe.AsPointer(ref this), punk, hmenu, nPos, idFirst, idLast, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Clone(ITravelLog** pptl)
        {
            return ((delegate* unmanaged<ITravelLog*, ITravelLog**, int>)(lpVtbl[11]))((ITravelLog*)Unsafe.AsPointer(ref this), pptl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("DWORD")]
        public uint CountEntries(IUnknown* punk)
        {
            return ((delegate* unmanaged<ITravelLog*, IUnknown*, uint>)(lpVtbl[12]))((ITravelLog*)Unsafe.AsPointer(ref this), punk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Revert()
        {
            return ((delegate* unmanaged<ITravelLog*, int>)(lpVtbl[13]))((ITravelLog*)Unsafe.AsPointer(ref this));
        }
    }
}
