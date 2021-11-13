// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("D11AD862-66DE-4DF4-BF6C-1F5621996AF1")]
    [NativeTypeName("struct IOpenControlPanel : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IOpenControlPanel : IOpenControlPanel.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IOpenControlPanel*, Guid*, void**, int>)(lpVtbl[0]))((IOpenControlPanel*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IOpenControlPanel*, uint>)(lpVtbl[1]))((IOpenControlPanel*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IOpenControlPanel*, uint>)(lpVtbl[2]))((IOpenControlPanel*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Open([NativeTypeName("LPCWSTR")] ushort* pszName, [NativeTypeName("LPCWSTR")] ushort* pszPage, IUnknown* punkSite)
        {
            return ((delegate* unmanaged<IOpenControlPanel*, ushort*, ushort*, IUnknown*, int>)(lpVtbl[3]))((IOpenControlPanel*)Unsafe.AsPointer(ref this), pszName, pszPage, punkSite);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetPath([NativeTypeName("LPCWSTR")] ushort* pszName, [NativeTypeName("LPWSTR")] ushort* pszPath, uint cchPath)
        {
            return ((delegate* unmanaged<IOpenControlPanel*, ushort*, ushort*, uint, int>)(lpVtbl[4]))((IOpenControlPanel*)Unsafe.AsPointer(ref this), pszName, pszPath, cchPath);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetCurrentView(CPVIEW* pView)
        {
            return ((delegate* unmanaged<IOpenControlPanel*, CPVIEW*, int>)(lpVtbl[5]))((IOpenControlPanel*)Unsafe.AsPointer(ref this), pView);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT Open([NativeTypeName("LPCWSTR")] ushort* pszName, [NativeTypeName("LPCWSTR")] ushort* pszPage, IUnknown* punkSite);

            [VtblIndex(4)]
            HRESULT GetPath([NativeTypeName("LPCWSTR")] ushort* pszName, [NativeTypeName("LPWSTR")] ushort* pszPath, uint cchPath);

            [VtblIndex(5)]
            HRESULT GetCurrentView(CPVIEW* pView);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IOpenControlPanel*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IOpenControlPanel*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IOpenControlPanel*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, IUnknown *) __attribute__((stdcall))")]
            public delegate* unmanaged<IOpenControlPanel*, ushort*, ushort*, IUnknown*, int> Open;

            [NativeTypeName("HRESULT (LPCWSTR, LPWSTR, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<IOpenControlPanel*, ushort*, ushort*, uint, int> GetPath;

            [NativeTypeName("HRESULT (CPVIEW *) __attribute__((stdcall))")]
            public delegate* unmanaged<IOpenControlPanel*, CPVIEW*, int> GetCurrentView;
        }
    }
}
