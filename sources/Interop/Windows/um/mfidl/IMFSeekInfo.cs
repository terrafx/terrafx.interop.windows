// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("26AFEA53-D9ED-42B5-AB80-E64F9EE34779")]
    [NativeTypeName("struct IMFSeekInfo : IUnknown")]
    public unsafe partial struct IMFSeekInfo
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFSeekInfo*, Guid*, void**, int>)(lpVtbl[0]))((IMFSeekInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFSeekInfo*, uint>)(lpVtbl[1]))((IMFSeekInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFSeekInfo*, uint>)(lpVtbl[2]))((IMFSeekInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetNearestKeyFrames([NativeTypeName("const GUID *")] Guid* pguidTimeFormat, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarStartPosition, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pvarPreviousKeyFrame, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pvarNextKeyFrame)
        {
            return ((delegate* stdcall<IMFSeekInfo*, Guid*, PROPVARIANT*, PROPVARIANT*, PROPVARIANT*, int>)(lpVtbl[3]))((IMFSeekInfo*)Unsafe.AsPointer(ref this), pguidTimeFormat, pvarStartPosition, pvarPreviousKeyFrame, pvarNextKeyFrame);
        }
    }
}
