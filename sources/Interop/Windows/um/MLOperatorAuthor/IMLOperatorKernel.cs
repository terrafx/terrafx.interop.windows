// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("11C4B4A0-B467-4EAA-A1A6-B961D8D0ED79")]
    [NativeTypeName("struct IMLOperatorKernel : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMLOperatorKernel
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMLOperatorKernel*, Guid*, void**, int>)(lpVtbl[0]))((IMLOperatorKernel*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMLOperatorKernel*, uint>)(lpVtbl[1]))((IMLOperatorKernel*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMLOperatorKernel*, uint>)(lpVtbl[2]))((IMLOperatorKernel*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Compute(IMLOperatorKernelContext* context)
        {
            return ((delegate* unmanaged<IMLOperatorKernel*, IMLOperatorKernelContext*, int>)(lpVtbl[3]))((IMLOperatorKernel*)Unsafe.AsPointer(ref this), context);
        }
    }
}
