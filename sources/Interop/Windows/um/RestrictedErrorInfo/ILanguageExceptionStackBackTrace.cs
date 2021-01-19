// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/RestrictedErrorInfo.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CBE53FB5-F967-4258-8D34-42F5E25833DE")]
    [NativeTypeName("struct ILanguageExceptionStackBackTrace : IUnknown")]
    public unsafe partial struct ILanguageExceptionStackBackTrace
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ILanguageExceptionStackBackTrace*, Guid*, void**, int>)(lpVtbl[0]))((ILanguageExceptionStackBackTrace*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ILanguageExceptionStackBackTrace*, uint>)(lpVtbl[1]))((ILanguageExceptionStackBackTrace*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ILanguageExceptionStackBackTrace*, uint>)(lpVtbl[2]))((ILanguageExceptionStackBackTrace*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStackBackTrace([NativeTypeName("ULONG")] uint maxFramesToCapture, [NativeTypeName("UINT_PTR []")] nuint* stackBackTrace, [NativeTypeName("ULONG *")] uint* framesCaptured)
        {
            return ((delegate* unmanaged<ILanguageExceptionStackBackTrace*, uint, nuint*, uint*, int>)(lpVtbl[3]))((ILanguageExceptionStackBackTrace*)Unsafe.AsPointer(ref this), maxFramesToCapture, stackBackTrace, framesCaptured);
        }
    }
}
