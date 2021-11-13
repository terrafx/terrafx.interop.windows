// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from https://docs.microsoft.com/en-us/windows/win32/appxpkg/how-to-programmatically-sign-a-package
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct SIGNER_SUBJECT_INFO
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("DWORD *")]
        public uint* pdwIndex;

        [NativeTypeName("DWORD")]
        public uint dwSubjectChoice;

        [NativeTypeName("_SIGNER_SUBJECT_INFO::(anonymous union at ./mssign32.h:30:9)")]
        public _Anonymous_e__Union Anonymous;

        public ref SIGNER_FILE_INFO* pSignerFileInfo
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.pSignerFileInfo;
            }
        }

        public ref SIGNER_BLOB_INFO* pSignerBlobInfo
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.pSignerBlobInfo;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public SIGNER_FILE_INFO* pSignerFileInfo;

            [FieldOffset(0)]
            public SIGNER_BLOB_INFO* pSignerBlobInfo;
        }
    }
}
