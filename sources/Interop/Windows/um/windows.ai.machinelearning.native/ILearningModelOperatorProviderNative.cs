// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.ai.machinelearning.native.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1ADAA23A-EB67-41F3-AAD8-5D984E9BACD4")]
    [NativeTypeName("struct ILearningModelOperatorProviderNative : IUnknown")]
    public unsafe partial struct ILearningModelOperatorProviderNative
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<ILearningModelOperatorProviderNative*, Guid*, void**, int>)(lpVtbl[0]))((ILearningModelOperatorProviderNative*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<ILearningModelOperatorProviderNative*, uint>)(lpVtbl[1]))((ILearningModelOperatorProviderNative*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<ILearningModelOperatorProviderNative*, uint>)(lpVtbl[2]))((ILearningModelOperatorProviderNative*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRegistry([NativeTypeName("IMLOperatorRegistry **")] IMLOperatorRegistry** ppOperatorRegistry)
        {
            return ((delegate* unmanaged[Stdcall]<ILearningModelOperatorProviderNative*, IMLOperatorRegistry**, int>)(lpVtbl[3]))((ILearningModelOperatorProviderNative*)Unsafe.AsPointer(ref this), ppOperatorRegistry);
        }
    }
}
