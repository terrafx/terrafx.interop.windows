// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4FD67194-1002-4513-BFF2-C0DDF6258552")]
    [NativeTypeName("struct ITfInputProcessorProfileSubstituteLayout : IUnknown")]
    public unsafe partial struct ITfInputProcessorProfileSubstituteLayout
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfInputProcessorProfileSubstituteLayout*, Guid*, void**, int>)(lpVtbl[0]))((ITfInputProcessorProfileSubstituteLayout*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfInputProcessorProfileSubstituteLayout*, uint>)(lpVtbl[1]))((ITfInputProcessorProfileSubstituteLayout*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfInputProcessorProfileSubstituteLayout*, uint>)(lpVtbl[2]))((ITfInputProcessorProfileSubstituteLayout*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSubstituteKeyboardLayout([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const GUID &")] Guid* guidProfile, [NativeTypeName("HKL *")] IntPtr* phKL)
        {
            return ((delegate* unmanaged<ITfInputProcessorProfileSubstituteLayout*, Guid*, ushort, Guid*, IntPtr*, int>)(lpVtbl[3]))((ITfInputProcessorProfileSubstituteLayout*)Unsafe.AsPointer(ref this), rclsid, langid, guidProfile, phKL);
        }
    }
}
