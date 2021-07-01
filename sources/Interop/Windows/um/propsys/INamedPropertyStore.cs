// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("71604B0F-97B0-4764-8577-2F13E98A1422")]
    [NativeTypeName("struct INamedPropertyStore : IUnknown")]
    public unsafe partial struct INamedPropertyStore
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<INamedPropertyStore*, Guid*, void**, int>)(lpVtbl[0]))((INamedPropertyStore*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<INamedPropertyStore*, uint>)(lpVtbl[1]))((INamedPropertyStore*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<INamedPropertyStore*, uint>)(lpVtbl[2]))((INamedPropertyStore*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetNamedValue([NativeTypeName("LPCWSTR")] ushort* pszName, PROPVARIANT* ppropvar)
        {
            return ((delegate* unmanaged<INamedPropertyStore*, ushort*, PROPVARIANT*, int>)(lpVtbl[3]))((INamedPropertyStore*)Unsafe.AsPointer(ref this), pszName, ppropvar);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetNamedValue([NativeTypeName("LPCWSTR")] ushort* pszName, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar)
        {
            return ((delegate* unmanaged<INamedPropertyStore*, ushort*, PROPVARIANT*, int>)(lpVtbl[4]))((INamedPropertyStore*)Unsafe.AsPointer(ref this), pszName, propvar);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetNameCount([NativeTypeName("DWORD *")] uint* pdwCount)
        {
            return ((delegate* unmanaged<INamedPropertyStore*, uint*, int>)(lpVtbl[5]))((INamedPropertyStore*)Unsafe.AsPointer(ref this), pdwCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetNameAt([NativeTypeName("DWORD")] uint iProp, [NativeTypeName("BSTR *")] ushort** pbstrName)
        {
            return ((delegate* unmanaged<INamedPropertyStore*, uint, ushort**, int>)(lpVtbl[6]))((INamedPropertyStore*)Unsafe.AsPointer(ref this), iProp, pbstrName);
        }
    }
}
