// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("000214F7-0000-0000-C000-000000000046")]
    [NativeTypeName("struct INewShortcutHookW : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct INewShortcutHookW
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<INewShortcutHookW*, Guid*, void**, int>)(lpVtbl[0]))((INewShortcutHookW*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<INewShortcutHookW*, uint>)(lpVtbl[1]))((INewShortcutHookW*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<INewShortcutHookW*, uint>)(lpVtbl[2]))((INewShortcutHookW*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetReferent([NativeTypeName("PCWSTR")] ushort* pcszReferent, [NativeTypeName("HWND")] IntPtr hwnd)
        {
            return ((delegate* unmanaged<INewShortcutHookW*, ushort*, IntPtr, int>)(lpVtbl[3]))((INewShortcutHookW*)Unsafe.AsPointer(ref this), pcszReferent, hwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetReferent([NativeTypeName("PWSTR")] ushort* pszReferent, int cchReferent)
        {
            return ((delegate* unmanaged<INewShortcutHookW*, ushort*, int, int>)(lpVtbl[4]))((INewShortcutHookW*)Unsafe.AsPointer(ref this), pszReferent, cchReferent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetFolder([NativeTypeName("PCWSTR")] ushort* pcszFolder)
        {
            return ((delegate* unmanaged<INewShortcutHookW*, ushort*, int>)(lpVtbl[5]))((INewShortcutHookW*)Unsafe.AsPointer(ref this), pcszFolder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetFolder([NativeTypeName("PWSTR")] ushort* pszFolder, int cchFolder)
        {
            return ((delegate* unmanaged<INewShortcutHookW*, ushort*, int, int>)(lpVtbl[6]))((INewShortcutHookW*)Unsafe.AsPointer(ref this), pszFolder, cchFolder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetName([NativeTypeName("PWSTR")] ushort* pszName, int cchName)
        {
            return ((delegate* unmanaged<INewShortcutHookW*, ushort*, int, int>)(lpVtbl[7]))((INewShortcutHookW*)Unsafe.AsPointer(ref this), pszName, cchName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetExtension([NativeTypeName("PWSTR")] ushort* pszExtension, int cchExtension)
        {
            return ((delegate* unmanaged<INewShortcutHookW*, ushort*, int, int>)(lpVtbl[8]))((INewShortcutHookW*)Unsafe.AsPointer(ref this), pszExtension, cchExtension);
        }
    }
}
