// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.data.xml.dom.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='NodeType.xml' path='doc/member[@name="NodeType"]/*' />
public enum NodeType
{
    /// <include file='NodeType.xml' path='doc/member[@name="NodeType.NodeType_Invalid"]/*' />
    NodeType_Invalid = 0,

    /// <include file='NodeType.xml' path='doc/member[@name="NodeType.NodeType_ElementNode"]/*' />
    NodeType_ElementNode = 1,

    /// <include file='NodeType.xml' path='doc/member[@name="NodeType.NodeType_AttributeNode"]/*' />
    NodeType_AttributeNode = 2,

    /// <include file='NodeType.xml' path='doc/member[@name="NodeType.NodeType_TextNode"]/*' />
    NodeType_TextNode = 3,

    /// <include file='NodeType.xml' path='doc/member[@name="NodeType.NodeType_DataSectionNode"]/*' />
    NodeType_DataSectionNode = 4,

    /// <include file='NodeType.xml' path='doc/member[@name="NodeType.NodeType_EntityReferenceNode"]/*' />
    NodeType_EntityReferenceNode = 5,

    /// <include file='NodeType.xml' path='doc/member[@name="NodeType.NodeType_EntityNode"]/*' />
    NodeType_EntityNode = 6,

    /// <include file='NodeType.xml' path='doc/member[@name="NodeType.NodeType_ProcessingInstructionNode"]/*' />
    NodeType_ProcessingInstructionNode = 7,

    /// <include file='NodeType.xml' path='doc/member[@name="NodeType.NodeType_CommentNode"]/*' />
    NodeType_CommentNode = 8,

    /// <include file='NodeType.xml' path='doc/member[@name="NodeType.NodeType_DocumentNode"]/*' />
    NodeType_DocumentNode = 9,

    /// <include file='NodeType.xml' path='doc/member[@name="NodeType.NodeType_DocumentTypeNode"]/*' />
    NodeType_DocumentTypeNode = 10,

    /// <include file='NodeType.xml' path='doc/member[@name="NodeType.NodeType_DocumentFragmentNode"]/*' />
    NodeType_DocumentFragmentNode = 11,

    /// <include file='NodeType.xml' path='doc/member[@name="NodeType.NodeType_NotationNode"]/*' />
    NodeType_NotationNode = 12,
}
