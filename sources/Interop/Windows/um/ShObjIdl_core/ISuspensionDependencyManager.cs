// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("52B83A42-2543-416A-81D9-C0DE7969C8B3")]
    [NativeTypeName("struct ISuspensionDependencyManager : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISuspensionDependencyManager
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISuspensionDependencyManager*, Guid*, void**, int>)(lpVtbl[0]))((ISuspensionDependencyManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISuspensionDependencyManager*, uint>)(lpVtbl[1]))((ISuspensionDependencyManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISuspensionDependencyManager*, uint>)(lpVtbl[2]))((ISuspensionDependencyManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT RegisterAsChild(HANDLE processHandle)
        {
            return ((delegate* unmanaged<ISuspensionDependencyManager*, HANDLE, int>)(lpVtbl[3]))((ISuspensionDependencyManager*)Unsafe.AsPointer(ref this), processHandle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GroupChildWithParent(HANDLE childProcessHandle)
        {
            return ((delegate* unmanaged<ISuspensionDependencyManager*, HANDLE, int>)(lpVtbl[4]))((ISuspensionDependencyManager*)Unsafe.AsPointer(ref this), childProcessHandle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT UngroupChildFromParent(HANDLE childProcessHandle)
        {
            return ((delegate* unmanaged<ISuspensionDependencyManager*, HANDLE, int>)(lpVtbl[5]))((ISuspensionDependencyManager*)Unsafe.AsPointer(ref this), childProcessHandle);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISuspensionDependencyManager*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISuspensionDependencyManager*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISuspensionDependencyManager*, uint> Release;

            [NativeTypeName("HRESULT (HANDLE) __attribute__((stdcall))")]
            public delegate* unmanaged<ISuspensionDependencyManager*, HANDLE, int> RegisterAsChild;

            [NativeTypeName("HRESULT (HANDLE) __attribute__((stdcall))")]
            public delegate* unmanaged<ISuspensionDependencyManager*, HANDLE, int> GroupChildWithParent;

            [NativeTypeName("HRESULT (HANDLE) __attribute__((stdcall))")]
            public delegate* unmanaged<ISuspensionDependencyManager*, HANDLE, int> UngroupChildFromParent;
        }
    }
}
