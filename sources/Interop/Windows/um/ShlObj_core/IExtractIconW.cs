// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("000214FA-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IExtractIconW : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IExtractIconW
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IExtractIconW*, Guid*, void**, int>)(lpVtbl[0]))((IExtractIconW*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IExtractIconW*, uint>)(lpVtbl[1]))((IExtractIconW*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IExtractIconW*, uint>)(lpVtbl[2]))((IExtractIconW*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetIconLocation([NativeTypeName("UINT")] uint uFlags, [NativeTypeName("PWSTR")] ushort* pszIconFile, [NativeTypeName("UINT")] uint cchMax, int* piIndex, [NativeTypeName("UINT *")] uint* pwFlags)
        {
            return ((delegate* unmanaged<IExtractIconW*, uint, ushort*, uint, int*, uint*, int>)(lpVtbl[3]))((IExtractIconW*)Unsafe.AsPointer(ref this), uFlags, pszIconFile, cchMax, piIndex, pwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int Extract([NativeTypeName("PCWSTR")] ushort* pszFile, [NativeTypeName("UINT")] uint nIconIndex, [NativeTypeName("HICON *")] IntPtr* phiconLarge, [NativeTypeName("HICON *")] IntPtr* phiconSmall, [NativeTypeName("UINT")] uint nIconSize)
        {
            return ((delegate* unmanaged<IExtractIconW*, ushort*, uint, IntPtr*, IntPtr*, uint, int>)(lpVtbl[4]))((IExtractIconW*)Unsafe.AsPointer(ref this), pszFile, nIconIndex, phiconLarge, phiconSmall, nIconSize);
        }
    }
}
