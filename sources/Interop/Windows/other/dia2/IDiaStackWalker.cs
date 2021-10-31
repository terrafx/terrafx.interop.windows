// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5485216B-A54C-469F-9670-52B24D5229BB")]
    [NativeTypeName("struct IDiaStackWalker : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDiaStackWalker
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDiaStackWalker*, Guid*, void**, int>)(lpVtbl[0]))((IDiaStackWalker*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDiaStackWalker*, uint>)(lpVtbl[1]))((IDiaStackWalker*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDiaStackWalker*, uint>)(lpVtbl[2]))((IDiaStackWalker*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT getEnumFrames(IDiaStackWalkHelper* pHelper, IDiaEnumStackFrames** ppEnum)
        {
            return ((delegate* unmanaged<IDiaStackWalker*, IDiaStackWalkHelper*, IDiaEnumStackFrames**, int>)(lpVtbl[3]))((IDiaStackWalker*)Unsafe.AsPointer(ref this), pHelper, ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT getEnumFrames2([NativeTypeName("enum CV_CPU_TYPE_e")] CV_CPU_TYPE_e cpuid, IDiaStackWalkHelper* pHelper, IDiaEnumStackFrames** ppEnum)
        {
            return ((delegate* unmanaged<IDiaStackWalker*, CV_CPU_TYPE_e, IDiaStackWalkHelper*, IDiaEnumStackFrames**, int>)(lpVtbl[4]))((IDiaStackWalker*)Unsafe.AsPointer(ref this), cpuid, pHelper, ppEnum);
        }
    }
}
