// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("000214E1-0000-0000-C000-000000000046")]
    [NativeTypeName("struct INewShortcutHookA : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct INewShortcutHookA
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<INewShortcutHookA*, Guid*, void**, int>)(lpVtbl[0]))((INewShortcutHookA*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<INewShortcutHookA*, uint>)(lpVtbl[1]))((INewShortcutHookA*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<INewShortcutHookA*, uint>)(lpVtbl[2]))((INewShortcutHookA*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetReferent([NativeTypeName("PCSTR")] sbyte* pcszReferent, [NativeTypeName("HWND")] IntPtr hwnd)
        {
            return ((delegate* unmanaged<INewShortcutHookA*, sbyte*, IntPtr, int>)(lpVtbl[3]))((INewShortcutHookA*)Unsafe.AsPointer(ref this), pcszReferent, hwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetReferent([NativeTypeName("PSTR")] sbyte* pszReferent, int cchReferent)
        {
            return ((delegate* unmanaged<INewShortcutHookA*, sbyte*, int, int>)(lpVtbl[4]))((INewShortcutHookA*)Unsafe.AsPointer(ref this), pszReferent, cchReferent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetFolder([NativeTypeName("PCSTR")] sbyte* pcszFolder)
        {
            return ((delegate* unmanaged<INewShortcutHookA*, sbyte*, int>)(lpVtbl[5]))((INewShortcutHookA*)Unsafe.AsPointer(ref this), pcszFolder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetFolder([NativeTypeName("PSTR")] sbyte* pszFolder, int cchFolder)
        {
            return ((delegate* unmanaged<INewShortcutHookA*, sbyte*, int, int>)(lpVtbl[6]))((INewShortcutHookA*)Unsafe.AsPointer(ref this), pszFolder, cchFolder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetName([NativeTypeName("PSTR")] sbyte* pszName, int cchName)
        {
            return ((delegate* unmanaged<INewShortcutHookA*, sbyte*, int, int>)(lpVtbl[7]))((INewShortcutHookA*)Unsafe.AsPointer(ref this), pszName, cchName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetExtension([NativeTypeName("PSTR")] sbyte* pszExtension, int cchExtension)
        {
            return ((delegate* unmanaged<INewShortcutHookA*, sbyte*, int, int>)(lpVtbl[8]))((INewShortcutHookA*)Unsafe.AsPointer(ref this), pszExtension, cchExtension);
        }
    }
}
