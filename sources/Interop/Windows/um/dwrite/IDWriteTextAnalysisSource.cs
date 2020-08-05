// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("688E1A58-5094-47C8-ADC8-FBCEA60AE92B")]
    [NativeTypeName("struct IDWriteTextAnalysisSource : IUnknown")]
    public unsafe partial struct IDWriteTextAnalysisSource
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDWriteTextAnalysisSource*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteTextAnalysisSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDWriteTextAnalysisSource*, uint>)(lpVtbl[1]))((IDWriteTextAnalysisSource*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDWriteTextAnalysisSource*, uint>)(lpVtbl[2]))((IDWriteTextAnalysisSource*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTextAtPosition([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("const WCHAR **")] ushort** textString, [NativeTypeName("UINT32 *")] uint* textLength)
        {
            return ((delegate* stdcall<IDWriteTextAnalysisSource*, uint, ushort**, uint*, int>)(lpVtbl[3]))((IDWriteTextAnalysisSource*)Unsafe.AsPointer(ref this), textPosition, textString, textLength);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTextBeforePosition([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("const WCHAR **")] ushort** textString, [NativeTypeName("UINT32 *")] uint* textLength)
        {
            return ((delegate* stdcall<IDWriteTextAnalysisSource*, uint, ushort**, uint*, int>)(lpVtbl[4]))((IDWriteTextAnalysisSource*)Unsafe.AsPointer(ref this), textPosition, textString, textLength);
        }

        public DWRITE_READING_DIRECTION GetParagraphReadingDirection()
        {
            return ((delegate* stdcall<IDWriteTextAnalysisSource*, DWRITE_READING_DIRECTION>)(lpVtbl[5]))((IDWriteTextAnalysisSource*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLocaleName([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32 *")] uint* textLength, [NativeTypeName("const WCHAR **")] ushort** localeName)
        {
            return ((delegate* stdcall<IDWriteTextAnalysisSource*, uint, uint*, ushort**, int>)(lpVtbl[6]))((IDWriteTextAnalysisSource*)Unsafe.AsPointer(ref this), textPosition, textLength, localeName);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetNumberSubstitution([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32 *")] uint* textLength, [NativeTypeName("IDWriteNumberSubstitution **")] IDWriteNumberSubstitution** numberSubstitution)
        {
            return ((delegate* stdcall<IDWriteTextAnalysisSource*, uint, uint*, IDWriteNumberSubstitution**, int>)(lpVtbl[7]))((IDWriteTextAnalysisSource*)Unsafe.AsPointer(ref this), textPosition, textLength, numberSubstitution);
        }
    }
}
