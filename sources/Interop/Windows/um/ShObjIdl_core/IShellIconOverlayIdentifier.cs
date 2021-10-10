// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0C6C4200-C589-11D0-999A-00C04FD655E1")]
    [NativeTypeName("struct IShellIconOverlayIdentifier : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IShellIconOverlayIdentifier
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IShellIconOverlayIdentifier*, Guid*, void**, int>)(lpVtbl[0]))((IShellIconOverlayIdentifier*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IShellIconOverlayIdentifier*, uint>)(lpVtbl[1]))((IShellIconOverlayIdentifier*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IShellIconOverlayIdentifier*, uint>)(lpVtbl[2]))((IShellIconOverlayIdentifier*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int IsMemberOf([NativeTypeName("LPCWSTR")] ushort* pwszPath, [NativeTypeName("DWORD")] uint dwAttrib)
        {
            return ((delegate* unmanaged<IShellIconOverlayIdentifier*, ushort*, uint, int>)(lpVtbl[3]))((IShellIconOverlayIdentifier*)Unsafe.AsPointer(ref this), pwszPath, dwAttrib);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetOverlayInfo([NativeTypeName("LPWSTR")] ushort* pwszIconFile, int cchMax, int* pIndex, [NativeTypeName("DWORD *")] uint* pdwFlags)
        {
            return ((delegate* unmanaged<IShellIconOverlayIdentifier*, ushort*, int, int*, uint*, int>)(lpVtbl[4]))((IShellIconOverlayIdentifier*)Unsafe.AsPointer(ref this), pwszIconFile, cchMax, pIndex, pdwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetPriority(int* pPriority)
        {
            return ((delegate* unmanaged<IShellIconOverlayIdentifier*, int*, int>)(lpVtbl[5]))((IShellIconOverlayIdentifier*)Unsafe.AsPointer(ref this), pPriority);
        }
    }
}
