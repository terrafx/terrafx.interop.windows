// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/InkPresenterDesktop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CCDA0A9A-1B78-4632-BB96-97800662E26C")]
    [NativeTypeName("struct IInkHostWorkItem : IUnknown")]
    public unsafe partial struct IInkHostWorkItem
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IInkHostWorkItem*, Guid*, void**, int>)(lpVtbl[0]))((IInkHostWorkItem*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IInkHostWorkItem*, uint>)(lpVtbl[1]))((IInkHostWorkItem*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IInkHostWorkItem*, uint>)(lpVtbl[2]))((IInkHostWorkItem*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke()
        {
            return ((delegate* stdcall<IInkHostWorkItem*, int>)(lpVtbl[3]))((IInkHostWorkItem*)Unsafe.AsPointer(ref this));
        }
    }
}
