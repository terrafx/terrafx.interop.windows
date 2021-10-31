// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Dimm.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B3458082-BD00-11D1-939B-0060B067B86E")]
    [NativeTypeName("struct IActiveIMMRegistrar : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IActiveIMMRegistrar
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IActiveIMMRegistrar*, Guid*, void**, int>)(lpVtbl[0]))((IActiveIMMRegistrar*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IActiveIMMRegistrar*, uint>)(lpVtbl[1]))((IActiveIMMRegistrar*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IActiveIMMRegistrar*, uint>)(lpVtbl[2]))((IActiveIMMRegistrar*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT RegisterIME([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LANGID")] ushort lgid, [NativeTypeName("LPCWSTR")] ushort* pszIconFile, [NativeTypeName("LPCWSTR")] ushort* pszDesc)
        {
            return ((delegate* unmanaged<IActiveIMMRegistrar*, Guid*, ushort, ushort*, ushort*, int>)(lpVtbl[3]))((IActiveIMMRegistrar*)Unsafe.AsPointer(ref this), rclsid, lgid, pszIconFile, pszDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT UnregisterIME([NativeTypeName("const IID &")] Guid* rclsid)
        {
            return ((delegate* unmanaged<IActiveIMMRegistrar*, Guid*, int>)(lpVtbl[4]))((IActiveIMMRegistrar*)Unsafe.AsPointer(ref this), rclsid);
        }
    }
}
