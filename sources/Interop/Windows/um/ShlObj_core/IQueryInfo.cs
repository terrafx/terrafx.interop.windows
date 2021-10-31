// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00021500-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IQueryInfo : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IQueryInfo
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IQueryInfo*, Guid*, void**, int>)(lpVtbl[0]))((IQueryInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IQueryInfo*, uint>)(lpVtbl[1]))((IQueryInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IQueryInfo*, uint>)(lpVtbl[2]))((IQueryInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetInfoTip([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PWSTR *")] ushort** ppwszTip)
        {
            return ((delegate* unmanaged<IQueryInfo*, uint, ushort**, int>)(lpVtbl[3]))((IQueryInfo*)Unsafe.AsPointer(ref this), dwFlags, ppwszTip);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetInfoFlags([NativeTypeName("DWORD *")] uint* pdwFlags)
        {
            return ((delegate* unmanaged<IQueryInfo*, uint*, int>)(lpVtbl[4]))((IQueryInfo*)Unsafe.AsPointer(ref this), pdwFlags);
        }
    }
}
