// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("71C6E74D-0F28-11D8-A82A-00065B84435C")]
    [NativeTypeName("struct IEnumTfInputProcessorProfiles : IUnknown")]
    public unsafe partial struct IEnumTfInputProcessorProfiles
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IEnumTfInputProcessorProfiles*, Guid*, void**, int>)(lpVtbl[0]))((IEnumTfInputProcessorProfiles*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEnumTfInputProcessorProfiles*, uint>)(lpVtbl[1]))((IEnumTfInputProcessorProfiles*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEnumTfInputProcessorProfiles*, uint>)(lpVtbl[2]))((IEnumTfInputProcessorProfiles*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Clone(IEnumTfInputProcessorProfiles** ppEnum)
        {
            return ((delegate* unmanaged<IEnumTfInputProcessorProfiles*, IEnumTfInputProcessorProfiles**, int>)(lpVtbl[3]))((IEnumTfInputProcessorProfiles*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint ulCount, TF_INPUTPROCESSORPROFILE* pProfile, [NativeTypeName("ULONG *")] uint* pcFetch)
        {
            return ((delegate* unmanaged<IEnumTfInputProcessorProfiles*, uint, TF_INPUTPROCESSORPROFILE*, uint*, int>)(lpVtbl[4]))((IEnumTfInputProcessorProfiles*)Unsafe.AsPointer(ref this), ulCount, pProfile, pcFetch);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged<IEnumTfInputProcessorProfiles*, int>)(lpVtbl[5]))((IEnumTfInputProcessorProfiles*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint ulCount)
        {
            return ((delegate* unmanaged<IEnumTfInputProcessorProfiles*, uint, int>)(lpVtbl[6]))((IEnumTfInputProcessorProfiles*)Unsafe.AsPointer(ref this), ulCount);
        }
    }
}
