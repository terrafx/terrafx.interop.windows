// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MSAAText.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("03DE00AA-F272-41E3-99CB-03C5E8114EA0")]
    [NativeTypeName("struct ICoCreateLocally : IUnknown")]
    public unsafe partial struct ICoCreateLocally
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ICoCreateLocally*, Guid*, void**, int>)(lpVtbl[0]))((ICoCreateLocally*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICoCreateLocally*, uint>)(lpVtbl[1]))((ICoCreateLocally*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICoCreateLocally*, uint>)(lpVtbl[2]))((ICoCreateLocally*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CoCreateLocally([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("DWORD")] uint dwClsContext, [NativeTypeName("const IID &")] Guid* riid, IUnknown** punk, [NativeTypeName("const IID &")] Guid* riidParam, IUnknown* punkParam, VARIANT varParam)
        {
            return ((delegate* unmanaged<ICoCreateLocally*, Guid*, uint, Guid*, IUnknown**, Guid*, IUnknown*, VARIANT, int>)(lpVtbl[3]))((ICoCreateLocally*)Unsafe.AsPointer(ref this), rclsid, dwClsContext, riid, punk, riidParam, punkParam, varParam);
        }
    }
}
