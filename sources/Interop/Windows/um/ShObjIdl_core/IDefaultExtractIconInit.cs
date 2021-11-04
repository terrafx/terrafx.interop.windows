// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("41DED17D-D6B3-4261-997D-88C60E4B1D58")]
    [NativeTypeName("struct IDefaultExtractIconInit : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDefaultExtractIconInit : IDefaultExtractIconInit.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDefaultExtractIconInit*, Guid*, void**, int>)(lpVtbl[0]))((IDefaultExtractIconInit*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDefaultExtractIconInit*, uint>)(lpVtbl[1]))((IDefaultExtractIconInit*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDefaultExtractIconInit*, uint>)(lpVtbl[2]))((IDefaultExtractIconInit*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetFlags(uint uFlags)
        {
            return ((delegate* unmanaged<IDefaultExtractIconInit*, uint, int>)(lpVtbl[3]))((IDefaultExtractIconInit*)Unsafe.AsPointer(ref this), uFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetKey(HKEY hkey)
        {
            return ((delegate* unmanaged<IDefaultExtractIconInit*, HKEY, int>)(lpVtbl[4]))((IDefaultExtractIconInit*)Unsafe.AsPointer(ref this), hkey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetNormalIcon([NativeTypeName("LPCWSTR")] ushort* pszFile, int iIcon)
        {
            return ((delegate* unmanaged<IDefaultExtractIconInit*, ushort*, int, int>)(lpVtbl[5]))((IDefaultExtractIconInit*)Unsafe.AsPointer(ref this), pszFile, iIcon);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetOpenIcon([NativeTypeName("LPCWSTR")] ushort* pszFile, int iIcon)
        {
            return ((delegate* unmanaged<IDefaultExtractIconInit*, ushort*, int, int>)(lpVtbl[6]))((IDefaultExtractIconInit*)Unsafe.AsPointer(ref this), pszFile, iIcon);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetShortcutIcon([NativeTypeName("LPCWSTR")] ushort* pszFile, int iIcon)
        {
            return ((delegate* unmanaged<IDefaultExtractIconInit*, ushort*, int, int>)(lpVtbl[7]))((IDefaultExtractIconInit*)Unsafe.AsPointer(ref this), pszFile, iIcon);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT SetDefaultIcon([NativeTypeName("LPCWSTR")] ushort* pszFile, int iIcon)
        {
            return ((delegate* unmanaged<IDefaultExtractIconInit*, ushort*, int, int>)(lpVtbl[8]))((IDefaultExtractIconInit*)Unsafe.AsPointer(ref this), pszFile, iIcon);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT SetFlags(uint uFlags);

            [VtblIndex(4)]
            HRESULT SetKey(HKEY hkey);

            [VtblIndex(5)]
            HRESULT SetNormalIcon([NativeTypeName("LPCWSTR")] ushort* pszFile, int iIcon);

            [VtblIndex(6)]
            HRESULT SetOpenIcon([NativeTypeName("LPCWSTR")] ushort* pszFile, int iIcon);

            [VtblIndex(7)]
            HRESULT SetShortcutIcon([NativeTypeName("LPCWSTR")] ushort* pszFile, int iIcon);

            [VtblIndex(8)]
            HRESULT SetDefaultIcon([NativeTypeName("LPCWSTR")] ushort* pszFile, int iIcon);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDefaultExtractIconInit*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDefaultExtractIconInit*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDefaultExtractIconInit*, uint> Release;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<IDefaultExtractIconInit*, uint, int> SetFlags;

            [NativeTypeName("HRESULT (HKEY) __attribute__((stdcall))")]
            public delegate* unmanaged<IDefaultExtractIconInit*, HKEY, int> SetKey;

            [NativeTypeName("HRESULT (LPCWSTR, int) __attribute__((stdcall))")]
            public delegate* unmanaged<IDefaultExtractIconInit*, ushort*, int, int> SetNormalIcon;

            [NativeTypeName("HRESULT (LPCWSTR, int) __attribute__((stdcall))")]
            public delegate* unmanaged<IDefaultExtractIconInit*, ushort*, int, int> SetOpenIcon;

            [NativeTypeName("HRESULT (LPCWSTR, int) __attribute__((stdcall))")]
            public delegate* unmanaged<IDefaultExtractIconInit*, ushort*, int, int> SetShortcutIcon;

            [NativeTypeName("HRESULT (LPCWSTR, int) __attribute__((stdcall))")]
            public delegate* unmanaged<IDefaultExtractIconInit*, ushort*, int, int> SetDefaultIcon;
        }
    }
}
