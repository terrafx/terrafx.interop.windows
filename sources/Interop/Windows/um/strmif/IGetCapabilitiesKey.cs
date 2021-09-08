// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A8809222-07BB-48EA-951C-33158100625B")]
    [NativeTypeName("struct IGetCapabilitiesKey : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IGetCapabilitiesKey
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IGetCapabilitiesKey*, Guid*, void**, int>)(lpVtbl[0]))((IGetCapabilitiesKey*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IGetCapabilitiesKey*, uint>)(lpVtbl[1]))((IGetCapabilitiesKey*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IGetCapabilitiesKey*, uint>)(lpVtbl[2]))((IGetCapabilitiesKey*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetCapabilitiesKey([NativeTypeName("HKEY *")] IntPtr* pHKey)
        {
            return ((delegate* unmanaged<IGetCapabilitiesKey*, IntPtr*, int>)(lpVtbl[3]))((IGetCapabilitiesKey*)Unsafe.AsPointer(ref this), pHKey);
        }
    }
}
