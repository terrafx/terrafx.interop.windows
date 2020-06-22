// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E13AF3C1-4D47-4354-B1F5-E83AE0ECAE60")]
    public unsafe partial struct IMFTimedTextFormattedText
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFTimedTextFormattedText*, Guid*, void**, int>)(lpVtbl[0]))((IMFTimedTextFormattedText*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFTimedTextFormattedText*, uint>)(lpVtbl[1]))((IMFTimedTextFormattedText*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFTimedTextFormattedText*, uint>)(lpVtbl[2]))((IMFTimedTextFormattedText*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetText([NativeTypeName("LPWSTR *")] ushort** text)
        {
            return ((delegate* stdcall<IMFTimedTextFormattedText*, ushort**, int>)(lpVtbl[3]))((IMFTimedTextFormattedText*)Unsafe.AsPointer(ref this), text);
        }

        [return: NativeTypeName("DWORD")]
        public uint GetSubformattingCount()
        {
            return ((delegate* stdcall<IMFTimedTextFormattedText*, uint>)(lpVtbl[4]))((IMFTimedTextFormattedText*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSubformatting([NativeTypeName("DWORD")] uint index, [NativeTypeName("DWORD *")] uint* firstChar, [NativeTypeName("DWORD *")] uint* charLength, [NativeTypeName("IMFTimedTextStyle **")] IMFTimedTextStyle** style)
        {
            return ((delegate* stdcall<IMFTimedTextFormattedText*, uint, uint*, uint*, IMFTimedTextStyle**, int>)(lpVtbl[5]))((IMFTimedTextFormattedText*)Unsafe.AsPointer(ref this), index, firstChar, charLength, style);
        }
    }
}
