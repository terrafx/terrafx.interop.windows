// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F0EE7333-E6FC-479B-9F25-A860C234A38E")]
    [NativeTypeName("struct IOpenSearchSource : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IOpenSearchSource
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IOpenSearchSource*, Guid*, void**, int>)(lpVtbl[0]))((IOpenSearchSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IOpenSearchSource*, uint>)(lpVtbl[1]))((IOpenSearchSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IOpenSearchSource*, uint>)(lpVtbl[2]))((IOpenSearchSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetResults([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("LPCWSTR")] ushort* pszQuery, [NativeTypeName("DWORD")] uint dwStartIndex, [NativeTypeName("DWORD")] uint dwCount, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IOpenSearchSource*, IntPtr, ushort*, uint, uint, Guid*, void**, int>)(lpVtbl[3]))((IOpenSearchSource*)Unsafe.AsPointer(ref this), hwnd, pszQuery, dwStartIndex, dwCount, riid, ppv);
        }
    }
}
