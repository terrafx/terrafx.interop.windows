// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("000214F7-0000-0000-C000-000000000046")]
    [NativeTypeName("struct INewShortcutHookW : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct INewShortcutHookW : INewShortcutHookW.Interface
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
        public HRESULT SetReferent([NativeTypeName("PCWSTR")] ushort* pcszReferent, HWND hwnd)
        {
            return ((delegate* unmanaged<INewShortcutHookW*, ushort*, HWND, int>)(lpVtbl[3]))((INewShortcutHookW*)Unsafe.AsPointer(ref this), pcszReferent, hwnd);
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

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT SetReferent([NativeTypeName("PCWSTR")] ushort* pcszReferent, HWND hwnd);

            [VtblIndex(4)]
            HRESULT GetReferent([NativeTypeName("PWSTR")] ushort* pszReferent, int cchReferent);

            [VtblIndex(5)]
            HRESULT SetFolder([NativeTypeName("PCWSTR")] ushort* pcszFolder);

            [VtblIndex(6)]
            HRESULT GetFolder([NativeTypeName("PWSTR")] ushort* pszFolder, int cchFolder);

            [VtblIndex(7)]
            HRESULT GetName([NativeTypeName("PWSTR")] ushort* pszName, int cchName);

            [VtblIndex(8)]
            HRESULT GetExtension([NativeTypeName("PWSTR")] ushort* pszExtension, int cchExtension);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<INewShortcutHookW*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<INewShortcutHookW*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<INewShortcutHookW*, uint> Release;

            [NativeTypeName("HRESULT (PCWSTR, HWND) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<INewShortcutHookW*, ushort*, HWND, int> SetReferent;

            [NativeTypeName("HRESULT (PWSTR, int) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<INewShortcutHookW*, ushort*, int, int> GetReferent;

            [NativeTypeName("HRESULT (PCWSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<INewShortcutHookW*, ushort*, int> SetFolder;

            [NativeTypeName("HRESULT (PWSTR, int) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<INewShortcutHookW*, ushort*, int, int> GetFolder;

            [NativeTypeName("HRESULT (PWSTR, int) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<INewShortcutHookW*, ushort*, int, int> GetName;

            [NativeTypeName("HRESULT (PWSTR, int) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<INewShortcutHookW*, ushort*, int, int> GetExtension;
        }
    }
}
