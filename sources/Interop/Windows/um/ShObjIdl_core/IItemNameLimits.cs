// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1DF0D7F1-B267-4D28-8B10-12E23202A5C4")]
    [NativeTypeName("struct IItemNameLimits : IUnknown")]
    public unsafe partial struct IItemNameLimits
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IItemNameLimits*, Guid*, void**, int>)(lpVtbl[0]))((IItemNameLimits*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IItemNameLimits*, uint>)(lpVtbl[1]))((IItemNameLimits*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IItemNameLimits*, uint>)(lpVtbl[2]))((IItemNameLimits*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetValidCharacters([NativeTypeName("LPWSTR *")] ushort** ppwszValidChars, [NativeTypeName("LPWSTR *")] ushort** ppwszInvalidChars)
        {
            return ((delegate* unmanaged<IItemNameLimits*, ushort**, ushort**, int>)(lpVtbl[3]))((IItemNameLimits*)Unsafe.AsPointer(ref this), ppwszValidChars, ppwszInvalidChars);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMaxLength([NativeTypeName("LPCWSTR")] ushort* pszName, int* piMaxNameLen)
        {
            return ((delegate* unmanaged<IItemNameLimits*, ushort*, int*, int>)(lpVtbl[4]))((IItemNameLimits*)Unsafe.AsPointer(ref this), pszName, piMaxNameLen);
        }
    }
}
