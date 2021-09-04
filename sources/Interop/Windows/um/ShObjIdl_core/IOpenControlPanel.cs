// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D11AD862-66DE-4DF4-BF6C-1F5621996AF1")]
    [NativeTypeName("struct IOpenControlPanel : IUnknown")]
    public unsafe partial struct IOpenControlPanel
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IOpenControlPanel*, Guid*, void**, int>)(lpVtbl[0]))((IOpenControlPanel*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IOpenControlPanel*, uint>)(lpVtbl[1]))((IOpenControlPanel*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IOpenControlPanel*, uint>)(lpVtbl[2]))((IOpenControlPanel*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Open([NativeTypeName("LPCWSTR")] ushort* pszName, [NativeTypeName("LPCWSTR")] ushort* pszPage, IUnknown* punkSite)
        {
            return ((delegate* unmanaged<IOpenControlPanel*, ushort*, ushort*, IUnknown*, int>)(lpVtbl[3]))((IOpenControlPanel*)Unsafe.AsPointer(ref this), pszName, pszPage, punkSite);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPath([NativeTypeName("LPCWSTR")] ushort* pszName, [NativeTypeName("LPWSTR")] ushort* pszPath, [NativeTypeName("UINT")] uint cchPath)
        {
            return ((delegate* unmanaged<IOpenControlPanel*, ushort*, ushort*, uint, int>)(lpVtbl[4]))((IOpenControlPanel*)Unsafe.AsPointer(ref this), pszName, pszPath, cchPath);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentView(CPVIEW* pView)
        {
            return ((delegate* unmanaged<IOpenControlPanel*, CPVIEW*, int>)(lpVtbl[5]))((IOpenControlPanel*)Unsafe.AsPointer(ref this), pView);
        }
    }
}
