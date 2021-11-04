// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F9C665D6-C2F2-4C19-BF33-8322D7352F51")]
    [NativeTypeName("struct INameSpaceTreeControlDropHandler : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct INameSpaceTreeControlDropHandler
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlDropHandler*, Guid*, void**, int>)(lpVtbl[0]))((INameSpaceTreeControlDropHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<INameSpaceTreeControlDropHandler*, uint>)(lpVtbl[1]))((INameSpaceTreeControlDropHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<INameSpaceTreeControlDropHandler*, uint>)(lpVtbl[2]))((INameSpaceTreeControlDropHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT OnDragEnter(IShellItem* psiOver, IShellItemArray* psiaData, BOOL fOutsideSource, [NativeTypeName("DWORD")] uint grfKeyState, [NativeTypeName("DWORD *")] uint* pdwEffect)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlDropHandler*, IShellItem*, IShellItemArray*, BOOL, uint, uint*, int>)(lpVtbl[3]))((INameSpaceTreeControlDropHandler*)Unsafe.AsPointer(ref this), psiOver, psiaData, fOutsideSource, grfKeyState, pdwEffect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT OnDragOver(IShellItem* psiOver, IShellItemArray* psiaData, [NativeTypeName("DWORD")] uint grfKeyState, [NativeTypeName("DWORD *")] uint* pdwEffect)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlDropHandler*, IShellItem*, IShellItemArray*, uint, uint*, int>)(lpVtbl[4]))((INameSpaceTreeControlDropHandler*)Unsafe.AsPointer(ref this), psiOver, psiaData, grfKeyState, pdwEffect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT OnDragPosition(IShellItem* psiOver, IShellItemArray* psiaData, int iNewPosition, int iOldPosition)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlDropHandler*, IShellItem*, IShellItemArray*, int, int, int>)(lpVtbl[5]))((INameSpaceTreeControlDropHandler*)Unsafe.AsPointer(ref this), psiOver, psiaData, iNewPosition, iOldPosition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT OnDrop(IShellItem* psiOver, IShellItemArray* psiaData, int iPosition, [NativeTypeName("DWORD")] uint grfKeyState, [NativeTypeName("DWORD *")] uint* pdwEffect)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlDropHandler*, IShellItem*, IShellItemArray*, int, uint, uint*, int>)(lpVtbl[6]))((INameSpaceTreeControlDropHandler*)Unsafe.AsPointer(ref this), psiOver, psiaData, iPosition, grfKeyState, pdwEffect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT OnDropPosition(IShellItem* psiOver, IShellItemArray* psiaData, int iNewPosition, int iOldPosition)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlDropHandler*, IShellItem*, IShellItemArray*, int, int, int>)(lpVtbl[7]))((INameSpaceTreeControlDropHandler*)Unsafe.AsPointer(ref this), psiOver, psiaData, iNewPosition, iOldPosition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT OnDragLeave(IShellItem* psiOver)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlDropHandler*, IShellItem*, int>)(lpVtbl[8]))((INameSpaceTreeControlDropHandler*)Unsafe.AsPointer(ref this), psiOver);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeControlDropHandler*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeControlDropHandler*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeControlDropHandler*, uint> Release;

            [NativeTypeName("HRESULT (IShellItem *, IShellItemArray *, BOOL, DWORD, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeControlDropHandler*, IShellItem*, IShellItemArray*, BOOL, uint, uint*, int> OnDragEnter;

            [NativeTypeName("HRESULT (IShellItem *, IShellItemArray *, DWORD, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeControlDropHandler*, IShellItem*, IShellItemArray*, uint, uint*, int> OnDragOver;

            [NativeTypeName("HRESULT (IShellItem *, IShellItemArray *, int, int) __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeControlDropHandler*, IShellItem*, IShellItemArray*, int, int, int> OnDragPosition;

            [NativeTypeName("HRESULT (IShellItem *, IShellItemArray *, int, DWORD, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeControlDropHandler*, IShellItem*, IShellItemArray*, int, uint, uint*, int> OnDrop;

            [NativeTypeName("HRESULT (IShellItem *, IShellItemArray *, int, int) __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeControlDropHandler*, IShellItem*, IShellItemArray*, int, int, int> OnDropPosition;

            [NativeTypeName("HRESULT (IShellItem *) __attribute__((stdcall))")]
            public delegate* unmanaged<INameSpaceTreeControlDropHandler*, IShellItem*, int> OnDragLeave;
        }
    }
}
