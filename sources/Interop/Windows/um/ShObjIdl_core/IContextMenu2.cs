// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("000214F4-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IContextMenu2 : IContextMenu")]
    [NativeInheritance("IContextMenu")]
    public unsafe partial struct IContextMenu2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IContextMenu2*, Guid*, void**, int>)(lpVtbl[0]))((IContextMenu2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IContextMenu2*, uint>)(lpVtbl[1]))((IContextMenu2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IContextMenu2*, uint>)(lpVtbl[2]))((IContextMenu2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT QueryContextMenu(HMENU hmenu, uint indexMenu, uint idCmdFirst, uint idCmdLast, uint uFlags)
        {
            return ((delegate* unmanaged<IContextMenu2*, HMENU, uint, uint, uint, uint, int>)(lpVtbl[3]))((IContextMenu2*)Unsafe.AsPointer(ref this), hmenu, indexMenu, idCmdFirst, idCmdLast, uFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT InvokeCommand(CMINVOKECOMMANDINFO* pici)
        {
            return ((delegate* unmanaged<IContextMenu2*, CMINVOKECOMMANDINFO*, int>)(lpVtbl[4]))((IContextMenu2*)Unsafe.AsPointer(ref this), pici);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetCommandString([NativeTypeName("UINT_PTR")] nuint idCmd, uint uType, uint* pReserved, [NativeTypeName("CHAR *")] sbyte* pszName, uint cchMax)
        {
            return ((delegate* unmanaged<IContextMenu2*, nuint, uint, uint*, sbyte*, uint, int>)(lpVtbl[5]))((IContextMenu2*)Unsafe.AsPointer(ref this), idCmd, uType, pReserved, pszName, cchMax);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT HandleMenuMsg(uint uMsg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam)
        {
            return ((delegate* unmanaged<IContextMenu2*, uint, nuint, nint, int>)(lpVtbl[6]))((IContextMenu2*)Unsafe.AsPointer(ref this), uMsg, wParam, lParam);
        }
    }
}
