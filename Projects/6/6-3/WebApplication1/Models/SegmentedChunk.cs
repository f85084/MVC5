//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SegmentedChunk
    {
        public System.Guid ChunkId { get; set; }
        public System.Guid SnapshotDataId { get; set; }
        public byte ChunkFlags { get; set; }
        public string ChunkName { get; set; }
        public int ChunkType { get; set; }
        public short Version { get; set; }
        public string MimeType { get; set; }
        public string Machine { get; set; }
        public long SegmentedChunkId { get; set; }
    }
}