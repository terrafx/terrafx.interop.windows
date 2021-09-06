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
    public unsafe partial struct INameSpaceTreeControlDropHandler
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlDropHandler*, Guid*, void**, int>)(lpVtbl[0]))((INameSpaceTreeControlDropHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<INameSpaceTreeControlDropHandler*, uint>)(lpVtbl[1]))((INameSpaceTreeControlDropHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<INameSpaceTreeControlDropHandler*, uint>)(lpVtbl[2]))((INameSpaceTreeControlDropHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnDragEnter(IShellItem* psiOver, IShellItemArray* psiaData, [NativeTypeName("BOOL")] int fOutsideSource, [NativeTypeName("DWORD")] uint grfKeyState, [NativeTypeName("DWORD *")] uint* pdwEffect)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlDropHandler*, IShellItem*, IShellItemArray*, int, uint, uint*, int>)(lpVtbl[3]))((INameSpaceTreeControlDropHandler*)Unsafe.AsPointer(ref this), psiOver, psiaData, fOutsideSource, grfKeyState, pdwEffect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnDragOver(IShellItem* psiOver, IShellItemArray* psiaData, [NativeTypeName("DWORD")] uint grfKeyState, [NativeTypeName("DWORD *")] uint* pdwEffect)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlDropHandler*, IShellItem*, IShellItemArray*, uint, uint*, int>)(lpVtbl[4]))((INameSpaceTreeControlDropHandler*)Unsafe.AsPointer(ref this), psiOver, psiaData, grfKeyState, pdwEffect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnDragPosition(IShellItem* psiOver, IShellItemArray* psiaData, int iNewPosition, int iOldPosition)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlDropHandler*, IShellItem*, IShellItemArray*, int, int, int>)(lpVtbl[5]))((INameSpaceTreeControlDropHandler*)Unsafe.AsPointer(ref this), psiOver, psiaData, iNewPosition, iOldPosition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnDrop(IShellItem* psiOver, IShellItemArray* psiaData, int iPosition, [NativeTypeName("DWORD")] uint grfKeyState, [NativeTypeName("DWORD *")] uint* pdwEffect)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlDropHandler*, IShellItem*, IShellItemArray*, int, uint, uint*, int>)(lpVtbl[6]))((INameSpaceTreeControlDropHandler*)Unsafe.AsPointer(ref this), psiOver, psiaData, iPosition, grfKeyState, pdwEffect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnDropPosition(IShellItem* psiOver, IShellItemArray* psiaData, int iNewPosition, int iOldPosition)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlDropHandler*, IShellItem*, IShellItemArray*, int, int, int>)(lpVtbl[7]))((INameSpaceTreeControlDropHandler*)Unsafe.AsPointer(ref this), psiOver, psiaData, iNewPosition, iOldPosition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnDragLeave(IShellItem* psiOver)
        {
            return ((delegate* unmanaged<INameSpaceTreeControlDropHandler*, IShellItem*, int>)(lpVtbl[8]))((INameSpaceTreeControlDropHandler*)Unsafe.AsPointer(ref this), psiOver);
        }
    }
}
