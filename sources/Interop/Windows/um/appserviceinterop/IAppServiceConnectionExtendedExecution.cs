// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/appserviceinterop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("65219584-F9CB-4AE3-81F9-A28A6CA450D9")]
    [NativeTypeName("struct IAppServiceConnectionExtendedExecution : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAppServiceConnectionExtendedExecution
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppServiceConnectionExtendedExecution*, Guid*, void**, int>)(lpVtbl[0]))((IAppServiceConnectionExtendedExecution*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppServiceConnectionExtendedExecution*, uint>)(lpVtbl[1]))((IAppServiceConnectionExtendedExecution*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppServiceConnectionExtendedExecution*, uint>)(lpVtbl[2]))((IAppServiceConnectionExtendedExecution*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT OpenForExtendedExecutionAsync([NativeTypeName("const IID &")] Guid* riid, void** operation)
        {
            return ((delegate* unmanaged<IAppServiceConnectionExtendedExecution*, Guid*, void**, int>)(lpVtbl[3]))((IAppServiceConnectionExtendedExecution*)Unsafe.AsPointer(ref this), riid, operation);
        }
    }
}
