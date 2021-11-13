// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("EF15AD6F-0DC9-4908-AB35-A575A30DFBF8")]
    [NativeTypeName("struct IMLOperatorKernelFactory : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMLOperatorKernelFactory : IMLOperatorKernelFactory.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMLOperatorKernelFactory*, Guid*, void**, int>)(lpVtbl[0]))((IMLOperatorKernelFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMLOperatorKernelFactory*, uint>)(lpVtbl[1]))((IMLOperatorKernelFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMLOperatorKernelFactory*, uint>)(lpVtbl[2]))((IMLOperatorKernelFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT CreateKernel(IMLOperatorKernelCreationContext* context, IMLOperatorKernel** kernel)
        {
            return ((delegate* unmanaged<IMLOperatorKernelFactory*, IMLOperatorKernelCreationContext*, IMLOperatorKernel**, int>)(lpVtbl[3]))((IMLOperatorKernelFactory*)Unsafe.AsPointer(ref this), context, kernel);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT CreateKernel(IMLOperatorKernelCreationContext* context, IMLOperatorKernel** kernel);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMLOperatorKernelFactory*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMLOperatorKernelFactory*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMLOperatorKernelFactory*, uint> Release;

            [NativeTypeName("HRESULT (IMLOperatorKernelCreationContext *, IMLOperatorKernel **) noexcept __attribute__((stdcall))")]
            public delegate* unmanaged<IMLOperatorKernelFactory*, IMLOperatorKernelCreationContext*, IMLOperatorKernel**, int> CreateKernel;
        }
    }
}
