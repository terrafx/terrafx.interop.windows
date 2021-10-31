// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct DDOVERLAYFX
    {
        [NativeTypeName("DWORD")]
        public uint dwSize;

        [NativeTypeName("DWORD")]
        public uint dwAlphaEdgeBlendBitDepth;

        [NativeTypeName("DWORD")]
        public uint dwAlphaEdgeBlend;

        [NativeTypeName("DWORD")]
        public uint dwReserved;

        [NativeTypeName("DWORD")]
        public uint dwAlphaDestConstBitDepth;

        [NativeTypeName("_DDOVERLAYFX::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/ddraw.h:775:5)")]
        public _Anonymous1_e__Union Anonymous1;

        [NativeTypeName("DWORD")]
        public uint dwAlphaSrcConstBitDepth;

        [NativeTypeName("_DDOVERLAYFX::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/ddraw.h:781:5)")]
        public _Anonymous2_e__Union Anonymous2;

        public DDCOLORKEY dckDestColorkey;

        public DDCOLORKEY dckSrcColorkey;

        [NativeTypeName("DWORD")]
        public uint dwDDFX;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        public ref uint dwAlphaDestConst
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.dwAlphaDestConst, 1));
            }
        }

        public ref IDirectDrawSurface* lpDDSAlphaDest
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous1.lpDDSAlphaDest;
            }
        }

        public ref uint dwAlphaSrcConst
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.dwAlphaSrcConst, 1));
            }
        }

        public ref IDirectDrawSurface* lpDDSAlphaSrc
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous2.lpDDSAlphaSrc;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous1_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwAlphaDestConst;

            [FieldOffset(0)]
            [NativeTypeName("LPDIRECTDRAWSURFACE")]
            public IDirectDrawSurface* lpDDSAlphaDest;
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous2_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwAlphaSrcConst;

            [FieldOffset(0)]
            [NativeTypeName("LPDIRECTDRAWSURFACE")]
            public IDirectDrawSurface* lpDDSAlphaSrc;
        }
    }
}
