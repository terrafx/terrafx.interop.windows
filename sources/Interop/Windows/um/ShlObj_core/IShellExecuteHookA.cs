// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("000214F5-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IShellExecuteHookA : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IShellExecuteHookA
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IShellExecuteHookA*, Guid*, void**, int>)(lpVtbl[0]))((IShellExecuteHookA*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IShellExecuteHookA*, uint>)(lpVtbl[1]))((IShellExecuteHookA*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IShellExecuteHookA*, uint>)(lpVtbl[2]))((IShellExecuteHookA*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Execute([NativeTypeName("LPSHELLEXECUTEINFOA")] void* pei)
        {
            return ((delegate* unmanaged<IShellExecuteHookA*, void*, int>)(lpVtbl[3]))((IShellExecuteHookA*)Unsafe.AsPointer(ref this), pei);
        }
    }
}
