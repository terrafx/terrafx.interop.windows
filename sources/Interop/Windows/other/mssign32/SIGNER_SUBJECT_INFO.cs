// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from https://docs.microsoft.com/en-us/windows/win32/appxpkg/how-to-programmatically-sign-a-package
// Original source is Copyright © Microsoft. All rights reserved. License information available at https://github.com/MicrosoftDocs/win32/blob/docs/LICENSE-CODE

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct SIGNER_SUBJECT_INFO
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("DWORD *")]
        public uint* pdwIndex;

        [NativeTypeName("DWORD")]
        public uint dwSubjectChoice;

        [NativeTypeName("_SIGNER_SUBJECT_INFO::(anonymous union at ./mssign32.h:25:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref SIGNER_FILE_INFO* pSignerFileInfo
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->pSignerFileInfo;
                }
            }
        }

        public ref SIGNER_BLOB_INFO* pSignerBlobInfo
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->pSignerBlobInfo;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("SIGNER_FILE_INFO *")]
            public SIGNER_FILE_INFO* pSignerFileInfo;

            [FieldOffset(0)]
            [NativeTypeName("SIGNER_BLOB_INFO *")]
            public SIGNER_BLOB_INFO* pSignerBlobInfo;
        }
    }
}
