// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BCFCE0A0-EC17-11D0-8D10-00A0C90F2719")]
    [NativeTypeName("struct IContextMenu3 : IContextMenu2")]
    public unsafe partial struct IContextMenu3
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IContextMenu3*, Guid*, void**, int>)(lpVtbl[0]))((IContextMenu3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IContextMenu3*, uint>)(lpVtbl[1]))((IContextMenu3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IContextMenu3*, uint>)(lpVtbl[2]))((IContextMenu3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryContextMenu([NativeTypeName("HMENU")] IntPtr hmenu, [NativeTypeName("UINT")] uint indexMenu, [NativeTypeName("UINT")] uint idCmdFirst, [NativeTypeName("UINT")] uint idCmdLast, [NativeTypeName("UINT")] uint uFlags)
        {
            return ((delegate* unmanaged<IContextMenu3*, IntPtr, uint, uint, uint, uint, int>)(lpVtbl[3]))((IContextMenu3*)Unsafe.AsPointer(ref this), hmenu, indexMenu, idCmdFirst, idCmdLast, uFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InvokeCommand(CMINVOKECOMMANDINFO* pici)
        {
            return ((delegate* unmanaged<IContextMenu3*, CMINVOKECOMMANDINFO*, int>)(lpVtbl[4]))((IContextMenu3*)Unsafe.AsPointer(ref this), pici);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCommandString([NativeTypeName("UINT_PTR")] nuint idCmd, [NativeTypeName("UINT")] uint uType, [NativeTypeName("UINT *")] uint* pReserved, [NativeTypeName("CHAR *")] sbyte* pszName, [NativeTypeName("UINT")] uint cchMax)
        {
            return ((delegate* unmanaged<IContextMenu3*, nuint, uint, uint*, sbyte*, uint, int>)(lpVtbl[5]))((IContextMenu3*)Unsafe.AsPointer(ref this), idCmd, uType, pReserved, pszName, cchMax);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int HandleMenuMsg([NativeTypeName("UINT")] uint uMsg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam)
        {
            return ((delegate* unmanaged<IContextMenu3*, uint, nuint, nint, int>)(lpVtbl[6]))((IContextMenu3*)Unsafe.AsPointer(ref this), uMsg, wParam, lParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int HandleMenuMsg2([NativeTypeName("UINT")] uint uMsg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam, [NativeTypeName("LRESULT *")] nint* plResult)
        {
            return ((delegate* unmanaged<IContextMenu3*, uint, nuint, nint, nint*, int>)(lpVtbl[7]))((IContextMenu3*)Unsafe.AsPointer(ref this), uMsg, wParam, lParam, plResult);
        }
    }
}
