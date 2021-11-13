// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("000001D5-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IProcessLock : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IProcessLock : IProcessLock.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IProcessLock*, Guid*, void**, int>)(lpVtbl[0]))((IProcessLock*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IProcessLock*, uint>)(lpVtbl[1]))((IProcessLock*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IProcessLock*, uint>)(lpVtbl[2]))((IProcessLock*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("ULONG")]
        public uint AddRefOnProcess()
        {
            return ((delegate* unmanaged<IProcessLock*, uint>)(lpVtbl[3]))((IProcessLock*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("ULONG")]
        public uint ReleaseRefOnProcess()
        {
            return ((delegate* unmanaged<IProcessLock*, uint>)(lpVtbl[4]))((IProcessLock*)Unsafe.AsPointer(ref this));
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            [return: NativeTypeName("ULONG")]
            uint AddRefOnProcess();

            [VtblIndex(4)]
            [return: NativeTypeName("ULONG")]
            uint ReleaseRefOnProcess();
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IProcessLock*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IProcessLock*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IProcessLock*, uint> Release;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IProcessLock*, uint> AddRefOnProcess;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IProcessLock*, uint> ReleaseRefOnProcess;
        }
    }
}
