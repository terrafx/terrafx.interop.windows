// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("000214EB-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IExtractIconA : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IExtractIconA
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IExtractIconA*, Guid*, void**, int>)(lpVtbl[0]))((IExtractIconA*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IExtractIconA*, uint>)(lpVtbl[1]))((IExtractIconA*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IExtractIconA*, uint>)(lpVtbl[2]))((IExtractIconA*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetIconLocation([NativeTypeName("UINT")] uint uFlags, [NativeTypeName("PSTR")] sbyte* pszIconFile, [NativeTypeName("UINT")] uint cchMax, int* piIndex, [NativeTypeName("UINT *")] uint* pwFlags)
        {
            return ((delegate* unmanaged<IExtractIconA*, uint, sbyte*, uint, int*, uint*, int>)(lpVtbl[3]))((IExtractIconA*)Unsafe.AsPointer(ref this), uFlags, pszIconFile, cchMax, piIndex, pwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int Extract([NativeTypeName("PCSTR")] sbyte* pszFile, [NativeTypeName("UINT")] uint nIconIndex, [NativeTypeName("HICON *")] IntPtr* phiconLarge, [NativeTypeName("HICON *")] IntPtr* phiconSmall, [NativeTypeName("UINT")] uint nIconSize)
        {
            return ((delegate* unmanaged<IExtractIconA*, sbyte*, uint, IntPtr*, IntPtr*, uint, int>)(lpVtbl[4]))((IExtractIconA*)Unsafe.AsPointer(ref this), pszFile, nIconIndex, phiconLarge, phiconSmall, nIconSize);
        }
    }
}
