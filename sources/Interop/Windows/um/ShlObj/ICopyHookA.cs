// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("000214EF-0000-0000-C000-000000000046")]
    [NativeTypeName("struct ICopyHookA : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ICopyHookA
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ICopyHookA*, Guid*, void**, int>)(lpVtbl[0]))((ICopyHookA*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICopyHookA*, uint>)(lpVtbl[1]))((ICopyHookA*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICopyHookA*, uint>)(lpVtbl[2]))((ICopyHookA*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("UINT")]
        public uint CopyCallback(HWND hwnd, [NativeTypeName("UINT")] uint wFunc, [NativeTypeName("UINT")] uint wFlags, [NativeTypeName("PCSTR")] sbyte* pszSrcFile, [NativeTypeName("DWORD")] uint dwSrcAttribs, [NativeTypeName("PCSTR")] sbyte* pszDestFile, [NativeTypeName("DWORD")] uint dwDestAttribs)
        {
            return ((delegate* unmanaged<ICopyHookA*, HWND, uint, uint, sbyte*, uint, sbyte*, uint, uint>)(lpVtbl[3]))((ICopyHookA*)Unsafe.AsPointer(ref this), hwnd, wFunc, wFlags, pszSrcFile, dwSrcAttribs, pszDestFile, dwDestAttribs);
        }
    }
}
