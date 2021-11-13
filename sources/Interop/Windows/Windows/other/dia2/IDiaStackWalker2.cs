// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("7C185885-A015-4CAC-9411-0F4FB39B1F3A")]
    [NativeTypeName("struct IDiaStackWalker2 : IDiaStackWalker")]
    [NativeInheritance("IDiaStackWalker")]
    public unsafe partial struct IDiaStackWalker2 : IDiaStackWalker2.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDiaStackWalker2*, Guid*, void**, int>)(lpVtbl[0]))((IDiaStackWalker2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDiaStackWalker2*, uint>)(lpVtbl[1]))((IDiaStackWalker2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDiaStackWalker2*, uint>)(lpVtbl[2]))((IDiaStackWalker2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT getEnumFrames(IDiaStackWalkHelper* pHelper, IDiaEnumStackFrames** ppEnum)
        {
            return ((delegate* unmanaged<IDiaStackWalker2*, IDiaStackWalkHelper*, IDiaEnumStackFrames**, int>)(lpVtbl[3]))((IDiaStackWalker2*)Unsafe.AsPointer(ref this), pHelper, ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT getEnumFrames2([NativeTypeName("enum CV_CPU_TYPE_e")] CV_CPU_TYPE_e cpuid, IDiaStackWalkHelper* pHelper, IDiaEnumStackFrames** ppEnum)
        {
            return ((delegate* unmanaged<IDiaStackWalker2*, CV_CPU_TYPE_e, IDiaStackWalkHelper*, IDiaEnumStackFrames**, int>)(lpVtbl[4]))((IDiaStackWalker2*)Unsafe.AsPointer(ref this), cpuid, pHelper, ppEnum);
        }

        public interface Interface : IDiaStackWalker.Interface
        {
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaStackWalker2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaStackWalker2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaStackWalker2*, uint> Release;

            [NativeTypeName("HRESULT (IDiaStackWalkHelper *, IDiaEnumStackFrames **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaStackWalker2*, IDiaStackWalkHelper*, IDiaEnumStackFrames**, int> getEnumFrames;

            [NativeTypeName("HRESULT (enum CV_CPU_TYPE_e, IDiaStackWalkHelper *, IDiaEnumStackFrames **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaStackWalker2*, CV_CPU_TYPE_e, IDiaStackWalkHelper*, IDiaEnumStackFrames**, int> getEnumFrames2;
        }
    }
}
