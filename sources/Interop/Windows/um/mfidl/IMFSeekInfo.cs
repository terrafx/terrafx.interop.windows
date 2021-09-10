// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("26AFEA53-D9ED-42B5-AB80-E64F9EE34779")]
    [NativeTypeName("struct IMFSeekInfo : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFSeekInfo
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFSeekInfo*, Guid*, void**, int>)(lpVtbl[0]))((IMFSeekInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFSeekInfo*, uint>)(lpVtbl[1]))((IMFSeekInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFSeekInfo*, uint>)(lpVtbl[2]))((IMFSeekInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetNearestKeyFrames([NativeTypeName("const GUID *")] Guid* pguidTimeFormat, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarStartPosition, PROPVARIANT* pvarPreviousKeyFrame, PROPVARIANT* pvarNextKeyFrame)
        {
            return ((delegate* unmanaged<IMFSeekInfo*, Guid*, PROPVARIANT*, PROPVARIANT*, PROPVARIANT*, int>)(lpVtbl[3]))((IMFSeekInfo*)Unsafe.AsPointer(ref this), pguidTimeFormat, pvarStartPosition, pvarPreviousKeyFrame, pvarNextKeyFrame);
        }
    }
}
