// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplusmetaheader.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.MetafileType;

namespace TerraFX.Interop
{
    public partial struct MetafileHeader
    {
        [NativeTypeName("Gdiplus::MetafileType")]
        public MetafileType Type;

        [NativeTypeName("UINT")]
        public uint Size;

        [NativeTypeName("UINT")]
        public uint Version;

        [NativeTypeName("UINT")]
        public uint EmfPlusFlags;

        [NativeTypeName("Gdiplus::REAL")]
        public float DpiX;

        [NativeTypeName("Gdiplus::REAL")]
        public float DpiY;

        [NativeTypeName("INT")]
        public int X;

        [NativeTypeName("INT")]
        public int Y;

        [NativeTypeName("INT")]
        public int Width;

        [NativeTypeName("INT")]
        public int Height;

        [NativeTypeName("Gdiplus::MetafileHeader::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/GdiplusMetaHeader.h:129:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref METAHEADER WmfHeader
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.WmfHeader, 1));
            }
        }

        public ref ENHMETAHEADER3 EmfHeader
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.EmfHeader, 1));
            }
        }

        [NativeTypeName("INT")]
        public int EmfPlusHeaderSize;

        [NativeTypeName("INT")]
        public int LogicalDpiX;

        [NativeTypeName("INT")]
        public int LogicalDpiY;

        [return: NativeTypeName("Gdiplus::MetafileType")]
        public new MetafileType GetType()
        {
            return Type;
        }

        [return: NativeTypeName("UINT")]
        public uint GetMetafileSize()
        {
            return Size;
        }

        [return: NativeTypeName("UINT")]
        public uint GetVersion()
        {
            return Version;
        }

        [return: NativeTypeName("UINT")]
        public uint GetEmfPlusFlags()
        {
            return EmfPlusFlags;
        }

        [return: NativeTypeName("Gdiplus::REAL")]
        public float GetDpiX()
        {
            return DpiX;
        }

        [return: NativeTypeName("Gdiplus::REAL")]
        public float GetDpiY()
        {
            return DpiY;
        }

        public unsafe void GetBounds([NativeTypeName("Gdiplus::Rect *")] Rect* rect)
        {
            rect->X = X;
            rect->Y = Y;
            rect->Width = Width;
            rect->Height = Height;
        }

        [return: NativeTypeName("BOOL")]
        public int IsWmf()
        {
            return ((Type == MetafileTypeWmf) || (Type == MetafileTypeWmfPlaceable)) ? 1 : 0;
        }

        [return: NativeTypeName("BOOL")]
        public int IsWmfPlaceable()
        {
            return (Type == MetafileTypeWmfPlaceable) ? 1 : 0;
        }

        [return: NativeTypeName("BOOL")]
        public int IsEmf()
        {
            return (Type == MetafileTypeEmf) ? 1 : 0;
        }

        [return: NativeTypeName("BOOL")]
        public int IsEmfOrEmfPlus()
        {
            return (Type >= (MetafileTypeEmf)) ? 1 : 0;
        }

        [return: NativeTypeName("BOOL")]
        public int IsEmfPlus()
        {
            return (Type >= (MetafileTypeEmfPlusOnly)) ? 1 : 0;
        }

        [return: NativeTypeName("BOOL")]
        public int IsEmfPlusDual()
        {
            return (Type == MetafileTypeEmfPlusDual) ? 1 : 0;
        }

        [return: NativeTypeName("BOOL")]
        public int IsEmfPlusOnly()
        {
            return (Type == MetafileTypeEmfPlusOnly) ? 1 : 0;
        }

        [return: NativeTypeName("BOOL")]
        public int IsDisplay()
        {
            return ((IsEmfPlus()) != 0 && ((EmfPlusFlags & 0x00000001) != 0)) ? 1 : 0;
        }

        [return: NativeTypeName("const METAHEADER *")]
        public unsafe METAHEADER* GetWmfHeader()
        {
            if ((IsWmf()) != 0)
            {
                return (METAHEADER*)Unsafe.AsPointer(ref Anonymous.WmfHeader);
            }

            return null;
        }

        [return: NativeTypeName("const Gdiplus::ENHMETAHEADER3 *")]
        public unsafe ENHMETAHEADER3* GetEmfHeader()
        {
            if ((IsEmfOrEmfPlus()) != 0)
            {
                return (ENHMETAHEADER3*)Unsafe.AsPointer(ref Anonymous.EmfHeader);
            }

            return null;
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public METAHEADER WmfHeader;

            [FieldOffset(0)]
            [NativeTypeName("Gdiplus::ENHMETAHEADER3")]
            public ENHMETAHEADER3 EmfHeader;
        }
    }
}
