// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FCE4BDE0-4B68-4B80-8E9C-7426315A7388")]
    [NativeTypeName("struct IShellRunDll : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IShellRunDll
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IShellRunDll*, Guid*, void**, int>)(lpVtbl[0]))((IShellRunDll*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IShellRunDll*, uint>)(lpVtbl[1]))((IShellRunDll*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IShellRunDll*, uint>)(lpVtbl[2]))((IShellRunDll*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Run([NativeTypeName("LPCWSTR")] ushort* pszArgs)
        {
            return ((delegate* unmanaged<IShellRunDll*, ushort*, int>)(lpVtbl[3]))((IShellRunDll*)Unsafe.AsPointer(ref this), pszArgs);
        }
    }
}
