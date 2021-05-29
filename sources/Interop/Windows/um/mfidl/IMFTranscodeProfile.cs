// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4ADFDBA3-7AB0-4953-A62B-461E7FF3DA1E")]
    [NativeTypeName("struct IMFTranscodeProfile : IUnknown")]
    public unsafe partial struct IMFTranscodeProfile
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFTranscodeProfile*, Guid*, void**, int>)(lpVtbl[0]))((IMFTranscodeProfile*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFTranscodeProfile*, uint>)(lpVtbl[1]))((IMFTranscodeProfile*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFTranscodeProfile*, uint>)(lpVtbl[2]))((IMFTranscodeProfile*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAudioAttributes(IMFAttributes* pAttrs)
        {
            return ((delegate* unmanaged<IMFTranscodeProfile*, IMFAttributes*, int>)(lpVtbl[3]))((IMFTranscodeProfile*)Unsafe.AsPointer(ref this), pAttrs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAudioAttributes(IMFAttributes** ppAttrs)
        {
            return ((delegate* unmanaged<IMFTranscodeProfile*, IMFAttributes**, int>)(lpVtbl[4]))((IMFTranscodeProfile*)Unsafe.AsPointer(ref this), ppAttrs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetVideoAttributes(IMFAttributes* pAttrs)
        {
            return ((delegate* unmanaged<IMFTranscodeProfile*, IMFAttributes*, int>)(lpVtbl[5]))((IMFTranscodeProfile*)Unsafe.AsPointer(ref this), pAttrs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVideoAttributes(IMFAttributes** ppAttrs)
        {
            return ((delegate* unmanaged<IMFTranscodeProfile*, IMFAttributes**, int>)(lpVtbl[6]))((IMFTranscodeProfile*)Unsafe.AsPointer(ref this), ppAttrs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetContainerAttributes(IMFAttributes* pAttrs)
        {
            return ((delegate* unmanaged<IMFTranscodeProfile*, IMFAttributes*, int>)(lpVtbl[7]))((IMFTranscodeProfile*)Unsafe.AsPointer(ref this), pAttrs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetContainerAttributes(IMFAttributes** ppAttrs)
        {
            return ((delegate* unmanaged<IMFTranscodeProfile*, IMFAttributes**, int>)(lpVtbl[8]))((IMFTranscodeProfile*)Unsafe.AsPointer(ref this), ppAttrs);
        }
    }
}
