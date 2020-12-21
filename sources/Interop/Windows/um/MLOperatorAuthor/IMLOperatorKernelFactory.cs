// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EF15AD6F-0DC9-4908-AB35-A575A30DFBF8")]
    [NativeTypeName("struct IMLOperatorKernelFactory : IUnknown")]
    public unsafe partial struct IMLOperatorKernelFactory
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IMLOperatorKernelFactory*, Guid*, void**, int>)(lpVtbl[0]))((IMLOperatorKernelFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMLOperatorKernelFactory*, uint>)(lpVtbl[1]))((IMLOperatorKernelFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMLOperatorKernelFactory*, uint>)(lpVtbl[2]))((IMLOperatorKernelFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateKernel([NativeTypeName("IMLOperatorKernelCreationContext *")] IMLOperatorKernelCreationContext* context, [NativeTypeName("IMLOperatorKernel **")] IMLOperatorKernel** kernel)
        {
            return ((delegate* unmanaged<IMLOperatorKernelFactory*, IMLOperatorKernelCreationContext*, IMLOperatorKernel**, int>)(lpVtbl[3]))((IMLOperatorKernelFactory*)Unsafe.AsPointer(ref this), context, kernel);
        }
    }
}
